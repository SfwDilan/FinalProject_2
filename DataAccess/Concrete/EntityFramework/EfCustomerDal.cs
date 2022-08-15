using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        //ICustomerDal 'a neden ihtiyaç var ? Zaten diğer sınıftan inhereiiance alıyorum
        //Sebep1: EnttityFramework'tan farklı bir mimariye geçebiliriz(dapper,Nhibernate,portgrSql...) ve,
        //Sebeb2: ICustomer'de Sadece Customer' e ait özel operasyonları buraya çekicez.Bunu da DTO ilr yapıcaz.
    }
}
