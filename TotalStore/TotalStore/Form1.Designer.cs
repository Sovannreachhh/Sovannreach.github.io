namespace TotalStore
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalResult = new System.Windows.Forms.TextBox();
            this.txtShowEnter = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "P.name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "P.Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "P.QTY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "TotalResult";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(232, 149);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(208, 20);
            this.txtQTY.TabIndex = 5;
            this.txtQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQTY_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(232, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(208, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtTotalResult
            // 
            this.txtTotalResult.Location = new System.Drawing.Point(232, 260);
            this.txtTotalResult.Name = "txtTotalResult";
            this.txtTotalResult.Size = new System.Drawing.Size(208, 20);
            this.txtTotalResult.TabIndex = 7;
            // 
            // txtShowEnter
            // 
            this.txtShowEnter.Location = new System.Drawing.Point(418, 308);
            this.txtShowEnter.Name = "txtShowEnter";
            this.txtShowEnter.Size = new System.Drawing.Size(94, 37);
            this.txtShowEnter.TabIndex = 8;
            this.txtShowEnter.Text = "Show Enter";
            this.txtShowEnter.UseVisualStyleBackColor = true;
            this.txtShowEnter.Click += new System.EventHandler(this.txtShowEnter_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(307, 308);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 37);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Enter";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtShowEnter);
            this.Controls.Add(this.txtTotalResult);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalResult;
        private System.Windows.Forms.Button txtShowEnter;
        private System.Windows.Forms.Button btnShow;
    }
}

