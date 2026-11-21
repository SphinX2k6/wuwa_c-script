using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Helper;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000053 RID: 83
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class UnrealObjectSetProcessor<[Nullable(0)] T> : NativeSetProcessor<T> where T : UnrealUObject
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr data, int index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<T>(data + (IntPtr)index);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0000E8FB File Offset: 0x0000CAFB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr data, int index, T value)
		{
			ref IntPtr ptr = data + (IntPtr)(index * IntPtrHelper.Size);
			T t = value;
			ptr = ((t != null) ? t._NativePtr : IntPtr.Zero);
		}
	}
}
