using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028EB RID: 10475
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapToastStyle")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1048)]
	public class FTapToastStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026DA5 RID: 159141 RVA: 0x003B421D File Offset: 0x003B241D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapToastStyle._ScriptStructPtr != 0) ? FTapToastStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapToastStyle", ref FTapToastStyle._ScriptStructPtr);
		}

		// Token: 0x170095AB RID: 38315
		// (get) Token: 0x06026DA6 RID: 159142 RVA: 0x003B4244 File Offset: 0x003B2444
		// (set) Token: 0x06026DA7 RID: 159143 RVA: 0x003B4287 File Offset: 0x003B2487
		public FSlateBrush Background
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Background) == null)
				{
					result = (this._Background = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_Background, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_Background, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095AC RID: 38316
		// (get) Token: 0x06026DA8 RID: 159144 RVA: 0x003B42A8 File Offset: 0x003B24A8
		// (set) Token: 0x06026DA9 RID: 159145 RVA: 0x003B42EB File Offset: 0x003B24EB
		public FSlateBrush IconBrushTemplate
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._IconBrushTemplate) == null)
				{
					result = (this._IconBrushTemplate = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_IconBrushTemplate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_IconBrushTemplate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095AD RID: 38317
		// (get) Token: 0x06026DAA RID: 159146 RVA: 0x003B430C File Offset: 0x003B250C
		// (set) Token: 0x06026DAB RID: 159147 RVA: 0x003B434F File Offset: 0x003B254F
		public FTextBlockStyle ContentStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._ContentStyle) == null)
				{
					result = (this._ContentStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_ContentStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_ContentStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095AE RID: 38318
		// (get) Token: 0x06026DAC RID: 159148 RVA: 0x003B4370 File Offset: 0x003B2570
		// (set) Token: 0x06026DAD RID: 159149 RVA: 0x003B4380 File Offset: 0x003B2580
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapToastStyle.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x06026DAE RID: 159150 RVA: 0x003B4391 File Offset: 0x003B2591
		public FTapToastStyle()
		{
		}

		// Token: 0x06026DAF RID: 159151 RVA: 0x003B4399 File Offset: 0x003B2599
		public FTapToastStyle(FSlateBrush Background, FSlateBrush IconBrushTemplate, FTextBlockStyle ContentStyle, float Height)
		{
			this.Background = Background;
			this.IconBrushTemplate = IconBrushTemplate;
			this.ContentStyle = ContentStyle;
			this.Height = Height;
		}

		// Token: 0x06026DB0 RID: 159152 RVA: 0x003B43BE File Offset: 0x003B25BE
		protected override IntPtr GetUStructPtr()
		{
			return FTapToastStyle.StaticStruct();
		}

		// Token: 0x06026DB1 RID: 159153 RVA: 0x003B43CA File Offset: 0x003B25CA
		[NullableContext(2)]
		public FTapToastStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026DB2 RID: 159154 RVA: 0x003B43D4 File Offset: 0x003B25D4
		public FTapToastStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026DB3 RID: 159155 RVA: 0x003B43DF File Offset: 0x003B25DF
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapToastStyle(Pointer, false, true);
		}

		// Token: 0x06026DB4 RID: 159156 RVA: 0x003B43E9 File Offset: 0x003B25E9
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapToastStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04015547 RID: 87367
		public new const string __ObjectPath = "/Script/TapCommon.TapToastStyle";

		// Token: 0x04015548 RID: 87368
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015549 RID: 87369
		internal static int __PropertyOffset_Background;

		// Token: 0x0401554A RID: 87370
		[Nullable(2)]
		private FSlateBrush _Background;

		// Token: 0x0401554B RID: 87371
		internal static int __PropertyOffset_IconBrushTemplate;

		// Token: 0x0401554C RID: 87372
		[Nullable(2)]
		private FSlateBrush _IconBrushTemplate;

		// Token: 0x0401554D RID: 87373
		internal static int __PropertyOffset_ContentStyle;

		// Token: 0x0401554E RID: 87374
		[Nullable(2)]
		private FTextBlockStyle _ContentStyle;

		// Token: 0x0401554F RID: 87375
		internal static int __PropertyOffset_Height;
	}
}
