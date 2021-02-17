using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        /*
         * ProductManagerden "_productDal.GetAll(), true, Messages.ProductsListed" yazan kısım
         * Bizim T Data olarak yazdığımız kısıma gelir
         
         */
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message) // default , datanın default değeridir
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
