namespace GADE5112___20204162___Task_1
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
            this.map_LB = new System.Windows.Forms.Label();
            this.heroHP_LB = new System.Windows.Forms.Label();
            this.heroName_TB = new System.Windows.Forms.TextBox();
            this.heroName_LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // map_LB
            // 
            this.map_LB.AutoSize = true;
            this.map_LB.Location = new System.Drawing.Point(108, 152);
            this.map_LB.Name = "map_LB";
            this.map_LB.Size = new System.Drawing.Size(35, 13);
            this.map_LB.TabIndex = 0;
            this.map_LB.Text = "label1";
            this.map_LB.Click += new System.EventHandler(this.label1_Click);
            // 
            // heroHP_LB
            // 
            this.heroHP_LB.AutoSize = true;
            this.heroHP_LB.Location = new System.Drawing.Point(283, 130);
            this.heroHP_LB.Name = "heroHP_LB";
            this.heroHP_LB.Size = new System.Drawing.Size(15, 13);
            this.heroHP_LB.TabIndex = 1;
            this.heroHP_LB.Text = "lb";
            // 
            // heroName_TB
            // 
            this.heroName_TB.Location = new System.Drawing.Point(22, 22);
            this.heroName_TB.Name = "heroName_TB";
            this.heroName_TB.Size = new System.Drawing.Size(94, 20);
            this.heroName_TB.TabIndex = 2;
            // 
            // heroName_LB
            // 
            this.heroName_LB.AutoSize = true;
            this.heroName_LB.Location = new System.Drawing.Point(283, 105);
            this.heroName_LB.Name = "heroName_LB";
            this.heroName_LB.Size = new System.Drawing.Size(35, 13);
            this.heroName_LB.TabIndex = 3;
            this.heroName_LB.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 340);
            this.Controls.Add(this.heroName_LB);
            this.Controls.Add(this.heroName_TB);
            this.Controls.Add(this.heroHP_LB);
            this.Controls.Add(this.map_LB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Rogue Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label map_LB;
        private System.Windows.Forms.Label heroHP_LB;
        private System.Windows.Forms.TextBox heroName_TB;
        private System.Windows.Forms.Label heroName_LB;
    }
}

