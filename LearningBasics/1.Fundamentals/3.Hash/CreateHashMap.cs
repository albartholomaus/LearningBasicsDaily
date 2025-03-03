using LearningBasics._99.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBasics.BasicsOrBasics.Hash
{
    public class HashMapping
    {
        int Size { get; set; }
        int Capacity { get; set; }
        public HashPair[] Map { get; set; }

        public HashMapping()
        {
            Size = 0;
            Capacity = 2;
            Map = new HashPair[Capacity];
        }

        public int Hash(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += key[i];
            }
            return index % Capacity;
        }
        public int HashP(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += key[i];
            }
            return index % Capacity;
        }

        public void ReHash()
        {
            Capacity = 2 * Capacity;
            HashPair[] newMap = new HashPair[Capacity];

            HashPair[] oldMap = Map;
            Map = newMap;
            Size = 0;
            foreach (var pair in oldMap)
            {
                if (pair != null)
                {
                    Put(pair.Key, pair.Value);
                }
            }
        }
        public void ReHashP()
        {
            Capacity = Capacity * 2;
            HashPair[] resized = new HashPair[Capacity];
            HashPair[] oldMap = Map;
            Map = resized;
            Size = 0;
            foreach (var hashPairing in oldMap)
            {
                if (hashPairing != null)
                {
                    Put(hashPairing.Key, hashPairing.Value);
                }
            }

        }

        public string Get(string key)
        {
            int index = Hash(key);
            while (Map[index] != null)
            {
                if (Map[index].Key == key)
                {
                    return Map[index].Value;
                }
                index++;
                index %= Capacity;
            }
            return string.Empty;
        }
        public string GetP(string key)
        {
            int index = Hash(key);
            while (Map[index] != null)
            {
                if (Map[index].Key == key)
                {
                    return Map[index].Value;
                }
                index++;
                index %= Capacity;
            }
            return string.Empty;
        }

        public void Put(string key, string value)
        {
            int index = Hash(key);
            while (true)
            {
                if (Map[index] == null)
                {
                    Map[index] = new HashPair(key, value);
                    Size++;
                    if (Size >= Capacity / 2)
                    {
                        ReHash();
                    }
                    return;
                }
                else if (Map[index].Key == key)
                {
                    Map[index].Value = value;
                }
                index++;
                index %= Capacity;
            }
        }
        public void PutP(string key, string value)
        {
        
        }
        
        public void Remove(string key)
        {
            if (Get(key) == null)
            {
                return;
            }
            int index = Hash(key);
            while (true)
            {
                if (Map[index].Key == key)
                {
                    Map[index] = null;
                    Size--;
                    return;
                }
                index++;
                index %= Capacity;
            }
        }
        public void RemoveP(string key)
        { }

        public void Print()
        {
            foreach (var pair in Map)
            {
                if (pair != null)
                {
                    Console.WriteLine($"{pair.Key} {pair.Value}");
                }
            }
        }
      
    }
    public class HashPair
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public HashPair(string key, string value)
        {
            Key = key;
            Value = value;

        }
    }
}
