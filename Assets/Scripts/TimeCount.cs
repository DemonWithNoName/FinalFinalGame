using System;
using System.IO;


public class TimeCount  {

    public static void saveTime()
    {
        
        if (File.Exists(@"SaveTime.txt"))
        {
            string highscoreTimeStr = File.ReadAllText(@"SaveTime.txt");
            float highscoreTime = float.Parse(highscoreTimeStr);
            if (GameVariables.time > highscoreTime)
            {
                File.WriteAllText(@"SaveTime.txt", GameVariables.time.ToString());
            }

        }
        else
        {
            File.WriteAllText(@"SaveTime.txt", GameVariables.time.ToString());
        }

    }
}
