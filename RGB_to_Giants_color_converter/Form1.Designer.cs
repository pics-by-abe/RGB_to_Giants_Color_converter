
namespace RGB_to_Giants_Color_Converter
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
            this.txtColorB = new System.Windows.Forms.TextBox();
            this.txtColorG = new System.Windows.Forms.TextBox();
            this.txtColorR = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtColorB
            // 
            this.txtColorB.Location = new System.Drawing.Point(57, 181);
            this.txtColorB.Name = "txtColorB";
            this.txtColorB.Size = new System.Drawing.Size(100, 20);
            this.txtColorB.TabIndex = 0;
            // 
            // txtColorG
            // 
            this.txtColorG.Location = new System.Drawing.Point(57, 143);
            this.txtColorG.Name = "txtColorG";
            this.txtColorG.Size = new System.Drawing.Size(100, 20);
            this.txtColorG.TabIndex = 1;
            // 
            // txtColorR
            // 
            this.txtColorR.Location = new System.Drawing.Point(57, 102);
            this.txtColorR.Name = "txtColorR";
            this.txtColorR.Size = new System.Drawing.Size(100, 20);
            this.txtColorR.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(320, 178);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(494, 181);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(100, 20);
            this.txtOutPut.TabIndex = 4;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(16, 188);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "B";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(16, 150);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(15, 13);
            this.lblG.TabIndex = 6;
            this.lblG.Text = "G";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(16, 105);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(15, 13);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "RGB TO GIANTS COLOR CONVERTER";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.LinkColor = System.Drawing.Color.Black;
            this.lblLink.Location = new System.Drawing.Point(301, 204);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(122, 13);
            this.lblLink.TabIndex = 9;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "made by pics_by_abe ©";
            this.lblLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(648, 178);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(104, 23);
            this.btnCopyToClipboard.TabIndex = 10;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtColorR);
            this.Controls.Add(this.txtColorG);
            this.Controls.Add(this.txtColorB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RBG TO GIANTS COLOR CONERTER | © pics_by_abe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColorB;
        private System.Windows.Forms.TextBox txtColorG;
        private System.Windows.Forms.TextBox txtColorR;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Button btnCopyToClipboard;
    }
}

