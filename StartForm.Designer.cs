
namespace ComputerScienceInternalAssessment
{
    partial class StartForm
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
            this.ViewSwimmerListBtn = new System.Windows.Forms.Button();
            this.StartHelpBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewSwimmerListBtn
            // 
            this.ViewSwimmerListBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewSwimmerListBtn.Location = new System.Drawing.Point(27, 202);
            this.ViewSwimmerListBtn.Name = "ViewSwimmerListBtn";
            this.ViewSwimmerListBtn.Size = new System.Drawing.Size(227, 80);
            this.ViewSwimmerListBtn.TabIndex = 0;
            this.ViewSwimmerListBtn.Text = "View Swimmer List";
            this.ViewSwimmerListBtn.UseCompatibleTextRendering = true;
            this.ViewSwimmerListBtn.UseVisualStyleBackColor = false;
            this.ViewSwimmerListBtn.Click += new System.EventHandler(this.ViewSwimmerListBtn_Click);
            // 
            // StartHelpBtn
            // 
            this.StartHelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StartHelpBtn.Location = new System.Drawing.Point(27, 329);
            this.StartHelpBtn.Name = "StartHelpBtn";
            this.StartHelpBtn.Size = new System.Drawing.Size(75, 23);
            this.StartHelpBtn.TabIndex = 3;
            this.StartHelpBtn.Text = "Help";
            this.StartHelpBtn.UseVisualStyleBackColor = false;
            this.StartHelpBtn.Click += new System.EventHandler(this.StartHelpBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitBtn.Location = new System.Drawing.Point(177, 329);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(77, 23);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartHelpBtn);
            this.Controls.Add(this.ViewSwimmerListBtn);
            this.Name = "StartForm";
            this.Text = "Swimmer Application";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewSwimmerListBtn;
        private System.Windows.Forms.Button StartHelpBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
    }
}

