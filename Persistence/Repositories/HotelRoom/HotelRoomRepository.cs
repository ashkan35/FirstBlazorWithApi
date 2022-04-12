using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contracts.Persistence.HotelRoom;
using Application.Features.HotelRoom;
using Persistence.Repositories.Common;

namespace Persistence.Repositories.HotelRoom
{
    internal class HotelRoomRepository:BaseAsyncRepository<Domain.Entities.HotelRoom>,IHotelRoomRepository
    {
        public HotelRoomRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Domain.Entities.HotelRoom> CreateHotelRoomAsync(Domain.Entities.HotelRoom model)
        {
            await base.AddAsync(model);
            return model;
        }
    }
}
