using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Helper;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000041 RID: 65
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealUObjectArrayProcessor<[Nullable(0)] T> : NativeArrayProcessorBase<T> where T : UnrealUObject
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x0000D7DA File Offset: 0x0000B9DA
		public UnrealUObjectArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = IntPtrHelper.Size;
			this.MinAlignment = IntPtrHelper.Size;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0000D7FF File Offset: 0x0000B9FF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override T Get(IntPtr Data, int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<T>(*(Data + (IntPtr)(Index * this.Size)));
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0000D812 File Offset: 0x0000BA12
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			ref IntPtr ptr = Data + (IntPtr)(Index * this.Size);
			T t = Value;
			ptr = ((t != null) ? t._NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0000D838 File Offset: 0x0000BA38
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

		// Token: 0x0600088A RID: 2186 RVA: 0x0000D87A File Offset: 0x0000BA7A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0000D895 File Offset: 0x0000BA95
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
