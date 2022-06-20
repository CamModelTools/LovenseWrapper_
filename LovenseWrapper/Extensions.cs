using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovenseWrapper
{
    public static class Extensions
    {
        public static string ToyIdStr(this StLovenseToyInfo stLovenseToyInfo)
        {
            string toyIdentification = "";
            unsafe
            {
                for (int i = 0; i < 64; i++)
                {
                    if ((char)stLovenseToyInfo.ToyId[i] == 0x00)
                    {
                        break;
                    }

                    toyIdentification += (char)stLovenseToyInfo.ToyId[i];
                }
            }
            return toyIdentification;
        }

        public static string ToyNameStr(this StLovenseToyInfo stLovenseToyInfo)
        {
            string toyNameTest = "";
            unsafe
            {
                for (int i = 0; i < 64; i++)
                {
                    if ((char)stLovenseToyInfo.ToyName[i] == 0x00)
                    {
                        break;
                    }
                    toyNameTest += (char)stLovenseToyInfo.ToyName[i];
                }
            }
            return toyNameTest;
        }

        public static string ToyTypeStr(this StLovenseToyInfo stLovenseToyInfo)
        {
            return ((LVSToyType)stLovenseToyInfo.ToyType).ToString();
        }
    }
}
