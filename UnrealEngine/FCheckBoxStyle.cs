using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027EE RID: 10222
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.CheckBoxStyle")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1688)]
	public class FCheckBoxStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602618C RID: 156044 RVA: 0x0039C8D0 File Offset: 0x0039AAD0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCheckBoxStyle._ScriptStructPtr != 0) ? FCheckBoxStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.CheckBoxStyle", ref FCheckBoxStyle._ScriptStructPtr);
		}

		// Token: 0x1700930A RID: 37642
		// (get) Token: 0x0602618D RID: 156045 RVA: 0x0039C8F4 File Offset: 0x0039AAF4
		// (set) Token: 0x0602618E RID: 156046 RVA: 0x0039C908 File Offset: 0x0039AB08
		[Nullable(0)]
		public unsafe TEnumAsByte<ESlateCheckBoxType> CheckBoxType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckBoxType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckBoxType) = value;
			}
		}

		// Token: 0x1700930B RID: 37643
		// (get) Token: 0x0602618F RID: 156047 RVA: 0x0039C920 File Offset: 0x0039AB20
		// (set) Token: 0x06026190 RID: 156048 RVA: 0x0039C963 File Offset: 0x0039AB63
		public FSlateBrush UncheckedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UncheckedImage) == null)
				{
					result = (this._UncheckedImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700930C RID: 37644
		// (get) Token: 0x06026191 RID: 156049 RVA: 0x0039C984 File Offset: 0x0039AB84
		// (set) Token: 0x06026192 RID: 156050 RVA: 0x0039C9C7 File Offset: 0x0039ABC7
		public FSlateBrush UncheckedHoveredImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UncheckedHoveredImage) == null)
				{
					result = (this._UncheckedHoveredImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedHoveredImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedHoveredImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700930D RID: 37645
		// (get) Token: 0x06026193 RID: 156051 RVA: 0x0039C9E8 File Offset: 0x0039ABE8
		// (set) Token: 0x06026194 RID: 156052 RVA: 0x0039CA2B File Offset: 0x0039AC2B
		public FSlateBrush UncheckedPressedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UncheckedPressedImage) == null)
				{
					result = (this._UncheckedPressedImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedPressedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedPressedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700930E RID: 37646
		// (get) Token: 0x06026195 RID: 156053 RVA: 0x0039CA4C File Offset: 0x0039AC4C
		// (set) Token: 0x06026196 RID: 156054 RVA: 0x0039CA8F File Offset: 0x0039AC8F
		public FSlateBrush CheckedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._CheckedImage) == null)
				{
					result = (this._CheckedImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700930F RID: 37647
		// (get) Token: 0x06026197 RID: 156055 RVA: 0x0039CAB0 File Offset: 0x0039ACB0
		// (set) Token: 0x06026198 RID: 156056 RVA: 0x0039CAF3 File Offset: 0x0039ACF3
		public FSlateBrush CheckedHoveredImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._CheckedHoveredImage) == null)
				{
					result = (this._CheckedHoveredImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedHoveredImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedHoveredImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009310 RID: 37648
		// (get) Token: 0x06026199 RID: 156057 RVA: 0x0039CB14 File Offset: 0x0039AD14
		// (set) Token: 0x0602619A RID: 156058 RVA: 0x0039CB57 File Offset: 0x0039AD57
		public FSlateBrush CheckedPressedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._CheckedPressedImage) == null)
				{
					result = (this._CheckedPressedImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedPressedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedPressedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009311 RID: 37649
		// (get) Token: 0x0602619B RID: 156059 RVA: 0x0039CB78 File Offset: 0x0039AD78
		// (set) Token: 0x0602619C RID: 156060 RVA: 0x0039CBBB File Offset: 0x0039ADBB
		public FSlateBrush UndeterminedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UndeterminedImage) == null)
				{
					result = (this._UndeterminedImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UndeterminedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UndeterminedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009312 RID: 37650
		// (get) Token: 0x0602619D RID: 156061 RVA: 0x0039CBDC File Offset: 0x0039ADDC
		// (set) Token: 0x0602619E RID: 156062 RVA: 0x0039CC1F File Offset: 0x0039AE1F
		public FSlateBrush UndeterminedHoveredImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UndeterminedHoveredImage) == null)
				{
					result = (this._UndeterminedHoveredImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UndeterminedHoveredImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UndeterminedHoveredImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009313 RID: 37651
		// (get) Token: 0x0602619F RID: 156063 RVA: 0x0039CC40 File Offset: 0x0039AE40
		// (set) Token: 0x060261A0 RID: 156064 RVA: 0x0039CC83 File Offset: 0x0039AE83
		public FSlateBrush UndeterminedPressedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UndeterminedPressedImage) == null)
				{
					result = (this._UndeterminedPressedImage = new FSlateBrush(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UndeterminedPressedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UndeterminedPressedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009314 RID: 37652
		// (get) Token: 0x060261A1 RID: 156065 RVA: 0x0039CCA4 File Offset: 0x0039AEA4
		// (set) Token: 0x060261A2 RID: 156066 RVA: 0x0039CCB8 File Offset: 0x0039AEB8
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17009315 RID: 37653
		// (get) Token: 0x060261A3 RID: 156067 RVA: 0x0039CCD0 File Offset: 0x0039AED0
		// (set) Token: 0x060261A4 RID: 156068 RVA: 0x0039CD13 File Offset: 0x0039AF13
		public FSlateColor ForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ForegroundColor) == null)
				{
					result = (this._ForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_ForegroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009316 RID: 37654
		// (get) Token: 0x060261A5 RID: 156069 RVA: 0x0039CD34 File Offset: 0x0039AF34
		// (set) Token: 0x060261A6 RID: 156070 RVA: 0x0039CD77 File Offset: 0x0039AF77
		public FSlateColor BorderBackgroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._BorderBackgroundColor) == null)
				{
					result = (this._BorderBackgroundColor = new FSlateColor(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_BorderBackgroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_BorderBackgroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009317 RID: 37655
		// (get) Token: 0x060261A7 RID: 156071 RVA: 0x0039CD98 File Offset: 0x0039AF98
		// (set) Token: 0x060261A8 RID: 156072 RVA: 0x0039CDDB File Offset: 0x0039AFDB
		public FSlateSound CheckedSlateSound
		{
			get
			{
				base.FastCheckIsValid();
				FSlateSound result;
				if ((result = this._CheckedSlateSound) == null)
				{
					result = (this._CheckedSlateSound = new FSlateSound(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedSlateSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateSound.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_CheckedSlateSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009318 RID: 37656
		// (get) Token: 0x060261A9 RID: 156073 RVA: 0x0039CDFC File Offset: 0x0039AFFC
		// (set) Token: 0x060261AA RID: 156074 RVA: 0x0039CE3F File Offset: 0x0039B03F
		public FSlateSound UncheckedSlateSound
		{
			get
			{
				base.FastCheckIsValid();
				FSlateSound result;
				if ((result = this._UncheckedSlateSound) == null)
				{
					result = (this._UncheckedSlateSound = new FSlateSound(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedSlateSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateSound.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_UncheckedSlateSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009319 RID: 37657
		// (get) Token: 0x060261AB RID: 156075 RVA: 0x0039CE60 File Offset: 0x0039B060
		// (set) Token: 0x060261AC RID: 156076 RVA: 0x0039CEA3 File Offset: 0x0039B0A3
		public FSlateSound HoveredSlateSound
		{
			get
			{
				base.FastCheckIsValid();
				FSlateSound result;
				if ((result = this._HoveredSlateSound) == null)
				{
					result = (this._HoveredSlateSound = new FSlateSound(base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_HoveredSlateSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateSound.StaticStruct(), base.NativePtr + (IntPtr)FCheckBoxStyle.__PropertyOffset_HoveredSlateSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060261AD RID: 156077 RVA: 0x0039CEC4 File Offset: 0x0039B0C4
		public FCheckBoxStyle()
		{
		}

		// Token: 0x060261AE RID: 156078 RVA: 0x0039CECC File Offset: 0x0039B0CC
		public FCheckBoxStyle([Nullable(0)] TEnumAsByte<ESlateCheckBoxType> CheckBoxType, FSlateBrush UncheckedImage, FSlateBrush UncheckedHoveredImage, FSlateBrush UncheckedPressedImage, FSlateBrush CheckedImage, FSlateBrush CheckedHoveredImage, FSlateBrush CheckedPressedImage, FSlateBrush UndeterminedImage, FSlateBrush UndeterminedHoveredImage, FSlateBrush UndeterminedPressedImage, FMargin Padding, FSlateColor ForegroundColor, FSlateColor BorderBackgroundColor, FSlateSound CheckedSlateSound, FSlateSound UncheckedSlateSound, FSlateSound HoveredSlateSound, FName CheckedSound_DEPRECATED, FName UncheckedSound_DEPRECATED, FName HoveredSound_DEPRECATED)
		{
			this.CheckBoxType = CheckBoxType;
			this.UncheckedImage = UncheckedImage;
			this.UncheckedHoveredImage = UncheckedHoveredImage;
			this.UncheckedPressedImage = UncheckedPressedImage;
			this.CheckedImage = CheckedImage;
			this.CheckedHoveredImage = CheckedHoveredImage;
			this.CheckedPressedImage = CheckedPressedImage;
			this.UndeterminedImage = UndeterminedImage;
			this.UndeterminedHoveredImage = UndeterminedHoveredImage;
			this.UndeterminedPressedImage = UndeterminedPressedImage;
			this.Padding = Padding;
			this.ForegroundColor = ForegroundColor;
			this.BorderBackgroundColor = BorderBackgroundColor;
			this.CheckedSlateSound = CheckedSlateSound;
			this.UncheckedSlateSound = UncheckedSlateSound;
			this.HoveredSlateSound = HoveredSlateSound;
		}

		// Token: 0x060261AF RID: 156079 RVA: 0x0039CF5C File Offset: 0x0039B15C
		protected override IntPtr GetUStructPtr()
		{
			return FCheckBoxStyle.StaticStruct();
		}

		// Token: 0x060261B0 RID: 156080 RVA: 0x0039CF68 File Offset: 0x0039B168
		[NullableContext(2)]
		public FCheckBoxStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060261B1 RID: 156081 RVA: 0x0039CF72 File Offset: 0x0039B172
		public FCheckBoxStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060261B2 RID: 156082 RVA: 0x0039CF7D File Offset: 0x0039B17D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCheckBoxStyle(Pointer, false, true);
		}

		// Token: 0x060261B3 RID: 156083 RVA: 0x0039CF87 File Offset: 0x0039B187
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCheckBoxStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014CEA RID: 85226
		public new const string __ObjectPath = "/Script/SlateCore.CheckBoxStyle";

		// Token: 0x04014CEB RID: 85227
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CEC RID: 85228
		internal static int __PropertyOffset_CheckBoxType;

		// Token: 0x04014CED RID: 85229
		internal static int __PropertyOffset_UncheckedImage;

		// Token: 0x04014CEE RID: 85230
		[Nullable(2)]
		private FSlateBrush _UncheckedImage;

		// Token: 0x04014CEF RID: 85231
		internal static int __PropertyOffset_UncheckedHoveredImage;

		// Token: 0x04014CF0 RID: 85232
		[Nullable(2)]
		private FSlateBrush _UncheckedHoveredImage;

		// Token: 0x04014CF1 RID: 85233
		internal static int __PropertyOffset_UncheckedPressedImage;

		// Token: 0x04014CF2 RID: 85234
		[Nullable(2)]
		private FSlateBrush _UncheckedPressedImage;

		// Token: 0x04014CF3 RID: 85235
		internal static int __PropertyOffset_CheckedImage;

		// Token: 0x04014CF4 RID: 85236
		[Nullable(2)]
		private FSlateBrush _CheckedImage;

		// Token: 0x04014CF5 RID: 85237
		internal static int __PropertyOffset_CheckedHoveredImage;

		// Token: 0x04014CF6 RID: 85238
		[Nullable(2)]
		private FSlateBrush _CheckedHoveredImage;

		// Token: 0x04014CF7 RID: 85239
		internal static int __PropertyOffset_CheckedPressedImage;

		// Token: 0x04014CF8 RID: 85240
		[Nullable(2)]
		private FSlateBrush _CheckedPressedImage;

		// Token: 0x04014CF9 RID: 85241
		internal static int __PropertyOffset_UndeterminedImage;

		// Token: 0x04014CFA RID: 85242
		[Nullable(2)]
		private FSlateBrush _UndeterminedImage;

		// Token: 0x04014CFB RID: 85243
		internal static int __PropertyOffset_UndeterminedHoveredImage;

		// Token: 0x04014CFC RID: 85244
		[Nullable(2)]
		private FSlateBrush _UndeterminedHoveredImage;

		// Token: 0x04014CFD RID: 85245
		internal static int __PropertyOffset_UndeterminedPressedImage;

		// Token: 0x04014CFE RID: 85246
		[Nullable(2)]
		private FSlateBrush _UndeterminedPressedImage;

		// Token: 0x04014CFF RID: 85247
		internal static int __PropertyOffset_Padding;

		// Token: 0x04014D00 RID: 85248
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x04014D01 RID: 85249
		[Nullable(2)]
		private FSlateColor _ForegroundColor;

		// Token: 0x04014D02 RID: 85250
		internal static int __PropertyOffset_BorderBackgroundColor;

		// Token: 0x04014D03 RID: 85251
		[Nullable(2)]
		private FSlateColor _BorderBackgroundColor;

		// Token: 0x04014D04 RID: 85252
		internal static int __PropertyOffset_CheckedSlateSound;

		// Token: 0x04014D05 RID: 85253
		[Nullable(2)]
		private FSlateSound _CheckedSlateSound;

		// Token: 0x04014D06 RID: 85254
		internal static int __PropertyOffset_UncheckedSlateSound;

		// Token: 0x04014D07 RID: 85255
		[Nullable(2)]
		private FSlateSound _UncheckedSlateSound;

		// Token: 0x04014D08 RID: 85256
		internal static int __PropertyOffset_HoveredSlateSound;

		// Token: 0x04014D09 RID: 85257
		[Nullable(2)]
		private FSlateSound _HoveredSlateSound;
	}
}
