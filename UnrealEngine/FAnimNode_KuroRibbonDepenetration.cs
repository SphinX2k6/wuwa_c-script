using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001616 RID: 5654
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroRibbonDepenetration")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 456)]
	public class FAnimNode_KuroRibbonDepenetration : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060146C0 RID: 83648 RVA: 0x001E06F4 File Offset: 0x001DE8F4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroRibbonDepenetration._ScriptStructPtr != 0) ? FAnimNode_KuroRibbonDepenetration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroRibbonDepenetration", ref FAnimNode_KuroRibbonDepenetration._ScriptStructPtr);
		}

		// Token: 0x1700504A RID: 20554
		// (get) Token: 0x060146C1 RID: 83649 RVA: 0x001E0718 File Offset: 0x001DE918
		// (set) Token: 0x060146C2 RID: 83650 RVA: 0x001E075B File Offset: 0x001DE95B
		[Nullable(1)]
		public TArray<FRibbonChainConfig> RibbonChains
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FRibbonChainConfig> result;
				if ((result = this._RibbonChains) == null)
				{
					result = (this._RibbonChains = new TArray<FRibbonChainConfig>(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_RibbonChains, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RibbonChains.CopyAssign(value);
			}
		}

		// Token: 0x1700504B RID: 20555
		// (get) Token: 0x060146C3 RID: 83651 RVA: 0x001E0769 File Offset: 0x001DE969
		// (set) Token: 0x060146C4 RID: 83652 RVA: 0x001E0779 File Offset: 0x001DE979
		public unsafe ERibbonDepenetrationDirectionType DetectDirectionType
		{
			get
			{
				return (ERibbonDepenetrationDirectionType)(*(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_DetectDirectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_DetectDirectionType) = (byte)value;
			}
		}

		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x060146C5 RID: 83653 RVA: 0x001E078A File Offset: 0x001DE98A
		// (set) Token: 0x060146C6 RID: 83654 RVA: 0x001E079E File Offset: 0x001DE99E
		public unsafe FVector DetectConfigVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_DetectConfigVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_DetectConfigVector) = value;
			}
		}

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x060146C7 RID: 83655 RVA: 0x001E07B3 File Offset: 0x001DE9B3
		// (set) Token: 0x060146C8 RID: 83656 RVA: 0x001E07C7 File Offset: 0x001DE9C7
		public unsafe TEnumAsByte<ETraceTypeQuery> TraceChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_TraceChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_TraceChannel) = value;
			}
		}

		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x060146C9 RID: 83657 RVA: 0x001E07DC File Offset: 0x001DE9DC
		// (set) Token: 0x060146CA RID: 83658 RVA: 0x001E07EC File Offset: 0x001DE9EC
		public unsafe float RecoverySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_RecoverySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_RecoverySpeed) = value;
			}
		}

		// Token: 0x1700504F RID: 20559
		// (get) Token: 0x060146CB RID: 83659 RVA: 0x001E07FD File Offset: 0x001DE9FD
		// (set) Token: 0x060146CC RID: 83660 RVA: 0x001E080D File Offset: 0x001DEA0D
		public unsafe bool bDebugDrawDetect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_bDebugDrawDetect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_bDebugDrawDetect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x060146CD RID: 83661 RVA: 0x001E081E File Offset: 0x001DEA1E
		// (set) Token: 0x060146CE RID: 83662 RVA: 0x001E082E File Offset: 0x001DEA2E
		public unsafe bool bDebugDrawChain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_bDebugDrawChain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroRibbonDepenetration.__PropertyOffset_bDebugDrawChain) = (value ? 1 : 0);
			}
		}

		// Token: 0x060146CF RID: 83663 RVA: 0x001E083F File Offset: 0x001DEA3F
		public FAnimNode_KuroRibbonDepenetration()
		{
		}

		// Token: 0x060146D0 RID: 83664 RVA: 0x001E0848 File Offset: 0x001DEA48
		[NullableContext(1)]
		public FAnimNode_KuroRibbonDepenetration(TArray<FRibbonChainConfig> RibbonChains, ERibbonDepenetrationDirectionType DetectDirectionType, FVector DetectConfigVector, [Nullable(0)] TEnumAsByte<ETraceTypeQuery> TraceChannel, float RecoverySpeed, bool bDebugDrawDetect, bool bDebugDrawChain, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.RibbonChains = RibbonChains;
			this.DetectDirectionType = DetectDirectionType;
			this.DetectConfigVector = DetectConfigVector;
			this.TraceChannel = TraceChannel;
			this.RecoverySpeed = RecoverySpeed;
			this.bDebugDrawDetect = bDebugDrawDetect;
			this.bDebugDrawChain = bDebugDrawChain;
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

		// Token: 0x060146D1 RID: 83665 RVA: 0x001E08F8 File Offset: 0x001DEAF8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroRibbonDepenetration.StaticStruct();
		}

		// Token: 0x060146D2 RID: 83666 RVA: 0x001E0904 File Offset: 0x001DEB04
		[NullableContext(2)]
		public FAnimNode_KuroRibbonDepenetration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060146D3 RID: 83667 RVA: 0x001E090E File Offset: 0x001DEB0E
		public FAnimNode_KuroRibbonDepenetration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060146D4 RID: 83668 RVA: 0x001E0919 File Offset: 0x001DEB19
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroRibbonDepenetration(Pointer, false, true);
		}

		// Token: 0x060146D5 RID: 83669 RVA: 0x001E0923 File Offset: 0x001DEB23
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroRibbonDepenetration(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1C6 RID: 45510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroRibbonDepenetration";

		// Token: 0x0400B1C7 RID: 45511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1C8 RID: 45512
		internal static int __PropertyOffset_RibbonChains;

		// Token: 0x0400B1C9 RID: 45513
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRibbonChainConfig> _RibbonChains;

		// Token: 0x0400B1CA RID: 45514
		internal static int __PropertyOffset_DetectDirectionType;

		// Token: 0x0400B1CB RID: 45515
		internal static int __PropertyOffset_DetectConfigVector;

		// Token: 0x0400B1CC RID: 45516
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x0400B1CD RID: 45517
		internal static int __PropertyOffset_RecoverySpeed;

		// Token: 0x0400B1CE RID: 45518
		internal static int __PropertyOffset_bDebugDrawDetect;

		// Token: 0x0400B1CF RID: 45519
		internal static int __PropertyOffset_bDebugDrawChain;
	}
}
