using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
        List<Member> GetAll();
        Member GetById(int id);
    }
}
