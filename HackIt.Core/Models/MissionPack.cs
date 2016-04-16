using HackIt.Core.Models;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace HackIt.Core
{
    public class MissionPack : List<Mission>
    {
        public string Name { get; set; }

        public static MissionPack Load(string filename)
        {
            MissionPack sg = new MissionPack();
            
            using (var db = new LiteDatabase(filename))
            {
                if (db.CollectionExists("Meta"))
                {
                    var meta = db.GetCollection("Meta");
                    sg.Name = meta.FindAll().ToArray()[0]["name"];
                }

                var col = db.GetCollection<Mission>("Missions");

                foreach (var m in col.FindAll())
                {
                    sg.Add(m);
                }
            }

            return sg;
        }

        public void Save(string filename)
        {
            System.IO.File.Delete(filename);

            using (var db = new LiteDatabase(filename))
            {
                var meta = db.GetCollection("Meta");
                
                var metaDict = new Dictionary<string, BsonValue>()
                {
                    ["name"] = Name
                };
                meta.Insert(new BsonDocument(metaDict));

                var col = db.GetCollection<Mission>("Missions");
                

                foreach (var m in this)
                {
                    col.Insert(m);
                }
                db.Commit();
            }
        }

        public override string ToString() => Name;
    }
}