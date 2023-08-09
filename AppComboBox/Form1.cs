using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            //Adiciona itens ao combo
            cboLista.Items.Add(txtTexto.Text);

            //Conta o numero de itens do combo
            lblQtde.Text = cboLista.Items.Count.ToString();

            //Limpa a caixa de texto
            txtTexto.Clear();

            //Muda o foco para a caixa de texto
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(cboLista.SelectedIndex != -1)
            {
                //Remove item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);

                //Exibe a quantia de itens do combobox
                lblQtde.Text = cboLista.Items.Count.ToString();

                //Limpa o texto do combo
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            {
                //Ixibe o indice
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                //Exibir indice do item do combo
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }
        }
    }
}
