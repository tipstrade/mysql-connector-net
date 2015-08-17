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

using System;
using System.Collections.Generic;

namespace MySql.XDevAPI
{
  public class SelectStatement : Statement
  {
    private List<string> projection;

    private string where = null;


    public SelectStatement Select(params string[] columns)
    {
      projection = new List<string>(columns);
      return this;
    }

    public SelectStatement Where(string condition)
    {
      where = condition;
      return this;
    }

    public SelectStatement OrderBy(string p)
    {
      throw new NotImplementedException();
    }

    public SelectStatement Bind(params string[] parameters)
    {
      throw new NotImplementedException();
    }

    public ResultSet Execute()
    {
      throw new NotImplementedException();
    }

  }
}
