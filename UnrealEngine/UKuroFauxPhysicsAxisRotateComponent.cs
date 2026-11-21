using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000384 RID: 900
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponent")]
	[UnrealStructLayout(880, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 880)]
	public class UKuroFauxPhysicsAxisRotateComponent : UKuroFauxPhysicsRotateComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005A58 RID: 23128 RVA: 0x0007FBA8 File Offset: 0x0007DDA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsAxisRotateComponent._ClassPtr;
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x0007FBB4 File Offset: 0x0007DDB4
		public UKuroFauxPhysicsAxisRotateComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsAxisRotateComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x0007FBDC File Offset: 0x0007DDDC
		public UKuroFauxPhysicsAxisRotateComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsAxisRotateComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x0007FC0F File Offset: 0x0007DE0F
		// (set) Token: 0x06005A5C RID: 23132 RVA: 0x0007FC23 File Offset: 0x0007DE23
		public unsafe FVector LocalRotationAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_LocalRotationAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_LocalRotationAxis) = value;
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06005A5D RID: 23133 RVA: 0x0007FC38 File Offset: 0x0007DE38
		// (set) Token: 0x06005A5E RID: 23134 RVA: 0x0007FC48 File Offset: 0x0007DE48
		public unsafe bool bConstrain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_bConstrain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_bConstrain) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06005A5F RID: 23135 RVA: 0x0007FC59 File Offset: 0x0007DE59
		// (set) Token: 0x06005A60 RID: 23136 RVA: 0x0007FC69 File Offset: 0x0007DE69
		public unsafe float ConstrainAngleMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ConstrainAngleMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ConstrainAngleMin) = value;
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06005A61 RID: 23137 RVA: 0x0007FC7A File Offset: 0x0007DE7A
		// (set) Token: 0x06005A62 RID: 23138 RVA: 0x0007FC8A File Offset: 0x0007DE8A
		public unsafe float ConstrainAngleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ConstrainAngleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ConstrainAngleMax) = value;
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06005A63 RID: 23139 RVA: 0x0007FC9B File Offset: 0x0007DE9B
		// (set) Token: 0x06005A64 RID: 23140 RVA: 0x0007FCAB File Offset: 0x0007DEAB
		public unsafe float ConstrainBounce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ConstrainBounce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ConstrainBounce) = value;
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06005A65 RID: 23141 RVA: 0x0007FCBC File Offset: 0x0007DEBC
		// (set) Token: 0x06005A66 RID: 23142 RVA: 0x0007FCCC File Offset: 0x0007DECC
		public unsafe float ImpactMinStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ImpactMinStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_ImpactMinStrength) = value;
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06005A67 RID: 23143 RVA: 0x0007FCDD File Offset: 0x0007DEDD
		// (set) Token: 0x06005A68 RID: 23144 RVA: 0x0007FCED File Offset: 0x0007DEED
		public unsafe float MinTimeBetweenImpacts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_MinTimeBetweenImpacts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_MinTimeBetweenImpacts) = value;
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06005A69 RID: 23145 RVA: 0x0007FD00 File Offset: 0x0007DF00
		// (set) Token: 0x06005A6A RID: 23146 RVA: 0x0007FD39 File Offset: 0x0007DF39
		public FKuroFauxPhysicsAxisRotateConstraintHit OnMinConstraintHit
		{
			get
			{
				base.FastCheckIsValid();
				FKuroFauxPhysicsAxisRotateConstraintHit result;
				if ((result = this._OnMinConstraintHit) == null)
				{
					result = (this._OnMinConstraintHit = new FKuroFauxPhysicsAxisRotateConstraintHit(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_OnMinConstraintHit, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_OnMinConstraintHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x0007FD5C File Offset: 0x0007DF5C
		// (set) Token: 0x06005A6C RID: 23148 RVA: 0x0007FD95 File Offset: 0x0007DF95
		public FKuroFauxPhysicsAxisRotateConstraintHit OnMaxConstraintHit
		{
			get
			{
				base.FastCheckIsValid();
				FKuroFauxPhysicsAxisRotateConstraintHit result;
				if ((result = this._OnMaxConstraintHit) == null)
				{
					result = (this._OnMaxConstraintHit = new FKuroFauxPhysicsAxisRotateConstraintHit(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_OnMaxConstraintHit, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFauxPhysicsAxisRotateComponent.__PropertyOffset_OnMaxConstraintHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x0007FDB6 File Offset: 0x0007DFB6
		public float GetCurrentAlphaBetweenConstraints()
		{
			return UKuroFauxPhysicsAxisRotateComponent.__GetCurrentAlphaBetweenConstraints_Internal(base.NativePtr);
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x0007FDC3 File Offset: 0x0007DFC3
		public void ApplyAngularMovement(float AngleRadians)
		{
			UKuroFauxPhysicsAxisRotateComponent.__ApplyAngularMovement_Internal(base.NativePtr, AngleRadians);
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x0007FDD1 File Offset: 0x0007DFD1
		public void ApplyAngularImpulse(float AngularImpulseRadians)
		{
			UKuroFauxPhysicsAxisRotateComponent.__ApplyAngularImpulse_Internal(base.NativePtr, AngularImpulseRadians);
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x0007FDDF File Offset: 0x0007DFDF
		public void ApplyAngularForce(float AngularForceRadians)
		{
			UKuroFauxPhysicsAxisRotateComponent.__ApplyAngularForce_Internal(base.NativePtr, AngularForceRadians);
		}

		// Token: 0x06005A71 RID: 23153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentAlphaBetweenConstraints_Internal(IntPtr @this);

		// Token: 0x06005A72 RID: 23154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAngularMovement_Internal(IntPtr @this, float AngleRadians);

		// Token: 0x06005A73 RID: 23155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAngularImpulse_Internal(IntPtr @this, float AngularImpulseRadians);

		// Token: 0x06005A74 RID: 23156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAngularForce_Internal(IntPtr @this, float AngularForceRadians);

		// Token: 0x06005A75 RID: 23157 RVA: 0x0007FDED File Offset: 0x0007DFED
		static UKuroFauxPhysicsAxisRotateComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponent");
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x0007FDFB File Offset: 0x0007DFFB
		protected UKuroFauxPhysicsAxisRotateComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400258F RID: 9615
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponent";

		// Token: 0x04002590 RID: 9616
		private static IntPtr _ClassPtr;

		// Token: 0x04002591 RID: 9617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002592 RID: 9618
		internal static int __PropertyOffset_LocalRotationAxis;

		// Token: 0x04002593 RID: 9619
		internal static int __PropertyOffset_bConstrain;

		// Token: 0x04002594 RID: 9620
		internal static int __PropertyOffset_ConstrainAngleMin;

		// Token: 0x04002595 RID: 9621
		internal static int __PropertyOffset_ConstrainAngleMax;

		// Token: 0x04002596 RID: 9622
		internal static int __PropertyOffset_ConstrainBounce;

		// Token: 0x04002597 RID: 9623
		internal static int __PropertyOffset_ImpactMinStrength;

		// Token: 0x04002598 RID: 9624
		internal static int __PropertyOffset_MinTimeBetweenImpacts;

		// Token: 0x04002599 RID: 9625
		internal static int __PropertyOffset_OnMinConstraintHit;

		// Token: 0x0400259A RID: 9626
		[Nullable(2)]
		private FKuroFauxPhysicsAxisRotateConstraintHit _OnMinConstraintHit;

		// Token: 0x0400259B RID: 9627
		internal static int __PropertyOffset_OnMaxConstraintHit;

		// Token: 0x0400259C RID: 9628
		[Nullable(2)]
		private FKuroFauxPhysicsAxisRotateConstraintHit _OnMaxConstraintHit;
	}
}
