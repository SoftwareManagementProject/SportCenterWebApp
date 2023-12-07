using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPacketService
    {
        void Add(Packet packet);
        void Delete(Packet packet);
        void Update(Packet packet);
        List<Packet> GetAll();
        Packet GetById(int id);
        List<Packet> GetAllByUsername(string username);
    }
}
