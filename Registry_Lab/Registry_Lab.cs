using Microsoft.Win32;
using Registry_Lab.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Registry_Lab
{
    public partial class Registry_Lab : Form
    {
        private readonly RegistryManager registryManager = new RegistryManager();

        public Registry_Lab()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            treeViewRegistry.Nodes.Clear();

            // Добавляем корневые узлы для основных разделов реестра
            string[] rootKeys = { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_CURRENT_CONFIG" };
            foreach (var rootKey in rootKeys)
            {
                TreeNode rootNode = new TreeNode(rootKey) { Tag = rootKey };
                rootNode.Nodes.Add(new TreeNode()); // заглушка чтобы загружать узлы только при открытии
                treeViewRegistry.Nodes.Add(rootNode);
            }

            treeViewRegistry.BeforeExpand += TreeViewRegistry_BeforeExpand;  //раскрытие
            treeViewRegistry.AfterSelect += TreeViewRegistry_AfterSelect;   //выбор
        }

        private void TreeViewRegistry_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            LoadSubKeys(e.Node);
        }

        private void TreeViewRegistry_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DisplayKeyValues(e.Node);
        }

        private void LoadSubKeys(TreeNode node)
        {
            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null) // Если это заглушка
            {
                node.Nodes.Clear();
                string rootKey = GetRootKeyFromNode(node);
                string subKeyPath = GetSubKeyPathFromNode(node);

                List<string> subKeys = registryManager.GetSubKeys(rootKey, subKeyPath);
                if (subKeys != null)
                {
                    foreach (string subKey in subKeys)
                    {
                        TreeNode subNode = new TreeNode(subKey) { Tag = $"{rootKey}\\{subKeyPath}\\{subKey}" };
                        subNode.Nodes.Add(new TreeNode()); // Заглушка для подгрузки
                        node.Nodes.Add(subNode);
                    }
                }
            }
        }

        private void DisplayKeyValues(TreeNode node)
        {
            listBoxRegistry.Items.Clear();

            string rootKey = GetRootKeyFromNode(node);
            string subKeyPath = GetSubKeyPathFromNode(node);

            // Обновляем путь в Label
            labelCurrentPath.Text = $"Текущий путь: {rootKey}\\{subKeyPath}";

            var values = registryManager.GetKeyValues(rootKey, subKeyPath);
            if (values != null)
            {
                foreach (var kvp in values)
                {
                    string item = $"{rootKey}\\{subKeyPath}|{kvp.Key}|{kvp.Value.Type}|{kvp.Value.Value}";
                    listBoxRegistry.Items.Add(item);
                }
            }
        }

        private string GetRootKeyFromNode(TreeNode node) // проходит вверх по деревую до родительского ключа
        {
            TreeNode currentNode = node;
            while (currentNode.Parent != null)
            {
                currentNode = currentNode.Parent;
            }
            return currentNode.Tag.ToString();
        }

        private string GetSubKeyPathFromNode(TreeNode node) // путь до родительского
        {
            Stack<string> pathStack = new Stack<string>();
            TreeNode currentNode = node;

            while (currentNode.Parent != null)
            {
                pathStack.Push(currentNode.Text);
                currentNode = currentNode.Parent;
            }

            return string.Join("\\", pathStack);
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (listBoxRegistry.SelectedItem == null)
            {
                MessageBox.Show("Выберите параметр для сохранения.");
                return;
            }

            // Получаем выбранный элемент из listBox
            string selectedValue = listBoxRegistry.SelectedItem.ToString();

            // Разделяем строку на ключ, имя параметра, тип и значение
            string[] parts = selectedValue.Split(new string[] { "|" }, StringSplitOptions.None);
            if (parts.Length < 4)
            {
                MessageBox.Show("Некорректные данные для сохранения.");
                return;
            }

            string key = parts[0]; // Ключ
            string valueName = parts[1]; // Имя параметра
            string valueType = parts[2]; // Тип параметра
            string valueData = parts[3]; // Значение параметра

            string filePath = @"C:\Users\Vlad\source\repos\Registry_LAB\Registry_Lab\RegInfo.txt"; // Указываем путь к файлу

            try
            {
                // Открываем файл для дозаписи данных
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine($"Ключ: {key} | Имя: {valueName} | Тип: {valueType} | Значение: {valueData}");
                }
                MessageBox.Show("Данные успешно сохранены в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }


        private void buttonCreateSubKey_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewRegistry.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Выберите узел для создания подключа.");
                return;
            }

            string rootKey = GetRootKeyFromNode(selectedNode);
            string subKeyPath = GetSubKeyPathFromNode(selectedNode);
            string newSubKeyName = textBoxNewSubKey.Text;

            if (string.IsNullOrEmpty(newSubKeyName))
            {
                MessageBox.Show("Введите имя подключа.");
                return;
            }

            // Формируем новый путь для создания подключа
            string fullSubKeyPath = subKeyPath == "" ? newSubKeyName : $"{subKeyPath}\\{newSubKeyName}";

            // Пытаемся создать новый подключ
            bool success = registryManager.CreateSubKey(rootKey, fullSubKeyPath, newSubKeyName);
            if (success)
            {
                // Перезагружаем подкатегории для выбранного узла
                LoadSubKeys(selectedNode);
                MessageBox.Show("Подключ создан.");
            }
            else
            {
                MessageBox.Show("Ошибка создания подключа.");
            }
        }

        private void buttonCreateValue_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewRegistry.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Выберите узел для создания параметра.");
                return;
            }

            string rootKey = GetRootKeyFromNode(selectedNode);
            string subKeyPath = GetSubKeyPathFromNode(selectedNode);

            string valueName = textBoxValueName.Text;
            string valueData = textBoxValueData.Text;

            if (string.IsNullOrEmpty(valueName) || string.IsNullOrEmpty(valueData))
            {
                MessageBox.Show("Заполните имя и данные параметра.");
                return; 
            }

            RegistryValueKind valueKind;
            object value;

            try
            {
                switch (comboBoxValueType.SelectedItem.ToString())
                {
                    case "Строковый":
                        valueKind = RegistryValueKind.String;
                        value = valueData;
                        break;

                    case "Числовой":
                        valueKind = RegistryValueKind.DWord;
                        value = int.Parse(valueData);
                        break;

                    case "Двоичный":
                        valueKind = RegistryValueKind.Binary;
                        value = ParseBinaryInput(valueData);
                        break;

                    default:
                        MessageBox.Show("Неизвестный тип значения.");
                        return;
                }

                bool success = registryManager.CreateValue(rootKey, subKeyPath, valueName, value, valueKind);
                if (success)
                {
                    // Обновляем список значений для выбранного ключа
                    DisplayKeyValues(selectedNode);
                    MessageBox.Show("Параметр создан.");
                }
                else
                {
                    MessageBox.Show("Ошибка создания параметра.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

  
        private byte[] ParseBinaryInput(string binaryString)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(binaryString, "^[01]*$"))
            {
                throw new FormatException("Бинарные данные должны содержать только символы 0 и 1.");
            }

            int bitLength = binaryString.Length;
            int byteLength = (bitLength + 7) / 8; // Округляем в большую сторону для добавления недостающих бит
            byte[] bytes = new byte[byteLength];

            for (int i = 0; i < bitLength; i++)
            {
                int byteIndex = i / 8; // Индекс байта
                int bitIndex = 7 - (i % 8); // Индекс бита (от старшего к младшему)
                if (binaryString[i] == '1')
                {
                    bytes[byteIndex] |= (byte)(1 << bitIndex);
                }
            }

            return bytes;
        }



    }
}
