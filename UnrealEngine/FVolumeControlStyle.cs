using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200283B RID: 10299
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.VolumeControlStyle")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1784)]
	public class FVolumeControlStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026463 RID: 156771 RVA: 0x003A1F22 File Offset: 0x003A0122
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVolumeControlStyle._ScriptStructPtr != 0) ? FVolumeControlStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.VolumeControlStyle", ref FVolumeControlStyle._ScriptStructPtr);
		}

		// Token: 0x170093C6 RID: 37830
		// (get) Token: 0x06026464 RID: 156772 RVA: 0x003A1F48 File Offset: 0x003A0148
		// (set) Token: 0x06026465 RID: 156773 RVA: 0x003A1F8B File Offset: 0x003A018B
		public FSliderStyle SliderStyle
		{
			get
			{
				base.FastCheckIsValid();
				FSliderStyle result;
				if ((result = this._SliderStyle) == null)
				{
					result = (this._SliderStyle = new FSliderStyle(base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_SliderStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSliderStyle.StaticStruct(), base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_SliderStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093C7 RID: 37831
		// (get) Token: 0x06026466 RID: 156774 RVA: 0x003A1FAC File Offset: 0x003A01AC
		// (set) Token: 0x06026467 RID: 156775 RVA: 0x003A1FEF File Offset: 0x003A01EF
		public FSlateBrush HighVolumeImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HighVolumeImage) == null)
				{
					result = (this._HighVolumeImage = new FSlateBrush(base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_HighVolumeImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_HighVolumeImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093C8 RID: 37832
		// (get) Token: 0x06026468 RID: 156776 RVA: 0x003A2010 File Offset: 0x003A0210
		// (set) Token: 0x06026469 RID: 156777 RVA: 0x003A2053 File Offset: 0x003A0253
		public FSlateBrush MidVolumeImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MidVolumeImage) == null)
				{
					result = (this._MidVolumeImage = new FSlateBrush(base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_MidVolumeImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_MidVolumeImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093C9 RID: 37833
		// (get) Token: 0x0602646A RID: 156778 RVA: 0x003A2074 File Offset: 0x003A0274
		// (set) Token: 0x0602646B RID: 156779 RVA: 0x003A20B7 File Offset: 0x003A02B7
		public FSlateBrush LowVolumeImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._LowVolumeImage) == null)
				{
					result = (this._LowVolumeImage = new FSlateBrush(base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_LowVolumeImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_LowVolumeImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093CA RID: 37834
		// (get) Token: 0x0602646C RID: 156780 RVA: 0x003A20D8 File Offset: 0x003A02D8
		// (set) Token: 0x0602646D RID: 156781 RVA: 0x003A211B File Offset: 0x003A031B
		public FSlateBrush NoVolumeImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NoVolumeImage) == null)
				{
					result = (this._NoVolumeImage = new FSlateBrush(base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_NoVolumeImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_NoVolumeImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093CB RID: 37835
		// (get) Token: 0x0602646E RID: 156782 RVA: 0x003A213C File Offset: 0x003A033C
		// (set) Token: 0x0602646F RID: 156783 RVA: 0x003A217F File Offset: 0x003A037F
		public FSlateBrush MutedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MutedImage) == null)
				{
					result = (this._MutedImage = new FSlateBrush(base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_MutedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FVolumeControlStyle.__PropertyOffset_MutedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026470 RID: 156784 RVA: 0x003A21A0 File Offset: 0x003A03A0
		public FVolumeControlStyle()
		{
		}

		// Token: 0x06026471 RID: 156785 RVA: 0x003A21A8 File Offset: 0x003A03A8
		public FVolumeControlStyle(FSliderStyle SliderStyle, FSlateBrush HighVolumeImage, FSlateBrush MidVolumeImage, FSlateBrush LowVolumeImage, FSlateBrush NoVolumeImage, FSlateBrush MutedImage)
		{
			this.SliderStyle = SliderStyle;
			this.HighVolumeImage = HighVolumeImage;
			this.MidVolumeImage = MidVolumeImage;
			this.LowVolumeImage = LowVolumeImage;
			this.NoVolumeImage = NoVolumeImage;
			this.MutedImage = MutedImage;
		}

		// Token: 0x06026472 RID: 156786 RVA: 0x003A21DD File Offset: 0x003A03DD
		protected override IntPtr GetUStructPtr()
		{
			return FVolumeControlStyle.StaticStruct();
		}

		// Token: 0x06026473 RID: 156787 RVA: 0x003A21E9 File Offset: 0x003A03E9
		[NullableContext(2)]
		public FVolumeControlStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026474 RID: 156788 RVA: 0x003A21F3 File Offset: 0x003A03F3
		public FVolumeControlStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026475 RID: 156789 RVA: 0x003A21FE File Offset: 0x003A03FE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVolumeControlStyle(Pointer, false, true);
		}

		// Token: 0x06026476 RID: 156790 RVA: 0x003A2208 File Offset: 0x003A0408
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVolumeControlStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014F43 RID: 85827
		public new const string __ObjectPath = "/Script/SlateCore.VolumeControlStyle";

		// Token: 0x04014F44 RID: 85828
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F45 RID: 85829
		internal static int __PropertyOffset_SliderStyle;

		// Token: 0x04014F46 RID: 85830
		[Nullable(2)]
		private FSliderStyle _SliderStyle;

		// Token: 0x04014F47 RID: 85831
		internal static int __PropertyOffset_HighVolumeImage;

		// Token: 0x04014F48 RID: 85832
		[Nullable(2)]
		private FSlateBrush _HighVolumeImage;

		// Token: 0x04014F49 RID: 85833
		internal static int __PropertyOffset_MidVolumeImage;

		// Token: 0x04014F4A RID: 85834
		[Nullable(2)]
		private FSlateBrush _MidVolumeImage;

		// Token: 0x04014F4B RID: 85835
		internal static int __PropertyOffset_LowVolumeImage;

		// Token: 0x04014F4C RID: 85836
		[Nullable(2)]
		private FSlateBrush _LowVolumeImage;

		// Token: 0x04014F4D RID: 85837
		internal static int __PropertyOffset_NoVolumeImage;

		// Token: 0x04014F4E RID: 85838
		[Nullable(2)]
		private FSlateBrush _NoVolumeImage;

		// Token: 0x04014F4F RID: 85839
		internal static int __PropertyOffset_MutedImage;

		// Token: 0x04014F50 RID: 85840
		[Nullable(2)]
		private FSlateBrush _MutedImage;
	}
}
