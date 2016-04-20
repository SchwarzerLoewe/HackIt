using HackIt.Core.Models;
using LiteDB;
using System;
using System.Collections.Generic;

namespace HackIt.Core
{
    public class SavedGame
    {
        public List<Mission> CompletedMissions { get; set; } = new List<Mission>();
        public Mission CurrentMission { get; set; }
        public int Coins { get; set; } = 0;
        public int Id { get; set; } = 0;
        public int Points { get; set; }
        public Dictionary<string, List<Command>> Commands = new Dictionary<string, List<Command>>();

        public static SavedGame Load()
        {
            SavedGame sg = null;

            using (var db = new LiteDatabase(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\HackIT.saved"))
            {
                var col = db.GetCollection<SavedGame>("Game");
                sg = col.FindById(0);

                if (sg == null) sg = new SavedGame();

                var cmds = db.GetCollection<CustomCommand>("Commands");
                var fa = cmds.FindAll();
                foreach (var item in fa)
                {
                    if (sg.Commands.ContainsKey(item.Name)) continue;
                    sg.Commands.Add(item.Name, item.Commands);
                }
            }

            return sg;
        }

        public void Save()
        {
            using (var db = new LiteDatabase(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\HackIT.saved"))
            {                
                if (db.CollectionExists("Game"))
                {
                    var col = db.GetCollection<SavedGame>("Game");
                    col.Insert(this);
                }
                else
                {
                    var col = db.GetCollection<SavedGame>("Game");
                    col.Update(0, this);
                }

                var cmds = db.GetCollection<CustomCommand>("Commands");

                foreach (var c in Commands)
                {
                    var cm = new CustomCommand();
                    cm.Name = c.Key;
                    cm.Commands = c.Value;

                    cmds.Insert(cm);
                }

                db.Commit();
            }
        }
    }
}