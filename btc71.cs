using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Tạo một Từ điển <string, int>
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Thêm một số giá trị cặp khóa vào Từ điển
        myDictionary.Add("apple", 5);
        myDictionary.Add("banana", 3);
        myDictionary.Add("orange", 7);
        myDictionary.Add("grape", 2);

        // Kiểm tra sự tồn tại của một khóa trong Từ điển bằng phương thức ContainsKey
        string keyToCheck = "banana";
        if (myDictionary.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"The key '{keyToCheck}' exists in the dictionary.");
        }
        else
        {
            Console.WriteLine($"The key '{keyToCheck}' does not exist in the dictionary.");
        }

        // Truy xuất giá trị liên kết với một khóa một cách an toàn bằng phương thức TryGetValue
        int value;
        keyToCheck = "grape";
        if (myDictionary.TryGetValue(keyToCheck, out value))
        {
            Console.WriteLine($"The value associated with the key '{keyToCheck}' is: {value}");
        }
        else
        {
            Console.WriteLine($"The key '{keyToCheck}' does not exist in the dictionary.");
        }

        // Lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng
        Console.WriteLine("\nAll key-value pairs in the dictionary:");
        foreach (KeyValuePair<string, int> kvp in myDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}