namespace FloresDormitoryMS
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
            panel1 = new Panel();
            btnLogout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnTenants = new Button();
            btnBilling = new Button();
            btnMaintenance = new Button();
            btnRecords = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 63, 12);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1710, 120);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(64, 64, 64);
            btnLogout.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1420, 29);
            btnLogout.Margin = new Padding(20, 20, 0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(5);
            btnLogout.Size = new Size(257, 59);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(62, 62, 62);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnTenants);
            flowLayoutPanel1.Controls.Add(btnBilling);
            flowLayoutPanel1.Controls.Add(btnMaintenance);
            flowLayoutPanel1.Controls.Add(btnRecords);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(297, 805);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(20, 20);
            btnDashboard.Margin = new Padding(20, 20, 0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(5);
            btnDashboard.Size = new Size(257, 59);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnTenants
            // 
            btnTenants.BackColor = Color.FromArgb(64, 64, 64);
            btnTenants.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTenants.Location = new Point(20, 99);
            btnTenants.Margin = new Padding(20, 20, 0, 0);
            btnTenants.Name = "btnTenants";
            btnTenants.Padding = new Padding(5);
            btnTenants.Size = new Size(257, 59);
            btnTenants.TabIndex = 1;
            btnTenants.Text = "TENANTS";
            btnTenants.UseVisualStyleBackColor = false;
            btnTenants.Click += btnTenants_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(64, 64, 64);
            btnBilling.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.Location = new Point(20, 178);
            btnBilling.Margin = new Padding(20, 20, 0, 0);
            btnBilling.Name = "btnBilling";
            btnBilling.Padding = new Padding(5);
            btnBilling.Size = new Size(257, 59);
            btnBilling.TabIndex = 2;
            btnBilling.Text = "BILLING";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click_1;
            // 
            // btnMaintenance
            // 
            btnMaintenance.BackColor = Color.FromArgb(64, 64, 64);
            btnMaintenance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaintenance.Location = new Point(20, 257);
            btnMaintenance.Margin = new Padding(20, 20, 0, 0);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Padding = new Padding(5);
            btnMaintenance.Size = new Size(257, 59);
            btnMaintenance.TabIndex = 3;
            btnMaintenance.Text = "MAINTENANCE";
            btnMaintenance.UseVisualStyleBackColor = false;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.FromArgb(64, 64, 64);
            btnRecords.Dock = DockStyle.Bottom;
            btnRecords.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecords.Location = new Point(20, 336);
            btnRecords.Margin = new Padding(20, 20, 0, 0);
            btnRecords.Name = "btnRecords";
            btnRecords.Padding = new Padding(5);
            btnRecords.Size = new Size(257, 59);
            btnRecords.TabIndex = 4;
            btnRecords.Text = "RECORDS";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 925);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(255, 253, 249);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashboard;
        private Button btnTenants;
        private Button btnBilling;
        private Button btnMaintenance;
        private Button btnRecords;
        private Button btnLogout;
    }
}
