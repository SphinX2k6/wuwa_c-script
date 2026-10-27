using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F96 RID: 3990
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotationBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleRotationBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D702 RID: 55042 RVA: 0x0013CC39 File Offset: 0x0013AE39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotationBase._ClassPtr;
		}

		// Token: 0x0600D703 RID: 55043 RVA: 0x0013CC45 File Offset: 0x0013AE45
		static UParticleModuleRotationBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotationBase");
		}

		// Token: 0x0600D704 RID: 55044 RVA: 0x0013CC54 File Offset: 0x0013AE54
		protected UParticleModuleRotationBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D705 RID: 55045 RVA: 0x0013CC7C File Offset: 0x0013AE7C
		protected UParticleModuleRotationBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007438 RID: 29752
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotationBase";

		// Token: 0x04007439 RID: 29753
		private static IntPtr _ClassPtr;

		// Token: 0x0400743A RID: 29754
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
