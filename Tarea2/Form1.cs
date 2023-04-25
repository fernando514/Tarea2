using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal n1;
            decimal n2;
            decimal n3;
            decimal n4;

            n1 = decimal.Parse(nota1textBox.Text);
            n2 = decimal.Parse(nota2textBox.Text);
            n3 = decimal.Parse(nota3textBox.Text);  
            n4 = decimal.Parse(nota4textBox.Text);

            decimal Promedio = await PromedioAsync(n1, n2, n3, n4);

            MessageBox.Show("El promedio final es:" + Promedio);




        }

        public async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            var ResultadoPromedio = await Task.Run (() =>
                
            {
                return ((n1 + n2 + n3 + n4)/4);
            }
            );
            return ResultadoPromedio;
        }


    }
}
