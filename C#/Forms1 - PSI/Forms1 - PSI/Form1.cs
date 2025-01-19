using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms1___PSI
{
    public partial class janela : Form
    {
        public janela()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Verificar se a TextBox está vazia
            if (string.IsNullOrWhiteSpace(txtbNome.Text))
            {
                MessageBox.Show("Por favor, preencha um Nome.");
                return;
            }

            // Verificar se a ComboBox tem uma seleção válida
            if (cbDistrito.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um Distrito.");
                return;
            }


            // Verificar se pelo menos um RadioButton está selecionado
            if (!rbFeminino.Checked && !rbMasculino.Checked)
            {
                MessageBox.Show("Por favor, selecione um sexo.");
                return;
            }

            // Caso todas as verificações sejam bem-sucedidas
            MessageBox.Show("Todos os campos estão válidos!");
        }

    }
}
