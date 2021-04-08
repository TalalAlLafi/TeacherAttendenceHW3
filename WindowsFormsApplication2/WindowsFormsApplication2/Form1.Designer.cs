namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.Windows.Forms.Label courseNameLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label dateeLabel;
            System.Windows.Forms.Label staettaimeLabel;
            System.Windows.Forms.Label learntaimeLabel;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label teacherNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new WindowsFormsApplication2.ado.DataSet1();
            this.attendaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendaseTableAdapter = new WindowsFormsApplication2.ado.DataSet1TableAdapters.attendaseTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.ado.DataSet1TableAdapters.TableAdapterManager();
            this.courseTableAdapter = new WindowsFormsApplication2.ado.DataSet1TableAdapters.courseTableAdapter();
            this.attendaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.attendaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attendaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseNameComboBox = new System.Windows.Forms.ComboBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.dateeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.staettaimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.learntaimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new WindowsFormsApplication2.ado.DataSet1TableAdapters.roomTableAdapter();
            this.roomNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new WindowsFormsApplication2.ado.DataSet1TableAdapters.teacherTableAdapter();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            courseNameLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            dateeLabel = new System.Windows.Forms.Label();
            staettaimeLabel = new System.Windows.Forms.Label();
            learntaimeLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            teacherNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendaseBindingNavigator)).BeginInit();
            this.attendaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new System.Drawing.Point(8, 139);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new System.Drawing.Size(71, 13);
            courseNameLabel.TabIndex = 2;
            courseNameLabel.Text = "Course Name";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(8, 172);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(52, 13);
            commentLabel.TabIndex = 4;
            commentLabel.Text = "Comment";
            // 
            // dateeLabel
            // 
            dateeLabel.AutoSize = true;
            dateeLabel.Location = new System.Drawing.Point(14, 202);
            dateeLabel.Name = "dateeLabel";
            dateeLabel.Size = new System.Drawing.Size(30, 13);
            dateeLabel.TabIndex = 6;
            dateeLabel.Text = "Date";
            // 
            // staettaimeLabel
            // 
            staettaimeLabel.AutoSize = true;
            staettaimeLabel.Location = new System.Drawing.Point(343, 116);
            staettaimeLabel.Name = "staettaimeLabel";
            staettaimeLabel.Size = new System.Drawing.Size(56, 13);
            staettaimeLabel.TabIndex = 9;
            staettaimeLabel.Text = "Start Time";
            // 
            // learntaimeLabel
            // 
            learntaimeLabel.AutoSize = true;
            learntaimeLabel.Location = new System.Drawing.Point(344, 144);
            learntaimeLabel.Name = "learntaimeLabel";
            learntaimeLabel.Size = new System.Drawing.Size(59, 13);
            learntaimeLabel.TabIndex = 11;
            learntaimeLabel.Text = "Learn Time";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(344, 173);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(64, 13);
            roomNameLabel.TabIndex = 13;
            roomNameLabel.Text = "Room Name";
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(344, 202);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(76, 13);
            teacherNameLabel.TabIndex = 15;
            teacherNameLabel.Text = "Teacher Name";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendaseBindingSource
            // 
            this.attendaseBindingSource.DataMember = "attendase";
            this.attendaseBindingSource.DataSource = this.dataSet1;
            // 
            // attendaseTableAdapter
            // 
            this.attendaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendaseTableAdapter = this.attendaseTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.roomTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.ado.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // attendaseBindingNavigator
            // 
            this.attendaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attendaseBindingNavigator.BindingSource = this.attendaseBindingSource;
            this.attendaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attendaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attendaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.attendaseBindingNavigatorSaveItem});
            this.attendaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attendaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendaseBindingNavigator.Name = "attendaseBindingNavigator";
            this.attendaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attendaseBindingNavigator.Size = new System.Drawing.Size(773, 25);
            this.attendaseBindingNavigator.TabIndex = 0;
            this.attendaseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // attendaseBindingNavigatorSaveItem
            // 
            this.attendaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attendaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attendaseBindingNavigatorSaveItem.Image")));
            this.attendaseBindingNavigatorSaveItem.Name = "attendaseBindingNavigatorSaveItem";
            this.attendaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.attendaseBindingNavigatorSaveItem.Text = "Save Data";
            this.attendaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.attendaseBindingNavigatorSaveItem_Click);
            // 
            // attendaseDataGridView
            // 
            this.attendaseDataGridView.AutoGenerateColumns = false;
            this.attendaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.attendaseDataGridView.DataSource = this.attendaseBindingSource;
            this.attendaseDataGridView.Location = new System.Drawing.Point(0, 237);
            this.attendaseDataGridView.Name = "attendaseDataGridView";
            this.attendaseDataGridView.Size = new System.Drawing.Size(753, 173);
            this.attendaseDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "attendaseid";
            this.dataGridViewTextBoxColumn1.HeaderText = "attendaseid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datee";
            this.dataGridViewTextBoxColumn2.HeaderText = "datee";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "staettaime";
            this.dataGridViewTextBoxColumn3.HeaderText = "staettaime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "learntaime";
            this.dataGridViewTextBoxColumn4.HeaderText = "learntaime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn5.HeaderText = "comment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "teachername";
            this.dataGridViewTextBoxColumn6.HeaderText = "teachername";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "coursename";
            this.dataGridViewTextBoxColumn7.HeaderText = "coursename";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "roomname";
            this.dataGridViewTextBoxColumn8.HeaderText = "roomname";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.dataSet1;
            // 
            // courseNameComboBox
            // 
            this.courseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "courseName", true));
            this.courseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendaseBindingSource, "coursename", true));
            this.courseNameComboBox.DataSource = this.courseBindingSource;
            this.courseNameComboBox.DisplayMember = "courseName";
            this.courseNameComboBox.FormattingEnabled = true;
            this.courseNameComboBox.Location = new System.Drawing.Point(87, 136);
            this.courseNameComboBox.Name = "courseNameComboBox";
            this.courseNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.courseNameComboBox.TabIndex = 3;
            this.courseNameComboBox.ValueMember = "courseName";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendaseBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(87, 169);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 20);
            this.commentTextBox.TabIndex = 5;
            // 
            // dateeDateTimePicker
            // 
            this.dateeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendaseBindingSource, "datee", true));
            this.dateeDateTimePicker.Location = new System.Drawing.Point(87, 199);
            this.dateeDateTimePicker.Name = "dateeDateTimePicker";
            this.dateeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateeDateTimePicker.TabIndex = 7;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.courseBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 25);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(773, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(69, 22);
            this.bindingNavigatorAddNewItem1.Text = "add course";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // staettaimeDateTimePicker
            // 
            this.staettaimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendaseBindingSource, "staettaime", true));
            this.staettaimeDateTimePicker.Location = new System.Drawing.Point(428, 109);
            this.staettaimeDateTimePicker.Name = "staettaimeDateTimePicker";
            this.staettaimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.staettaimeDateTimePicker.TabIndex = 10;
            // 
            // learntaimeDateTimePicker
            // 
            this.learntaimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendaseBindingSource, "learntaime", true));
            this.learntaimeDateTimePicker.Location = new System.Drawing.Point(428, 139);
            this.learntaimeDateTimePicker.Name = "learntaimeDateTimePicker";
            this.learntaimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.learntaimeDateTimePicker.TabIndex = 12;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "room";
            this.roomBindingSource.DataSource = this.dataSet1;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomNameComboBox
            // 
            this.roomNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "roomName", true));
            this.roomNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendaseBindingSource, "roomname", true));
            this.roomNameComboBox.DataSource = this.roomBindingSource;
            this.roomNameComboBox.DisplayMember = "roomName";
            this.roomNameComboBox.FormattingEnabled = true;
            this.roomNameComboBox.Location = new System.Drawing.Point(428, 169);
            this.roomNameComboBox.Name = "roomNameComboBox";
            this.roomNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.roomNameComboBox.TabIndex = 14;
            this.roomNameComboBox.ValueMember = "roomName";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.dataSet1;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "teacherName", true));
            this.teacherNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendaseBindingSource, "teachername", true));
            this.teacherNameComboBox.DataSource = this.teacherBindingSource;
            this.teacherNameComboBox.DisplayMember = "teacherName";
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(428, 199);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.teacherNameComboBox.TabIndex = 16;
            this.teacherNameComboBox.ValueMember = "teacherName";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator2.BindingSource = this.roomBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 50);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(773, 25);
            this.bindingNavigator2.TabIndex = 17;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(63, 22);
            this.bindingNavigatorAddNewItem2.Text = "add room";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator3.BindingSource = this.teacherBindingSource;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 75);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(773, 25);
            this.bindingNavigator3.TabIndex = 18;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(73, 22);
            this.bindingNavigatorAddNewItem3.Text = "add teacher";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Delete";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 430);
            this.Controls.Add(this.bindingNavigator3);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(teacherNameLabel);
            this.Controls.Add(this.teacherNameComboBox);
            this.Controls.Add(roomNameLabel);
            this.Controls.Add(this.roomNameComboBox);
            this.Controls.Add(learntaimeLabel);
            this.Controls.Add(this.learntaimeDateTimePicker);
            this.Controls.Add(staettaimeLabel);
            this.Controls.Add(this.staettaimeDateTimePicker);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(dateeLabel);
            this.Controls.Add(this.dateeDateTimePicker);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(courseNameLabel);
            this.Controls.Add(this.courseNameComboBox);
            this.Controls.Add(this.attendaseDataGridView);
            this.Controls.Add(this.attendaseBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendaseBindingNavigator)).EndInit();
            this.attendaseBindingNavigator.ResumeLayout(false);
            this.attendaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ado.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource attendaseBindingSource;
        private ado.DataSet1TableAdapters.attendaseTableAdapter attendaseTableAdapter;
        private ado.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attendaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton attendaseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attendaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private ado.DataSet1TableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.ComboBox courseNameComboBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker dateeDateTimePicker;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.DateTimePicker staettaimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker learntaimeDateTimePicker;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private ado.DataSet1TableAdapters.roomTableAdapter roomTableAdapter;
        private System.Windows.Forms.ComboBox roomNameComboBox;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private ado.DataSet1TableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
    }
}

