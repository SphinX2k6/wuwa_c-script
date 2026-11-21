using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000278 RID: 632
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponent2DParams")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSceneCaptureComponent2DParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060040E4 RID: 16612 RVA: 0x0005D1C9 File Offset: 0x0005B3C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneCaptureComponent2DParams._ScriptStructPtr != 0) ? FSceneCaptureComponent2DParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SceneCaptureComponent2DParams", ref FSceneCaptureComponent2DParams._ScriptStructPtr);
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060040E5 RID: 16613 RVA: 0x0005D1ED File Offset: 0x0005B3ED
		// (set) Token: 0x060040E6 RID: 16614 RVA: 0x0005D1FD File Offset: 0x0005B3FD
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060040E7 RID: 16615 RVA: 0x0005D20E File Offset: 0x0005B40E
		// (set) Token: 0x060040E8 RID: 16616 RVA: 0x0005D21E File Offset: 0x0005B41E
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

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x0005D22F File Offset: 0x0005B42F
		// (set) Token: 0x060040EA RID: 16618 RVA: 0x0005D23F File Offset: 0x0005B43F
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

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060040EB RID: 16619 RVA: 0x0005D250 File Offset: 0x0005B450
		// (set) Token: 0x060040EC RID: 16620 RVA: 0x0005D260 File Offset: 0x0005B460
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

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x0005D271 File Offset: 0x0005B471
		// (set) Token: 0x060040EE RID: 16622 RVA: 0x0005D281 File Offset: 0x0005B481
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

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x0005D292 File Offset: 0x0005B492
		// (set) Token: 0x060040F0 RID: 16624 RVA: 0x0005D2AB File Offset: 0x0005B4AB
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

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x0005D2DB File Offset: 0x0005B4DB
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x0005D2F4 File Offset: 0x0005B4F4
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

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x0005D324 File Offset: 0x0005B524
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x0005D33D File Offset: 0x0005B53D
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

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x0005D36D File Offset: 0x0005B56D
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x0005D386 File Offset: 0x0005B586
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

		// Token: 0x060040F7 RID: 16631 RVA: 0x0005D3B6 File Offset: 0x0005B5B6
		public FSceneCaptureComponent2DParams()
		{
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x0005D3BE File Offset: 0x0005B5BE
		protected override IntPtr GetUStructPtr()
		{
			return FSceneCaptureComponent2DParams.StaticStruct();
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x0005D3CA File Offset: 0x0005B5CA
		[NullableContext(2)]
		public FSceneCaptureComponent2DParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0005D3D4 File Offset: 0x0005B5D4
		public FSceneCaptureComponent2DParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0005D3DF File Offset: 0x0005B5DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneCaptureComponent2DParams(Pointer, false, true);
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x0005D3E9 File Offset: 0x0005B5E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneCaptureComponent2DParams(Pointer, MemoryOwner);
		}

		// Token: 0x04001981 RID: 6529
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SceneCaptureComponent2DParams";

		// Token: 0x04001982 RID: 6530
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001983 RID: 6531
		internal static int __PropertyOffset_CaptureInterval;

		// Token: 0x04001984 RID: 6532
		internal static int __PropertyOffset_CaptureMaxRTSize;

		// Token: 0x04001985 RID: 6533
		internal static int __PropertyOffset_CaptureMaxRTSizeXScale;

		// Token: 0x04001986 RID: 6534
		internal static int __PropertyOffset_CaptureMaxRTSizeYScale;

		// Token: 0x04001987 RID: 6535
		internal static int __PropertyOffset_MaxViewDistanceOverride;

		// Token: 0x04001988 RID: 6536
		internal static int __PropertyOffset_bEnableCapture;

		// Token: 0x04001989 RID: 6537
		internal static byte __PropertyMask_bEnableCapture;

		// Token: 0x0400198A RID: 6538
		internal static int __PropertyOffset_bCaptureSkeletal;

		// Token: 0x0400198B RID: 6539
		internal static byte __PropertyMask_bCaptureSkeletal;

		// Token: 0x0400198C RID: 6540
		internal static int __PropertyOffset_bCaptureDynamicShadows;

		// Token: 0x0400198D RID: 6541
		internal static byte __PropertyMask_bCaptureDynamicShadows;

		// Token: 0x0400198E RID: 6542
		internal static int __PropertyOffset_bCaptureParticles;

		// Token: 0x0400198F RID: 6543
		internal static byte __PropertyMask_bCaptureParticles;
	}
}
