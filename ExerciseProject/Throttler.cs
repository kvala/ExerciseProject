using System;
using System.Collections.Generic;

namespace ExerciseProject
{
    public class Throttler
    {
        // This method returns true if request is allowable
        // id is userid and it is string
        // 1 request per min(60 sec)
        readonly Dictionary<string, DateTime> _dictionary = new Dictionary<string, DateTime>();

        public bool Allow(string id)
        {
            lock (id)
            {
                // for same user there should not be any request in last 60 sec
                if (!_dictionary.ContainsKey(id))
                {
                    _dictionary.Add(id, DateTime.Now);
                    return true;
                }

                var lastUsed = _dictionary[id];

                if ((DateTime.Now - lastUsed).Seconds >= 60)
                {
                    _dictionary[id] = DateTime.Now;
                    return true;
                }
            }
            return false;
        }
    }
}