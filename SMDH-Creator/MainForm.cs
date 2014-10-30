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

        OpenFileDialog importSmallIconDialog;
        OpenFileDialog importBigIconDialog;

        public MainForm()
        {
            InitializeComponent();

            openDialog = new OpenFileDialog();
            openDialog.FileOk += openDialog_FileOk;

            saveDialog = new SaveFileDialog();
            saveDialog.FileOk += saveDialog_FileOk;

            importSmallIconDialog = new OpenFileDialog();
            importSmallIconDialog.FileOk += importSmallIconDialog_FileOk;

            importBigIconDialog = new OpenFileDialog();
            importBigIconDialog.FileOk += importBigIconDialog_FileOk;
            
            titleNumber.SelectedIndex = 0;
        }

        void importSmallIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = sender as OpenFileDialog;
            this.smallIcon.Image = (Image)(new Bitmap(Image.FromFile(dialog.FileName), new Size(24, 24)));
        }
       
        void importBigIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = sender as OpenFileDialog;
            this.bigIcon.Image = (Image)(new Bitmap(Image.FromFile(dialog.FileName), new Size(48, 48)));
        }

        void openDialog_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog dialog = sender as OpenFileDialog;

            smdhFile.Load(dialog.FileName);
            
            this.smallIcon.Image = smdhFile.SmallIcon;
            this.bigIcon.Image = smdhFile.BigIcon;
            this.version.Text = smdhFile.Version.ToString();
            this.publisher.Text = smdhFile.GetPublisher(this.titleNumber.SelectedIndex);
            this.shortDescription.Text = smdhFile.GetShortDescription(this.titleNumber.SelectedIndex);
            this.longDescription.Text = smdhFile.GetLongDescription(this.titleNumber.SelectedIndex);
        }

        void saveDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog dialog = sender as SaveFileDialog;

            this.smdhFile.SmallIcon = new Bitmap(this.smallIcon.Image);
            this.smdhFile.BigIcon = new Bitmap(this.bigIcon.Image);

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

        private void titleNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.smdhFile.Valid)
            {
                this.publisher.Text = smdhFile.GetPublisher(this.titleNumber.SelectedIndex);
                this.shortDescription.Text = smdhFile.GetShortDescription(this.titleNumber.SelectedIndex);
                this.longDescription.Text = smdhFile.GetLongDescription(this.titleNumber.SelectedIndex);
            }
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.importSmallIconDialog.ShowDialog();
        }

        private void bigIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.importBigIconDialog.ShowDialog();
        }

        private void publisher_TextChanged(object sender, EventArgs e)
        {
            this.smdhFile.SetPublisher(this.titleNumber.SelectedIndex, this.publisher.Text);
        }

        private void shortDescription_TextChanged(object sender, EventArgs e)
        {
            this.smdhFile.SetShortDescription(this.titleNumber.SelectedIndex, this.shortDescription.Text);
        }

        private void longDescription_TextChanged(object sender, EventArgs e)
        {
            this.smdhFile.SetLongDescription(this.titleNumber.SelectedIndex, this.longDescription.Text);
        }
    }
}
