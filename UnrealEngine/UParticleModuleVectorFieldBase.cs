using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB2 RID: 4018
	[UnrealObjectPath("/Script/Engine.ParticleModuleVectorFieldBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleVectorFieldBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D86D RID: 55405 RVA: 0x0013F52A File Offset: 0x0013D72A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVectorFieldBase._ClassPtr;
		}

		// Token: 0x0600D86E RID: 55406 RVA: 0x0013F536 File Offset: 0x0013D736
		static UParticleModuleVectorFieldBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVectorFieldBase");
		}

		// Token: 0x0600D86F RID: 55407 RVA: 0x0013F544 File Offset: 0x0013D744
		protected UParticleModuleVectorFieldBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x0013F56C File Offset: 0x0013D76C
		protected UParticleModuleVectorFieldBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007548 RID: 30024
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVectorFieldBase";

		// Token: 0x04007549 RID: 30025
		private static IntPtr _ClassPtr;

		// Token: 0x0400754A RID: 30026
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
