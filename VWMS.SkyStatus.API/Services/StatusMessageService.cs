using AutoMapper;
using VWMS.SkyStatus.API.Entities;
using VWMS.SkyStatus.API.Models;
using VWMS.SkyStatus.API.Repositories;

namespace VWMS.SkyStatus.API.Services
{
    public class StatusMessageService
    {
        private readonly IMapper _mapper;
        private readonly StatusMessageRepository _repository;

        public StatusMessageService(IMapper mapper, StatusMessageRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void ProcessStatusMessage(StatusMessageDto statusMessageDto)
        {
            // Map DTO to Entity
            var statusMessage = _mapper.Map<StatusMessage>(statusMessageDto);

            // Save to database
            _repository.SaveStatusMessage(statusMessage);
        }
    }
}
