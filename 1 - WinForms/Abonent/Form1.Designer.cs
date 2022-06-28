namespace Abonent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.executorsGV = new System.Windows.Forms.DataGridView();
            this.abonentsGV = new System.Windows.Forms.DataGridView();
            this.requestsGV = new System.Windows.Forms.DataGridView();
            this.executorStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonentStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.requestsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.executorsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGV)).BeginInit();
            this.executorStrip.SuspendLayout();
            this.abonentStrip.SuspendLayout();
            this.requestsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // executorsGV
            // 
            this.executorsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.executorsGV.Location = new System.Drawing.Point(12, 12);
            this.executorsGV.Name = "executorsGV";
            this.executorsGV.Size = new System.Drawing.Size(416, 487);
            this.executorsGV.TabIndex = 0;
            // 
            // abonentsGV
            // 
            this.abonentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonentsGV.Location = new System.Drawing.Point(434, 12);
            this.abonentsGV.Name = "abonentsGV";
            this.abonentsGV.Size = new System.Drawing.Size(416, 487);
            this.abonentsGV.TabIndex = 1;
            // 
            // requestsGV
            // 
            this.requestsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsGV.Location = new System.Drawing.Point(856, 12);
            this.requestsGV.Name = "requestsGV";
            this.requestsGV.Size = new System.Drawing.Size(416, 487);
            this.requestsGV.TabIndex = 2;
            // 
            // executorStrip
            // 
            this.executorStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.executorStrip.Name = "ExecutorStrip";
            this.executorStrip.Size = new System.Drawing.Size(129, 70);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // abonentStrip
            // 
            this.abonentStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.добавитьToolStripMenuItem1});
            this.abonentStrip.Name = "abonentStrip";
            this.abonentStrip.Size = new System.Drawing.Size(129, 70);
            // 
            // requestsStrip
            // 
            this.requestsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem2,
            this.изменитьToolStripMenuItem2,
            this.добавитьToolStripMenuItem2});
            this.requestsStrip.Name = "requestsStrip";
            this.requestsStrip.Size = new System.Drawing.Size(181, 92);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 511);
            this.Controls.Add(this.requestsGV);
            this.Controls.Add(this.abonentsGV);
            this.Controls.Add(this.executorsGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.executorsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonentsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGV)).EndInit();
            this.executorStrip.ResumeLayout(false);
            this.abonentStrip.ResumeLayout(false);
            this.requestsStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView executorsGV;
        public System.Windows.Forms.DataGridView abonentsGV;
        public System.Windows.Forms.DataGridView requestsGV;
        public System.Windows.Forms.ContextMenuStrip executorStrip;
        public System.Windows.Forms.ContextMenuStrip abonentStrip;
        public System.Windows.Forms.ContextMenuStrip requestsStrip;
        public System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
    }
}

