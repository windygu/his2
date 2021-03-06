﻿using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Demographic
	/// </summary>
	public partial class Demographic
	{
		public Demographic()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "Demographic"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Demographic");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Demographic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Demographic(");
			strSql.Append("PID,Gender,BirthDay,Age,Race,HomeTown,Phone1,Phone2,Address,Email)");
			strSql.Append(" values (");
			strSql.Append("@PID,@Gender,@BirthDay,@Age,@Race,@HomeTown,@Phone1,@Phone2,@Address,@Email)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@PID", OleDbType.Integer,4),
					new OleDbParameter("@Gender", OleDbType.VarChar,2),
					new OleDbParameter("@BirthDay", OleDbType.Date),
					new OleDbParameter("@Age", OleDbType.Integer,4),
					new OleDbParameter("@Race", OleDbType.VarChar,50),
					new OleDbParameter("@HomeTown", OleDbType.VarChar,50),
					new OleDbParameter("@Phone1", OleDbType.VarChar,50),
					new OleDbParameter("@Phone2", OleDbType.VarChar,50),
					new OleDbParameter("@Address", OleDbType.VarChar,50),
					new OleDbParameter("@Email", OleDbType.VarChar,50)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.Gender;
			parameters[2].Value = model.BirthDay;
			parameters[3].Value = model.Age;
			parameters[4].Value = model.Race;
			parameters[5].Value = model.HomeTown;
			parameters[6].Value = model.Phone1;
			parameters[7].Value = model.Phone2;
			parameters[8].Value = model.Address;
			parameters[9].Value = model.Email;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.Demographic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Demographic set ");
			strSql.Append("PID=@PID,");
			strSql.Append("Gender=@Gender,");
			strSql.Append("BirthDay=@BirthDay,");
			strSql.Append("Age=@Age,");
			strSql.Append("Race=@Race,");
			strSql.Append("HomeTown=@HomeTown,");
			strSql.Append("Phone1=@Phone1,");
			strSql.Append("Phone2=@Phone2,");
			strSql.Append("Address=@Address,");
			strSql.Append("Email=@Email");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@PID", OleDbType.Integer,4),
					new OleDbParameter("@Gender", OleDbType.VarChar,2),
					new OleDbParameter("@BirthDay", OleDbType.Date),
					new OleDbParameter("@Age", OleDbType.Integer,4),
					new OleDbParameter("@Race", OleDbType.VarChar,50),
					new OleDbParameter("@HomeTown", OleDbType.VarChar,50),
					new OleDbParameter("@Phone1", OleDbType.VarChar,50),
					new OleDbParameter("@Phone2", OleDbType.VarChar,50),
					new OleDbParameter("@Address", OleDbType.VarChar,50),
					new OleDbParameter("@Email", OleDbType.VarChar,50),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.Gender;
			parameters[2].Value = model.BirthDay;
			parameters[3].Value = model.Age;
			parameters[4].Value = model.Race;
			parameters[5].Value = model.HomeTown;
			parameters[6].Value = model.Phone1;
			parameters[7].Value = model.Phone2;
			parameters[8].Value = model.Address;
			parameters[9].Value = model.Email;
			parameters[10].Value = model.ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Demographic ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Demographic ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.Demographic GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,PID,Gender,BirthDay,Age,Race,HomeTown,Phone1,Phone2,Address,Email from Demographic ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.Demographic model=new Maticsoft.Model.Demographic();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Maticsoft.Model.Demographic DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Demographic model=new Maticsoft.Model.Demographic();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PID"]!=null && row["PID"].ToString()!="")
				{
					model.PID=int.Parse(row["PID"].ToString());
				}
				if(row["Gender"]!=null)
				{
					model.Gender=row["Gender"].ToString();
				}
				if(row["BirthDay"]!=null && row["BirthDay"].ToString()!="")
				{
					model.BirthDay=DateTime.Parse(row["BirthDay"].ToString());
				}
				if(row["Age"]!=null && row["Age"].ToString()!="")
				{
					model.Age=int.Parse(row["Age"].ToString());
				}
				if(row["Race"]!=null)
				{
					model.Race=row["Race"].ToString();
				}
				if(row["HomeTown"]!=null)
				{
					model.HomeTown=row["HomeTown"].ToString();
				}
				if(row["Phone1"]!=null)
				{
					model.Phone1=row["Phone1"].ToString();
				}
				if(row["Phone2"]!=null)
				{
					model.Phone2=row["Phone2"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,PID,Gender,BirthDay,Age,Race,HomeTown,Phone1,Phone2,Address,Email ");
			strSql.Append(" FROM Demographic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Demographic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Demographic T ");
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
			parameters[0].Value = "Demographic";
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
            strSql.Append(@"select p.ID AS 编号, p.IDCode AS ID编号,p.Name AS 姓名,
                                g.Gender AS 性别,g.BirthDay AS 出生日期,g.Age AS 年龄,g.Race AS 民族,g.HomeTown AS 籍贯,g.Phone1 AS 联系电话1,g.Phone2 AS 联系电话2,
                                g.Address AS 联系地址,g.Email AS 电子邮箱 ");
            strSql.Append(" FROM Demographic g, Patient p ");
            strSql.Append(" where  g.PID = p.ID  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append( strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }
    }
}

