﻿using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:GeneralInfo
    /// </summary>
    public partial class GeneralInfo
    {
        public GeneralInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperOleDb.GetMaxID("ID", "GeneralInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from GeneralInfo");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.GeneralInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into GeneralInfo(");
            strSql.Append("PID,Height,Weight,Waist,BMI,SmokeYear,SmokePerDay,SmokeIndex,QuitSmoke,QuitYear)");
            strSql.Append(" values (");
            strSql.Append("@PID,@Height,@Weight,@Waist,@BMI,@SmokeYear,@SmokePerDay,@SmokeIndex,@QuitSmoke,@QuitYear)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@PID", OleDbType.Integer,4),
					new OleDbParameter("@Height", OleDbType.Decimal),
					new OleDbParameter("@Weight", OleDbType.Decimal),
					new OleDbParameter("@Waist", OleDbType.Decimal),
					new OleDbParameter("@BMI", OleDbType.Decimal),
					new OleDbParameter("@SmokeYear", OleDbType.Decimal),
					new OleDbParameter("@SmokePerDay", OleDbType.Decimal),
					new OleDbParameter("@SmokeIndex", OleDbType.Decimal),
					new OleDbParameter("@QuitSmoke", OleDbType.Boolean,1),
					new OleDbParameter("@QuitYear", OleDbType.VarChar,50)};
            parameters[0].Value = model.PID;
            parameters[1].Value = model.Height;
            parameters[2].Value = model.Weight;
            parameters[3].Value = model.Waist;
            parameters[4].Value = model.BMI;
            parameters[5].Value = model.SmokeYear;
            parameters[6].Value = model.SmokePerDay;
            parameters[7].Value = model.SmokeIndex;
            parameters[8].Value = model.QuitSmoke;
            parameters[9].Value = model.QuitYear;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.GeneralInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update GeneralInfo set ");
            strSql.Append("PID=@PID,");
            strSql.Append("Height=@Height,");
            strSql.Append("Weight=@Weight,");
            strSql.Append("Waist=@Waist,");
            strSql.Append("BMI=@BMI,");
            strSql.Append("SmokeYear=@SmokeYear,");
            strSql.Append("SmokePerDay=@SmokePerDay,");
            strSql.Append("SmokeIndex=@SmokeIndex,");
            strSql.Append("QuitSmoke=@QuitSmoke,");
            strSql.Append("QuitYear=@QuitYear");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@PID", OleDbType.Integer,4),
					new OleDbParameter("@Height", OleDbType.Decimal),
					new OleDbParameter("@Weight", OleDbType.Decimal),
					new OleDbParameter("@Waist", OleDbType.Decimal),
					new OleDbParameter("@BMI", OleDbType.Decimal),
					new OleDbParameter("@SmokeYear", OleDbType.Decimal),
					new OleDbParameter("@SmokePerDay", OleDbType.Decimal),
					new OleDbParameter("@SmokeIndex", OleDbType.Decimal),
					new OleDbParameter("@QuitSmoke", OleDbType.Boolean,1),
					new OleDbParameter("@QuitYear", OleDbType.VarChar,50),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.PID;
            parameters[1].Value = model.Height;
            parameters[2].Value = model.Weight;
            parameters[3].Value = model.Waist;
            parameters[4].Value = model.BMI;
            parameters[5].Value = model.SmokeYear;
            parameters[6].Value = model.SmokePerDay;
            parameters[7].Value = model.SmokeIndex;
            parameters[8].Value = model.QuitSmoke;
            parameters[9].Value = model.QuitYear;
            parameters[10].Value = model.ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GeneralInfo ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GeneralInfo ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.GeneralInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,PID,Height,Weight,Waist,BMI,SmokeYear,SmokePerDay,SmokeIndex,QuitSmoke,QuitYear from GeneralInfo ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            Maticsoft.Model.GeneralInfo model = new Maticsoft.Model.GeneralInfo();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.GeneralInfo DataRowToModel(DataRow row)
        {
            Maticsoft.Model.GeneralInfo model = new Maticsoft.Model.GeneralInfo();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["PID"] != null && row["PID"].ToString() != "")
                {
                    model.PID = int.Parse(row["PID"].ToString());
                }
                if (row["Height"] != null && row["Height"].ToString() != "")
                {
                    model.Height = decimal.Parse(row["Height"].ToString());
                }
                if (row["Weight"] != null && row["Weight"].ToString() != "")
                {
                    model.Weight = decimal.Parse(row["Weight"].ToString());
                }
                if (row["Waist"] != null && row["Waist"].ToString() != "")
                {
                    model.Waist = decimal.Parse(row["Waist"].ToString());
                }
                if (row["BMI"] != null && row["BMI"].ToString() != "")
                {
                    model.BMI = decimal.Parse(row["BMI"].ToString());
                }
                if (row["SmokeYear"] != null && row["SmokeYear"].ToString() != "")
                {
                    model.SmokeYear = decimal.Parse(row["SmokeYear"].ToString());
                }
                if (row["SmokePerDay"] != null && row["SmokePerDay"].ToString() != "")
                {
                    model.SmokePerDay = decimal.Parse(row["SmokePerDay"].ToString());
                }
                if (row["SmokeIndex"] != null && row["SmokeIndex"].ToString() != "")
                {
                    model.SmokeIndex = decimal.Parse(row["SmokeIndex"].ToString());
                }
                if (row["QuitSmoke"] != null && row["QuitSmoke"].ToString() != "")
                {
                    if ((row["QuitSmoke"].ToString() == "1") || (row["QuitSmoke"].ToString().ToLower() == "true"))
                    {
                        model.QuitSmoke = true;
                    }
                    else
                    {
                        model.QuitSmoke = false;
                    }
                }
                if (row["QuitYear"] != null)
                {
                    model.QuitYear = row["QuitYear"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,PID,Height,Weight,Waist,BMI,SmokeYear,SmokePerDay,SmokeIndex,QuitSmoke,QuitYear ");
            strSql.Append(" FROM GeneralInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM GeneralInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from GeneralInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            OleDbParameter[] parameters = {
                    new OleDbParameter("@tblName", OleDbType.VarChar, 255),
                    new OleDbParameter("@fldName", OleDbType.VarChar, 255),
                    new OleDbParameter("@PageSize", OleDbType.Integer),
                    new OleDbParameter("@PageIndex", OleDbType.Integer),
                    new OleDbParameter("@IsReCount", OleDbType.Boolean),
                    new OleDbParameter("@OrderType", OleDbType.Boolean),
                    new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
                    };
            parameters[0].Value = "GeneralInfo";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod

        public DataSet GetListWithTitle(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select  p.ID AS 编号, p.IDCode AS ID编号,p.Name AS 姓名, 
                                g.Height AS 身高,
                                g.Weight AS 体重,
                                g.Waist AS 腰围,
                                g.BMI AS 体重指数,
                                g.SmokeYear AS 吸烟年,
                                g.SmokePerDay AS 平均支每日,
                                g.SmokeIndex AS 吸烟指数（支年）,
                                g.QuitSmoke AS 是否戒烟,
                                g.QuitYear AS  戒烟时间");
            strSql.Append(" FROM GeneralInfo g, Patient p ");
            strSql.Append(" where g.PID = p.ID  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(  strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }
    }
}
