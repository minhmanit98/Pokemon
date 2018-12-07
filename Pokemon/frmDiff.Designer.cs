namespace Pokemon
{
    partial class frmDiff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiff));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.bthard = new System.Windows.Forms.PictureBox();
            this.btmedium = new System.Windows.Forms.PictureBox();
            this.bteasy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bthard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNew.Font = new System.Drawing.Font("Komika Axis", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnNew.Image = global::Pokemon.Properties.Resources.reset;
            this.btnNew.Location = new System.Drawing.Point(12, 189);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 32);
            this.btnNew.TabIndex = 1;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnLoad.Font = new System.Drawing.Font("Komika Axis", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoad.Image = global::Pokemon.Properties.Resources.OpenSaved;
            this.btnLoad.Location = new System.Drawing.Point(147, 189);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // bthard
            // 
            this.bthard.BackColor = System.Drawing.Color.Transparent;
            this.bthard.Image = global::Pokemon.Properties.Resources.hard;
            this.bthard.Location = new System.Drawing.Point(43, 118);
            this.bthard.Name = "bthard";
            this.bthard.Size = new System.Drawing.Size(169, 65);
            this.bthard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bthard.TabIndex = 6;
            this.bthard.TabStop = false;
            this.bthard.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btmedium
            // 
            this.btmedium.BackColor = System.Drawing.Color.Transparent;
            this.btmedium.Image = global::Pokemon.Properties.Resources.medium;
            this.btmedium.Location = new System.Drawing.Point(44, 51);
            this.btmedium.Name = "btmedium";
            this.btmedium.Size = new System.Drawing.Size(169, 80);
            this.btmedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmedium.TabIndex = 7;
            this.btmedium.TabStop = false;
            this.btmedium.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bteasy
            // 
            this.bteasy.BackColor = System.Drawing.Color.Transparent;
            this.bteasy.Image = global::Pokemon.Properties.Resources.easy;
            this.bteasy.Location = new System.Drawing.Point(36, 7);
            this.bteasy.Name = "bteasy";
            this.bteasy.Size = new System.Drawing.Size(182, 58);
            this.bteasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bteasy.TabIndex = 8;
            this.bteasy.TabStop = false;
            this.bteasy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pokemon.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(246, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Pokemon.Properties.Resources.bgblack;
            this.ClientSize = new System.Drawing.Size(267, 233);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bthard);
            this.Controls.Add(this.bteasy);
            this.Controls.Add(this.btmedium);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Mới";
            ((System.ComponentModel.ISupportInitialize)(this.bthard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox bthard;
        private System.Windows.Forms.PictureBox btmedium;
        private System.Windows.Forms.PictureBox bteasy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}