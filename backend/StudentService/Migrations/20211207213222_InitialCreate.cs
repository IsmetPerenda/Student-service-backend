using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kursevi",
                columns: table => new
                {
                    KursId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKursa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kursevi", x => x.KursId);
                });

            migrationBuilder.CreateTable(
                name: "KurseviStudenta",
                columns: table => new
                {
                    KursId = table.Column<int>(type: "int", nullable: false),
                    NazivKursa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "StatusStudents",
                columns: table => new
                {
                    StatusStudentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivStatusa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusStudents", x => x.StatusStudentaId);
                });

            migrationBuilder.CreateTable(
                name: "StudentiNaKursu",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    BrojIndeksa = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Godina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojIndeksa = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Godina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "StudentsInfoReport",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    BrojIndeksa = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Godina = table.Column<int>(type: "int", nullable: false),
                    StatusStudentaId = table.Column<int>(type: "int", nullable: false),
                    NazivStatusa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KursStudent",
                columns: table => new
                {
                    KurseviKursId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KursStudent", x => new { x.KurseviKursId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_KursStudent_Kursevi_KurseviKursId",
                        column: x => x.KurseviKursId,
                        principalTable: "Kursevi",
                        principalColumn: "KursId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KursStudent_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kursevi",
                columns: new[] { "KursId", "NazivKursa" },
                values: new object[,]
                {
                    { 1, "Matematika" },
                    { 2, "Fizika" },
                    { 3, "Hemija" },
                    { 4, "Programiranje" },
                    { 5, "Programiranje 2" }
                });

            migrationBuilder.InsertData(
                table: "StatusStudents",
                columns: new[] { "StatusStudentaId", "NazivStatusa" },
                values: new object[,]
                {
                    { 14, 0 },
                    { 13, 1 },
                    { 11, 0 },
                    { 10, 0 },
                    { 9, 1 },
                    { 8, 1 },
                    { 12, 1 },
                    { 6, 0 },
                    { 5, 0 },
                    { 4, 0 },
                    { 3, 1 },
                    { 2, 0 },
                    { 1, 0 },
                    { 7, 0 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BrojIndeksa", "Godina", "Ime", "Prezime" },
                values: new object[,]
                {
                    { 12, 233, 3, "Hiram ", "Garcia" },
                    { 11, 222, 2, "Broderick ", "Bentley" },
                    { 10, 211, 1, "Adrienne ", "Logan" },
                    { 9, 199, 3, "Hinton ", "Love" },
                    { 8, 188, 2, "Angelia ", "Ruiz" },
                    { 7, 177, 1, "Mccullough ", "Curry" },
                    { 4, 144, 1, "James ", "Hines" },
                    { 5, 155, 2, "Leon ", "Moran" },
                    { 3, 133, 3, "Brianna", "Wong" },
                    { 2, 122, 2, "Natalie", "Portman" },
                    { 1, 111, 1, "Chris", "Hemsworth" },
                    { 13, 244, 1, "Deshawn ", "Cummings" },
                    { 6, 166, 3, "Simpson ", "Evans" },
                    { 14, 255, 2, "Normand ", "Hughes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KursStudent_StudentId",
                table: "KursStudent",
                column: "StudentId");

            string GetStudentsInfoProcedure = @"CREATE PROCEDURE GetStudentsInfoProcedure
                                             @studentID int
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON
                                             SELECT*
                                             FROM[StudentService].[dbo].[Students] s
                                            JOIN[StudentService].[dbo].[StatusStudents] ss ON ss.StatusStudentaId = s.StudentId

                                             WHERE s.StudentId = @studentID
                                             END; ";



            string GetAllStudentsOnKursProcedure = @"CREATE PROCEDURE GetAllStudentsOnKurs
                                             @kursID int
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON
                                                SELECT s.[StudentId]
                                                    ,s.[BrojIndeksa]
                                                    ,s.[Ime]
                                                    ,s.[Prezime]
                                                    ,s.[Godina]
                                                FROM [StudentService].[dbo].[Students] s
                                                Join [StudentService].[dbo].[KursStudent] ks On s.[StudentId] = ks.StudentId
                                                Join [StudentService].[dbo].[Kursevi] k On k.[KursId] = ks.KurseviKursId
                                                where k.[KursId] = @kursID
                                             END; ";
            string GetAllKursesOfStudentProcedure = @"CREATE PROCEDURE GetAllKursesOfStudent
                                             @studentID int
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON
                                             SELECT     k.[KursId]
                                                        ,k.[NazivKursa]
                                             FROM [StudentService].[dbo].[Kursevi] k
                                             Join [StudentService].[dbo].[KursStudent] ks On k.[KursId] = ks.KurseviKursId
                                             Join [StudentService].[dbo].[Students] s On s.[StudentId] = ks.StudentId
                                             where s.[StudentId] = @studentID
                                             END; ";
            migrationBuilder.Sql(GetStudentsInfoProcedure);
            migrationBuilder.Sql(GetAllStudentsOnKursProcedure);
            migrationBuilder.Sql(GetAllKursesOfStudentProcedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KurseviStudenta");

            migrationBuilder.DropTable(
                name: "KursStudent");

            migrationBuilder.DropTable(
                name: "StatusStudents");

            migrationBuilder.DropTable(
                name: "StudentiNaKursu");

            migrationBuilder.DropTable(
                name: "StudentsInfoReport");

            migrationBuilder.DropTable(
                name: "Kursevi");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
            name: "GetStudentsInfoProcedure");

            migrationBuilder.DropTable(
            name: "GetAllStudentsOnKursProcedure");
            migrationBuilder.DropTable(
           name: "GetAllKursesOfStudentProcedure");
        }
    }
}
