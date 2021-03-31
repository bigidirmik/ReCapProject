using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int userId);
        IDataResult<User> GetUserByMail(string email);

        IDataResult<List<OperationClaim>> GetClaims(User user);

        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
