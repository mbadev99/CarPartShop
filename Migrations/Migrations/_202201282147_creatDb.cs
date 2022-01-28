using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Migrations
{
    [Migration(202201282147)]
    public class _202201282147_creatDb : Migration
    {
        public override void Up()
        {
            Create.Table("CarBrands")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable();

            Create.Table("CarModels")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("BrandId").AsGuid().NotNullable()
                .ForeignKey("FK_CarModels_CarBrands", "CarBrands", "Id")
                .OnDelete(System.Data.Rule.Cascade);
        }

        public override void Down()
        {
            Delete.Table("CarModels");

            Delete.Table("CarBrands");
        }

    }
}
