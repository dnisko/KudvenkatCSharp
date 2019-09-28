namespace Reflection
{
    partial class Reflection
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
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lstConstructors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(108, 8);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(402, 20);
            this.txtTypeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Methods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Constructors";
            // 
            // btnDiscover
            // 
            this.btnDiscover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscover.Location = new System.Drawing.Point(529, 5);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(293, 23);
            this.btnDiscover.TabIndex = 5;
            this.btnDiscover.Text = "Discover Type Information";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.Location = new System.Drawing.Point(16, 79);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(250, 342);
            this.lstMethods.TabIndex = 6;
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.Location = new System.Drawing.Point(293, 79);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(250, 342);
            this.lstProperties.TabIndex = 7;
            // 
            // lstConstructors
            // 
            this.lstConstructors.FormattingEnabled = true;
            this.lstConstructors.Location = new System.Drawing.Point(572, 79);
            this.lstConstructors.Name = "lstConstructors";
            this.lstConstructors.Size = new System.Drawing.Size(250, 342);
            this.lstConstructors.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lstConstructors);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.btnDiscover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.ListBox lstMethods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.ListBox lstConstructors;
    }
}

