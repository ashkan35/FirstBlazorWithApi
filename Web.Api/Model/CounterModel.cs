namespace Web.Api.Model
{
    public class CounterModel
    {
        public Counter Data { get; set; }
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }

    public class Counter
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

}
