using Quiz_Master.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Quiz_Master
{
    enum enPlayingLevel
    {
        Mix=0,
        Easy,
        Medium,
        Hard,
        None
    }
    enum enOperatorType
    {
        Mix,
        Addition,
        Subtraction,
        Multiplication,
        Division,
        None,
    }

    struct stGameStats
    {
        public stRoundStats RoundStats;
        public enOperatorType OperType;
        public enPlayingLevel Level;
        public short TotalWin, TotalFail;
        public short Rounds;
    };
    struct stRoundStats
    {
        public int Number1, Number2, TotalNumbers;
        public bool isWinInRound;
        public short TotalRounds;
        public enOperatorType OperTypeRound;
        public enPlayingLevel LevelRound;
    };

    
    public partial class Quiz_Master : Form
    {
        public Quiz_Master()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        enPlayingLevel playingLevel = enPlayingLevel.None;
        enOperatorType operatorType = enOperatorType.None;
        stGameStats gameStats = new stGameStats();


        Random rnd = new Random();

        char getCharformOperator(enOperatorType Type)
        {
            switch (Type)
            {
                case enOperatorType.Addition:
                   return '+';
                case enOperatorType.Subtraction:
                    return '-';
                case enOperatorType.Multiplication:
                    return '×';
                case enOperatorType.Division:
                    return '/';
                default:
                    return '+';
                    
            }
        }
        void SwapNumbers(ref int N1, ref int N2)
        {
            int NS = N1;
            N1 = N2;
            N2 = NS;
        }
        void SwaprbChoice(ref RadioButton btn1, ref RadioButton btn2)
        {
            RadioButton Swapbtn=btn1;
            btn1 = btn2;
            btn2 = Swapbtn;
        }

        private void ChangeOperatorTypeInGame(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem tool in tsmOperatorType.DropDownItems)
            {
                if (tool.Checked)
                {
                    int Num = Convert.ToInt16(tool.Tag);
                    operatorType = (enOperatorType)Num;
                    break;
                }
            }
        }
        private void ChangeLevelInGame(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem tool in tsmGameLevel.DropDownItems)
            {
                if (tool.Checked)
                {
                    int Num = Convert.ToInt16(tool.Tag);
                    playingLevel = (enPlayingLevel)Num;
                    break;
                }
            }
        }
        private void ChecKChoice_Type(object sender, EventArgs e)
        {
            foreach(ToolStripMenuItem tool in tsmOperatorType.DropDownItems)
            {
                if(tool.Checked)
                {
                    tool.Checked = false;
                }
            }
            ((ToolStripMenuItem)sender).Checked = true;


        }
        private void CheckChoice_Level(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem tool in tsmGameLevel.DropDownItems)
            {
                if (tool.Checked)
                {
                    tool.Checked = false;
                }
            }
            ((ToolStripMenuItem)sender).Checked = true;
        }
        private enOperatorType IsOperatorMix()
        {

            enOperatorType OType = operatorType;
            if (OType == enOperatorType.Mix)
            {
                OType=(enOperatorType)rnd.Next(1,5);
            }
            return OType;

        }
        private enPlayingLevel IsLevelMix()
        {

            enPlayingLevel level = playingLevel;
            if (level == enPlayingLevel.Mix)
            {
                level=(enPlayingLevel)rnd.Next(1,5);
            }
            return level;

        }
        private int GetTotalNumbers(int N1,int N2)
        {
            switch (gameStats.RoundStats.OperTypeRound)
            {
                case enOperatorType.Addition:
                    return (N1+N2);
                case enOperatorType.Subtraction:
                    return (N1-N2);
                case enOperatorType.Multiplication:
                    return (N1*N2);
                case enOperatorType.Division:
                    return (N1/N2);
                default:
                    return 0;

            }
        }

        private void FillrbChoices()
        {
            int RealValue = gameStats.RoundStats.TotalNumbers;
            int ForeignValue2 = rnd.Next(RealValue-3,RealValue+3);
            int ForeignValue3 = rnd.Next(RealValue-3,RealValue+3);

            if (ForeignValue2 == ForeignValue3)
                ForeignValue2++;
            if (ForeignValue2 == RealValue)
                ForeignValue2++;
            if (ForeignValue3 == RealValue)
                ForeignValue3--;

            rbChoice1.Text = RealValue.ToString();
            rbChoice2.Text = ForeignValue2.ToString();
            rbChoice3.Text = ForeignValue3.ToString();

            byte choicenumberToSwap_rbChoice =(byte) rnd.Next(1, 4);
            if (choicenumberToSwap_rbChoice == 1)
                SwaprbChoice(ref rbChoice1, ref rbChoice2);
            else if (choicenumberToSwap_rbChoice == 2)
                SwaprbChoice(ref rbChoice1, ref rbChoice3);
            else
                SwaprbChoice(ref rbChoice2, ref rbChoice3);

        }
        private bool IsCorrectAnswer(int Total, RadioButton rdButtonChoice)
        {
            if (rdButtonChoice.Text == gameStats.RoundStats.TotalNumbers.ToString())
            {
                return true;
            }
            return false;
        }

        private void FillListCheck()
        {
            for (int i=1;i<=gameStats.Rounds;i++)
            {
                ListViewItem Item = new ListViewItem("-"+i.ToString(),1);
                lvQuestion.Items.Add(Item);
            }

        }
        private void GenerateQuestion()
        {
            
            gameStats.RoundStats.LevelRound= IsLevelMix();
            gameStats.RoundStats.OperTypeRound=IsOperatorMix();
           
            switch (gameStats.RoundStats.LevelRound)
            {
                case enPlayingLevel.Easy:
                    gameStats.RoundStats.Number1=rnd.Next(1,21);
                    gameStats.RoundStats.Number2=rnd.Next(1,21);
                    break;
                case enPlayingLevel.Medium:
                    gameStats.RoundStats.Number1=rnd.Next(20,50);
                    gameStats.RoundStats.Number2=rnd.Next(20,50);
                    break;
                case enPlayingLevel.Hard:
                    gameStats.RoundStats.Number1=rnd.Next(50,100);
                    gameStats.RoundStats.Number2=rnd.Next(50,100);
                    break;
            }
            if (gameStats.RoundStats.OperTypeRound == enOperatorType.Division)
            {
                if (gameStats.RoundStats.Number1 < gameStats.RoundStats.Number2)
                {
                    SwapNumbers(ref gameStats.RoundStats.Number1, ref gameStats.RoundStats.Number2);
                }
            }
            gameStats.RoundStats.TotalNumbers = GetTotalNumbers(gameStats.RoundStats.Number1, gameStats.RoundStats.Number2); ;

        }

        void UpdateInfoOnScreen(bool UpdateAll=true)
        {
            if (UpdateAll)
            {

                lblRound.Text = $"Question {gameStats.RoundStats.TotalRounds} of {gameStats.Rounds}";
                lblWin.Text = $"Win(s) : {gameStats.TotalWin}";
                lblFail.Text = $"Fail(s) : {gameStats.TotalFail}";
                FillrbChoices();
                progressBar1.Value = gameStats.RoundStats.TotalRounds;
                lblPercent.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100)+"%";
                lblTypeOperator.Text = $"T/Operator : {operatorType}";
                lblDifficultyLevel.Text = $"D/Level : {playingLevel}";
            }
            else
            {
                lblWin.Text = $"Win(s) : {gameStats.TotalWin}";
                lblFail.Text = $"Fail(s) : {gameStats.TotalFail}";
            }

        }
        void ShowQuestionInScreen()
        {
            if (gameStats.RoundStats.TotalRounds>gameStats.Rounds)
            {
                MessageBox.Show("Click on Settings at the top and Update Amount Round that will play it", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            GenerateQuestion();
            UpdateInfoOnScreen(true);
            lblQuestion.Text = $"What is the result of \n {gameStats.RoundStats.Number1} {getCharformOperator(gameStats.RoundStats.OperTypeRound)} {gameStats.RoundStats.Number2} = ?";

        }
        void StartRound()
        {
            if (playingLevel == enPlayingLevel.None || operatorType == enOperatorType.None|| gameStats.Rounds<=0)
            {
                MessageBox.Show("Click on Settings at the top and choice (Game Level & Operator Type) ", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnStartRound.Enabled = false;
            btnResetRound.Enabled = true;
            tsmOperatorType.Enabled = false;
            tsmGameLevel.Enabled = false;
            tsmamountQuestion.Enabled = false;
            panelRadioButton.Visible = true;
            progressBar1.Maximum = gameStats.Rounds;
            
            foreach (RadioButton rbtn in panelRadioButton.Controls)
            {
                rbtn.Checked = false;
            }
            FillListCheck();
            gameStats.RoundStats.TotalRounds++;
            ShowQuestionInScreen();
        }
        private void StartRound_Click(object sender, EventArgs e)
        {
            StartRound();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            gameStats.RoundStats.TotalRounds++;
            if (gameStats.RoundStats.TotalRounds > gameStats.Rounds)
            {
                MessageBox.Show("You Already Finish Rounds Click on button Reset to start", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnNext.Enabled = false;
                btnCheck.Enabled = false;
                return;
            }
            ResetApparencerbtnChoice();
            btnNext.Enabled = false;
            ShowQuestionInScreen();
        }
        void ResetApparencerbtnChoice()
        {
            foreach (RadioButton rbtn in panelRadioButton.Controls)
            {
                rbtn.BackColor = Color.Transparent;
                rbtn.Checked= false;
                gameStats.RoundStats.isWinInRound=false;
            }
            btnCheck.Enabled = true;
        }
        void ResetGame()
        {
            if(gameStats.Rounds>0)
            {
                if(MessageBox.Show("Are Sure","Notice",MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)==DialogResult.Cancel)
                {
                    return;
                }

            }
            ResetApparencerbtnChoice();
            progressBar1.Maximum = gameStats.Rounds;

            btnNext.Enabled = false;
            btnStartRound.Enabled = true;
            tsmOperatorType.Enabled = true;
            tsmGameLevel.Enabled = true;
            tsmamountQuestion.Enabled =true ;
            panelRadioButton.Visible = false;

            
            gameStats = new stGameStats();
           
            gameStats.OperType = enOperatorType.None;
            gameStats.Level = enPlayingLevel.None;

            gameStats.RoundStats.LevelRound = enPlayingLevel.None;
            gameStats.RoundStats.OperTypeRound = enOperatorType.None;

            UpdateInfoOnScreen();
            lblQuestion.Text = "Question";
            tstbReadAmount.Text = Convert.ToString(0);
            foreach (ToolStripMenuItem tool in tsmOperatorType.DropDownItems)
            {
                if (tool.Checked)
                {
                    tool.Checked = false;
                }
            }
            foreach (ToolStripMenuItem tool in tsmGameLevel.DropDownItems)
            {
                if (tool.Checked)
                {
                    tool.Checked = false;
                }
            }
            tsmNone.Checked = true;
            tsmNoneLevel.Checked = true;
            lvQuestion.Items.Clear();

        }
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void AmountRoundWillPlay(object sender, EventArgs e)
        {
            int Amount=0;
           
           
           bool isTrue = int.TryParse(tstbReadAmount.Text, out Amount);
           if (isTrue)
           {
               gameStats.Rounds = Convert.ToInt16(tstbReadAmount.Text);
           }
           else
            {
                MessageBox.Show("Wrong entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CheckFromChoice()
        {
            if(!rbChoice1.Checked&&!rbChoice2.Checked&&!rbChoice3.Checked)
            {
                MessageBox.Show("Click on Choice","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (RadioButton rbtn in panelRadioButton.Controls)
            {
                if(rbtn.Checked)
                {
                    if(gameStats.RoundStats.isWinInRound = IsCorrectAnswer(gameStats.RoundStats.TotalNumbers, rbtn))
                    {
                        rbtn.BackColor = Color.LightGreen;
                        gameStats.TotalWin++;
                        lvQuestion.Items[gameStats.RoundStats.TotalRounds - 1].ImageIndex = 2;
                    }
                    else 
                    {

                        rbtn.BackColor = Color.Red;
                        lvQuestion.Items[gameStats.RoundStats.TotalRounds - 1].ImageIndex = 0;

                        gameStats.TotalFail++;
                    }
                    UpdateInfoOnScreen(false);
                    break;

                }
            }
            btnCheck.Enabled= false;
            btnNext.Enabled = true;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckFromChoice();
        }

        private void Quiz_Master_Load(object sender, EventArgs e)
        {
            UpdateInfoOnScreen();
        }

        private void btnChangeGame_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle="Soon";
            notifyIcon1.BalloonTipText="Soon will be new games";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void ChangeFormButton(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width+4, ((Button)sender).Height+4);
        }

        private void ResetFormButton(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(((Button)sender).Width - 4, ((Button)sender).Height - 4);

        }
    }
}
