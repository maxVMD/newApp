namespace newBook
{
    partial class AddBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_done = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отметитьКакГотовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dill_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1_addbook = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКДиллеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.dateTimePickerNewBook = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_done)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dill_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_addbook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView_done);
            this.groupBox1.Controls.Add(this.dill_dataGridView);
            this.groupBox1.Controls.Add(this.dataGridView1_addbook);
            this.groupBox1.Controls.Add(this.btn_addBook);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbld);
            this.groupBox1.Controls.Add(this.dateTimePickerNewBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 557);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить ноутбук";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выбери диллара затем пустую строку ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(480, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(423, 70);
            this.button1.TabIndex = 12;
            this.button1.Text = "СОХРАНИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_done
            // 
            this.dataGridView_done.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_done.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView_done.Location = new System.Drawing.Point(9, 270);
            this.dataGridView_done.Name = "dataGridView_done";
            this.dataGridView_done.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_done.Size = new System.Drawing.Size(894, 179);
            this.dataGridView_done.TabIndex = 11;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отметитьКакГотовыйToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(208, 26);
            // 
            // отметитьКакГотовыйToolStripMenuItem
            // 
            this.отметитьКакГотовыйToolStripMenuItem.Name = "отметитьКакГотовыйToolStripMenuItem";
            this.отметитьКакГотовыйToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.отметитьКакГотовыйToolStripMenuItem.Text = "Отметить как \"Готовый\"";
            this.отметитьКакГотовыйToolStripMenuItem.Click += new System.EventHandler(this.отметитьКакГотовыйToolStripMenuItem_Click);
            // 
            // dill_dataGridView
            // 
            this.dill_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dill_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dill_dataGridView.Location = new System.Drawing.Point(9, 39);
            this.dill_dataGridView.Name = "dill_dataGridView";
            this.dill_dataGridView.ReadOnly = true;
            this.dill_dataGridView.Size = new System.Drawing.Size(246, 225);
            this.dill_dataGridView.TabIndex = 10;
            // 
            // dataGridView1_addbook
            // 
            this.dataGridView1_addbook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_addbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_addbook.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1_addbook.Location = new System.Drawing.Point(261, 70);
            this.dataGridView1_addbook.Name = "dataGridView1_addbook";
            this.dataGridView1_addbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_addbook.Size = new System.Drawing.Size(642, 194);
            this.dataGridView1_addbook.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКДиллеруToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 26);
            // 
            // добавитьКДиллеруToolStripMenuItem
            // 
            this.добавитьКДиллеруToolStripMenuItem.Name = "добавитьКДиллеруToolStripMenuItem";
            this.добавитьКДиллеруToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.добавитьКДиллеруToolStripMenuItem.Text = "добавить к диллеру";
            this.добавитьКДиллеруToolStripMenuItem.Click += new System.EventHandler(this.добавитьКДиллеруToolStripMenuItem_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addBook.Location = new System.Drawing.Point(9, 481);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(423, 70);
            this.btn_addBook.TabIndex = 8;
            this.btn_addBook.Text = "ДОБАВИТЬ НОУТБУК";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(470, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата постепления";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbld.Location = new System.Drawing.Point(6, 19);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(84, 17);
            this.lbld.TabIndex = 4;
            this.lbld.Text = "Диллеросы";
            // 
            // dateTimePickerNewBook
            // 
            this.dateTimePickerNewBook.Location = new System.Drawing.Point(611, 455);
            this.dateTimePickerNewBook.Name = "dateTimePickerNewBook";
            this.dateTimePickerNewBook.Size = new System.Drawing.Size(292, 20);
            this.dateTimePickerNewBook.TabIndex = 3;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 581);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_done)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dill_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_addbook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewBook;
        public System.Windows.Forms.DataGridView dataGridView1_addbook;
        private System.Windows.Forms.DataGridView dill_dataGridView;
        public System.Windows.Forms.DataGridView dataGridView_done;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКДиллеруToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem отметитьКакГотовыйToolStripMenuItem;
    }
}