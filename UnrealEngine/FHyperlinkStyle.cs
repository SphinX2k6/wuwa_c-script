using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200281C RID: 10268
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.HyperlinkStyle")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1504)]
	public class FHyperlinkStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262A7 RID: 156327 RVA: 0x0039EB19 File Offset: 0x0039CD19
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHyperlinkStyle._ScriptStructPtr != 0) ? FHyperlinkStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.HyperlinkStyle", ref FHyperlinkStyle._ScriptStructPtr);
		}

		// Token: 0x17009359 RID: 37721
		// (get) Token: 0x060262A8 RID: 156328 RVA: 0x0039EB40 File Offset: 0x0039CD40
		// (set) Token: 0x060262A9 RID: 156329 RVA: 0x0039EB83 File Offset: 0x0039CD83
		public FButtonStyle UnderlineStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._UnderlineStyle) == null)
				{
					result = (this._UnderlineStyle = new FButtonStyle(base.NativePtr + (IntPtr)FHyperlinkStyle.__PropertyOffset_UnderlineStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FHyperlinkStyle.__PropertyOffset_UnderlineStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700935A RID: 37722
		// (get) Token: 0x060262AA RID: 156330 RVA: 0x0039EBA4 File Offset: 0x0039CDA4
		// (set) Token: 0x060262AB RID: 156331 RVA: 0x0039EBE7 File Offset: 0x0039CDE7
		public FTextBlockStyle TextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TextStyle) == null)
				{
					result = (this._TextStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FHyperlinkStyle.__PropertyOffset_TextStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FHyperlinkStyle.__PropertyOffset_TextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700935B RID: 37723
		// (get) Token: 0x060262AC RID: 156332 RVA: 0x0039EC08 File Offset: 0x0039CE08
		// (set) Token: 0x060262AD RID: 156333 RVA: 0x0039EC1C File Offset: 0x0039CE1C
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHyperlinkStyle.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHyperlinkStyle.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x060262AE RID: 156334 RVA: 0x0039EC31 File Offset: 0x0039CE31
		public FHyperlinkStyle()
		{
		}

		// Token: 0x060262AF RID: 156335 RVA: 0x0039EC39 File Offset: 0x0039CE39
		public FHyperlinkStyle(FButtonStyle UnderlineStyle, FTextBlockStyle TextStyle, FMargin Padding)
		{
			this.UnderlineStyle = UnderlineStyle;
			this.TextStyle = TextStyle;
			this.Padding = Padding;
		}

		// Token: 0x060262B0 RID: 156336 RVA: 0x0039EC56 File Offset: 0x0039CE56
		protected override IntPtr GetUStructPtr()
		{
			return FHyperlinkStyle.StaticStruct();
		}

		// Token: 0x060262B1 RID: 156337 RVA: 0x0039EC62 File Offset: 0x0039CE62
		[NullableContext(2)]
		public FHyperlinkStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262B2 RID: 156338 RVA: 0x0039EC6C File Offset: 0x0039CE6C
		public FHyperlinkStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262B3 RID: 156339 RVA: 0x0039EC77 File Offset: 0x0039CE77
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHyperlinkStyle(Pointer, false, true);
		}

		// Token: 0x060262B4 RID: 156340 RVA: 0x0039EC81 File Offset: 0x0039CE81
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHyperlinkStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E40 RID: 85568
		public new const string __ObjectPath = "/Script/SlateCore.HyperlinkStyle";

		// Token: 0x04014E41 RID: 85569
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E42 RID: 85570
		internal static int __PropertyOffset_UnderlineStyle;

		// Token: 0x04014E43 RID: 85571
		[Nullable(2)]
		private FButtonStyle _UnderlineStyle;

		// Token: 0x04014E44 RID: 85572
		internal static int __PropertyOffset_TextStyle;

		// Token: 0x04014E45 RID: 85573
		[Nullable(2)]
		private FTextBlockStyle _TextStyle;

		// Token: 0x04014E46 RID: 85574
		internal static int __PropertyOffset_Padding;
	}
}
