using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_GUI_Demo
{
    
    public partial class frm_HangmanDemo : Form
    {
        int Increment = 0;
        Image[] HangMen = {
                              Properties.Resources.Hangman_0,
                              Properties.Resources.Hangman_1,
                              Properties.Resources.Hangman_2,
                              Properties.Resources.Hangman_3,
                              Properties.Resources.Hangman_4,
                              Properties.Resources.Hangman_5,
                              Properties.Resources.Hangman_6,
                          };
        public frm_HangmanDemo()
        {
            InitializeComponent();
            MessageBox.Show("Welcome To My Demo GUI");
            btn_Revive.Visible = false;
        }

        private void Prg_Game_Click(object sender, EventArgs e)
        {

        }


        private void Tmr_Demo_Tick(object sender, EventArgs e)
        {
            {
                btn_Revive.Visible = false;
                if (Increment < 7)
                {
                    pic_Hangman.Image = HangMen[Increment];
                    Prg_Game.Value = (Increment);
                    Increment = Increment + 1;
                }
                else
                {
                    btn_Revive.Visible = true;
                    Increment = 0;
                }
            }
        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            txt_Word.Text = "****";
            btn_demo.Visible = false;
            Tmr_Demo.Start();
            txt_UsedLetters.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
        }

        private void txt_UsedLetters_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
