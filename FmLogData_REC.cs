using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FileStreamLibrary;
using System.Threading.Tasks;

namespace nsUI
{
    public partial class FmLogData_REC : Form
    {
        private enum ETVClassNode
        {
            Data,

            Count
        }

        private string _ChosenNodeDate;
        private string[] sExceptionCtl;
        readonly int ReadCountNum = 50;
        private string[] _logFiles;
        /// <summary>所選擇的Log檔案內容</summary>
        private string[] LogFileDataArr;
        private string[] FilteredLogFileDataArr;
        private int Segment;
        private int Residue;
        private string _LogPath = "C:\\Log";
        private Keyboard.NumKeyboard _keyboard;
        private bool _UMTC_LuZhu = false;

        public FmLogData_REC()
        {
            InitializeComponent();
            FmBtnClickEvnet(this);
            _keyboard = new Keyboard.NumKeyboard();

            IniFile ini = new IniFile("C:\\Log\\Log.ini", true);
            ini.FileClose();
            ini.Dispose();
            RefreshUI();

            
        }

        private void LoadSubDirectories(TreeNode parentNode)
        {
            string path = parentNode.Tag.ToString();

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dir));
                    node.Tag = dir;

                    // 判斷是否還有子資料夾
                    if (Directory.GetDirectories(dir).Length > 0)
                    {
                        node.Nodes.Add("Loading...");
                    }

                    string[] files = Directory.GetFiles(dir);
                    if (files.Length > 0)
                    {
                        foreach (string file in files)
                        {
                            TreeNode nodeFile = new TreeNode(Path.GetFileName(file));
                            nodeFile.Tag = file;

                            node.Nodes.Add(nodeFile);
                        }
                    }

