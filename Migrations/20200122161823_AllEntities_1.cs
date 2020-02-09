using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace hohsys.API.Migrations
{
    public partial class AllEntities_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "AspNetUsers",
                newName: "Lastname");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false, comment: "Name of the clinic"),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkRoutes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    RouteName = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    FeaturedImage = table.Column<string>(nullable: true),
                    ClinicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkRoutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkRoutes_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    DestinationName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    GoogleMapEmbedUrl = table.Column<string>(nullable: true),
                    WorkRouteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destinations_WorkRoutes_WorkRouteId",
                        column: x => x.WorkRouteId,
                        principalTable: "WorkRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    FirstName1 = table.Column<string>(maxLength: 100, nullable: true),
                    FirstName2 = table.Column<string>(maxLength: 100, nullable: true),
                    LastName1 = table.Column<string>(maxLength: 100, nullable: true),
                    LastName2 = table.Column<string>(maxLength: 100, nullable: true),
                    ProfilePicture = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 400, nullable: true),
                    ClinicId = table.Column<int>(nullable: false),
                    WorkRouteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_WorkRoutes_WorkRouteId",
                        column: x => x.WorkRouteId,
                        principalTable: "WorkRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    FirstName1 = table.Column<string>(maxLength: 100, nullable: true),
                    FirstName2 = table.Column<string>(maxLength: 100, nullable: true),
                    LastName1 = table.Column<string>(maxLength: 100, nullable: true),
                    LastName2 = table.Column<string>(maxLength: 100, nullable: true),
                    Birth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(maxLength: 400, nullable: true),
                    ClinicId = table.Column<int>(nullable: true),
                    WorkRouteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacients_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacients_WorkRoutes_WorkRouteId",
                        column: x => x.WorkRouteId,
                        principalTable: "WorkRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    Day = table.Column<DateTimeOffset>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    WorkRouteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_WorkRoutes_WorkRouteId",
                        column: x => x.WorkRouteId,
                        principalTable: "WorkRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkRouteComentaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    WorkRouteId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkRouteComentaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkRouteComentaries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkRouteComentaries_WorkRoutes_WorkRouteId",
                        column: x => x.WorkRouteId,
                        principalTable: "WorkRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkRouteMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    MediaCategoryId = table.Column<int>(nullable: true),
                    WorkRouteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkRouteMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkRouteMedia_MediaCategories_MediaCategoryId",
                        column: x => x.MediaCategoryId,
                        principalTable: "MediaCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkRouteMedia_WorkRoutes_WorkRouteId",
                        column: x => x.WorkRouteId,
                        principalTable: "WorkRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    number = table.Column<string>(nullable: true),
                    Extention = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    PositionName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    PacientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Pacients_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacientMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    MediaCategoryId = table.Column<int>(nullable: true),
                    PacientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PacientMedia_MediaCategories_MediaCategoryId",
                        column: x => x.MediaCategoryId,
                        principalTable: "MediaCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacientMedia_Pacients_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientComentaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    PacientId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientComentaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientComentaries_Pacients_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientComentaries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalIndications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTimeOffset>(nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: false),
                    UserAdded = table.Column<string>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    MedicalRecordId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalIndications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalIndications_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalIndications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_WorkRouteId",
                table: "Destinations",
                column: "WorkRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmployeeId",
                table: "Emails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ClinicId",
                table: "Employees",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkRouteId",
                table: "Employees",
                column: "WorkRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalIndications_MedicalRecordId",
                table: "MedicalIndications",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalIndications_UserId",
                table: "MedicalIndications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PacientId",
                table: "MedicalRecords",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientMedia_MediaCategoryId",
                table: "PacientMedia",
                column: "MediaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PacientMedia_PacientId",
                table: "PacientMedia",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_ClinicId",
                table: "Pacients",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_WorkRouteId",
                table: "Pacients",
                column: "WorkRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientComentaries_PacientId",
                table: "PatientComentaries",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientComentaries_UserId",
                table: "PatientComentaries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_EmployeeId",
                table: "PhoneNumbers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_EmployeeId",
                table: "Positions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_WorkRouteId",
                table: "Schedules",
                column: "WorkRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRouteComentaries_UserId",
                table: "WorkRouteComentaries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRouteComentaries_WorkRouteId",
                table: "WorkRouteComentaries",
                column: "WorkRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRouteMedia_MediaCategoryId",
                table: "WorkRouteMedia",
                column: "MediaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRouteMedia_WorkRouteId",
                table: "WorkRouteMedia",
                column: "WorkRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRoutes_ClinicId",
                table: "WorkRoutes",
                column: "ClinicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "MedicalIndications");

            migrationBuilder.DropTable(
                name: "PacientMedia");

            migrationBuilder.DropTable(
                name: "PatientComentaries");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "WorkRouteComentaries");

            migrationBuilder.DropTable(
                name: "WorkRouteMedia");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "MediaCategories");

            migrationBuilder.DropTable(
                name: "Pacients");

            migrationBuilder.DropTable(
                name: "WorkRoutes");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "lastname");
        }
    }
}
