using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace Registry_Lab.Manager
{
    public class RegistryManager
    {
        // Метод для получения структуры реестра
        public List<string> GetSubKeys(string rootKey, string subKeyPath)
        {
            RegistryKey root = GetRootKey(rootKey);
            if (root == null) return null;

            using (RegistryKey subKey = root.OpenSubKey(subKeyPath))
            {
                if (subKey == null) return null;
                return new List<string>(subKey.GetSubKeyNames());
            }
        }

        // Метод для чтения параметров ключа
        public Dictionary<string, (object Value, RegistryValueKind Type)> GetKeyValues(string rootKey, string subKeyPath)
        {
            RegistryKey root = GetRootKey(rootKey);
            if (root == null) return null;

            using (RegistryKey subKey = root.OpenSubKey(subKeyPath))
            {
                if (subKey == null) return null;

                var values = new Dictionary<string, (object, RegistryValueKind)>();
                foreach (string valueName in subKey.GetValueNames())
                {
                    values[valueName] = (subKey.GetValue(valueName), subKey.GetValueKind(valueName));
                }
                return values;
            }
        }

        // Метод для создания подключа
        public bool CreateSubKey(string rootKey, string subKeyPath, string newSubKeyName)
        {
            RegistryKey root = GetRootKey(rootKey);
            if (root == null) return false;

            // Формируем полный путь для нового подключа
            string fullPath = subKeyPath == "" ? newSubKeyName : $"{subKeyPath}\\{newSubKeyName}";

            using (RegistryKey subKey = root.CreateSubKey(fullPath))
            {
                return subKey != null;
            }
        }

        // Метод для создания значения
        public bool CreateValue(string rootKey, string subKeyPath, string valueName, object valueData, RegistryValueKind valueKind)
        {
            RegistryKey root = GetRootKey(rootKey);
            if (root == null) return false;

            using (RegistryKey subKey = root.CreateSubKey(subKeyPath))
            {
                if (subKey == null) return false;
                subKey.SetValue(valueName, valueData, valueKind);
                return true;
            }
        }

        private RegistryKey GetRootKey(string rootKey)
        {
            switch (rootKey)
            {
                case "HKEY_CLASSES_ROOT": return Registry.ClassesRoot;
                case "HKEY_CURRENT_USER": return Registry.CurrentUser;
                case "HKEY_LOCAL_MACHINE": return Registry.LocalMachine;
                case "HKEY_USERS": return Registry.Users;
                case "HKEY_CURRENT_CONFIG": return Registry.CurrentConfig;
                default: return null;
            }
        }
    }
}
