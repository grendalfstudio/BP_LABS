using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string[] rawProps = _props.Split(';');
            Dictionary<string, string> properties = new Dictionary<string, string>();
            foreach (string property in rawProps)
            {
                properties.Add(property.Substring(0, property.Length - property.IndexOf(':')), 
                                                  property.Substring(property.IndexOf(':')+1));
                Debug.WriteLine(property.Substring(0, property.Length - property.IndexOf(':')));
                Debug.WriteLine(property.Substring(property.IndexOf(':') + 1));
            }
        }

        private Dictionary<string, string> GetProperties(string _props)
        {

        }
    }
}
