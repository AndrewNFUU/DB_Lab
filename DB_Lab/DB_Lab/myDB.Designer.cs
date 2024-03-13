namespace DB_Lab
{
    partial class myDB
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.TableExploration = new System.Windows.Forms.ToolStripMenuItem();
            this.TableGemstone = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLaboratory = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBTablesToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBTablesToolStripMenuItem
            // 
            this.dBTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TableExpert,
            this.TableExploration,
            this.TableGemstone,
            this.TableLaboratory});
            this.dBTablesToolStripMenuItem.Name = "dBTablesToolStripMenuItem";
            this.dBTablesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.dBTablesToolStripMenuItem.Text = "DB Tables";
            // 
            // TableExpert
            // 
            this.TableExpert.Image = global::DB_Lab.Properties.Resources.scientist;
            this.TableExpert.Name = "TableExpert";
            this.TableExpert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.TableExpert.Size = new System.Drawing.Size(224, 26);
            this.TableExpert.Text = "Expert";
            this.TableExpert.Click += new System.EventHandler(this.TableExpert_Click);
            // 
            // TableExploration
            // 
            this.TableExploration.Image = global::DB_Lab.Properties.Resources.explore;
            this.TableExploration.Name = "TableExploration";
            this.TableExploration.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.TableExploration.Size = new System.Drawing.Size(224, 26);
            this.TableExploration.Text = "Exploration";
            this.TableExploration.Click += new System.EventHandler(this.TableExploration_Click);
            // 
            // TableGemstone
            // 
            this.TableGemstone.Image = global::DB_Lab.Properties.Resources.gem;
            this.TableGemstone.Name = "TableGemstone";
            this.TableGemstone.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.TableGemstone.Size = new System.Drawing.Size(224, 26);
            this.TableGemstone.Text = "Gemstone";
            this.TableGemstone.Click += new System.EventHandler(this.TableGemstone_Click);
            // 
            // TableLaboratory
            // 
            this.TableLaboratory.Image = global::DB_Lab.Properties.Resources.lab_microscope;
            this.TableLaboratory.Name = "TableLaboratory";
            this.TableLaboratory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.TableLaboratory.Size = new System.Drawing.Size(224, 26);
            this.TableLaboratory.Text = "Laboratory";
            this.TableLaboratory.Click += new System.EventHandler(this.TableLaboratory_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // myDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Click += new System.EventHandler(this.myDB_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableExpert;
        private System.Windows.Forms.ToolStripMenuItem TableExploration;
        private System.Windows.Forms.ToolStripMenuItem TableGemstone;
        private System.Windows.Forms.ToolStripMenuItem TableLaboratory;
    }
}

