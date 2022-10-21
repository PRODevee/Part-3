namespace Part_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.redDisplay = new System.Windows.Forms.RichTextBox();
            this.lblSwampStats = new System.Windows.Forms.Label();
            this.lblMageStats = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.Location = new System.Drawing.Point(645, 64);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(38, 15);
            this.lblHeroStats.TabIndex = 0;
            this.lblHeroStats.Text = "label1";
            // 
            // redDisplay
            // 
            this.redDisplay.Location = new System.Drawing.Point(169, 64);
            this.redDisplay.Name = "redDisplay";
            this.redDisplay.Size = new System.Drawing.Size(384, 252);
            this.redDisplay.TabIndex = 1;
            this.redDisplay.Text = "";
            // 
            // lblSwampStats
            // 
            this.lblSwampStats.AutoSize = true;
            this.lblSwampStats.Location = new System.Drawing.Point(645, 138);
            this.lblSwampStats.Name = "lblSwampStats";
            this.lblSwampStats.Size = new System.Drawing.Size(38, 15);
            this.lblSwampStats.TabIndex = 2;
            this.lblSwampStats.Text = "label2";
            // 
            // lblMageStats
            // 
            this.lblMageStats.AutoSize = true;
            this.lblMageStats.Location = new System.Drawing.Point(645, 214);
            this.lblMageStats.Name = "lblMageStats";
            this.lblMageStats.Size = new System.Drawing.Size(38, 15);
            this.lblMageStats.TabIndex = 3;
            this.lblMageStats.Text = "label1";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(579, 293);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(686, 293);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lblMageStats);
            this.Controls.Add(this.lblSwampStats);
            this.Controls.Add(this.redDisplay);
            this.Controls.Add(this.lblHeroStats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeroStats;
        private RichTextBox redDisplay;
        private Label lblSwampStats;
        private Label lblMageStats;
        private Button BtnSave;
        private Button btnLoad;
    }
}