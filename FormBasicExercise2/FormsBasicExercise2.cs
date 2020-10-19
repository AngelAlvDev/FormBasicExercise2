using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBasicExercise2
{
    public partial class FormsBasicExercise2 : Form
    {
        public FormsBasicExercise2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double primer_numero = Convert.ToDouble(textBox1.Text);
            Double segundo_numero = Convert.ToDouble(textBox2.Text);
            label4.Text = Convert.ToString(primer_numero + segundo_numero);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }
    }
}
