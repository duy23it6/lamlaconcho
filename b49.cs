using System;

public class Program
{
    // Hàm generic để tìm giá trị nhỏ nhất trong mảng
    public static T FindMinValue<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array is null or empty.");
        }

        T minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(minValue) < 0)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }

    static void Main(string[] args)
    {
        // Khai báo biến kiểu dynamic
        dynamic min_value;

        // Mảng số nguyên 4 byte
        int[] intArray = { 5, 3, 8, 2, 4 };
        min_value = FindMinValue(intArray);
        Console.WriteLine($"Min value in intArray: {min_value.ToString()}");

        // Mảng số nguyên không dấu 4 byte
        uint[] uintArray = { 5, 3, 8, 2, 4 };
        min_value = FindMinValue(uintArray);
        Console.WriteLine($"Min value in uintArray: {min_value.ToString()}");

        // Mảng số thực 4 byte
        float[] floatArray = { 5.5f, 3.3f, 8.8f, 2.2f, 4.4f };
        min_value = FindMinValue(floatArray);
        Console.WriteLine($"Min value in floatArray: {min_value.ToString()}");

        // Mảng số thực 8 byte
        double[] doubleArray = { 5.5, 3.3, 8.8, 2.2, 4.4 };
        min_value = FindMinValue(doubleArray);
        Console.WriteLine($"Min value in doubleArray: {min_value.ToString()}");
    }
}
