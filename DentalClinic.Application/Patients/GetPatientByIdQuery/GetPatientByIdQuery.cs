using DentalClinic.Domain.Patients;
using MediatR;

namespace DentalClinic.Application.Patients.GetPatientByIdQuery
{
    public record GetPatientByIdQuery(int Id) : IRequest<Patient>;
}
