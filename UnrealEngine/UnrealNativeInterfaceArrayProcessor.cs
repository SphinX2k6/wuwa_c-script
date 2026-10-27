using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000055 RID: 85
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealNativeInterfaceArrayProcessor<T> : NativeArrayProcessorBase<T> where T : class, IUnrealNativeInterface
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00010A50 File Offset: 0x0000EC50
		public UnrealNativeInterfaceArrayProcessor()
		{
			MethodInfo method = typeof(T).GetMethod("InterfaceOffset", BindingFlags.Instance | BindingFlags.Public);
			if (method == null)
			{
				throw new InvalidOperationException();
			}
			this.RefInterfaceOffsetMethod = method;
			base..ctor();
			this.Size = sizeof(FScriptInterface);
			this.MinAlignment = typeof(FScriptInterface).GetCustomAttribute<UnrealStructLayoutAttribute>().Pack;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00010AAF File Offset: 0x0000ECAF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return (Data + (IntPtr)(Index * this.Size)).ToInterface<T>();
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00010AC1 File Offset: 0x0000ECC1
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr Data, int Index, T Value)
		{
			*(Data + (IntPtr)(Index * this.Size)) = new FScriptInterface(Value, (Value != null) ? ((int)this.RefInterfaceOffsetMethod.Invoke(Value, null)) : 0);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00010B00 File Offset: 0x0000ED00
		[NullableContext(2)]
		public unsafe override int FindIndex(IntPtr Data, int Num, T Value)
		{
			FScriptInterface right = new FScriptInterface(Value, (Value != null) ? ((int)this.RefInterfaceOffsetMethod.Invoke(Value, null)) : 0);
			for (int i = 0; i < Num; i++)
			{
				if (*(Data + (IntPtr)(i * this.Size)) == right)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00010B63 File Offset: 0x0000ED63
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00010B7E File Offset: 0x0000ED7E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}

		// Token: 0x04000166 RID: 358
		private readonly MethodInfo RefInterfaceOffsetMethod;
	}
}
