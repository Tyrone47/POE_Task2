using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameEngine gameEngine = new GameEngine(20, 20, 20, 20, 3, 5);
            txtDisplayGame.Text = gameEngine.ToString();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
