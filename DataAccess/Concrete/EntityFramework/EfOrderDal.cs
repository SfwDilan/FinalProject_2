using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
        //IOrderDal 'a neden ihtiyaç var ? Zaten diğer sınıftan inhereiiance alıyorum
        //Sebep1: EnttityFramework'tan farklı bir mimariye geçebiliriz(dapper,Nhibernate,portgrSql...) ve,
        //Sebeb2: IOrder'de Sadece Order' e ait özel operasyonları buraya çekicez.Bunu da DTO ilr yapıcaz.
    }
}
