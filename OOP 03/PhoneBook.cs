using System;
using System.Security.Cryptography;

public struct PhoneBook
{
    private string[] Names;
    private long[] Numbers;
    private int _size;

    public PhoneBook(int size)
    {
        _size = size; // ← Important fix
        Names = new string[size];
        Numbers = new long[size];
    }

    public int Size
    {
        get { return _size; }
    }

    public long this[string name] 
    {
        get
        {
            for (int i = 0; i < _size; i++)
            {
                if (Names[i] == name)
                {
                    return Numbers[i];
                }
            }
            return -1;
        }
        set 
        {

            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == name)
                {
                    Numbers[i] = value;
                }
            }
        }
    }

    public void AddPerson(string name, long number, int index)
    {
        if (index >= 0 && index < _size)
        {
            Names[index] = name;
            Numbers[index] = number;
        }
    }

    public long GetNumber(string name)
    {
        for (int i = 0; i < _size; i++)
        {
            if (Names[i] == name)
            {
                return Numbers[i];
            }
        }
        return -1;
    }

    public void setNumber(string name, long newNumber)
    {
        for (int i = 0; i < Names.Length; i++)
        {
            if (Names[i] == name)
            {
                Numbers[i] = newNumber;
            }
        }
    }

    //public string this[string name] 
    //{
    //    get 
    //    {
    //        return "Name: " + name + ", Number: " + this[name];  // can't use indexer for the same parameter
    //    }
    //}

    public string this[int index] 
    {
        get 
        {
            return $"Index : {index} , the number is : {Numbers[index]}";
        }
    }
}