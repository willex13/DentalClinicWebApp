using DentalClinic.Domain.Patients;
using MediatR;

namespace DentalClinic.Application.Patients.GetPatients
{
    public class GetPatientsQuery : IRequest<List<Patient>>
    {

    }
}
