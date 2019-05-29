using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace CSS
{
    class CSSReader
    {
        List<string> stylesheet;
        public CSSReader(string _ssPath)
        {
            StreamReader sr = new StreamReader(_ssPath);
            string rawSS = sr.ReadToEnd();
            sr.Close();
            rawSS = rawSS.Replace('\r', '\0');
            rawSS = rawSS.Replace('\n', '\0');
            stylesheet = rawSS.Split(new char[] { '{', '}'}).ToList<string>();
        }

        public void ApplyStyle(object _object)
        {
            string objType = _object.GetType().ToString().ToLower();
            objType = objType.Substring(objType.LastIndexOf('.') + 1);
            Debug.WriteLine(objType);
            switch (objType)
            {
                case "button":
                    ApplyForButton((Button)_object, stylesheet.ElementAt(stylesheet.IndexOf("button ")+1));
                    break;
            }
        }

        private void ApplyForButton(Button button, string _props)
        {
            Dictionary<string, string> properties = GetProperties(_props);
            FontProperties fontProperties = new FontProperties(8.25f);            
            foreach(var property in properties)
            {
                switch (property.Key)
                {
                    case "background-color":
                        button.BackColor = Color.FromName(property.Value);
                        break;
                    case "color":
                        button.ForeColor = Color.FromName(property.Value);
                        break;  
                    case "font-family":
                        FontFamily family = new FontFamily(property.Value);
                        fontProperties.family = family;
                        break;
                    case "font-size":
                        float size = (float)Convert.ToDouble(property.Value.Substring(0, property.Value.Length - 2));
                        fontProperties.size = size;
                        break;
                    case "font-style":
                        
                        FontStyle f = (FontStyle)Enum.Parse(typeof(FontStyle), property.Value, true);
                        fontProperties.style = f;
                        break;
                    case "text-align":
                        button.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), property.Value, true);
                        break;
                }                    
            }
            button.Font = new Font(fontProperties.family, fontProperties.size, fontProperties.style);            
        }

        private Dictionary<string, string> GetProperties(string _props)
        {
            string[] rawProps = _props.Split(';');
            List<string> preparedProps = new List<string>();
            Dictionary<string, string> properties = new Dictionary<string, string>();
            foreach(var str in rawProps)
            {                
                preparedProps.Add(str.Trim('\0').Trim());
            }
            foreach (string property in preparedProps)
            {
                if (property != "") { 
                properties.Add(property.Substring(0, property.Length - (property.Length - property.IndexOf(':'))).Trim(),
                                                  property.Substring(property.IndexOf(':') + 1).Trim());
                Debug.WriteLine(property.Substring(0, property.Length - property.IndexOf(':')));
                Debug.WriteLine(property.Substring(property.IndexOf(':') + 1));
                }
            }


            return properties;
        }

        struct FontProperties
        {
            public FontFamily family;
            public float size;
            public FontStyle style;

            public FontProperties(float _size)
            {
                family = FontFamily.GenericSansSerif;
                size = _size;
                style = FontStyle.Regular;
            }
        }
    }
}
