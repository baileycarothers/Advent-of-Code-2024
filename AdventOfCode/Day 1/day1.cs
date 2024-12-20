namespace AdventOfCode
{
    class Day1
    {
        public static void PartOne()
        {
            string fileToRead = "~/../../../../Day 1/day1input.txt";
            StreamReader sr = new StreamReader(fileToRead);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            string[] lines = fileContent.Split('\n');

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();

            foreach (string line in lines)
            {
                string[] splitNums = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                list1.Add(Int32.Parse(splitNums[0]));
                list2.Add(Int32.Parse(splitNums[1]));
            }

            list1.Sort();
            list2.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                int ans = Math.Abs(list1[i] - list2[i]);
                list3.Add(ans);
            }

            int answer = list3.Sum();
            Console.Write(answer);
        }

        public static void PartTwo()
        {
            string fileToRead = "~/../../../../Day 1/day1input.txt";
            StreamReader sr = new StreamReader(fileToRead);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            string[] lines = fileContent.Split('\n');

            List<int> leftList = new List<int>();
            Dictionary<int, int> rightList = new Dictionary<int, int>();

            foreach (string line in lines)
            {
                string[] splitNums = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int rightNum = Int32.Parse(splitNums[1]);
                int leftNum = Int32.Parse(splitNums[0]);
                
                if (rightList.ContainsKey(rightNum))
                {
                    rightList[rightNum] += 1;
                }
                else
                {
                    rightList.Add(rightNum, 1);
                }

                leftList.Add(leftNum);
            }

            int answer = 0;

            foreach (int num in leftList)
            {
                if (rightList.ContainsKey(num))
                {
                    answer += num * rightList[num];
                }
            }

            Console.WriteLine(answer);
        }
    }
}