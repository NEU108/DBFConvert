using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DBFConvert.Src
{
    public class FileWatchHelper
    {

        public static System.IO.FileSystemWatcher m_Watcher = new System.IO.FileSystemWatcher();

        private static string fileWatchPath = @"D:\tianchi\";
        private static string fileWatchFile = "gd_line_desc.txt";
        private static bool _isWatch = false;


        private static FileWatchHelper fileWatchHelper = null;
        public static FileWatchHelper getInstance(string filepath,string filter) 
        {
            if (fileWatchHelper == null)
                fileWatchHelper = new FileWatchHelper();

            fileWatchPath = filepath;
            fileWatchFile = filter;
            InitWatchHelper();

            return fileWatchHelper;
        }

        private static void InitWatchHelper() 
        {
            m_Watcher.Path = fileWatchPath;
            m_Watcher.Filter = fileWatchFile;
            m_Watcher.NotifyFilter = NotifyFilters.LastAccess |
                         NotifyFilters.LastWrite |
                         NotifyFilters.FileName |
                         NotifyFilters.DirectoryName;
            m_Watcher.Changed += new FileSystemEventHandler(m_Watcher_Changed);
            m_Watcher.Created += new FileSystemEventHandler(m_Watcher_Changed);
            m_Watcher.Deleted += new FileSystemEventHandler(m_Watcher_Changed);
            m_Watcher.Renamed += new RenamedEventHandler(m_Watcher_Resumed);
            m_Watcher.IncludeSubdirectories = false;//包含子目录 
        }

        /// <summary>
        /// 监控是否正在运行
        /// </summary>
        public bool IsWatch
        {
            get
            {
                return _isWatch;
            }
        }

        /// <summary>
        /// 开始监视
        /// </summary>
        public void  EnableWatch()
        {
            _isWatch = true;
            m_Watcher.EnableRaisingEvents = true;//开始监视
        }
        /// <summary>
        /// 结束监视
        /// </summary>
        public void DisableWatch()
        {
            _isWatch = false;
            m_Watcher.EnableRaisingEvents = false;//结束监视
        }

        /// <summary>
        /// 关闭监听器
        /// </summary>
        public void Close()
        {
            _isWatch = false;
            m_Watcher.Changed -= new FileSystemEventHandler(m_Watcher_Changed);
            m_Watcher.Created -= new FileSystemEventHandler(m_Watcher_Changed);
            m_Watcher.Deleted -= new FileSystemEventHandler(m_Watcher_Changed);
            m_Watcher.Renamed -= new RenamedEventHandler(m_Watcher_Resumed);
            m_Watcher.EnableRaisingEvents = false;
            m_Watcher = null;
        }

        public delegate void FileChangedEvent(System.IO.FileSystemEventArgs e);
        static FileChangedEvent fileChangedEvent;

        /// <summary>
        /// 监听事件触发的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void m_Watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            fileChangedEvent(e);
            /////这里写你监视的函数
        }
        /// <summary>
        /// 文件或目录重命名时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void m_Watcher_Resumed(object sender, RenamedEventArgs e)
        {
            //这里不用写
        }

    }
}
