using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FAD RID: 4013
	[UnrealObjectPath("/Script/Engine.ParticleModuleTypeDataBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleTypeDataBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D7DF RID: 55263 RVA: 0x0013E565 File Offset: 0x0013C765
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTypeDataBase._ClassPtr;
		}

		// Token: 0x0600D7E0 RID: 55264 RVA: 0x0013E571 File Offset: 0x0013C771
		static UParticleModuleTypeDataBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTypeDataBase");
		}

		// Token: 0x0600D7E1 RID: 55265 RVA: 0x0013E580 File Offset: 0x0013C780
		protected UParticleModuleTypeDataBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x0013E5A8 File Offset: 0x0013C7A8
		protected UParticleModuleTypeDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074DD RID: 29917
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTypeDataBase";

		// Token: 0x040074DE RID: 29918
		private static IntPtr _ClassPtr;

		// Token: 0x040074DF RID: 29919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
