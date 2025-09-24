// For examples, see:
// https://thegraybook.vvvv.org/reference/extending/writing-nodes.html#examples

namespace IO.DriveInfo;

public static class ByteUtils
{
    public static double To(double value, ByteUnit kind) =>
        value / Math.Pow(1024, (int)kind);

    public static double From(double value, ByteUnit kind) =>
        value * Math.Pow(1024, (int)kind);
}