using NginxAccessLogAnalysis.Model;
using NginxAccessLogAnalysis.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NginxAccessLogAnalysis
{
    /// <summary>
    /// 
    /// </summary>
    /// autor: 刘彦桢
    /// date: 2020-8-20
    public partial class Form1 : Form
    {
        private List<BrowseLog> listBrowseLog = new List<BrowseLog>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "选择Nginx日志文件";
            fileDialog.Filter = "Nginx日志文件(*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = lFileName.Text = fileDialog.FileName;
                string strLog = FileUtils.Read(fileName);
                if (string.IsNullOrEmpty(strLog))
                {
                    MessageBox.Show("Nginx日志为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string[] arrayLog = strLog.Split('\n');
                listBrowseLog = new List<BrowseLog>();
                for (int i = 0; i < arrayLog.Length; i++)
                {
                    listBrowseLog.Add(new BrowseLog(i + 1, arrayLog[i]));
                }
                dgvLog.DataSource = ListUtils.ToDataTable(listBrowseLog);
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvLog.DataSource = ListUtils.ToDataTable(listBrowseLog); ;
                return;
            }
            List<BrowseLog> searchList = listBrowseLog.Where(item => item.Log.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) > -1).ToList();
            dgvLog.DataSource = ListUtils.ToDataTable(searchList);
        }
    }
}
