using Search;
int[] arr = {10, 20, 30, 40, 50, 60, 70, 80};
int index = BinarySearch.Search(arr, 300);
if(index != -1)
    Console.WriteLine($"Array[{index}] => {arr[index]}");
else 
    Console.WriteLine("Eleman bulunamadı!");
