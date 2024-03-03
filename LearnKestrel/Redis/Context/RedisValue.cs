using System.Text;

namespace LearnKestrel.Redis.Context
{
    public class RedisValue
    {
        public RedisValue(ReadOnlyMemory<Byte> value)
        {
            Value = value;
        }

        public ReadOnlyMemory<Byte> Value { get; }

        /// <summary>
        /// 替换为字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Encoding.UTF8.GetString(this.Value.Span);
        }
    }
}
