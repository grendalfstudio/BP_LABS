using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace BP_LAB_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private string _textToAnalysis;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpen_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == true)
                {
                    rtbFileText.AppendText(File.ReadAllText(openFileDialog.FileName, Encoding.Default));
                    _textToAnalysis = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
                    btnAnalyze.IsEnabled = true;
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAnalyze_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                SortedList<string, int> wordQuantity = new SortedList<string, int>();
                SortedList<char, int> letterQuantity = new SortedList<char, int>();

                _textToAnalysis = PrepareText(_textToAnalysis);

                string[] wordsToAnalysis = _textToAnalysis.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in wordsToAnalysis)
                {
                    if (!wordQuantity.ContainsKey(word))
                    {
                        wordQuantity.Add(word, 1);
                    }
                    else
                    {
                        int count = 0;
                        wordQuantity.TryGetValue(word, out count);
                        ++count;
                        wordQuantity.Remove(word);
                        wordQuantity.Add(word, count);
                    }
                }

                foreach (string word in wordsToAnalysis)
                {
                    foreach (char letter in word)
                    {
                        if (!letterQuantity.ContainsKey(letter))
                        {
                            letterQuantity.Add(letter, 1);
                        }
                        else
                        {
                            int count = 0;
                            letterQuantity.TryGetValue(letter, out count);
                            ++count;
                            letterQuantity.Remove(letter);
                            letterQuantity.Add(letter, count);
                        }
                    }
                }

                listWord.ItemsSource = wordQuantity;
                listLetters.ItemsSource = letterQuantity;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            
        }

        private string PrepareText(string input)
        {
            input = input.ToLower();
            input = input.Replace(',', ' ');
            input = input.Replace('.', ' ');
            input = input.Replace('!', ' ');
            input = input.Replace('?', ' ');
            input = input.Replace('\n', ' ');
            input = input.Replace('\r', ' ');
            input = input.Replace('/', ' ');
            input = input.Replace('-', ' ');
            input = input.Replace(':', ' ');
            input = input.Replace(';', ' ');
            input = input.Replace('[', ' ');
            input = input.Replace(']', ' ');
            input = input.Replace('«', '\0');
            input = input.Replace('»', '\0');
            input = input.Replace('\'', '\0');

            return input;
        }
    }
}