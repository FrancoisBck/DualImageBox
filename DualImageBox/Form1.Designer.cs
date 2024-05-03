namespace DualImageBox
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgBoxLeft = new Cyotek.Windows.Forms.ImageBox();
            this.imgBoxRight = new Cyotek.Windows.Forms.ImageBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imgBoxLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgBoxRight, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imgBoxLeft
            // 
            this.imgBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBoxLeft.Location = new System.Drawing.Point(3, 3);
            this.imgBoxLeft.Name = "imgBoxLeft";
            this.imgBoxLeft.Size = new System.Drawing.Size(394, 444);
            this.imgBoxLeft.TabIndex = 0;
            this.imgBoxLeft.Text = "Left";
            this.imgBoxLeft.ZoomChanged += new System.EventHandler(this.imgBoxLeft_ZoomChanged);
            this.imgBoxLeft.Scroll += new System.Windows.Forms.ScrollEventHandler(this.imgBoxLeft_Scroll);
            // 
            // imgBoxRight
            // 
            this.imgBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBoxRight.Location = new System.Drawing.Point(403, 3);
            this.imgBoxRight.Name = "imgBoxRight";
            this.imgBoxRight.Size = new System.Drawing.Size(394, 444);
            this.imgBoxRight.TabIndex = 1;
            this.imgBoxRight.Text = "Right";
            this.imgBoxRight.ZoomChanged += new System.EventHandler(this.imgBoxRight_ZoomChanged);
            this.imgBoxRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.imgBoxRight_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Cyotek.Windows.Forms.ImageBox imgBoxLeft;
        private Cyotek.Windows.Forms.ImageBox imgBoxRight;
    }
}

