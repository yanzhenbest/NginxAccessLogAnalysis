using System;
using System.IO;
using System.Text;

namespace NginxAccessLogAnalysis.Utils
{
    /// <summary>
    /// 文件工具类
    /// </summary>
    /// autor: 刘彦桢
    /// date: 2020-8-20
    public class FileUtils
    {
        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="path">文件绝对路径地址</param>
        /// <returns></returns>
        public static string Read(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                int count = Convert.ToInt32(fs.Length);
                byte[] array = new byte[count];
                fs.Read(array, 0, count);
                return Encoding.UTF8.GetString(array);
            }
        }
    }
}
