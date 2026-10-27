using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F9E RID: 3998
	[UnrealObjectPath("/Script/Engine.ParticleModuleSizeBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleSizeBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D736 RID: 55094 RVA: 0x0013D241 File Offset: 0x0013B441
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSizeBase._ClassPtr;
		}

		// Token: 0x0600D737 RID: 55095 RVA: 0x0013D24D File Offset: 0x0013B44D
		static UParticleModuleSizeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSizeBase");
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x0013D25C File Offset: 0x0013B45C
		protected UParticleModuleSizeBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSizeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D739 RID: 55097 RVA: 0x0013D284 File Offset: 0x0013B484
		protected UParticleModuleSizeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400745E RID: 29790
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSizeBase";

		// Token: 0x0400745F RID: 29791
		private static IntPtr _ClassPtr;

		// Token: 0x04007460 RID: 29792
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
