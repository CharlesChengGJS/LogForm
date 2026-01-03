namespace nsUI
{
    partial class FmLogData_REC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLogData_REC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSync = new System.Windows.Forms.Button();
            this.BtnFolder = new System.Windows.Forms.Button();
            this.TV_Files = new System.Windows.Forms.TreeView();
            this.LblLogTitle = new System.Windows.Forms.Label();
            this.DGV_LogData = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblLogFilePath = new System.Windows.Forms.Label();
            this.GB_TimeRange = new System.Windows.Forms.GroupBox();
            this.NumUD_EndH = new System.Windows.Forms.NumericUpDown();
            this.NumUD_StartH = new System.Windows.Forms.NumericUpDown();
            this.Lbl_To = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.GB_ReplayTimeRange = new System.Windows.Forms.GroupBox();
            this.DTP_Replay = new System.Windows.Forms.DateTimePicker();
            this.NumUD_ReplayM = new System.Windows.Forms.NumericUpDown();
            this.NumUD_ReplayH = new System.Windows.Forms.NumericUpDown();
            this.Lbl_ReplayTo = new System.Windows.Forms.Label();
            this.BtnReplay = new System.Windows.Forms.Button();
            this.CB_Mode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LogData)).BeginInit();
            this.GB_TimeRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_EndH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_StartH)).BeginInit();
            this.GB_ReplayTimeRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ReplayM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ReplayH)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSync
            // 
            this.BtnSync.Image = ((System.Drawing.Image)(resources.GetObject("BtnSync.Image")));
            this.BtnSync.Location = new System.Drawing.Point(10, 503);
            this.BtnSync.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnSync.Name = "BtnSync";
            this.BtnSync.Size = new System.Drawing.Size(60, 60);
            this.BtnSync.TabIndex = 51;
            this.BtnSync.UseVisualStyleBackColor = true;
            this.BtnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // BtnFolder
            // 
            this.BtnFolder.Image = ((System.Drawing.Image)(resources.GetObject("BtnFolder.Image")));
            this.BtnFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnFolder.Location = new System.Drawing.Point(90, 503);
            this.BtnFolder.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnFolder.Name = "BtnFolder";
            this.BtnFolder.Size = new System.Drawing.Size(60, 60);
            this.BtnFolder.TabIndex = 48;
            this.BtnFolder.UseVisualStyleBackColor = true;
            this.BtnFolder.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // TV_Files
            // 
            this.TV_Files.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TV_Files.Location = new System.Drawing.Point(0, 24);
            this.TV_Files.Name = "TV_Files";
            this.TV_Files.Size = new System.Drawing.Size(160, 417);
            this.TV_Files.TabIndex = 52;
            this.TV_Files.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TV_Files_BeforeExpand);
            this.TV_Files.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TV_Files_AfterExpand);
            this.TV_Files.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_Files_AfterSelect);
            // 
            // LblLogTitle
            // 
            this.LblLogTitle.AutoSize = true;
            this.LblLogTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblLogTitle.Location = new System.Drawing.Point(0, 0);
            this.LblLogTitle.Name = "LblLogTitle";
            this.LblLogTitle.Size = new System.Drawing.Size(48, 24);
            this.LblLogTitle.TabIndex = 53;
            this.LblLogTitle.Text = "日誌";
            // 
            // DGV_LogData
            // 
            this.DGV_LogData.AllowUserToAddRows = false;
            this.DGV_LogData.AllowUserToDeleteRows = false;
            this.DGV_LogData.AllowUserToResizeColumns = false;
            this.DGV_LogData.AllowUserToResizeRows = false;
            this.DGV_LogData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_LogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LogData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColMode,
            this.ColAction,
            this.ColValue});
            this.DGV_LogData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_LogData.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DGV_LogData.Location = new System.Drawing.Point(160, 24);
            this.DGV_LogData.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DGV_LogData.MultiSelect = false;
            this.DGV_LogData.Name = "DGV_LogData";
            this.DGV_LogData.ReadOnly = true;
            this.DGV_LogData.RowHeadersVisible = false;
            this.DGV_LogData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DGV_LogData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_LogData.RowTemplate.Height = 24;
            this.DGV_LogData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_LogData.Size = new System.Drawing.Size(858, 730);
            this.DGV_LogData.TabIndex = 55;
            this.DGV_LogData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_LogData_CellClick);
            this.DGV_LogData.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DGV_LogData_Scroll);
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColName.FillWeight = 370F;
            this.ColName.HeaderText = "Time";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColName.Width = 45;
            // 
            // ColMode
            // 
            this.ColMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColMode.FillWeight = 220F;
            this.ColMode.HeaderText = "Mode";
            this.ColMode.Name = "ColMode";
            this.ColMode.ReadOnly = true;
            this.ColMode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColMode.Width = 49;
            // 
            // ColAction
            // 
            this.ColAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColAction.HeaderText = "Action";
            this.ColAction.Name = "ColAction";
            this.ColAction.ReadOnly = true;
            this.ColAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColAction.Width = 55;
            // 
            // ColValue
            // 
            this.ColValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColValue.HeaderText = "Data";
            this.ColValue.Name = "ColValue";
            this.ColValue.ReadOnly = true;
            this.ColValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColValue.Width = 42;
            // 
            // LblLogFilePath
            // 
            this.LblLogFilePath.AutoSize = true;
            this.LblLogFilePath.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblLogFilePath.Location = new System.Drawing.Point(160, 4);
            this.LblLogFilePath.Name = "LblLogFilePath";
            this.LblLogFilePath.Size = new System.Drawing.Size(69, 20);
            this.LblLogFilePath.TabIndex = 53;
            this.LblLogFilePath.Text = "FilePath";
            // 
            // GB_TimeRange
            // 
            this.GB_TimeRange.Controls.Add(this.NumUD_EndH);
            this.GB_TimeRange.Controls.Add(this.NumUD_StartH);
            this.GB_TimeRange.Controls.Add(this.Lbl_To);
            this.GB_TimeRange.Location = new System.Drawing.Point(0, 447);
            this.GB_TimeRange.Name = "GB_TimeRange";
            this.GB_TimeRange.Size = new System.Drawing.Size(160, 50);
            this.GB_TimeRange.TabIndex = 57;
            this.GB_TimeRange.TabStop = false;
            this.GB_TimeRange.Text = "Range";
            // 
            // NumUD_EndH
            // 
            this.NumUD_EndH.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.NumUD_EndH.Location = new System.Drawing.Point(90, 17);
            this.NumUD_EndH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumUD_EndH.Name = "NumUD_EndH";
            this.NumUD_EndH.Size = new System.Drawing.Size(60, 28);
            this.NumUD_EndH.TabIndex = 58;
            this.NumUD_EndH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUD_EndH.ValueChanged += new System.EventHandler(this.NumUDRangeH_ValueChanged);
            this.NumUD_EndH.Click += new System.EventHandler(this.ShowNumKeyboard);
            // 
            // NumUD_StartH
            // 
            this.NumUD_StartH.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.NumUD_StartH.Location = new System.Drawing.Point(10, 17);
            this.NumUD_StartH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumUD_StartH.Name = "NumUD_StartH";
            this.NumUD_StartH.Size = new System.Drawing.Size(60, 28);
            this.NumUD_StartH.TabIndex = 58;
            this.NumUD_StartH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUD_StartH.ValueChanged += new System.EventHandler(this.NumUDRangeH_ValueChanged);
            this.NumUD_StartH.Click += new System.EventHandler(this.ShowNumKeyboard);
            // 
            // Lbl_To
            // 
            this.Lbl_To.AutoSize = true;
            this.Lbl_To.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_To.Location = new System.Drawing.Point(70, 19);
            this.Lbl_To.Name = "Lbl_To";
            this.Lbl_To.Size = new System.Drawing.Size(21, 20);
            this.Lbl_To.TabIndex = 53;
            this.Lbl_To.Text = "~";
            // 
            // BtnReturn
            // 
            this.BtnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnReturn.Location = new System.Drawing.Point(10, 711);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(1);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(140, 45);
            this.BtnReturn.TabIndex = 48;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // GB_ReplayTimeRange
            // 
            this.GB_ReplayTimeRange.Controls.Add(this.DTP_Replay);
            this.GB_ReplayTimeRange.Controls.Add(this.NumUD_ReplayM);
            this.GB_ReplayTimeRange.Controls.Add(this.NumUD_ReplayH);
            this.GB_ReplayTimeRange.Controls.Add(this.Lbl_ReplayTo);
            this.GB_ReplayTimeRange.Location = new System.Drawing.Point(0, 569);
            this.GB_ReplayTimeRange.Name = "GB_ReplayTimeRange";
            this.GB_ReplayTimeRange.Size = new System.Drawing.Size(160, 80);
            this.GB_ReplayTimeRange.TabIndex = 72;
            this.GB_ReplayTimeRange.TabStop = false;
            this.GB_ReplayTimeRange.Text = "Replay Start";
            this.GB_ReplayTimeRange.Visible = false;
            // 
            // DTP_Replay
            // 
            this.DTP_Replay.CustomFormat = "yyyy-MM-dd";
            this.DTP_Replay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Replay.Location = new System.Drawing.Point(10, 17);
            this.DTP_Replay.Name = "DTP_Replay";
            this.DTP_Replay.Size = new System.Drawing.Size(140, 27);
            this.DTP_Replay.TabIndex = 74;
            // 
            // NumUD_ReplayM
            // 
            this.NumUD_ReplayM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.NumUD_ReplayM.Location = new System.Drawing.Point(90, 47);
            this.NumUD_ReplayM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumUD_ReplayM.Name = "NumUD_ReplayM";
            this.NumUD_ReplayM.Size = new System.Drawing.Size(60, 28);
            this.NumUD_ReplayM.TabIndex = 61;
            this.NumUD_ReplayM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUD_ReplayM.Click += new System.EventHandler(this.ShowNumKeyboard);
            // 
            // NumUD_ReplayH
            // 
            this.NumUD_ReplayH.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.NumUD_ReplayH.Location = new System.Drawing.Point(10, 47);
            this.NumUD_ReplayH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumUD_ReplayH.Name = "NumUD_ReplayH";
            this.NumUD_ReplayH.Size = new System.Drawing.Size(60, 28);
            this.NumUD_ReplayH.TabIndex = 60;
            this.NumUD_ReplayH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUD_ReplayH.Click += new System.EventHandler(this.ShowNumKeyboard);
            // 
            // Lbl_ReplayTo
            // 
            this.Lbl_ReplayTo.AutoSize = true;
            this.Lbl_ReplayTo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_ReplayTo.Location = new System.Drawing.Point(70, 49);
            this.Lbl_ReplayTo.Name = "Lbl_ReplayTo";
            this.Lbl_ReplayTo.Size = new System.Drawing.Size(21, 20);
            this.Lbl_ReplayTo.TabIndex = 59;
            this.Lbl_ReplayTo.Text = "~";
            // 
            // BtnReplay
            // 
            this.BtnReplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnReplay.Location = new System.Drawing.Point(10, 653);
            this.BtnReplay.Margin = new System.Windows.Forms.Padding(1);
            this.BtnReplay.Name = "BtnReplay";
            this.BtnReplay.Size = new System.Drawing.Size(140, 45);
            this.BtnReplay.TabIndex = 73;
            this.BtnReplay.Text = "播放";
            this.BtnReplay.UseVisualStyleBackColor = true;
            this.BtnReplay.Visible = false;
            this.BtnReplay.Click += new System.EventHandler(this.BtnReplay_Click);
            // 
            // CB_Mode
            // 
            this.CB_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Mode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F);
            this.CB_Mode.FormattingEnabled = true;
            this.CB_Mode.Location = new System.Drawing.Point(435, 0);
            this.CB_Mode.Name = "CB_Mode";
            this.CB_Mode.Size = new System.Drawing.Size(200, 32);
            this.CB_Mode.TabIndex = 56;
            this.CB_Mode.Visible = false;
            this.CB_Mode.SelectedIndexChanged += new System.EventHandler(this.CB_Mode_SelectedIndexChanged);
            // 
            // FmLogData_REC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 766);
            this.Controls.Add(this.BtnReplay);
            this.Controls.Add(this.GB_ReplayTimeRange);
            this.Controls.Add(this.GB_TimeRange);
            this.Controls.Add(this.CB_Mode);
            this.Controls.Add(this.DGV_LogData);
            this.Controls.Add(this.LblLogFilePath);
            this.Controls.Add(this.LblLogTitle);
            this.Controls.Add(this.TV_Files);
            this.Controls.Add(this.BtnSync);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnFolder);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmLogData_REC";
            this.Text = "LogDataREC";
            this.Load += new System.EventHandler(this.FmLogData_Load);
            this.Shown += new System.EventHandler(this.FmLogData_REC_Shown);
            this.VisibleChanged += new System.EventHandler(this.FmLogData_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LogData)).EndInit();
            this.GB_TimeRange.ResumeLayout(false);
            this.GB_TimeRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_EndH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_StartH)).EndInit();
            this.GB_ReplayTimeRange.ResumeLayout(false);
            this.GB_ReplayTimeRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ReplayM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_ReplayH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFolder;
        private System.Windows.Forms.Button BtnSync;
        private System.Windows.Forms.TreeView TV_Files;
        private System.Windows.Forms.Label LblLogTitle;
        private System.Windows.Forms.DataGridView DGV_LogData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.Label LblLogFilePath;
        private System.Windows.Forms.GroupBox GB_TimeRange;
        private System.Windows.Forms.NumericUpDown NumUD_StartH;
        private System.Windows.Forms.NumericUpDown NumUD_EndH;
        private System.Windows.Forms.Label Lbl_To;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.GroupBox GB_ReplayTimeRange;
        private System.Windows.Forms.Button BtnReplay;
        private System.Windows.Forms.NumericUpDown NumUD_ReplayM;
        private System.Windows.Forms.NumericUpDown NumUD_ReplayH;
        private System.Windows.Forms.Label Lbl_ReplayTo;
        private System.Windows.Forms.DateTimePicker DTP_Replay;
        private System.Windows.Forms.ComboBox CB_Mode;
    }
}