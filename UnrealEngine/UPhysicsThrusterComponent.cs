using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE9 RID: 4073
	[UnrealObjectPath("/Script/Engine.PhysicsThrusterComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UPhysicsThrusterComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DC9C RID: 56476 RVA: 0x00144B77 File Offset: 0x00142D77
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsThrusterComponent._ClassPtr;
		}

		// Token: 0x0600DC9D RID: 56477 RVA: 0x00144B84 File Offset: 0x00142D84
		public UPhysicsThrusterComponent() : this(BuiltinUtils.AllocNativeUObject(UPhysicsThrusterComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DC9E RID: 56478 RVA: 0x00144BAC File Offset: 0x00142DAC
		[NullableContext(1)]
		public UPhysicsThrusterComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsThrusterComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600DC9F RID: 56479 RVA: 0x00144BDF File Offset: 0x00142DDF
		// (set) Token: 0x0600DCA0 RID: 56480 RVA: 0x00144BEF File Offset: 0x00142DEF
		public unsafe float ThrustStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsThrusterComponent.__PropertyOffset_ThrustStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsThrusterComponent.__PropertyOffset_ThrustStrength) = value;
			}
		}

		// Token: 0x0600DCA1 RID: 56481 RVA: 0x00144C00 File Offset: 0x00142E00
		static UPhysicsThrusterComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsThrusterComponent");
		}

		// Token: 0x0600DCA2 RID: 56482 RVA: 0x00144C0E File Offset: 0x00142E0E
		protected UPhysicsThrusterComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007730 RID: 30512
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsThrusterComponent";

		// Token: 0x04007731 RID: 30513
		private static IntPtr _ClassPtr;

		// Token: 0x04007732 RID: 30514
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007733 RID: 30515
		internal static int __PropertyOffset_ThrustStrength;
	}
}
