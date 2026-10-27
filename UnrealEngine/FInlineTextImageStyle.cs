using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200281E RID: 10270
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.InlineTextImageStyle")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FInlineTextImageStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262C1 RID: 156353 RVA: 0x0039EDCA File Offset: 0x0039CFCA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInlineTextImageStyle._ScriptStructPtr != 0) ? FInlineTextImageStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.InlineTextImageStyle", ref FInlineTextImageStyle._ScriptStructPtr);
		}

		// Token: 0x1700935E RID: 37726
		// (get) Token: 0x060262C2 RID: 156354 RVA: 0x0039EDF0 File Offset: 0x0039CFF0
		// (set) Token: 0x060262C3 RID: 156355 RVA: 0x0039EE33 File Offset: 0x0039D033
		public FSlateBrush Image
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Image) == null)
				{
					result = (this._Image = new FSlateBrush(base.NativePtr + (IntPtr)FInlineTextImageStyle.__PropertyOffset_Image, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FInlineTextImageStyle.__PropertyOffset_Image, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700935F RID: 37727
		// (get) Token: 0x060262C4 RID: 156356 RVA: 0x0039EE54 File Offset: 0x0039D054
		// (set) Token: 0x060262C5 RID: 156357 RVA: 0x0039EE64 File Offset: 0x0039D064
		public unsafe short Baseline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInlineTextImageStyle.__PropertyOffset_Baseline);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInlineTextImageStyle.__PropertyOffset_Baseline) = value;
			}
		}

		// Token: 0x060262C6 RID: 156358 RVA: 0x0039EE75 File Offset: 0x0039D075
		public FInlineTextImageStyle()
		{
		}

		// Token: 0x060262C7 RID: 156359 RVA: 0x0039EE7D File Offset: 0x0039D07D
		public FInlineTextImageStyle(FSlateBrush Image, short Baseline)
		{
			this.Image = Image;
			this.Baseline = Baseline;
		}

		// Token: 0x060262C8 RID: 156360 RVA: 0x0039EE93 File Offset: 0x0039D093
		protected override IntPtr GetUStructPtr()
		{
			return FInlineTextImageStyle.StaticStruct();
		}

		// Token: 0x060262C9 RID: 156361 RVA: 0x0039EE9F File Offset: 0x0039D09F
		[NullableContext(2)]
		public FInlineTextImageStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262CA RID: 156362 RVA: 0x0039EEA9 File Offset: 0x0039D0A9
		public FInlineTextImageStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262CB RID: 156363 RVA: 0x0039EEB4 File Offset: 0x0039D0B4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInlineTextImageStyle(Pointer, false, true);
		}

		// Token: 0x060262CC RID: 156364 RVA: 0x0039EEBE File Offset: 0x0039D0BE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInlineTextImageStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E4D RID: 85581
		public new const string __ObjectPath = "/Script/SlateCore.InlineTextImageStyle";

		// Token: 0x04014E4E RID: 85582
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E4F RID: 85583
		internal static int __PropertyOffset_Image;

		// Token: 0x04014E50 RID: 85584
		[Nullable(2)]
		private FSlateBrush _Image;

		// Token: 0x04014E51 RID: 85585
		internal static int __PropertyOffset_Baseline;
	}
}
