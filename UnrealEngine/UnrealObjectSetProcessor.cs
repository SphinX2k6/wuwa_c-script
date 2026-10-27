using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Helper;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200006E RID: 110
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class UnrealObjectSetProcessor<[Nullable(0)] T> : NativeSetProcessor<T> where T : UnrealUObject
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x00013C48 File Offset: 0x00011E48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr data, int index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<T>(data + (IntPtr)index);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00013C53 File Offset: 0x00011E53
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr data, int index, T value)
		{
			ref IntPtr ptr = data + (IntPtr)(index * IntPtrHelper.Size);
			T t = value;
			ptr = ((t != null) ? t._NativePtr : IntPtr.Zero);
		}
	}
}
