using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP_DZ7
{
    class BCoder : ICoder
    {
        public string Str { get; set; }
        public virtual string Encode()
        {
            string k = "";
            for (int i = 0; i < Str.Length; i++)
            {
                if (((int)Str[i] >= 65 && (int)Str[i] <= 90))
                    k += (char)(90 - ((int)Str[i] - 65));
                if (((int)Str[i] >= 97 && (int)Str[i] <= 122))
                    k += (char)(122 - ((int)Str[i] - 97));
                if (((int)Str[i] >= 1040 && (int)Str[i] <= 1071))
                    k += (char)(1071 - ((int)Str[i] - 1040));
                if (((int)Str[i] >= 1072 && (int)Str[i] <= 1103))
                    k += (char)(1103 - ((int)Str[i] - 1072));
            }
            return k;
        }
        public virtual string Decode()
        {
            string k = "";
            for (int i = 0; i < Str.Length; i++)
            {
                if (((int)Str[i] >= 65 && (int)Str[i] <= 90))
                    k += (char)(65 - ((int)Str[i] - 90));
                if (((int)Str[i] >= 97 && (int)Str[i] <= 122))
                    k += (char)(97 - ((int)Str[i] - 122));
                if (((int)Str[i] >= 1040 && (int)Str[i] <= 1071))
                    k += (char)(1040 - ((int)Str[i] - 1071));
                if (((int)Str[i] >= 1072 && (int)Str[i] <= 1103))
                    k += (char)(1072 - ((int)Str[i] - 1103));
            }
            return k;
        }
    }
}
