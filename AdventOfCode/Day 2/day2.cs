namespace AdventOfCode
{
    class Day2
    {
        public void PartOne()
        {
            string fileToRead = "~/../../../../Day 2/day2input.txt";
            StreamReader sr = new StreamReader(fileToRead);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            string[] lines = fileContent.Split('\n');

            foreach (string line in lines)
            {
                string[] splitNums = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                List<Int32> splitInts = new List<int>();

                foreach (string num in splitNums)
                {
                    splitInts.Add(Int32.Parse(num));
                }

                Int32 prevNum = 0, currNum = 0;

                for (int i = 0; i < splitInts.Count; i++)
                {
                    if (i == 0)
                    {
                        currNum = splitInts[i];
                    }
                    else
                    {
                        prevNum = currNum;
                        currNum = splitInts[i];

                        if (prevNum - currNum > 3)
                        {
                            
                        }
                    }
                }
            }

        }

        public void PartTwo()
        {

        }
    }
}