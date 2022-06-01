using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        int XorO = 0;
        int turn_XorO = 1;
        bool turn = true; //true = X and false = 0 

        public Form1()
        {
            InitializeComponent();
        }

        private void Mec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-tac-toe is a game for two players, X and O, who take turns marking the spaces in a 3×3 grid. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game.");
        }

        private void Res_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Ex_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void playerbutton_click(object sender, EventArgs e)
        {
            Button playerbutton = (Button)sender;
            if (turn)
            {
                playerbutton.Text = "X"; //First player
            }
            else
            {
                playerbutton.Text = "O";// Second player
            }
                
            turn = !turn;//this switches turns of players
            turn_XorO++;

            playerbutton.Enabled = false;// The button will not change after clicking

            playerbutton.BackColor = Color.PaleVioletRed;
        
        }
    }

}
    
