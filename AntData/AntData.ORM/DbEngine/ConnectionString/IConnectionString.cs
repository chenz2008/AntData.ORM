﻿using System;
using System.Configuration;
namespace AntData.ORM.DbEngine.ConnectionString
{
    public interface IConnectionString
    {
        /// <summary>
        /// 获取连接字符串的来源
        /// 一般大公司需要保护这个信息 可以根据需要自己来实现这个
        /// </summary>
        /// <param name="connectionStringName"></param>
        /// <returns></returns>
        ConnectionStringSettings GetConnectionString(String connectionStringName);
    }
}