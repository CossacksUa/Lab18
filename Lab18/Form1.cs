using System.Diagnostics;

namespace Lab18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Встановлення колонок ListView
            listViewProcesses.Columns.Add("Процес", 200, HorizontalAlignment.Left);
            listViewProcesses.Columns.Add("ID", 100, HorizontalAlignment.Left);

            UpdateProcessList();
        }

        private void UpdateProcessList()
        {
            listViewProcesses.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                item.Tag = process;
                listViewProcesses.Items.Add(item);
            }
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listViewProcesses.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProcesses.SelectedItems.Count > 0)
            {
                var process = (Process)listViewProcesses.SelectedItems[0].Tag;
                ShowProcessInfo(process);
            }
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProcesses.SelectedItems.Count > 0)
            {
                var process = (Process)listViewProcesses.SelectedItems[0].Tag;
                try
                {
                    process.Kill();
                    UpdateProcessList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося зупинити процес: {ex.Message}");
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (ListViewItem item in listViewProcesses.Items)
                        {
                            writer.WriteLine($"{item.Text}\t{item.SubItems[1].Text}");
                        }
                    }
                }
            }
        }

        private void ShowProcessInfo(Process process)
        {
            string info = $"Процес: {process.ProcessName}\nID: {process.Id}\nThreads: {process.Threads.Count}\nModules:\n";
            foreach (ProcessModule module in process.Modules)
            {
                info += $"{module.ModuleName}\n";
            }

            MessageBox.Show(info, "Інформація про процес");
        }


        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button exportButton;
    }
}