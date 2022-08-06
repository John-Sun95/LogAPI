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
                    ApplicationID = table.Column<int>(maxLength: 20, nullable: false),
                    TraceID = table.Column<int>(maxLength: 20, nullable: false),
                    Severity = table.Column<string>(maxLength: 20, nullable: true),
                    Timestamp = table.Column<string>(maxLength: 20, nullable: true),
                    Message = table.Column<string>(maxLength: 50, nullable: true),
                    ComponentName = table.Column<string>(maxLength: 10, nullable: true),
                    RequestId = table.Column<int>(maxLength: 20, nullable: false)
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
