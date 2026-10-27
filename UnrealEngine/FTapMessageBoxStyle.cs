using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028E4 RID: 10468
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapMessageBoxStyle")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 736)]
	public class FTapMessageBoxStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D46 RID: 159046 RVA: 0x003B37C8 File Offset: 0x003B19C8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapMessageBoxStyle._ScriptStructPtr != 0) ? FTapMessageBoxStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapMessageBoxStyle", ref FTapMessageBoxStyle._ScriptStructPtr);
		}

		// Token: 0x17009593 RID: 38291
		// (get) Token: 0x06026D47 RID: 159047 RVA: 0x003B37EC File Offset: 0x003B19EC
		// (set) Token: 0x06026D48 RID: 159048 RVA: 0x003B382F File Offset: 0x003B1A2F
		public FTextBlockStyle RichTextBlockStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._RichTextBlockStyle) == null)
				{
					result = (this._RichTextBlockStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FTapMessageBoxStyle.__PropertyOffset_RichTextBlockStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FTapMessageBoxStyle.__PropertyOffset_RichTextBlockStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009594 RID: 38292
		// (get) Token: 0x06026D49 RID: 159049 RVA: 0x003B3850 File Offset: 0x003B1A50
		// (set) Token: 0x06026D4A RID: 159050 RVA: 0x003B3864 File Offset: 0x003B1A64
		public unsafe FMargin ContentPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapMessageBoxStyle.__PropertyOffset_ContentPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapMessageBoxStyle.__PropertyOffset_ContentPadding) = value;
			}
		}

		// Token: 0x06026D4B RID: 159051 RVA: 0x003B3879 File Offset: 0x003B1A79
		public FTapMessageBoxStyle()
		{
		}

		// Token: 0x06026D4C RID: 159052 RVA: 0x003B3881 File Offset: 0x003B1A81
		public FTapMessageBoxStyle(FTextBlockStyle RichTextBlockStyle, FMargin ContentPadding)
		{
			this.RichTextBlockStyle = RichTextBlockStyle;
			this.ContentPadding = ContentPadding;
		}

		// Token: 0x06026D4D RID: 159053 RVA: 0x003B3897 File Offset: 0x003B1A97
		protected override IntPtr GetUStructPtr()
		{
			return FTapMessageBoxStyle.StaticStruct();
		}

		// Token: 0x06026D4E RID: 159054 RVA: 0x003B38A3 File Offset: 0x003B1AA3
		[NullableContext(2)]
		public FTapMessageBoxStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D4F RID: 159055 RVA: 0x003B38AD File Offset: 0x003B1AAD
		public FTapMessageBoxStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D50 RID: 159056 RVA: 0x003B38B8 File Offset: 0x003B1AB8
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapMessageBoxStyle(Pointer, false, true);
		}

		// Token: 0x06026D51 RID: 159057 RVA: 0x003B38C2 File Offset: 0x003B1AC2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapMessageBoxStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04015511 RID: 87313
		public new const string __ObjectPath = "/Script/TapCommon.TapMessageBoxStyle";

		// Token: 0x04015512 RID: 87314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015513 RID: 87315
		internal static int __PropertyOffset_RichTextBlockStyle;

		// Token: 0x04015514 RID: 87316
		[Nullable(2)]
		private FTextBlockStyle _RichTextBlockStyle;

		// Token: 0x04015515 RID: 87317
		internal static int __PropertyOffset_ContentPadding;
	}
}
