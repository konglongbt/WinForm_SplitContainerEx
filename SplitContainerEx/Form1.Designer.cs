namespace SplitContainerEx
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
            this.splitContainerE1 = new SplitContainerEx.SplitContainerE();
            this.splitContainerE2 = new SplitContainerEx.SplitContainerE();
            this.splitContainerE1.Panel2.SuspendLayout();
            this.splitContainerE1.SuspendLayout();
            this.splitContainerE2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerE1
            // 
            this.splitContainerE1.CollpasePanel = SplitContainerEx.SplitContainerE.SplitterPanelEnum.Panel1;
            this.splitContainerE1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerE1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerE1.Name = "splitContainerE1";
            this.splitContainerE1.Panel1MinSize = 0;
            // 
            // splitContainerE1.Panel2
            // 
            this.splitContainerE1.Panel2.Controls.Add(this.splitContainerE2);
            this.splitContainerE1.Panel2MinSize = 0;
            this.splitContainerE1.Size = new System.Drawing.Size(830, 367);
            this.splitContainerE1.SplitterDistance = 276;
            this.splitContainerE1.SplitterWidth = 9;
            this.splitContainerE1.TabIndex = 0;
            // 
            // splitContainerE2
            // 
            this.splitContainerE2.CollpasePanel = SplitContainerEx.SplitContainerE.SplitterPanelEnum.Panel1;
            this.splitContainerE2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerE2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerE2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerE2.Name = "splitContainerE2";
            this.splitContainerE2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerE2.Panel1MinSize = 0;
            this.splitContainerE2.Panel2MinSize = 0;
            this.splitContainerE2.Size = new System.Drawing.Size(545, 367);
            this.splitContainerE2.SplitterDistance = 181;
            this.splitContainerE2.SplitterWidth = 9;
            this.splitContainerE2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 367);
            this.Controls.Add(this.splitContainerE1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerE1.Panel2.ResumeLayout(false);
            this.splitContainerE1.ResumeLayout(false);
            this.splitContainerE2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainerE splitContainerE1;
        private SplitContainerE splitContainerE2;
    }
}