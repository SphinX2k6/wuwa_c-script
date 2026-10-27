using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F1 RID: 10737
	[UnrealObjectPath("/Script/UMG.VerticalBoxSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UVerticalBoxSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D1B RID: 163099 RVA: 0x003CACE4 File Offset: 0x003C8EE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVerticalBoxSlot._ClassPtr;
		}

		// Token: 0x06027D1C RID: 163100 RVA: 0x003CACF0 File Offset: 0x003C8EF0
		public UVerticalBoxSlot() : this(BuiltinUtils.AllocNativeUObject(UVerticalBoxSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D1D RID: 163101 RVA: 0x003CAD18 File Offset: 0x003C8F18
		[NullableContext(1)]
		public UVerticalBoxSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVerticalBoxSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700985E RID: 39006
		// (get) Token: 0x06027D1E RID: 163102 RVA: 0x003CAD4C File Offset: 0x003C8F4C
		// (set) Token: 0x06027D1F RID: 163103 RVA: 0x003CAD85 File Offset: 0x003C8F85
		[Nullable(1)]
		public FSlateChildSize Size
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSlateChildSize result;
				if ((result = this._Size) == null)
				{
					result = (this._Size = new FSlateChildSize(base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_Size, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateChildSize.StaticStruct(), base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_Size, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700985F RID: 39007
		// (get) Token: 0x06027D20 RID: 163104 RVA: 0x003CADA6 File Offset: 0x003C8FA6
		// (set) Token: 0x06027D21 RID: 163105 RVA: 0x003CADBA File Offset: 0x003C8FBA
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17009860 RID: 39008
		// (get) Token: 0x06027D22 RID: 163106 RVA: 0x003CADCF File Offset: 0x003C8FCF
		// (set) Token: 0x06027D23 RID: 163107 RVA: 0x003CADE3 File Offset: 0x003C8FE3
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x17009861 RID: 39009
		// (get) Token: 0x06027D24 RID: 163108 RVA: 0x003CADF8 File Offset: 0x003C8FF8
		// (set) Token: 0x06027D25 RID: 163109 RVA: 0x003CAE0C File Offset: 0x003C900C
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVerticalBoxSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06027D26 RID: 163110 RVA: 0x003CAE21 File Offset: 0x003C9021
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UVerticalBoxSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027D27 RID: 163111 RVA: 0x003CAE34 File Offset: 0x003C9034
		[NullableContext(2)]
		public void SetSize(FSlateChildSize InSize)
		{
			UVerticalBoxSlot.__SetSize_Internal(base.NativePtr, (InSize ?? new FSlateChildSize()).NativePtr);
		}

		// Token: 0x06027D28 RID: 163112 RVA: 0x003CAE50 File Offset: 0x003C9050
		public void SetPadding(FMargin InPadding)
		{
			UVerticalBoxSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027D29 RID: 163113 RVA: 0x003CAE5E File Offset: 0x003C905E
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UVerticalBoxSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027D2A RID: 163114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027D2B RID: 163115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, IntPtr InSize);

		// Token: 0x06027D2C RID: 163116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06027D2D RID: 163117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06027D2E RID: 163118 RVA: 0x003CAE71 File Offset: 0x003C9071
		static UVerticalBoxSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.VerticalBoxSlot");
		}

		// Token: 0x06027D2F RID: 163119 RVA: 0x003CAE7F File Offset: 0x003C907F
		protected UVerticalBoxSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C68 RID: 89192
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.VerticalBoxSlot";

		// Token: 0x04015C69 RID: 89193
		private static IntPtr _ClassPtr;

		// Token: 0x04015C6A RID: 89194
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C6B RID: 89195
		internal static int __PropertyOffset_Size;

		// Token: 0x04015C6C RID: 89196
		[Nullable(2)]
		private FSlateChildSize _Size;

		// Token: 0x04015C6D RID: 89197
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015C6E RID: 89198
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015C6F RID: 89199
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
