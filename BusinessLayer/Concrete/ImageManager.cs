using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private IImageDal _imageDal;
        public ImageManager(IImageDal imageDal) 
        {
            _imageDal= imageDal;
        }
        public void Add(Image image)
        {
            _imageDal.Add(image);
        }

        public void Delete(Image image)
        {
            _imageDal.Delete(image);
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetAll();
        }

        public List<Image> GetAll(Expression<Func<Image, bool>> filter)
        {
            return _imageDal.GetAll(filter);
        }

        public Image GetById(int id)
        {
            return _imageDal.Get(i => i.ImageId == id);
        }

        public void Update(Image image)
        {
            _imageDal.Update(image);
        }
    }
}
