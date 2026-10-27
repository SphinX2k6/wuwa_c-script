using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200161F RID: 5663
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_SimpleDCC")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 488)]
	public class FAnimNode_SimpleDCC : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014792 RID: 83858 RVA: 0x001E1D00 File Offset: 0x001DFF00
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SimpleDCC._ScriptStructPtr != 0) ? FAnimNode_SimpleDCC._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_SimpleDCC", ref FAnimNode_SimpleDCC._ScriptStructPtr);
		}

		// Token: 0x1700508F RID: 20623
		// (get) Token: 0x06014793 RID: 83859 RVA: 0x001E1D24 File Offset: 0x001DFF24
		// (set) Token: 0x06014794 RID: 83860 RVA: 0x001E1D67 File Offset: 0x001DFF67
		public TArray<FSimpleDCCConfig> FSimpleDCCConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSimpleDCCConfig> result;
				if ((result = this._FSimpleDCCConfigs) == null)
				{
					result = (this._FSimpleDCCConfigs = new TArray<FSimpleDCCConfig>(base.NativePtr + (IntPtr)FAnimNode_SimpleDCC.__PropertyOffset_FSimpleDCCConfigs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FSimpleDCCConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17005090 RID: 20624
		// (get) Token: 0x06014795 RID: 83861 RVA: 0x001E1D75 File Offset: 0x001DFF75
		// (set) Token: 0x06014796 RID: 83862 RVA: 0x001E1D85 File Offset: 0x001DFF85
		public unsafe bool bAdditiveMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SimpleDCC.__PropertyOffset_bAdditiveMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SimpleDCC.__PropertyOffset_bAdditiveMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014797 RID: 83863 RVA: 0x001E1D96 File Offset: 0x001DFF96
		public FAnimNode_SimpleDCC()
		{
		}

		// Token: 0x06014798 RID: 83864 RVA: 0x001E1DA0 File Offset: 0x001DFFA0
		public FAnimNode_SimpleDCC(TArray<FSimpleDCCConfig> FSimpleDCCConfigs, bool bAdditiveMode, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.FSimpleDCCConfigs = FSimpleDCCConfigs;
			this.bAdditiveMode = bAdditiveMode;
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

		// Token: 0x06014799 RID: 83865 RVA: 0x001E1E28 File Offset: 0x001E0028
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SimpleDCC.StaticStruct();
		}

		// Token: 0x0601479A RID: 83866 RVA: 0x001E1E34 File Offset: 0x001E0034
		[NullableContext(2)]
		public FAnimNode_SimpleDCC(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601479B RID: 83867 RVA: 0x001E1E3E File Offset: 0x001E003E
		public FAnimNode_SimpleDCC(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601479C RID: 83868 RVA: 0x001E1E49 File Offset: 0x001E0049
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SimpleDCC(Pointer, false, true);
		}

		// Token: 0x0601479D RID: 83869 RVA: 0x001E1E53 File Offset: 0x001E0053
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SimpleDCC(Pointer, MemoryOwner);
		}

		// Token: 0x0400B22C RID: 45612
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_SimpleDCC";

		// Token: 0x0400B22D RID: 45613
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B22E RID: 45614
		internal static int __PropertyOffset_FSimpleDCCConfigs;

		// Token: 0x0400B22F RID: 45615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSimpleDCCConfig> _FSimpleDCCConfigs;

		// Token: 0x0400B230 RID: 45616
		internal static int __PropertyOffset_bAdditiveMode;
	}
}
