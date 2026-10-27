using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200160E RID: 5646
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroCacheBones")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class FAnimNode_KuroCacheBones : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014602 RID: 83458 RVA: 0x001DF2A8 File Offset: 0x001DD4A8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroCacheBones._ScriptStructPtr != 0) ? FAnimNode_KuroCacheBones._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroCacheBones", ref FAnimNode_KuroCacheBones._ScriptStructPtr);
		}

		// Token: 0x1700500B RID: 20491
		// (get) Token: 0x06014603 RID: 83459 RVA: 0x001DF2CC File Offset: 0x001DD4CC
		// (set) Token: 0x06014604 RID: 83460 RVA: 0x001DF30F File Offset: 0x001DD50F
		public TArray<FName> BoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoneNames) == null)
				{
					result = (this._BoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_KuroCacheBones.__PropertyOffset_BoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneNames.CopyAssign(value);
			}
		}

		// Token: 0x1700500C RID: 20492
		// (get) Token: 0x06014605 RID: 83461 RVA: 0x001DF31D File Offset: 0x001DD51D
		// (set) Token: 0x06014606 RID: 83462 RVA: 0x001DF32D File Offset: 0x001DD52D
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroCacheBones.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroCacheBones.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014607 RID: 83463 RVA: 0x001DF33E File Offset: 0x001DD53E
		public FAnimNode_KuroCacheBones()
		{
		}

		// Token: 0x06014608 RID: 83464 RVA: 0x001DF348 File Offset: 0x001DD548
		public FAnimNode_KuroCacheBones(TArray<FName> BoneNames, bool bEnable, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BoneNames = BoneNames;
			this.bEnable = bEnable;
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

		// Token: 0x06014609 RID: 83465 RVA: 0x001DF3D0 File Offset: 0x001DD5D0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroCacheBones.StaticStruct();
		}

		// Token: 0x0601460A RID: 83466 RVA: 0x001DF3DC File Offset: 0x001DD5DC
		[NullableContext(2)]
		public FAnimNode_KuroCacheBones(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601460B RID: 83467 RVA: 0x001DF3E6 File Offset: 0x001DD5E6
		public FAnimNode_KuroCacheBones(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601460C RID: 83468 RVA: 0x001DF3F1 File Offset: 0x001DD5F1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroCacheBones(Pointer, false, true);
		}

		// Token: 0x0601460D RID: 83469 RVA: 0x001DF3FB File Offset: 0x001DD5FB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroCacheBones(Pointer, MemoryOwner);
		}

		// Token: 0x0400B167 RID: 45415
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroCacheBones";

		// Token: 0x0400B168 RID: 45416
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B169 RID: 45417
		internal static int __PropertyOffset_BoneNames;

		// Token: 0x0400B16A RID: 45418
		[Nullable(2)]
		private TArray<FName> _BoneNames;

		// Token: 0x0400B16B RID: 45419
		internal static int __PropertyOffset_bEnable;
	}
}
