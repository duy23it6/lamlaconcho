using System;
using System.Collections.Generic;

public class Student
{
    public string ID { get; set; }
    public float GPA { get; set; }
}
class Program
{
    static void Main()
    {
        Dictionary<string, float> dict1 = new Dictionary<string, float>();

        while (true)
        {
            Console.WriteLine("Nhập ID sinh viên (hoặc '#' để dừng): ");
            string id = Console.ReadLine();
            if (id == "#")
            {
                break;
            }

            Console.WriteLine("Nhập điểm trung bình: ");
            string gpaInput = Console.ReadLine();
            if (float.TryParse(gpaInput, out float gpa))
            {
                dict1[id] = gpa;
            }
            else
            {
                Console.WriteLine("Điểm trung bình không hợp lệ. Bỏ qua sinh viên này.");
            }
        }

        // Xác định điểm trung bình của sinh viên có ID là "123456"
        string searchID = "123456";
        if (dict1.TryGetValue(searchID, out float searchedGpa))
        {
            Console.WriteLine($"Điểm trung bình của sinh viên có ID '{searchID}' là {searchedGpa}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sinh viên có ID '{searchID}'");
        }
    }
}
