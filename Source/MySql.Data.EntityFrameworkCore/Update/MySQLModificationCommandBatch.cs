﻿// Copyright © 2015, Oracle and/or its affiliates. All rights reserved.
//
// MySQL Connector/NET is licensed under the terms of the GPLv2
// <http://www.gnu.org/licenses/old-licenses/gpl-2.0.html>, like most 
// MySQL Connectors. There are special exceptions to the terms and 
// conditions of the GPLv2 as it is applied to this software, see the 
// FLOSS License Exception
// <http://www.mysql.com/about/legal/licensing/foss-exception.html>.
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation; version 2 of the License.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
// for more details.
//
// You should have received a copy of the GNU General Public License along 
// with this program; if not, write to the Free Software Foundation, Inc., 
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using Microsoft.EntityFrameworkCore.Update;
using Microsoft.EntityFrameworkCore.Storage;

namespace MySQL.Data.EntityFrameworkCore.Update
{
  public class MySQLModificationCommandBatch : AffectedCountModificationCommandBatch
  {
    public MySQLModificationCommandBatch(
            [NotNull] IRelationalCommandBuilderFactory commandBuilderFactory,
            [NotNull] ISqlGenerationHelper sqlGenerator,
            [NotNull] MySQLUpdateSqlGenerator updateSqlGenerator,
            [NotNull] IRelationalValueBufferFactoryFactory valueBufferFactoryFactory,
            [CanBeNull] int? maxBatchSize)
        : base(commandBuilderFactory, sqlGenerator, updateSqlGenerator, valueBufferFactoryFactory)
    {
    }

    protected override bool CanAddCommand(ModificationCommand modificationCommand)
    {
      // TODO: check this
      return true;
    }

    protected override string GetCommandText()
    {
      return base.GetCommandText();
    }

    protected override bool IsCommandTextValid()
    {
      string s = GetCommandText();
      return true;
    }
  }
}
