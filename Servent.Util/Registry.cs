using System;
using System.Diagnostics;
using Microsoft.Win32;
using Servent.Util.Properties;

namespace Servent.Util
{
    public enum RegistryRoot
    {
        HkeyClassesRoot,
        HkeyCurrentUser,
        HkeyLocalMachine,
        HkeyUsers,
        HkeyCurrentConfig,
    }

    [UsedImplicitly]
    public sealed class Registry : MarshalByRefObject
    {
        public static object Read(RegistryRoot root, string key, string name, string defaultValue)
        {
            RegistryKey registryKey = null;
            switch (root)
            {
                case RegistryRoot.HkeyClassesRoot:
                    registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, false);
                    break;
                case RegistryRoot.HkeyCurrentUser:
                    registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key, false);
                    break;
                case RegistryRoot.HkeyLocalMachine:
                    registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(key, false);
                    break;
                case RegistryRoot.HkeyUsers:
                    registryKey = Microsoft.Win32.Registry.Users.OpenSubKey(key, false);
                    break;
                case RegistryRoot.HkeyCurrentConfig:
                    registryKey = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(key, false);
                    break;
            }
            if (registryKey != null)
                return registryKey.GetValue(name, defaultValue);
            return defaultValue;
        }

        public static void Write(RegistryRoot root, string key, string name, string value)
        {
            RegistryKey registryKey = null;
            switch (root)
            {
                case RegistryRoot.HkeyClassesRoot:
                    registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyCurrentUser:
                    registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyLocalMachine:
                    registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyUsers:
                    registryKey = Microsoft.Win32.Registry.Users.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyCurrentConfig:
                    registryKey = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(key, true);
                    break;
            }
            if (registryKey == null)
                registryKey = Create(root, key);
            registryKey.SetValue(name, value);
            registryKey.Close();
        }

        public static void Write(RegistryRoot root, string key, string name, int vlr)
        {
            RegistryKey registryKey = null;
            switch (root)
            {
                case RegistryRoot.HkeyClassesRoot:
                    registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyCurrentUser:
                    registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyLocalMachine:
                    registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyUsers:
                    registryKey = Microsoft.Win32.Registry.Users.OpenSubKey(key, true);
                    break;
                case RegistryRoot.HkeyCurrentConfig:
                    registryKey = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(key, true);
                    break;
            }
            if (registryKey == null)
                registryKey = Create(root, key);
            registryKey.SetValue(name, vlr);
            registryKey.Close();
        }

        private static RegistryKey Create(RegistryRoot root, string key)
        {
            RegistryKey registryKey = null;
            switch (root)
            {
                case RegistryRoot.HkeyClassesRoot:
                    registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("", true);
                    break;
                case RegistryRoot.HkeyCurrentUser:
                    registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("", true);
                    break;
                case RegistryRoot.HkeyLocalMachine:
                    registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("", true);
                    break;
                case RegistryRoot.HkeyUsers:
                    registryKey = Microsoft.Win32.Registry.Users.OpenSubKey("", true);
                    break;
                case RegistryRoot.HkeyCurrentConfig:
                    registryKey = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey("", true);
                    break;
            }
            
            return registryKey.CreateSubKey(key);
        }

        public static object Read64(RegistryRoot Root, string key, string name, string defaultValue)
        {
            return Read(Root, ChangeKeyToX64(key), name, defaultValue);
        }

        public static void Write64(RegistryRoot Root, string key, string name, string value)
        {
            Write(Root, ChangeKeyToX64(key), name, value);
        }

        public static void Write64(RegistryRoot Root, string key, string name, int vlr)
        {
            Write(Root, ChangeKeyToX64(key), name, vlr);
        }

        private static string ChangeKeyToX64(string key)
        {
            if (IntPtr.Size == 8 && key.ToLower().StartsWith("software"))
                return key.Insert(8, "\\Wow6432Node");
            return key;
        }
    }
}
