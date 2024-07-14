using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomicHabits.Common
{
    public class GenericResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public GenericResponse(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public static GenericResponse<T> SuccessResponse(T data, string message = "")
        {
            return new GenericResponse<T>(true, message, data);
        }

        public static GenericResponse<T> FailureResponse(string message)
        {
            return new GenericResponse<T>(false, message, default);
        }
    }
}