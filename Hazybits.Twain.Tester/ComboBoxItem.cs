namespace Hazybits.Twain.Tester
{
    public class ComboBoxItem<T>
    {
        public T Data;

        public ComboBoxItem(T data)
        {
            Data = data;
        }


        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
