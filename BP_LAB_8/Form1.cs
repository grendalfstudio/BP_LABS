using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Створити словники для перекладу з української мови на іноземну і навпаки.
 *  В коді заповнити словник десятьма словами.
 *  На формі створити інтерфейс, що дозволяє:
 *-	передивлятись словники (використати цикл foreach);
 *-	додавати слова(слово додається в обидва словники, якщо таке слово вже існує, 
 *      то виводити відповідне попередження користувачу);
 *-	перекласти слово в обох напрямах(слово повинно вводитись повністю);
 *-	переклад тексту(користувач обирає напрям перекладу, вводить текст, 
 *      програма перекладає тільки ті слова, що є в словниках, 
 *      інші слова залишаються без змін, закінчення не враховуються). 
 */


namespace BP_LAB_8
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> enuaDict = new Dictionary<string, string>();
        Dictionary<string, string> uaenDict = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            InitializeDictionary();
        }

        private void InitializeDictionary()
        {
            enuaDict.Add("morning"   ,  "ранок"     );
            enuaDict.Add("evening"   ,  "вечір"     );
            enuaDict.Add("day"       ,  "день"      );
            enuaDict.Add("string"    ,  "рядок"     );
            enuaDict.Add("word"      ,  "слово"     );
            enuaDict.Add("dictionary",  "словник"   );
            enuaDict.Add("task"      ,  "завдання"  );
            enuaDict.Add("window"    ,  "вікно"     );
            enuaDict.Add("symbol"    ,  "символ"    );
            enuaDict.Add("exception" ,  "виняток"   );

            uaenDict.Add("ранок"   ,"morning"   );
            uaenDict.Add("вечір"   ,"evening"   );
            uaenDict.Add("день"    ,"day"       );
            uaenDict.Add("рядок"   ,"string"    );
            uaenDict.Add("слово"   ,"word"      );
            uaenDict.Add("словник" ,"dictionary");
            uaenDict.Add("завдання","task"      );
            uaenDict.Add("вікно"   ,"window"    );
            uaenDict.Add("символ"  ,"symbol"    );
            uaenDict.Add("виняток" ,"exception" );
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string wordEn = textEnglish.Text;
                string wordUa = textUkainian.Text;

                enuaDict.Add(wordEn, wordUa);
                uaenDict.Add(wordUa, wordEn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowEn_Click(object sender, EventArgs e)
        {
            try
            {
                dictView.Text = "";
                foreach( KeyValuePair<string, string> entry in enuaDict )
                {
                    string pair = entry.Key + " -> " + entry.Value;
                    dictView.Text += pair + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowUa_Click(object sender, EventArgs e)
        {
            try
            {
                dictView.Text = "";
                foreach( KeyValuePair<string, string> entry in uaenDict )
                {
                    string pair = entry.Key + " -> " + entry.Value;
                    dictView.Text += pair + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTranslateWord_Click(object sender, EventArgs e)
        {
            try
            {
                string word = textWord.Text;
                string translated = "";
                if (enuaDict.ContainsKey(word))
                {                    
                    enuaDict.TryGetValue(word, out translated);
                    textTranslated.Text = translated;
                } 
                else if (uaenDict.ContainsKey(word))
                {
                    uaenDict.TryGetValue(word, out translated);
                    textTranslated.Text = translated;
                } 
                else
                {
                    throw new ArgumentException("No such word in dictionaries");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {

                string input = richText.Text;
                string result = "";
                string wordTranslated = "";
                
                input = input.ToLower();
                input = input.Replace(',', ' ');
                input = input.Replace('.', ' ');
                input = input.Replace('!', ' ');
                input = input.Replace('?', ' ');

                richTextTranslated.Text = "";
                
                string[] inputList = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (radioEnglish.Checked)
                {
                    foreach (string word in inputList)
                    {
                        if (uaenDict.TryGetValue(word, out wordTranslated))
                        {
                            result += wordTranslated + ' ';
                        } else
                        {
                            result += word + ' ';
                        }
                    }
                } else if (radioUkrainian.Checked)
                {
                    foreach (string word in inputList)
                    {
                        if (enuaDict.TryGetValue(word, out wordTranslated))
                        {
                            result += wordTranslated + ' ';
                        } else
                        {
                            result += word + ' ';
                        }
                    }
                }
                richTextTranslated.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}