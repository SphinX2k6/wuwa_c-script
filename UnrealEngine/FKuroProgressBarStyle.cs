using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001901 RID: 6401
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroProgressBarStyle")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 648)]
	public class FKuroProgressBarStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017C0A RID: 97290 RVA: 0x0022CB87 File Offset: 0x0022AD87
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroProgressBarStyle._ScriptStructPtr != 0) ? FKuroProgressBarStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroProgressBarStyle", ref FKuroProgressBarStyle._ScriptStructPtr);
		}

		// Token: 0x17005FA2 RID: 24482
		// (get) Token: 0x06017C0B RID: 97291 RVA: 0x0022CBAC File Offset: 0x0022ADAC
		// (set) Token: 0x06017C0C RID: 97292 RVA: 0x0022CBEF File Offset: 0x0022ADEF
		public FSlateBrush BackgroundImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImage) == null)
				{
					result = (this._BackgroundImage = new FSlateBrush(base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_BackgroundImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_BackgroundImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005FA3 RID: 24483
		// (get) Token: 0x06017C0D RID: 97293 RVA: 0x0022CC10 File Offset: 0x0022AE10
		// (set) Token: 0x06017C0E RID: 97294 RVA: 0x0022CC53 File Offset: 0x0022AE53
		public FSlateBrush FillImageMiddle
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._FillImageMiddle) == null)
				{
					result = (this._FillImageMiddle = new FSlateBrush(base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_FillImageMiddle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_FillImageMiddle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005FA4 RID: 24484
		// (get) Token: 0x06017C0F RID: 97295 RVA: 0x0022CC74 File Offset: 0x0022AE74
		// (set) Token: 0x06017C10 RID: 97296 RVA: 0x0022CCB7 File Offset: 0x0022AEB7
		public FSlateBrush FillImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._FillImage) == null)
				{
					result = (this._FillImage = new FSlateBrush(base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_FillImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_FillImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005FA5 RID: 24485
		// (get) Token: 0x06017C11 RID: 97297 RVA: 0x0022CCD8 File Offset: 0x0022AED8
		// (set) Token: 0x06017C12 RID: 97298 RVA: 0x0022CD1B File Offset: 0x0022AF1B
		public FSlateBrush MarqueeImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MarqueeImage) == null)
				{
					result = (this._MarqueeImage = new FSlateBrush(base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_MarqueeImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FKuroProgressBarStyle.__PropertyOffset_MarqueeImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06017C13 RID: 97299 RVA: 0x0022CD3C File Offset: 0x0022AF3C
		public FKuroProgressBarStyle()
		{
		}

		// Token: 0x06017C14 RID: 97300 RVA: 0x0022CD44 File Offset: 0x0022AF44
		public FKuroProgressBarStyle(FSlateBrush BackgroundImage, FSlateBrush FillImageMiddle, FSlateBrush FillImage, FSlateBrush MarqueeImage)
		{
			this.BackgroundImage = BackgroundImage;
			this.FillImageMiddle = FillImageMiddle;
			this.FillImage = FillImage;
			this.MarqueeImage = MarqueeImage;
		}

		// Token: 0x06017C15 RID: 97301 RVA: 0x0022CD69 File Offset: 0x0022AF69
		protected override IntPtr GetUStructPtr()
		{
			return FKuroProgressBarStyle.StaticStruct();
		}

		// Token: 0x06017C16 RID: 97302 RVA: 0x0022CD75 File Offset: 0x0022AF75
		[NullableContext(2)]
		public FKuroProgressBarStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017C17 RID: 97303 RVA: 0x0022CD7F File Offset: 0x0022AF7F
		public FKuroProgressBarStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017C18 RID: 97304 RVA: 0x0022CD8A File Offset: 0x0022AF8A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroProgressBarStyle(Pointer, false, true);
		}

		// Token: 0x06017C19 RID: 97305 RVA: 0x0022CD94 File Offset: 0x0022AF94
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroProgressBarStyle(Pointer, MemoryOwner);
		}

		// Token: 0x0400CE30 RID: 52784
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroProgressBarStyle";

		// Token: 0x0400CE31 RID: 52785
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CE32 RID: 52786
		internal static int __PropertyOffset_BackgroundImage;

		// Token: 0x0400CE33 RID: 52787
		[Nullable(2)]
		private FSlateBrush _BackgroundImage;

		// Token: 0x0400CE34 RID: 52788
		internal static int __PropertyOffset_FillImageMiddle;

		// Token: 0x0400CE35 RID: 52789
		[Nullable(2)]
		private FSlateBrush _FillImageMiddle;

		// Token: 0x0400CE36 RID: 52790
		internal static int __PropertyOffset_FillImage;

		// Token: 0x0400CE37 RID: 52791
		[Nullable(2)]
		private FSlateBrush _FillImage;

		// Token: 0x0400CE38 RID: 52792
		internal static int __PropertyOffset_MarqueeImage;

		// Token: 0x0400CE39 RID: 52793
		[Nullable(2)]
		private FSlateBrush _MarqueeImage;
	}
}
