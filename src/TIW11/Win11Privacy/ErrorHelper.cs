using System;
using System.Windows.Forms;

namespace ThisIsWin11
{
    internal class ErrorHelper
    {
        private static RichTextBox target = null;

        //errorlogger to target rtbPS
        public void SetTarget(RichTextBox richText)
        {
            target = richText;
        }

        public void Log(string format, params object[] args)
        {
            format += "\r\n";

            if (target.InvokeRequired)
            {
                target.Invoke(new Action(() =>
                    target.AppendText(string.Format(format, args))
                ));
            }
            else
            {
                target.AppendText(string.Format(format, args));
            }
        }

        public static ErrorHelper Instance
        {
            get => new ErrorHelper();
        }
    }
}