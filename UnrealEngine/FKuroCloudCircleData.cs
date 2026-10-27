using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001ACE RID: 6862
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudCircleData")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroCloudCircleData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019851 RID: 104529 RVA: 0x0025B6EC File Offset: 0x002598EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCloudCircleData._ScriptStructPtr != 0) ? FKuroCloudCircleData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudCircleData", ref FKuroCloudCircleData._ScriptStructPtr);
		}

		// Token: 0x170065D0 RID: 26064
		// (get) Token: 0x06019852 RID: 104530 RVA: 0x0025B710 File Offset: 0x00259910
		// (set) Token: 0x06019853 RID: 104531 RVA: 0x0025B720 File Offset: 0x00259920
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x170065D1 RID: 26065
		// (get) Token: 0x06019854 RID: 104532 RVA: 0x0025B731 File Offset: 0x00259931
		// (set) Token: 0x06019855 RID: 104533 RVA: 0x0025B745 File Offset: 0x00259945
		public unsafe FVector Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x170065D2 RID: 26066
		// (get) Token: 0x06019856 RID: 104534 RVA: 0x0025B75A File Offset: 0x0025995A
		// (set) Token: 0x06019857 RID: 104535 RVA: 0x0025B76A File Offset: 0x0025996A
		public unsafe int TextureIdx
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_TextureIdx);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_TextureIdx) = value;
			}
		}

		// Token: 0x170065D3 RID: 26067
		// (get) Token: 0x06019858 RID: 104536 RVA: 0x0025B77B File Offset: 0x0025997B
		// (set) Token: 0x06019859 RID: 104537 RVA: 0x0025B78B File Offset: 0x0025998B
		public unsafe float HorizontalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_HorizontalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_HorizontalOffset) = value;
			}
		}

		// Token: 0x170065D4 RID: 26068
		// (get) Token: 0x0601985A RID: 104538 RVA: 0x0025B79C File Offset: 0x0025999C
		// (set) Token: 0x0601985B RID: 104539 RVA: 0x0025B7AC File Offset: 0x002599AC
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170065D5 RID: 26069
		// (get) Token: 0x0601985C RID: 104540 RVA: 0x0025B7BD File Offset: 0x002599BD
		// (set) Token: 0x0601985D RID: 104541 RVA: 0x0025B7D1 File Offset: 0x002599D1
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x170065D6 RID: 26070
		// (get) Token: 0x0601985E RID: 104542 RVA: 0x0025B7E6 File Offset: 0x002599E6
		// (set) Token: 0x0601985F RID: 104543 RVA: 0x0025B7F6 File Offset: 0x002599F6
		public unsafe float AlphaControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_AlphaControl);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_AlphaControl) = value;
			}
		}

		// Token: 0x170065D7 RID: 26071
		// (get) Token: 0x06019860 RID: 104544 RVA: 0x0025B807 File Offset: 0x00259A07
		// (set) Token: 0x06019861 RID: 104545 RVA: 0x0025B817 File Offset: 0x00259A17
		public unsafe float AlphaMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_AlphaMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_AlphaMax) = value;
			}
		}

		// Token: 0x170065D8 RID: 26072
		// (get) Token: 0x06019862 RID: 104546 RVA: 0x0025B828 File Offset: 0x00259A28
		// (set) Token: 0x06019863 RID: 104547 RVA: 0x0025B838 File Offset: 0x00259A38
		public unsafe float AlphaMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_AlphaMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_AlphaMin) = value;
			}
		}

		// Token: 0x170065D9 RID: 26073
		// (get) Token: 0x06019864 RID: 104548 RVA: 0x0025B849 File Offset: 0x00259A49
		// (set) Token: 0x06019865 RID: 104549 RVA: 0x0025B859 File Offset: 0x00259A59
		public unsafe float Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Brightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_Brightness) = value;
			}
		}

		// Token: 0x170065DA RID: 26074
		// (get) Token: 0x06019866 RID: 104550 RVA: 0x0025B86A File Offset: 0x00259A6A
		// (set) Token: 0x06019867 RID: 104551 RVA: 0x0025B87A File Offset: 0x00259A7A
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x170065DB RID: 26075
		// (get) Token: 0x06019868 RID: 104552 RVA: 0x0025B88B File Offset: 0x00259A8B
		// (set) Token: 0x06019869 RID: 104553 RVA: 0x0025B89B File Offset: 0x00259A9B
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_FadeInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_FadeInTime) = value;
			}
		}

		// Token: 0x170065DC RID: 26076
		// (get) Token: 0x0601986A RID: 104554 RVA: 0x0025B8AC File Offset: 0x00259AAC
		// (set) Token: 0x0601986B RID: 104555 RVA: 0x0025B8BC File Offset: 0x00259ABC
		public unsafe float FullStayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_FullStayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_FullStayTime) = value;
			}
		}

		// Token: 0x170065DD RID: 26077
		// (get) Token: 0x0601986C RID: 104556 RVA: 0x0025B8CD File Offset: 0x00259ACD
		// (set) Token: 0x0601986D RID: 104557 RVA: 0x0025B8DD File Offset: 0x00259ADD
		public unsafe float DisappearTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_DisappearTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCircleData.__PropertyOffset_DisappearTime) = value;
			}
		}

		// Token: 0x0601986E RID: 104558 RVA: 0x0025B8EE File Offset: 0x00259AEE
		public FKuroCloudCircleData()
		{
		}

		// Token: 0x0601986F RID: 104559 RVA: 0x0025B8F8 File Offset: 0x00259AF8
		public FKuroCloudCircleData(float Distance, FVector Rotator, int TextureIdx, float HorizontalOffset, float Scale, FVector Offset, float AlphaControl, float AlphaMax, float AlphaMin, float Brightness, float FadeOutTime, float FadeInTime, float FullStayTime, float DisappearTime)
		{
			this.Distance = Distance;
			this.Rotator = Rotator;
			this.TextureIdx = TextureIdx;
			this.HorizontalOffset = HorizontalOffset;
			this.Scale = Scale;
			this.Offset = Offset;
			this.AlphaControl = AlphaControl;
			this.AlphaMax = AlphaMax;
			this.AlphaMin = AlphaMin;
			this.Brightness = Brightness;
			this.FadeOutTime = FadeOutTime;
			this.FadeInTime = FadeInTime;
			this.FullStayTime = FullStayTime;
			this.DisappearTime = DisappearTime;
		}

		// Token: 0x06019870 RID: 104560 RVA: 0x0025B978 File Offset: 0x00259B78
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCloudCircleData.StaticStruct();
		}

		// Token: 0x06019871 RID: 104561 RVA: 0x0025B984 File Offset: 0x00259B84
		[NullableContext(2)]
		public FKuroCloudCircleData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019872 RID: 104562 RVA: 0x0025B98E File Offset: 0x00259B8E
		public FKuroCloudCircleData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019873 RID: 104563 RVA: 0x0025B999 File Offset: 0x00259B99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCloudCircleData(Pointer, false, true);
		}

		// Token: 0x06019874 RID: 104564 RVA: 0x0025B9A3 File Offset: 0x00259BA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCloudCircleData(Pointer, MemoryOwner);
		}

		// Token: 0x0400DE44 RID: 56900
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudCircleData";

		// Token: 0x0400DE45 RID: 56901
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DE46 RID: 56902
		internal static int __PropertyOffset_Distance;

		// Token: 0x0400DE47 RID: 56903
		internal static int __PropertyOffset_Rotator;

		// Token: 0x0400DE48 RID: 56904
		internal static int __PropertyOffset_TextureIdx;

		// Token: 0x0400DE49 RID: 56905
		internal static int __PropertyOffset_HorizontalOffset;

		// Token: 0x0400DE4A RID: 56906
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400DE4B RID: 56907
		internal static int __PropertyOffset_Offset;

		// Token: 0x0400DE4C RID: 56908
		internal static int __PropertyOffset_AlphaControl;

		// Token: 0x0400DE4D RID: 56909
		internal static int __PropertyOffset_AlphaMax;

		// Token: 0x0400DE4E RID: 56910
		internal static int __PropertyOffset_AlphaMin;

		// Token: 0x0400DE4F RID: 56911
		internal static int __PropertyOffset_Brightness;

		// Token: 0x0400DE50 RID: 56912
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x0400DE51 RID: 56913
		internal static int __PropertyOffset_FadeInTime;

		// Token: 0x0400DE52 RID: 56914
		internal static int __PropertyOffset_FullStayTime;

		// Token: 0x0400DE53 RID: 56915
		internal static int __PropertyOffset_DisappearTime;
	}
}
