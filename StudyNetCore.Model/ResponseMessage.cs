﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyNetCore.Model
{
    public class ResultCode
    {
        // 成功状态码
        public static int SUCCESS = 1;

        // -------------------失败状态码----------------------
        // 参数错误
        public static int PARAMS_IS_NULL = 10001;// 参数为空
        public static int PARAMS_NOT_COMPLETE = 10002; // 参数不全
        public static int PARAMS_TYPE_ERROR = 10003; // 参数类型错误
        public static int PARAMS_IS_INVALID = 10004; // 参数无效

        // 用户错误
        public static int USER_NOT_EXIST = 20001; // 用户不存在
        public static int USER_NOT_LOGGED_IN = 20002; // 用户未登陆
        public static int USER_ACCOUNT_ERROR = 20003; // 用户名或密码错误
        public static int USER_ACCOUNT_FORBIDDEN = 20004; // 用户账户已被禁用
        public static int USER_HAS_EXIST = 20005;// 用户已存在

        // 业务错误
        public static int BUSINESS_ERROR = 30001;// 系统业务出现问题

        // 数据错误
        public static int DATA_NOT_FOUND = 40001; // 数据未找到
        public static int DATA_IS_WRONG = 40002;// 数据有误
        public static int DATA_ALREADY_EXISTED = 40003;// 数据已存在

        // 系统错误
        public static int SYSTEM_INNER_ERROR = 50001; // 系统内部错误

        // 接口错误
        public static int INTERFACE_INNER_INVOKE_ERROR = 60001; // 系统内部接口调用异常
        public static int INTERFACE_OUTER_INVOKE_ERROR = 60002;// 系统外部接口调用异常
        public static int INTERFACE_FORBIDDEN = 60003;// 接口禁止访问
        public static int INTERFACE_ADDRESS_INVALID = 60004;// 接口地址无效
        public static int INTERFACE_REQUEST_TIMEOUT = 60005;// 接口请求超时
        public static int INTERFACE_EXCEED_LOAD = 60006;// 接口负载过高

        // 权限错误
        public static int PERMISSION_NO_ACCESS = 70001;// 没有访问权限
    }
    public class Result<T>
    {
        private int code;
        private string message;
        private T data;
        public Result(int code, string message, T data)
        {
            this.code = code;
            this.message = message;
            this.data = data;
        }
    }
}
