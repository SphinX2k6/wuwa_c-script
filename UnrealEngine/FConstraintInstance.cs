using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000971 RID: 2417
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ConstraintInstance")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 656)]
	public class FConstraintInstance : FConstraintInstanceBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600886F RID: 34927 RVA: 0x000C3770 File Offset: 0x000C1970
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintInstance._ScriptStructPtr != 0) ? FConstraintInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ConstraintInstance", ref FConstraintInstance._ScriptStructPtr);
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06008870 RID: 34928 RVA: 0x000C3794 File Offset: 0x000C1994
		// (set) Token: 0x06008871 RID: 34929 RVA: 0x000C37A8 File Offset: 0x000C19A8
		public unsafe FName JointName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_JointName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_JointName) = value;
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06008872 RID: 34930 RVA: 0x000C37BD File Offset: 0x000C19BD
		// (set) Token: 0x06008873 RID: 34931 RVA: 0x000C37D1 File Offset: 0x000C19D1
		public unsafe FName ConstraintBone1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_ConstraintBone1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_ConstraintBone1) = value;
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06008874 RID: 34932 RVA: 0x000C37E6 File Offset: 0x000C19E6
		// (set) Token: 0x06008875 RID: 34933 RVA: 0x000C37FA File Offset: 0x000C19FA
		public unsafe FName ConstraintBone2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_ConstraintBone2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_ConstraintBone2) = value;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06008876 RID: 34934 RVA: 0x000C380F File Offset: 0x000C1A0F
		// (set) Token: 0x06008877 RID: 34935 RVA: 0x000C3823 File Offset: 0x000C1A23
		public unsafe FVector Pos1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_Pos1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_Pos1) = value;
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06008878 RID: 34936 RVA: 0x000C3838 File Offset: 0x000C1A38
		// (set) Token: 0x06008879 RID: 34937 RVA: 0x000C384C File Offset: 0x000C1A4C
		public unsafe FVector PriAxis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_PriAxis1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_PriAxis1) = value;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x0600887A RID: 34938 RVA: 0x000C3861 File Offset: 0x000C1A61
		// (set) Token: 0x0600887B RID: 34939 RVA: 0x000C3875 File Offset: 0x000C1A75
		public unsafe FVector SecAxis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_SecAxis1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_SecAxis1) = value;
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600887C RID: 34940 RVA: 0x000C388A File Offset: 0x000C1A8A
		// (set) Token: 0x0600887D RID: 34941 RVA: 0x000C389E File Offset: 0x000C1A9E
		public unsafe FVector Pos2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_Pos2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_Pos2) = value;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600887E RID: 34942 RVA: 0x000C38B3 File Offset: 0x000C1AB3
		// (set) Token: 0x0600887F RID: 34943 RVA: 0x000C38C7 File Offset: 0x000C1AC7
		public unsafe FVector PriAxis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_PriAxis2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_PriAxis2) = value;
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06008880 RID: 34944 RVA: 0x000C38DC File Offset: 0x000C1ADC
		// (set) Token: 0x06008881 RID: 34945 RVA: 0x000C38F0 File Offset: 0x000C1AF0
		public unsafe FVector SecAxis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_SecAxis2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_SecAxis2) = value;
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06008882 RID: 34946 RVA: 0x000C3905 File Offset: 0x000C1B05
		// (set) Token: 0x06008883 RID: 34947 RVA: 0x000C3919 File Offset: 0x000C1B19
		public unsafe FRotator AngularRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_AngularRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_AngularRotationOffset) = value;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06008884 RID: 34948 RVA: 0x000C392E File Offset: 0x000C1B2E
		// (set) Token: 0x06008885 RID: 34949 RVA: 0x000C3947 File Offset: 0x000C1B47
		public unsafe bool bScaleLinearLimits
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_bScaleLinearLimits) & FConstraintInstance.__PropertyMask_bScaleLinearLimits) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_bScaleLinearLimits) = ((*(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_bScaleLinearLimits) & ~FConstraintInstance.__PropertyMask_bScaleLinearLimits) | (value ? FConstraintInstance.__PropertyMask_bScaleLinearLimits : 0));
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06008886 RID: 34950 RVA: 0x000C3978 File Offset: 0x000C1B78
		// (set) Token: 0x06008887 RID: 34951 RVA: 0x000C39BB File Offset: 0x000C1BBB
		public FConstraintProfileProperties ProfileInstance
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintProfileProperties result;
				if ((result = this._ProfileInstance) == null)
				{
					result = (this._ProfileInstance = new FConstraintProfileProperties(base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_ProfileInstance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintProfileProperties.StaticStruct(), base.NativePtr + (IntPtr)FConstraintInstance.__PropertyOffset_ProfileInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008888 RID: 34952 RVA: 0x000C39DC File Offset: 0x000C1BDC
		public FConstraintInstance()
		{
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x000C39E4 File Offset: 0x000C1BE4
		[NullableContext(0)]
		public FConstraintInstance(FName JointName, FName ConstraintBone1, FName ConstraintBone2, FVector Pos1, FVector PriAxis1, FVector SecAxis1, FVector Pos2, FVector PriAxis2, FVector SecAxis2, FRotator AngularRotationOffset, bool bScaleLinearLimits, [Nullable(1)] FConstraintProfileProperties ProfileInstance, bool bDisableCollision_DEPRECATED, bool bEnableProjection_DEPRECATED, float ProjectionLinearTolerance_DEPRECATED, float ProjectionAngularTolerance_DEPRECATED, TEnumAsByte<ELinearConstraintMotion> LinearXMotion_DEPRECATED, TEnumAsByte<ELinearConstraintMotion> LinearYMotion_DEPRECATED, TEnumAsByte<ELinearConstraintMotion> LinearZMotion_DEPRECATED, float LinearLimitSize_DEPRECATED, bool bLinearLimitSoft_DEPRECATED, float LinearLimitStiffness_DEPRECATED, float LinearLimitDamping_DEPRECATED, bool bLinearBreakable_DEPRECATED, float LinearBreakThreshold_DEPRECATED, TEnumAsByte<EAngularConstraintMotion> AngularSwing1Motion_DEPRECATED, TEnumAsByte<EAngularConstraintMotion> AngularTwistMotion_DEPRECATED, TEnumAsByte<EAngularConstraintMotion> AngularSwing2Motion_DEPRECATED, bool bSwingLimitSoft_DEPRECATED, bool bTwistLimitSoft_DEPRECATED, float Swing1LimitAngle_DEPRECATED, float TwistLimitAngle_DEPRECATED, float Swing2LimitAngle_DEPRECATED, float SwingLimitStiffness_DEPRECATED, float SwingLimitDamping_DEPRECATED, float TwistLimitStiffness_DEPRECATED, float TwistLimitDamping_DEPRECATED, bool bAngularBreakable_DEPRECATED, float AngularBreakThreshold_DEPRECATED, bool bLinearXPositionDrive_DEPRECATED, bool bLinearXVelocityDrive_DEPRECATED, bool bLinearYPositionDrive_DEPRECATED, bool bLinearYVelocityDrive_DEPRECATED, bool bLinearZPositionDrive_DEPRECATED, bool bLinearZVelocityDrive_DEPRECATED, bool bLinearPositionDrive_DEPRECATED, bool bLinearVelocityDrive_DEPRECATED, FVector LinearPositionTarget_DEPRECATED, FVector LinearVelocityTarget_DEPRECATED, float LinearDriveSpring_DEPRECATED, float LinearDriveDamping_DEPRECATED, float LinearDriveForceLimit_DEPRECATED, bool bSwingPositionDrive_DEPRECATED, bool bSwingVelocityDrive_DEPRECATED, bool bTwistPositionDrive_DEPRECATED, bool bTwistVelocityDrive_DEPRECATED, bool bAngularSlerpDrive_DEPRECATED, bool bAngularOrientationDrive_DEPRECATED, bool bEnableSwingDrive_DEPRECATED, bool bEnableTwistDrive_DEPRECATED, bool bAngularVelocityDrive_DEPRECATED, FQuat AngularPositionTarget_DEPRECATED, TEnumAsByte<EAngularDriveMode> AngularDriveMode_DEPRECATED, FRotator AngularOrientationTarget_DEPRECATED, FVector AngularVelocityTarget_DEPRECATED, float AngularDriveSpring_DEPRECATED, float AngularDriveDamping_DEPRECATED, float AngularDriveForceLimit_DEPRECATED)
		{
			this.JointName = JointName;
			this.ConstraintBone1 = ConstraintBone1;
			this.ConstraintBone2 = ConstraintBone2;
			this.Pos1 = Pos1;
			this.PriAxis1 = PriAxis1;
			this.SecAxis1 = SecAxis1;
			this.Pos2 = Pos2;
			this.PriAxis2 = PriAxis2;
			this.SecAxis2 = SecAxis2;
			this.AngularRotationOffset = AngularRotationOffset;
			this.bScaleLinearLimits = bScaleLinearLimits;
			this.ProfileInstance = ProfileInstance;
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x000C3A54 File Offset: 0x000C1C54
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintInstance.StaticStruct();
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x000C3A60 File Offset: 0x000C1C60
		[NullableContext(2)]
		public FConstraintInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x000C3A6A File Offset: 0x000C1C6A
		public FConstraintInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x000C3A75 File Offset: 0x000C1C75
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintInstance(Pointer, false, true);
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x000C3A7F File Offset: 0x000C1C7F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintInstance(Pointer, MemoryOwner);
		}

		// Token: 0x040040DA RID: 16602
		public new const string __ObjectPath = "/Script/Engine.ConstraintInstance";

		// Token: 0x040040DB RID: 16603
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040DC RID: 16604
		internal static int __PropertyOffset_JointName;

		// Token: 0x040040DD RID: 16605
		internal static int __PropertyOffset_ConstraintBone1;

		// Token: 0x040040DE RID: 16606
		internal static int __PropertyOffset_ConstraintBone2;

		// Token: 0x040040DF RID: 16607
		internal static int __PropertyOffset_Pos1;

		// Token: 0x040040E0 RID: 16608
		internal static int __PropertyOffset_PriAxis1;

		// Token: 0x040040E1 RID: 16609
		internal static int __PropertyOffset_SecAxis1;

		// Token: 0x040040E2 RID: 16610
		internal static int __PropertyOffset_Pos2;

		// Token: 0x040040E3 RID: 16611
		internal static int __PropertyOffset_PriAxis2;

		// Token: 0x040040E4 RID: 16612
		internal static int __PropertyOffset_SecAxis2;

		// Token: 0x040040E5 RID: 16613
		internal static int __PropertyOffset_AngularRotationOffset;

		// Token: 0x040040E6 RID: 16614
		internal static int __PropertyOffset_bScaleLinearLimits;

		// Token: 0x040040E7 RID: 16615
		internal static byte __PropertyMask_bScaleLinearLimits;

		// Token: 0x040040E8 RID: 16616
		internal static int __PropertyOffset_ProfileInstance;

		// Token: 0x040040E9 RID: 16617
		[Nullable(2)]
		private FConstraintProfileProperties _ProfileInstance;
	}
}
