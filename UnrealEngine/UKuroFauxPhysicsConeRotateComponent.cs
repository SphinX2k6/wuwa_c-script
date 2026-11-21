using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000387 RID: 903
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponent")]
	[UnrealStructLayout(896, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 896)]
	public class UKuroFauxPhysicsConeRotateComponent : UKuroFauxPhysicsRotateComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005AA9 RID: 23209 RVA: 0x000800ED File Offset: 0x0007E2ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsConeRotateComponent._ClassPtr;
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x000800FC File Offset: 0x0007E2FC
		public UKuroFauxPhysicsConeRotateComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsConeRotateComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00080124 File Offset: 0x0007E324
		public UKuroFauxPhysicsConeRotateComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsConeRotateComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x00080157 File Offset: 0x0007E357
		// (set) Token: 0x06005AAD RID: 23213 RVA: 0x00080167 File Offset: 0x0007E367
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

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x00080178 File Offset: 0x0007E378
		// (set) Token: 0x06005AAF RID: 23215 RVA: 0x0008018C File Offset: 0x0007E38C
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

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06005AB0 RID: 23216 RVA: 0x000801A1 File Offset: 0x0007E3A1
		// (set) Token: 0x06005AB1 RID: 23217 RVA: 0x000801B1 File Offset: 0x0007E3B1
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

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x000801C2 File Offset: 0x0007E3C2
		// (set) Token: 0x06005AB3 RID: 23219 RVA: 0x000801D2 File Offset: 0x0007E3D2
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

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06005AB4 RID: 23220 RVA: 0x000801E3 File Offset: 0x0007E3E3
		// (set) Token: 0x06005AB5 RID: 23221 RVA: 0x000801F3 File Offset: 0x0007E3F3
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

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x00080204 File Offset: 0x0007E404
		// (set) Token: 0x06005AB7 RID: 23223 RVA: 0x00080214 File Offset: 0x0007E414
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x00080228 File Offset: 0x0007E428
		// (set) Token: 0x06005AB9 RID: 23225 RVA: 0x00080261 File Offset: 0x0007E461
		public FKuroPhysicsConeRotateConstraintHit OnConstraintHit
		{
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
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFauxPhysicsConeRotateComponent.__PropertyOffset_OnConstraintHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00080282 File Offset: 0x0007E482
		static UKuroFauxPhysicsConeRotateComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponent");
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00080290 File Offset: 0x0007E490
		protected UKuroFauxPhysicsConeRotateComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040025A8 RID: 9640
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponent";

		// Token: 0x040025A9 RID: 9641
		private static IntPtr _ClassPtr;

		// Token: 0x040025AA RID: 9642
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040025AB RID: 9643
		internal static int __PropertyOffset_ConeAngle;

		// Token: 0x040025AC RID: 9644
		internal static int __PropertyOffset_LocalConeDirection;

		// Token: 0x040025AD RID: 9645
		internal static int __PropertyOffset_ConstrainBounce;

		// Token: 0x040025AE RID: 9646
		internal static int __PropertyOffset_bConstrainTwist;

		// Token: 0x040025AF RID: 9647
		internal static int __PropertyOffset_ImpactMinStrength;

		// Token: 0x040025B0 RID: 9648
		internal static int __PropertyOffset_MinTimeBetweenImpacts;

		// Token: 0x040025B1 RID: 9649
		internal static int __PropertyOffset_OnConstraintHit;

		// Token: 0x040025B2 RID: 9650
		[Nullable(2)]
		private FKuroPhysicsConeRotateConstraintHit _OnConstraintHit;
	}
}
