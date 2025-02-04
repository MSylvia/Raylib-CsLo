//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.InteropServices;

namespace Raylib_CsLo
{
    public static unsafe partial class RRes
    {
        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern rresResourceChunk rresLoadResourceChunk([NativeTypeName("const char *")] sbyte* fileName, int rresId);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rresUnloadResourceChunk(rresResourceChunk chunk);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern rresResourceMulti rresLoadResourceMulti([NativeTypeName("const char *")] sbyte* fileName, int rresId);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rresUnloadResourceMulti(rresResourceMulti multi);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern rresResourceChunkInfo rresLoadResourceChunkInfo([NativeTypeName("const char *")] sbyte* fileName, int rresId);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern rresResourceChunkInfo* rresLoadResourceChunkInfoAll([NativeTypeName("const char *")] sbyte* fileName, [NativeTypeName("unsigned int *")] uint* chunkCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern rresCentralDir rresLoadCentralDirectory([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rresUnloadCentralDirectory(rresCentralDir dir);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint rresGetDataType([NativeTypeName("const unsigned char *")] byte* fourCC);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rresGetResourceId(rresCentralDir dir, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint rresComputeCRC32([NativeTypeName("unsigned char *")] byte* data, int len);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rresSetCipherPassword([NativeTypeName("const char *")] sbyte* pass);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* rresGetCipherPassword();

        [NativeTypeName("#define RRES_MAX_FILENAME_SIZE 1024")]
        public const int RRES_MAX_FILENAME_SIZE = 1024;
    }
}
