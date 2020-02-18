namespace BoatReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumAdults = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtNumChildren = new System.Windows.Forms.TextBox();
            this.btnCheckReserve = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCheckReserve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What type of boat?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "How many adults?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "How many children?";
            // 
            // txtNumAdults
            // 
            this.txtNumAdults.Location = new System.Drawing.Point(327, 120);
            this.txtNumAdults.Name = "txtNumAdults";
            this.txtNumAdults.Size = new System.Drawing.Size(100, 20);
            this.txtNumAdults.TabIndex = 1;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(327, 70);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 0;
            // 
            // txtNumChildren
            // 
            this.txtNumChildren.Location = new System.Drawing.Point(327, 160);
            this.txtNumChildren.Name = "txtNumChildren";
            this.txtNumChildren.Size = new System.Drawing.Size(100, 20);
            this.txtNumChildren.TabIndex = 2;
            // 
            // btnCheckReserve
            // 
            this.btnCheckReserve.Location = new System.Drawing.Point(121, 228);
            this.btnCheckReserve.Name = "btnCheckReserve";
            this.btnCheckReserve.Size = new System.Drawing.Size(136, 23);
            this.btnCheckReserve.TabIndex = 6;
            this.btnCheckReserve.Text = "Check reservation";
            this.btnCheckReserve.UseVisualStyleBackColor = true;
            this.btnCheckReserve.Click += new System.EventHandler(this.btnCheckReserve_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(121, 283);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 7;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(257, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(475, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCheckReserve
            // 
            this.lblCheckReserve.AutoSize = true;
            this.lblCheckReserve.Location = new System.Drawing.Point(392, 233);
            this.lblCheckReserve.Name = "lblCheckReserve";
            this.lblCheckReserve.Padding = new System.Windows.Forms.Padding(10);
            this.lblCheckReserve.Size = new System.Drawing.Size(20, 33);
            this.lblCheckReserve.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCheckReserve);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnCheckReserve);
            this.Controls.Add(this.txtNumChildren);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtNumAdults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rental Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumAdults;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtNumChildren;
        private System.Windows.Forms.Button btnCheckReserve;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCheckReserve;
    }
}

