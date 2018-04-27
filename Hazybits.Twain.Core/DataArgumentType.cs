namespace Hazybits.Twain.Core
{
    public enum DataArgumentType
    {
        Null = 0x0000,
        CustomBase = 0x8000,
        Capability = 0x0001,
        Event = 0x0002,
        Identity = 0x0003,
        Parent = 0x0004,
        PendingXFers = 0x0005,
        SetupMemXFer = 0x0006,
        SetupFileXFer = 0x0007,
        Status = 0x0008,
        UserInterface = 0x0009,
        XFerGroup = 0x000a,
        CustomDsData = 0x000c,
        DeviceEvent = 0x000d,
        FileSystem = 0x000e,
        PassThru = 0x000f,
        Callback = 0x0010,
        StatusUtf8 = 0x0011,

        /* Data Argument Types for the DG_IMAGE Data Group. */
        ImageInfo = 0x0101,
        ImageLayout = 0x0102,
        ImageMemXFer = 0x0103,
        ImageNativeXFer = 0x0104,
        ImageFileXFer = 0x0105,
        ImageMemFileXFer = 0x0402,
        CieColor = 0x0106,
        GrayResponse = 0x0107,
        RgbResponse = 0x0108,
        JpegCompression = 0x0109,
        Palette8 = 0x010a,
        ExtImageInfo = 0x010b,

        /* Data Argument Types for the DG_AUDIO Data Group. */
        AudioFileXFer = 0x0201,
        AudioInfo = 0x0202,
        AudioNativeXFer = 0x0203,

        IccProfile = 0x0401,
        EntryPoint = 0x0403
    }
}
