using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000388 RID: 904
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponent")]
	[UnrealStructLayout(832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 832)]
	public class UKuroFauxPhysicsFreeRotateComponent : UKuroFauxPhysicsRotateComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005ABC RID: 23228 RVA: 0x00080299 File Offset: 0x0007E499
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsFreeRotateComponent._ClassPtr;
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x000802A8 File Offset: 0x0007E4A8
		public UKuroFauxPhysicsFreeRotateComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsFreeRotateComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x000802D0 File Offset: 0x0007E4D0
		[NullableContext(1)]
		public UKuroFauxPhysicsFreeRotateComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsFreeRotateComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06005ABF RID: 23231 RVA: 0x00080303 File Offset: 0x0007E503
		// (set) Token: 0x06005AC0 RID: 23232 RVA: 0x00080313 File Offset: 0x0007E513
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

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00080324 File Offset: 0x0007E524
		static UKuroFauxPhysicsFreeRotateComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponent");
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00080332 File Offset: 0x0007E532
		protected UKuroFauxPhysicsFreeRotateComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040025B3 RID: 9651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponent";

		// Token: 0x040025B4 RID: 9652
		private static IntPtr _ClassPtr;

		// Token: 0x040025B5 RID: 9653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040025B6 RID: 9654
		internal static int __PropertyOffset_ConstrainedAngularVelocityDegrees;
	}
}
