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

using MySql.Data;
namespace MySql.Protocol
{
  internal abstract class ProtocolBase
  {
    public ProtocolBase(MySqlConnectionStringBuilder settings)
    {

    }

    #region Actions

    public abstract void OpenConnection();

    public abstract void CloseConnection();

    public abstract void ExecutePrepareStatement();

    public abstract void ExecuteReader();

    public abstract int ExecuteStatement();

    public abstract void Find();

    public abstract void Insert();

    public abstract void Update();

    public abstract void Delete();

    public abstract void Reset();

    public abstract void ExecuteBatch();

    #endregion


    #region InternalMethods



    #endregion
  }
}
