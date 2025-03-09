using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class key_correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dentists_Appointments_AppointmentId",
                table: "Dentists");

            migrationBuilder.DropForeignKey(
                name: "FK_Dentists_TreatmentRecords_TreatmentRecordId",
                table: "Dentists");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Appointments_AppointmentId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Billings_BillingId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_TreatmentRecords_TreatmentRecordId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Appointments_AppointmentId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_TreatmentRecords_TreatmentRecordId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_TreatmentRecordId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_AppointmentId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Patients_AppointmentId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_BillingId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_TreatmentRecordId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Dentists_AppointmentId",
                table: "Dentists");

            migrationBuilder.DropIndex(
                name: "IX_Dentists_TreatmentRecordId",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "TreatmentRecordId",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "BillingId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TreatmentRecordId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "TreatmentRecordId",
                table: "Dentists");

            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "TreatmentRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "TreatmentRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreatmentId",
                table: "TreatmentRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Billings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DentistId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentRecords_DentistId",
                table: "TreatmentRecords",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentRecords_PatientId",
                table: "TreatmentRecords",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentRecords_TreatmentId",
                table: "TreatmentRecords",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_PatientId",
                table: "Billings",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DentistId",
                table: "Appointments",
                column: "DentistId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_RoomId",
                table: "Appointments",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Dentists_DentistId",
                table: "Appointments",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Rooms_RoomId",
                table: "Appointments",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Billings_Patients_PatientId",
                table: "Billings",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentRecords_Dentists_DentistId",
                table: "TreatmentRecords",
                column: "DentistId",
                principalTable: "Dentists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentRecords_Patients_PatientId",
                table: "TreatmentRecords",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentRecords_Treatments_TreatmentId",
                table: "TreatmentRecords",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Dentists_DentistId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Rooms_RoomId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Billings_Patients_PatientId",
                table: "Billings");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentRecords_Dentists_DentistId",
                table: "TreatmentRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentRecords_Patients_PatientId",
                table: "TreatmentRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentRecords_Treatments_TreatmentId",
                table: "TreatmentRecords");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentRecords_DentistId",
                table: "TreatmentRecords");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentRecords_PatientId",
                table: "TreatmentRecords");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentRecords_TreatmentId",
                table: "TreatmentRecords");

            migrationBuilder.DropIndex(
                name: "IX_Billings_PatientId",
                table: "Billings");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DentistId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_RoomId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "TreatmentRecords");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "TreatmentRecords");

            migrationBuilder.DropColumn(
                name: "TreatmentId",
                table: "TreatmentRecords");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "DentistId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentRecordId",
                table: "Treatments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BillingId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreatmentRecordId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Dentists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreatmentRecordId",
                table: "Dentists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TreatmentRecordId",
                table: "Treatments",
                column: "TreatmentRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_AppointmentId",
                table: "Rooms",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AppointmentId",
                table: "Patients",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_BillingId",
                table: "Patients",
                column: "BillingId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_TreatmentRecordId",
                table: "Patients",
                column: "TreatmentRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Dentists_AppointmentId",
                table: "Dentists",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Dentists_TreatmentRecordId",
                table: "Dentists",
                column: "TreatmentRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dentists_Appointments_AppointmentId",
                table: "Dentists",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dentists_TreatmentRecords_TreatmentRecordId",
                table: "Dentists",
                column: "TreatmentRecordId",
                principalTable: "TreatmentRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Appointments_AppointmentId",
                table: "Patients",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Billings_BillingId",
                table: "Patients",
                column: "BillingId",
                principalTable: "Billings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_TreatmentRecords_TreatmentRecordId",
                table: "Patients",
                column: "TreatmentRecordId",
                principalTable: "TreatmentRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Appointments_AppointmentId",
                table: "Rooms",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_TreatmentRecords_TreatmentRecordId",
                table: "Treatments",
                column: "TreatmentRecordId",
                principalTable: "TreatmentRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
