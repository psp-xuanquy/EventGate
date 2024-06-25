﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public class ServiceResult<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public int Status { get; set; }
        public string ErrorMessage { get; set; }

        public ServiceResult()
        {
            IsSuccess = false;
            Status = -1;
            ErrorMessage = "Action fail";
        }

        public ServiceResult(int status, string message)
        {
            IsSuccess = false;
            Status = status;
            ErrorMessage = message;
        }

        public ServiceResult(int status, string message, T data)
        {
            IsSuccess = true;
            Status = status;
            ErrorMessage = message;
            Data = data;
        }
    }
}
