using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PacketManager : IPacketService
    {
        private IPacketDal _packetDal;

        public PacketManager(IPacketDal packetDal)
        {
            _packetDal = packetDal;
        }

        public void Add(Packet packet)
        {
            _packetDal.Add(packet);
        }

        public void Delete(Packet packet)
        {
            _packetDal.Delete(packet);
        }

        public List<Packet> GetAll()
        {
            return _packetDal.GetAll();
        }

        public List<Packet> GetAllByUsername(string username)
        {
            return _packetDal.GetAllByUsername(username);
        }

        public Packet GetById(int id)
        {
            return _packetDal.Get(i => i.PacketId == id);
        }

        public void Update(Packet packet)
        {
            _packetDal.Update(packet);
        }
    }
}
