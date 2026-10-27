using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F65 RID: 3941
	[UnrealObjectPath("/Script/Engine.ParticleModuleEventBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleEventBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4CA RID: 54474 RVA: 0x00138BFD File Offset: 0x00136DFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleEventBase._ClassPtr;
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x00138C09 File Offset: 0x00136E09
		static UParticleModuleEventBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleEventBase");
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x00138C18 File Offset: 0x00136E18
		protected UParticleModuleEventBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4CD RID: 54477 RVA: 0x00138C40 File Offset: 0x00136E40
		protected UParticleModuleEventBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007297 RID: 29335
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleEventBase";

		// Token: 0x04007298 RID: 29336
		private static IntPtr _ClassPtr;

		// Token: 0x04007299 RID: 29337
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
