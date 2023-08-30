using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFrameework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context) 
        {
            
        }
    }
}
