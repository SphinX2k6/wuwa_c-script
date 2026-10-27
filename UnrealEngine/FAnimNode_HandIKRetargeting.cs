using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E2 RID: 738
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_HandIKRetargeting")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class FAnimNode_HandIKRetargeting : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060029CC RID: 10700 RVA: 0x0003F484 File Offset: 0x0003D684
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_HandIKRetargeting._ScriptStructPtr != 0) ? FAnimNode_HandIKRetargeting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_HandIKRetargeting", ref FAnimNode_HandIKRetargeting._ScriptStructPtr);
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x0003F4A8 File Offset: 0x0003D6A8
		// (set) Token: 0x060029CE RID: 10702 RVA: 0x0003F4EB File Offset: 0x0003D6EB
		public FBoneReference RightHandFK
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RightHandFK) == null)
				{
					result = (this._RightHandFK = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_RightHandFK, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_RightHandFK, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x0003F50C File Offset: 0x0003D70C
		// (set) Token: 0x060029D0 RID: 10704 RVA: 0x0003F54F File Offset: 0x0003D74F
		public FBoneReference LeftHandFK
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._LeftHandFK) == null)
				{
					result = (this._LeftHandFK = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_LeftHandFK, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_LeftHandFK, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x0003F570 File Offset: 0x0003D770
		// (set) Token: 0x060029D2 RID: 10706 RVA: 0x0003F5B3 File Offset: 0x0003D7B3
		public FBoneReference RightHandIK
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RightHandIK) == null)
				{
					result = (this._RightHandIK = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_RightHandIK, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_RightHandIK, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x0003F617 File Offset: 0x0003D817
		public FBoneReference LeftHandIK
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._LeftHandIK) == null)
				{
					result = (this._LeftHandIK = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_LeftHandIK, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_LeftHandIK, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x0003F638 File Offset: 0x0003D838
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x0003F67B File Offset: 0x0003D87B
		public TArray<FBoneReference> IKBonesToMove
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._IKBonesToMove) == null)
				{
					result = (this._IKBonesToMove = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_IKBonesToMove, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IKBonesToMove.CopyAssign(value);
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x0003F689 File Offset: 0x0003D889
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x0003F699 File Offset: 0x0003D899
		public unsafe float HandFKWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_HandFKWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HandIKRetargeting.__PropertyOffset_HandFKWeight) = value;
			}
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x0003F6AA File Offset: 0x0003D8AA
		public FAnimNode_HandIKRetargeting()
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x0003F6B4 File Offset: 0x0003D8B4
		public FAnimNode_HandIKRetargeting(FBoneReference RightHandFK, FBoneReference LeftHandFK, FBoneReference RightHandIK, FBoneReference LeftHandIK, TArray<FBoneReference> IKBonesToMove, float HandFKWeight, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.RightHandFK = RightHandFK;
			this.LeftHandFK = LeftHandFK;
			this.RightHandIK = RightHandIK;
			this.LeftHandIK = LeftHandIK;
			this.IKBonesToMove = IKBonesToMove;
			this.HandFKWeight = HandFKWeight;
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

		// Token: 0x060029DB RID: 10715 RVA: 0x0003F75C File Offset: 0x0003D95C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_HandIKRetargeting.StaticStruct();
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x0003F768 File Offset: 0x0003D968
		[NullableContext(2)]
		public FAnimNode_HandIKRetargeting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x0003F772 File Offset: 0x0003D972
		public FAnimNode_HandIKRetargeting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x0003F77D File Offset: 0x0003D97D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_HandIKRetargeting(Pointer, false, true);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x0003F787 File Offset: 0x0003D987
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_HandIKRetargeting(Pointer, MemoryOwner);
		}

		// Token: 0x040010D4 RID: 4308
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_HandIKRetargeting";

		// Token: 0x040010D5 RID: 4309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010D6 RID: 4310
		internal static int __PropertyOffset_RightHandFK;

		// Token: 0x040010D7 RID: 4311
		[Nullable(2)]
		private FBoneReference _RightHandFK;

		// Token: 0x040010D8 RID: 4312
		internal static int __PropertyOffset_LeftHandFK;

		// Token: 0x040010D9 RID: 4313
		[Nullable(2)]
		private FBoneReference _LeftHandFK;

		// Token: 0x040010DA RID: 4314
		internal static int __PropertyOffset_RightHandIK;

		// Token: 0x040010DB RID: 4315
		[Nullable(2)]
		private FBoneReference _RightHandIK;

		// Token: 0x040010DC RID: 4316
		internal static int __PropertyOffset_LeftHandIK;

		// Token: 0x040010DD RID: 4317
		[Nullable(2)]
		private FBoneReference _LeftHandIK;

		// Token: 0x040010DE RID: 4318
		internal static int __PropertyOffset_IKBonesToMove;

		// Token: 0x040010DF RID: 4319
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _IKBonesToMove;

		// Token: 0x040010E0 RID: 4320
		internal static int __PropertyOffset_HandFKWeight;
	}
}
