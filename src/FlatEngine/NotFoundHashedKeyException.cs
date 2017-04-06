using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatEngine
{
    public class NotFoundHashedKeyException : Exception
    { 
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Hashed key</param>
        /// <param name="value">Hashed value</param>
        public NotFoundHashedKeyException(string key, string value) 
            : base("Specified value not found in hashed values. key=" + key + ", value=" + value)
        {
        }
    }
}
