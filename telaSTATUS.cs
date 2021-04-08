using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GNCTAREFAS
{
    public partial class telaSTATUS : Form
    {
        public telaSTATUS()
        {
            InitializeComponent();
        }

        private void statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gNCTAREFASDataSet);

        }

        private void telaSTATUS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gNCTAREFASDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.gNCTAREFASDataSet.Status);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                statusBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(gNCTAREFASDataSet);
                Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
