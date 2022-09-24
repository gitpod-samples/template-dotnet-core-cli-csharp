using ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mozab.Service.Comments.Services
{
    public interface IHarperConfiguration
    {
        HarperDbConfiguration GetHarperConfigurations();
    }
}
