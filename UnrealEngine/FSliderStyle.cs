using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002833 RID: 10291
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.SliderStyle")]
	[UnrealStructLayout(976, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 976)]
	public class FSliderStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060263B9 RID: 156601 RVA: 0x003A06E6 File Offset: 0x0039E8E6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSliderStyle._ScriptStructPtr != 0) ? FSliderStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SliderStyle", ref FSliderStyle._ScriptStructPtr);
		}

		// Token: 0x17009391 RID: 37777
		// (get) Token: 0x060263BA RID: 156602 RVA: 0x003A070C File Offset: 0x0039E90C
		// (set) Token: 0x060263BB RID: 156603 RVA: 0x003A074F File Offset: 0x0039E94F
		public FSlateBrush NormalBarImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NormalBarImage) == null)
				{
					result = (this._NormalBarImage = new FSlateBrush(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_NormalBarImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_NormalBarImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009392 RID: 37778
		// (get) Token: 0x060263BC RID: 156604 RVA: 0x003A0770 File Offset: 0x0039E970
		// (set) Token: 0x060263BD RID: 156605 RVA: 0x003A07B3 File Offset: 0x0039E9B3
		public FSlateBrush HoveredBarImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HoveredBarImage) == null)
				{
					result = (this._HoveredBarImage = new FSlateBrush(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_HoveredBarImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_HoveredBarImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009393 RID: 37779
		// (get) Token: 0x060263BE RID: 156606 RVA: 0x003A07D4 File Offset: 0x0039E9D4
		// (set) Token: 0x060263BF RID: 156607 RVA: 0x003A0817 File Offset: 0x0039EA17
		public FSlateBrush DisabledBarImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DisabledBarImage) == null)
				{
					result = (this._DisabledBarImage = new FSlateBrush(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_DisabledBarImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_DisabledBarImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009394 RID: 37780
		// (get) Token: 0x060263C0 RID: 156608 RVA: 0x003A0838 File Offset: 0x0039EA38
		// (set) Token: 0x060263C1 RID: 156609 RVA: 0x003A087B File Offset: 0x0039EA7B
		public FSlateBrush NormalThumbImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NormalThumbImage) == null)
				{
					result = (this._NormalThumbImage = new FSlateBrush(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_NormalThumbImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_NormalThumbImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009395 RID: 37781
		// (get) Token: 0x060263C2 RID: 156610 RVA: 0x003A089C File Offset: 0x0039EA9C
		// (set) Token: 0x060263C3 RID: 156611 RVA: 0x003A08DF File Offset: 0x0039EADF
		public FSlateBrush HoveredThumbImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HoveredThumbImage) == null)
				{
					result = (this._HoveredThumbImage = new FSlateBrush(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_HoveredThumbImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_HoveredThumbImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009396 RID: 37782
		// (get) Token: 0x060263C4 RID: 156612 RVA: 0x003A0900 File Offset: 0x0039EB00
		// (set) Token: 0x060263C5 RID: 156613 RVA: 0x003A0943 File Offset: 0x0039EB43
		public FSlateBrush DisabledThumbImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DisabledThumbImage) == null)
				{
					result = (this._DisabledThumbImage = new FSlateBrush(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_DisabledThumbImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_DisabledThumbImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009397 RID: 37783
		// (get) Token: 0x060263C6 RID: 156614 RVA: 0x003A0964 File Offset: 0x0039EB64
		// (set) Token: 0x060263C7 RID: 156615 RVA: 0x003A0974 File Offset: 0x0039EB74
		public unsafe float BarThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_BarThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSliderStyle.__PropertyOffset_BarThickness) = value;
			}
		}

		// Token: 0x060263C8 RID: 156616 RVA: 0x003A0985 File Offset: 0x0039EB85
		public FSliderStyle()
		{
		}

		// Token: 0x060263C9 RID: 156617 RVA: 0x003A098D File Offset: 0x0039EB8D
		public FSliderStyle(FSlateBrush NormalBarImage, FSlateBrush HoveredBarImage, FSlateBrush DisabledBarImage, FSlateBrush NormalThumbImage, FSlateBrush HoveredThumbImage, FSlateBrush DisabledThumbImage, float BarThickness)
		{
			this.NormalBarImage = NormalBarImage;
			this.HoveredBarImage = HoveredBarImage;
			this.DisabledBarImage = DisabledBarImage;
			this.NormalThumbImage = NormalThumbImage;
			this.HoveredThumbImage = HoveredThumbImage;
			this.DisabledThumbImage = DisabledThumbImage;
			this.BarThickness = BarThickness;
		}

		// Token: 0x060263CA RID: 156618 RVA: 0x003A09CA File Offset: 0x0039EBCA
		protected override IntPtr GetUStructPtr()
		{
			return FSliderStyle.StaticStruct();
		}

		// Token: 0x060263CB RID: 156619 RVA: 0x003A09D6 File Offset: 0x0039EBD6
		[NullableContext(2)]
		public FSliderStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060263CC RID: 156620 RVA: 0x003A09E0 File Offset: 0x0039EBE0
		public FSliderStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060263CD RID: 156621 RVA: 0x003A09EB File Offset: 0x0039EBEB
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSliderStyle(Pointer, false, true);
		}

		// Token: 0x060263CE RID: 156622 RVA: 0x003A09F5 File Offset: 0x0039EBF5
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSliderStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014ECF RID: 85711
		public new const string __ObjectPath = "/Script/SlateCore.SliderStyle";

		// Token: 0x04014ED0 RID: 85712
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014ED1 RID: 85713
		internal static int __PropertyOffset_NormalBarImage;

		// Token: 0x04014ED2 RID: 85714
		[Nullable(2)]
		private FSlateBrush _NormalBarImage;

		// Token: 0x04014ED3 RID: 85715
		internal static int __PropertyOffset_HoveredBarImage;

		// Token: 0x04014ED4 RID: 85716
		[Nullable(2)]
		private FSlateBrush _HoveredBarImage;

		// Token: 0x04014ED5 RID: 85717
		internal static int __PropertyOffset_DisabledBarImage;

		// Token: 0x04014ED6 RID: 85718
		[Nullable(2)]
		private FSlateBrush _DisabledBarImage;

		// Token: 0x04014ED7 RID: 85719
		internal static int __PropertyOffset_NormalThumbImage;

		// Token: 0x04014ED8 RID: 85720
		[Nullable(2)]
		private FSlateBrush _NormalThumbImage;

		// Token: 0x04014ED9 RID: 85721
		internal static int __PropertyOffset_HoveredThumbImage;

		// Token: 0x04014EDA RID: 85722
		[Nullable(2)]
		private FSlateBrush _HoveredThumbImage;

		// Token: 0x04014EDB RID: 85723
		internal static int __PropertyOffset_DisabledThumbImage;

		// Token: 0x04014EDC RID: 85724
		[Nullable(2)]
		private FSlateBrush _DisabledThumbImage;

		// Token: 0x04014EDD RID: 85725
		internal static int __PropertyOffset_BarThickness;
	}
}
