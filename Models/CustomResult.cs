using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoCqrs.Models
{
    public class CustomResult<T>
    {
        public CustomResult(T? data = default, bool success = true, string message = "")
        {
            Data = data;
            Success = success;
            Message = message;
        }

        public T? Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

    }
}