namespace BDMiTalller
{
    partial class Agregar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_cliente));
            System.Windows.Forms.Label rFCLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label domiciloLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            this.dataEmpl = new BDMiTalller.DataEmpl();
            this.eMPLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLTableAdapter = new BDMiTalller.DataEmplTableAdapters.EMPLTableAdapter();
            this.tableAdapterManager = new BDMiTalller.DataEmplTableAdapters.TableAdapterManager();
            this.eMPLBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.eMPLBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clietDataGridView = new System.Windows.Forms.DataGridView();
            this.rFCTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.domiciloTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataClient = new BDMiTalller.DataClient();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clietTableAdapter = new BDMiTalller.DataClientTableAdapters.ClietTableAdapter();
            this.tableAdapterManager1 = new BDMiTalller.DataClientTableAdapters.TableAdapterManager();
            rFCLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            domiciloLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLBindingNavigator)).BeginInit();
            this.eMPLBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clietDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEmpl
            // 
            this.dataEmpl.DataSetName = "DataEmpl";
            this.dataEmpl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLBindingSource
            // 
            this.eMPLBindingSource.DataMember = "EMPL";
            this.eMPLBindingSource.DataSource = this.dataEmpl;
            // 
            // eMPLTableAdapter
            // 
            this.eMPLTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EMPLTableAdapter = this.eMPLTableAdapter;
            this.tableAdapterManager.UpdateOrder = BDMiTalller.DataEmplTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLBindingNavigator
            // 
            this.eMPLBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eMPLBindingNavigator.BindingSource = this.eMPLBindingSource;
            this.eMPLBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eMPLBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eMPLBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.eMPLBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eMPLBindingNavigatorSaveItem});
            this.eMPLBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eMPLBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eMPLBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eMPLBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eMPLBindingNavigator.Name = "eMPLBindingNavigator";
            this.eMPLBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eMPLBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.eMPLBindingNavigator.TabIndex = 0;
            this.eMPLBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // eMPLBindingNavigatorSaveItem
            // 
            this.eMPLBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLBindingNavigatorSaveItem.Image")));
            this.eMPLBindingNavigatorSaveItem.Name = "eMPLBindingNavigatorSaveItem";
            this.eMPLBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.eMPLBindingNavigatorSaveItem.Text = "Guardar datos";
            this.eMPLBindingNavigatorSaveItem.Click += new System.EventHandler(this.eMPLBindingNavigatorSaveItem_Click);
            // 
            // clietDataGridView
            // 
            this.clietDataGridView.AutoGenerateColumns = false;
            this.clietDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clietDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clietDataGridView.DataSource = this.clietBindingSource;
            this.clietDataGridView.Location = new System.Drawing.Point(358, 139);
            this.clietDataGridView.Name = "clietDataGridView";
            this.clietDataGridView.RowHeadersWidth = 51;
            this.clietDataGridView.RowTemplate.Height = 24;
            this.clietDataGridView.Size = new System.Drawing.Size(430, 220);
            this.clietDataGridView.TabIndex = 1;
            // 
            // rFCLabel
            // 
            rFCLabel.AutoSize = true;
            rFCLabel.Location = new System.Drawing.Point(37, 145);
            rFCLabel.Name = "rFCLabel";
            rFCLabel.Size = new System.Drawing.Size(39, 17);
            rFCLabel.TabIndex = 2;
            rFCLabel.Text = "RFC:";
            // 
            // rFCTextBox
            // 
            this.rFCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clietBindingSource, "RFC", true));
            this.rFCTextBox.Location = new System.Drawing.Point(111, 142);
            this.rFCTextBox.Name = "rFCTextBox";
            this.rFCTextBox.Size = new System.Drawing.Size(225, 22);
            this.rFCTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(37, 173);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clietBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(111, 170);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(225, 22);
            this.nombreTextBox.TabIndex = 5;
            // 
            // domiciloLabel
            // 
            domiciloLabel.AutoSize = true;
            domiciloLabel.Location = new System.Drawing.Point(37, 201);
            domiciloLabel.Name = "domiciloLabel";
            domiciloLabel.Size = new System.Drawing.Size(65, 17);
            domiciloLabel.TabIndex = 6;
            domiciloLabel.Text = "Domicilo:";
            // 
            // domiciloTextBox
            // 
            this.domiciloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clietBindingSource, "Domicilo", true));
            this.domiciloTextBox.Location = new System.Drawing.Point(111, 198);
            this.domiciloTextBox.Name = "domiciloTextBox";
            this.domiciloTextBox.Size = new System.Drawing.Size(225, 22);
            this.domiciloTextBox.TabIndex = 7;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(37, 229);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(68, 17);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clietBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(111, 226);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(225, 22);
            this.telefonoTextBox.TabIndex = 9;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(37, 257);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(55, 17);
            correoLabel.TabIndex = 10;
            correoLabel.Text = "Correo:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clietBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(111, 254);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(225, 22);
            this.correoTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(187, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // clietBindingSource
            // 
            this.clietBindingSource.DataMember = "Cliet";
            this.clietBindingSource.DataSource = this.dataClient;
            // 
            // dataClient
            // 
            this.dataClient.DataSetName = "DataClient";
            this.dataClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RFC";
            this.dataGridViewTextBoxColumn1.HeaderText = "RFC";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Domicilo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Domicilo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // clietTableAdapter
            // 
            this.clietTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClietTableAdapter = this.clietTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BDMiTalller.DataClientTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Agregar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(rFCLabel);
            this.Controls.Add(this.rFCTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(domiciloLabel);
            this.Controls.Add(this.domiciloTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.clietDataGridView);
            this.Controls.Add(this.eMPLBindingNavigator);
            this.Name = "Agregar_cliente";
            this.Text = "Agregar_cliente";
            this.Load += new System.EventHandler(this.Agregar_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLBindingNavigator)).EndInit();
            this.eMPLBindingNavigator.ResumeLayout(false);
            this.eMPLBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clietDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataEmpl dataEmpl;
        private System.Windows.Forms.BindingSource eMPLBindingSource;
        private DataEmplTableAdapters.EMPLTableAdapter eMPLTableAdapter;
        private DataEmplTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eMPLBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eMPLBindingNavigatorSaveItem;
        private DataClient dataClient;
        private System.Windows.Forms.BindingSource clietBindingSource;
        private DataClientTableAdapters.ClietTableAdapter clietTableAdapter;
        private DataClientTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView clietDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox rFCTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox domiciloTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}