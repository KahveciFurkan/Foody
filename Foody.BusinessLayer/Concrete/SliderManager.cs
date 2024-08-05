using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class SliderManager : GenericManager<Slider>, ISliderService
    {
        public SliderManager(IGenericDal<Slider> genericDal) : base(genericDal)
        {
        }
    }
}
