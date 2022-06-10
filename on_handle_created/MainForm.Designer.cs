
namespace on_handle_created
{
    partial class MainForm
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
            this.listBox1 = new on_handle_created.CustomListBox();
            this.buttonRecreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 212);
            this.listBox1.TabIndex = 0;
            // 
            // buttonRecreate
            // 
            this.buttonRecreate.Location = new System.Drawing.Point(0, 237);
            this.buttonRecreate.Name = "buttonRecreate";
            this.buttonRecreate.Size = new System.Drawing.Size(75, 23);
            this.buttonRecreate.TabIndex = 1;
            this.buttonRecreate.Text = "Recreate";
            this.buttonRecreate.UseVisualStyleBackColor = true;
            this.buttonRecreate.Click += new System.EventHandler(this.buttonRecreate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.buttonRecreate);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private on_handle_created.CustomListBox listBox1;
        private System.Windows.Forms.Button buttonRecreate;
    }
}

