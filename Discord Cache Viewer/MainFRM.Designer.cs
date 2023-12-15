namespace DiscordImageCacheViewer
{
    partial class MainFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.path = new System.Windows.Forms.TextBox();
            this.ImageView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.viewimagebtn = new System.Windows.Forms.Button();
            this.fixcachebtn = new System.Windows.Forms.Button();
            this.openfolderbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(17, 23);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(240, 20);
            this.path.TabIndex = 0;
            this.path.Text = "C:\\Users\\Example\\AppData\\Roaming\\discord\\Cache\\Cache_Data";
            // 
            // ImageView
            // 
            this.ImageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageView.GridLines = true;
            this.ImageView.HideSelection = false;
            this.ImageView.LargeImageList = this.imageList1;
            this.ImageView.Location = new System.Drawing.Point(17, 49);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(321, 216);
            this.ImageView.SmallImageList = this.imageList1;
            this.ImageView.TabIndex = 2;
            this.ImageView.UseCompatibleStateImageBehavior = false;
            this.ImageView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // viewimagebtn
            // 
            this.viewimagebtn.Location = new System.Drawing.Point(220, 271);
            this.viewimagebtn.Name = "viewimagebtn";
            this.viewimagebtn.Size = new System.Drawing.Size(118, 23);
            this.viewimagebtn.TabIndex = 3;
            this.viewimagebtn.Text = "View Images";
            this.viewimagebtn.UseVisualStyleBackColor = true;
            this.viewimagebtn.Click += new System.EventHandler(this.viewimagebtn_Click);
            // 
            // fixcachebtn
            // 
            this.fixcachebtn.Location = new System.Drawing.Point(17, 271);
            this.fixcachebtn.Name = "fixcachebtn";
            this.fixcachebtn.Size = new System.Drawing.Size(127, 23);
            this.fixcachebtn.TabIndex = 4;
            this.fixcachebtn.Text = "Rename Cache";
            this.fixcachebtn.UseVisualStyleBackColor = true;
            this.fixcachebtn.Click += new System.EventHandler(this.fixcachebtn_Click);
            // 
            // openfolderbtn
            // 
            this.openfolderbtn.Location = new System.Drawing.Point(263, 21);
            this.openfolderbtn.Name = "openfolderbtn";
            this.openfolderbtn.Size = new System.Drawing.Size(75, 23);
            this.openfolderbtn.TabIndex = 5;
            this.openfolderbtn.Text = "•••";
            this.openfolderbtn.UseVisualStyleBackColor = true;
            this.openfolderbtn.Click += new System.EventHandler(this.openfolderbtn_Click);
            // 
            // MainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 308);
            this.Controls.Add(this.openfolderbtn);
            this.Controls.Add(this.fixcachebtn);
            this.Controls.Add(this.viewimagebtn);
            this.Controls.Add(this.ImageView);
            this.Controls.Add(this.path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 347);
            this.Name = "MainFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Image Cache Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.ListView ImageView;
        private System.Windows.Forms.Button viewimagebtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button fixcachebtn;
        private System.Windows.Forms.Button openfolderbtn;
    }
}

