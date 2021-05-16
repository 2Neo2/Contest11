using System;
using System.Collections.Generic;
using System.Linq;

public class Map<TKey, TValue>
{
    private List<(TKey, TValue)> map;
    public Map()
    {
        map = new List<(TKey, TValue)>();
    }

    public void Add(TKey key, TValue value)
    {
        if (ContainsKey(key))
            throw new ArgumentException($"An item with the same key has already been added. Key: {key}");
        else
            map.Add((key, value));
    }
    
    public TValue this[TKey key]
    {
        get
        {
            if (!ContainsKey(key))
                throw new ArgumentException($"The given key '{key}' was not present in the map.");
            return map.Where(x => x.Item1.Equals(key)).ToArray()[0].Item2;
        }
    }

    public bool Remove(TKey key)
    {
        if (!ContainsKey(key))
            return false;
        else
        {
            map.Remove((key, this[key]));
            return true;
        }
    }

    public int Count => map.Count;

    public bool ContainsKey(TKey key)
    {
        bool flag = false;
        foreach (var element in map)
        {
            if (element.Item1.Equals(key))
            {
                flag = true;
                break;
            }
        }

        if (flag)
            return true;
        else
            return false;
    }
}