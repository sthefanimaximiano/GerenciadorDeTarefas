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
    public partial class telaTAREFA : Form
    {
        public telaTAREFA()
        {
            InitializeComponent();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gNCTAREFASDataSet);

        }

        private void telaTAREFA_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gNCTAREFASDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.gNCTAREFASDataSet.Responsavel);
            // TODO: esta linha de código carrega dados na tabela 'gNCTAREFASDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.gNCTAREFASDataSet.Status);
            // TODO: esta linha de código carrega dados na tabela 'gNCTAREFASDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.gNCTAREFASDataSet.Tarefa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            
            
            try
            {
                tarefaBindingSource.EndEdit();
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
