using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000043 RID: 67
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealDelegateProxyArrayProcessor<[Nullable(0)] T> : NativeArrayProcessorBase<T> where T : FScriptDelegate, IUnrealDelegateProxy, new()
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0000DA4D File Offset: 0x0000BC4D
		public UnrealDelegateProxyArrayProcessor(int InElementSize, int InMinAlignment)
		{
			this.Size = InElementSize;
			this.MinAlignment = InMinAlignment;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0000DA64 File Offset: 0x0000BC64
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

		// Token: 0x06000899 RID: 2201 RVA: 0x0000DAB7 File Offset: 0x0000BCB7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000DABE File Offset: 0x0000BCBE
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0000DAC5 File Offset: 0x0000BCC5
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, T Value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0000DACC File Offset: 0x0000BCCC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0000DAD3 File Offset: 0x0000BCD3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0000DADA File Offset: 0x0000BCDA
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0000DAE1 File Offset: 0x0000BCE1
		[NullableContext(0)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
