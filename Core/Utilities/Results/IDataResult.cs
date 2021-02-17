using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Success ve Message işlemlerini tekrar yazmamak için IResult implement ettik
    public interface IDataResult<T>:IResult 
    {
        T Data { get; }
    }
}
