namespace WindowsFormsApp1
{
    partial class FormRequest
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
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label climateTechTypeLabel;
            System.Windows.Forms.Label climateTechModelLabel;
            System.Windows.Forms.Label problemDescryptionLabel;
            System.Windows.Forms.Label requestStatusLabel;
            System.Windows.Forms.Label completionDateLabel;
            System.Windows.Forms.Label repairPartsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequest));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.demooDataSet = new WindowsFormsApp1.demooDataSet();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new WindowsFormsApp1.demooDataSetTableAdapters.ЗаявкиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.demooDataSetTableAdapters.TableAdapterManager();
            this.заявкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.заявкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.заявкиDataGridView = new System.Windows.Forms.DataGridView();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.climateTechTypeTextBox = new System.Windows.Forms.TextBox();
            this.climateTechModelTextBox = new System.Windows.Forms.TextBox();
            this.problemDescryptionTextBox = new System.Windows.Forms.TextBox();
            this.requestStatusTextBox = new System.Windows.Forms.TextBox();
            this.completionDateTextBox = new System.Windows.Forms.TextBox();
            this.repairPartsTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            startDateLabel = new System.Windows.Forms.Label();
            climateTechTypeLabel = new System.Windows.Forms.Label();
            climateTechModelLabel = new System.Windows.Forms.Label();
            problemDescryptionLabel = new System.Windows.Forms.Label();
            requestStatusLabel = new System.Windows.Forms.Label();
            completionDateLabel = new System.Windows.Forms.Label();
            repairPartsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.demooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingNavigator)).BeginInit();
            this.заявкиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(80, 314);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(56, 13);
            startDateLabel.TabIndex = 6;
            startDateLabel.Text = "start Date:";
            // 
            // climateTechTypeLabel
            // 
            climateTechTypeLabel.AutoSize = true;
            climateTechTypeLabel.Location = new System.Drawing.Point(80, 340);
            climateTechTypeLabel.Name = "climateTechTypeLabel";
            climateTechTypeLabel.Size = new System.Drawing.Size(98, 13);
            climateTechTypeLabel.TabIndex = 8;
            climateTechTypeLabel.Text = "climate Tech Type:";
            // 
            // climateTechModelLabel
            // 
            climateTechModelLabel.AutoSize = true;
            climateTechModelLabel.Location = new System.Drawing.Point(80, 366);
            climateTechModelLabel.Name = "climateTechModelLabel";
            climateTechModelLabel.Size = new System.Drawing.Size(103, 13);
            climateTechModelLabel.TabIndex = 10;
            climateTechModelLabel.Text = "climate Tech Model:";
            // 
            // problemDescryptionLabel
            // 
            problemDescryptionLabel.AutoSize = true;
            problemDescryptionLabel.Location = new System.Drawing.Point(80, 392);
            problemDescryptionLabel.Name = "problemDescryptionLabel";
            problemDescryptionLabel.Size = new System.Drawing.Size(106, 13);
            problemDescryptionLabel.TabIndex = 12;
            problemDescryptionLabel.Text = "problem Descryption:";
            // 
            // requestStatusLabel
            // 
            requestStatusLabel.AutoSize = true;
            requestStatusLabel.Location = new System.Drawing.Point(80, 418);
            requestStatusLabel.Name = "requestStatusLabel";
            requestStatusLabel.Size = new System.Drawing.Size(78, 13);
            requestStatusLabel.TabIndex = 14;
            requestStatusLabel.Text = "request Status:";
            // 
            // completionDateLabel
            // 
            completionDateLabel.AutoSize = true;
            completionDateLabel.Location = new System.Drawing.Point(80, 444);
            completionDateLabel.Name = "completionDateLabel";
            completionDateLabel.Size = new System.Drawing.Size(87, 13);
            completionDateLabel.TabIndex = 16;
            completionDateLabel.Text = "completion Date:";
            // 
            // repairPartsLabel
            // 
            repairPartsLabel.AutoSize = true;
            repairPartsLabel.Location = new System.Drawing.Point(80, 470);
            repairPartsLabel.Name = "repairPartsLabel";
            repairPartsLabel.Size = new System.Drawing.Size(63, 13);
            repairPartsLabel.TabIndex = 18;
            repairPartsLabel.Text = "repair Parts:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Клиенты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(691, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Комментарии";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // demooDataSet
            // 
            this.demooDataSet.DataSetName = "demooDataSet";
            this.demooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.demooDataSet;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.demooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = this.заявкиTableAdapter;
            this.tableAdapterManager.комментыTableAdapter = null;
            // 
            // заявкиBindingNavigator
            // 
            this.заявкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заявкиBindingNavigator.BindingSource = this.заявкиBindingSource;
            this.заявкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заявкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заявкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заявкиBindingNavigatorSaveItem});
            this.заявкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заявкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заявкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заявкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заявкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заявкиBindingNavigator.Name = "заявкиBindingNavigator";
            this.заявкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заявкиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.заявкиBindingNavigator.TabIndex = 2;
            this.заявкиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заявкиBindingNavigatorSaveItem
            // 
            this.заявкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заявкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заявкиBindingNavigatorSaveItem.Image")));
            this.заявкиBindingNavigatorSaveItem.Name = "заявкиBindingNavigatorSaveItem";
            this.заявкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заявкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заявкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.заявкиBindingNavigatorSaveItem_Click);
            // 
            // заявкиDataGridView
            // 
            this.заявкиDataGridView.AutoGenerateColumns = false;
            this.заявкиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заявкиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.заявкиDataGridView.DataSource = this.заявкиBindingSource;
            this.заявкиDataGridView.Location = new System.Drawing.Point(38, 40);
            this.заявкиDataGridView.Name = "заявкиDataGridView";
            this.заявкиDataGridView.Size = new System.Drawing.Size(457, 220);
            this.заявкиDataGridView.TabIndex = 3;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "startDate", true));
            this.startDateTextBox.Location = new System.Drawing.Point(192, 311);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDateTextBox.TabIndex = 7;
            this.startDateTextBox.TextChanged += new System.EventHandler(this.startDateTextBox_TextChanged);
            // 
            // climateTechTypeTextBox
            // 
            this.climateTechTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "climateTechType", true));
            this.climateTechTypeTextBox.Location = new System.Drawing.Point(192, 337);
            this.climateTechTypeTextBox.Name = "climateTechTypeTextBox";
            this.climateTechTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.climateTechTypeTextBox.TabIndex = 9;
            this.climateTechTypeTextBox.TextChanged += new System.EventHandler(this.climateTechTypeTextBox_TextChanged);
            // 
            // climateTechModelTextBox
            // 
            this.climateTechModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "climateTechModel", true));
            this.climateTechModelTextBox.Location = new System.Drawing.Point(192, 363);
            this.climateTechModelTextBox.Name = "climateTechModelTextBox";
            this.climateTechModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.climateTechModelTextBox.TabIndex = 11;
            this.climateTechModelTextBox.TextChanged += new System.EventHandler(this.climateTechModelTextBox_TextChanged);
            // 
            // problemDescryptionTextBox
            // 
            this.problemDescryptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "problemDescryption", true));
            this.problemDescryptionTextBox.Location = new System.Drawing.Point(192, 389);
            this.problemDescryptionTextBox.Name = "problemDescryptionTextBox";
            this.problemDescryptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.problemDescryptionTextBox.TabIndex = 13;
            this.problemDescryptionTextBox.TextChanged += new System.EventHandler(this.problemDescryptionTextBox_TextChanged);
            // 
            // requestStatusTextBox
            // 
            this.requestStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "requestStatus", true));
            this.requestStatusTextBox.Location = new System.Drawing.Point(192, 415);
            this.requestStatusTextBox.Name = "requestStatusTextBox";
            this.requestStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestStatusTextBox.TabIndex = 15;
            this.requestStatusTextBox.TextChanged += new System.EventHandler(this.requestStatusTextBox_TextChanged);
            // 
            // completionDateTextBox
            // 
            this.completionDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "completionDate", true));
            this.completionDateTextBox.Location = new System.Drawing.Point(192, 441);
            this.completionDateTextBox.Name = "completionDateTextBox";
            this.completionDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.completionDateTextBox.TabIndex = 17;
            this.completionDateTextBox.TextChanged += new System.EventHandler(this.completionDateTextBox_TextChanged);
            // 
            // repairPartsTextBox
            // 
            this.repairPartsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "repairParts", true));
            this.repairPartsTextBox.Location = new System.Drawing.Point(192, 467);
            this.repairPartsTextBox.Name = "repairPartsTextBox";
            this.repairPartsTextBox.Size = new System.Drawing.Size(100, 20);
            this.repairPartsTextBox.TabIndex = 19;
            this.repairPartsTextBox.TextChanged += new System.EventHandler(this.repairPartsTextBox_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(550, 218);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 36;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Создать запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "startDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "startDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "climateTechType";
            this.dataGridViewTextBoxColumn3.HeaderText = "climateTechType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "climateTechModel";
            this.dataGridViewTextBoxColumn4.HeaderText = "climateTechModel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "problemDescryption";
            this.dataGridViewTextBoxColumn5.HeaderText = "problemDescryption";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "requestStatus";
            this.dataGridViewTextBoxColumn6.HeaderText = "requestStatus";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "completionDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "completionDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "repairParts";
            this.dataGridViewTextBoxColumn8.HeaderText = "repairParts";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(climateTechTypeLabel);
            this.Controls.Add(this.climateTechTypeTextBox);
            this.Controls.Add(climateTechModelLabel);
            this.Controls.Add(this.climateTechModelTextBox);
            this.Controls.Add(problemDescryptionLabel);
            this.Controls.Add(this.problemDescryptionTextBox);
            this.Controls.Add(requestStatusLabel);
            this.Controls.Add(this.requestStatusTextBox);
            this.Controls.Add(completionDateLabel);
            this.Controls.Add(this.completionDateTextBox);
            this.Controls.Add(repairPartsLabel);
            this.Controls.Add(this.repairPartsTextBox);
            this.Controls.Add(this.заявкиDataGridView);
            this.Controls.Add(this.заявкиBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormRequest";
            this.Text = "FormRequest";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingNavigator)).EndInit();
            this.заявкиBindingNavigator.ResumeLayout(false);
            this.заявкиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private demooDataSet demooDataSet;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private demooDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private demooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заявкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заявкиBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView заявкиDataGridView;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox climateTechTypeTextBox;
        private System.Windows.Forms.TextBox climateTechModelTextBox;
        private System.Windows.Forms.TextBox problemDescryptionTextBox;
        private System.Windows.Forms.TextBox requestStatusTextBox;
        private System.Windows.Forms.TextBox completionDateTextBox;
        private System.Windows.Forms.TextBox repairPartsTextBox;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}