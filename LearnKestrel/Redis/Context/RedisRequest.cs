namespace LearnKestrel.Redis.Context
{
    /// <summary>
    /// redis请求
    /// </summary>
    public class RedisRequest
    {


        private readonly List<RedisValue> values = new();

        public RedisRequest(List<RedisValue> values)
        {
            this.values = values;
        }

        // 请求参数 redisvalue类型
        // 参数的个数
        // 参数的类型？
        public int ArgumentCount => values.Count - 1;

        public string ArguMent { get; set; }

        public RedisValue Argument(int index)
        {
            return values[index+1];
        }

        public override string ToString()
        {
            return string.Join(" ", this.values);
        }
    }
}
