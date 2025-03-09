using DentalClinic.Domain.Patients;
using MediatR;

namespace DentalClinic.Application.Patients.GetPatientByIdQuery
{
    public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, Patient>
    {
        private readonly IPatientRepository _patientRepository;

        public GetPatientByIdQueryHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<Patient> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            var patient = await _patientRepository.GetPatientAsync(request.Id);
            return patient;
        }
    }
}
