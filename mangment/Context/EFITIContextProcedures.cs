﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using mangment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace mangment.Context
{
    public partial class EFITIContext
    {
        private IEFITIContextProcedures _procedures;

        public virtual IEFITIContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new EFITIContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IEFITIContextProcedures GetProcedures()
        {
            return Procedures;
        }
    }

    public partial class EFITIContextProcedures : IEFITIContextProcedures
    {
        private readonly EFITIContext _context;

        public EFITIContextProcedures(EFITIContext context)
        {
            _context = context;
        }
    }
}
