using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001615 RID: 5653
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroQuadrupedIK")]
	[UnrealStructLayout(2080, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2080)]
	public class FAnimNode_KuroQuadrupedIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060146B4 RID: 83636 RVA: 0x001E057C File Offset: 0x001DE77C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroQuadrupedIK._ScriptStructPtr != 0) ? FAnimNode_KuroQuadrupedIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroQuadrupedIK", ref FAnimNode_KuroQuadrupedIK._ScriptStructPtr);
		}

		// Token: 0x17005048 RID: 20552
		// (get) Token: 0x060146B5 RID: 83637 RVA: 0x001E05A0 File Offset: 0x001DE7A0
		// (set) Token: 0x060146B6 RID: 83638 RVA: 0x001E05B4 File Offset: 0x001DE7B4
		[Nullable(2)]
		public unsafe UKuroQuadrupedIK_Settings SettingsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroQuadrupedIK_Settings>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KuroQuadrupedIK.__PropertyOffset_SettingsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KuroQuadrupedIK.__PropertyOffset_SettingsAsset, value);
			}
		}

		// Token: 0x17005049 RID: 20553
		// (get) Token: 0x060146B7 RID: 83639 RVA: 0x001E05CC File Offset: 0x001DE7CC
		// (set) Token: 0x060146B8 RID: 83640 RVA: 0x001E060F File Offset: 0x001DE80F
		public FKuroQuadrupedIK_InputData InputData
		{
			get
			{
				base.FastCheckIsValid();
				FKuroQuadrupedIK_InputData result;
				if ((result = this._InputData) == null)
				{
					result = (this._InputData = new FKuroQuadrupedIK_InputData(base.NativePtr + (IntPtr)FAnimNode_KuroQuadrupedIK.__PropertyOffset_InputData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroQuadrupedIK_InputData.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KuroQuadrupedIK.__PropertyOffset_InputData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060146B9 RID: 83641 RVA: 0x001E0630 File Offset: 0x001DE830
		public FAnimNode_KuroQuadrupedIK()
		{
		}

		// Token: 0x060146BA RID: 83642 RVA: 0x001E0638 File Offset: 0x001DE838
		public FAnimNode_KuroQuadrupedIK(UKuroQuadrupedIK_Settings SettingsAsset, FKuroQuadrupedIK_InputData InputData, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.SettingsAsset = SettingsAsset;
			this.InputData = InputData;
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

		// Token: 0x060146BB RID: 83643 RVA: 0x001E06C0 File Offset: 0x001DE8C0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroQuadrupedIK.StaticStruct();
		}

		// Token: 0x060146BC RID: 83644 RVA: 0x001E06CC File Offset: 0x001DE8CC
		[NullableContext(2)]
		public FAnimNode_KuroQuadrupedIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060146BD RID: 83645 RVA: 0x001E06D6 File Offset: 0x001DE8D6
		public FAnimNode_KuroQuadrupedIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060146BE RID: 83646 RVA: 0x001E06E1 File Offset: 0x001DE8E1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroQuadrupedIK(Pointer, false, true);
		}

		// Token: 0x060146BF RID: 83647 RVA: 0x001E06EB File Offset: 0x001DE8EB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroQuadrupedIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1C1 RID: 45505
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroQuadrupedIK";

		// Token: 0x0400B1C2 RID: 45506
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1C3 RID: 45507
		internal static int __PropertyOffset_SettingsAsset;

		// Token: 0x0400B1C4 RID: 45508
		internal static int __PropertyOffset_InputData;

		// Token: 0x0400B1C5 RID: 45509
		[Nullable(2)]
		private FKuroQuadrupedIK_InputData _InputData;
	}
}
