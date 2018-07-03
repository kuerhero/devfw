//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : OPS.Data
//  @ File Name : IDbDialect.cs
//  @ Date : 8/18/2011
//  @ Author : ????
//  @ Description : 
//       SQLite���ʺϵ���
//

using System;
using System.Collections.Generic;
using System.Data.Common;

namespace JR.DevFw.Data
{
    /// <summary>
    /// �м��
    /// </summary>
    /// <param name="action"></param>
    /// <param name="sql"></param>
    /// <param name="sqlParams"></param>
    /// <param name="exc"></param>
    /// <returns></returns>
    public delegate bool Middleware(String action, String sql, DbParameter[] sqlParams, Exception exc);

    /// <summary>
    /// Ӱ���е�SQL����
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public delegate int RowAffer(string sql);

    /// <summary>
    /// ���ݶ�ȡ������
    /// </summary>
    /// <param name="reader"></param>
    public delegate void DataReaderFunc(DbDataReader reader);

    /// <summary>
    /// ���ݿⷽ��
    /// </summary>
    public interface IDbDialect
    {
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>
        /// <returns></returns>
        string GetConnectionString();
        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <returns></returns>
        DbConnection GetConnection();

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        DbParameter CreateParameter(string name, object value);

        /// <summary>
        /// ת�������ֵ�Ϊ��������
        /// </summary>
        /// <param name="paramMap"></param>
        /// <returns></returns>
        DbParameter[] ParseParameters(IDictionary<String, Object> paramMap);

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="query">��ѯ���</param>
        /// <returns></returns>
        DbCommand CreateCommand(string query);

        /// <summary>
        /// ��������������
        /// </summary>
        /// <param name="conn">����</param>
        /// <param name="query">��ѯ���</param>
        /// <returns></returns>
        DbDataAdapter CreateDataAdapter(DbConnection conn, string query);

        /// <summary>
        /// ִ��SQL�ű�
        /// </summary>
        /// <param name="conn">����</param>
        /// <param name="r">������Ӱ�����</param>
        /// <param name="sql">SQL���</param>
        /// <param name="delimiter">�ָ��</param>
        /// <returns></returns>
        int ExecuteScript(DbConnection conn, RowAffer r, string sql, string delimiter);
    }
}