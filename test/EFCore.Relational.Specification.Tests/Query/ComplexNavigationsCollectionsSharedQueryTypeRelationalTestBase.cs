﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.Query
{
    public abstract class ComplexNavigationsCollectionsSharedQueryTypeRelationalTestBase<TFixture> : ComplexNavigationsCollectionsSharedTypeQueryTestBase<TFixture>
        where TFixture : ComplexNavigationsSharedTypeQueryRelationalFixtureBase, new()
    {
        protected ComplexNavigationsCollectionsSharedQueryTypeRelationalTestBase(TFixture fixture)
            : base(fixture)
        {
        }
    }
}
