using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000056 RID: 86
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealBlueprintInterfaceArrayProcessor<T> : NativeArrayProcessorBase<T> where T : class, IUnrealBlueprintInterface
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x00010B99 File Offset: 0x0000ED99
		public UnrealBlueprintInterfaceArrayProcessor()
		{
			this.Size = sizeof(FScriptInterface);
			this.MinAlignment = typeof(FScriptInterface).GetCustomAttribute<UnrealStructLayoutAttribute>().Pack;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00010BC7 File Offset: 0x0000EDC7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return (Data + (IntPtr)(Index * this.Size)).ToInterface<T>();
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00010BD9 File Offset: 0x0000EDD9
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			ref FScriptInterface ptr = Data + (IntPtr)(Index * this.Size);
			T t = Value;
			ptr = new FScriptInterface((t != null) ? t.NativePtr : IntPtr.Zero, IntPtr.Zero);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00010C0C File Offset: 0x0000EE0C
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

		// Token: 0x060008E8 RID: 2280 RVA: 0x00010C62 File Offset: 0x0000EE62
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00010C7D File Offset: 0x0000EE7D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}
	}
}
