using System;
using VWMS.SkyStatus.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace VWMS.SkyStatus.API.Repositories
{
    public class StatusMessageRepository
    {
        private readonly VWMSContext _context;

        public StatusMessageRepository(VWMSContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void SaveStatusMessage(StatusMessage statusMessage)
        {
            if (statusMessage == null)
            {
                throw new ArgumentNullException(nameof(statusMessage));
            }

            _context.StatusMessages.Add(statusMessage);
            _context.SaveChanges();
        }
    }
}
