using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ASPMessageBoard.Services.Encryptors
{
    public interface IEncryptor
    {
        string Encrypt(string input);
    }
}
