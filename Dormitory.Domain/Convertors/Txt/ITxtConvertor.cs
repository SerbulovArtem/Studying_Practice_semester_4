namespace Dormitory.Domain.Convertors.Txt
{
    internal interface ITxtConvertor<T>
    {
        T Convert(string line);

        string Convert(T value);
    }
}
