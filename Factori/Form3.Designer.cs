namespace heeeeeeeeeeeeeh
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label id_LectLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label stageLabel;
            System.Windows.Forms.Label kafedraLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.meshcheryakovDataSet = new heeeeeeeeeeeeeh.MeshcheryakovDataSet();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTableAdapter = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.LecturerTableAdapter();
            this.tableAdapterManager = new heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager();
            this.lecturerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lecturerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_LectTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.stageTextBox = new System.Windows.Forms.TextBox();
            this.kafedraTextBox = new System.Windows.Forms.TextBox();
            id_LectLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            stageLabel = new System.Windows.Forms.Label();
            kafedraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingNavigator)).BeginInit();
            this.lecturerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(293, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица «Лектор»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // meshcheryakovDataSet
            // 
            this.meshcheryakovDataSet.DataSetName = "MeshcheryakovDataSet";
            this.meshcheryakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.meshcheryakovDataSet;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExamTableAdapter = null;
            this.tableAdapterManager.LecturerTableAdapter = this.lecturerTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.StudGroupTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = heeeeeeeeeeeeeh.MeshcheryakovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lecturerBindingNavigator
            // 
            this.lecturerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lecturerBindingNavigator.BindingSource = this.lecturerBindingSource;
            this.lecturerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lecturerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lecturerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lecturerBindingNavigatorSaveItem});
            this.lecturerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lecturerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lecturerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lecturerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lecturerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lecturerBindingNavigator.Name = "lecturerBindingNavigator";
            this.lecturerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lecturerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.lecturerBindingNavigator.TabIndex = 2;
            this.lecturerBindingNavigator.Text = "bindingNavigator1";
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
            // lecturerBindingNavigatorSaveItem
            // 
            this.lecturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lecturerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lecturerBindingNavigatorSaveItem.Image")));
            this.lecturerBindingNavigatorSaveItem.Name = "lecturerBindingNavigatorSaveItem";
            this.lecturerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lecturerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.lecturerBindingNavigatorSaveItem.Click += new System.EventHandler(this.lecturerBindingNavigatorSaveItem_Click);
            // 
            // id_LectLabel
            // 
            id_LectLabel.AutoSize = true;
            id_LectLabel.Location = new System.Drawing.Point(319, 197);
            id_LectLabel.Name = "id_LectLabel";
            id_LectLabel.Size = new System.Drawing.Size(44, 13);
            id_LectLabel.TabIndex = 2;
            id_LectLabel.Text = "Номер:";
            // 
            // id_LectTextBox
            // 
            this.id_LectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "Id_Lect", true));
            this.id_LectTextBox.Location = new System.Drawing.Point(369, 194);
            this.id_LectTextBox.Name = "id_LectTextBox";
            this.id_LectTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_LectTextBox.TabIndex = 3;
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(326, 223);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(37, 13);
            fIOLabel.TabIndex = 4;
            fIOLabel.Text = "ФИО:";
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(369, 220);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(100, 20);
            this.fIOTextBox.TabIndex = 5;
            // 
            // stageLabel
            // 
            stageLabel.AutoSize = true;
            stageLabel.Location = new System.Drawing.Point(328, 249);
            stageLabel.Name = "stageLabel";
            stageLabel.Size = new System.Drawing.Size(36, 13);
            stageLabel.TabIndex = 6;
            stageLabel.Text = "Стаж:";
            // 
            // stageTextBox
            // 
            this.stageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "Stage", true));
            this.stageTextBox.Location = new System.Drawing.Point(370, 246);
            this.stageTextBox.Name = "stageTextBox";
            this.stageTextBox.Size = new System.Drawing.Size(100, 20);
            this.stageTextBox.TabIndex = 7;
            // 
            // kafedraLabel
            // 
            kafedraLabel.AutoSize = true;
            kafedraLabel.Location = new System.Drawing.Point(309, 275);
            kafedraLabel.Name = "kafedraLabel";
            kafedraLabel.Size = new System.Drawing.Size(55, 13);
            kafedraLabel.TabIndex = 8;
            kafedraLabel.Text = "Кафедра:";
            // 
            // kafedraTextBox
            // 
            this.kafedraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "Kafedra", true));
            this.kafedraTextBox.Location = new System.Drawing.Point(370, 272);
            this.kafedraTextBox.Name = "kafedraTextBox";
            this.kafedraTextBox.Size = new System.Drawing.Size(100, 20);
            this.kafedraTextBox.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(kafedraLabel);
            this.Controls.Add(this.kafedraTextBox);
            this.Controls.Add(stageLabel);
            this.Controls.Add(this.stageTextBox);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(id_LectLabel);
            this.Controls.Add(this.id_LectTextBox);
            this.Controls.Add(this.lecturerBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Таблица «Лектор»";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meshcheryakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingNavigator)).EndInit();
            this.lecturerBindingNavigator.ResumeLayout(false);
            this.lecturerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MeshcheryakovDataSet meshcheryakovDataSet;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private MeshcheryakovDataSetTableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private MeshcheryakovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lecturerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lecturerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_LectTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox stageTextBox;
        private System.Windows.Forms.TextBox kafedraTextBox;
    }
}