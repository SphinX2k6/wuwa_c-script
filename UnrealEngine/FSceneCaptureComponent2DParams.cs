using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010D5 RID: 4309
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponent2DParams")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSceneCaptureComponent2DParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F631 RID: 63025 RVA: 0x0016CC96 File Offset: 0x0016AE96
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneCaptureComponent2DParams._ScriptStructPtr != 0) ? FSceneCaptureComponent2DParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SceneCaptureComponent2DParams", ref FSceneCaptureComponent2DParams._ScriptStructPtr);
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0600F632 RID: 63026 RVA: 0x0016CCBA File Offset: 0x0016AEBA
		// (set) Token: 0x0600F633 RID: 63027 RVA: 0x0016CCCA File Offset: 0x0016AECA
		public unsafe float CaptureInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureInterval) = value;
			}
		}

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0600F634 RID: 63028 RVA: 0x0016CCDB File Offset: 0x0016AEDB
		// (set) Token: 0x0600F635 RID: 63029 RVA: 0x0016CCEB File Offset: 0x0016AEEB
		public unsafe int CaptureMaxRTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureMaxRTSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureMaxRTSize) = value;
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600F636 RID: 63030 RVA: 0x0016CCFC File Offset: 0x0016AEFC
		// (set) Token: 0x0600F637 RID: 63031 RVA: 0x0016CD0C File Offset: 0x0016AF0C
		public unsafe int CaptureMaxRTSizeXScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureMaxRTSizeXScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureMaxRTSizeXScale) = value;
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x0600F638 RID: 63032 RVA: 0x0016CD1D File Offset: 0x0016AF1D
		// (set) Token: 0x0600F639 RID: 63033 RVA: 0x0016CD2D File Offset: 0x0016AF2D
		public unsafe int CaptureMaxRTSizeYScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureMaxRTSizeYScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_CaptureMaxRTSizeYScale) = value;
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0600F63A RID: 63034 RVA: 0x0016CD3E File Offset: 0x0016AF3E
		// (set) Token: 0x0600F63B RID: 63035 RVA: 0x0016CD4E File Offset: 0x0016AF4E
		public unsafe float MaxViewDistanceOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_MaxViewDistanceOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_MaxViewDistanceOverride) = value;
			}
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0600F63C RID: 63036 RVA: 0x0016CD5F File Offset: 0x0016AF5F
		// (set) Token: 0x0600F63D RID: 63037 RVA: 0x0016CD78 File Offset: 0x0016AF78
		public unsafe bool bEnableCapture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bEnableCapture) & FSceneCaptureComponent2DParams.__PropertyMask_bEnableCapture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bEnableCapture) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bEnableCapture) & ~FSceneCaptureComponent2DParams.__PropertyMask_bEnableCapture) | (value ? FSceneCaptureComponent2DParams.__PropertyMask_bEnableCapture : 0));
			}
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0600F63E RID: 63038 RVA: 0x0016CDA8 File Offset: 0x0016AFA8
		// (set) Token: 0x0600F63F RID: 63039 RVA: 0x0016CDC1 File Offset: 0x0016AFC1
		public unsafe bool bCaptureSkeletal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureSkeletal) & FSceneCaptureComponent2DParams.__PropertyMask_bCaptureSkeletal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureSkeletal) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureSkeletal) & ~FSceneCaptureComponent2DParams.__PropertyMask_bCaptureSkeletal) | (value ? FSceneCaptureComponent2DParams.__PropertyMask_bCaptureSkeletal : 0));
			}
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x0600F640 RID: 63040 RVA: 0x0016CDF1 File Offset: 0x0016AFF1
		// (set) Token: 0x0600F641 RID: 63041 RVA: 0x0016CE0A File Offset: 0x0016B00A
		public unsafe bool bCaptureDynamicShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureDynamicShadows) & FSceneCaptureComponent2DParams.__PropertyMask_bCaptureDynamicShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureDynamicShadows) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureDynamicShadows) & ~FSceneCaptureComponent2DParams.__PropertyMask_bCaptureDynamicShadows) | (value ? FSceneCaptureComponent2DParams.__PropertyMask_bCaptureDynamicShadows : 0));
			}
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0600F642 RID: 63042 RVA: 0x0016CE3A File Offset: 0x0016B03A
		// (set) Token: 0x0600F643 RID: 63043 RVA: 0x0016CE53 File Offset: 0x0016B053
		public unsafe bool bCaptureParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureParticles) & FSceneCaptureComponent2DParams.__PropertyMask_bCaptureParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureParticles) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParams.__PropertyOffset_bCaptureParticles) & ~FSceneCaptureComponent2DParams.__PropertyMask_bCaptureParticles) | (value ? FSceneCaptureComponent2DParams.__PropertyMask_bCaptureParticles : 0));
			}
		}

		// Token: 0x0600F644 RID: 63044 RVA: 0x0016CE83 File Offset: 0x0016B083
		public FSceneCaptureComponent2DParams()
		{
		}

		// Token: 0x0600F645 RID: 63045 RVA: 0x0016CE8C File Offset: 0x0016B08C
		public FSceneCaptureComponent2DParams(float CaptureInterval, int CaptureMaxRTSize, int CaptureMaxRTSizeXScale, int CaptureMaxRTSizeYScale, float MaxViewDistanceOverride, bool bEnableCapture, bool bCaptureSkeletal, bool bCaptureDynamicShadows, bool bCaptureParticles)
		{
			this.CaptureInterval = CaptureInterval;
			this.CaptureMaxRTSize = CaptureMaxRTSize;
			this.CaptureMaxRTSizeXScale = CaptureMaxRTSizeXScale;
			this.CaptureMaxRTSizeYScale = CaptureMaxRTSizeYScale;
			this.MaxViewDistanceOverride = MaxViewDistanceOverride;
			this.bEnableCapture = bEnableCapture;
			this.bCaptureSkeletal = bCaptureSkeletal;
			this.bCaptureDynamicShadows = bCaptureDynamicShadows;
			this.bCaptureParticles = bCaptureParticles;
		}

		// Token: 0x0600F646 RID: 63046 RVA: 0x0016CEE4 File Offset: 0x0016B0E4
		protected override IntPtr GetUStructPtr()
		{
			return FSceneCaptureComponent2DParams.StaticStruct();
		}

		// Token: 0x0600F647 RID: 63047 RVA: 0x0016CEF0 File Offset: 0x0016B0F0
		[NullableContext(2)]
		public FSceneCaptureComponent2DParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F648 RID: 63048 RVA: 0x0016CEFA File Offset: 0x0016B0FA
		public FSceneCaptureComponent2DParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F649 RID: 63049 RVA: 0x0016CF05 File Offset: 0x0016B105
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneCaptureComponent2DParams(Pointer, false, true);
		}

		// Token: 0x0600F64A RID: 63050 RVA: 0x0016CF0F File Offset: 0x0016B10F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneCaptureComponent2DParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400855C RID: 34140
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SceneCaptureComponent2DParams";

		// Token: 0x0400855D RID: 34141
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400855E RID: 34142
		internal static int __PropertyOffset_CaptureInterval;

		// Token: 0x0400855F RID: 34143
		internal static int __PropertyOffset_CaptureMaxRTSize;

		// Token: 0x04008560 RID: 34144
		internal static int __PropertyOffset_CaptureMaxRTSizeXScale;

		// Token: 0x04008561 RID: 34145
		internal static int __PropertyOffset_CaptureMaxRTSizeYScale;

		// Token: 0x04008562 RID: 34146
		internal static int __PropertyOffset_MaxViewDistanceOverride;

		// Token: 0x04008563 RID: 34147
		internal static int __PropertyOffset_bEnableCapture;

		// Token: 0x04008564 RID: 34148
		internal static byte __PropertyMask_bEnableCapture;

		// Token: 0x04008565 RID: 34149
		internal static int __PropertyOffset_bCaptureSkeletal;

		// Token: 0x04008566 RID: 34150
		internal static byte __PropertyMask_bCaptureSkeletal;

		// Token: 0x04008567 RID: 34151
		internal static int __PropertyOffset_bCaptureDynamicShadows;

		// Token: 0x04008568 RID: 34152
		internal static byte __PropertyMask_bCaptureDynamicShadows;

		// Token: 0x04008569 RID: 34153
		internal static int __PropertyOffset_bCaptureParticles;

		// Token: 0x0400856A RID: 34154
		internal static byte __PropertyMask_bCaptureParticles;
	}
}
