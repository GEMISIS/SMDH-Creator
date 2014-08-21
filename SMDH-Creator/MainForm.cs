using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMDH_Creator
{
    public partial class MainForm : Form
    {
        SMDH smdhFile = new SMDH();
        OpenFileDialog openDialog;
        SaveFileDialog saveDialog;

        public MainForm()
        {
            InitializeComponent();

            openDialog = new OpenFileDialog();
            openDialog.FileOk += openDialog_FileOk;

            saveDialog = new SaveFileDialog();
            saveDialog.FileOk += saveDialog_FileOk;
        }

        void openDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = sender as OpenFileDialog;
            smdhFile.Load(dialog.FileName);
            this.smallIcon.Image = smdhFile.SmallIcon;
            this.LargeIcon.Image = smdhFile.BigIcon;
        }

        void saveDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog dialog = sender as SaveFileDialog;
            smdhFile.Save(dialog.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDialog.ShowDialog();
        }
    }
}
