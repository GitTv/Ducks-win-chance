using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ducks
{
    public partial class Form1 : Form
    {
        int _chance = 0;
        int _chance2 = 0;
        int _beurd = 1;
        bool _price = false;
        int _duck1 = 0;
        int _duck2 = 0;
        int _duck3 = 0;
        int _duck4 = 0;
       

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomDuck();
            lbDuck1.Text = _duck1.ToString();
            lbDuck2.Text = _duck2.ToString();
            lbDuck3.Text = _duck3.ToString();
            lbDuck4.Text = _duck4.ToString();
        }
        public void Play()
        {
            _beurd++;

        }
        public void RandomDuck()
        {
            Random random1 = new Random();
            int randomNumber1 = random1.Next(1, 14);
            _duck1 = randomNumber1;

            Random random2 = new Random();
            int randomNumber2 = random1.Next(1, 14);
            _duck2 = randomNumber2;

            Random random3 = new Random();
            int randomNumber3 = random1.Next(1, 14);
            _duck3 = randomNumber3;

            Random random4 = new Random();
            int randomNumber4 = random1.Next(1, 14);
            _duck4 = randomNumber4;
        }
    }
}
