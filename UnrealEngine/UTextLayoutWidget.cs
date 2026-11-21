using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000871 RID: 2161
	[UnrealObjectPath("/Script/UMG.TextLayoutWidget")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public abstract class UTextLayoutWidget : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BB98 RID: 48024 RVA: 0x0012C5EB File Offset: 0x0012A7EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextLayoutWidget._ClassPtr;
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x0600BB99 RID: 48025 RVA: 0x0012C5F7 File Offset: 0x0012A7F7
		// (set) Token: 0x0600BB9A RID: 48026 RVA: 0x0012C610 File Offset: 0x0012A810
		public unsafe bool AutoWrapText
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_AutoWrapText) & UTextLayoutWidget.__PropertyMask_AutoWrapText) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_AutoWrapText) = ((*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_AutoWrapText) & ~UTextLayoutWidget.__PropertyMask_AutoWrapText) | (value ? UTextLayoutWidget.__PropertyMask_AutoWrapText : 0));
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x0600BB9B RID: 48027 RVA: 0x0012C640 File Offset: 0x0012A840
		// (set) Token: 0x0600BB9C RID: 48028 RVA: 0x0012C650 File Offset: 0x0012A850
		public unsafe float WrapTextAt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_WrapTextAt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_WrapTextAt) = value;
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x0600BB9D RID: 48029 RVA: 0x0012C661 File Offset: 0x0012A861
		// (set) Token: 0x0600BB9E RID: 48030 RVA: 0x0012C675 File Offset: 0x0012A875
		public unsafe FMargin Margin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_Margin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_Margin) = value;
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x0600BB9F RID: 48031 RVA: 0x0012C68A File Offset: 0x0012A88A
		// (set) Token: 0x0600BBA0 RID: 48032 RVA: 0x0012C69A File Offset: 0x0012A89A
		public unsafe float LineHeightPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_LineHeightPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_LineHeightPercentage) = value;
			}
		}

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x0012C6AB File Offset: 0x0012A8AB
		static UTextLayoutWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.TextLayoutWidget");
		}

		// Token: 0x0600BBA2 RID: 48034 RVA: 0x0012C6BC File Offset: 0x0012A8BC
		protected UTextLayoutWidget() : this(BuiltinUtils.AllocNativeUObject(UTextLayoutWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BBA3 RID: 48035 RVA: 0x0012C6E4 File Offset: 0x0012A8E4
		protected UTextLayoutWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054F2 RID: 21746
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.TextLayoutWidget";

		// Token: 0x040054F3 RID: 21747
		private static IntPtr _ClassPtr;

		// Token: 0x040054F4 RID: 21748
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054F5 RID: 21749
		internal static int __PropertyOffset_AutoWrapText;

		// Token: 0x040054F6 RID: 21750
		internal static byte __PropertyMask_AutoWrapText;

		// Token: 0x040054F7 RID: 21751
		internal static int __PropertyOffset_WrapTextAt;

		// Token: 0x040054F8 RID: 21752
		internal static int __PropertyOffset_Margin;

		// Token: 0x040054F9 RID: 21753
		internal static int __PropertyOffset_LineHeightPercentage;
	}
}
