using Servent.Util;

namespace Servent.DAL
{
    public static class Settings
    {
        public static string ServerAddress
        {
            get
            {
                return (string)Registry.Read(RegistryRoot.HkeyLocalMachine, "Software\\Pegasus\\Servent\\Server", "ServerAddress", "");
            }
            set
            {
                Registry.Write(RegistryRoot.HkeyLocalMachine, "Software\\Pegasus\\Servent\\Server", "ServerAddress", value);
            }
        }

        public static bool IsLocalServer
        {
            get
            {
                bool result;
                bool.TryParse(Registry.Read(RegistryRoot.HkeyLocalMachine, "Software\\Pegasus\\Servent\\Server", "IsLocalServer", "True").ToString(),out result);
                return result;
            }
            set
            {
                Registry.Write(RegistryRoot.HkeyLocalMachine, "Software\\Pegasus\\Servent\\Server", "IsLocalServer", value.ToString());
            }
        }
        public static string ConnectionString
        {
            get
            { 
                return string.Format(@"Server=ndd-desk-tes242;Data Source={0}; Initial Catalog=dbservent; User Id=sa; Password=P@ssw0rd;", ServerAddress);
            }
        }
    }
}
