namespace MiniShop.Shared.ResponseDtos
{
    //burada factory design pattern kullandık.
    public class Response<T>
    {
        public T Data { get; set; }
        public string Error { get; set; }
        public int StatusCode { get; set; }
        public bool IsSucceeded { get; set; }
        /// <summary>
        /// Bu metod içinde veri barındıran başarılı bir cevap döndürmek için kullanırılır.
        /// </summary>
        /// <param name="data">Geri döndürülecek veri</param>
        /// <param name="statusCode">Http kodu</param>
        /// <returns>Response<typeparamref name="T"></returns>
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
        /// Bu metod içinde veri barındırmayan başarılı bir cevap döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">Http kodu</param>
        /// <returns>Response<typeparamref name="T"></returns>
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
        /// bu metod hata durumlarında döndürülecek cevap için kullanılır
        /// </summary>
        /// <param name="error">Hata mesajı</param>
        /// <param name="statusCode">Http kodu</param>
        /// <returns>Response<reaponsetyperef name="T"></returns>
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