                    parentNode.Nodes.Add(node);

                    
                }


            }
            catch (UnauthorizedAccessException)
            {
                // 權限不足就略過
            }
        }
        #region Click or CheckedChanged Event
        public void FmBtnClickEvnet(Control Ctrl)
        {
            foreach (Control ctrl in Ctrl.Controls)
            {
                if (ctrl is System.Windows.Forms.Button)
                    ((System.Windows.Forms.Button)ctrl).Click += new EventHandler(FmBtn_Click);
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
                else if (ctrl is RadioButton)
                    ((RadioButton)ctrl).CheckedChanged += new EventHandler(RadioBtn_CheckedChanged);
                else if (ctrl is GroupBox || ctrl is TableLayoutPanel)
                    FmBtnClickEvnet(ctrl);
                else if (ctrl is TabControl)
                {
                    for (int i = 0; i < ((TabControl)ctrl).TabPages.Count; i++)
                        FmBtnClickEvnet(((TabControl)ctrl).TabPages[i]);
                }
            }
        }
        private void FmBtn_Click(object sender, EventArgs e)
        {
     
            LogDef.Add(
                ELogFileName.Operate,
                this.GetType().Name,
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                ((System.Windows.Forms.Button)sender).Name + "[" + ((System.Windows.Forms.Button)sender).Text + "]" + " Click");
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
           

            LogDef.Add(
                ELogFileName.Operate,
                this.GetType().Name,
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                ((CheckBox)sender).Name + "[" + ((CheckBox)sender).Text + "] change to " + ((CheckBox)sender).Checked.ToString());
        }
        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
      

            LogDef.Add(
                ELogFileName.Operate,
                this.GetType().Name,
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                ((RadioButton)sender).Name + "[" + ((RadioButton)sender).Text + "] change to " + ((RadioButton)sender).Checked.ToString());
        }
        #endregion

        private void FmLogData_Load(object sender, EventArgs e)
        {
            this.Font = new Font("新細明體", 12);

            DGV_LogData.BorderStyle = BorderStyle.None;
            DGV_LogData.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold);
            DGV_LogData.RowHeadersVisible = false;
            DGV_LogData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGV_LogData.RowHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold);
            DGV_LogData.RowsDefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular);

           

            NumUD_StartH.Value = NumUD_StartH.Minimum;
            NumUD_EndH.Value = NumUD_EndH.Maximum;
            NumUD_ReplayH.Value = 0;
            NumUD_ReplayM.Value = 0;

            RefreshUI();
        }

        private void ShowNumKeyboard(object sender, EventArgs e) { _keyboard.Call((NumericUpDown)sender); }


        public string[] GetLogFiles()
        {
            List<string> list = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(_LogPath);
            if (Directory.Exists(_LogPath))
            {
                return FindLogDirectory(_LogPath);
            }

            return null;
        }

        public static string[] FindLogDirectory(string targetDirectory)
        {
            List<string> list = new List<string>();
            string[] directories = Directory.GetDirectories(targetDirectory);
            string[] array = directories;
            foreach (string targetDirectory2 in array)
            {
                string[] array2 = LogFiles(targetDirectory2);
                foreach (string item in array2)
                {
                    list.Add(item);
                }
            }

            return list.ToArray();
        }

        public static string[] LogFiles(string targetDirectory)
        {
            List<string> list = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(targetDirectory);
            FileInfo[] files = directoryInfo.GetFiles("*.log");
            foreach (FileInfo fileInfo in files)
            {
                string text = fileInfo.Name.Split('.')[0];
                if (text.Length < 8 || !int.TryParse(text.Substring(0, 8), out var _))
                {
                    list.Add(targetDirectory.Split('\\').Last() + fileInfo.Name);
                }
            }

            return list.ToArray();
        }

        public void RefreshUI()
        {
            TV_Files.Nodes.Clear();
            TreeNode root = new TreeNode(_LogPath);
            root.Tag = _LogPath;

            // 加一個假節點，表示「還沒載入」
            root.Nodes.Add("Loading...");
            TV_Files.Nodes.Add(root);

            //_logFiles = GetLogFiles();
            //Array.Reverse(_logFiles);

            //RefreshTreeView();
        }

      

        private async void DGV_LogData_Scroll(object sender, ScrollEventArgs e)
        {
            await Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    if (e.NewValue + DGV_LogData.DisplayedRowCount(false) >= DGV_LogData.RowCount)
                    {
                        if (FilteredLogFileDataArr.Length != 0)
                        {
                            string[] _strarr;
                            int ResidueBuf = DGV_LogData.RowCount % ReadCountNum;
                            int SegmentBuf = (DGV_LogData.RowCount - ResidueBuf) / ReadCountNum;

                            if (DGV_LogData.RowCount + ReadCountNum > FilteredLogFileDataArr.Length)
                                DGV_LogData.RowCount = FilteredLogFileDataArr.Length;
                            else
                                DGV_LogData.RowCount += ReadCountNum;

                            for (int i = (SegmentBuf * ReadCountNum + ResidueBuf - 1); i < Segment * ReadCountNum + Residue; i++)
                            {
                                if (i < DGV_LogData.RowCount)
                                {
                                    if (_UMTC_LuZhu)
                                        _strarr = Regex.Split(FilteredLogFileDataArr[i], ",");
                                    else
                                        _strarr = Regex.Split(FilteredLogFileDataArr[i], "---");
                                    if (_strarr[0].Length > 24)
                                        _strarr[0] = _strarr[0].Substring(11, 13);

                                    for (int j = 0; j < DGV_LogData.Rows[i].Cells.Count; j++)
                                    {
                                        if (_strarr.Length > j)
                                            DGV_LogData.Rows[i].Cells[j].Value = _strarr[j];
                                    }
                                    for (int j = DGV_LogData.Rows[i].Cells.Count; j < _strarr.Length; j++)
                                    {
                                        if (_strarr.Length > j)
                                            DGV_LogData.Rows[i].Cells[DGV_LogData.Rows[i].Cells.Count - 1].Value += _strarr[j];
                                    }
                                }
                                else
                                    break;
                            }
                        }
                    }

                    CB_Mode.Location = new Point(DGV_LogData.Location.X + DGV_LogData.Columns[0].Width + 1, DGV_LogData.Location.Y + 1);//更新控件位置
                    CB_Mode.Width = DGV_LogData.Columns[1].Width;//設定控件寬度
                    CB_Mode.Visible = true;
                    CB_Mode.BringToFront();//控件移至最頂層
                }));
            });
        }

        private void ShowDataToViewLog()
        {
            string[] _strarr;

            DGV_LogData.Rows.Clear();

            RenewHeaderText();

            for (int i = 0; i < Segment * ReadCountNum + Residue; i++)
            {
                if (i < ReadCountNum)
                {
                    if (_UMTC_LuZhu)
                        _strarr = Regex.Split(FilteredLogFileDataArr[i], ",");
                    else
                        _strarr = Regex.Split(FilteredLogFileDataArr[i], "---");
                    if (_strarr[0].Length > 24)
                        _strarr[0] = _strarr[0].Substring(11, 13);

                    for (int j = 0; j < DGV_LogData.Rows[i].Cells.Count; j++)
                    {
                        if (_strarr.Length <= j)
                            break;
                        DGV_LogData.Rows[i].Cells[j].Value = _strarr[j];
                    }
                    for (int j = DGV_LogData.Rows[i].Cells.Count; j < _strarr.Length; j++)
                    {
                        if (_strarr.Length <= j)
                            break;
                        DGV_LogData.Rows[i].Cells[DGV_LogData.Rows[i].Cells.Count - 1].Value += _strarr[j];
                    }
                }
                else
                    break;
            }

            CB_Mode.Location = new Point(DGV_LogData.Location.X + DGV_LogData.Columns[0].Width, DGV_LogData.Location.Y);//更新控件位置
            CB_Mode.Width = DGV_LogData.Columns[1].Width;//設定控件寬度
            CB_Mode.Visible = true;
            CB_Mode.BringToFront();//控件移至最頂層
        }

        /// <summary>讀取確認行數並更新[HeaderText]名稱</summary>
        private void RenewHeaderText()
        {
            if (String.IsNullOrEmpty(_ChosenNodeDate))
                _ChosenNodeDate = "Time";

            DGV_LogData.Columns[0].HeaderText = _ChosenNodeDate;
            // DGV_LogData.Columns[0].Frozen = true;
            DGV_LogData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // DGV_LogData.Columns[1].Frozen = true;

            Residue = FilteredLogFileDataArr.Length % ReadCountNum;
            Segment = (FilteredLogFileDataArr.Length - Residue) / ReadCountNum;

            if (Residue == 0 && Segment == 0)
            {
                DGV_LogData.RowCount = 1;
                DGV_LogData.Columns[3].HeaderText = "Data";
            }
            else
            {
                if (Segment > 0)
                    DGV_LogData.RowCount = ReadCountNum;
                else
                    DGV_LogData.RowCount = Residue;

                DGV_LogData.Columns[3].HeaderText = "Data (" + FilteredLogFileDataArr.Length + ")";
            }
        }

        private void RenewFilteredLogFileDataArr()
        {
            if (CB_Mode.SelectedIndex < 0)
                return;

            List<string> FilteredList = new List<string>();
            if (CB_Mode.SelectedIndex == 0 && (NumUD_EndH.Value - NumUD_StartH.Value) == 23)
            {
                FilteredLogFileDataArr = LogFileDataArr;
            }
            else
            {
                for (int i = 0; i < LogFileDataArr.Length; i++)
                {
                    string[] strArray;
                    if (_UMTC_LuZhu)
                        strArray = Regex.Split(LogFileDataArr[i], ",");
                    else
                        strArray = Regex.Split(LogFileDataArr[i], "---");

                    if (CB_Mode.SelectedIndex == 0 || (strArray != null && strArray.Length > 1 && CB_Mode.Text.ToLower() == strArray[1].ToLower()))
                    {
                        if (NumUD_StartH.Value <= NumUD_EndH.Value)
                        {
                            int iH = -1;
                            if (strArray[0].Length > 14 && int.TryParse(strArray[0].Substring(12, 2), out iH))
                            {
                                if (iH >= (int)NumUD_StartH.Value && iH <= (int)NumUD_EndH.Value)
                                    FilteredList.Add(LogFileDataArr[i]);
                            }
                        }
                        else
                            FilteredList.Add(LogFileDataArr[i]);
                    }
                }

                FilteredLogFileDataArr = FilteredList.ToArray();
            }

            ShowDataToViewLog();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_LogPath);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Close();
            //G.UI.frmMainFm.Invoke(new Action(() => { G.UI.frmMainFm.TopPanel_Hide(); }));
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            //RenewLang();
            RefreshUI();
        }

        private void FmLogData_VisibleChanged(object sender, EventArgs e)
        {
            
        }
        private void RenewLang()
        {
            //if (!G.Comm.LangV2.Get(this))
            //{
            //    G.Comm.LangV2.Add(this, sExceptionCtl);
            //    RenewLang();
            //}
        }

        private void TV_Files_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (!File.Exists(e.Node.Tag.ToString()))
            {
                return;
            }


            string sNodePath = e.Node.Tag.ToString();
            if (sNodePath.IndexOf("UMTC_LuZhu") > 0)
                _UMTC_LuZhu = true;
            else
                _UMTC_LuZhu = false;

            LogFileDataArr = Read(sNodePath);
            Array.Reverse(LogFileDataArr);
            if (LogFileDataArr == null)
                return;

            #region Log模式下拉選單基礎建立
            CB_Mode.Items.Clear();//清空模式下拉選單
            CB_Mode.Items.Add("All");//新增基礎選項
            CB_Mode.SelectedIndex = 0;
            #endregion


            for(int i = 0; i < LogFileDataArr.Length; i++)
            {
                string[] data;
                if (_UMTC_LuZhu)
                    data = Regex.Split(LogFileDataArr[i], ",");
                else
                    data = Regex.Split(LogFileDataArr[i], "---");

                if (data.Length > 1)
                {
                    string str = data[1];
                    if (CB_Mode.FindStringExact(str) < 0)
                        CB_Mode.Items.Add(str);
                }
            }


            RenewFilteredLogFileDataArr();

            //for (int i = 0; i < _logFiles.Length; i++)
            //{
            //    string sDateDir = _logFiles[i].Substring(0, 6);
            //    string sFileName = _logFiles[i].Substring(6, _logFiles[i].Length - 6);

            //    int iBuf = -1;
            //    if (int.TryParse(sDateDir, out iBuf) &&
            //        _logFiles[i].Substring(0, 8).ToLower() == sPathAry[1].ToLower() &&
            //        _logFiles[i].Substring(8, _logFiles[i].Length - 8).ToLower() == (sPathAry[2] + ".log").ToLower())
            //    {
            //        LblLogFilePath.Text = _LogPath + "\\" + sDateDir + "\\" + sFileName;
            //        string[] sLogDataBuf = Read((sDateDir + "\\" + sFileName).Split('.')[0]);
            //        for (int j = 0; j < sLogDataBuf.Length; j++)
            //        {
            //            LogDataList.Add(sLogDataBuf[j]);

            //            string sDataBuf = Regex.Split(sLogDataBuf[j], "---")[1];
            //            #region Log模式下拉選單更新
            //            if (CB_Mode.FindStringExact(sDataBuf) < 0)
            //                CB_Mode.Items.Add(sDataBuf);
            //            #endregion
            //        }
            //    }
            //}


        }


        public string[] Read(string logFilePath)
        {
            try
            {
                Encoding encoding = Encoding.UTF8;
                //byte[] array = new byte[5];
                //using (FileStream fileStream = new FileStream(logFilePath, FileMode.Open))
                //{
                //    fileStream.Read(array, 0, 5);
                //    fileStream.Close();
                //    if (array[0] == 239 && array[1] == 187 && array[2] == 191)
                //    {
                //        encoding = Encoding.UTF8;
                //    }
                //}

                FileStream fileStream2 = File.Open(logFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamReader streamReader = new StreamReader(fileStream2, encoding);
                List<string> strList = new List<string>();
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadLine().Trim();
                    strList.Add(text);
                }

                fileStream2.Close();
                streamReader.Close();
                fileStream2.Dispose();
                streamReader.Dispose();

                return strList.ToArray();
            }
            catch (Exception ex)
            {
                LogDef.Add(
                ELogFileName.Operate,
                this.GetType().Name,
                System.Reflection.MethodBase.GetCurrentMethod().Name,
                   "Error:" + ex.ToString());

                return null;
            }
        }
        private void CB_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenewFilteredLogFileDataArr();
        }

        private void NumUDRangeH_ValueChanged(object sender, EventArgs e)
        {
            if (NumUD_StartH.Value > NumUD_EndH.Value)
            {
                switch (((NumericUpDown)sender).Name)
                {
                    case "NumUD_StartH":
                        NumUD_EndH.Value = NumUD_StartH.Value;
                        return;
                    case "NumUD_EndH":
                        NumUD_StartH.Value = NumUD_EndH.Value;
                        return;
                    default:
                        break;
                }
            }

            RenewFilteredLogFileDataArr();
        }

        private void DGV_LogData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1)
            //{
            //    string strTime = DGV_LogData.Columns[0].HeaderText + DGV_LogData.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(0, 9);
            //    DateTime dt;
            //    if (DateTime.TryParseExact(strTime,
            //        "yyyy-MM-dd HH:mm:ss",
            //        System.Globalization.CultureInfo.InvariantCulture,
            //        System.Globalization.DateTimeStyles.None,
            //        out dt))
            //    {
            //        for (int i = 0; i < G.Vision.GetViedoCamNum(); i++)
            //            G.Vision.Replay_Viedo(i, dt, false);
            //    }
            //}
        }

        private void BtnReplay_Click(object sender, EventArgs e)
        {
            //string strTime = DTP_Replay.Text + " " + NumUD_ReplayH.Value.ToString("00") + ":" + NumUD_ReplayM.Value.ToString("00") + ":00";
            //DateTime dt;
            //if (DateTime.TryParseExact(strTime,
            //        "yyyy-MM-dd HH:mm:ss",
            //        System.Globalization.CultureInfo.InvariantCulture,
            //        System.Globalization.DateTimeStyles.None,
            //        out dt))
            //{
            //    for (int i = 0; i < G.Vision.GetViedoCamNum(); i++)
            //        G.Vision.Replay_Viedo(i, dt, true);
            //}
        }

        private void FmLogData_REC_Shown(object sender, EventArgs e)
        {

        }

        private void TV_Files_AfterExpand(object sender, TreeViewEventArgs e)
        {
            
        }

        private void TV_Files_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "Loading...")
            {
                e.Node.Nodes.Clear();
                LoadSubDirectories(e.Node);
            }
        }
    }
}