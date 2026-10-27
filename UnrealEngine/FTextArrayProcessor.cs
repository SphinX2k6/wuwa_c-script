using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200005B RID: 91
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class FTextArrayProcessor : NativeArrayProcessorBase<FText>
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x00010E90 File Offset: 0x0000F090
		public FTextArrayProcessor()
		{
			this.RequireConstructAndDestruct = true;
			UnrealStructLayoutAttribute customAttribute = typeof(FText).GetCustomAttribute<UnrealStructLayoutAttribute>();
			this.Size = customAttribute.Size;
			this.MinAlignment = customAttribute.Pack;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00010ED2 File Offset: 0x0000F0D2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override FText Get(IntPtr Data, int Index)
		{
			return new FText(Data + (IntPtr)(Index * this.Size), false, true);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00010EE6 File Offset: 0x0000F0E6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override FText GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return new FText(Data + (IntPtr)(Index * this.Size), Caller);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00010EF9 File Offset: 0x0000F0F9
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr Data, int Index, FText Value)
		{
			FText.NativeCopy((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (Value != null) ? Value._NativePtr : IntPtr.Zero, 1);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00010F1C File Offset: 0x0000F11C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, FText Value)
		{
			return FText.FindIndex(Data, Num, (Value != null) ? Value._NativePtr : IntPtr.Zero);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00010F35 File Offset: 0x0000F135
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			FText.NativeConstruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00010F48 File Offset: 0x0000F148
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void DestructValues(IntPtr Data, int Index, int Count)
		{
			FText.NativeDestruct(Data + (IntPtr)(Index * this.Size), Count);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00010F5B File Offset: 0x0000F15B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			FText.NativeCopy(Dest, Data, Num);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00010F65 File Offset: 0x0000F165
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref FText Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
