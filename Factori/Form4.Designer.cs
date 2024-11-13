namespace heeeeeeeeeeeeeh
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label id_StudentLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label nameGroupLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label stipLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.meshcheryakovDataSet = new heeeeeeeeeeeeeh.MeshcheryakovDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_StudentTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stipTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.nameGroupComboBox = new System.Windows.Forms.ComboBox();
            this.nameGroupTextBox = new System.Windows.Forms.TextBox();
            this.fKExamStudentID173876EABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.ExamTableAdapter();
            this.studGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studGroupTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.StudGroupTableAdapter();
            this.studGroupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            id_StudentLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            nameGroupLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            stipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKExamStudentID173876EABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(252, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица «Студент»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // meshcheryakovDataSet
            // 
            this.meshcheryakovDataSet.DataSetName = "MeshcheryakovDataSet";
            this.meshcheryakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.meshcheryakovDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExamTableAdapter = this.examTableAdapter;
            this.tableAdapterManager.LecturerTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.StudGroupTableAdapter = this.studGroupTableAdapter;
            this.tableAdapterManager.UpdateOrder = heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.studentBindingNavigator.TabIndex = 2;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // id_StudentLabel
            // 
            id_StudentLabel.AutoSize = true;
            id_StudentLabel.Location = new System.Drawing.Point(285, 143);
            id_StudentLabel.Name = "id_StudentLabel";
            id_StudentLabel.Size = new System.Drawing.Size(44, 13);
            id_StudentLabel.TabIndex = 2;
            id_StudentLabel.Text = "Номер:";
            // 
            // id_StudentTextBox
            // 
            this.id_StudentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Id_Student", true));
            this.id_StudentTextBox.Location = new System.Drawing.Point(335, 140);
            this.id_StudentTextBox.Name = "id_StudentTextBox";
            this.id_StudentTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_StudentTextBox.TabIndex = 3;
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(292, 169);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(37, 13);
            fIOLabel.TabIndex = 4;
            fIOLabel.Text = "ФИО:";
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(335, 166);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(100, 20);
            this.fIOTextBox.TabIndex = 5;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(240, 198);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(89, 13);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Дата рождения:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(335, 192);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.birthdayDateTimePicker.TabIndex = 7;
            // 
            // nameGroupLabel
            // 
            nameGroupLabel.AutoSize = true;
            nameGroupLabel.Location = new System.Drawing.Point(284, 247);
            nameGroupLabel.Name = "nameGroupLabel";
            nameGroupLabel.Size = new System.Drawing.Size(45, 13);
            nameGroupLabel.TabIndex = 8;
            nameGroupLabel.Text = "Группа:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(299, 221);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(30, 13);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Пол:";
            // 
            // stipLabel
            // 
            stipLabel.AutoSize = true;
            stipLabel.Location = new System.Drawing.Point(265, 273);
            stipLabel.Name = "stipLabel";
            stipLabel.Size = new System.Drawing.Size(64, 13);
            stipLabel.TabIndex = 12;
            stipLabel.Text = "Стипендия:";
            // 
            // stipTextBox
            // 
            this.stipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Stip", true));
            this.stipTextBox.Location = new System.Drawing.Point(335, 270);
            this.stipTextBox.Name = "stipTextBox";
            this.stipTextBox.Size = new System.Drawing.Size(100, 20);
            this.stipTextBox.TabIndex = 13;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.genderComboBox.Location = new System.Drawing.Point(335, 217);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 15;
            // 
            // nameGroupComboBox
            // 
            this.nameGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "NameGroup", true));
            this.nameGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studGroupBindingSource, "NameGroup", true));
            this.nameGroupComboBox.DataSource = this.studGroupBindingSource1;
            this.nameGroupComboBox.DisplayMember = "NameGroup";
            this.nameGroupComboBox.FormattingEnabled = true;
            this.nameGroupComboBox.Location = new System.Drawing.Point(441, 243);
            this.nameGroupComboBox.Name = "nameGroupComboBox";
            this.nameGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameGroupComboBox.TabIndex = 16;
            this.nameGroupComboBox.ValueMember = "NameGroup";
            // 
            // nameGroupTextBox
            // 
            this.nameGroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "NameGroup", true));
            this.nameGroupTextBox.Location = new System.Drawing.Point(335, 244);
            this.nameGroupTextBox.Name = "nameGroupTextBox";
            this.nameGroupTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameGroupTextBox.TabIndex = 9;
            // 
            // fKExamStudentID173876EABindingSource
            // 
            this.fKExamStudentID173876EABindingSource.DataMember = "FK__Exam__StudentID__173876EA";
            this.fKExamStudentID173876EABindingSource.DataSource = this.studentBindingSource;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // studGroupBindingSource
            // 
            this.studGroupBindingSource.DataMember = "StudGroup";
            this.studGroupBindingSource.DataSource = this.meshcheryakovDataSet;
            // 
            // studGroupTableAdapter
            // 
            this.studGroupTableAdapter.ClearBeforeFill = true;
            // 
            // studGroupBindingSource1
            // 
            this.studGroupBindingSource1.DataMember = "StudGroup";
            this.studGroupBindingSource1.DataSource = this.meshcheryakovDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameGroupComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(stipLabel);
            this.Controls.Add(this.stipTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(nameGroupLabel);
            this.Controls.Add(this.nameGroupTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(id_StudentLabel);
            this.Controls.Add(this.id_StudentTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "таблица «Студент»";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKExamStudentID173876EABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studGroupBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MeshcheryakovDataSet meshcheryakovDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MeshcheryakovDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private MeshcheryakovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_StudentTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox stipTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox nameGroupComboBox;
        private MeshcheryakovDataSetTableAdapters.ExamTableAdapter examTableAdapter;
        private System.Windows.Forms.TextBox nameGroupTextBox;
        private System.Windows.Forms.BindingSource fKExamStudentID173876EABindingSource;
        private MeshcheryakovDataSetTableAdapters.StudGroupTableAdapter studGroupTableAdapter;
        private System.Windows.Forms.BindingSource studGroupBindingSource;
        private System.Windows.Forms.BindingSource studGroupBindingSource1;
    }
}