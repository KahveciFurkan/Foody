﻿using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.EntityFramework;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class ReviewManager : GenericManager<Review>, IReviewService
    {
        public ReviewManager(IGenericDal<Review> genericDal) : base(genericDal)
        {
        }
    }
}