namespace FloresDormitoryMS
{
    public partial class Form1 : Form
    {
        FormDashboard fDashboard;
        FormTenant fTenant;
        FormBilling fBilling;
        FormMaintenance fMaintenance;
        FormRecords fRecords;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (fDashboard == null)
            {
                fDashboard = new FormDashboard();
                fDashboard.FormClosed += FDashboard_FormClosed;
                fDashboard.MdiParent = this;
                fDashboard.Show();
            }
            else
            {   
                fDashboard.Activate();
                //close tabs other than Dashboard


            }
        }

        // Event handler added because Form1.Designer.cs wires btnTenants.Click to this method. for the sidebar
        private void btnTenants_Click(object sender, EventArgs e)
        {
            if (fTenant == null)
            {
                fTenant = new FormTenant();
                fTenant.FormClosed += fTenant_FormClosed;
                fTenant.MdiParent = this;
                fTenant.Show();
                
            }
            else
            {
                fTenant.Activate();
                //close tabs other than tenants


            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            if (fBilling == null)
            {
                fBilling = new FormBilling();
                fBilling.FormClosed += fBilling_FormClosed;
                fBilling.MdiParent = this;
                fBilling.Show();
            }
            else
            {
                fBilling.Activate();
                //close tabs other than Billing

            }
        }       
        private void btnBilling_Click_1(object sender, EventArgs e)
        {
            if (fBilling == null)
            {
                fBilling = new FormBilling();
                fBilling.FormClosed += fBilling_FormClosed;
                fBilling.MdiParent = this;
                fBilling.Show();
            }
            else
            {
                fBilling.Activate();
                //close tabs other than Billing

            }
        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            if (fMaintenance == null)
            {
                fMaintenance = new FormMaintenance();
                fMaintenance.FormClosed += fMaintenance_FormClosed;
                fMaintenance.MdiParent = this;
                fMaintenance.Show();
            }
            else
            {
                fMaintenance.Activate();
                //close tabs other than Maintenance


            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            if (fRecords == null)
            {
                fRecords = new FormRecords();
                fRecords.FormClosed += fRecords_FormClosed;
                fRecords.MdiParent = this;
                fRecords.Show();
            }
            else
            {
                fRecords.Activate();
            }
        }

        // Event handlers to set form references to null when forms are closed
        private void FDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fDashboard = null;
        }
        private void fTenant_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fTenant = null;
        }
        private void fBilling_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fBilling = null;
        }

        private void fMaintenance_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fMaintenance = null;
        }

        private void fRecords_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fRecords = null;
        }

 
    }
}
