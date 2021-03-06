using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert<T>(T t);
        void Delete<T>(T t);
        void Update<T>(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
