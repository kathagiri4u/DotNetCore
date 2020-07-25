using System;

namespace Extensions
{
    public static class IExtensions 
    {

        public static string ToProper(this String oldString)
        {
             if(oldString.Length>0)
             {
                 string newStr = null;
                 oldString = oldString.ToLower();
                 string[] strArray = oldString.Split(' ');
                 foreach(string s in strArray)
                 {
                     char[] charArray = s.ToCharArray();
                     charArray[0] = Char.ToUpper(charArray[0]);
                     if(newStr==null)
                        newStr = new string(charArray);
                    else
                        newStr +=  " " + new string(charArray);
                 }
                 return newStr;

             }

             return oldString;
        }

    }
}