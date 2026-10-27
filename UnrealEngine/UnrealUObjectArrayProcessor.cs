using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Helper;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200005C RID: 92
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealUObjectArrayProcessor<[Nullable(0)] T> : NativeArrayProcessorBase<T> where T : UnrealUObject
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x00010F6E File Offset: 0x0000F16E
		public UnrealUObjectArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = IntPtrHelper.Size;
			this.MinAlignment = IntPtrHelper.Size;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00010F93 File Offset: 0x0000F193
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override T Get(IntPtr Data, int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<T>(*(Data + (IntPtr)(Index * this.Size)));
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00010FA6 File Offset: 0x0000F1A6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			ref IntPtr ptr = Data + (IntPtr)(Index * this.Size);
			T t = Value;
			ptr = ((t != null) ? t._NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00010FCC File Offset: 0x0000F1CC
		public unsafe override int FindIndex(IntPtr Data, int Num, T Value)
		{
			T t = Value;
			IntPtr intPtr = (t != null) ? t.NativePtr : IntPtr.Zero;
			for (int i = 0; i < Num; i++)
			{
				if (*(Data + (IntPtr)(i * this.Size)) == intPtr)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001100E File Offset: 0x0000F20E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00011029 File Offset: 0x0000F229
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00011044 File Offset: 0x0000F244
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
