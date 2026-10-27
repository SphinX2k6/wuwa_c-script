using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A0C RID: 10764
	[UnrealObjectPath("/Script/UMG.WrapBoxSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UWrapBoxSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602805E RID: 163934 RVA: 0x003CEC08 File Offset: 0x003CCE08
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWrapBoxSlot._ClassPtr;
		}

		// Token: 0x0602805F RID: 163935 RVA: 0x003CEC14 File Offset: 0x003CCE14
		public UWrapBoxSlot() : this(BuiltinUtils.AllocNativeUObject(UWrapBoxSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028060 RID: 163936 RVA: 0x003CEC3C File Offset: 0x003CCE3C
		[NullableContext(1)]
		public UWrapBoxSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWrapBoxSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098DF RID: 39135
		// (get) Token: 0x06028061 RID: 163937 RVA: 0x003CEC6F File Offset: 0x003CCE6F
		// (set) Token: 0x06028062 RID: 163938 RVA: 0x003CEC83 File Offset: 0x003CCE83
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170098E0 RID: 39136
		// (get) Token: 0x06028063 RID: 163939 RVA: 0x003CEC98 File Offset: 0x003CCE98
		// (set) Token: 0x06028064 RID: 163940 RVA: 0x003CECA8 File Offset: 0x003CCEA8
		public unsafe bool bFillEmptySpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_bFillEmptySpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_bFillEmptySpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098E1 RID: 39137
		// (get) Token: 0x06028065 RID: 163941 RVA: 0x003CECB9 File Offset: 0x003CCEB9
		// (set) Token: 0x06028066 RID: 163942 RVA: 0x003CECC9 File Offset: 0x003CCEC9
		public unsafe float FillSpanWhenLessThan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_FillSpanWhenLessThan);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_FillSpanWhenLessThan) = value;
			}
		}

		// Token: 0x170098E2 RID: 39138
		// (get) Token: 0x06028067 RID: 163943 RVA: 0x003CECDA File Offset: 0x003CCEDA
		// (set) Token: 0x06028068 RID: 163944 RVA: 0x003CECEE File Offset: 0x003CCEEE
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170098E3 RID: 39139
		// (get) Token: 0x06028069 RID: 163945 RVA: 0x003CED03 File Offset: 0x003CCF03
		// (set) Token: 0x0602806A RID: 163946 RVA: 0x003CED17 File Offset: 0x003CCF17
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBoxSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x0602806B RID: 163947 RVA: 0x003CED2C File Offset: 0x003CCF2C
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UWrapBoxSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x0602806C RID: 163948 RVA: 0x003CED3F File Offset: 0x003CCF3F
		public void SetPadding(FMargin InPadding)
		{
			UWrapBoxSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x0602806D RID: 163949 RVA: 0x003CED4D File Offset: 0x003CCF4D
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UWrapBoxSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x0602806E RID: 163950 RVA: 0x003CED60 File Offset: 0x003CCF60
		public void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan)
		{
			UWrapBoxSlot.__SetFillSpanWhenLessThan_Internal(base.NativePtr, InFillSpanWhenLessThan);
		}

		// Token: 0x0602806F RID: 163951 RVA: 0x003CED6E File Offset: 0x003CCF6E
		public void SetFillEmptySpace(bool InbFillEmptySpace)
		{
			UWrapBoxSlot.__SetFillEmptySpace_Internal(base.NativePtr, InbFillEmptySpace);
		}

		// Token: 0x06028070 RID: 163952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06028071 RID: 163953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06028072 RID: 163954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06028073 RID: 163955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillSpanWhenLessThan_Internal(IntPtr @this, float InFillSpanWhenLessThan);

		// Token: 0x06028074 RID: 163956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillEmptySpace_Internal(IntPtr @this, bool InbFillEmptySpace);

		// Token: 0x06028075 RID: 163957 RVA: 0x003CED7C File Offset: 0x003CCF7C
		static UWrapBoxSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WrapBoxSlot");
		}

		// Token: 0x06028076 RID: 163958 RVA: 0x003CED8A File Offset: 0x003CCF8A
		protected UWrapBoxSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D6C RID: 89452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WrapBoxSlot";

		// Token: 0x04015D6D RID: 89453
		private static IntPtr _ClassPtr;

		// Token: 0x04015D6E RID: 89454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D6F RID: 89455
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015D70 RID: 89456
		internal static int __PropertyOffset_bFillEmptySpace;

		// Token: 0x04015D71 RID: 89457
		internal static int __PropertyOffset_FillSpanWhenLessThan;

		// Token: 0x04015D72 RID: 89458
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015D73 RID: 89459
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
