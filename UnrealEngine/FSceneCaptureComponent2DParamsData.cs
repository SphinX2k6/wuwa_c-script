using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010D6 RID: 4310
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponent2DParamsData")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSceneCaptureComponent2DParamsData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F64B RID: 63051 RVA: 0x0016CF18 File Offset: 0x0016B118
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneCaptureComponent2DParamsData._ScriptStructPtr != 0) ? FSceneCaptureComponent2DParamsData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SceneCaptureComponent2DParamsData", ref FSceneCaptureComponent2DParamsData._ScriptStructPtr);
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0600F64C RID: 63052 RVA: 0x0016CF3C File Offset: 0x0016B13C
		// (set) Token: 0x0600F64D RID: 63053 RVA: 0x0016CF4C File Offset: 0x0016B14C
		public unsafe float CaptureInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureInterval) = value;
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0600F64E RID: 63054 RVA: 0x0016CF5D File Offset: 0x0016B15D
		// (set) Token: 0x0600F64F RID: 63055 RVA: 0x0016CF6D File Offset: 0x0016B16D
		public unsafe int CaptureMaxRTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureMaxRTSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureMaxRTSize) = value;
			}
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0600F650 RID: 63056 RVA: 0x0016CF7E File Offset: 0x0016B17E
		// (set) Token: 0x0600F651 RID: 63057 RVA: 0x0016CF8E File Offset: 0x0016B18E
		public unsafe int CaptureMaxRTSizeXScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureMaxRTSizeXScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureMaxRTSizeXScale) = value;
			}
		}

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x0600F652 RID: 63058 RVA: 0x0016CF9F File Offset: 0x0016B19F
		// (set) Token: 0x0600F653 RID: 63059 RVA: 0x0016CFAF File Offset: 0x0016B1AF
		public unsafe int CaptureMaxRTSizeYScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureMaxRTSizeYScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_CaptureMaxRTSizeYScale) = value;
			}
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x0600F654 RID: 63060 RVA: 0x0016CFC0 File Offset: 0x0016B1C0
		// (set) Token: 0x0600F655 RID: 63061 RVA: 0x0016CFD0 File Offset: 0x0016B1D0
		public unsafe float MaxViewDistanceOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_MaxViewDistanceOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_MaxViewDistanceOverride) = value;
			}
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x0600F656 RID: 63062 RVA: 0x0016CFE1 File Offset: 0x0016B1E1
		// (set) Token: 0x0600F657 RID: 63063 RVA: 0x0016CFFA File Offset: 0x0016B1FA
		public unsafe bool bEnableCapture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bEnableCapture) & FSceneCaptureComponent2DParamsData.__PropertyMask_bEnableCapture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bEnableCapture) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bEnableCapture) & ~FSceneCaptureComponent2DParamsData.__PropertyMask_bEnableCapture) | (value ? FSceneCaptureComponent2DParamsData.__PropertyMask_bEnableCapture : 0));
			}
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0600F658 RID: 63064 RVA: 0x0016D02A File Offset: 0x0016B22A
		// (set) Token: 0x0600F659 RID: 63065 RVA: 0x0016D043 File Offset: 0x0016B243
		public unsafe bool bCaptureSkeletal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureSkeletal) & FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureSkeletal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureSkeletal) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureSkeletal) & ~FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureSkeletal) | (value ? FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureSkeletal : 0));
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x0600F65A RID: 63066 RVA: 0x0016D073 File Offset: 0x0016B273
		// (set) Token: 0x0600F65B RID: 63067 RVA: 0x0016D08C File Offset: 0x0016B28C
		public unsafe bool bCaptureDynamicShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureDynamicShadows) & FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureDynamicShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureDynamicShadows) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureDynamicShadows) & ~FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureDynamicShadows) | (value ? FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureDynamicShadows : 0));
			}
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x0600F65C RID: 63068 RVA: 0x0016D0BC File Offset: 0x0016B2BC
		// (set) Token: 0x0600F65D RID: 63069 RVA: 0x0016D0D5 File Offset: 0x0016B2D5
		public unsafe bool bCaptureParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureParticles) & FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureParticles) = ((*(base.NativePtr + (IntPtr)FSceneCaptureComponent2DParamsData.__PropertyOffset_bCaptureParticles) & ~FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureParticles) | (value ? FSceneCaptureComponent2DParamsData.__PropertyMask_bCaptureParticles : 0));
			}
		}

		// Token: 0x0600F65E RID: 63070 RVA: 0x0016D105 File Offset: 0x0016B305
		public FSceneCaptureComponent2DParamsData()
		{
		}

		// Token: 0x0600F65F RID: 63071 RVA: 0x0016D110 File Offset: 0x0016B310
		public FSceneCaptureComponent2DParamsData(float CaptureInterval, int CaptureMaxRTSize, int CaptureMaxRTSizeXScale, int CaptureMaxRTSizeYScale, float MaxViewDistanceOverride, bool bEnableCapture, bool bCaptureSkeletal, bool bCaptureDynamicShadows, bool bCaptureParticles)
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

		// Token: 0x0600F660 RID: 63072 RVA: 0x0016D168 File Offset: 0x0016B368
		protected override IntPtr GetUStructPtr()
		{
			return FSceneCaptureComponent2DParamsData.StaticStruct();
		}

		// Token: 0x0600F661 RID: 63073 RVA: 0x0016D174 File Offset: 0x0016B374
		[NullableContext(2)]
		public FSceneCaptureComponent2DParamsData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F662 RID: 63074 RVA: 0x0016D17E File Offset: 0x0016B37E
		public FSceneCaptureComponent2DParamsData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F663 RID: 63075 RVA: 0x0016D189 File Offset: 0x0016B389
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneCaptureComponent2DParamsData(Pointer, false, true);
		}

		// Token: 0x0600F664 RID: 63076 RVA: 0x0016D193 File Offset: 0x0016B393
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneCaptureComponent2DParamsData(Pointer, MemoryOwner);
		}

		// Token: 0x0400856B RID: 34155
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SceneCaptureComponent2DParamsData";

		// Token: 0x0400856C RID: 34156
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400856D RID: 34157
		internal static int __PropertyOffset_CaptureInterval;

		// Token: 0x0400856E RID: 34158
		internal static int __PropertyOffset_CaptureMaxRTSize;

		// Token: 0x0400856F RID: 34159
		internal static int __PropertyOffset_CaptureMaxRTSizeXScale;

		// Token: 0x04008570 RID: 34160
		internal static int __PropertyOffset_CaptureMaxRTSizeYScale;

		// Token: 0x04008571 RID: 34161
		internal static int __PropertyOffset_MaxViewDistanceOverride;

		// Token: 0x04008572 RID: 34162
		internal static int __PropertyOffset_bEnableCapture;

		// Token: 0x04008573 RID: 34163
		internal static byte __PropertyMask_bEnableCapture;

		// Token: 0x04008574 RID: 34164
		internal static int __PropertyOffset_bCaptureSkeletal;

		// Token: 0x04008575 RID: 34165
		internal static byte __PropertyMask_bCaptureSkeletal;

		// Token: 0x04008576 RID: 34166
		internal static int __PropertyOffset_bCaptureDynamicShadows;

		// Token: 0x04008577 RID: 34167
		internal static byte __PropertyMask_bCaptureDynamicShadows;

		// Token: 0x04008578 RID: 34168
		internal static int __PropertyOffset_bCaptureParticles;

		// Token: 0x04008579 RID: 34169
		internal static byte __PropertyMask_bCaptureParticles;
	}
}
