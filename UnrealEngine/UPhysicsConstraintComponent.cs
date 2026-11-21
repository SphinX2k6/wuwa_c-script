using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025E RID: 606
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsConstraintComponent")]
	[UnrealStructLayout(1312, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class UPhysicsConstraintComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060033C0 RID: 13248 RVA: 0x0004A002 File Offset: 0x00048202
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsConstraintComponent._ClassPtr;
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x0004A010 File Offset: 0x00048210
		public UPhysicsConstraintComponent() : this(BuiltinUtils.AllocNativeUObject(UPhysicsConstraintComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x0004A038 File Offset: 0x00048238
		[NullableContext(1)]
		public UPhysicsConstraintComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsConstraintComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x0004A06B File Offset: 0x0004826B
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x0004A07F File Offset: 0x0004827F
		public unsafe AActor ConstraintActor1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor1, value);
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x0004A094 File Offset: 0x00048294
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x0004A0A8 File Offset: 0x000482A8
		public unsafe AActor ConstraintActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicsConstraintComponent.__PropertyOffset_ConstraintActor2, value);
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x0004A0C0 File Offset: 0x000482C0
		// (set) Token: 0x060033C8 RID: 13256 RVA: 0x0004A0F9 File Offset: 0x000482F9
		[Nullable(1)]
		public FConstraintBrokenSignature OnConstraintBroken
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPhysicsConstraintComponent.__PropertyOffset_OnConstraintBroken, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x0004A11A File Offset: 0x0004831A
		public void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			UPhysicsConstraintComponent.__SetOrientationDriveTwistAndSwing_Internal(base.NativePtr, bEnableTwistDrive, bEnableSwingDrive);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x0004A129 File Offset: 0x00048329
		public void SetOrientationDriveSLERP(bool bEnableSLERP)
		{
			UPhysicsConstraintComponent.__SetOrientationDriveSLERP_Internal(base.NativePtr, bEnableSLERP);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x0004A137 File Offset: 0x00048337
		public void SetLinearVelocityTarget(in FVector InVelTarget)
		{
			UPhysicsConstraintComponent.__SetLinearVelocityTarget_Internal(base.NativePtr, InVelTarget);
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x0004A145 File Offset: 0x00048345
		public void SetLinearVelocityDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			UPhysicsConstraintComponent.__SetLinearVelocityDrive_Internal(base.NativePtr, bEnableDriveX, bEnableDriveY, bEnableDriveZ);
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x0004A155 File Offset: 0x00048355
		public void SetLinearPositionTarget(in FVector InPosTarget)
		{
			UPhysicsConstraintComponent.__SetLinearPositionTarget_Internal(base.NativePtr, InPosTarget);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x0004A163 File Offset: 0x00048363
		public void SetLinearPositionDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			UPhysicsConstraintComponent.__SetLinearPositionDrive_Internal(base.NativePtr, bEnableDriveX, bEnableDriveY, bEnableDriveZ);
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x0004A173 File Offset: 0x00048373
		public void SetLinearDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			UPhysicsConstraintComponent.__SetLinearDriveParams_Internal(base.NativePtr, PositionStrength, VelocityStrength, InForceLimit);
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x0004A183 File Offset: 0x00048383
		public void SetLinearBreakable(bool bLinearBreakable, float LinearBreakThreshold)
		{
			UPhysicsConstraintComponent.__SetLinearBreakable_Internal(base.NativePtr, bLinearBreakable, LinearBreakThreshold);
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x0004A192 File Offset: 0x00048392
		public void SetDisableCollision(bool bDisableCollision)
		{
			UPhysicsConstraintComponent.__SetDisableCollision_Internal(base.NativePtr, bDisableCollision);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x0004A1A0 File Offset: 0x000483A0
		public void SetConstrainedComponents(UPrimitiveComponent Component1, FName BoneName1, UPrimitiveComponent Component2, FName BoneName2)
		{
			UPhysicsConstraintComponent.__SetConstrainedComponents_Internal(base.NativePtr, (Component1 != null) ? Component1.NativePtr : IntPtr.Zero, BoneName1, (Component2 != null) ? Component2.NativePtr : IntPtr.Zero, BoneName2);
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x0004A1D0 File Offset: 0x000483D0
		public void SetAngularVelocityTarget(in FVector InVelTarget)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityTarget_Internal(base.NativePtr, InVelTarget);
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x0004A1DE File Offset: 0x000483DE
		public void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityDriveTwistAndSwing_Internal(base.NativePtr, bEnableTwistDrive, bEnableSwingDrive);
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x0004A1ED File Offset: 0x000483ED
		public void SetAngularVelocityDriveSLERP(bool bEnableSLERP)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityDriveSLERP_Internal(base.NativePtr, bEnableSLERP);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x0004A1FB File Offset: 0x000483FB
		public void SetAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
		{
			UPhysicsConstraintComponent.__SetAngularVelocityDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive);
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x0004A20A File Offset: 0x0004840A
		public void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType, float TwistLimitAngle)
		{
			UPhysicsConstraintComponent.__SetAngularTwistLimit_Internal(base.NativePtr, ConstraintType, TwistLimitAngle);
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x0004A21E File Offset: 0x0004841E
		public void SetAngularSwing2Limit(EAngularConstraintMotion MotionType, float Swing2LimitAngle)
		{
			UPhysicsConstraintComponent.__SetAngularSwing2Limit_Internal(base.NativePtr, MotionType, Swing2LimitAngle);
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x0004A232 File Offset: 0x00048432
		public void SetAngularSwing1Limit(EAngularConstraintMotion MotionType, float Swing1LimitAngle)
		{
			UPhysicsConstraintComponent.__SetAngularSwing1Limit_Internal(base.NativePtr, MotionType, Swing1LimitAngle);
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x0004A246 File Offset: 0x00048446
		public void SetAngularOrientationTarget(in FRotator InPosTarget)
		{
			UPhysicsConstraintComponent.__SetAngularOrientationTarget_Internal(base.NativePtr, InPosTarget);
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x0004A254 File Offset: 0x00048454
		public void SetAngularOrientationDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
		{
			UPhysicsConstraintComponent.__SetAngularOrientationDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive);
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x0004A263 File Offset: 0x00048463
		public void SetAngularDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			UPhysicsConstraintComponent.__SetAngularDriveParams_Internal(base.NativePtr, PositionStrength, VelocityStrength, InForceLimit);
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x0004A273 File Offset: 0x00048473
		public void SetAngularBreakable(bool bAngularBreakable, float AngularBreakThreshold)
		{
			UPhysicsConstraintComponent.__SetAngularBreakable_Internal(base.NativePtr, bAngularBreakable, AngularBreakThreshold);
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x0004A282 File Offset: 0x00048482
		public bool IsBroken()
		{
			return UPhysicsConstraintComponent.__IsBroken_Internal(base.NativePtr);
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0004A28F File Offset: 0x0004848F
		public float GetCurrentTwist()
		{
			return UPhysicsConstraintComponent.__GetCurrentTwist_Internal(base.NativePtr);
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0004A29C File Offset: 0x0004849C
		public float GetCurrentSwing2()
		{
			return UPhysicsConstraintComponent.__GetCurrentSwing2_Internal(base.NativePtr);
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x0004A2A9 File Offset: 0x000484A9
		public float GetCurrentSwing1()
		{
			return UPhysicsConstraintComponent.__GetCurrentSwing1_Internal(base.NativePtr);
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x0004A2B8 File Offset: 0x000484B8
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

		// Token: 0x060033E3 RID: 13283 RVA: 0x0004A2E2 File Offset: 0x000484E2
		public void BreakConstraint()
		{
			UPhysicsConstraintComponent.__BreakConstraint_Internal(base.NativePtr);
		}

		// Token: 0x060033E4 RID: 13284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrientationDriveTwistAndSwing_Internal(IntPtr @this, bool bEnableTwistDrive, bool bEnableSwingDrive);

		// Token: 0x060033E5 RID: 13285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrientationDriveSLERP_Internal(IntPtr @this, bool bEnableSLERP);

		// Token: 0x060033E6 RID: 13286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearVelocityTarget_Internal(IntPtr @this, in FVector InVelTarget);

		// Token: 0x060033E7 RID: 13287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearVelocityDrive_Internal(IntPtr @this, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ);

		// Token: 0x060033E8 RID: 13288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearPositionTarget_Internal(IntPtr @this, in FVector InPosTarget);

		// Token: 0x060033E9 RID: 13289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearPositionDrive_Internal(IntPtr @this, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ);

		// Token: 0x060033EA RID: 13290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearDriveParams_Internal(IntPtr @this, float PositionStrength, float VelocityStrength, float InForceLimit);

		// Token: 0x060033EB RID: 13291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearBreakable_Internal(IntPtr @this, bool bLinearBreakable, float LinearBreakThreshold);

		// Token: 0x060033EC RID: 13292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableCollision_Internal(IntPtr @this, bool bDisableCollision);

		// Token: 0x060033ED RID: 13293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstrainedComponents_Internal(IntPtr @this, IntPtr Component1, FName BoneName1, IntPtr Component2, FName BoneName2);

		// Token: 0x060033EE RID: 13294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityTarget_Internal(IntPtr @this, in FVector InVelTarget);

		// Token: 0x060033EF RID: 13295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityDriveTwistAndSwing_Internal(IntPtr @this, bool bEnableTwistDrive, bool bEnableSwingDrive);

		// Token: 0x060033F0 RID: 13296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityDriveSLERP_Internal(IntPtr @this, bool bEnableSLERP);

		// Token: 0x060033F1 RID: 13297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularVelocityDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive);

		// Token: 0x060033F2 RID: 13298
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularTwistLimit_Internal(IntPtr @this, TEnumAsByte<EAngularConstraintMotion> ConstraintType, float TwistLimitAngle);

		// Token: 0x060033F3 RID: 13299
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularSwing2Limit_Internal(IntPtr @this, TEnumAsByte<EAngularConstraintMotion> MotionType, float Swing2LimitAngle);

		// Token: 0x060033F4 RID: 13300
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularSwing1Limit_Internal(IntPtr @this, TEnumAsByte<EAngularConstraintMotion> MotionType, float Swing1LimitAngle);

		// Token: 0x060033F5 RID: 13301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularOrientationTarget_Internal(IntPtr @this, in FRotator InPosTarget);

		// Token: 0x060033F6 RID: 13302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularOrientationDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive);

		// Token: 0x060033F7 RID: 13303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularDriveParams_Internal(IntPtr @this, float PositionStrength, float VelocityStrength, float InForceLimit);

		// Token: 0x060033F8 RID: 13304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularBreakable_Internal(IntPtr @this, bool bAngularBreakable, float AngularBreakThreshold);

		// Token: 0x060033F9 RID: 13305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBroken_Internal(IntPtr @this);

		// Token: 0x060033FA RID: 13306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentTwist_Internal(IntPtr @this);

		// Token: 0x060033FB RID: 13307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentSwing2_Internal(IntPtr @this);

		// Token: 0x060033FC RID: 13308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentSwing1_Internal(IntPtr @this);

		// Token: 0x060033FD RID: 13309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetConstraintForce_Internal(IntPtr @this, ref FVector OutLinearForce, ref FVector OutAngularForce);

		// Token: 0x060033FE RID: 13310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakConstraint_Internal(IntPtr @this);

		// Token: 0x060033FF RID: 13311 RVA: 0x0004A2EF File Offset: 0x000484EF
		static UPhysicsConstraintComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsConstraintComponent");
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x0004A2FD File Offset: 0x000484FD
		protected UPhysicsConstraintComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001202 RID: 4610
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsConstraintComponent";

		// Token: 0x04001203 RID: 4611
		private static IntPtr _ClassPtr;

		// Token: 0x04001204 RID: 4612
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001205 RID: 4613
		internal static int __PropertyOffset_ConstraintActor1;

		// Token: 0x04001206 RID: 4614
		internal static int __PropertyOffset_ConstraintActor2;

		// Token: 0x04001207 RID: 4615
		internal static int __PropertyOffset_OnConstraintBroken;

		// Token: 0x04001208 RID: 4616
		private FConstraintBrokenSignature _OnConstraintBroken;
	}
}
