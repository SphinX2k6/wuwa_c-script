using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029CB RID: 10699
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.RichTextStyleRow")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 720)]
	public class FRichTextStyleRow : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060278D9 RID: 162009 RVA: 0x003C5901 File Offset: 0x003C3B01
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRichTextStyleRow._ScriptStructPtr != 0) ? FRichTextStyleRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.RichTextStyleRow", ref FRichTextStyleRow._ScriptStructPtr);
		}

		// Token: 0x17009790 RID: 38800
		// (get) Token: 0x060278DA RID: 162010 RVA: 0x003C5928 File Offset: 0x003C3B28
		// (set) Token: 0x060278DB RID: 162011 RVA: 0x003C596B File Offset: 0x003C3B6B
		public FTextBlockStyle TextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TextStyle) == null)
				{
					result = (this._TextStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FRichTextStyleRow.__PropertyOffset_TextStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FRichTextStyleRow.__PropertyOffset_TextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060278DC RID: 162012 RVA: 0x003C598C File Offset: 0x003C3B8C
		public FRichTextStyleRow()
		{
		}

		// Token: 0x060278DD RID: 162013 RVA: 0x003C5994 File Offset: 0x003C3B94
		public FRichTextStyleRow(FTextBlockStyle TextStyle)
		{
			this.TextStyle = TextStyle;
		}

		// Token: 0x060278DE RID: 162014 RVA: 0x003C59A3 File Offset: 0x003C3BA3
		protected override IntPtr GetUStructPtr()
		{
			return FRichTextStyleRow.StaticStruct();
		}

		// Token: 0x060278DF RID: 162015 RVA: 0x003C59AF File Offset: 0x003C3BAF
		[NullableContext(2)]
		public FRichTextStyleRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060278E0 RID: 162016 RVA: 0x003C59B9 File Offset: 0x003C3BB9
		public FRichTextStyleRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060278E1 RID: 162017 RVA: 0x003C59C4 File Offset: 0x003C3BC4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRichTextStyleRow(Pointer, false, true);
		}

		// Token: 0x060278E2 RID: 162018 RVA: 0x003C59CE File Offset: 0x003C3BCE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRichTextStyleRow(Pointer, MemoryOwner);
		}

		// Token: 0x04015AE7 RID: 88807
		public new const string __ObjectPath = "/Script/UMG.RichTextStyleRow";

		// Token: 0x04015AE8 RID: 88808
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015AE9 RID: 88809
		internal static int __PropertyOffset_TextStyle;

		// Token: 0x04015AEA RID: 88810
		[Nullable(2)]
		private FTextBlockStyle _TextStyle;
	}
}
