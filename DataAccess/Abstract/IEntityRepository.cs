using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    // class : class demek referance tip demektir
    // IEntity : IEntity olabilir yada IEntityden implement eden bir nesne olabilir(Product,Category,Customer vs) verilebilsin(int,string verilmesin)
    // new () : new'lene bilir olmalı. Interfaceler newlenmediği için IEntity verilmez. IEntity'den implement edilenler verilebilir
    // Sistemimiz artık sadece veritabanı nesneleriyle çalışan bir Repository oldu
    public interface IEntityRepository<T> where T : class,IEntity,new ()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filter=null , filtre vermek zorunlu değil, filtre vermemişse herşeyi listeler
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
