namespace Topic_9___Assignemnt_2
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddition = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblMultiplication = new System.Windows.Forms.Label();
            this.lblSubtraction = new System.Windows.Forms.Label();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdd.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(311, 85);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(62, 78);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "+";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdd.MouseLeave += new System.EventHandler(this.lblPlusLeave);
            this.lblAdd.MouseHover += new System.EventHandler(this.lblPlusHover);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseLeave += new System.EventHandler(this.lblMinusLeave);
            this.label2.MouseHover += new System.EventHandler(this.lblMinusHover);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 78);
            this.label3.TabIndex = 2;
            this.label3.Text = "÷";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseLeave += new System.EventHandler(this.lblDivideLeave);
            this.label3.MouseHover += new System.EventHandler(this.lblDivideHover);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 78);
            this.label4.TabIndex = 3;
            this.label4.Text = "x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseLeave += new System.EventHandler(this.lblMultiplyLeave);
            this.label4.MouseHover += new System.EventHandler(this.lblMultiplyHover);
            // 
            // lblAddition
            // 
            this.lblAddition.AutoSize = true;
            this.lblAddition.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddition.Location = new System.Drawing.Point(403, 103);
            this.lblAddition.Name = "lblAddition";
            this.lblAddition.Size = new System.Drawing.Size(87, 30);
            this.lblAddition.TabIndex = 4;
            this.lblAddition.Text = "7+7 = 14";
            this.lblAddition.Visible = false;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(403, 337);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(76, 30);
            this.lblDivision.TabIndex = 5;
            this.lblDivision.Text = "7÷7 = 1";
            this.lblDivision.Visible = false;
            // 
            // lblMultiplication
            // 
            this.lblMultiplication.AutoSize = true;
            this.lblMultiplication.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplication.Location = new System.Drawing.Point(403, 259);
            this.lblMultiplication.Name = "lblMultiplication";
            this.lblMultiplication.Size = new System.Drawing.Size(84, 30);
            this.lblMultiplication.TabIndex = 6;
            this.lblMultiplication.Text = "7x7 = 49";
            this.lblMultiplication.Visible = false;
            // 
            // lblSubtraction
            // 
            this.lblSubtraction.AutoSize = true;
            this.lblSubtraction.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtraction.Location = new System.Drawing.Point(403, 181);
            this.lblSubtraction.Name = "lblSubtraction";
            this.lblSubtraction.Size = new System.Drawing.Size(71, 30);
            this.lblSubtraction.TabIndex = 7;
            this.lblSubtraction.Text = "7-7 = 0";
            this.lblSubtraction.Visible = false;
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruct.Location = new System.Drawing.Point(181, 30);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(437, 30);
            this.lblInstruct.TabIndex = 8;
            this.lblInstruct.Text = "Hover over the symbol to see its equation with sevens!";
            this.lblInstruct.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.lblSubtraction);
            this.Controls.Add(this.lblMultiplication);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblAddition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Thats a whole lot of sevens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddition;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblMultiplication;
        private System.Windows.Forms.Label lblSubtraction;
        private System.Windows.Forms.Label lblInstruct;
    }
}

