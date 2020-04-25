using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCharting
{
    public class SQLiteConfiguration : DbConfiguration
    {
        public SQLiteConfiguration()
        {
            //SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }
    public class GameContext : DbContext
    {
        public GameContext() : base("name=MyDatabase")
        {
            Database.SetInitializer<GameContext>(null);
        }

        public DbSet<PriceChartingModel> PriceChartingModels { get; set; }
        public DbSet<Data> PriceChartindData { get; set; }
    }
}
