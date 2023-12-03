using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IImageService
    {
        void Add(Image image);
        void Update(Image image);
        void Delete(Image image);
        List<Image> GetAll();
        List<Image> GetAll(Expression<Func<Image, bool>> filter);
        Image GetById(int id);
    }
}
