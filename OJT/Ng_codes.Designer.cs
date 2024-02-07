
namespace OJT
{
    partial class Ng_codes
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
            this.lblNgCode = new System.Windows.Forms.Label();
            this.lblNgCodeInfo = new System.Windows.Forms.Label();
            this.lvwClassification = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwNgCode = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblNgCode
            // 
            this.lblNgCode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNgCode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNgCode.ForeColor = System.Drawing.Color.White;
            this.lblNgCode.Location = new System.Drawing.Point(46, 28);
            this.lblNgCode.Name = "lblNgCode";
            this.lblNgCode.Size = new System.Drawing.Size(107, 33);
            this.lblNgCode.TabIndex = 2;
            this.lblNgCode.Text = "Code";
            this.lblNgCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNgCodeInfo
            // 
            this.lblNgCodeInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNgCodeInfo.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNgCodeInfo.ForeColor = System.Drawing.Color.White;
            this.lblNgCodeInfo.Location = new System.Drawing.Point(155, 28);
            this.lblNgCodeInfo.Name = "lblNgCodeInfo";
            this.lblNgCodeInfo.Size = new System.Drawing.Size(315, 33);
            this.lblNgCodeInfo.TabIndex = 2;
            this.lblNgCodeInfo.Text = "Info";
            this.lblNgCodeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwClassification
            // 
            this.lvwClassification.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwClassification.GridLines = true;
            this.lvwClassification.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwClassification.HideSelection = false;
            this.lvwClassification.Location = new System.Drawing.Point(46, 64);
            this.lvwClassification.Name = "lvwClassification";
            this.lvwClassification.Size = new System.Drawing.Size(126, 399);
            this.lvwClassification.TabIndex = 4;
            this.lvwClassification.UseCompatibleStateImageBehavior = false;
            this.lvwClassification.View = System.Windows.Forms.View.Details;
            this.lvwClassification.SelectedIndexChanged += new System.EventHandler(this.lvwClassification_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "중분류";
            this.columnHeader1.Width = 120;
            // 
            // lvwNgCode
            // 
            this.lvwNgCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvwNgCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvwNgCode.GridLines = true;
            this.lvwNgCode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwNgCode.HideSelection = false;
            this.lvwNgCode.Location = new System.Drawing.Point(178, 64);
            this.lvwNgCode.Name = "lvwNgCode";
            this.lvwNgCode.Size = new System.Drawing.Size(292, 399);
            this.lvwNgCode.TabIndex = 4;
            this.lvwNgCode.UseCompatibleStateImageBehavior = false;
            this.lvwNgCode.View = System.Windows.Forms.View.Details;
            this.lvwNgCode.SelectedIndexChanged += new System.EventHandler(this.lvwNgCode_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "불량코드";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "불량명";
            this.columnHeader3.Width = 186;
            // 
            // Ng_codes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 506);
            this.Controls.Add(this.lvwNgCode);
            this.Controls.Add(this.lvwClassification);
            this.Controls.Add(this.lblNgCodeInfo);
            this.Controls.Add(this.lblNgCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ng_codes";
            this.ShowIcon = false;
            this.Text = "Ng_codes";
            this.Load += new System.EventHandler(this.Ng_codes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNgCode;
        private System.Windows.Forms.Label lblNgCodeInfo;
        private System.Windows.Forms.ListView lvwClassification;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvwNgCode;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}