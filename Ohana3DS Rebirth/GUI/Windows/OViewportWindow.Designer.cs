﻿namespace Ohana3DS_Rebirth.GUI
{
    partial class OViewportWindow
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Component Designer

        /// <summary> 
        /// Método necessário para o suporte do Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Screen = new System.Windows.Forms.PictureBox();
            this.ContentContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentContainer
            // 
            this.ContentContainer.Controls.Add(this.Screen);
            this.ContentContainer.Size = new System.Drawing.Size(632, 488);
            this.ContentContainer.Controls.SetChildIndex(this.Screen, 0);
            // 
            // Screen
            // 
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 16);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(632, 472);
            this.Screen.TabIndex = 1;
            this.Screen.TabStop = false;
            this.Screen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseDown);
            this.Screen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseMove);
            this.Screen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseUp);
            this.Screen.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Screen_MouseWheel);
            this.Screen.Resize += new System.EventHandler(this.Screen_Resize);
            // 
            // OViewportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Icon = global::Ohana3DS_Rebirth.Properties.Resources.icn_w_viewport;
            this.Name = "OViewportWindow";
            this.Size = new System.Drawing.Size(640, 496);
            this.ContentContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Screen;




    }
}
