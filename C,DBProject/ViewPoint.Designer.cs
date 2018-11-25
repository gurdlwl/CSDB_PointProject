namespace C_DBProject
{
    partial class ViewPoint
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
            this.PointListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // PointListView
            // 
            this.PointListView.Location = new System.Drawing.Point(12, 12);
            this.PointListView.Name = "PointListView";
            this.PointListView.Size = new System.Drawing.Size(510, 235);
            this.PointListView.TabIndex = 0;
            this.PointListView.UseCompatibleStateImageBehavior = false;
            // 
            // ViewPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.PointListView);
            this.Name = "ViewPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPoint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PointListView;
    }
}