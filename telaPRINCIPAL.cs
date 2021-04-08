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
    public partial class telaPRINCIPAL : Form
    {
        public telaPRINCIPAL()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            telaSTATUS telastatus = new telaSTATUS();
            telastatus.ShowDialog();
        }

        private void telaPRINCIPAL_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gNCTAREFASDataSet.SelectQueryDados'. Você pode movê-la ou removê-la conforme necessário.
            this.selectQueryDadosTableAdapter.Fill(this.gNCTAREFASDataSet.SelectQueryDados);
            // TODO: esta linha de código carrega dados na tabela 'gNCTAREFASDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.gNCTAREFASDataSet.Tarefa);



        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaTAREFA telatarefa = new telaTAREFA();
            telatarefa.ShowDialog();
            this.tarefaTableAdapter.Fill(this.gNCTAREFASDataSet.Tarefa);
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            telaRESPONSAVEL telaresponsavel = new telaRESPONSAVEL();
            telaresponsavel.ShowDialog();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gNCTAREFASDataSet);

        }
    }
}
