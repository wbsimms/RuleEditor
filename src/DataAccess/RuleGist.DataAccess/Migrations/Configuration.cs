using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace RuleGist.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RuleGistContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

		[ExcludeFromCodeCoverage]
        protected override void Seed(RuleGistContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


			AddLoggingTables(context);
	        context.SaveChanges();
        }

		[ExcludeFromCodeCoverage]
		private void AddLoggingTables(RuleGistContext context)
		{
			string databaseSql =
				new StreamReader(
					this.GetType()
						.Assembly.GetManifestResourceStream(
							"RuleGist.DataAccess.Migrations.Scripts.CreateLoggingDatabaseObjects.sql")).ReadToEnd();
			context.Database.ExecuteSqlCommand(databaseSql);
		}
    }
}
