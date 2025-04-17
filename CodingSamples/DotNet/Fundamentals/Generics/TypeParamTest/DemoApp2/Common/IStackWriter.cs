namespace DemoApp.Common;

public interface IStackWriter<in E>
{
    void Push(E item);
}
