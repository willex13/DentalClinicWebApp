using DentalClinic.Domain.Patients;
using MediatR;

namespace DentalClinic.Application.Patients.CreatePatient
{
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IPatientRepository _patientRepository;

        public CreatePatientCommandHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<int> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var patient = new Patient { FirstName = request.FirstName, LastName = request.LastName, Phone = request.Phone, DateOfBirth = request.DateOfBirth, Gender = request.Gender, Email = request.Email, NIF = request.NIF, MedicalHistory = request.MedicalHistory };
            await _patientRepository.AddPatientAsync(patient);
            return patient.Id;
        }
    }
}
