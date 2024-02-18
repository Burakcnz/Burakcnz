using MiniShop.Shared.Dtos;
using MiniShop.Shared.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

//Burada Factory Design Pattern kullandık.
namespace MiniShop.Shared.ResponseDtos
{
    public class Response<T>
    {
        public T Data { get; set; }


        public string Error { get; set; }

        public int ItemCount { get; set; }


        [JsonIgnore]
        public int StatusCode { get; set; }


        [JsonIgnore]
        public bool IsSucceeded { get; set; }


        /// <summary>
        /// Bu metot, içinde veri barındıran başarılı bir cevap döndürmek için kullanılır.
        /// </summary>
        /// <param name="data">Geri döndürülecek veri</param>
        /// <param name="statusCode">Http kodu</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T>
            {
                Data = data,
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }

        /// <summary>
        /// Bu metot, içinde veri ve item count barındıran başarılı bir cevap döndürmek için kullanılır.
        /// </summary>
        /// <param name="data">Geri döndürülecek veri</param>
        /// <param name="statusCode">Http kodu</param>
        /// <param name="itemCount">Item Count</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(T data, int statusCode, int itemCount)
        {
            return new Response<T>
            {
                Data = data,
                StatusCode = statusCode,
                IsSucceeded = true,
                ItemCount=itemCount
            };
        }

        /// <summary>
        /// Bu metot, içinde veri barındırmayan başarılı bir cevap döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">Http kodu</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(int statusCode)
        {
            return new Response<T>
            {
                Data = default(T),
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }

        /// <summary>
        /// Bu metot, hata durumlarında döndürülecek cevap için kullanılır.
        /// </summary>
        /// <param name="error">Hata mesajı</param>
        /// <param name="statusCode">Http kodu</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T>
            {
                Error = error,
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }
    }
}


