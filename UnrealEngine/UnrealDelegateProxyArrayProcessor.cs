using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200005E RID: 94
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealDelegateProxyArrayProcessor<[Nullable(0)] T> : NativeArrayProcessorBase<T> where T : FScriptDelegate, IUnrealDelegateProxy, new()
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x000111E1 File Offset: 0x0000F3E1
		public UnrealDelegateProxyArrayProcessor(int InElementSize, int InMinAlignment)
		{
			this.Size = InElementSize;
			this.MinAlignment = InMinAlignment;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000111F8 File Offset: 0x0000F3F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			IntPtr intPtr = Data + (IntPtr)(Index * this.Size);
			return Activator.CreateInstance(typeof(T), new object[]
			{
				intPtr,
				false,
				true
			}) as T;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001124B File Offset: 0x0000F44B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00011252 File Offset: 0x0000F452
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00011259 File Offset: 0x0000F459
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, T Value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00011260 File Offset: 0x0000F460
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00011267 File Offset: 0x0000F467
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001126E File Offset: 0x0000F46E
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00011275 File Offset: 0x0000F475
		[NullableContext(0)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
