using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_baby.Location = new Point(659, 83);
            BabyRusza();
        }
        private void BabyRusza()
        {
            btn_baby.Enabled = true;
            Stopwatch stopwatch = new Stopwatch();
            int x = 658;
            while (x > 0)
            {
                btn_baby.Location = new Point(x, 83);
                x = x - 5;
                stopwatch.Start();
                while (stopwatch.ElapsedMilliseconds < 400)
                {
                    
                }
                ChwilaPrzerwy();
                stopwatch.Reset();
            }
        }

        private void ChwilaPrzerwy()
        {

        }
        private void btn_baby_Click(object sender, EventArgs e)
        {
            btn_baby.Location = new Point(659, 83);
        }
    }
}
