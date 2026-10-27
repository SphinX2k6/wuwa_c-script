using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001604 RID: 5636
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_BoneRotateToLocation")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 416)]
	public class FAnimNode_BoneRotateToLocation : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014502 RID: 83202 RVA: 0x001DD754 File Offset: 0x001DB954
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BoneRotateToLocation._ScriptStructPtr != 0) ? FAnimNode_BoneRotateToLocation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_BoneRotateToLocation", ref FAnimNode_BoneRotateToLocation._ScriptStructPtr);
		}

		// Token: 0x17004FB3 RID: 20403
		// (get) Token: 0x06014503 RID: 83203 RVA: 0x001DD778 File Offset: 0x001DB978
		// (set) Token: 0x06014504 RID: 83204 RVA: 0x001DD78C File Offset: 0x001DB98C
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17004FB4 RID: 20404
		// (get) Token: 0x06014505 RID: 83205 RVA: 0x001DD7A1 File Offset: 0x001DB9A1
		// (set) Token: 0x06014506 RID: 83206 RVA: 0x001DD7B1 File Offset: 0x001DB9B1
		public unsafe float TurnAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_TurnAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_TurnAngle) = value;
			}
		}

		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x06014507 RID: 83207 RVA: 0x001DD7C2 File Offset: 0x001DB9C2
		// (set) Token: 0x06014508 RID: 83208 RVA: 0x001DD7D2 File Offset: 0x001DB9D2
		public unsafe float LookUpAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_LookUpAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_LookUpAngle) = value;
			}
		}

		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x06014509 RID: 83209 RVA: 0x001DD7E3 File Offset: 0x001DB9E3
		// (set) Token: 0x0601450A RID: 83210 RVA: 0x001DD7F7 File Offset: 0x001DB9F7
		public unsafe FVector ForwardLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_ForwardLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_ForwardLocation) = value;
			}
		}

		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x0601450B RID: 83211 RVA: 0x001DD80C File Offset: 0x001DBA0C
		// (set) Token: 0x0601450C RID: 83212 RVA: 0x001DD820 File Offset: 0x001DBA20
		public unsafe FVector2D TurnLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_TurnLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_TurnLimit) = value;
			}
		}

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x0601450D RID: 83213 RVA: 0x001DD835 File Offset: 0x001DBA35
		// (set) Token: 0x0601450E RID: 83214 RVA: 0x001DD849 File Offset: 0x001DBA49
		public unsafe FVector2D LookUpLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_LookUpLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_LookUpLimit) = value;
			}
		}

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x0601450F RID: 83215 RVA: 0x001DD85E File Offset: 0x001DBA5E
		// (set) Token: 0x06014510 RID: 83216 RVA: 0x001DD86E File Offset: 0x001DBA6E
		public unsafe float LookUpOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_LookUpOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_LookUpOffset) = value;
			}
		}

		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x06014511 RID: 83217 RVA: 0x001DD87F File Offset: 0x001DBA7F
		// (set) Token: 0x06014512 RID: 83218 RVA: 0x001DD88F File Offset: 0x001DBA8F
		public unsafe float TurnUpOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_TurnUpOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_TurnUpOffset) = value;
			}
		}

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x06014513 RID: 83219 RVA: 0x001DD8A0 File Offset: 0x001DBAA0
		// (set) Token: 0x06014514 RID: 83220 RVA: 0x001DD8B0 File Offset: 0x001DBAB0
		public unsafe bool bRollBackToOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_bRollBackToOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_bRollBackToOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x06014515 RID: 83221 RVA: 0x001DD8C1 File Offset: 0x001DBAC1
		// (set) Token: 0x06014516 RID: 83222 RVA: 0x001DD8D1 File Offset: 0x001DBAD1
		public unsafe bool bStopRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_bStopRoll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_bStopRoll) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x06014517 RID: 83223 RVA: 0x001DD8E2 File Offset: 0x001DBAE2
		// (set) Token: 0x06014518 RID: 83224 RVA: 0x001DD8F2 File Offset: 0x001DBAF2
		public unsafe bool bDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_bDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneRotateToLocation.__PropertyOffset_bDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014519 RID: 83225 RVA: 0x001DD903 File Offset: 0x001DBB03
		public FAnimNode_BoneRotateToLocation()
		{
		}

		// Token: 0x0601451A RID: 83226 RVA: 0x001DD90C File Offset: 0x001DBB0C
		[NullableContext(1)]
		public FAnimNode_BoneRotateToLocation(FName BoneName, float TurnAngle, float LookUpAngle, FVector ForwardLocation, FVector2D TurnLimit, FVector2D LookUpLimit, float LookUpOffset, float TurnUpOffset, bool bRollBackToOrigin, bool bStopRoll, bool bDebug, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BoneName = BoneName;
			this.TurnAngle = TurnAngle;
			this.LookUpAngle = LookUpAngle;
			this.ForwardLocation = ForwardLocation;
			this.TurnLimit = TurnLimit;
			this.LookUpLimit = LookUpLimit;
			this.LookUpOffset = LookUpOffset;
			this.TurnUpOffset = TurnUpOffset;
			this.bRollBackToOrigin = bRollBackToOrigin;
			this.bStopRoll = bStopRoll;
			this.bDebug = bDebug;
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

		// Token: 0x0601451B RID: 83227 RVA: 0x001DD9DC File Offset: 0x001DBBDC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BoneRotateToLocation.StaticStruct();
		}

		// Token: 0x0601451C RID: 83228 RVA: 0x001DD9E8 File Offset: 0x001DBBE8
		[NullableContext(2)]
		public FAnimNode_BoneRotateToLocation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601451D RID: 83229 RVA: 0x001DD9F2 File Offset: 0x001DBBF2
		public FAnimNode_BoneRotateToLocation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601451E RID: 83230 RVA: 0x001DD9FD File Offset: 0x001DBBFD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BoneRotateToLocation(Pointer, false, true);
		}

		// Token: 0x0601451F RID: 83231 RVA: 0x001DDA07 File Offset: 0x001DBC07
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BoneRotateToLocation(Pointer, MemoryOwner);
		}

		// Token: 0x0400B0E0 RID: 45280
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_BoneRotateToLocation";

		// Token: 0x0400B0E1 RID: 45281
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B0E2 RID: 45282
		internal static int __PropertyOffset_BoneName;

		// Token: 0x0400B0E3 RID: 45283
		internal static int __PropertyOffset_TurnAngle;

		// Token: 0x0400B0E4 RID: 45284
		internal static int __PropertyOffset_LookUpAngle;

		// Token: 0x0400B0E5 RID: 45285
		internal static int __PropertyOffset_ForwardLocation;

		// Token: 0x0400B0E6 RID: 45286
		internal static int __PropertyOffset_TurnLimit;

		// Token: 0x0400B0E7 RID: 45287
		internal static int __PropertyOffset_LookUpLimit;

		// Token: 0x0400B0E8 RID: 45288
		internal static int __PropertyOffset_LookUpOffset;

		// Token: 0x0400B0E9 RID: 45289
		internal static int __PropertyOffset_TurnUpOffset;

		// Token: 0x0400B0EA RID: 45290
		internal static int __PropertyOffset_bRollBackToOrigin;

		// Token: 0x0400B0EB RID: 45291
		internal static int __PropertyOffset_bStopRoll;

		// Token: 0x0400B0EC RID: 45292
		internal static int __PropertyOffset_bDebug;
	}
}
