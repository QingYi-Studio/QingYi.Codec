namespace Codec.Chars
{
    /// <summary>
    /// Base32 chars.
    /// </summary>
    public class Base32Chars
    {
        /// <summary>
        /// RFC 4648 Base32 alphabet.
        /// </summary>
        public static readonly char[] RFC4648 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".ToCharArray();

        /// <summary>
        /// Extended Hex Base32 alphabet, used for encoding hexadecimal values.
        /// </summary>
        public static readonly char[] ExtendedHex = "0123456789ABCDEFGHIJKLMNOPQRSTUV".ToCharArray();

        /// <summary>
        /// ZBase32 alphabet, used in ZBase32 encoding scheme.
        /// </summary>
        public static readonly char[] ZBase32 = "ybndrfg8ejkmcpqxot1uwisza345h768".ToCharArray();

        /// <summary>
        /// Crockford Base32 alphabet, designed to avoid visually ambiguous characters.
        /// </summary>
        public static readonly char[] Crockford = "0123456789abcdefghjkmnpqrstvwxyz".ToCharArray();

        /// <summary>
        /// Electrologica Base32 alphabet, used in Electrologica encoding scheme.
        /// </summary>
        public static readonly char[] Electrologica = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".ToCharArray();

        /// <summary>
        /// GeoHash Base32 alphabet, used in GeoHash encoding for geographical coordinates.
        /// </summary>
        public static readonly char[] GeoHash = "0123456789bcdefghjkmnpqrstuvwxyz".ToCharArray();

        /// <summary>
        /// Word-safe Base32 alphabet, designed to avoid ambiguous characters and be easy to read.
        /// </summary>
        public static readonly char[] WordSafe = "abcdefghijklmnopqrstuvwxyz234567".ToCharArray();
    }
}
