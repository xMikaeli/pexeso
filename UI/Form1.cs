using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pexeso.logic;

namespace pexeso.UI
{
    public partial class Form1 : Form
    {
        Hra game = new Hra();
        public Form1()
        {
            InitializeComponent();
        }

        private void HerniPoleInit(){
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<4; j++)
                {
                    tableLayoutPanel1.Controls.Add(new PictureBox() { Image = game.Bars.ElementAt(0).Card.Picture }, i, j);
                }
            }
        }


        
    }
}
