using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao
{
    public partial class Divisão : Form
    {
        public Divisão()
        {
            InitializeComponent();
        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_Valor1.Text);
                int b = Convert.ToInt32(tx_Valor2.Text);
                int c = a / b;
                MessageBox.Show(c.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao dividir");
            }
            finally
            {
                MessageBox.Show("Vai executar independente se der certo.");
            }
            
        }
    }
}
