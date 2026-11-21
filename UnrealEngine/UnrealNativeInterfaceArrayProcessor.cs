using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003A RID: 58
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealNativeInterfaceArrayProcessor<T> : NativeArrayProcessorBase<T> where T : class, IUnrealNativeInterface
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x0000D2BC File Offset: 0x0000B4BC
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

		// Token: 0x06000864 RID: 2148 RVA: 0x0000D31B File Offset: 0x0000B51B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return (Data + (IntPtr)(Index * this.Size)).ToInterface<T>();
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0000D32D File Offset: 0x0000B52D
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr Data, int Index, T Value)
		{
			*(Data + (IntPtr)(Index * this.Size)) = new FScriptInterface(Value, (Value != null) ? ((int)this.RefInterfaceOffsetMethod.Invoke(Value, null)) : 0);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0000D36C File Offset: 0x0000B56C
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

		// Token: 0x06000867 RID: 2151 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0000D3EA File Offset: 0x0000B5EA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}

		// Token: 0x0400011F RID: 287
		private readonly MethodInfo RefInterfaceOffsetMethod;
	}
}
