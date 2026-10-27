using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F6F RID: 3951
	[UnrealObjectPath("/Script/Engine.ParticleModuleLifetimeBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleLifetimeBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D522 RID: 54562 RVA: 0x00139659 File Offset: 0x00137859
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLifetimeBase._ClassPtr;
		}

		// Token: 0x0600D523 RID: 54563 RVA: 0x00139665 File Offset: 0x00137865
		static UParticleModuleLifetimeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLifetimeBase");
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x00139674 File Offset: 0x00137874
		protected UParticleModuleLifetimeBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLifetimeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D525 RID: 54565 RVA: 0x0013969C File Offset: 0x0013789C
		protected UParticleModuleLifetimeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072DD RID: 29405
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLifetimeBase";

		// Token: 0x040072DE RID: 29406
		private static IntPtr _ClassPtr;

		// Token: 0x040072DF RID: 29407
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
