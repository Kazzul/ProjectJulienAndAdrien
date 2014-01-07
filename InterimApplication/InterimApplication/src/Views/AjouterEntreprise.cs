using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Controler;
using Model;

namespace InterimApplication.src.Views
{
    public partial class AjouterEntreprise : Form
    {
        private ControlerEntreprisesClientes cC;
        private BindingSource bind;

        public AjouterEntreprise()
        {
            InitializeComponent();
        }

        public AjouterEntreprise(ControlerEntreprisesClientes cec, BindingSource bs)
        {
            InitializeComponent();
            cC = cec;
            bind = bs;
        }

        private void buttonAddCorp_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.TextLength > 0)
            {
                cC.ajouter(new EntrepriseCliente(this.textBoxName.Text, this.textBoxAddress.Text, this.textBoxSiret.Text));
                bind.Add(new EntrepriseCliente(this.textBoxName.Text, this.textBoxAddress.Text, this.textBoxSiret.Text));
                this.Dispose();
            }
        }

        private void AjouterEntreprise_Load(object sender, EventArgs e)
        {

        }
    }
}
