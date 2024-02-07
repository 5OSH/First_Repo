
namespace OJT
{
    partial class Model_Edit
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
            this.NewButton = new System.Windows.Forms.Button();
            this.ModelListView = new System.Windows.Forms.ListView();
            this.ModelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelNameTB = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClockTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.H_Active = new System.Windows.Forms.TextBox();
            this.H_FrontPorch = new System.Windows.Forms.TextBox();
            this.H_SyncWidth = new System.Windows.Forms.TextBox();
            this.H_BackPorch = new System.Windows.Forms.TextBox();
            this.H_Total = new System.Windows.Forms.TextBox();
            this.H_Frequency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.V_Active = new System.Windows.Forms.TextBox();
            this.V_FrontPorch = new System.Windows.Forms.TextBox();
            this.V_SyncWidth = new System.Windows.Forms.TextBox();
            this.V_BackPorch = new System.Windows.Forms.TextBox();
            this.V_Total = new System.Windows.Forms.TextBox();
            this.V_Frequency = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewButton.Location = new System.Drawing.Point(24, 63);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(65, 29);
            this.NewButton.TabIndex = 1;
            this.NewButton.TabStop = false;
            this.NewButton.Text = "New";
            this.NewButton.UseMnemonic = false;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ModelListView
            // 
            this.ModelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModelName});
            this.ModelListView.GridLines = true;
            this.ModelListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ModelListView.HideSelection = false;
            this.ModelListView.Location = new System.Drawing.Point(24, 98);
            this.ModelListView.Name = "ModelListView";
            this.ModelListView.Size = new System.Drawing.Size(278, 340);
            this.ModelListView.TabIndex = 2;
            this.ModelListView.TabStop = false;
            this.ModelListView.UseCompatibleStateImageBehavior = false;
            this.ModelListView.View = System.Windows.Forms.View.Details;
            this.ModelListView.SelectedIndexChanged += new System.EventHandler(this.ModelListView_SelectedIndexChanged);
            // 
            // ModelName
            // 
            this.ModelName.Width = 600;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(318, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timing Setting";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(321, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelNameTB
            // 
            this.ModelNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelNameTB.Location = new System.Drawing.Point(24, 36);
            this.ModelNameTB.Name = "ModelNameTB";
            this.ModelNameTB.Size = new System.Drawing.Size(278, 21);
            this.ModelNameTB.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteButton.Location = new System.Drawing.Point(95, 63);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(65, 29);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RenameButton.Location = new System.Drawing.Point(166, 63);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(65, 29);
            this.RenameButton.TabIndex = 1;
            this.RenameButton.TabStop = false;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CopyButton.Location = new System.Drawing.Point(237, 63);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(65, 29);
            this.CopyButton.TabIndex = 1;
            this.CopyButton.TabStop = false;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(320, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Active";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(320, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Front Porch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(320, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sync Width";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(320, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Back Porch";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(320, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(320, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Frequency";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockTB
            // 
            this.ClockTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClockTB.Location = new System.Drawing.Point(426, 38);
            this.ClockTB.Name = "ClockTB";
            this.ClockTB.Size = new System.Drawing.Size(73, 21);
            this.ClockTB.TabIndex = 2;
            this.ClockTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(505, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "(MHz)";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(426, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Horizontal";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // H_Active
            // 
            this.H_Active.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_Active.Location = new System.Drawing.Point(426, 98);
            this.H_Active.Name = "H_Active";
            this.H_Active.Size = new System.Drawing.Size(73, 21);
            this.H_Active.TabIndex = 3;
            this.H_Active.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H_FrontPorch
            // 
            this.H_FrontPorch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_FrontPorch.Location = new System.Drawing.Point(426, 127);
            this.H_FrontPorch.Name = "H_FrontPorch";
            this.H_FrontPorch.Size = new System.Drawing.Size(73, 21);
            this.H_FrontPorch.TabIndex = 4;
            this.H_FrontPorch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H_SyncWidth
            // 
            this.H_SyncWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_SyncWidth.Location = new System.Drawing.Point(426, 156);
            this.H_SyncWidth.Name = "H_SyncWidth";
            this.H_SyncWidth.Size = new System.Drawing.Size(73, 21);
            this.H_SyncWidth.TabIndex = 5;
            this.H_SyncWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H_BackPorch
            // 
            this.H_BackPorch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_BackPorch.Location = new System.Drawing.Point(426, 185);
            this.H_BackPorch.Name = "H_BackPorch";
            this.H_BackPorch.Size = new System.Drawing.Size(73, 21);
            this.H_BackPorch.TabIndex = 6;
            this.H_BackPorch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H_Total
            // 
            this.H_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_Total.Location = new System.Drawing.Point(426, 214);
            this.H_Total.Name = "H_Total";
            this.H_Total.ReadOnly = true;
            this.H_Total.Size = new System.Drawing.Size(73, 21);
            this.H_Total.TabIndex = 5;
            this.H_Total.TabStop = false;
            this.H_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H_Frequency
            // 
            this.H_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_Frequency.Location = new System.Drawing.Point(426, 243);
            this.H_Frequency.Name = "H_Frequency";
            this.H_Frequency.ReadOnly = true;
            this.H_Frequency.Size = new System.Drawing.Size(73, 21);
            this.H_Frequency.TabIndex = 5;
            this.H_Frequency.TabStop = false;
            this.H_Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(504, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "(Pixels)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(505, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "(Pixels)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(505, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "(Pixels)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(505, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "(Pixels)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(505, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "(Pixels)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(505, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "(KHz)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(664, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "(Lines)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(665, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "(Lines)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(665, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "(Lines)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(665, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "(Lines)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(665, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "(Lines)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(665, 244);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 3;
            this.label22.Text = "(Hz)";
            // 
            // V_Active
            // 
            this.V_Active.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V_Active.Location = new System.Drawing.Point(586, 98);
            this.V_Active.Name = "V_Active";
            this.V_Active.Size = new System.Drawing.Size(73, 21);
            this.V_Active.TabIndex = 7;
            this.V_Active.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // V_FrontPorch
            // 
            this.V_FrontPorch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V_FrontPorch.Location = new System.Drawing.Point(586, 127);
            this.V_FrontPorch.Name = "V_FrontPorch";
            this.V_FrontPorch.Size = new System.Drawing.Size(73, 21);
            this.V_FrontPorch.TabIndex = 8;
            this.V_FrontPorch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // V_SyncWidth
            // 
            this.V_SyncWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V_SyncWidth.Location = new System.Drawing.Point(586, 156);
            this.V_SyncWidth.Name = "V_SyncWidth";
            this.V_SyncWidth.Size = new System.Drawing.Size(73, 21);
            this.V_SyncWidth.TabIndex = 9;
            this.V_SyncWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // V_BackPorch
            // 
            this.V_BackPorch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V_BackPorch.Location = new System.Drawing.Point(586, 185);
            this.V_BackPorch.Name = "V_BackPorch";
            this.V_BackPorch.Size = new System.Drawing.Size(73, 21);
            this.V_BackPorch.TabIndex = 10;
            this.V_BackPorch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // V_Total
            // 
            this.V_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V_Total.Location = new System.Drawing.Point(586, 214);
            this.V_Total.Name = "V_Total";
            this.V_Total.ReadOnly = true;
            this.V_Total.Size = new System.Drawing.Size(73, 21);
            this.V_Total.TabIndex = 5;
            this.V_Total.TabStop = false;
            this.V_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // V_Frequency
            // 
            this.V_Frequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V_Frequency.Location = new System.Drawing.Point(586, 243);
            this.V_Frequency.Name = "V_Frequency";
            this.V_Frequency.ReadOnly = true;
            this.V_Frequency.Size = new System.Drawing.Size(73, 21);
            this.V_Frequency.TabIndex = 5;
            this.V_Frequency.TabStop = false;
            this.V_Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(758, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 53);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(587, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 21);
            this.label23.TabIndex = 3;
            this.label23.Text = "Vertical";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(758, 94);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(141, 53);
            this.btnSaveExit.TabIndex = 12;
            this.btnSaveExit.Text = "Save && Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(758, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 53);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(587, 311);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(141, 53);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.TabStop = false;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Model_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(911, 497);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.V_Frequency);
            this.Controls.Add(this.H_Frequency);
            this.Controls.Add(this.V_Total);
            this.Controls.Add(this.H_Total);
            this.Controls.Add(this.V_BackPorch);
            this.Controls.Add(this.H_BackPorch);
            this.Controls.Add(this.V_SyncWidth);
            this.Controls.Add(this.H_SyncWidth);
            this.Controls.Add(this.V_FrontPorch);
            this.Controls.Add(this.V_Active);
            this.Controls.Add(this.H_FrontPorch);
            this.Controls.Add(this.H_Active);
            this.Controls.Add(this.ClockTB);
            this.Controls.Add(this.ModelNameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModelListView);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Model_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model_Edit";
            this.Load += new System.EventHandler(this.Model_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ListView ModelListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelNameTB;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ClockTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox H_Active;
        private System.Windows.Forms.TextBox H_FrontPorch;
        private System.Windows.Forms.TextBox H_SyncWidth;
        private System.Windows.Forms.TextBox H_BackPorch;
        private System.Windows.Forms.TextBox H_Total;
        private System.Windows.Forms.TextBox H_Frequency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox V_Active;
        private System.Windows.Forms.TextBox V_FrontPorch;
        private System.Windows.Forms.TextBox V_SyncWidth;
        private System.Windows.Forms.TextBox V_BackPorch;
        private System.Windows.Forms.TextBox V_Total;
        private System.Windows.Forms.TextBox V_Frequency;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader ModelName;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}