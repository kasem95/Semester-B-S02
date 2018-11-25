using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class Form1 : Form
    {
        public bool start = false;
        public bool X = false;
        public bool O = false;
        public int XS = 0;
        public int OS = 0;
        public bool XWin = false;
        public bool OWin = false;
        public Form1()
        {
            InitializeComponent();
        }


        public void End()
        {
            LUBtn.Text = "";
            CUBtn.Text = "";
            RUBtn.Text = "";
            CLBtn.Text = "";
            CBtn.Text = "";
            RCBtn.Text = "";
            LBBtn.Text = "";
            CBBtn.Text = "";
            RBBtn.Text = "";
            if(X==false&&O==true)
            {
                XS++;
                XScore.Text = XS.ToString();
                XWin = true;
                OWin = false;
            }
            else if(O==false&&X==true)
            {
                OS++;
                OScore1.Text = OS.ToString();
                XWin = false;
                OWin = true;
            }
            if ((XWin == false && OWin == false)|| (XWin == true && OWin == true))
            {
                X = true;
                O = false;
            }
            else
            {
                X = XWin;
                O = OWin;
            }
        }/// <summary>
        /// if one of the players won or draw this function ends the game.
        /// </summary>
        public void DrawCheck()
        {
            if(LUBtn.Text!=""&&CUBtn.Text!=""&&RUBtn.Text!=""&&
               CLBtn.Text!=""&&CBtn.Text!=""&&RCBtn.Text!=""&&
               LBBtn.Text!=""&&CBBtn.Text!=""&&RBBtn.Text!="")
            {
                MessageBox.Show("The game has ended, its a DRAW , last player won will start now!!");
                X = false;
                O = false;
                End();
            }
        }/// <summary>
        /// checks if all the buttons are filled, if yes its ends the game.
        /// </summary>
        


        private void LUBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (LUBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        LUBtn.Text = "X";
                        X = false;
                        O = true;
                        if (CUBtn.Text == "X" && RUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CLBtn.Text == "X" && LBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && RBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                    else if (O == true && X == false)
                    {
                        LUBtn.Text = "O";
                        O = false;
                        X = true;
                        if (CUBtn.Text == "O" && RUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CLBtn.Text == "O" && LBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && RBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
                
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void CUBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (CUBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        CUBtn.Text = "X";
                        X = false;
                        O = true;
                        if (LUBtn.Text == "X" && RUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && CBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                    else if (O == true && X == false)
                    {
                        CUBtn.Text = "O";
                        O = false;
                        X = true;
                        if (LUBtn.Text == "O" && RUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && CBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void RUBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (RUBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        RUBtn.Text = "X";
                        X = false;
                        O = true;
                        if (CUBtn.Text == "X" && LUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (RCBtn.Text == "X" && RBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && LBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                    else if (O == true && X == false)
                    {
                        RUBtn.Text = "O";
                        O = false;
                        X = true;
                        if (CUBtn.Text == "O" && LUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (RCBtn.Text == "O" && RBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && LBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void CLBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (CLBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        CLBtn.Text = "X";
                        X = false;
                        O = true;
                        if (LUBtn.Text == "X" && LBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && RCBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();

                    }
                    else if (O == true && X == false)
                    {
                        CLBtn.Text = "O";
                        O = false;
                        X = true;
                        if (LUBtn.Text == "O" && LBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && RCBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (CBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        CBtn.Text = "X";
                        X = false;
                        O = true;
                        if (CUBtn.Text == "X" && CBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CLBtn.Text == "X" && RCBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (RUBtn.Text == "X" && LBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (LUBtn.Text == "X" && RBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                    else if (O == true && X == false)
                    {
                        CBtn.Text = "O";
                        O = false;
                        X = true;
                        if (CUBtn.Text == "O" && CBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CLBtn.Text == "O" && RCBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (RUBtn.Text == "O" && LBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (LUBtn.Text == "O" && RBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void RCBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (RCBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        RCBtn.Text = "X";
                        X = false;
                        O = true;
                        if (RUBtn.Text == "X" && LBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && CLBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();

                    }
                    else if (O == true && X == false)
                    {
                        RCBtn.Text = "O";
                        O = false;
                        X = true;
                        if (RUBtn.Text == "O" && LBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && CLBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void LBBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (LBBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        LBBtn.Text = "X";
                        X = false;
                        O = true;
                        if (CLBtn.Text == "X" && LUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBBtn.Text == "X" && RBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && RUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                    else if (O == true && X == false)
                    {
                        LBBtn.Text = "O";
                        O = false;
                        X = true;
                        if (CLBtn.Text == "O" && LUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBBtn.Text == "O" && RBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && RUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void CBBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (CBBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        CBBtn.Text = "X";
                        X = false;
                        O = true;
                        if (LBBtn.Text == "X" && RBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && CUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                    else if (O == true && X == false)
                    {
                        CBBtn.Text = "O";
                        O = false;
                        X = true;
                        if (LBBtn.Text == "O" && RBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && CUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void RBBtn_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (RBBtn.Text == "")
                {
                    if (X == true && O == false)
                    {
                        RBBtn.Text = "X";
                        X = false;
                        O = true;
                        if (CBBtn.Text == "X" && LBBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (RCBtn.Text == "X" && RUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "X" && LUBtn.Text == "X")
                        {
                            XWin = true;
                            OWin = false;
                            MessageBox.Show("X Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                    else if (O == true && X == false)
                    {
                        RBBtn.Text = "O";
                        O = false;
                        X = true;
                        if (CBBtn.Text == "O" && LBBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (RCBtn.Text == "O" && RUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        else if (CBtn.Text == "O" && LUBtn.Text == "O")
                        {
                            XWin = false;
                            OWin = true;
                            MessageBox.Show("O Player won!!!!");
                            End();
                        }
                        DrawCheck();
                    }
                }
            }
            else if (start == false)
            {
                MessageBox.Show("You have not started the game yet!");
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                start = true;
                StartBtn.Text = "RESTART";
                MessageBox.Show("Game has started!!, X go first!!");
                X = true;
                O = false;
                XS = 0;
                OS = 0;
                XWin = false;
                OWin = false;
            }
            else if(start == true)
            {
                
                
                LUBtn.Text = "";
                CUBtn.Text = "";
                RUBtn.Text = "";
                CLBtn.Text = "";
                CBtn.Text = "";
                RCBtn.Text = "";
                LBBtn.Text = "";
                CBBtn.Text = "";
                RBBtn.Text = "";
                MessageBox.Show("Game restarted!!, X go first!!");
                XS = 0;
                OS = 0;
                XScore.Text = "0";
                OScore1.Text = "0";
                XWin = false;
                OWin = false;
                X = true;
                O = false;
            }

        }
    }
}
