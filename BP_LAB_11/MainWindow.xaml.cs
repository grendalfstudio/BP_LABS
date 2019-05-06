using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace BP_LAB_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string _folderPath;

        private void BtnChooseFolder_OnClick(object sender, RoutedEventArgs e)
        {
             FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
             if (folderBrowserDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
             _folderPath = folderBrowserDialog.SelectedPath;
             tbPath.Text = _folderPath;
             tbCondition.Text = "";
        }

        private void BtnSearch_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string pattern = tbCondition.Text;
                List<string> fileList = new List<string>();
                Search(_folderPath, pattern, ref fileList);
                lsvResults.ItemsSource = fileList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            
        }
        
        private bool strmatch(string str, string pattern)
        {
            int n = str.Count();
            int m = pattern.Count();
            
            if (!(bool) matchCase.IsChecked)
            {
                str = str.ToLower();
                pattern = pattern.ToLower();
            }
            
            if (m == 0) 
                return (n == 0); 
	
            bool[][] lookup = new bool[n + 1][];

            for (int i = 0; i < n + 1; i++)
            {
                lookup[i] = new bool[m + 1];
                lookup[i].Fill(false);
            }

            lookup[0][0] = true; 
	
            for (int j = 1; j <= m; j++) 
                if (pattern.ElementAt(j - 1) == '*') 
                    lookup[0][j] = lookup[0][j - 1]; 
	
            for (int i = 1; i <= n; i++) 
            { 
                for (int j = 1; j <= m; j++) 
                { 
                    if (pattern.ElementAt(j - 1) == '*') 
                        lookup[i][j] = lookup[i][j - 1] || 
                                       lookup[i - 1][j]; 
	
                    else if (pattern.ElementAt(j - 1) == '?' || 
                             str.ElementAt(i - 1) == pattern.ElementAt(j - 1)) 
                        lookup[i][j] = lookup[i - 1][j - 1]; 
	
                    else lookup[i][j] = false; 
                } 
            } 
	
            return lookup[n][m]; 
        }

        private void Search(string directory, string pattern, ref List<string> fileList)
        {
            List<string> innnerFileList = new List<string>();
            string[] fileNameList = Directory.GetFiles(@directory);
            string[] directoryPathList = Directory.GetDirectories(@directory);
            foreach (var file in fileNameList)
            {
                string fileName = file.Substring(file.LastIndexOf('\\'));
                if (!(bool) matchCase.IsChecked)
                {
                    fileName = fileName.ToLower();
                    pattern = pattern.ToLower();
                }
                if (!pattern.Contains('*') && !pattern.Contains('?'))
                {
                    if (fileName.Contains(pattern))
                    {
                        innnerFileList.Add(file);
                    }
                }
                else
                {
                    if (strmatch(fileName, pattern))
                    {
                        innnerFileList.Add(file);
                    }
                }
            }
            fileList =  fileList.Concat(innnerFileList).ToList();
            foreach (var dir in directoryPathList)
            {
                Search(dir, pattern, ref fileList);
            }
        }

        private void BtnOpen_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = lsvResults.SelectedItem as string;
                Process.Start("explorer.exe", "/select, " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }
    }
    public static class ArrayExtensions {
        public static void Fill<T>(this T[] originalArray, T with) {
            for(int i = 0; i < originalArray.Length; i++){
                originalArray[i] = with;
            }
        }  
    }
}