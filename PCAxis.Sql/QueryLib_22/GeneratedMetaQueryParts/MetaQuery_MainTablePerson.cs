using System;
using System.Collections.Generic;
using System.Data;

using PCAxis.Sql.DbConfig;


//This code is generated. 

namespace PCAxis.Sql.QueryLib_22
{
    public partial class MetaQuery
    {
        public Dictionary<string, MainTablePersonRow> GetMainTablePersonRows(string aMainTable, string aRolePerson, bool emptyRowSetIsOK)
        {
            Dictionary<string, MainTablePersonRow> myOut = new Dictionary<string, MainTablePersonRow>();
            SqlDbConfig dbconf = DB;
            string sqlString = GetMainTablePerson_SQLString_NoWhere();
            //
            // WHERE MTP.MainTable = '<aMainTable>'
            //    AND MTP.RolePerson = '<aRolePerson>'
            //
            sqlString += " WHERE " + DB.MainTablePerson.MainTableCol.Is(aMainTable) +
                         " AND " + DB.MainTablePerson.RolePersonCol.Is(aRolePerson);

            DataSet ds = mSqlCommand.ExecuteSelect(sqlString);
            DataRowCollection myRows = ds.Tables[0].Rows;

            if (myRows.Count < 1 && !emptyRowSetIsOK)
            {
                throw new PCAxis.Sql.Exceptions.DbException(35, " MainTable = " + aMainTable + " RolePerson = " + aRolePerson);
            }

            foreach (DataRow sqlRow in myRows)
            {
                MainTablePersonRow outRow = new MainTablePersonRow(sqlRow, DB);
                myOut.Add(outRow.PersonCode, outRow);
            }
            return myOut;
        }

        private String GetMainTablePerson_SQLString_NoWhere()
        {
            //SqlDbConfig dbconf = DB;   
            string sqlString = "SELECT ";


            sqlString +=
                DB.MainTablePerson.MainTableCol.ForSelect() + ", " +
                DB.MainTablePerson.PersonCodeCol.ForSelect() + ", " +
                DB.MainTablePerson.RolePersonCol.ForSelect();

            sqlString += " /" + "*** SQLID: GetMainTablePersonRows_01 ***" + "/ ";
            sqlString += " FROM " + DB.MainTablePerson.GetNameAndAlias();
            return sqlString;
        }
    }
}
