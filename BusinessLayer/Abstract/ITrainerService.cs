using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITrainerService
    {
        void Add(Trainer trainer);
        void Update(Trainer trainer);
        void Delete(Trainer trainer);
        List<Trainer> GetAll();
        Trainer GetById(int id);
    }
}
