using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace hohsys.API.Migrations
{
    public partial class MakingComentsCompleteXD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "WorkRoutes",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "WorkRoutes",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "RouteName",
                table: "WorkRoutes",
                maxLength: 200,
                nullable: true,
                comment: "Título que corresponde al registro de rutas de trabajo.",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "WorkRoutes",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "WorkRoutes",
                nullable: true,
                comment: "Imagen titular del registro de ruta.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WorkRoutes",
                maxLength: 500,
                nullable: true,
                comment: "Descripción general de la ruta de trabajo.",
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "WorkRoutes",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "WorkRoutes",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "WorkRoutes",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "WorkRouteMedia",
                nullable: false,
                comment: "Usuario que realizó la última actualización",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "WorkRouteMedia",
                nullable: false,
                comment: "Usuario que creó el registro",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "WorkRouteMedia",
                nullable: true,
                comment: "dirección de ubicación del archivo al que refiere el registro",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "WorkRouteMedia",
                nullable: false,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "WorkRouteMedia",
                nullable: false,
                comment: "Fecha de última actualización del registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "WorkRouteMedia",
                nullable: false,
                comment: "Fecha en la que se agregó el registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "WorkRouteMedia",
                nullable: false,
                comment: "Llave primaria de la entidad",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "WorkRouteComentaries",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "WorkRouteComentaries",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "WorkRouteComentaries",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "WorkRouteComentaries",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "WorkRouteComentaries",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "WorkRouteComentaries",
                nullable: true,
                comment: "Cuerpo del comentario.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "WorkRouteComentaries",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Schedules",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Schedules",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Schedules",
                nullable: true,
                comment: "Estado actual de un horario (Pendiente, ejecutado, cancelado).",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Schedules",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Day",
                table: "Schedules",
                nullable: false,
                comment: "Nombre del dia que corresponda al registro de horario creado.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Schedules",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Schedules",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Schedules",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Positions",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Positions",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                nullable: true,
                comment: "Nombre del cargo o posición que se ejerce en una clínica.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Positions",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Positions",
                nullable: true,
                comment: "Descripción del cargo.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Positions",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Positions",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Positions",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "PhoneNumbers",
                nullable: true,
                comment: "Corresponde al registro número de teléfono.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "PhoneNumbers",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "PhoneNumbers",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PhoneNumbers",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Extention",
                table: "PhoneNumbers",
                nullable: true,
                comment: "Número de extensión del número.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "PhoneNumbers",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "PhoneNumbers",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PhoneNumbers",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "PatientComentaries",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "PatientComentaries",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PatientComentaries",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "PatientComentaries",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "PatientComentaries",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "PatientComentaries",
                nullable: true,
                comment: "Cuerpo del comentario.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PatientComentaries",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Pacients",
                nullable: false,
                comment: "Usuario que realizó la última actualización",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Pacients",
                nullable: false,
                comment: "Usuario que creó el registro",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LastName2",
                table: "Pacients",
                maxLength: 100,
                nullable: true,
                comment: "Segundo apellido del paciente",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName1",
                table: "Pacients",
                maxLength: 100,
                nullable: true,
                comment: "Primer apellido del paciente",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Pacients",
                nullable: false,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName2",
                table: "Pacients",
                maxLength: 100,
                nullable: true,
                comment: "Segundo nombre del paciente",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName1",
                table: "Pacients",
                maxLength: 100,
                nullable: true,
                comment: "Primer nombre del paciente",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Pacients",
                nullable: false,
                comment: "Fecha de última actualización del registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Pacients",
                nullable: false,
                comment: "Fecha en la que se agregó el registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Pacients",
                maxLength: 400,
                nullable: true,
                comment: "Dirección domiciliar del paciente",
                oldClrType: typeof(string),
                oldType: "character varying(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pacients",
                nullable: false,
                comment: "Llave primaria de la entidad",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "PacientMedia",
                nullable: false,
                comment: "Usuario que realizó la última actualización",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "PacientMedia",
                nullable: false,
                comment: "Usuario que creó el registro",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "PacientMedia",
                nullable: true,
                comment: "dirección de ubicación del archivo al que refiere el registro",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PacientMedia",
                nullable: false,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "PacientMedia",
                nullable: false,
                comment: "Fecha de última actualización del registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "PacientMedia",
                nullable: false,
                comment: "Fecha en la que se agregó el registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PacientMedia",
                nullable: false,
                comment: "Llave primaria de la entidad",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "MedicalRecords",
                nullable: false,
                comment: "Usuario que realizó la última actualización",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "MedicalRecords",
                nullable: false,
                comment: "Usuario que creó el registro",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "MedicalRecords",
                nullable: false,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MedicalRecords",
                nullable: false,
                comment: "Fecha de última actualización del registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "MedicalRecords",
                nullable: false,
                comment: "Fecha en la que se agregó el registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MedicalRecords",
                nullable: false,
                comment: "Llave primaria de la entidad",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "MedicalIndications",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "MedicalIndications",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "MedicalIndications",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MedicalIndications",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "MedicalIndications",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "MedicalIndications",
                nullable: true,
                comment: "Cuerpo o descripción de registro de indicación.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MedicalIndications",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "MediaCategories",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "MediaCategories",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "MediaCategories",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MediaCategories",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "MediaCategories",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "MediaCategories",
                nullable: true,
                comment: "Nombre de la categoría.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MediaCategories",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Employees",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Employees",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Employees",
                nullable: true,
                comment: "Foto de perdil de empleado.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName2",
                table: "Employees",
                maxLength: 100,
                nullable: true,
                comment: "Segundo apellido del empleado.",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName1",
                table: "Employees",
                maxLength: 100,
                nullable: true,
                comment: "Primer apellido del empleado.",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Employees",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName2",
                table: "Employees",
                maxLength: 100,
                nullable: true,
                comment: "Segundo nombre del empleado.",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName1",
                table: "Employees",
                maxLength: 100,
                nullable: true,
                comment: "Primer nombre del empleado.",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Employees",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Employees",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                maxLength: 400,
                nullable: true,
                comment: "Dirección domiciliar del empleado.",
                oldClrType: typeof(string),
                oldType: "character varying(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Emails",
                nullable: false,
                comment: "Usuario que realizó la última actualización.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Emails",
                nullable: false,
                comment: "Usuario que creó el registro.",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Emails",
                nullable: false,
                comment: "Propiedad de borrado lógico.",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Emails",
                nullable: true,
                comment: "Corresponde a la dirección de correo electrónico.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Emails",
                nullable: false,
                comment: "Fecha de última actualización del registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Emails",
                nullable: false,
                comment: "Fecha en la que se agregó el registro.",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Emails",
                nullable: false,
                comment: "Llave primaria de la entidad.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Destinations",
                nullable: false,
                comment: "Usuario que realizó la última actualización",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Destinations",
                nullable: false,
                comment: "Usuario que creó el registro",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Destinations",
                nullable: true,
                comment: "Imagen principal del registro",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Destinations",
                nullable: false,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleMapEmbedUrl",
                table: "Destinations",
                nullable: true,
                comment: "Url de google Maps de la localización geográfica del destino.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DestinationName",
                table: "Destinations",
                nullable: true,
                comment: "Titulo o nombre del destino",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                nullable: true,
                comment: "Descrición general del destino",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Destinations",
                nullable: false,
                comment: "Fecha de última actualización del registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Destinations",
                nullable: false,
                comment: "Fecha en la que se agregó el registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Destinations",
                nullable: false,
                comment: "Llave primaria de la entidad",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Clinics",
                nullable: false,
                comment: "Usuario que realizó la última actualización",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Clinics",
                nullable: false,
                comment: "Usuario que creó el registro",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clinics",
                maxLength: 100,
                nullable: true,
                comment: "Número de teléfono de la clínica",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                maxLength: 60,
                nullable: true,
                comment: "Nombre de la clinica en el registro",
                oldClrType: typeof(string),
                oldType: "character varying(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Clinics",
                nullable: false,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Clinics",
                maxLength: 500,
                nullable: true,
                comment: "Descripción general de la clínica",
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Clinics",
                nullable: false,
                comment: "Fecha de última actualización del registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Clinics",
                nullable: false,
                comment: "Fecha en la que se agregó el registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Clinics",
                maxLength: 100,
                nullable: true,
                comment: "Ciudad donde se ubica la clínica",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clinics",
                maxLength: 500,
                nullable: true,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Clinics",
                nullable: false,
                comment: "Llave primaria de la entidad",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true,
                comment: "Nombre de usuario. En este caso solo se guarda el primer nombre de un usuario.",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                nullable: true,
                comment: "Apellido de un usuario. para este registro solo se almacena un apellido de usuario",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: false,
                comment: "Propiedad de borrado lógico",
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "AspNetUsers",
                nullable: false,
                comment: "Fecha de última actualización del registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "AspNetUsers",
                nullable: false,
                comment: "Fecha en la que se agregó el registro",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUsers",
                nullable: false,
                comment: "Llave primaria de la entidad",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "WorkRoutes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "WorkRoutes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "RouteName",
                table: "WorkRoutes",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "Título que corresponde al registro de rutas de trabajo.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "WorkRoutes",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "WorkRoutes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Imagen titular del registro de ruta.");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "WorkRoutes",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Descripción general de la ruta de trabajo.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "WorkRoutes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "WorkRoutes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "WorkRoutes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "WorkRouteMedia",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "WorkRouteMedia",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "WorkRouteMedia",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "dirección de ubicación del archivo al que refiere el registro");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "WorkRouteMedia",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "WorkRouteMedia",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "WorkRouteMedia",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "WorkRouteMedia",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "WorkRouteComentaries",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "WorkRouteComentaries",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "WorkRouteComentaries",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "WorkRouteComentaries",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "WorkRouteComentaries",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "WorkRouteComentaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Cuerpo del comentario.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "WorkRouteComentaries",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Schedules",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Schedules",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Schedules",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Estado actual de un horario (Pendiente, ejecutado, cancelado).");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Schedules",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Day",
                table: "Schedules",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Nombre del dia que corresponda al registro de horario creado.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Schedules",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Schedules",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Schedules",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Positions",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Positions",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Nombre del cargo o posición que se ejerce en una clínica.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Positions",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Positions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Descripción del cargo.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Positions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Positions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Positions",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "PhoneNumbers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Corresponde al registro número de teléfono.");

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "PhoneNumbers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "PhoneNumbers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PhoneNumbers",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<string>(
                name: "Extention",
                table: "PhoneNumbers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Número de extensión del número.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "PhoneNumbers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "PhoneNumbers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PhoneNumbers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "PatientComentaries",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "PatientComentaries",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PatientComentaries",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "PatientComentaries",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "PatientComentaries",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "PatientComentaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Cuerpo del comentario.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PatientComentaries",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Pacients",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Pacients",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro");

            migrationBuilder.AlterColumn<string>(
                name: "LastName2",
                table: "Pacients",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Segundo apellido del paciente");

            migrationBuilder.AlterColumn<string>(
                name: "LastName1",
                table: "Pacients",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Primer apellido del paciente");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Pacients",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName2",
                table: "Pacients",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Segundo nombre del paciente");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName1",
                table: "Pacients",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Primer nombre del paciente");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Pacients",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Pacients",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Pacients",
                type: "character varying(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400,
                oldNullable: true,
                oldComment: "Dirección domiciliar del paciente");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pacients",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "PacientMedia",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "PacientMedia",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "PacientMedia",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "dirección de ubicación del archivo al que refiere el registro");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PacientMedia",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "PacientMedia",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "PacientMedia",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PacientMedia",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "MedicalRecords",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "MedicalRecords",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "MedicalRecords",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MedicalRecords",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "MedicalRecords",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MedicalRecords",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "MedicalIndications",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "MedicalIndications",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "MedicalIndications",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MedicalIndications",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "MedicalIndications",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "MedicalIndications",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Cuerpo o descripción de registro de indicación.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MedicalIndications",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "MediaCategories",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "MediaCategories",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "MediaCategories",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MediaCategories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "MediaCategories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "MediaCategories",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Nombre de la categoría.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MediaCategories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Employees",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Employees",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Employees",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Foto de perdil de empleado.");

            migrationBuilder.AlterColumn<string>(
                name: "LastName2",
                table: "Employees",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Segundo apellido del empleado.");

            migrationBuilder.AlterColumn<string>(
                name: "LastName1",
                table: "Employees",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Primer apellido del empleado.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Employees",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName2",
                table: "Employees",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Segundo nombre del empleado.");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName1",
                table: "Employees",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Primer nombre del empleado.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "character varying(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400,
                oldNullable: true,
                oldComment: "Dirección domiciliar del empleado.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Emails",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización.");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Emails",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro.");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Emails",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico.");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Emails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Corresponde a la dirección de correo electrónico.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Emails",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro.");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Emails",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro.");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Emails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Destinations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Destinations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro");

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Destinations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Imagen principal del registro");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Destinations",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleMapEmbedUrl",
                table: "Destinations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Url de google Maps de la localización geográfica del destino.");

            migrationBuilder.AlterColumn<string>(
                name: "DestinationName",
                table: "Destinations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Titulo o nombre del destino");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Destinations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Descrición general del destino");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Destinations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Destinations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Destinations",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "UserUpdated",
                table: "Clinics",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que realizó la última actualización");

            migrationBuilder.AlterColumn<string>(
                name: "UserAdded",
                table: "Clinics",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Usuario que creó el registro");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clinics",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Número de teléfono de la clínica");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Clinics",
                type: "character varying(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Nombre de la clinica en el registro");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Clinics",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Clinics",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Descripción general de la clínica");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Clinics",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "Clinics",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Clinics",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Ciudad donde se ubica la clínica");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clinics",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Clinics",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Nombre de usuario. En este caso solo se guarda el primer nombre de un usuario.");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Apellido de un usuario. para este registro solo se almacena un apellido de usuario");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Propiedad de borrado lógico");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha de última actualización del registro");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateAdded",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldComment: "Fecha en la que se agregó el registro");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Llave primaria de la entidad")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
