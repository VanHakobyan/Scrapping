using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hellocoton;
using Newtonsoft.Json;

namespace EmailLoading
{
    class Program
    {
        private const string baseDir = @"D:\HelloCoton";
        static void Main(string[] args)
        {
            var fileHJson = File.ReadAllLines(baseDir + "/heepsy.csv");
            Categores categores=new Categores();
            categores.Profiles=new List<Profile>();
            foreach (var s in fileHJson)
            {
                var strings = s.Split(',');
                categores.Profiles.Add(new Profile { Nickname = strings[1],eMail = strings[2],InstagramURL = strings[4],Abonnés = strings[3]});
            }
            var files = Directory.GetFiles(baseDir);
            List<Categores> categoreses = new List<Categores>();
            foreach (var file in files)
            {
                var fileJson = File.ReadAllText(file);
                var cat = JsonConvert.DeserializeObject<Categores>(fileJson);
                categoreses.Add(cat);
            }

            categores.CategoreName = "heepsy";
            categoreses.Add(categores);
            var profiles = categoreses.SelectMany(x => x.Profiles).Where(x => x.eMail != null && x.eMail.Contains("@")).ToList();
            File.WriteAllText(@"D:\ProfileWithEmailHelloCoton.json", JsonConvert.SerializeObject(profiles));
        }
    }
}
