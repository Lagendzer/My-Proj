namespace heeeeeeeeeeeeeh
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label nameGroupLabel;
            System.Windows.Forms.Label kursLabel;
            System.Windows.Forms.Label kafedraLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.studGroupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studGroupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameGroupTextBox = new System.Windows.Forms.TextBox();
            this.kafedraTextBox = new System.Windows.Forms.TextBox();
            this.kursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.studGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meshcheryakovDataSet = new heeeeeeeeeeeeeh.MeshcheryakovDataSet();
            this.studGroupTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.StudGroupTableAdapter();
            this.tableAdapterManager = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.StudentTableAdapter();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameGroupLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            kafedraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingNavigator)).BeginInit();
            this.studGroupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(157, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица «Группа»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studGroupBindingNavigator
            // 
            this.studGroupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studGroupBindingNavigator.BindingSource = this.studGroupBindingSource;
            this.studGroupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studGroupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studGroupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studGroupBindingNavigatorSaveItem});
            this.studGroupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studGroupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studGroupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studGroupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studGroupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studGroupBindingNavigator.Name = "studGroupBindingNavigator";
            this.studGroupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studGroupBindingNavigator.Size = new System.Drawing.Size(526, 25);
            this.studGroupBindingNavigator.TabIndex = 1;
            this.studGroupBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // studGroupBindingNavigatorSaveItem
            // 
            this.studGroupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studGroupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studGroupBindingNavigatorSaveItem.Image")));
            this.studGroupBindingNavigatorSaveItem.Name = "studGroupBindingNavigatorSaveItem";
            this.studGroupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studGroupBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studGroupBindingNavigatorSaveItem.Click += new System.EventHandler(this.studGroupBindingNavigatorSaveItem_Click);
            // 
            // nameGroupLabel
            // 
            nameGroupLabel.AutoSize = true;
            nameGroupLabel.Location = new System.Drawing.Point(129, 149);
            nameGroupLabel.Name = "nameGroupLabel";
            nameGroupLabel.Size = new System.Drawing.Size(99, 13);
            nameGroupLabel.TabIndex = 2;
            nameGroupLabel.Text = "Название группы:";
            // 
            // nameGroupTextBox
            // 
            this.nameGroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studGroupBindingSource, "NameGroup", true));
            this.nameGroupTextBox.Location = new System.Drawing.Point(234, 146);
            this.nameGroupTextBox.Name = "nameGroupTextBox";
            this.nameGroupTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameGroupTextBox.TabIndex = 3;
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Location = new System.Drawing.Point(194, 187);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(34, 13);
            kursLabel.TabIndex = 4;
            kursLabel.Text = "Курс:";
            kursLabel.Click += new System.EventHandler(this.kursLabel_Click);
            // 
            // kafedraLabel
            // 
            kafedraLabel.AutoSize = true;
            kafedraLabel.Location = new System.Drawing.Point(173, 227);
            kafedraLabel.Name = "kafedraLabel";
            kafedraLabel.Size = new System.Drawing.Size(55, 13);
            kafedraLabel.TabIndex = 6;
            kafedraLabel.Text = "Кафедра:";
            // 
            // kafedraTextBox
            // 
            this.kafedraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studGroupBindingSource, "Kafedra", true));
            this.kafedraTextBox.Location = new System.Drawing.Point(234, 224);
            this.kafedraTextBox.Name = "kafedraTextBox";
            this.kafedraTextBox.Size = new System.Drawing.Size(100, 20);
            this.kafedraTextBox.TabIndex = 7;
            // 
            // kursNumericUpDown
            // 
            this.kursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studGroupBindingSource, "Kurs", true));
            this.kursNumericUpDown.Location = new System.Drawing.Point(234, 185);
            this.kursNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.kursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kursNumericUpDown.Name = "kursNumericUpDown";
            this.kursNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.kursNumericUpDown.TabIndex = 9;
            this.kursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // studGroupBindingSource
            // 
            this.studGroupBindingSource.DataMember = "StudGroup";
            this.studGroupBindingSource.DataSource = this.meshcheryakovDataSet;
            // 
            // meshcheryakovDataSet
            // 
            this.meshcheryakovDataSet.DataSetName = "MeshcheryakovDataSet";
            this.meshcheryakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studGroupTableAdapter
            // 
            this.studGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExamTableAdapter = null;
            this.tableAdapterManager.LecturerTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.StudGroupTableAdapter = this.studGroupTableAdapter;
            this.tableAdapterManager.UpdateOrder = heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "StudGroup_Student";
            this.studentBindingSource.DataSource = this.studGroupBindingSource;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(84, 279);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(300, 220);
            this.studentDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Student";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 511);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.kursNumericUpDown);
            this.Controls.Add(kafedraLabel);
            this.Controls.Add(this.kafedraTextBox);
            this.Controls.Add(kursLabel);
            this.Controls.Add(nameGroupLabel);
            this.Controls.Add(this.nameGroupTextBox);
            this.Controls.Add(this.studGroupBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Таблица «Группа»";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingNavigator)).EndInit();
            this.studGroupBindingNavigator.ResumeLayout(false);
            this.studGroupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MeshcheryakovDataSet meshcheryakovDataSet;
        private System.Windows.Forms.BindingSource studGroupBindingSource;
        private MeshcheryakovDataSetTableAdapters.StudGroupTableAdapter studGroupTableAdapter;
        private MeshcheryakovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studGroupBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studGroupBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameGroupTextBox;
        private System.Windows.Forms.TextBox kafedraTextBox;
        private System.Windows.Forms.NumericUpDown kursNumericUpDown;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MeshcheryakovDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}