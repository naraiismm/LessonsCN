using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForEncapsulation
{
    public class Personel
    {
        private string tckimlikno;

        public string TCKIMLIKNO
        {
            get
            {
                return tckimlikno.Substring(0,4);
            }
            set 
            {
               
                if (value.Length==11)
                {
                   for(int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi=char.IsNumber(value[i]);
                        if (sayiMi) 
                        {
                            tckimlikno = value;
                        }
                        else
                        {
                            Console.WriteLine("Karakter hepsi dogru deyil deyil");
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("TC no 11 karakter degildir");
                }
            }
        }

    }
}
