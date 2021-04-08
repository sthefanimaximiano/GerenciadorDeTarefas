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
    public partial class telaRESPONSAVEL : Form
    {
        public telaRESPONSAVEL()
        {
            InitializeComponent();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gNCTAREFASDataSet);

        }

        private void telaRESPONSAVEL_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gNCTAREFASDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.gNCTAREFASDataSet.Responsavel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                responsavelBindingSource.EndEdit();
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
