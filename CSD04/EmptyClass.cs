//相对来说，快速排序数值越大速度越快 。  快速排序是所有排序里面最快的
//class toSort
//{
//    static void Main(string[] args) //主程式
//    {
//        int[] arr = { 15, 22, 35, 9, 16, 33, 15, 23, 68, 1, 33, 25, 14 }; //待排序数组 陣列
//                                                                          //控制台遍历输出
//        Console.WriteLine("排序前的数列：");
//        foreach (int item in arr)
//            Console.Write(item + " ");
//        Console.WriteLine();

//        QuickSort(arr, 0, arr.Length - 1);  //调用快速排序函数。傳入值(要排序数组，基准值位置，数组长度)
//        // 陣列名稱.Length - 1 = 陣列長度（最後一位index）
//        //排列完後输出
//        Console.WriteLine();
//        Console.Write("排序后的数列：");
//        foreach (int item in arr)  //類似python for i in 陣列
//            Console.Write(item + " ");

//        Console.ReadLine(); //輸入（？
//    }

//    private static void QuickSort(int[] arr, int begin, int end)//傳入（陣列、基準值、最後一位index）
//    {
//        if (begin >= end) return;   //基準值(index) >= 最後一位index 就結束
//        int pivotIndex = QuickSort_Once(arr, begin, end);  //会得到一个基准值下标

//        QuickSort(arr, begin, pivotIndex - 1);  //对基准的左端进行排序  递归
//        QuickSort(arr, pivotIndex + 1, end);   //对基准的右端进行排序  递归
//    }

//    private static int QuickSort_Once(int[] arr, int begin, int end)//傳入（陣列、基準值、最後一位index）
//    {
//        int pivot = arr[begin];   //基準值 = 陣列[ (基準值的index) ]
//        int i = begin;  // i = 基準值index
//        int j = end;    // j = 最後一位index
//        int l = 0;  //test
//        while (i < j)   //基準值(index) >= 最後一位index 就結束
//        {
//            while (arr[j] >= pivot && i < j)  //從右到左，寻找第一个小于基准pivot的元素
//            {
//                j--; //指针向前移
//            }
//            l+= 1;
//            Console.WriteLine(l+".交換 基準值:"+pivot+" i:" + i + " j:" + j + " arr[i]:" + arr[i]  + "換成arr[j]:" + arr[j]);
//            arr[i] = arr[j];  //执行到此，j已指向从右端起第一个小于基准pivot的元素，执行替换


//            while (arr[i] <= pivot && i < j) //从左到右，寻找首个大于基准pivot的元素
//            {
//                i++; //指针向后移
//            }
//            l += 1;
//            Console.WriteLine(l + ".交換 基準值:" + pivot + " i:" + i + " j:" + j +" arr[j]:" + arr[j] +"換成arr[i]:" + arr[i]  );
//            arr[j] = arr[i];  //执行到此,i已指向从左端起首个大于基准pivot的元素，执行替换
//        }

//        //退出while循环,执行至此，必定是 i= j的情况（最后两个指针会碰头）
//        //i(或j)所指向的既是基准位置，定位该趟的基准并将该基准位置返回

//        l += 1;
//        Console.WriteLine(l + ".交換 基準值:" + pivot + " i:" + i + " arr[i]:"+arr[i]+"換成pivot:"+pivot);
//        arr[i] = pivot;
//        return i;


//    }
//}

class toSort
{
    static void Main(string[] args)
    {
        int[] num = { 726, 563, 456, 652, 531, 132, 391, 94, 96, 84, 74, 55, 54, 32, 43 };//開空陣列
        string[] s_num = new string[num.Length];
        int g = num.Length-1;

        QuickSort(num, 0, num.Length - 1);

        for(int i = 0; i <= g; i++)
        {
            if (num[i] < 100)
            {
                s_num[i] = "0"+(Convert.ToString(num[i]));
            }
            else
            {
                s_num[i] = Convert.ToString(num[i]);
            }
        }

        for(int i = 0; i <= g; i += 2)
        {
            try
            {
                Console.WriteLine(s_num[i] + "\t" + s_num[i + 1]);
            }
            catch (Exception)
            {
                Console.Write(s_num[i]);
            }
        }
        Console.ReadLine();
    }
    private static void QuickSort(int[] num,int begin , int end)
    {
        if (begin >= end) return;
        int pivotIndex = QuickSort_Once(num, begin, end);

        QuickSort(num, begin, pivotIndex - 1); //往左排列
        QuickSort(num, pivotIndex + 1, end);    //往右排列
    }
    private static int QuickSort_Once(int[]num, int begin , int end)
    {
        int pivot = num[begin];
        int i = begin, j = end;
        while (i < j)
        {
            while (num[j]>=pivot && i < j)
            {
                j--;
            }
            num[i] = num[j];
            while (num[i]<=pivot && i < j)
            {
                i++;
            }
            num[j] = num[i];
        }
        num[i] = pivot;
        return i;
    }

}
