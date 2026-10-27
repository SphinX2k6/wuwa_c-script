using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002825 RID: 10277
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ProgressBarStyle")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 648)]
	public class FProgressBarStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262F7 RID: 156407 RVA: 0x0039F184 File Offset: 0x0039D384
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FProgressBarStyle._ScriptStructPtr != 0) ? FProgressBarStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ProgressBarStyle", ref FProgressBarStyle._ScriptStructPtr);
		}

		// Token: 0x17009360 RID: 37728
		// (get) Token: 0x060262F8 RID: 156408 RVA: 0x0039F1A8 File Offset: 0x0039D3A8
		// (set) Token: 0x060262F9 RID: 156409 RVA: 0x0039F1EB File Offset: 0x0039D3EB
		public FSlateBrush BackgroundImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImage) == null)
				{
					result = (this._BackgroundImage = new FSlateBrush(base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_BackgroundImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_BackgroundImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009361 RID: 37729
		// (get) Token: 0x060262FA RID: 156410 RVA: 0x0039F20C File Offset: 0x0039D40C
		// (set) Token: 0x060262FB RID: 156411 RVA: 0x0039F24F File Offset: 0x0039D44F
		public FSlateBrush FillImageMiddle
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._FillImageMiddle) == null)
				{
					result = (this._FillImageMiddle = new FSlateBrush(base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_FillImageMiddle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_FillImageMiddle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009362 RID: 37730
		// (get) Token: 0x060262FC RID: 156412 RVA: 0x0039F270 File Offset: 0x0039D470
		// (set) Token: 0x060262FD RID: 156413 RVA: 0x0039F2B3 File Offset: 0x0039D4B3
		public FSlateBrush FillImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._FillImage) == null)
				{
					result = (this._FillImage = new FSlateBrush(base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_FillImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_FillImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009363 RID: 37731
		// (get) Token: 0x060262FE RID: 156414 RVA: 0x0039F2D4 File Offset: 0x0039D4D4
		// (set) Token: 0x060262FF RID: 156415 RVA: 0x0039F317 File Offset: 0x0039D517
		public FSlateBrush MarqueeImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MarqueeImage) == null)
				{
					result = (this._MarqueeImage = new FSlateBrush(base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_MarqueeImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FProgressBarStyle.__PropertyOffset_MarqueeImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026300 RID: 156416 RVA: 0x0039F338 File Offset: 0x0039D538
		public FProgressBarStyle()
		{
		}

		// Token: 0x06026301 RID: 156417 RVA: 0x0039F340 File Offset: 0x0039D540
		public FProgressBarStyle(FSlateBrush BackgroundImage, FSlateBrush FillImageMiddle, FSlateBrush FillImage, FSlateBrush MarqueeImage)
		{
			this.BackgroundImage = BackgroundImage;
			this.FillImageMiddle = FillImageMiddle;
			this.FillImage = FillImage;
			this.MarqueeImage = MarqueeImage;
		}

		// Token: 0x06026302 RID: 156418 RVA: 0x0039F365 File Offset: 0x0039D565
		protected override IntPtr GetUStructPtr()
		{
			return FProgressBarStyle.StaticStruct();
		}

		// Token: 0x06026303 RID: 156419 RVA: 0x0039F371 File Offset: 0x0039D571
		[NullableContext(2)]
		public FProgressBarStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026304 RID: 156420 RVA: 0x0039F37B File Offset: 0x0039D57B
		public FProgressBarStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026305 RID: 156421 RVA: 0x0039F386 File Offset: 0x0039D586
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FProgressBarStyle(Pointer, false, true);
		}

		// Token: 0x06026306 RID: 156422 RVA: 0x0039F390 File Offset: 0x0039D590
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FProgressBarStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E62 RID: 85602
		public new const string __ObjectPath = "/Script/SlateCore.ProgressBarStyle";

		// Token: 0x04014E63 RID: 85603
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E64 RID: 85604
		internal static int __PropertyOffset_BackgroundImage;

		// Token: 0x04014E65 RID: 85605
		[Nullable(2)]
		private FSlateBrush _BackgroundImage;

		// Token: 0x04014E66 RID: 85606
		internal static int __PropertyOffset_FillImageMiddle;

		// Token: 0x04014E67 RID: 85607
		[Nullable(2)]
		private FSlateBrush _FillImageMiddle;

		// Token: 0x04014E68 RID: 85608
		internal static int __PropertyOffset_FillImage;

		// Token: 0x04014E69 RID: 85609
		[Nullable(2)]
		private FSlateBrush _FillImage;

		// Token: 0x04014E6A RID: 85610
		internal static int __PropertyOffset_MarqueeImage;

		// Token: 0x04014E6B RID: 85611
		[Nullable(2)]
		private FSlateBrush _MarqueeImage;
	}
}
