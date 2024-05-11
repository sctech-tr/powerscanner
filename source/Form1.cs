using System.Diagnostics;

namespace PowerScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string pythonScriptPath = Path.Combine(Application.StartupPath, "powerscan.py");

            if (File.Exists(pythonScriptPath))
            {
                try
                {
                    Process.Start("py.exe", pythonScriptPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Scanner script not found. Please reinstall PowerScanner.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
