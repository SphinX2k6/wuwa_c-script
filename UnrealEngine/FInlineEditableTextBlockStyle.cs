using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200281D RID: 10269
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.InlineEditableTextBlockStyle")]
	[UnrealStructLayout(3088, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3088)]
	public class FInlineEditableTextBlockStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262B5 RID: 156341 RVA: 0x0039EC8A File Offset: 0x0039CE8A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInlineEditableTextBlockStyle._ScriptStructPtr != 0) ? FInlineEditableTextBlockStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.InlineEditableTextBlockStyle", ref FInlineEditableTextBlockStyle._ScriptStructPtr);
		}

		// Token: 0x1700935C RID: 37724
		// (get) Token: 0x060262B6 RID: 156342 RVA: 0x0039ECB0 File Offset: 0x0039CEB0
		// (set) Token: 0x060262B7 RID: 156343 RVA: 0x0039ECF3 File Offset: 0x0039CEF3
		public FEditableTextBoxStyle EditableTextBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FEditableTextBoxStyle result;
				if ((result = this._EditableTextBoxStyle) == null)
				{
					result = (this._EditableTextBoxStyle = new FEditableTextBoxStyle(base.NativePtr + (IntPtr)FInlineEditableTextBlockStyle.__PropertyOffset_EditableTextBoxStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditableTextBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)FInlineEditableTextBlockStyle.__PropertyOffset_EditableTextBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700935D RID: 37725
		// (get) Token: 0x060262B8 RID: 156344 RVA: 0x0039ED14 File Offset: 0x0039CF14
		// (set) Token: 0x060262B9 RID: 156345 RVA: 0x0039ED57 File Offset: 0x0039CF57
		public FTextBlockStyle TextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TextStyle) == null)
				{
					result = (this._TextStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FInlineEditableTextBlockStyle.__PropertyOffset_TextStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FInlineEditableTextBlockStyle.__PropertyOffset_TextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060262BA RID: 156346 RVA: 0x0039ED78 File Offset: 0x0039CF78
		public FInlineEditableTextBlockStyle()
		{
		}

		// Token: 0x060262BB RID: 156347 RVA: 0x0039ED80 File Offset: 0x0039CF80
		public FInlineEditableTextBlockStyle(FEditableTextBoxStyle EditableTextBoxStyle, FTextBlockStyle TextStyle)
		{
			this.EditableTextBoxStyle = EditableTextBoxStyle;
			this.TextStyle = TextStyle;
		}

		// Token: 0x060262BC RID: 156348 RVA: 0x0039ED96 File Offset: 0x0039CF96
		protected override IntPtr GetUStructPtr()
		{
			return FInlineEditableTextBlockStyle.StaticStruct();
		}

		// Token: 0x060262BD RID: 156349 RVA: 0x0039EDA2 File Offset: 0x0039CFA2
		[NullableContext(2)]
		public FInlineEditableTextBlockStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262BE RID: 156350 RVA: 0x0039EDAC File Offset: 0x0039CFAC
		public FInlineEditableTextBlockStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262BF RID: 156351 RVA: 0x0039EDB7 File Offset: 0x0039CFB7
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInlineEditableTextBlockStyle(Pointer, false, true);
		}

		// Token: 0x060262C0 RID: 156352 RVA: 0x0039EDC1 File Offset: 0x0039CFC1
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInlineEditableTextBlockStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E47 RID: 85575
		public new const string __ObjectPath = "/Script/SlateCore.InlineEditableTextBlockStyle";

		// Token: 0x04014E48 RID: 85576
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E49 RID: 85577
		internal static int __PropertyOffset_EditableTextBoxStyle;

		// Token: 0x04014E4A RID: 85578
		[Nullable(2)]
		private FEditableTextBoxStyle _EditableTextBoxStyle;

		// Token: 0x04014E4B RID: 85579
		internal static int __PropertyOffset_TextStyle;

		// Token: 0x04014E4C RID: 85580
		[Nullable(2)]
		private FTextBlockStyle _TextStyle;
	}
}
