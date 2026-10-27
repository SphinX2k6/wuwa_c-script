using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F6B RID: 3947
	[UnrealObjectPath("/Script/Engine.ParticleModuleKillBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleKillBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4FB RID: 54523 RVA: 0x0013916D File Offset: 0x0013736D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleKillBase._ClassPtr;
		}

		// Token: 0x0600D4FC RID: 54524 RVA: 0x00139179 File Offset: 0x00137379
		static UParticleModuleKillBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleKillBase");
		}

		// Token: 0x0600D4FD RID: 54525 RVA: 0x00139188 File Offset: 0x00137388
		protected UParticleModuleKillBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleKillBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4FE RID: 54526 RVA: 0x001391B0 File Offset: 0x001373B0
		protected UParticleModuleKillBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072BD RID: 29373
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleKillBase";

		// Token: 0x040072BE RID: 29374
		private static IntPtr _ClassPtr;

		// Token: 0x040072BF RID: 29375
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
