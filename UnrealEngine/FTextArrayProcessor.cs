using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000040 RID: 64
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class FTextArrayProcessor : NativeArrayProcessorBase<FText>
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x0000D6FC File Offset: 0x0000B8FC
		public FTextArrayProcessor()
		{
			this.RequireConstructAndDestruct = true;
			UnrealStructLayoutAttribute customAttribute = typeof(FText).GetCustomAttribute<UnrealStructLayoutAttribute>();
			this.Size = customAttribute.Size;
			this.MinAlignment = customAttribute.Pack;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0000D73E File Offset: 0x0000B93E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override FText Get(IntPtr Data, int Index)
		{
			return new FText(Data + (IntPtr)(Index * this.Size), false, true);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0000D752 File Offset: 0x0000B952
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override FText GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return new FText(Data + (IntPtr)(Index * this.Size), Caller);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0000D765 File Offset: 0x0000B965
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr Data, int Index, FText Value)
		{
			FText.NativeCopy((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (Value != null) ? Value._NativePtr : IntPtr.Zero, 1);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0000D788 File Offset: 0x0000B988
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, FText Value)
		{
			return FText.FindIndex(Data, Num, (Value != null) ? Value._NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0000D7A1 File Offset: 0x0000B9A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			FText.NativeConstruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			FText.NativeDestruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0000D7C7 File Offset: 0x0000B9C7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			FText.NativeCopy(Dest, Data, Num);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0000D7D1 File Offset: 0x0000B9D1
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref FText Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
