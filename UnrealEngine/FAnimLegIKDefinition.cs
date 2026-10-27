using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CC RID: 716
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimLegIKDefinition")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FAnimLegIKDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x0003B675 File Offset: 0x00039875
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimLegIKDefinition._ScriptStructPtr != 0) ? FAnimLegIKDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimLegIKDefinition", ref FAnimLegIKDefinition._ScriptStructPtr);
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x0003B69C File Offset: 0x0003989C
		// (set) Token: 0x060027A8 RID: 10152 RVA: 0x0003B6DF File Offset: 0x000398DF
		[Nullable(1)]
		public FBoneReference IKFootBone
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IKFootBone) == null)
				{
					result = (this._IKFootBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_IKFootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_IKFootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x0003B700 File Offset: 0x00039900
		// (set) Token: 0x060027AA RID: 10154 RVA: 0x0003B743 File Offset: 0x00039943
		[Nullable(1)]
		public FBoneReference FKFootBone
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._FKFootBone) == null)
				{
					result = (this._FKFootBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_FKFootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_FKFootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x0003B764 File Offset: 0x00039964
		// (set) Token: 0x060027AC RID: 10156 RVA: 0x0003B774 File Offset: 0x00039974
		public unsafe int NumBonesInLimb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_NumBonesInLimb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_NumBonesInLimb) = value;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x0003B785 File Offset: 0x00039985
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x0003B795 File Offset: 0x00039995
		public unsafe float MinRotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_MinRotationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_MinRotationAngle) = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x0003B7A6 File Offset: 0x000399A6
		// (set) Token: 0x060027B0 RID: 10160 RVA: 0x0003B7BA File Offset: 0x000399BA
		public unsafe TEnumAsByte<EAxis> FootBoneForwardAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_FootBoneForwardAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_FootBoneForwardAxis) = value;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x0003B7CF File Offset: 0x000399CF
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x0003B7E3 File Offset: 0x000399E3
		public unsafe TEnumAsByte<EAxis> HingeRotationAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_HingeRotationAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_HingeRotationAxis) = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x0003B7F8 File Offset: 0x000399F8
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x0003B808 File Offset: 0x00039A08
		public unsafe bool bEnableRotationLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_bEnableRotationLimit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_bEnableRotationLimit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x0003B819 File Offset: 0x00039A19
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x0003B829 File Offset: 0x00039A29
		public unsafe bool bEnableKneeTwistCorrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_bEnableKneeTwistCorrection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLegIKDefinition.__PropertyOffset_bEnableKneeTwistCorrection) = (value ? 1 : 0);
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x0003B83A File Offset: 0x00039A3A
		public FAnimLegIKDefinition()
		{
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x0003B844 File Offset: 0x00039A44
		public FAnimLegIKDefinition([Nullable(1)] FBoneReference IKFootBone, [Nullable(1)] FBoneReference FKFootBone, int NumBonesInLimb, float MinRotationAngle, TEnumAsByte<EAxis> FootBoneForwardAxis, TEnumAsByte<EAxis> HingeRotationAxis, bool bEnableRotationLimit, bool bEnableKneeTwistCorrection)
		{
			this.IKFootBone = IKFootBone;
			this.FKFootBone = FKFootBone;
			this.NumBonesInLimb = NumBonesInLimb;
			this.MinRotationAngle = MinRotationAngle;
			this.FootBoneForwardAxis = FootBoneForwardAxis;
			this.HingeRotationAxis = HingeRotationAxis;
			this.bEnableRotationLimit = bEnableRotationLimit;
			this.bEnableKneeTwistCorrection = bEnableKneeTwistCorrection;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x0003B894 File Offset: 0x00039A94
		protected override IntPtr GetUStructPtr()
		{
			return FAnimLegIKDefinition.StaticStruct();
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x0003B8A0 File Offset: 0x00039AA0
		[NullableContext(2)]
		public FAnimLegIKDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0003B8AA File Offset: 0x00039AAA
		public FAnimLegIKDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0003B8B5 File Offset: 0x00039AB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimLegIKDefinition(Pointer, false, true);
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0003B8BF File Offset: 0x00039ABF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimLegIKDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04000FA2 RID: 4002
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.AnimLegIKDefinition";

		// Token: 0x04000FA3 RID: 4003
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000FA4 RID: 4004
		internal static int __PropertyOffset_IKFootBone;

		// Token: 0x04000FA5 RID: 4005
		[Nullable(2)]
		private FBoneReference _IKFootBone;

		// Token: 0x04000FA6 RID: 4006
		internal static int __PropertyOffset_FKFootBone;

		// Token: 0x04000FA7 RID: 4007
		[Nullable(2)]
		private FBoneReference _FKFootBone;

		// Token: 0x04000FA8 RID: 4008
		internal static int __PropertyOffset_NumBonesInLimb;

		// Token: 0x04000FA9 RID: 4009
		internal static int __PropertyOffset_MinRotationAngle;

		// Token: 0x04000FAA RID: 4010
		internal static int __PropertyOffset_FootBoneForwardAxis;

		// Token: 0x04000FAB RID: 4011
		internal static int __PropertyOffset_HingeRotationAxis;

		// Token: 0x04000FAC RID: 4012
		internal static int __PropertyOffset_bEnableRotationLimit;

		// Token: 0x04000FAD RID: 4013
		internal static int __PropertyOffset_bEnableKneeTwistCorrection;
	}
}
