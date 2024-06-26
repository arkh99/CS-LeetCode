using System;
using System.Collections.Generic;

public class Program {
    public static List<int> AddTwoNumbers(List<int> l1, List<int> l2) {
        l1.Reverse();
        l2.Reverse();
        
        int numa1 = int.Parse(string.Join("", l1));
        int numa2 = int.Parse(string.Join("", l2));
        
        string sum = (numa1 + numa2).ToString();
        
        List<int> result = new List<int>();
        foreach (char digit in sum) {
            result.Add(int.Parse(digit.ToString()));
        }
        
        result.Reverse();
        return result;
    }

    public static void Main() {
        List<int> l1 = new List<int> { 2, 4, 3 };
        List<int> l2 = new List<int> { 5, 6, 4 };
        
        List<int> result = AddTwoNumbers(l1, l2);
        
        foreach (int num in result) {
            Console.WriteLine(num);
        }
    }
}
