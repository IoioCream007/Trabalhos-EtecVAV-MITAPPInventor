using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hot_dog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            string pedido = "Seu pedido:\n";

            // PÃO
            if (checkBox1.Checked)
                pedido += "- Pão: Quatro Queijos\n";
            if (checkBox2.Checked)
                pedido += "- Pão: Alho\n";
            if (checkBox3.Checked)
                pedido += "- Pão: De Leite\n";
            if (checkBox4.Checked)
                pedido += "- Pão: Tradicional\n";

            // MOLHOS
            if (checkBox5.Checked)
                pedido += "- Ketchup\n";
            if (checkBox6.Checked)
                pedido += "- Mostarda\n";
            if (checkBox7.Checked)
                pedido += "- Maionese\n";
            if (checkBox8.Checked)
                pedido += "- Molho da casa\n";

            // ACOMPANHAMENTOS
            if (checkBox9.Checked)
                pedido += "- Batata Frita\n";
            if (checkBox10.Checked)
                pedido += "- Nuggets\n";
            if (checkBox11.Checked)
                pedido += "- Torresmo\n";
            if (checkBox12.Checked)
                pedido += "- Onion Rings\n";

            // SALSICHA
            if (checkBox13.Checked)
                pedido += "- 1 Salsicha\n";
            if (checkBox14.Checked)
                pedido += "- 2 Salsichas\n";
            if (checkBox15.Checked)
                pedido += "- 3 Salsichas\n";
            if (checkBox16.Checked)
                pedido += "- 4 Salsichas\n";

            // EXTRAS
            if (checkBox17.Checked)
                pedido += "- Bacon\n";
            if (checkBox18.Checked)
                pedido += "- Calabresa\n";
            if (checkBox19.Checked)
                pedido += "- Milho\n";
            if (checkBox20.Checked)
                pedido += "- Purê\n";

            // Mostrar resultado
            MessageBox.Show(pedido);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

