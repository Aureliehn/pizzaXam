using System;
using System.Collections.Generic;
using System.Text;

namespace pizza.NewFolder
{
    public static class StrigExtensions
    {
        public static string PremiereLettreMajuscule(string str)
        {
            if (String.IsNullOrEmpty(str)) 
            { 
                return str; 
            };
            string ret = str.ToLower();
            ret = ret.Substring(0, 1).ToUpper() + ret.Substring(1, ret.Length-1);
            return ret;
        }
        
    
    }
}
    

