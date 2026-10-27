using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001841 RID: 6209
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponent")]
	[UnrealStructLayout(896, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 896)]
	public class UKuroFauxPhysicsConeRotateComponent : UKuroFauxPhysicsRotateComponentBase, IUnrealUObject, IUnrealObject, IKuroVisualizedInterface, IUnrealNativeInterface, IUnrealInterface, IKuroConeVisualizedInterface
	{
		// Token: 0x06016E4F RID: 93775 RVA: 0x0021696A File Offset: 0x00214B6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsConeRotateComponent._ClassPtr;
		}

		// Token: 0x06016E50 RID: 93776 RVA: 0x00216976 File Offset: 0x00214B76
		int IKuroVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsConeRotateComponent.__InterfaceOffset_IKuroVisualizedInterface;
		}

		// Token: 0x06016E51 RID: 93777 RVA: 0x0021697D File Offset: 0x00214B7D
		int IKuroConeVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsConeRotateComponent.__InterfaceOffset_IKuroConeVisualizedInterface;
		}

		// Token: 0x06016E52 RID: 93778 RVA: 0x00216984 File Offset: 0x00214B84
		public UKuroFauxPhysicsConeRotateComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsConeRotateComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E53 RID: 93779 RVA: 0x002169AC File Offset: 0x00214BAC
		[NullableContext(1)]
		public UKuroFauxPhysicsConeRotateComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsConeRotateComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C59 RID: 23641
		// (get) Token: 0x06016E54 RID: 93780 RVA: 0x002169DF File Offset: 0x00214BDF
		// (set) Token: 0x06016E55 RID: 93781 RVA: 0x002169EF File Offset: 0x00214BEF
		public unsafe float ConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_ConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_ConeAngle) = value;
			}
		}

		// Token: 0x17005C5A RID: 23642
		// (get) Token: 0x06016E56 RID: 93782 RVA: 0x00216A00 File Offset: 0x00214C00
		// (set) Token: 0x06016E57 RID: 93783 RVA: 0x00216A14 File Offset: 0x00214C14
		public unsafe FVector LocalConeDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_LocalConeDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_LocalConeDirection) = value;
			}
		}

		// Token: 0x17005C5B RID: 23643
		// (get) Token: 0x06016E58 RID: 93784 RVA: 0x00216A29 File Offset: 0x00214C29
		// (set) Token: 0x06016E59 RID: 93785 RVA: 0x00216A39 File Offset: 0x00214C39
		public unsafe float ConstrainBounce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_ConstrainBounce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_ConstrainBounce) = value;
			}
		}

		// Token: 0x17005C5C RID: 23644
		// (get) Token: 0x06016E5A RID: 93786 RVA: 0x00216A4A File Offset: 0x00214C4A
		// (set) Token: 0x06016E5B RID: 93787 RVA: 0x00216A5A File Offset: 0x00214C5A
		public unsafe bool bConstrainTwist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_bConstrainTwist) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_bConstrainTwist) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C5D RID: 23645
		// (get) Token: 0x06016E5C RID: 93788 RVA: 0x00216A6B File Offset: 0x00214C6B
		// (set) Token: 0x06016E5D RID: 93789 RVA: 0x00216A7B File Offset: 0x00214C7B
		public unsafe float ImpactMinStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_ImpactMinStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_ImpactMinStrength) = value;
			}
		}

		// Token: 0x17005C5E RID: 23646
		// (get) Token: 0x06016E5E RID: 93790 RVA: 0x00216A8C File Offset: 0x00214C8C
		// (set) Token: 0x06016E5F RID: 93791 RVA: 0x00216A9C File Offset: 0x00214C9C
		public unsafe float MinTimeBetweenImpacts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_MinTimeBetweenImpacts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_MinTimeBetweenImpacts) = value;
			}
		}

		// Token: 0x17005C5F RID: 23647
		// (get) Token: 0x06016E60 RID: 93792 RVA: 0x00216AB0 File Offset: 0x00214CB0
		// (set) Token: 0x06016E61 RID: 93793 RVA: 0x00216AE9 File Offset: 0x00214CE9
		[Nullable(1)]
		public FKuroPhysicsConeRotateConstraintHit OnConstraintHit
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroPhysicsConeRotateConstraintHit result;
				if ((result = this._OnConstraintHit) == null)
				{
					result = (this._OnConstraintHit = new FKuroPhysicsConeRotateConstraintHit(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_OnConstraintHit, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_OnConstraintHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06016E62 RID: 93794 RVA: 0x00216B0A File Offset: 0x00214D0A
		static UKuroFauxPhysicsConeRotateComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponent");
		}

		// Token: 0x06016E63 RID: 93795 RVA: 0x00216B18 File Offset: 0x00214D18
		protected UKuroFauxPhysicsConeRotateComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C70B RID: 50955
		internal static int __InterfaceOffset_IKuroVisualizedInterface;

		// Token: 0x0400C70C RID: 50956
		internal static int __InterfaceOffset_IKuroConeVisualizedInterface;

		// Token: 0x0400C70D RID: 50957
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponent";

		// Token: 0x0400C70E RID: 50958
		private static IntPtr _ClassPtr;

		// Token: 0x0400C70F RID: 50959
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C710 RID: 50960
		internal static int __PropertyOffset_ConeAngle;

		// Token: 0x0400C711 RID: 50961
		internal static int __PropertyOffset_LocalConeDirection;

		// Token: 0x0400C712 RID: 50962
		internal static int __PropertyOffset_ConstrainBounce;

		// Token: 0x0400C713 RID: 50963
		internal static int __PropertyOffset_bConstrainTwist;

		// Token: 0x0400C714 RID: 50964
		internal static int __PropertyOffset_ImpactMinStrength;

		// Token: 0x0400C715 RID: 50965
		internal static int __PropertyOffset_MinTimeBetweenImpacts;

		// Token: 0x0400C716 RID: 50966
		internal static int __PropertyOffset_OnConstraintHit;

		// Token: 0x0400C717 RID: 50967
		[Nullable(2)]
		private FKuroPhysicsConeRotateConstraintHit _OnConstraintHit;
	}
}
