namespace C_DBProject
{
    partial class SubMinusPoint
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
            this.subMPListView = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnsubMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subMPListView
            // 
            this.subMPListView.Location = new System.Drawing.Point(12, 12);
            this.subMPListView.MultiSelect = false;
            this.subMPListView.Name = "subMPListView";
            this.subMPListView.Size = new System.Drawing.Size(510, 224);
            this.subMPListView.TabIndex = 0;
            this.subMPListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnsubMP
            // 
            this.btnsubMP.Location = new System.Drawing.Point(177, 262);
            this.btnsubMP.Name = "btnsubMP";
            this.btnsubMP.Size = new System.Drawing.Size(75, 23);
            this.btnsubMP.TabIndex = 20;
            this.btnsubMP.Text = "상쇄";
            this.btnsubMP.UseVisualStyleBackColor = true;
            this.btnsubMP.Click += new System.EventHandler(this.btnsubMP_Click);
            // 
            // SubMinusPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnsubMP);
            this.Controls.Add(this.subMPListView);
            this.Name = "SubMinusPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubMinusPoint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView subMPListView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnsubMP;
    }
}