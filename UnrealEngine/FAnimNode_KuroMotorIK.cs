using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001614 RID: 5652
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroMotorIK")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 448)]
	public class FAnimNode_KuroMotorIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060146A4 RID: 83620 RVA: 0x001E03A0 File Offset: 0x001DE5A0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroMotorIK._ScriptStructPtr != 0) ? FAnimNode_KuroMotorIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroMotorIK", ref FAnimNode_KuroMotorIK._ScriptStructPtr);
		}

		// Token: 0x17005044 RID: 20548
		// (get) Token: 0x060146A5 RID: 83621 RVA: 0x001E03C4 File Offset: 0x001DE5C4
		// (set) Token: 0x060146A6 RID: 83622 RVA: 0x001E0407 File Offset: 0x001DE607
		public TArray<FKuroMotorWheelIkParams> MotorWheelIkParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMotorWheelIkParams> result;
				if ((result = this._MotorWheelIkParams) == null)
				{
					result = (this._MotorWheelIkParams = new TArray<FKuroMotorWheelIkParams>(base.NativePtr + (IntPtr)FAnimNode_KuroMotorIK.__PropertyOffset_MotorWheelIkParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MotorWheelIkParams.CopyAssign(value);
			}
		}

		// Token: 0x17005045 RID: 20549
		// (get) Token: 0x060146A7 RID: 83623 RVA: 0x001E0415 File Offset: 0x001DE615
		// (set) Token: 0x060146A8 RID: 83624 RVA: 0x001E0429 File Offset: 0x001DE629
		[Nullable(2)]
		public unsafe UMotorWheelDisplayInfoObject DisplayInfoObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMotorWheelDisplayInfoObject>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KuroMotorIK.__PropertyOffset_DisplayInfoObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KuroMotorIK.__PropertyOffset_DisplayInfoObject, value);
			}
		}

		// Token: 0x17005046 RID: 20550
		// (get) Token: 0x060146A9 RID: 83625 RVA: 0x001E043E File Offset: 0x001DE63E
		// (set) Token: 0x060146AA RID: 83626 RVA: 0x001E044E File Offset: 0x001DE64E
		public unsafe bool bSimulateDetect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroMotorIK.__PropertyOffset_bSimulateDetect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroMotorIK.__PropertyOffset_bSimulateDetect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005047 RID: 20551
		// (get) Token: 0x060146AB RID: 83627 RVA: 0x001E045F File Offset: 0x001DE65F
		// (set) Token: 0x060146AC RID: 83628 RVA: 0x001E0478 File Offset: 0x001DE678
		public unsafe bool DebugDraw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_KuroMotorIK.__PropertyOffset_DebugDraw) & FAnimNode_KuroMotorIK.__PropertyMask_DebugDraw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_KuroMotorIK.__PropertyOffset_DebugDraw) = ((*(base.NativePtr + (IntPtr)FAnimNode_KuroMotorIK.__PropertyOffset_DebugDraw) & ~FAnimNode_KuroMotorIK.__PropertyMask_DebugDraw) | (value ? FAnimNode_KuroMotorIK.__PropertyMask_DebugDraw : 0));
			}
		}

		// Token: 0x060146AD RID: 83629 RVA: 0x001E04A8 File Offset: 0x001DE6A8
		public FAnimNode_KuroMotorIK()
		{
		}

		// Token: 0x060146AE RID: 83630 RVA: 0x001E04B0 File Offset: 0x001DE6B0
		public FAnimNode_KuroMotorIK(TArray<FKuroMotorWheelIkParams> MotorWheelIkParams, UMotorWheelDisplayInfoObject DisplayInfoObject, bool bSimulateDetect, bool DebugDraw, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.MotorWheelIkParams = MotorWheelIkParams;
			this.DisplayInfoObject = DisplayInfoObject;
			this.bSimulateDetect = bSimulateDetect;
			this.DebugDraw = DebugDraw;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x060146AF RID: 83631 RVA: 0x001E0548 File Offset: 0x001DE748
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroMotorIK.StaticStruct();
		}

		// Token: 0x060146B0 RID: 83632 RVA: 0x001E0554 File Offset: 0x001DE754
		[NullableContext(2)]
		public FAnimNode_KuroMotorIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060146B1 RID: 83633 RVA: 0x001E055E File Offset: 0x001DE75E
		public FAnimNode_KuroMotorIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060146B2 RID: 83634 RVA: 0x001E0569 File Offset: 0x001DE769
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroMotorIK(Pointer, false, true);
		}

		// Token: 0x060146B3 RID: 83635 RVA: 0x001E0573 File Offset: 0x001DE773
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroMotorIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1B9 RID: 45497
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroMotorIK";

		// Token: 0x0400B1BA RID: 45498
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1BB RID: 45499
		internal static int __PropertyOffset_MotorWheelIkParams;

		// Token: 0x0400B1BC RID: 45500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMotorWheelIkParams> _MotorWheelIkParams;

		// Token: 0x0400B1BD RID: 45501
		internal static int __PropertyOffset_DisplayInfoObject;

		// Token: 0x0400B1BE RID: 45502
		internal static int __PropertyOffset_bSimulateDetect;

		// Token: 0x0400B1BF RID: 45503
		internal static int __PropertyOffset_DebugDraw;

		// Token: 0x0400B1C0 RID: 45504
		internal static byte __PropertyMask_DebugDraw;
	}
}
