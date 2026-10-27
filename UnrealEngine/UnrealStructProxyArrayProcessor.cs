using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200005F RID: 95
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealStructProxyArrayProcessor<T> : NativeArrayProcessorBase<T> where T : class, IUnrealStructProxy<T>
	{
		// Token: 0x0600091B RID: 2331 RVA: 0x00011288 File Offset: 0x0000F488
		public UnrealStructProxyArrayProcessor()
		{
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			this.RequireConstructAndDestruct = true;
			this.Size = IUnrealStructProxy<T>.Size;
			this.MinAlignment = IUnrealStructProxy<T>.MinAlignment;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000112E3 File Offset: 0x0000F4E3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return IUnrealStructProxy<T>.Create(Data + (IntPtr)(Index * this.Size));
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000112FB File Offset: 0x0000F4FB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return IUnrealStructProxy<T>.Create(Data + (IntPtr)(Index * this.Size), Caller);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00011314 File Offset: 0x0000F514
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			ArgumentNullException.ThrowIfNull(Value, "Value");
			IUnrealStructProxy<T>.NativeCopy(Data + (IntPtr)(Index * this.Size), Value.NativePtr, 1);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00011348 File Offset: 0x0000F548
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, T Value)
		{
			ArgumentNullException.ThrowIfNull(Value, "Value");
			return IUnrealStructProxy<T>.NativeFindIndex(Data, Num, Value.NativePtr);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00011372 File Offset: 0x0000F572
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			IUnrealStructProxy<T>.NativeConstruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0001138B File Offset: 0x0000F58B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			IUnrealStructProxy<T>.NativeDestruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000113A4 File Offset: 0x0000F5A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Src, IntPtr Dest, int Num)
		{
			IUnrealStructProxy<T>.NativeCopy(Dest, Src, Num);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000113B4 File Offset: 0x0000F5B4
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value.NativePtr;
		}
	}
}
