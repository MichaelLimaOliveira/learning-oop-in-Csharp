// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Contracts;

string helo = "            Hello, World!           ";
string helo2 = "            Hello, World!           ";

long bestTime = 0;
long tieCount = 0;
for (int i = 0; i < 1000; i++)
{
    var stopWatch = new Stopwatch();
    stopWatch.Start();
    helo = RemoveWhiteSpaceFromStartAndEndEstrevimTwo(helo);
    stopWatch.Stop();

    bestTime = stopWatch.ElapsedTicks < bestTime || bestTime == 0 ? stopWatch.ElapsedTicks : bestTime;

    Console.WriteLine(bestTime);
}
helo = RemoveWhiteSpaceFromStartAndEndEstrevim(helo);
Console.WriteLine($"Best Time: {bestTime}");
Console.WriteLine(helo);




string RemoveWhiteSpaceFromStartAndEnd(string word)
{
    string worldNew = " ";
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == ' ')
        { 
            if (word[i] - 1 != ' ' && i != 0 && i != word.Length-1)
            {
                worldNew += ' ';
            }
        }
        else
        {
            worldNew += word[i];
        }
    }
    return worldNew;
}

string RemoveWhiteSpaceFromStartAndEndEstrevim(string word)
{
    int count = 0;
    int reverseCount = 0;
    bool flag = false;
    bool reverseFlag = false;
    for(int i = 0; i < word.Length; i++)
    {
        var currentChar = word[i];
        if (currentChar == ' ' && !flag)
            count++;
        else
            flag = true;

        var reverseChar = word[word.Length - 1 - i];
        if (reverseChar == ' ' && !reverseFlag)
            reverseCount++;
        else
            reverseFlag = true;
    }

    string newString = string.Empty;
    for(int j = count; j < word.Length - reverseCount; j++)
    {
        newString += word[j];
    }

    TrimHelper
}

[System.Security.SecurityCritical]  // auto-generated
string InternalSubString(string test, int startIndex, int length)
{
    Contract.Assert(startIndex >= 0 && startIndex <= test.Length, "StartIndex is out of range!");
    Contract.Assert(length >= 0 && startIndex <= test.Length - length, "length is out of range!");

    String result = FastAllocateString(length);

    fixed (char* dest = &result.m_firstChar)
        fixed (char* src = &this.m_firstChar)
        {
            wstrcpy(dest, src + startIndex, length);
        }

    return result;
}
