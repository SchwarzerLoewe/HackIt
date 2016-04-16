﻿using System;

namespace HackIt.Core.Models
{
    public class Mission
    {
        public string Title { get; set; }
        public string[] UsableTools { get; set; }
        public Computer Host { get; set; }
        public string[] Messages { get; set; }
        public MissionDifficulty Difficulty { get; set; }
        public int AvalablePoints { get; set; }
        public FileSystem Filesystem { get; set; }

        public static Mission Create(string title, int maxPoints, string[] tools, MissionDifficulty difficulty, Computer host = null, string[] messages = null)
        {
            var ms = new Mission();

            ms.Title = title;
            ms.UsableTools = tools;
            ms.Difficulty = difficulty;
            ms.AvalablePoints = maxPoints;

            if (difficulty == MissionDifficulty.Hard) ms.AvalablePoints /= 2;
            if (difficulty == MissionDifficulty.Easy) ms.AvalablePoints *= 2;

            if (host == null)
            {
                ms.Host = new Computer();
                ms.Host.IP = IPAddressGenerator.Generate((int)ms.Difficulty + (int)DateTime.Now.Ticks);
                ms.Host.FileSystem = new FileSystem();
                ms.Host.Name = "Localhost";
            }
            if(messages == null)
            {
                ms.Messages = new string[0];
            }

            return ms;
        }
    }

    public enum MissionDifficulty
    {
        Easy,
        Medium,
        Difficult,
        Hard
    }
}