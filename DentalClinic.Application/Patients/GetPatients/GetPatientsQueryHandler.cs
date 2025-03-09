using DentalClinic.Domain.Patients;
using MediatR;

namespace DentalClinic.Application.Patients.GetPatients
{
    public class GetPatientsQueryHandler : IRequestHandler<GetPatientsQuery, IEnumerable<Patient>>
    {
        private readonly IPatientRepository _patientRepository;
        public GetPatientsQueryHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<IEnumerable<Patient>> Handle(GetPatientsQuery request, CancellationToken cancellationToken)
        {
            var patients = await _patientRepository.GetAllPatientsAsync();
            return patients;
        }
    }
}
