namespace Abonent
{
    partial class RequestForm
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
            this.IDtb = new System.Windows.Forms.TextBox();
            this.accountCDtb = new System.Windows.Forms.TextBox();
            this.executorCDtb = new System.Windows.Forms.TextBox();
            this.failrueCDtb = new System.Windows.Forms.TextBox();
            this.incomingDatedp = new System.Windows.Forms.DateTimePicker();
            this.executionDatedp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.clientError = new System.Windows.Forms.Label();
            this.failrueError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDtb
            // 
            this.IDtb.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.IDtb.Enabled = false;
            this.IDtb.ForeColor = System.Drawing.SystemColors.Menu;
            this.IDtb.Location = new System.Drawing.Point(178, 12);
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(309, 20);
            this.IDtb.TabIndex = 0;
            // 
            // accountCDtb
            // 
            this.accountCDtb.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.accountCDtb.ForeColor = System.Drawing.SystemColors.Menu;
            this.accountCDtb.Location = new System.Drawing.Point(178, 55);
            this.accountCDtb.Name = "accountCDtb";
            this.accountCDtb.Size = new System.Drawing.Size(309, 20);
            this.accountCDtb.TabIndex = 1;
            // 
            // executorCDtb
            // 
            this.executorCDtb.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.executorCDtb.ForeColor = System.Drawing.SystemColors.Menu;
            this.executorCDtb.Location = new System.Drawing.Point(178, 97);
            this.executorCDtb.Name = "executorCDtb";
            this.executorCDtb.Size = new System.Drawing.Size(309, 20);
            this.executorCDtb.TabIndex = 2;
            // 
            // failrueCDtb
            // 
            this.failrueCDtb.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.failrueCDtb.ForeColor = System.Drawing.SystemColors.Menu;
            this.failrueCDtb.Location = new System.Drawing.Point(178, 138);
            this.failrueCDtb.Name = "failrueCDtb";
            this.failrueCDtb.Size = new System.Drawing.Size(309, 20);
            this.failrueCDtb.TabIndex = 3;
            // 
            // incomingDatedp
            // 
            this.incomingDatedp.Location = new System.Drawing.Point(178, 178);
            this.incomingDatedp.Name = "incomingDatedp";
            this.incomingDatedp.Size = new System.Drawing.Size(309, 20);
            this.incomingDatedp.TabIndex = 4;
            // 
            // executionDatedp
            // 
            this.executionDatedp.Location = new System.Drawing.Point(178, 218);
            this.executionDatedp.Name = "executionDatedp";
            this.executionDatedp.Size = new System.Drawing.Size(309, 20);
            this.executionDatedp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Слесарь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Неисправность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата поступления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата выполнения";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(178, 257);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(15, 14);
            this.check.TabIndex = 12;
            this.check.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Выполнено";
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(395, 268);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(92, 28);
            this.DoneBtn.TabIndex = 14;
            this.DoneBtn.Text = "Готово";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // clientError
            // 
            this.clientError.AutoSize = true;
            this.clientError.ForeColor = System.Drawing.Color.Red;
            this.clientError.Location = new System.Drawing.Point(178, 78);
            this.clientError.Name = "clientError";
            this.clientError.Size = new System.Drawing.Size(172, 13);
            this.clientError.TabIndex = 15;
            this.clientError.Text = "Это поле не может быть пустым";
            this.clientError.Visible = false;
            // 
            // failrueError
            // 
            this.failrueError.AutoSize = true;
            this.failrueError.ForeColor = System.Drawing.Color.Red;
            this.failrueError.Location = new System.Drawing.Point(178, 161);
            this.failrueError.Name = "failrueError";
            this.failrueError.Size = new System.Drawing.Size(172, 13);
            this.failrueError.TabIndex = 16;
            this.failrueError.Text = "Это поле не может быть пустым";
            this.failrueError.Visible = false;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(499, 308);
            this.Controls.Add(this.failrueError);
            this.Controls.Add(this.clientError);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.executionDatedp);
            this.Controls.Add(this.incomingDatedp);
            this.Controls.Add(this.failrueCDtb);
            this.Controls.Add(this.executorCDtb);
            this.Controls.Add(this.accountCDtb);
            this.Controls.Add(this.IDtb);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox IDtb;
        public System.Windows.Forms.TextBox accountCDtb;
        public System.Windows.Forms.TextBox executorCDtb;
        public System.Windows.Forms.TextBox failrueCDtb;
        public System.Windows.Forms.DateTimePicker incomingDatedp;
        public System.Windows.Forms.DateTimePicker executionDatedp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Label clientError;
        private System.Windows.Forms.Label failrueError;
    }
}