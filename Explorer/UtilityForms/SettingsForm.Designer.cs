﻿namespace Explorer.UtilityForms
{
    partial class SettingsForm
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
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.ButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(18, 64);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(509, 184);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.HorizontalScrollbarBarColor = true;
            this.ButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ButtonsPanel.HorizontalScrollbarSize = 10;
            this.ButtonsPanel.Location = new System.Drawing.Point(18, 248);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(509, 37);
            this.ButtonsPanel.TabIndex = 1;
            this.ButtonsPanel.VerticalScrollbarBarColor = true;
            this.ButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 306);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(18, 64, 18, 21);
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroPanel ButtonsPanel;
    }
}