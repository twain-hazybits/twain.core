namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwPendingXFersImpl : TwPendingXFers<Structures.TwPendingXFersStruct>
    {
        public override ushort Count { get { return Structure.Count; } set { Structure.Count = value; } }
        public override uint EOJ { get { return Structure.EOJ; } set { Structure.EOJ = value; } }
    }
}
