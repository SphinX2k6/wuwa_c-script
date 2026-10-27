using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CD RID: 717
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 512)]
	public class FAnimNode_AimOffsetLookAt : FAnimNode_BlendSpacePlayer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060027BE RID: 10174 RVA: 0x0003B8C8 File Offset: 0x00039AC8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_AimOffsetLookAt._ScriptStructPtr != 0) ? FAnimNode_AimOffsetLookAt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt", ref FAnimNode_AimOffsetLookAt._ScriptStructPtr);
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x0003B8EC File Offset: 0x00039AEC
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x0003B92F File Offset: 0x00039B2F
		public FPoseLink BasePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._BasePose) == null)
				{
					result = (this._BasePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_BasePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_BasePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x0003B950 File Offset: 0x00039B50
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x0003B960 File Offset: 0x00039B60
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x0003B971 File Offset: 0x00039B71
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x0003B985 File Offset: 0x00039B85
		public unsafe FName SourceSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_SourceSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_SourceSocketName) = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x0003B99A File Offset: 0x00039B9A
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x0003B9AE File Offset: 0x00039BAE
		public unsafe FName PivotSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_PivotSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_PivotSocketName) = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x0003B9C3 File Offset: 0x00039BC3
		// (set) Token: 0x060027C8 RID: 10184 RVA: 0x0003B9D7 File Offset: 0x00039BD7
		public unsafe FVector LookAtLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_LookAtLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_LookAtLocation) = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x0003B9EC File Offset: 0x00039BEC
		// (set) Token: 0x060027CA RID: 10186 RVA: 0x0003BA00 File Offset: 0x00039C00
		public unsafe FVector SocketAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_SocketAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_SocketAxis) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x0003BA15 File Offset: 0x00039C15
		// (set) Token: 0x060027CC RID: 10188 RVA: 0x0003BA25 File Offset: 0x00039C25
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AimOffsetLookAt.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0003BA36 File Offset: 0x00039C36
		public FAnimNode_AimOffsetLookAt()
		{
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0003BA40 File Offset: 0x00039C40
		public FAnimNode_AimOffsetLookAt(FPoseLink BasePose, int LODThreshold, FName SourceSocketName, FName PivotSocketName, FVector LookAtLocation, FVector SocketAxis, float Alpha, float X, float Y, float Z, float PlayRate, bool bLoop, bool bResetPlayTimeWhenBlendSpaceChanges, float StartPosition, UBlendSpaceBase BlendSpace, bool bLockInput, EKuroBlendSpaceLockInputType LockInputType, UBlendSpaceBase PreviousBlendSpace, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.BasePose = BasePose;
			this.LODThreshold = LODThreshold;
			this.SourceSocketName = SourceSocketName;
			this.PivotSocketName = PivotSocketName;
			this.LookAtLocation = LookAtLocation;
			this.SocketAxis = SocketAxis;
			this.Alpha = Alpha;
			base.X = X;
			base.Y = Y;
			base.Z = Z;
			base.PlayRate = PlayRate;
			base.bLoop = bLoop;
			base.bResetPlayTimeWhenBlendSpaceChanges = bResetPlayTimeWhenBlendSpaceChanges;
			base.StartPosition = StartPosition;
			base.BlendSpace = BlendSpace;
			base.bLockInput = bLockInput;
			base.LockInputType = LockInputType;
			base.PreviousBlendSpace = PreviousBlendSpace;
			base.GroupName = GroupName;
			base.GroupRole = GroupRole;
			base.GroupScope = GroupScope;
			base.bIgnoreForRelevancyTest = bIgnoreForRelevancyTest;
			base.BlendWeight = BlendWeight;
			base.InternalTimeAccumulator = InternalTimeAccumulator;
			base.CachedSequenceLength = CachedSequenceLength;
			base.CachedRateScale = CachedRateScale;
			base.bUseSoftRef = bUseSoftRef;
			base.AnimationName = AnimationName;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x0003BB30 File Offset: 0x00039D30
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_AimOffsetLookAt.StaticStruct();
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x0003BB3C File Offset: 0x00039D3C
		[NullableContext(2)]
		public FAnimNode_AimOffsetLookAt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0003BB46 File Offset: 0x00039D46
		public FAnimNode_AimOffsetLookAt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0003BB51 File Offset: 0x00039D51
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_AimOffsetLookAt(Pointer, false, true);
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0003BB5B File Offset: 0x00039D5B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_AimOffsetLookAt(Pointer, MemoryOwner);
		}

		// Token: 0x04000FAE RID: 4014
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt";

		// Token: 0x04000FAF RID: 4015
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000FB0 RID: 4016
		internal static int __PropertyOffset_BasePose;

		// Token: 0x04000FB1 RID: 4017
		[Nullable(2)]
		private FPoseLink _BasePose;

		// Token: 0x04000FB2 RID: 4018
		internal static int __PropertyOffset_LODThreshold;

		// Token: 0x04000FB3 RID: 4019
		internal static int __PropertyOffset_SourceSocketName;

		// Token: 0x04000FB4 RID: 4020
		internal static int __PropertyOffset_PivotSocketName;

		// Token: 0x04000FB5 RID: 4021
		internal static int __PropertyOffset_LookAtLocation;

		// Token: 0x04000FB6 RID: 4022
		internal static int __PropertyOffset_SocketAxis;

		// Token: 0x04000FB7 RID: 4023
		internal static int __PropertyOffset_Alpha;
	}
}
