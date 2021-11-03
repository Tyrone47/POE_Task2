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
            for (int i = 0; i < this.gameEngine.GetMap().GetEnemyArray().Length; i++)
            {
                txtEnemyStats.Text += this.gameEngine.GetMap().GetEnemyArray()[i].ToString() + System.Environment.NewLine;
            }
             
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            this.gameEngine.MovePlayer(MovementEnum.UP);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();

           
            
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.DOWN);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();

            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.LEFT);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.gameEngine.MovePlayer(MovementEnum.RIGHT);
            this.gameEngine.MoveEnemies();
            txtDisplayGame.Text = gameEngine.ToString();
            txtPlayerStats.Text = gameEngine.GetMap().GetHero().ToString();
        }

        
    }
}
