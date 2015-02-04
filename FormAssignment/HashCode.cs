// Student: Emma Jane Heneghan
// Student Number: 10204278

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FormAssignment
{
    class HashCode
    {
        // its returning a string (variable username passed in as a parameter)
        public string PassHash(string data)
        {
            SHA1 sha = SHA1.Create();

            // instanciate the byte array
            // method computehash, strips down the word into bytes
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));

            // new string builder called returnvalue
            StringBuilder returnValue = new StringBuilder();

            // now need to loop through the array
            for (int i = 0; i < hashdata.Length; i++)
            {
                // toString - makes it work in console
                returnValue.Append(hashdata[i].ToString());
            }

            // returns string, returnValue is type stringbuilder
            return returnValue.ToString();
        }
    }
}
