using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE2 RID: 4066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsConstraintComponent")]
	[UnrealStructLayout(1312, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class UPhysicsConstraintComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DBA4 RID: 56228 RVA: 0x001439F2 File Offset: 0x00141BF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsConstraintComponent._ClassPtr;
		}

		// Token: 0x0600DBA5 RID: 56229 RVA: 0x00143A00 File Offset: 0x00141C00
		public UPhysicsConstraintComponent() : this(BuiltinUtils.AllocNativeUObject(UPhysicsConstraintComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DBA6 RID: 56230 RVA: 0x00143A28 File Offset: 0x00141C28
		public UPhysicsConstraintComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsConstraintComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600DBA7 RID: 56231 RVA: 0x00143A5B File Offset: 0x00141C5B
		// (set) Token: 0x0600DBA8 RID: 56232 RVA: 0x00143A6F File Offset: 0x00141C6F
		[Nullable(2)]
		public unsafe AActor ConstraintActor1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor1, value);
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600DBA9 RID: 56233 RVA: 0x00143A84 File Offset: 0x00141C84
		// (set) Token: 0x0600DBAA RID: 56234 RVA: 0x00143ABD File Offset: 0x00141CBD
		public FConstrainComponentPropName ComponentName1
		{
			get
			{
				base.FastCheckIsValid();
				FConstrainComponentPropName result;
				if ((result = this._ComponentName1) == null)
				{
					result = (this._ComponentName1 = new FConstrainComponentPropName(base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_ComponentName1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstrainComponentPropName.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_ComponentName1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600DBAB RID: 56235 RVA: 0x00143ADE File Offset: 0x00141CDE
		// (set) Token: 0x0600DBAC RID: 56236 RVA: 0x00143AF2 File Offset: 0x00141CF2
		[Nullable(2)]
		public unsafe AActor ConstraintActor2
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor2, value);
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600DBAD RID: 56237 RVA: 0x00143B08 File Offset: 0x00141D08
		// (set) Token: 0x0600DBAE RID: 56238 RVA: 0x00143B41 File Offset: 0x00141D41
		public FConstrainComponentPropName ComponentName2
		{
			get
			{
				base.FastCheckIsValid();
				FConstrainComponentPropName result;
				if ((result = this._ComponentName2) == null)
				{
					result = (this._ComponentName2 = new FConstrainComponentPropName(base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_ComponentName2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstrainComponentPropName.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_ComponentName2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600DBAF RID: 56239 RVA: 0x00143B62 File Offset: 0x00141D62
		// (set) Token: 0x0600DBB0 RID: 56240 RVA: 0x00143B76 File Offset: 0x00141D76
		[Nullable(2)]
		public unsafe UPhysicsConstraintTemplate ConstraintSetup_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintTemplate>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintSetup_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintSetup_DEPRECATED, value);
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600DBB1 RID: 56241 RVA: 0x00143B8C File Offset: 0x00141D8C
		// (set) Token: 0x0600DBB2 RID: 56242 RVA: 0x00143BC5 File Offset: 0x00141DC5
		public FConstraintBrokenSignature OnConstraintBroken
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintBrokenSignature result;
				if ((result = this._OnConstraintBroken) == null)
				{
					result = (this._OnConstraintBroken = new FConstraintBrokenSignature(base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_OnConstraintBroken, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_OnConstraintBroken, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x00143BE8 File Offset: 0x00141DE8
		// (set) Token: 0x0600DBB4 RID: 56244 RVA: 0x00143C21 File Offset: 0x00141E21
		public FConstraintInstance ConstraintInstance
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintInstance result;
				if ((result = this._ConstraintInstance) == null)
				{
					result = (this._ConstraintInstance = new FConstraintInstance(base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_ConstraintInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintInstance.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_ConstraintInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600DBB5 RID: 56245 RVA: 0x00143C42 File Offset: 0x00141E42
		public void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			UPhysicsConstraintComponent.__SetOrientationDriveTwistAndSwing_Internal(base.NativePtr, bEnableTwistDrive, bEnableSwingDrive);
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x00143C51 File Offset: 0x00141E51
		public void SetOrientationDriveSLERP(bool bEnableSLERP)
		{
			UPhysicsConstraintComponent.__SetOrientationDriveSLERP_Internal(base.NativePtr, bEnableSLERP);
		}

		// Token: 0x0600DBB7 RID: 56247 RVA: 0x00143C5F File Offset: 0x00141E5F
		public void SetLinearZLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
		{
			UPhysicsConstraintComponent.__SetLinearZLimit_Internal(base.NativePtr, ConstraintType, LimitSize);
		}

		// Token: 0x0600DBB8 RID: 56248 RVA: 0x00143C73 File Offset: 0x00141E73
		public void SetLinearYLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
		{
			UPhysicsConstraintComponent.__SetLinearYLimit_Internal(base.NativePtr, ConstraintType, LimitSize);
		}

		// Token: 0x0600DBB9 RID: 56249 RVA: 0x00143C87 File Offset: 0x00141E87
		public void SetLinearXLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
		{
			UPhysicsConstraintComponent.__SetLinearXLimit_Internal(base.NativePtr, ConstraintType, LimitSize);
		}

		// Token: 0x0600DBBA RID: 56250 RVA: 0x00143C9B File Offset: 0x00141E9B
		public void SetLinearVelocityTarget(in FVector InVelTarget)
		{
			UPhysicsConstraintComponent.__SetLinearVelocityTarget_Internal(base.NativePtr, InVelTarget);
		}

		// Token: 0x0600DBBB RID: 56251 RVA: 0x00143CA9 File Offset: 0x00141EA9
		public void SetLinearVelocityDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			UPhysicsConstraintComponent.__SetLinearVelocityDrive_Internal(base.NativePtr, bEnableDriveX, bEnableDriveY, bEnableDriveZ);
		}

		// Token: 0x0600DBBC RID: 56252 RVA: 0x00143CB9 File Offset: 0x00141EB9
		public void SetLinearPositionTarget(in FVector InPosTarget)
		{
			UPhysicsConstraintComponent.__SetLinearPositionTarget_Internal(base.NativePtr, InPosTarget);
		}

		// Token: 0x0600DBBD RID: 56253 RVA: 0x00143CC7 File Offset: 0x00141EC7
		public void SetLinearPositionDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			UPhysicsConstraintComponent.__SetLinearPositionDrive_Internal(base.NativePtr, bEnableDriveX, bEnableDriveY, bEnableDriveZ);
		}

		// Token: 0x0600DBBE RID: 56254 RVA: 0x00143CD7 File Offset: 0x00141ED7
		public void SetLinearDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			UPhysicsConstraintComponent.__SetLinearDriveParams_Internal(base.NativePtr, PositionStrength, VelocityStrength, InForceLimit);
		}

		// Token: 0x0600DBBF RID: 56255 RVA: 0x00143CE7 File Offset: 0x00141EE7
		public void SetLinearBreakable(bool bLinearBreakable, float LinearBreakThreshold)
		{
			UPhysicsConstraintComponent.__SetLinearBreakable_Internal(base.NativePtr, bLinearBreakable, LinearBreakThreshold);
		}

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x00143CF6 File Offset: 0x00141EF6
		public void SetDisableCollision(bool bDisableCollision)
		{
			UPhysicsConstraintComponent.__SetDisableCollision_Internal(base.NativePtr, bDisableCollision);
		}

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x00143D04 File Offset: 0x00141F04
		public void SetConstraintReferencePosition(EConstraintFrame Frame, in FVector RefPosition)
		{
			UPhysicsConstraintComponent.__SetConstraintReferencePosition_Internal(base.NativePtr, Frame, RefPosition);
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x00143D18 File Offset: 0x00141F18
		public void SetConstraintReferenceOrientation(EConstraintFrame Frame, in FVector PriAxis, in FVector SecAxis)
		{
			UPhysicsConstraintComponent.__SetConstraintReferenceOrientation_Internal(base.NativePtr, Frame, PriAxis, SecAxis);
		}

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00143D30 File Offset: 0x00141F30
		public unsafe void SetConstraintReferenceFrame(EConstraintFrame Frame, in FTransform RefFrame)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = RefFrame;
			UPhysicsConstraintComponent.__SetConstraintReferenceFrame_Internal(base.NativePtr, Frame, ptr);
		}

		// Token: 0x0600DBC4 RID: 56260 RVA: 0x00143D6B File Offset: 0x00141F6B
		[NullableContext(2)]
		public void SetConstrainedComponents(UPrimitiveComponent Component1, FName BoneName1, UPrimitiveComponent Component2, FName BoneName2)
		{
			UPhysicsConstraintComponent.__SetConstrainedComponents_Internal(base.NativePtr, (Component1 != null) ? Component1.NativePtr : IntPtr.Zero, BoneName1, (Component2 != null) ? Component2.NativePtr : IntPtr.Zero, BoneName2);
		}

		// Token: 0x0600DBC5 RID: 56261 RVA: 0x00143D9B File Offset: 0x00141F9B
		public void SetAngularVelocityTarget(in FVector InVelTarget)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityTarget_Internal(base.NativePtr, InVelTarget);
		}

		// Token: 0x0600DBC6 RID: 56262 RVA: 0x00143DA9 File Offset: 0x00141FA9
		public void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityDriveTwistAndSwing_Internal(base.NativePtr, bEnableTwistDrive, bEnableSwingDrive);
		}

		// Token: 0x0600DBC7 RID: 56263 RVA: 0x00143DB8 File Offset: 0x00141FB8
		public void SetAngularVelocityDriveSLERP(bool bEnableSLERP)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityDriveSLERP_Internal(base.NativePtr, bEnableSLERP);
		}

		// Token: 0x0600DBC8 RID: 56264 RVA: 0x00143DC6 File Offset: 0x00141FC6
		public void SetAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive);
		}

		// Token: 0x0600DBC9 RID: 56265 RVA: 0x00143DD5 File Offset: 0x00141FD5
		public void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType, float TwistLimitAngle)
		{
			UPhysicsConstraintComponent.__SetAngularTwistLimit_Internal(base.NativePtr, ConstraintType, TwistLimitAngle);
		}

		// Token: 0x0600DBCA RID: 56266 RVA: 0x00143DE9 File Offset: 0x00141FE9
		public void SetAngularSwing2Limit(EAngularConstraintMotion MotionType, float Swing2LimitAngle)
		{
			UPhysicsConstraintComponent.__SetAngularSwing2Limit_Internal(base.NativePtr, MotionType, Swing2LimitAngle);
		}

		// Token: 0x0600DBCB RID: 56267 RVA: 0x00143DFD File Offset: 0x00141FFD
		public void SetAngularSwing1Limit(EAngularConstraintMotion MotionType, float Swing1LimitAngle)
		{
			UPhysicsConstraintComponent.__SetAngularSwing1Limit_Internal(base.NativePtr, MotionType, Swing1LimitAngle);
		}

		// Token: 0x0600DBCC RID: 56268 RVA: 0x00143E11 File Offset: 0x00142011
		public void SetAngularOrientationTarget(in FRotator InPosTarget)
		{
			UPhysicsConstraintComponent.__SetAngularOrientationTarget_Internal(base.NativePtr, InPosTarget);
		}

		// Token: 0x0600DBCD RID: 56269 RVA: 0x00143E1F File Offset: 0x0014201F
		public void SetAngularOrientationDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
		{
			UPhysicsConstraintComponent.__SetAngularOrientationDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive);
		}

		// Token: 0x0600DBCE RID: 56270 RVA: 0x00143E2E File Offset: 0x0014202E
		public void SetAngularDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			UPhysicsConstraintComponent.__SetAngularDriveParams_Internal(base.NativePtr, PositionStrength, VelocityStrength, InForceLimit);
		}

		// Token: 0x0600DBCF RID: 56271 RVA: 0x00143E3E File Offset: 0x0014203E
		public void SetAngularDriveMode(EAngularDriveMode DriveMode)
		{
			UPhysicsConstraintComponent.__SetAngularDriveMode_Internal(base.NativePtr, DriveMode);
		}

		// Token: 0x0600DBD0 RID: 56272 RVA: 0x00143E51 File Offset: 0x00142051
		public void SetAngularBreakable(bool bAngularBreakable, float AngularBreakThreshold)
		{
			UPhysicsConstraintComponent.__SetAngularBreakable_Internal(base.NativePtr, bAngularBreakable, AngularBreakThreshold);
		}

		// Token: 0x0600DBD1 RID: 56273 RVA: 0x00143E60 File Offset: 0x00142060
		public bool IsBroken()
		{
			return UPhysicsConstraintComponent.__IsBroken_Internal(base.NativePtr);
		}

		// Token: 0x0600DBD2 RID: 56274 RVA: 0x00143E6D File Offset: 0x0014206D
		public float GetCurrentTwist()
		{
			return UPhysicsConstraintComponent.__GetCurrentTwist_Internal(base.NativePtr);
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x00143E7A File Offset: 0x0014207A
		public float GetCurrentSwing2()
		{
			return UPhysicsConstraintComponent.__GetCurrentSwing2_Internal(base.NativePtr);
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x00143E87 File Offset: 0x00142087
		public float GetCurrentSwing1()
		{
			return UPhysicsConstraintComponent.__GetCurrentSwing1_Internal(base.NativePtr);
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x00143E94 File Offset: 0x00142094
		public unsafe void GetConstraintForce(ref FVector OutLinearForce, ref FVector OutAngularForce)
		{
			fixed (FVector* ptr = &OutLinearForce)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &OutAngularForce)
				{
					void* ptr4 = (void*)ptr3;
					UPhysicsConstraintComponent.__GetConstraintForce_Internal(base.NativePtr, ref OutLinearForce, ref OutAngularForce);
					ptr = null;
				}
			}
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x00143EBE File Offset: 0x001420BE
		public void BreakConstraint()
		{
			UPhysicsConstraintComponent.__BreakConstraint_Internal(base.NativePtr);
		}

		// Token: 0x0600DBD7 RID: 56279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrientationDriveTwistAndSwing_Internal(IntPtr @this, bool bEnableTwistDrive, bool bEnableSwingDrive);

		// Token: 0x0600DBD8 RID: 56280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrientationDriveSLERP_Internal(IntPtr @this, bool bEnableSLERP);

		// Token: 0x0600DBD9 RID: 56281
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearZLimit_Internal(IntPtr @this, TEnumAsByte<ELinearConstraintMotion> ConstraintType, float LimitSize);

		// Token: 0x0600DBDA RID: 56282
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearYLimit_Internal(IntPtr @this, TEnumAsByte<ELinearConstraintMotion> ConstraintType, float LimitSize);

		// Token: 0x0600DBDB RID: 56283
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearXLimit_Internal(IntPtr @this, TEnumAsByte<ELinearConstraintMotion> ConstraintType, float LimitSize);

		// Token: 0x0600DBDC RID: 56284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearVelocityTarget_Internal(IntPtr @this, in FVector InVelTarget);

		// Token: 0x0600DBDD RID: 56285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearVelocityDrive_Internal(IntPtr @this, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ);

		// Token: 0x0600DBDE RID: 56286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearPositionTarget_Internal(IntPtr @this, in FVector InPosTarget);

		// Token: 0x0600DBDF RID: 56287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearPositionDrive_Internal(IntPtr @this, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ);

		// Token: 0x0600DBE0 RID: 56288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearDriveParams_Internal(IntPtr @this, float PositionStrength, float VelocityStrength, float InForceLimit);

		// Token: 0x0600DBE1 RID: 56289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearBreakable_Internal(IntPtr @this, bool bLinearBreakable, float LinearBreakThreshold);

		// Token: 0x0600DBE2 RID: 56290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableCollision_Internal(IntPtr @this, bool bDisableCollision);

		// Token: 0x0600DBE3 RID: 56291
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintReferencePosition_Internal(IntPtr @this, TEnumAsByte<EConstraintFrame> Frame, in FVector RefPosition);

		// Token: 0x0600DBE4 RID: 56292
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintReferenceOrientation_Internal(IntPtr @this, TEnumAsByte<EConstraintFrame> Frame, in FVector PriAxis, in FVector SecAxis);

		// Token: 0x0600DBE5 RID: 56293
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintReferenceFrame_Internal(IntPtr @this, TEnumAsByte<EConstraintFrame> Frame, in FTransform RefFrame);

		// Token: 0x0600DBE6 RID: 56294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstrainedComponents_Internal(IntPtr @this, IntPtr Component1, FName BoneName1, IntPtr Component2, FName BoneName2);

		// Token: 0x0600DBE7 RID: 56295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityTarget_Internal(IntPtr @this, in FVector InVelTarget);

		// Token: 0x0600DBE8 RID: 56296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityDriveTwistAndSwing_Internal(IntPtr @this, bool bEnableTwistDrive, bool bEnableSwingDrive);

		// Token: 0x0600DBE9 RID: 56297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityDriveSLERP_Internal(IntPtr @this, bool bEnableSLERP);

		// Token: 0x0600DBEA RID: 56298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive);

		// Token: 0x0600DBEB RID: 56299
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularTwistLimit_Internal(IntPtr @this, TEnumAsByte<EAngularConstraintMotion> ConstraintType, float TwistLimitAngle);

		// Token: 0x0600DBEC RID: 56300
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularSwing2Limit_Internal(IntPtr @this, TEnumAsByte<EAngularConstraintMotion> MotionType, float Swing2LimitAngle);

		// Token: 0x0600DBED RID: 56301
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularSwing1Limit_Internal(IntPtr @this, TEnumAsByte<EAngularConstraintMotion> MotionType, float Swing1LimitAngle);

		// Token: 0x0600DBEE RID: 56302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularOrientationTarget_Internal(IntPtr @this, in FRotator InPosTarget);

		// Token: 0x0600DBEF RID: 56303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularOrientationDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive);

		// Token: 0x0600DBF0 RID: 56304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularDriveParams_Internal(IntPtr @this, float PositionStrength, float VelocityStrength, float InForceLimit);

		// Token: 0x0600DBF1 RID: 56305
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularDriveMode_Internal(IntPtr @this, TEnumAsByte<EAngularDriveMode> DriveMode);

		// Token: 0x0600DBF2 RID: 56306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularBreakable_Internal(IntPtr @this, bool bAngularBreakable, float AngularBreakThreshold);

		// Token: 0x0600DBF3 RID: 56307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBroken_Internal(IntPtr @this);

		// Token: 0x0600DBF4 RID: 56308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentTwist_Internal(IntPtr @this);

		// Token: 0x0600DBF5 RID: 56309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentSwing2_Internal(IntPtr @this);

		// Token: 0x0600DBF6 RID: 56310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentSwing1_Internal(IntPtr @this);

		// Token: 0x0600DBF7 RID: 56311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetConstraintForce_Internal(IntPtr @this, ref FVector OutLinearForce, ref FVector OutAngularForce);

		// Token: 0x0600DBF8 RID: 56312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakConstraint_Internal(IntPtr @this);

		// Token: 0x0600DBF9 RID: 56313 RVA: 0x00143ECB File Offset: 0x001420CB
		static UPhysicsConstraintComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsConstraintComponent");
		}

		// Token: 0x0600DBFA RID: 56314 RVA: 0x00143ED9 File Offset: 0x001420D9
		protected UPhysicsConstraintComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040076D8 RID: 30424
		public new const string __ObjectPath = "/Script/Engine.PhysicsConstraintComponent";

		// Token: 0x040076D9 RID: 30425
		private static IntPtr _ClassPtr;

		// Token: 0x040076DA RID: 30426
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040076DB RID: 30427
		internal static int __PropertyOffset_ConstraintActor1;

		// Token: 0x040076DC RID: 30428
		internal static int __PropertyOffset_ComponentName1;

		// Token: 0x040076DD RID: 30429
		[Nullable(2)]
		private FConstrainComponentPropName _ComponentName1;

		// Token: 0x040076DE RID: 30430
		internal static int __PropertyOffset_ConstraintActor2;

		// Token: 0x040076DF RID: 30431
		internal static int __PropertyOffset_ComponentName2;

		// Token: 0x040076E0 RID: 30432
		[Nullable(2)]
		private FConstrainComponentPropName _ComponentName2;

		// Token: 0x040076E1 RID: 30433
		internal static int __PropertyOffset_ConstraintSetup_DEPRECATED;

		// Token: 0x040076E2 RID: 30434
		internal static int __PropertyOffset_OnConstraintBroken;

		// Token: 0x040076E3 RID: 30435
		[Nullable(2)]
		private FConstraintBrokenSignature _OnConstraintBroken;

		// Token: 0x040076E4 RID: 30436
		internal static int __PropertyOffset_ConstraintInstance;

		// Token: 0x040076E5 RID: 30437
		[Nullable(2)]
		private FConstraintInstance _ConstraintInstance;
	}
}
