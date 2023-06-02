namespace Conservatoire_musique0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxPrsn = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suivisDePaiementÉlèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.séanceÉlèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxEleve = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPrsn
            // 
            this.listBoxPrsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxPrsn.FormattingEnabled = true;
            this.listBoxPrsn.ItemHeight = 15;
            this.listBoxPrsn.Location = new System.Drawing.Point(30, 231);
            this.listBoxPrsn.Name = "listBoxPrsn";
            this.listBoxPrsn.Size = new System.Drawing.Size(638, 409);
            this.listBoxPrsn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professeurs de Musique";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevesToolStripMenuItem,
            this.inscriptionProfesseurToolStripMenuItem,
            this.suivisDePaiementÉlèveToolStripMenuItem,
            this.séanceÉlèveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(430, 152);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elevesToolStripMenuItem
            // 
            this.elevesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.elevesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elevesToolStripMenuItem.Name = "elevesToolStripMenuItem";
            this.elevesToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.elevesToolStripMenuItem.Text = "inscriptionEleve";
            this.elevesToolStripMenuItem.Click += new System.EventHandler(this.elevesToolStripMenuItem_Click);
            // 
            // inscriptionProfesseurToolStripMenuItem
            // 
            this.inscriptionProfesseurToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.inscriptionProfesseurToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inscriptionProfesseurToolStripMenuItem.Name = "inscriptionProfesseurToolStripMenuItem";
            this.inscriptionProfesseurToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.inscriptionProfesseurToolStripMenuItem.Text = "Inscription Professeur";
            this.inscriptionProfesseurToolStripMenuItem.Click += new System.EventHandler(this.inscriptionProfesseurToolStripMenuItem_Click);
            // 
            // suivisDePaiementÉlèveToolStripMenuItem
            // 
            this.suivisDePaiementÉlèveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.suivisDePaiementÉlèveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suivisDePaiementÉlèveToolStripMenuItem.Name = "suivisDePaiementÉlèveToolStripMenuItem";
            this.suivisDePaiementÉlèveToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.suivisDePaiementÉlèveToolStripMenuItem.Text = "Suivis de Paiement élève";
            this.suivisDePaiementÉlèveToolStripMenuItem.Click += new System.EventHandler(this.suivisDePaiementÉlèveToolStripMenuItem_Click);
            // 
            // séanceÉlèveToolStripMenuItem
            // 
            this.séanceÉlèveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.séanceÉlèveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.séanceÉlèveToolStripMenuItem.Name = "séanceÉlèveToolStripMenuItem";
            this.séanceÉlèveToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.séanceÉlèveToolStripMenuItem.Text = "Séance Professeur";
            this.séanceÉlèveToolStripMenuItem.Click += new System.EventHandler(this.séanceÉlèveToolStripMenuItem_Click);
            // 
            // listBoxEleve
            // 
            this.listBoxEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxEleve.FormattingEnabled = true;
            this.listBoxEleve.ItemHeight = 15;
            this.listBoxEleve.Location = new System.Drawing.Point(689, 231);
            this.listBoxEleve.Name = "listBoxEleve";
            this.listBoxEleve.Size = new System.Drawing.Size(615, 409);
            this.listBoxEleve.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(919, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Eleves Enregistrés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, -76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 250);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1336, 732);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxEleve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPrsn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxPrsn;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection2;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection3;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private TreeView treeView1;
        private ToolTip toolTip1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem professeursToolStripMenuItem;
        private ToolStripMenuItem inscriToolStripMenuItem;
        private ToolStripMenuItem inscriptionProfesseurToolStripMenuItem;
        private ToolStripMenuItem suivisDePaiementÉlèveToolStripMenuItem;
        private ToolStripMenuItem elevesToolStripMenuItem;
        private ListBox listBoxEleve;
        private Label label3;
        private ToolStripMenuItem séanceÉlèveToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}