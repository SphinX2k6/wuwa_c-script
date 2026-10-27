using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027EF RID: 10223
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ComboBoxStyle")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1232)]
	public class FComboBoxStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060261B4 RID: 156084 RVA: 0x0039CF90 File Offset: 0x0039B190
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComboBoxStyle._ScriptStructPtr != 0) ? FComboBoxStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ComboBoxStyle", ref FComboBoxStyle._ScriptStructPtr);
		}

		// Token: 0x1700931A RID: 37658
		// (get) Token: 0x060261B5 RID: 156085 RVA: 0x0039CFB4 File Offset: 0x0039B1B4
		// (set) Token: 0x060261B6 RID: 156086 RVA: 0x0039CFF7 File Offset: 0x0039B1F7
		public FComboButtonStyle ComboButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FComboButtonStyle result;
				if ((result = this._ComboButtonStyle) == null)
				{
					result = (this._ComboButtonStyle = new FComboButtonStyle(base.NativePtr + (IntPtr)FComboBoxStyle.__PropertyOffset_ComboButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComboButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FComboBoxStyle.__PropertyOffset_ComboButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700931B RID: 37659
		// (get) Token: 0x060261B7 RID: 156087 RVA: 0x0039D018 File Offset: 0x0039B218
		// (set) Token: 0x060261B8 RID: 156088 RVA: 0x0039D05B File Offset: 0x0039B25B
		public FSlateSound PressedSlateSound
		{
			get
			{
				base.FastCheckIsValid();
				FSlateSound result;
				if ((result = this._PressedSlateSound) == null)
				{
					result = (this._PressedSlateSound = new FSlateSound(base.NativePtr + (IntPtr)FComboBoxStyle.__PropertyOffset_PressedSlateSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateSound.StaticStruct(), base.NativePtr + (IntPtr)FComboBoxStyle.__PropertyOffset_PressedSlateSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700931C RID: 37660
		// (get) Token: 0x060261B9 RID: 156089 RVA: 0x0039D07C File Offset: 0x0039B27C
		// (set) Token: 0x060261BA RID: 156090 RVA: 0x0039D0BF File Offset: 0x0039B2BF
		public FSlateSound SelectionChangeSlateSound
		{
			get
			{
				base.FastCheckIsValid();
				FSlateSound result;
				if ((result = this._SelectionChangeSlateSound) == null)
				{
					result = (this._SelectionChangeSlateSound = new FSlateSound(base.NativePtr + (IntPtr)FComboBoxStyle.__PropertyOffset_SelectionChangeSlateSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateSound.StaticStruct(), base.NativePtr + (IntPtr)FComboBoxStyle.__PropertyOffset_SelectionChangeSlateSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060261BB RID: 156091 RVA: 0x0039D0E0 File Offset: 0x0039B2E0
		public FComboBoxStyle()
		{
		}

		// Token: 0x060261BC RID: 156092 RVA: 0x0039D0E8 File Offset: 0x0039B2E8
		public FComboBoxStyle(FComboButtonStyle ComboButtonStyle, FSlateSound PressedSlateSound, FSlateSound SelectionChangeSlateSound, FName PressedSound_DEPRECATED, FName SelectionChangeSound_DEPRECATED)
		{
			this.ComboButtonStyle = ComboButtonStyle;
			this.PressedSlateSound = PressedSlateSound;
			this.SelectionChangeSlateSound = SelectionChangeSlateSound;
		}

		// Token: 0x060261BD RID: 156093 RVA: 0x0039D105 File Offset: 0x0039B305
		protected override IntPtr GetUStructPtr()
		{
			return FComboBoxStyle.StaticStruct();
		}

		// Token: 0x060261BE RID: 156094 RVA: 0x0039D111 File Offset: 0x0039B311
		[NullableContext(2)]
		public FComboBoxStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060261BF RID: 156095 RVA: 0x0039D11B File Offset: 0x0039B31B
		public FComboBoxStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060261C0 RID: 156096 RVA: 0x0039D126 File Offset: 0x0039B326
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComboBoxStyle(Pointer, false, true);
		}

		// Token: 0x060261C1 RID: 156097 RVA: 0x0039D130 File Offset: 0x0039B330
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComboBoxStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014D0A RID: 85258
		public new const string __ObjectPath = "/Script/SlateCore.ComboBoxStyle";

		// Token: 0x04014D0B RID: 85259
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D0C RID: 85260
		internal static int __PropertyOffset_ComboButtonStyle;

		// Token: 0x04014D0D RID: 85261
		[Nullable(2)]
		private FComboButtonStyle _ComboButtonStyle;

		// Token: 0x04014D0E RID: 85262
		internal static int __PropertyOffset_PressedSlateSound;

		// Token: 0x04014D0F RID: 85263
		[Nullable(2)]
		private FSlateSound _PressedSlateSound;

		// Token: 0x04014D10 RID: 85264
		internal static int __PropertyOffset_SelectionChangeSlateSound;

		// Token: 0x04014D11 RID: 85265
		[Nullable(2)]
		private FSlateSound _SelectionChangeSlateSound;
	}
}
