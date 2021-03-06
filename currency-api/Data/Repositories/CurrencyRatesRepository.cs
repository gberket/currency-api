using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using currencyApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace currencyApi.Data
{
    public class CurrencyRatesRepository : GenericRepository<CurrencyRate>, ICurrencyRatesRepository
    {
        public CurrencyRatesRepository(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(unitOfWork, httpContextAccessor)
        {
        }

        public PagedItems<CurrencyRate> Get(int pageNumber = 0, int pageSize = 0, string sortTerm = null, bool sortDesc = false, string searchTerm = null)
        {
            var result = GetAll();
            
            result = result.Include(x => x.BaseCurrency).Include(x =>x.TargetCurrency);

        
            if (!String.IsNullOrWhiteSpace(searchTerm))
                result = result.Where(x => 
                            x.BaseCurrency.Code.ToUpper().Contains(searchTerm.ToUpper())
                            || x.BaseCurrency.Description.ToUpper().Contains(searchTerm.ToUpper())
                            || x.TargetCurrency.Code.ToUpper().Contains(searchTerm.ToUpper())
                            || x.TargetCurrency.Description.ToUpper().Contains(searchTerm.ToUpper())
                );

            if (!String.IsNullOrWhiteSpace(sortTerm))
            {
                if(sortTerm.ToUpper() == "BaseCurrencyCode".ToUpper())
                    result = sortDesc? result.OrderByDescending(x=>x.BaseCurrency.Code) : result.OrderBy(x=>x.BaseCurrency.Code);

                if(sortTerm.ToUpper() == "TargetCurrencyCode".ToUpper())
                    result = sortDesc? result.OrderByDescending(x=>x.TargetCurrency.Code) : result.OrderBy(x=>x.TargetCurrency.Code);
            }

            return new PagedItems<CurrencyRate>{
                Items = result.AsEnumerable(), 
                PageNumber = pageNumber,
                TotalPages = result.Count()
            };
        }

         public CurrencyRate GetOne(long id)
        {
            var result = GetAll();
            
            result = result.Include(x => x.BaseCurrency).Include(x =>x.TargetCurrency);

            result = result.Where(x => x.Id==id);

            return result.FirstOrDefault();
        }


         public CurrencyRate GetByCodes(string baseCode, string targetCode )
        {
            var result = GetAll();
            
            result = result.Include(x => x.BaseCurrency).Include(x =>x.TargetCurrency);

            result = result.Where(x => x.BaseCurrency.Code == baseCode && x.TargetCurrency.Code == targetCode);

            return result.FirstOrDefault();
        }

         public CurrencyRate GetByIds(long baseId, long targetId )
        {
            var result = GetAll();
            
            result = result.Include(x => x.BaseCurrency).Include(x =>x.TargetCurrency);

            result = result.Where(x => x.BaseCurrency.Id == baseId && x.TargetCurrency.Id == targetId);

            return result.FirstOrDefault();
        }
         public IEnumerable<CurrencyRate> GetByBaseCode(string baseCode)
        {
            var result = GetAll();
            
            result = result.Include(x => x.BaseCurrency).Include(x =>x.TargetCurrency);

            result = result.Where(x => x.BaseCurrency.Code == baseCode );

            return result.AsEnumerable();
        }
    }
}