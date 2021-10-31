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
        private GameEngine gameEngine;

        public Form1()
        {
            InitializeComponent();
           /* this.gameEngine = new GameEngine(20, 20, 20, 20, 3, 5);
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.gameEngine = new GameEngine(20, 20, 20, 20, 3, 5);
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            this.gameEngine.MovePlayer(MovementEnum.UP);
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();

        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.DOWN);
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.LEFT);
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.RIGHT);
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        
    }
}
