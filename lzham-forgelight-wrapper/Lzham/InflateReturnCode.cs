namespace LzhamWrapper
{
    public enum InflateReturnCode
    {
        LZHAM_Z_OK = 0,
        LZHAM_Z_STREAM_END = 1,
        LZHAM_Z_NEED_DICT = 2,
        LZHAM_Z_ERRNO = -1,
        LZHAM_Z_STREAM_ERROR = -2,
        LZHAM_Z_DATA_ERROR = -3,
        LZHAM_Z_MEM_ERROR = -4,
        LZHAM_Z_BUF_ERROR = -5,
        LZHAM_Z_VERSION_ERROR = -6,
        LZHAM_Z_PARAM_ERROR = -10000
    }
}
