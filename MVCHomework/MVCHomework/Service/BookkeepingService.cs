using MVCHomework.Models;
using MVCHomework.Models.ViewModels;
using MVCHomework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomework.Service
{
    public class BookkeepingService
    {
        private readonly IRepository<AccountBook> _accountBookRepository;

        public BookkeepingService(IUnitOfWork unitOfWork)
        {
            _accountBookRepository = new Repository<AccountBook>(unitOfWork);
        }


        public IEnumerable<BookkeepingViewModels> Lookup()
        {
            var source = _accountBookRepository.LookupAll();
            var result = source.Select(s => new BookkeepingViewModels()
            {
                category = (categoryType)s.Categoryyy,
                money = s.Amounttt,
                date = s.Dateee,
                description = s.Remarkkk
            });
            return result;
        }

    }
}