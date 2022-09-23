﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        // ilgili kulanıcının claim lerini içeren bir token üretecek
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
