using Application.Contracts.Persistence;
using Application.Contracts.Persistence.HotelRoom;
using Persistence.Repositories.HotelRoom;

namespace Persistence.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
       
        public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
        public IHotelRoomRepository HotelRoomRepository { get; }

        public UnitOfWork(ApplicationDbContext db)
       {
           _db = db;
           UserRefreshTokenRepository = new UserRefreshTokenRepository(_db);
           HotelRoomRepository = new HotelRoomRepository(_db);
       }

        public  Task CommitAsync()
        {
            return _db.SaveChangesAsync();
        }

        public ValueTask RollBackAsync()
        {
            return _db.DisposeAsync();
        }
   }
}
