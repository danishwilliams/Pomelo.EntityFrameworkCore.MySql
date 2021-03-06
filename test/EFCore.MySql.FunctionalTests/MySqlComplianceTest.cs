﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Pomelo.EntityFrameworkCore.MySql.FunctionalTests
{
    public class MySqlComplianceTest : RelationalComplianceTestBase
    {
        protected override ICollection<Type> IgnoredTestBases { get; } = new HashSet<Type>
        {
            typeof(UdfDbFunctionTestBase<>),
            typeof(TransactionInterceptionTestBase),
            typeof(CommandInterceptionTestBase),
            typeof(MigrationsTestBase<>),
            typeof(QueryTaggingTestBase<>),
        };

        protected override Assembly TargetAssembly { get; } = typeof(MySqlComplianceTest).Assembly;
    }
}
