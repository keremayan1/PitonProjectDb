﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.MongoDb
{
    public interface IMongoDbConnectionSettings
    {
        string ConnectionStrings { get; }
        string DatabaseName { get; }

    }
}
