using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterimApplication.src.Views
{
    public partial class MainInterimApp : Form
    {
        public MainInterimApp()
        {
            InitializeComponent();
        }

        private void buttonGestionEntreprisesClientes_Click(object sender, EventArgs e)
        {
            EntreprisesClientesManager frame = new EntreprisesClientesManager();
            this.AddOwnedForm(frame);
            frame.Activate();
            frame.Show();
        }
    }
}
