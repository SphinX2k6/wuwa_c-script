using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB6 RID: 4022
	[UnrealObjectPath("/Script/Engine.ParticleModuleVectorFieldRotationRate")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UParticleModuleVectorFieldRotationRate : UParticleModuleVectorFieldBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8A0 RID: 55456 RVA: 0x0013FA28 File Offset: 0x0013DC28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVectorFieldRotationRate._ClassPtr;
		}

		// Token: 0x0600D8A1 RID: 55457 RVA: 0x0013FA34 File Offset: 0x0013DC34
		public UParticleModuleVectorFieldRotationRate() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldRotationRate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8A2 RID: 55458 RVA: 0x0013FA5C File Offset: 0x0013DC5C
		[NullableContext(1)]
		public UParticleModuleVectorFieldRotationRate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldRotationRate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600D8A3 RID: 55459 RVA: 0x0013FA8F File Offset: 0x0013DC8F
		// (set) Token: 0x0600D8A4 RID: 55460 RVA: 0x0013FAA3 File Offset: 0x0013DCA3
		public unsafe FVector RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldRotationRate.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldRotationRate.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x0600D8A5 RID: 55461 RVA: 0x0013FAB8 File Offset: 0x0013DCB8
		static UParticleModuleVectorFieldRotationRate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVectorFieldRotationRate");
		}

		// Token: 0x0600D8A6 RID: 55462 RVA: 0x0013FAC6 File Offset: 0x0013DCC6
		protected UParticleModuleVectorFieldRotationRate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400756A RID: 30058
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVectorFieldRotationRate";

		// Token: 0x0400756B RID: 30059
		private static IntPtr _ClassPtr;

		// Token: 0x0400756C RID: 30060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400756D RID: 30061
		internal static int __PropertyOffset_RotationRate;
	}
}
