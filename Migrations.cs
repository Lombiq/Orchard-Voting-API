using System;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Contrib.Voting {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("VoteRecord",
                table => table
                    .Column<int>("Id", column => column.PrimaryKey().Identity())
                    .Column<DateTime>("CreatedUtc")
                    .Column<int>("ContentItemRecord_id")
                    .Column<string>("ContentType")
                    .Column<string>("Username")
                    .Column<string>("Hostname")
                    .Column<double>("Value")
                    .Column<int>("Axe")
                );

            SchemaBuilder.CreateTable("ResultRecord",
                table => table
                    .Column<int>("Id", column => column.PrimaryKey().Identity())
                    .Column<DateTime>("CreatedUtc", column => column.Nullable())
                    .Column<int>("ContentItemRecord_id")
                    .Column<string>("ContentType")
                    .Column<int>("Axe")
                    .Column<double>("Value")
                    .Column<int>("Count")
                    .Column<string>("FunctionName")
                );

            return 1;
        }
    }
}
