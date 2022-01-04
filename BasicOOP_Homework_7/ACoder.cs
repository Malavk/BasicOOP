using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP_DZ7
{
    class ACoder : ICoder
    {
        public string Str { get; set; }
        public virtual string Encode()
        {
            string k = "";
            for (int i = 0; i < Str.Length; i++)
                k += (char)((int)Str[i] + 1);

            return k;
        }
        public virtual string Decode()
        {
            string k = "";
            for (int i = 0; i < Str.Length; i++)
                k += (char)((int)Str[i] - 1);
            return k;
        }
    }
}
