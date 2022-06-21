using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovenseWrapper
{
    // --------------------------------------------------------------------------------
    /// <summary>
    /// Extends the structure StLovensToyInfo with useful functions
    /// </summary>
    // --------------------------------------------------------------------------------
    public static class Extensions
    {
        // ********************************************************************************
        /// <summary>
        /// Extends the structure StLovensToyInfo:
        ///   Returns the ToyId as a string
        /// </summary>
        /// <param name="stLovenseToyInfo"></param>
        /// <returns></returns>
        // <created>CMT,20/06/2022</created>
        // <changed>CMT,20/06/2022</changed>
        // ********************************************************************************
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

        // ********************************************************************************
        /// <summary>
        /// Extends the structure StLovensToyInfo:
        ///   Returns the ToyName as a string
        /// </summary>
        /// <param name="stLovenseToyInfo"></param>
        /// <returns></returns>
        // <created>CMT,20/06/2022</created>
        // <changed>CMT,20/06/2022</changed>
        // ********************************************************************************
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

        // ********************************************************************************
        /// <summary>
        /// Extends the structure StLovensToyInfo:
        ///   Returns the ToyType as a string
        /// </summary>
        /// <param name="stLovenseToyInfo"></param>
        /// <returns></returns>
        // <created>CMT,20/06/2022</created>
        // <changed>CMT,20/06/2022</changed>
        // ********************************************************************************
        public static string ToyTypeStr(this StLovenseToyInfo stLovenseToyInfo)
        {
            return ((LVSToyType)stLovenseToyInfo.ToyType).ToString();
        }
    }
}
