using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F61 RID: 3937
	[UnrealObjectPath("/Script/Engine.ParticleModuleColorBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleColorBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4A9 RID: 54441 RVA: 0x001387D6 File Offset: 0x001369D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleColorBase._ClassPtr;
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x001387E2 File Offset: 0x001369E2
		static UParticleModuleColorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleColorBase");
		}

		// Token: 0x0600D4AB RID: 54443 RVA: 0x001387F0 File Offset: 0x001369F0
		protected UParticleModuleColorBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4AC RID: 54444 RVA: 0x00138818 File Offset: 0x00136A18
		protected UParticleModuleColorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400727D RID: 29309
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleColorBase";

		// Token: 0x0400727E RID: 29310
		private static IntPtr _ClassPtr;

		// Token: 0x0400727F RID: 29311
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
