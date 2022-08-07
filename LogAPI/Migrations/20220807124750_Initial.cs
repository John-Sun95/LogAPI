using Microsoft.EntityFrameworkCore.Migrations;

namespace LogAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogEntry",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ApplicationID = table.Column<int>(nullable: false),
                    TraceID = table.Column<int>(nullable: false),
                    Severity = table.Column<string>(maxLength: 30, nullable: false),
                    Timestamp = table.Column<string>(maxLength: 30, nullable: false),
                    Message = table.Column<string>(maxLength: 50, nullable: false),
                    ComponentName = table.Column<string>(maxLength: 30, nullable: false),
                    RequestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntry", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogEntry");
        }
    }
}
