using System;

namespace Servent.DAL
{
    public static class  ServentContextFactory
    {
        private static ServentContext _instance;
        private static readonly Object MutX = new object();
        
        public static ServentContext GetContextInstance()
        {
            lock (MutX)
            {
                return _instance ?? (_instance = new ServentContext());
            }
        }
    }
}
