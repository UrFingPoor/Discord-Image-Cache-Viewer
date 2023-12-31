﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DiscordImageCacheViewer
{
    public partial class MainFRM : Form
    {
        HelperLib Helper = new HelperLib();
        public MainFRM() => InitializeComponent();
        private void openfolderbtn_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = $"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ofd.CheckPathExists = true;
                    ofd.RestoreDirectory = true;
                    path.Text = Path.GetDirectoryName(ofd.FileName);
                }
            }
        }
        private void fixcachebtn_Click(object sender, EventArgs e)
        {
            //loops through all files and only renames supported viewable Images
            foreach (var f in Directory.GetFiles($"{path.Text}"))
            {
                if (f.Contains(".png") || f.Contains(".jpg") || f.Contains(".gif")) continue;
                File.Move(f, f.Replace(f, $"{f}{Helper.GetExtFromMemory(f)}"));
            }
            MessageBox.Show("Successfully Renamed All Supported Images!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void viewimagebtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            ImageView.Items.Clear();
            imageList1.Images.Clear();

            //Populates ImageList & listview with filename and images
            foreach (var ImagePath in Directory.GetFiles($"{path.Text}"))
            {
                if (ImagePath.EndsWith(".jpg") || ImagePath.EndsWith(".png"))
                {
                    if (Helper.LoadCheck(ImagePath)) imageList1.Images.Add(Image.FromFile(ImagePath));
                    ImageView.Items.Add($"{Path.GetFileName(ImagePath)}", i);
                    i++;
                }
            }
        }
    }
}