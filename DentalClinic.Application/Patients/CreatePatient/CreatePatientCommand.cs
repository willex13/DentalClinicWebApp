using MediatR;

namespace DentalClinic.Application.Patients.CreatePatient
{
    public record CreatePatientCommand(string FirstName, string LastName, string Phone, DateTime? DateOfBirth, char Gender, string Email, string NIF, string MedicalHistory) : IRequest<int>;

}
