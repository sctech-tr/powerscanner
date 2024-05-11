namespace PowerScanner
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnScan = new Button();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            label1 = new Label();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = btnScan;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.White;
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnScan.Location = new Point(12, 42);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(289, 127);
            btnScan.TabIndex = 0;
            btnScan.Text = "Scan!";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 1;
            label1.Text = "PowerScanner";
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Red;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(269, 7);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(32, 32);
            guna2CircleButton1.TabIndex = 2;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = label1;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(313, 181);
            Controls.Add(guna2CircleButton1);
            Controls.Add(label1);
            Controls.Add(btnScan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "PowerScanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Button btnScan;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}
