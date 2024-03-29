﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCHomework.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; set; }
        void Commit();
    }
}