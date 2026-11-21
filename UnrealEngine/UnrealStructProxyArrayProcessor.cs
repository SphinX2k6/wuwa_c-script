using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000044 RID: 68
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealStructProxyArrayProcessor<T> : NativeArrayProcessorBase<T> where T : class, IUnrealStructProxy<T>
	{
		// Token: 0x060008A0 RID: 2208 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		public UnrealStructProxyArrayProcessor()
		{
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			this.RequireConstructAndDestruct = true;
			this.Size = IUnrealStructProxy<T>.Size;
			this.MinAlignment = IUnrealStructProxy<T>.MinAlignment;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0000DB4F File Offset: 0x0000BD4F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return IUnrealStructProxy<T>.Create(Data + (IntPtr)(Index * this.Size));
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0000DB67 File Offset: 0x0000BD67
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return IUnrealStructProxy<T>.Create(Data + (IntPtr)(Index * this.Size), Caller);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0000DB80 File Offset: 0x0000BD80
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			ArgumentNullException.ThrowIfNull(Value, "Value");
			IUnrealStructProxy<T>.NativeCopy(Data + (IntPtr)(Index * this.Size), Value.NativePtr, 1);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, T Value)
		{
			ArgumentNullException.ThrowIfNull(Value, "Value");
			return IUnrealStructProxy<T>.NativeFindIndex(Data, Num, Value.NativePtr);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0000DBDE File Offset: 0x0000BDDE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			IUnrealStructProxy<T>.NativeConstruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0000DBF7 File Offset: 0x0000BDF7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			IUnrealStructProxy<T>.NativeDestruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0000DC10 File Offset: 0x0000BE10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Src, IntPtr Dest, int Num)
		{
			IUnrealStructProxy<T>.NativeCopy(Dest, Src, Num);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value.NativePtr;
		}
	}
}
