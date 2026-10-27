using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FAA RID: 4010
	[UnrealObjectPath("/Script/Engine.ParticleModuleTrailBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleTrailBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D7B3 RID: 55219 RVA: 0x0013E0EA File Offset: 0x0013C2EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTrailBase._ClassPtr;
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x0013E0F6 File Offset: 0x0013C2F6
		static UParticleModuleTrailBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTrailBase");
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x0013E104 File Offset: 0x0013C304
		protected UParticleModuleTrailBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTrailBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x0013E12C File Offset: 0x0013C32C
		protected UParticleModuleTrailBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074BE RID: 29886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTrailBase";

		// Token: 0x040074BF RID: 29887
		private static IntPtr _ClassPtr;

		// Token: 0x040074C0 RID: 29888
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
