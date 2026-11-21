using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003B RID: 59
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealBlueprintInterfaceArrayProcessor<T> : NativeArrayProcessorBase<T> where T : class, IUnrealBlueprintInterface
	{
		// Token: 0x06000869 RID: 2153 RVA: 0x0000D405 File Offset: 0x0000B605
		public UnrealBlueprintInterfaceArrayProcessor()
		{
			this.Size = sizeof(FScriptInterface);
			this.MinAlignment = typeof(FScriptInterface).GetCustomAttribute<UnrealStructLayoutAttribute>().Pack;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000D433 File Offset: 0x0000B633
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return (Data + (IntPtr)(Index * this.Size)).ToInterface<T>();
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000D445 File Offset: 0x0000B645
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			ref FScriptInterface ptr = Data + (IntPtr)(Index * this.Size);
			T t = Value;
			ptr = new FScriptInterface((t != null) ? t.NativePtr : IntPtr.Zero, IntPtr.Zero);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0000D478 File Offset: 0x0000B678
		[NullableContext(2)]
		public unsafe override int FindIndex(IntPtr Data, int Num, T Value)
		{
			T t = Value;
			FScriptInterface right = new FScriptInterface((t != null) ? t.NativePtr : IntPtr.Zero, IntPtr.Zero);
			for (int i = 0; i < Num; i++)
			{
				if (*(Data + (IntPtr)(i * this.Size)) == right)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0000D4CE File Offset: 0x0000B6CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0000D4E9 File Offset: 0x0000B6E9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}
	}
}
