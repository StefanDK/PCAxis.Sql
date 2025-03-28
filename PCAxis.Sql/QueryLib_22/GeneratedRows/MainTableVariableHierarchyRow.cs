using System;
using System.Data;

using PCAxis.Sql.DbConfig;

//This code is generated. 

namespace PCAxis.Sql.QueryLib_22
{

    /// <summary>
    /// Holds the attributes for MainTableVariableHierarchy. (This entity is language independent.) 
    /// 
    /// The table links a grouping to a main table. 
    /// </summary>
    public class MainTableVariableHierarchyRow
    {
        private String mMainTable;
        /// <summary>
        /// Name of main table. \nSee further in the description of the table MainTable. 
        /// </summary>
        public String MainTable
        {
            get { return mMainTable; }
        }
        private String mVariable;
        /// <summary>
        /// Name of variable. \nSee further in the description of the table Variable. 
        /// </summary>
        public String Variable
        {
            get { return mVariable; }
        }
        private String mGrouping;
        /// <summary>
        /// Name of grouping. \nSee further in the description of the table Grouping. 
        /// </summary>
        public String Grouping
        {
            get { return mGrouping; }
        }
        private String mShowLevels;
        /// <summary>
        /// The number of open levels that will be shown at menu selection the first time the tree is displayed. Must be 0 if all levels shall be shown.
        /// </summary>
        public String ShowLevels
        {
            get { return mShowLevels; }
        }
        private String mAllLevelsStored;
        /// <summary>
        /// Shows if all levels shall be stored or not. Can be:\nY = Yes\nN = No
        /// </summary>
        public String AllLevelsStored
        {
            get { return mAllLevelsStored; }
        }

        public MainTableVariableHierarchyRow(DataRow myRow, SqlDbConfig_22 dbconf)
        {
            this.mMainTable = myRow[dbconf.MainTableVariableHierarchy.MainTableCol.Label()].ToString();
            this.mVariable = myRow[dbconf.MainTableVariableHierarchy.VariableCol.Label()].ToString();
            this.mGrouping = myRow[dbconf.MainTableVariableHierarchy.GroupingCol.Label()].ToString();
            this.mShowLevels = myRow[dbconf.MainTableVariableHierarchy.ShowLevelsCol.Label()].ToString();
            this.mAllLevelsStored = myRow[dbconf.MainTableVariableHierarchy.AllLevelsStoredCol.Label()].ToString();
        }
    }
}
