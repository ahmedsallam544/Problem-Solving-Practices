using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Practices
{
    // Do not change the name of this class
    public class CustomStringEnumerator : IEnumerable<string>
    {
        IEnumerable<string> _collection;
        EnumeratorConfig _config;

        /// <summary> Constructor </summary>
        /// <exception cref="System.ArgumentNullException">If a collection is null</exception>
        /// <exception cref="System.ArgumentNullException">If an config is null</exception>
        public CustomStringEnumerator(IEnumerable<string> collection, EnumeratorConfig config)
        {
            if (config == null)
                throw new ArgumentNullException();
            else
                _config = config;
            if (collection == null)
                throw new ArgumentNullException();
            else
                _collection = collection;

        }

        public IEnumerator<string> GetEnumerator()
        {
            return Getcollection().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<string> Getcollection()
        {
            foreach (var s in _collection)
            {
                if(_config.MinLength != -1)
                    if (s.Length < _config.MinLength)
                        continue;
                if (_config.MaxLength != -1)
                    if (s.Length > _config.MaxLength ) 
                    continue;
                if (!string.IsNullOrEmpty(s))
                {
                    if (_config.StartWithCapitalLetter)
                       if (!char.IsUpper(s, 0))
                        continue;
                    if (_config.StartWithDigit)
                        if (!char.IsDigit(s, 0))
                            continue;
                }
                yield return s;
            }
        }



    }

    //A sample showing how CustomStringEnumerator & EnumeratorConfig will be used


    //Your implementation of CustomStringEnumerator should take into account all the properties of EnumeratorConfig
    public class EnumeratorConfig
    {
        //Specifies the minimal length of strings that should be returned by a custom enumerator.
        //If it is set to negative value then this option is ignored.
        public int MinLength { get; set; } = -1;

        //Specifies the maximum length of strings that should be returned by a custom enumerator.
        //If it is set to negative value then this option is ignored.
        public int MaxLength { get; set; } = -1;

        //Specifies that only strings that start with a capital letter should be returned by a custom enumerator.
        //Please note that empty or null strings do not meet this condition.
        public bool StartWithCapitalLetter { get; set; }

        //Specifies that only strings that start with a digit should be returned by a custom enumerator.
        //Please note that empty or null strings do not meet this condition.
        public bool StartWithDigit { get; set; }
    }
}
