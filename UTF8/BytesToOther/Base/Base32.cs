using Codec.Chars;
using System;
using System.Text;

namespace Codec.UTF8.BytesToOther.Base
{
    /// <summary>
    /// Byte array to Base32.
    /// </summary>
    public class BytesToBase32
    {
        /// <summary>
        /// Converts a byte array to a Base32 encoded string using the RFC 4648 alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string Recommended(byte[] bytes)
        {
            return RFC4648(bytes);
        }

        /// <summary>
        /// Converts a byte array to a Base32 encoded string using the RFC 4648 alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string RFC4648(byte[] bytes)
        {
            if (bytes != null)
            {
                StringBuilder result = new StringBuilder((bytes.Length * 8 + 4) / 5);
                int buffer = 0;
                int bitsLeft = 0;

                foreach (byte b in bytes)
                {
                    buffer = buffer << 8 | b;
                    bitsLeft += 8;

                    while (bitsLeft >= 5)
                    {
                        bitsLeft -= 5;
                        result.Append(Base32Chars.RFC4648[buffer >> bitsLeft & 0x1F]);
                    }
                }

                if (bitsLeft > 0)
                {
                    result.Append(Base32Chars.RFC4648[buffer << 5 - bitsLeft & 0x1F]);
                }

                // Add padding if necessary
                while (result.Length % 8 != 0)
                {
                    result.Append('=');
                }

                return result.ToString();
            }

            throw new ArgumentNullException(nameof(bytes));
        }

        /// <summary>
        /// Converts a byte array to a Base32 encoded string using the Extended Hex alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string ExtendedHex(byte[] bytes)
        {
            if (bytes != null)
            {
                StringBuilder result = new StringBuilder((bytes.Length * 8 + 4) / 5);
                int buffer = 0;
                int bitsLeft = 0;

                foreach (byte b in bytes)
                {
                    buffer = buffer << 8 | b;
                    bitsLeft += 8;

                    while (bitsLeft >= 5)
                    {
                        bitsLeft -= 5;
                        result.Append(Base32Chars.ExtendedHex[buffer >> bitsLeft & 0x1F]);
                    }
                }

                if (bitsLeft > 0)
                {
                    result.Append(Base32Chars.ExtendedHex[buffer << 5 - bitsLeft & 0x1F]);
                }

                // Add padding if necessary
                while (result.Length % 8 != 0)
                {
                    result.Append('=');
                }

                return result.ToString();
            }

            throw new ArgumentNullException(nameof(bytes));
        }

        /// <summary>
        /// Converts a byte array to a Base32 encoded string using the Z-Base-32 alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string ZBase32(byte[] bytes)
        {
            if (bytes != null)
            {
                StringBuilder result = new StringBuilder((bytes.Length * 8 + 4) / 5);
                int buffer = 0;
                int bitsLeft = 0;

                foreach (byte b in bytes)
                {
                    buffer = buffer << 8 | b;
                    bitsLeft += 8;

                    while (bitsLeft >= 5)
                    {
                        bitsLeft -= 5;
                        result.Append(Base32Chars.ZBase32[buffer >> bitsLeft & 0x1F]);
                    }
                }

                if (bitsLeft > 0)
                {
                    result.Append(Base32Chars.ZBase32[buffer << 5 - bitsLeft & 0x1F]);
                }

                // Add padding if necessary
                while (result.Length % 8 != 0)
                {
                    result.Append('=');
                }

                return result.ToString();
            }

            throw new ArgumentNullException(nameof(bytes));
        }

        /// <summary>
        /// Converts a byte array to a Base32 encoded string using Crockford's Base32 alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string Crockford(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            StringBuilder result = new StringBuilder((bytes.Length * 8 + 4) / 5);
            int buffer = 0;
            int bitsLeft = 0;

            foreach (byte b in bytes)
            {
                buffer = (buffer << 8) | b;
                bitsLeft += 8;

                while (bitsLeft >= 5)
                {
                    bitsLeft -= 5;
                    result.Append(Base32Chars.Crockford[(buffer >> bitsLeft) & 0x1F]);
                }
            }

            if (bitsLeft > 0)
            {
                result.Append(Base32Chars.Crockford[(buffer << (5 - bitsLeft)) & 0x1F]);
            }

            // Add padding if necessary
            while (result.Length % 8 != 0)
            {
                result.Append('=');
            }

            return result.ToString();
        }

        /// <summary>
        /// Converts a byte array to a Base32 encoded string using Electrologica Base32 alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string Electrologica(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            StringBuilder result = new StringBuilder((bytes.Length * 8 + 4) / 5);
            int buffer = 0;
            int bitsLeft = 0;

            foreach (byte b in bytes)
            {
                buffer = (buffer << 8) | b;
                bitsLeft += 8;

                while (bitsLeft >= 5)
                {
                    bitsLeft -= 5;
                    result.Append(Base32Chars.Electrologica[(buffer >> bitsLeft) & 0x1F]);
                }
            }

            if (bitsLeft > 0)
            {
                result.Append(Base32Chars.Electrologica[(buffer << (5 - bitsLeft)) & 0x1F]);
            }

            // Add padding if necessary
            while (result.Length % 8 != 0)
            {
                result.Append('=');
            }

            return result.ToString();
        }

        /// <summary>
        /// Converts a byte array to a Base32 encoded string using Geohash Base32 alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string GeoHash(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            StringBuilder result = new StringBuilder((bytes.Length * 8 + 4) / 5);
            int buffer = 0;
            int bitsLeft = 0;

            foreach (byte b in bytes)
            {
                buffer = (buffer << 8) | b;
                bitsLeft += 8;

                while (bitsLeft >= 5)
                {
                    bitsLeft -= 5;
                    result.Append(Base32Chars.GeoHash[(buffer >> bitsLeft) & 0x1F]);
                }
            }

            if (bitsLeft > 0)
            {
                result.Append(Base32Chars.GeoHash[(buffer << (5 - bitsLeft)) & 0x1F]);
            }

            // Add padding if necessary
            while (result.Length % 8 != 0)
            {
                result.Append('=');
            }

            return result.ToString();
        }

        /// <summary>
        /// Converts a byte array to a Base32 encoded string using Word-safe Base32 alphabet.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>A Base32 encoded string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input byte array is null.</exception>
        public static string WordSafe(byte[] bytes)
        {
            if (bytes == null)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            StringBuilder result = new StringBuilder((bytes.Length * 8 + 4) / 5);
            int buffer = 0;
            int bitsLeft = 0;

            foreach (byte b in bytes)
            {
                buffer = (buffer << 8) | b;
                bitsLeft += 8;

                while (bitsLeft >= 5)
                {
                    bitsLeft -= 5;
                    result.Append(Base32Chars.WordSafe[(buffer >> bitsLeft) & 0x1F]);
                }
            }

            if (bitsLeft > 0)
            {
                result.Append(Base32Chars.WordSafe[(buffer << (5 - bitsLeft)) & 0x1F]);
            }

            // Add padding if necessary
            while (result.Length % 8 != 0)
            {
                result.Append('=');
            }

            return result.ToString();
        }
    }
}
