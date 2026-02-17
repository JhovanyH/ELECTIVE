namespace ELECTIVE
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            aDMINFORMToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            aDMINFORMToolStripMenuItem1 = new ToolStripMenuItem();
            dISPLAYFORMToolStripMenuItem = new ToolStripMenuItem();
            cAToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { aDMINFORMToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(172, 28);
            // 
            // aDMINFORMToolStripMenuItem
            // 
            aDMINFORMToolStripMenuItem.Name = "aDMINFORMToolStripMenuItem";
            aDMINFORMToolStripMenuItem.Size = new Size(171, 24);
            aDMINFORMToolStripMenuItem.Text = "ADMIN FORM";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aDMINFORMToolStripMenuItem1, dISPLAYFORMToolStripMenuItem, cAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1194, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDMINFORMToolStripMenuItem1
            // 
            aDMINFORMToolStripMenuItem1.Name = "aDMINFORMToolStripMenuItem1";
            aDMINFORMToolStripMenuItem1.Size = new Size(116, 24);
            aDMINFORMToolStripMenuItem1.Text = "ADMIN FORM";
            // 
            // dISPLAYFORMToolStripMenuItem
            // 
            dISPLAYFORMToolStripMenuItem.Name = "dISPLAYFORMToolStripMenuItem";
            dISPLAYFORMToolStripMenuItem.Size = new Size(122, 24);
            dISPLAYFORMToolStripMenuItem.Text = "DISPLAY FORM";
            // 
            // cAToolStripMenuItem
            // 
            cAToolStripMenuItem.Name = "cAToolStripMenuItem";
            cAToolStripMenuItem.Size = new Size(126, 24);
            cAToolStripMenuItem.Text = "CASHIER FORM";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 730);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "MainMenu";
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem aDMINFORMToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aDMINFORMToolStripMenuItem1;
        private ToolStripMenuItem dISPLAYFORMToolStripMenuItem;
        private ToolStripMenuItem cAToolStripMenuItem;
    }
}