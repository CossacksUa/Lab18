namespace Lab18
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
            listViewProcesses = new ListView();
            contextMenuStrip = new ContextMenuStrip(components);
            showInfoToolStripMenuItem = new ToolStripMenuItem();
            killProcessToolStripMenuItem = new ToolStripMenuItem();
            refreshButton = new Button();
            exportButton = new Button();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // listViewProcesses
            // 
            listViewProcesses.ContextMenuStrip = contextMenuStrip;
            listViewProcesses.FullRowSelect = true;
            listViewProcesses.GridLines = true;
            listViewProcesses.Location = new Point(12, 12);
            listViewProcesses.MultiSelect = false;
            listViewProcesses.Name = "listViewProcesses";
            listViewProcesses.Size = new Size(692, 386);
            listViewProcesses.TabIndex = 0;
            listViewProcesses.UseCompatibleStateImageBehavior = false;
            listViewProcesses.View = View.Details;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { showInfoToolStripMenuItem, killProcessToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(139, 48);
            contextMenuStrip.Opening += contextMenuStrip_Opening;
            // 
            // showInfoToolStripMenuItem
            // 
            showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            showInfoToolStripMenuItem.Size = new Size(138, 22);
            showInfoToolStripMenuItem.Text = "Інформація";
            showInfoToolStripMenuItem.Click += showInfoToolStripMenuItem_Click;
            // 
            // killProcessToolStripMenuItem
            // 
            killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            killProcessToolStripMenuItem.Size = new Size(138, 22);
            killProcessToolStripMenuItem.Text = "Зупинити";
            killProcessToolStripMenuItem.Click += killProcessToolStripMenuItem_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(728, 364);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(112, 42);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Оновити";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(742, 319);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(98, 39);
            exportButton.TabIndex = 2;
            exportButton.Text = "Експортувати";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(852, 418);
            Controls.Add(exportButton);
            Controls.Add(refreshButton);
            Controls.Add(listViewProcesses);
            Name = "Form1";
            Text = "Process Manager";
            Load += MainForm_Load;
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
