using System;
using System.Globalization;

namespace NginxAccessLogAnalysis.Model
{
    /// <summary>
    /// Nginx访问日志
    /// </summary>
    /// Nginx日志格式介绍 https://blog.csdn.net/wanchaopeng/article/details/93205621
    /// autor: 刘彦桢
    /// date: 2020-8-20
    public class BrowseLog
    {
        public BrowseLog() { }
        public BrowseLog(int id, string log)
        {
            Id = id;
            Log = log;
            // $remote_addr - $remote_user [$time_local] "$request" $status $body_bytes_sent "$http_referer" "$http_user_agent" "$http_x_forwarded_for"
            string sign = " - ";
            int index = log.IndexOf(sign);
            if (index > -1)
            {
                RemoteAddr = log.Substring(0, index);
                log = log.Substring(index + sign.Length);
                sign = " [";
                index = log.IndexOf(sign);
                if (index > -1)
                {
                    RemoteUser = log.Substring(0, index);
                    log = log.Substring(index + sign.Length);
                    sign = "] \"";
                    index = log.IndexOf(sign);
                    if (index > -1)
                    {
                        TimeLocal = log.Substring(0, index);
                        log = log.Substring(index + sign.Length);
                        sign = "\" ";
                        index = log.IndexOf(sign);
                        if (index > -1)
                        {
                            Request = log.Substring(0, index);
                            log = log.Substring(index + sign.Length);
                            sign = " ";
                            index = log.IndexOf(sign);
                            if (index > -1)
                            {
                                Status = log.Substring(0, index);
                                log = log.Substring(index + sign.Length);
                                sign = " \"";
                                index = log.IndexOf(sign);
                                if (index > -1)
                                {
                                    BodyBytesSent = log.Substring(0, index);

                                    log = log.Substring(index + sign.Length);
                                    sign = "\" \"";
                                    index = log.IndexOf(sign);
                                    if (index > -1)
                                    {
                                        HttpReferer = log.Substring(0, index);
                                        log = log.Substring(index + sign.Length);
                                        sign = "\"";
                                        index = log.IndexOf(sign);
                                        if (index > -1)
                                        {
                                            HttpUserAgent = log.Substring(0, index);
                                            log = log.Substring(index + sign.Length);
                                            if (!string.IsNullOrEmpty(log))
                                            {
                                                HttpXForwardedFor = log;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    BodyBytesSent = log;
                                    if (BodyBytesSent.Equals("-"))
                                    {
                                        BodyBytesSent = string.Empty;
                                        HttpReferer = "-";
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public int Id { set; get; }
        /// <summary>
        /// 日志字符串
        /// </summary>
        public string Log { set; get; }
        /// <summary>
        /// 客户端地址
        /// </summary>
        public string RemoteAddr { set; get; }
        /// <summary>
        /// 客户端用户名称
        /// </summary>
        public string RemoteUser { set; get; }
        /// <summary>
        /// 访问时间和时区
        /// </summary>
        public string TimeLocal { set; get; }
        /// <summary>
        /// 访问时间
        /// </summary>
        public DateTime? VisitTime
        {
            get
            {
                if (string.IsNullOrEmpty(TimeLocal))
                {
                    return null;
                }
                CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
                string format = "d/MMM/yyyy:HH:mm:ss";
                DateTime datetime = DateTime.ParseExact(TimeLocal.Split(' ')[0], format, cultureInfo);
                return datetime;
            }
        }
        /// <summary>
        /// 访问时区
        /// </summary>
        public string TimeZone
        {
            get
            {
                if (string.IsNullOrEmpty(TimeLocal))
                {
                    return string.Empty;
                }
                return TimeLocal.Split(' ')[1];
            }
        }
        /// <summary>
        /// 请求的URI和HTTP协议
        /// </summary>
        public string Request { set; get; }
        /// <summary>
        /// 请求方式
        /// </summary>
        public string Action
        {
            get
            {
                if (string.IsNullOrEmpty(Request))
                {
                    return string.Empty;
                }
                return Request.Split(' ')[0];
            }
        }
        /// <summary>
        /// 请求地址
        /// </summary>
        public string Uri
        {
            get
            {
                if (string.IsNullOrEmpty(Request))
                {
                    return string.Empty;
                }
                return Request.Split(' ')[1];
            }
        }
        /// <summary>
        /// HTTP请求状态
        /// </summary>
        public string Status { set; get; }
        /// <summary>
        /// 发送给客户端文件内容大小
        /// </summary>
        public string BodyBytesSent { set; get; }
        /// <summary>
        /// url跳转来源
        /// </summary>
        public string HttpReferer { set; get; }
        /// <summary>
        /// 用户终端浏览器等信息
        /// </summary>
        public string HttpUserAgent { set; get; }
        /// <summary>
        /// 请求过程中，upstream响应时间
        /// </summary>
        public string HttpXForwardedFor { set; get; }
    }
}
