using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D7 RID: 727
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BlendSpacePlayer")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 280)]
	public class FAnimNode_BlendSpacePlayer : FAnimNode_AssetPlayerBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060028A6 RID: 10406 RVA: 0x0003D3B0 File Offset: 0x0003B5B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BlendSpacePlayer._ScriptStructPtr != 0) ? FAnimNode_BlendSpacePlayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BlendSpacePlayer", ref FAnimNode_BlendSpacePlayer._ScriptStructPtr);
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x0003D3D4 File Offset: 0x0003B5D4
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x0003D3E4 File Offset: 0x0003B5E4
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_X) = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x0003D3F5 File Offset: 0x0003B5F5
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x0003D405 File Offset: 0x0003B605
		public unsafe float Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_Y) = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0003D416 File Offset: 0x0003B616
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x0003D426 File Offset: 0x0003B626
		public unsafe float Z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_Z);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_Z) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0003D437 File Offset: 0x0003B637
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x0003D447 File Offset: 0x0003B647
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x0003D458 File Offset: 0x0003B658
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x0003D468 File Offset: 0x0003B668
		public unsafe bool bLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_bLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_bLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0003D479 File Offset: 0x0003B679
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0003D489 File Offset: 0x0003B689
		public unsafe bool bResetPlayTimeWhenBlendSpaceChanges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_bResetPlayTimeWhenBlendSpaceChanges) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_bResetPlayTimeWhenBlendSpaceChanges) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x0003D49A File Offset: 0x0003B69A
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x0003D4AA File Offset: 0x0003B6AA
		public unsafe float StartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_StartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_StartPosition) = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x0003D4BB File Offset: 0x0003B6BB
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x0003D4CF File Offset: 0x0003B6CF
		public unsafe UBlendSpaceBase BlendSpace
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlendSpaceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendSpacePlayer.__PropertyOffset_BlendSpace);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendSpacePlayer.__PropertyOffset_BlendSpace, value);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x0003D4F4 File Offset: 0x0003B6F4
		public unsafe bool bLockInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_bLockInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_bLockInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0003D505 File Offset: 0x0003B705
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x0003D515 File Offset: 0x0003B715
		public unsafe EKuroBlendSpaceLockInputType LockInputType
		{
			get
			{
				return (EKuroBlendSpaceLockInputType)(*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_LockInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendSpacePlayer.__PropertyOffset_LockInputType) = (byte)value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x0003D526 File Offset: 0x0003B726
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x0003D53A File Offset: 0x0003B73A
		public unsafe UBlendSpaceBase PreviousBlendSpace
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlendSpaceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendSpacePlayer.__PropertyOffset_PreviousBlendSpace);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendSpacePlayer.__PropertyOffset_PreviousBlendSpace, value);
			}
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0003D54F File Offset: 0x0003B74F
		public FAnimNode_BlendSpacePlayer()
		{
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0003D558 File Offset: 0x0003B758
		[NullableContext(1)]
		public FAnimNode_BlendSpacePlayer(float X, float Y, float Z, float PlayRate, bool bLoop, bool bResetPlayTimeWhenBlendSpaceChanges, float StartPosition, UBlendSpaceBase BlendSpace, bool bLockInput, EKuroBlendSpaceLockInputType LockInputType, UBlendSpaceBase PreviousBlendSpace, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.PlayRate = PlayRate;
			this.bLoop = bLoop;
			this.bResetPlayTimeWhenBlendSpaceChanges = bResetPlayTimeWhenBlendSpaceChanges;
			this.StartPosition = StartPosition;
			this.BlendSpace = BlendSpace;
			this.bLockInput = bLockInput;
			this.LockInputType = LockInputType;
			this.PreviousBlendSpace = PreviousBlendSpace;
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

		// Token: 0x060028BF RID: 10431 RVA: 0x0003D610 File Offset: 0x0003B810
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BlendSpacePlayer.StaticStruct();
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0003D61C File Offset: 0x0003B81C
		public FAnimNode_BlendSpacePlayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0003D626 File Offset: 0x0003B826
		public FAnimNode_BlendSpacePlayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0003D631 File Offset: 0x0003B831
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BlendSpacePlayer(Pointer, false, true);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0003D63B File Offset: 0x0003B83B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BlendSpacePlayer(Pointer, MemoryOwner);
		}

		// Token: 0x04001030 RID: 4144
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BlendSpacePlayer";

		// Token: 0x04001031 RID: 4145
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001032 RID: 4146
		internal static int __PropertyOffset_X;

		// Token: 0x04001033 RID: 4147
		internal static int __PropertyOffset_Y;

		// Token: 0x04001034 RID: 4148
		internal static int __PropertyOffset_Z;

		// Token: 0x04001035 RID: 4149
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04001036 RID: 4150
		internal static int __PropertyOffset_bLoop;

		// Token: 0x04001037 RID: 4151
		internal static int __PropertyOffset_bResetPlayTimeWhenBlendSpaceChanges;

		// Token: 0x04001038 RID: 4152
		internal static int __PropertyOffset_StartPosition;

		// Token: 0x04001039 RID: 4153
		internal static int __PropertyOffset_BlendSpace;

		// Token: 0x0400103A RID: 4154
		internal static int __PropertyOffset_bLockInput;

		// Token: 0x0400103B RID: 4155
		internal static int __PropertyOffset_LockInputType;

		// Token: 0x0400103C RID: 4156
		internal static int __PropertyOffset_PreviousBlendSpace;
	}
}
