
namespace GNCTAREFAS
{
    partial class telaRESPONSAVEL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idResponsavelLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaRESPONSAVEL));
            this.gNCTAREFASDataSet = new GNCTAREFAS.GNCTAREFASDataSet();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new GNCTAREFAS.GNCTAREFASDataSetTableAdapters.ResponsavelTableAdapter();
            this.tableAdapterManager = new GNCTAREFAS.GNCTAREFASDataSetTableAdapters.TableAdapterManager();
            this.responsavelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.responsavelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idResponsavelLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idResponsavelLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gNCTAREFASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingNavigator)).BeginInit();
            this.responsavelBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idResponsavelLabel
            // 
            idResponsavelLabel.AutoSize = true;
            idResponsavelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            idResponsavelLabel.Location = new System.Drawing.Point(85, 56);
            idResponsavelLabel.Name = "idResponsavelLabel";
            idResponsavelLabel.Size = new System.Drawing.Size(72, 13);
            idResponsavelLabel.TabIndex = 1;
            idResponsavelLabel.Text = "Responsavel:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeLabel.Location = new System.Drawing.Point(85, 85);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // gNCTAREFASDataSet
            // 
            this.gNCTAREFASDataSet.DataSetName = "GNCTAREFASDataSet";
            this.gNCTAREFASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "Responsavel";
            this.responsavelBindingSource.DataSource = this.gNCTAREFASDataSet;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ResponsavelTableAdapter = this.responsavelTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GNCTAREFAS.GNCTAREFASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // responsavelBindingNavigator
            // 
            this.responsavelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.responsavelBindingNavigator.BindingSource = this.responsavelBindingSource;
            this.responsavelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.responsavelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.responsavelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.responsavelBindingNavigatorSaveItem});
            this.responsavelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.responsavelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.responsavelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.responsavelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.responsavelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.responsavelBindingNavigator.Name = "responsavelBindingNavigator";
            this.responsavelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.responsavelBindingNavigator.Size = new System.Drawing.Size(409, 25);
            this.responsavelBindingNavigator.TabIndex = 0;
            this.responsavelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // responsavelBindingNavigatorSaveItem
            // 
            this.responsavelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.responsavelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("responsavelBindingNavigatorSaveItem.Image")));
            this.responsavelBindingNavigatorSaveItem.Name = "responsavelBindingNavigatorSaveItem";
            this.responsavelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.responsavelBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.responsavelBindingNavigatorSaveItem.Click += new System.EventHandler(this.responsavelBindingNavigatorSaveItem_Click);
            // 
            // idResponsavelLabel1
            // 
            this.idResponsavelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsavelBindingSource, "IdResponsavel", true));
            this.idResponsavelLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idResponsavelLabel1.Location = new System.Drawing.Point(175, 56);
            this.idResponsavelLabel1.Name = "idResponsavelLabel1";
            this.idResponsavelLabel1.Size = new System.Drawing.Size(100, 23);
            this.idResponsavelLabel1.TabIndex = 2;
            this.idResponsavelLabel1.Text = "label1";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responsavelBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(175, 82);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(135, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telaRESPONSAVEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(409, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(idResponsavelLabel);
            this.Controls.Add(this.idResponsavelLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.responsavelBindingNavigator);
            this.Name = "telaRESPONSAVEL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Responsavel";
            this.Load += new System.EventHandler(this.telaRESPONSAVEL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gNCTAREFASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingNavigator)).EndInit();
            this.responsavelBindingNavigator.ResumeLayout(false);
            this.responsavelBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GNCTAREFASDataSet gNCTAREFASDataSet;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private GNCTAREFASDataSetTableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private GNCTAREFASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator responsavelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton responsavelBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idResponsavelLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button button1;
    }
}