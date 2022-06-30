using HomeWork.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Abstract
{
    public  interface IKampanyaService
    {
        Task StartAsync(KampanyaInputModel input);
    }
}
