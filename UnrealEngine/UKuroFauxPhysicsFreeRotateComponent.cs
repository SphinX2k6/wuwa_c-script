using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001843 RID: 6211
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponent")]
	[UnrealStructLayout(832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 832)]
	public class UKuroFauxPhysicsFreeRotateComponent : UKuroFauxPhysicsRotateComponentBase, IUnrealUObject, IUnrealObject, IKuroFreeVisualizedInterface, IUnrealNativeInterface, IUnrealInterface, IKuroVisualizedInterface
	{
		// Token: 0x06016E6A RID: 93802 RVA: 0x00216BA6 File Offset: 0x00214DA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsFreeRotateComponent._ClassPtr;
		}

		// Token: 0x06016E6B RID: 93803 RVA: 0x00216BB2 File Offset: 0x00214DB2
		int IKuroFreeVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsFreeRotateComponent.__InterfaceOffset_IKuroFreeVisualizedInterface;
		}

		// Token: 0x06016E6C RID: 93804 RVA: 0x00216BB9 File Offset: 0x00214DB9
		int IKuroVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsFreeRotateComponent.__InterfaceOffset_IKuroVisualizedInterface;
		}

		// Token: 0x06016E6D RID: 93805 RVA: 0x00216BC0 File Offset: 0x00214DC0
		public UKuroFauxPhysicsFreeRotateComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsFreeRotateComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E6E RID: 93806 RVA: 0x00216BE8 File Offset: 0x00214DE8
		[NullableContext(1)]
		public UKuroFauxPhysicsFreeRotateComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsFreeRotateComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C60 RID: 23648
		// (get) Token: 0x06016E6F RID: 93807 RVA: 0x00216C1B File Offset: 0x00214E1B
		// (set) Token: 0x06016E70 RID: 93808 RVA: 0x00216C2B File Offset: 0x00214E2B
		public unsafe float ConstrainedAngularVelocityDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsFreeRotateComponent.__PropertyOffset_ConstrainedAngularVelocityDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsFreeRotateComponent.__PropertyOffset_ConstrainedAngularVelocityDegrees) = value;
			}
		}

		// Token: 0x06016E71 RID: 93809 RVA: 0x00216C3C File Offset: 0x00214E3C
		static UKuroFauxPhysicsFreeRotateComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponent");
		}

		// Token: 0x06016E72 RID: 93810 RVA: 0x00216C4A File Offset: 0x00214E4A
		protected UKuroFauxPhysicsFreeRotateComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C71C RID: 50972
		internal static int __InterfaceOffset_IKuroFreeVisualizedInterface;

		// Token: 0x0400C71D RID: 50973
		internal static int __InterfaceOffset_IKuroVisualizedInterface;

		// Token: 0x0400C71E RID: 50974
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponent";

		// Token: 0x0400C71F RID: 50975
		private static IntPtr _ClassPtr;

		// Token: 0x0400C720 RID: 50976
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C721 RID: 50977
		internal static int __PropertyOffset_ConstrainedAngularVelocityDegrees;
	}
}
