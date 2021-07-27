using System;
using System.Collections.Generic;

public class Program{
	public static void Main(){
		List<int> arr = new List<int>(){1, 2, 3, 1, 5};
		Console.WriteLine(firstDuplicate(arr));
	}
	public static int firstDuplicate(List<int> arr){//O(n) O(1)
		List<int> it_was = new List<int>(){};
		foreach(int i in arr){
			if(it_was.Contains(i)){
				return i;
			}
			it_was.Add(i);
		}
		return -1;
	}
}