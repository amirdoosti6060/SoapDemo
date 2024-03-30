using System.Threading.Tasks;

namespace SoapServer
{
    public class MathService : IMathService
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => (a * b);

        public int Devide(int a, int b) => (a / b);
    }
}
