using System.Runtime.InteropServices;

namespace LzhamWrapper
{
    public class LzhamInterop
    {
        private const string LzhamDll = "lzham-forgelightx64.dll";

        [DllImport(LzhamDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe int decompress_forgelight_data(byte* inBuf, uint compressedSize, byte* outBuf, uint uncompressedSize);

        public static unsafe InflateReturnCode DecompressForgelightData(byte[] inBuf, uint compressedSize, byte[] outBuf, uint uncompressedSize)
        {
            if (inBuf == null || outBuf == null)
            {
                return InflateReturnCode.LZHAM_Z_PARAM_ERROR;
            }

            if (compressedSize > 0 && uncompressedSize < 0)
            {
                return InflateReturnCode.LZHAM_Z_PARAM_ERROR;
            }

            fixed (byte* inBufP = inBuf, outBufP = outBuf)
            {
                return (InflateReturnCode)decompress_forgelight_data(inBufP, compressedSize, outBufP, uncompressedSize);
            }
        }
    }
}
