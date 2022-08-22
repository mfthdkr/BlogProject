using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract.Generic;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IWriterDal: IGenericDal<Writer>
    {
    }
}
