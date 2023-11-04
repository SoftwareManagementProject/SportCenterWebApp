using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InMemory
{
    public class InMemoryTrainerRepository : ITrainerDal
    {
        private IQueryable<Trainer> _trainers;

        public InMemoryTrainerRepository()
        {
            _trainers = new List<Trainer>()
            {
                new Trainer() {TrainerId=1, CategoryId=1, NameSurname="Yusuf Dilekci", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer1.jpg"},
                new Trainer() {TrainerId=2, CategoryId=1, NameSurname="Sadik Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer2.jpg"},
                new Trainer() {TrainerId=3, CategoryId=2, NameSurname="Birol Sahin", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer3.jpg"},
                new Trainer() {TrainerId=4, CategoryId=2, NameSurname="Azat Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer4.jpg"},
                new Trainer() {TrainerId=5, CategoryId=3, NameSurname="Mert Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer5.jpg"},
                new Trainer() {TrainerId=6, CategoryId=4, NameSurname="Fatih Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer6.jpg"},
                new Trainer() {TrainerId=7, CategoryId=5, NameSurname="James Dincel", TrainerDescription="qwuıewqeouqw", TrainerImage="trainer7.jpg"},

            }.AsQueryable();
        }

        public void Add(Trainer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Trainer entity)
        {
            throw new NotImplementedException();
        }

        public Trainer Get(Expression<Func<Trainer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Trainer> GetAll(Expression<Func<Trainer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Trainer entity)
        {
            throw new NotImplementedException();
        }
    }
}
