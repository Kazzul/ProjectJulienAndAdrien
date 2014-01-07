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
    public partial class EntreprisesClientesManager : Form
    {
        protected ControlerEntreprisesClientes cC = new ControlerEntreprisesClientes();
        protected BindingSource bindingSources = new BindingSource();


        public EntreprisesClientesManager()
        {
            InitializeComponent();
        }

        private void EntreprisesClientesManager_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = true;
            foreach (EntrepriseCliente el in cC.lister())
            {
                bindingSources.Add(el);
            }
            dataGridView1.DataSource = bindingSources;
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterEntreprise frame = new AjouterEntreprise(cC, bindingSources);
            this.AddOwnedForm(frame);
            frame.Activate();
            frame.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    cC.supprimer((EntrepriseCliente)row.DataBoundItem);
                    bindingSources.Remove(row.DataBoundItem);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox) sender;
            IEnumerable<int> Cells = FindCellsWithText(dataGridView1,text.Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
                if (Cells.Contains(row.Index))
                {
                    row.Selected = true;
                }
            }     
        }

        private static IEnumerable<int> FindCellsWithText(DataGridView dgv, string searchText)
        {
            return
                from DataGridViewRow row in dgv.Rows
                from DataGridViewColumn column in dgv.Columns
                let cell = row.Cells[column.Index]
                where cell.Value != null && cell.Value.ToString().Contains(searchText)
                select cell.RowIndex;
        }
    }
}

/*
private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
{
 *         //private bool isLoad = false;
if ((isLoad == true) && (dataGridView1.CurrentCell.IsInEditMode))
{
    dataGridView1.BeginEdit(true);
    Console.WriteLine("Row Validating !" + dataGridView1.Rows[e.RowIndex].ToString() );
    EntrepriseCliente myEntr = (EntrepriseCliente)bindingSources[e.RowIndex];
    Console.WriteLine("Entreprise : " + myEntr.ToString());

    foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
    {
        Console.WriteLine("Celle edition : " + cell.IsInEditMode);
    }

    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
    {
        myEntr.nom = dataGridView1.Rows[e.RowIndex].Cells[1].Value as string;
    }
    if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
    {
        myEntr.adresse = dataGridView1.Rows[e.RowIndex].Cells[2].Value as string;
    }
    if (dataGridView1.Rows[e.RowIndex].Cells[3].Value != null)
    {
        myEntr.numSiret = dataGridView1.Rows[e.RowIndex].Cells[3].Value as string;
    }
    dataGridView1.EndEdit(DataGridViewDataErrorContexts.Commit);
}         dataGridView1.Rows[2].SetValues
}

private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
{
if (dataGridView1.CurrentCell.Value != null)
{
    Console.WriteLine("Cell val ! ");
    EntrepriseCliente myEntr = (EntrepriseCliente)bindingSources[e.RowIndex];
    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
    {
        myEntr.nom = dataGridView1.Rows[e.RowIndex].Cells[1].Value as string;
    }
    if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
    {
        myEntr.adresse = dataGridView1.Rows[e.RowIndex].Cells[2].Value as string;
    }
    if (dataGridView1.Rows[e.RowIndex].Cells[3].Value != null)
    {
        myEntr.numSiret = dataGridView1.Rows[e.RowIndex].Cells[3].Value as string;
    }
    bindingSources.Add(myEntr);
}
        
}*/