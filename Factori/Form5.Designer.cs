namespace heeeeeeeeeeeeeh
{
    partial class Form5
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
            System.Windows.Forms.Label id_StudentLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label markLabel;
            System.Windows.Forms.Label exam_DateLabel;
            System.Windows.Forms.Label id_LectLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.meshcheryakovDataSet = new heeeeeeeeeeeeeh.MeshcheryakovDataSet();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.ExamTableAdapter();
            this.tableAdapterManager = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager();
            this.lecturerTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.LecturerTableAdapter();
            this.studentTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.StudentTableAdapter();
            this.examBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.examBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.exam_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_StudentComboBox = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            id_StudentLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            markLabel = new System.Windows.Forms.Label();
            exam_DateLabel = new System.Windows.Forms.Label();
            id_LectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingNavigator)).BeginInit();
            this.examBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_StudentLabel
            // 
            id_StudentLabel.AutoSize = true;
            id_StudentLabel.Location = new System.Drawing.Point(80, 121);
            id_StudentLabel.Name = "id_StudentLabel";
            id_StudentLabel.Size = new System.Drawing.Size(92, 13);
            id_StudentLabel.TabIndex = 3;
            id_StudentLabel.Text = "Номер студента:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(117, 147);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(55, 13);
            subjectLabel.TabIndex = 4;
            subjectLabel.Text = "Предмет:";
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new System.Drawing.Point(125, 179);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(48, 13);
            markLabel.TabIndex = 6;
            markLabel.Text = "Оценка:";
            // 
            // exam_DateLabel
            // 
            exam_DateLabel.AutoSize = true;
            exam_DateLabel.Location = new System.Drawing.Point(83, 208);
            exam_DateLabel.Name = "exam_DateLabel";
            exam_DateLabel.Size = new System.Drawing.Size(89, 13);
            exam_DateLabel.TabIndex = 8;
            exam_DateLabel.Text = "Дата экзамена:";
            // 
            // id_LectLabel
            // 
            id_LectLabel.AutoSize = true;
            id_LectLabel.Location = new System.Drawing.Point(94, 231);
            id_LectLabel.Name = "id_LectLabel";
            id_LectLabel.Size = new System.Drawing.Size(78, 13);
            id_LectLabel.TabIndex = 10;
            id_LectLabel.Text = "Экзаменатор:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(103, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица «Экзамен»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // meshcheryakovDataSet
            // 
            this.meshcheryakovDataSet.DataSetName = "MeshcheryakovDataSet";
            this.meshcheryakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "Exam";
            this.examBindingSource.DataSource = this.meshcheryakovDataSet;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExamTableAdapter = this.examTableAdapter;
            this.tableAdapterManager.LecturerTableAdapter = this.lecturerTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.StudGroupTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // examBindingNavigator
            // 
            this.examBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.examBindingNavigator.BindingSource = this.examBindingSource;
            this.examBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.examBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.examBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.examBindingNavigatorSaveItem});
            this.examBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.examBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.examBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.examBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.examBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.examBindingNavigator.Name = "examBindingNavigator";
            this.examBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.examBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.examBindingNavigator.TabIndex = 3;
            this.examBindingNavigator.Text = "bindingNavigator1";
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
            // examBindingNavigatorSaveItem
            // 
            this.examBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("examBindingNavigatorSaveItem.Image")));
            this.examBindingNavigatorSaveItem.Name = "examBindingNavigatorSaveItem";
            this.examBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.examBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.examBindingNavigatorSaveItem.Click += new System.EventHandler(this.examBindingNavigatorSaveItem_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(178, 144);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextBox.TabIndex = 5;
            // 
            // markTextBox
            // 
            this.markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource, "Mark", true));
            this.markTextBox.Location = new System.Drawing.Point(178, 176);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(100, 20);
            this.markTextBox.TabIndex = 7;
            // 
            // exam_DateDateTimePicker
            // 
            this.exam_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.examBindingSource, "Exam_Date", true));
            this.exam_DateDateTimePicker.Location = new System.Drawing.Point(178, 202);
            this.exam_DateDateTimePicker.Name = "exam_DateDateTimePicker";
            this.exam_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.exam_DateDateTimePicker.TabIndex = 9;
            // 
            // id_StudentComboBox
            // 
            this.id_StudentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource, "Id_Student", true));
            this.id_StudentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.examBindingSource, "Id_Student", true));
            this.id_StudentComboBox.DataSource = this.studentBindingSource;
            this.id_StudentComboBox.DisplayMember = "Id_Student";
            this.id_StudentComboBox.FormattingEnabled = true;
            this.id_StudentComboBox.Location = new System.Drawing.Point(178, 117);
            this.id_StudentComboBox.Name = "id_StudentComboBox";
            this.id_StudentComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_StudentComboBox.TabIndex = 13;
            this.id_StudentComboBox.ValueMember = "Id_Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.meshcheryakovDataSet;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.meshcheryakovDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(218, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(330, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(218, 390);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.examBindingSource, "Id_Lect", true));
            this.comboBox1.DataSource = this.lecturerBindingSource;
            this.comboBox1.DisplayMember = "FIO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Id_Lect";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_StudentComboBox);
            this.Controls.Add(id_LectLabel);
            this.Controls.Add(exam_DateLabel);
            this.Controls.Add(this.exam_DateDateTimePicker);
            this.Controls.Add(markLabel);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(id_StudentLabel);
            this.Controls.Add(this.examBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Таблица \"Экзамен\"";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingNavigator)).EndInit();
            this.examBindingNavigator.ResumeLayout(false);
            this.examBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MeshcheryakovDataSet meshcheryakovDataSet;
        private System.Windows.Forms.BindingSource examBindingSource;
        private MeshcheryakovDataSetTableAdapters.ExamTableAdapter examTableAdapter;
        private MeshcheryakovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator examBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton examBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.DateTimePicker exam_DateDateTimePicker;
        private MeshcheryakovDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ComboBox id_StudentComboBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MeshcheryakovDataSetTableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}