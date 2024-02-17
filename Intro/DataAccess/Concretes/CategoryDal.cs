using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private readonly List<Category> _category;
        public CategoryDal()
        {
            _category = new List<Category>
            {
                new Category{CategoryId=1, CategoryName = "Programlama"},
                new Category{CategoryId=2, CategoryName="Backend"},
                new Category{CategoryId=3, CategoryName="Siber Güvenlik"}
            };
        }
     
        void ICategoryDal.Add(Category category)
        {
            _category.Add(category);
        }

        void ICategoryDal.Delete(Category category)
        {
            _category.Remove(category);
        }

        List<Category> ICategoryDal.GetAll()
        {
           return _category;
        }

        void ICategoryDal.Update(Category category)
        {
            var result = _category.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            if (result != null)
            {
                result.CategoryName = category.CategoryName;
            };
        }
    }
}
