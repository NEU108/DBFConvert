using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBFConvert
{
    static class Program
    { 
        public static bool isRegister = false;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UI线程中的异常
            Application.ThreadException +=
                new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //其他线程中的异常
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
              
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Main());
            // Application.Run(new F_RSA());
        }

        //UI线程中的异常
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("抱歉，您的操作没有能够完成，请再试一次或者联系软件提供商");
            LogUnhandledException(e.Exception);
        }
        //其他线程中的异常
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("抱歉，您的操作没有能够完成，请再试一次或者联系软件提供商");
            LogUnhandledException(e.ExceptionObject);
        }


        //日志
        static void LogUnhandledException(object exceptionobj)
        {
            //Log the exception here or report it to developer  
        }

    }
}
