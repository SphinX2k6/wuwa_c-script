using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F51 RID: 3921
	[UnrealObjectPath("/Script/Engine.ParticleModuleAttractorBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleAttractorBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D37F RID: 54143 RVA: 0x0013635D File Offset: 0x0013455D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAttractorBase._ClassPtr;
		}

		// Token: 0x0600D380 RID: 54144 RVA: 0x00136369 File Offset: 0x00134569
		static UParticleModuleAttractorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAttractorBase");
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x00136378 File Offset: 0x00134578
		protected UParticleModuleAttractorBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D382 RID: 54146 RVA: 0x001363A0 File Offset: 0x001345A0
		protected UParticleModuleAttractorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007192 RID: 29074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAttractorBase";

		// Token: 0x04007193 RID: 29075
		private static IntPtr _ClassPtr;

		// Token: 0x04007194 RID: 29076
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
