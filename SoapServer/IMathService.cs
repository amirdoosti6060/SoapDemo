using System.ServiceModel;

namespace SoapServer
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Subtract(int a, int b);

        [OperationContract]
        int Multiply(int a, int b);

        [OperationContract]
        int Devide(int a, int b);
    }
}
