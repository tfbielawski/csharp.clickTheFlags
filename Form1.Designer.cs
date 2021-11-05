namespace clickTheFlags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.finlandBox = new System.Windows.Forms.PictureBox();
            this.franceBox = new System.Windows.Forms.PictureBox();
            this.germanyFlag = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(105, 53);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(581, 41);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click the flag to see the country name: ";
            // 
            // finlandBox
            // 
            this.finlandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finlandBox.Image = ((System.Drawing.Image)(resources.GetObject("finlandBox.Image")));
            this.finlandBox.Location = new System.Drawing.Point(105, 165);
            this.finlandBox.Name = "finlandBox";
            this.finlandBox.Size = new System.Drawing.Size(122, 72);
            this.finlandBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.finlandBox.TabIndex = 1;
            this.finlandBox.TabStop = false;
            this.finlandBox.Click += new System.EventHandler(this.finlandBox_Click);
            // 
            // franceBox
            // 
            this.franceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.franceBox.Image = ((System.Drawing.Image)(resources.GetObject("franceBox.Image")));
            this.franceBox.Location = new System.Drawing.Point(351, 165);
            this.franceBox.Name = "franceBox";
            this.franceBox.Size = new System.Drawing.Size(122, 72);
            this.franceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.franceBox.TabIndex = 2;
            this.franceBox.TabStop = false;
            this.franceBox.Click += new System.EventHandler(this.franceBox_Click);
            // 
            // germanyFlag
            // 
            this.germanyFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanyFlag.Image = ((System.Drawing.Image)(resources.GetObject("germanyFlag.Image")));
            this.germanyFlag.Location = new System.Drawing.Point(586, 165);
            this.germanyFlag.Name = "germanyFlag";
            this.germanyFlag.Size = new System.Drawing.Size(122, 72);
            this.germanyFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.germanyFlag.TabIndex = 3;
            this.germanyFlag.TabStop = false;
            this.germanyFlag.Click += new System.EventHandler(this.germanyFlag_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(105, 284);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(581, 33);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanyFlag);
            this.Controls.Add(this.franceBox);
            this.Controls.Add(this.finlandBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "FLAGS";
            ((System.ComponentModel.ISupportInitialize)(this.finlandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox finlandBox;
        private System.Windows.Forms.PictureBox franceBox;
        private System.Windows.Forms.PictureBox germanyFlag;
        private System.Windows.Forms.Label countryLabel;
    }
}

