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
    public class TrainerManager : ITrainerService
    {
        private ITrainerDal _trainerDal;

        public TrainerManager(ITrainerDal trainerDal)
        {
            _trainerDal = trainerDal;
        }
        public void Add(Trainer trainer)
        {
            _trainerDal.Add(trainer);
        }

        public void Delete(Trainer trainer)
        {
            _trainerDal.Delete(trainer);
        }

        public List<Trainer> GetAll()
        {
            return _trainerDal.GetAll();
        }

        public Trainer GetById(int id)
        {
            return _trainerDal.Get(i => i.TrainerId == id);
        }

        public void Update(Trainer trainer)
        {
            _trainerDal.Update(trainer);
        }
    }
}
