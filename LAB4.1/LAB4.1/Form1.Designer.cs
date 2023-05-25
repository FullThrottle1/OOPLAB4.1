namespace LAB4._1
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
            mark_more = new CheckBox();
            ctrl_enabled = new CheckBox();
            SuspendLayout();
            // 
            // mark_more
            // 
            mark_more.AutoSize = true;
            mark_more.Location = new Point(200, 50);
            mark_more.Name = "mark_more";
            mark_more.Size = new Size(101, 24);
            mark_more.TabIndex = 0;
            mark_more.Text = "Intersection";
            mark_more.UseVisualStyleBackColor = true;
            // 
            // ctrl_enabled
            // 
            ctrl_enabled.AutoSize = true;
            ctrl_enabled.Location = new Point(50, 50);
            ctrl_enabled.Name = "ctrl_enabled";
            ctrl_enabled.Size = new Size(138, 24);
            ctrl_enabled.TabIndex = 1;
            ctrl_enabled.Text = "Control On";
            ctrl_enabled.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1000);
            Controls.Add(ctrl_enabled);
            Controls.Add(mark_more);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox mark_more;
        private CheckBox ctrl_enabled;
    }
}