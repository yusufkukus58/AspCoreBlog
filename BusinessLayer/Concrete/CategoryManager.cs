using BusinessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository efCategoryRepo;

        public CategoryManager()  // Category Manager Constracter Metodu ile EFCategory Repository tanımlıyoruz
        {
            efCategoryRepo = new EFCategoryRepository();
        }

        public void AddCategory(Category addcategory)
        {
            efCategoryRepo.Insert(addcategory);  // Entity Framework Category Repository CRUD ekleme işlemi
        }

        public void CategoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category delcategory)
        {
            efCategoryRepo.Delete(delcategory);  // Entity Framework Category Repository CRUD silme işlemi
        }

        public Category GetById(int id)
        {
            return efCategoryRepo.GetById(id);  // Entity Framework Category Repository Id'ye göre arama işlemi
        }

        public List<Category> GetList()
        {
            return efCategoryRepo.GetList();  // Entity Framework Category Repository listeleme işlemi
        }

        public void UpdateCategory(Category upcategory)
        {
            efCategoryRepo.Update(upcategory);  // Entity Framework Category Repository güncelleme işlemi
        }
    }
}
