using System;

namespace Servent.Util
{
    public class TraceHelper
    {
        private string _folder;
        private bool _traceEnabled;
        private string _fileName;

        public TraceHelper(string fileName)
        {
                 if (!this.TraceEnabled)
                return;

            
            this._fileName = fileName;
        }

        public TraceHelper(string fileName, string folder)
        {
            if (!this.TraceEnabled)
                return;
                       
            this._fileName = fileName;
        }

        public void Write(string msg)
        {
            if (this.TraceEnabled)
                try
                {
                    if (!System.IO.Directory.Exists(this._folder))
                        System.IO.Directory.CreateDirectory(this._folder);

                    System.IO.StreamWriter sw = new System.IO.StreamWriter(this._folder + "\\" + this._fileName + " " + DateTime.Now.ToString("yyyy MM dd") + ".txt", true);
                    sw.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId + " - " + DateTime.Now.ToString("HH:mm:ss") + " " + msg);
                    sw.Close();
                }
                catch
                {
                }
        }

        public static void WriteInEventVwr(string msg, System.Diagnostics.EventLogEntryType eventType)
        {
            System.Diagnostics.EventLog.WriteEntry ("Servent", msg, eventType);
        }

        public bool TraceEnabled
        {
            get { return true; }//TODO: Implementar
        }
    }
}
