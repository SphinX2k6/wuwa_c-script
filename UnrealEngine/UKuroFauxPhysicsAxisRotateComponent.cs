using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200183C RID: 6204
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponent")]
	[UnrealStructLayout(880, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 880)]
	public class UKuroFauxPhysicsAxisRotateComponent : UKuroFauxPhysicsRotateComponentBase, IUnrealUObject, IUnrealObject, IKuroVisualizedInterface, IUnrealNativeInterface, IUnrealInterface, IKuroAxisVisualizedInterface
	{
		// Token: 0x06016DE9 RID: 93673 RVA: 0x0021629C File Offset: 0x0021449C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsAxisRotateComponent._ClassPtr;
		}

		// Token: 0x06016DEA RID: 93674 RVA: 0x002162A8 File Offset: 0x002144A8
		int IKuroVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsAxisRotateComponent.__InterfaceOffset_IKuroVisualizedInterface;
		}

		// Token: 0x06016DEB RID: 93675 RVA: 0x002162AF File Offset: 0x002144AF
		int IKuroAxisVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsAxisRotateComponent.__InterfaceOffset_IKuroAxisVisualizedInterface;
		}

		// Token: 0x06016DEC RID: 93676 RVA: 0x002162B8 File Offset: 0x002144B8
		public UKuroFauxPhysicsAxisRotateComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsAxisRotateComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016DED RID: 93677 RVA: 0x002162E0 File Offset: 0x002144E0
		public UKuroFauxPhysicsAxisRotateComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsAxisRotateComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C4B RID: 23627
		// (get) Token: 0x06016DEE RID: 93678 RVA: 0x00216313 File Offset: 0x00214513
		// (set) Token: 0x06016DEF RID: 93679 RVA: 0x00216327 File Offset: 0x00214527
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

		// Token: 0x17005C4C RID: 23628
		// (get) Token: 0x06016DF0 RID: 93680 RVA: 0x0021633C File Offset: 0x0021453C
		// (set) Token: 0x06016DF1 RID: 93681 RVA: 0x0021634C File Offset: 0x0021454C
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

		// Token: 0x17005C4D RID: 23629
		// (get) Token: 0x06016DF2 RID: 93682 RVA: 0x0021635D File Offset: 0x0021455D
		// (set) Token: 0x06016DF3 RID: 93683 RVA: 0x0021636D File Offset: 0x0021456D
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

		// Token: 0x17005C4E RID: 23630
		// (get) Token: 0x06016DF4 RID: 93684 RVA: 0x0021637E File Offset: 0x0021457E
		// (set) Token: 0x06016DF5 RID: 93685 RVA: 0x0021638E File Offset: 0x0021458E
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

		// Token: 0x17005C4F RID: 23631
		// (get) Token: 0x06016DF6 RID: 93686 RVA: 0x0021639F File Offset: 0x0021459F
		// (set) Token: 0x06016DF7 RID: 93687 RVA: 0x002163AF File Offset: 0x002145AF
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

		// Token: 0x17005C50 RID: 23632
		// (get) Token: 0x06016DF8 RID: 93688 RVA: 0x002163C0 File Offset: 0x002145C0
		// (set) Token: 0x06016DF9 RID: 93689 RVA: 0x002163D0 File Offset: 0x002145D0
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

		// Token: 0x17005C51 RID: 23633
		// (get) Token: 0x06016DFA RID: 93690 RVA: 0x002163E1 File Offset: 0x002145E1
		// (set) Token: 0x06016DFB RID: 93691 RVA: 0x002163F1 File Offset: 0x002145F1
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

		// Token: 0x17005C52 RID: 23634
		// (get) Token: 0x06016DFC RID: 93692 RVA: 0x00216404 File Offset: 0x00214604
		// (set) Token: 0x06016DFD RID: 93693 RVA: 0x0021643D File Offset: 0x0021463D
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

		// Token: 0x17005C53 RID: 23635
		// (get) Token: 0x06016DFE RID: 93694 RVA: 0x00216460 File Offset: 0x00214660
		// (set) Token: 0x06016DFF RID: 93695 RVA: 0x00216499 File Offset: 0x00214699
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

		// Token: 0x06016E00 RID: 93696 RVA: 0x002164BA File Offset: 0x002146BA
		public float GetCurrentAlphaBetweenConstraints()
		{
			return UKuroFauxPhysicsAxisRotateComponent.__GetCurrentAlphaBetweenConstraints_Internal(base.NativePtr);
		}

		// Token: 0x06016E01 RID: 93697 RVA: 0x002164C7 File Offset: 0x002146C7
		public void ApplyAngularMovement(float AngleRadians)
		{
			UKuroFauxPhysicsAxisRotateComponent.__ApplyAngularMovement_Internal(base.NativePtr, AngleRadians);
		}

		// Token: 0x06016E02 RID: 93698 RVA: 0x002164D5 File Offset: 0x002146D5
		public void ApplyAngularImpulse(float AngularImpulseRadians)
		{
			UKuroFauxPhysicsAxisRotateComponent.__ApplyAngularImpulse_Internal(base.NativePtr, AngularImpulseRadians);
		}

		// Token: 0x06016E03 RID: 93699 RVA: 0x002164E3 File Offset: 0x002146E3
		public void ApplyAngularForce(float AngularForceRadians)
		{
			UKuroFauxPhysicsAxisRotateComponent.__ApplyAngularForce_Internal(base.NativePtr, AngularForceRadians);
		}

		// Token: 0x06016E04 RID: 93700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentAlphaBetweenConstraints_Internal(IntPtr @this);

		// Token: 0x06016E05 RID: 93701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAngularMovement_Internal(IntPtr @this, float AngleRadians);

		// Token: 0x06016E06 RID: 93702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAngularImpulse_Internal(IntPtr @this, float AngularImpulseRadians);

		// Token: 0x06016E07 RID: 93703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyAngularForce_Internal(IntPtr @this, float AngularForceRadians);

		// Token: 0x06016E08 RID: 93704 RVA: 0x002164F1 File Offset: 0x002146F1
		static UKuroFauxPhysicsAxisRotateComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponent");
		}

		// Token: 0x06016E09 RID: 93705 RVA: 0x002164FF File Offset: 0x002146FF
		protected UKuroFauxPhysicsAxisRotateComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C6E9 RID: 50921
		internal static int __InterfaceOffset_IKuroVisualizedInterface;

		// Token: 0x0400C6EA RID: 50922
		internal static int __InterfaceOffset_IKuroAxisVisualizedInterface;

		// Token: 0x0400C6EB RID: 50923
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponent";

		// Token: 0x0400C6EC RID: 50924
		private static IntPtr _ClassPtr;

		// Token: 0x0400C6ED RID: 50925
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C6EE RID: 50926
		internal static int __PropertyOffset_LocalRotationAxis;

		// Token: 0x0400C6EF RID: 50927
		internal static int __PropertyOffset_bConstrain;

		// Token: 0x0400C6F0 RID: 50928
		internal static int __PropertyOffset_ConstrainAngleMin;

		// Token: 0x0400C6F1 RID: 50929
		internal static int __PropertyOffset_ConstrainAngleMax;

		// Token: 0x0400C6F2 RID: 50930
		internal static int __PropertyOffset_ConstrainBounce;

		// Token: 0x0400C6F3 RID: 50931
		internal static int __PropertyOffset_ImpactMinStrength;

		// Token: 0x0400C6F4 RID: 50932
		internal static int __PropertyOffset_MinTimeBetweenImpacts;

		// Token: 0x0400C6F5 RID: 50933
		internal static int __PropertyOffset_OnMinConstraintHit;

		// Token: 0x0400C6F6 RID: 50934
		[Nullable(2)]
		private FKuroFauxPhysicsAxisRotateConstraintHit _OnMinConstraintHit;

		// Token: 0x0400C6F7 RID: 50935
		internal static int __PropertyOffset_OnMaxConstraintHit;

		// Token: 0x0400C6F8 RID: 50936
		[Nullable(2)]
		private FKuroFauxPhysicsAxisRotateConstraintHit _OnMaxConstraintHit;
	}
}
