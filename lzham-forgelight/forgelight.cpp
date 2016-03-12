#include <lzham.h>

extern "C"
{
    __declspec(dllexport) int decompress_forgelight_data(const unsigned char* inBuf, unsigned int compressedSize, unsigned char* outBuf, unsigned int uncompressedSize)
    {
        lzham_z_stream stream;
        int result;

        lzham_z_inflateInit2(&stream, 20);
        stream.avail_in = compressedSize;
        stream.avail_out = uncompressedSize;
        stream.next_in = inBuf;
        stream.next_out = outBuf;

        result = lzham_z_inflate(&stream, LZHAM_Z_FINISH);
        lzham_z_inflateEnd(&stream);

        return result;
    }
}