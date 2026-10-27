using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F5E RID: 3934
	[UnrealObjectPath("/Script/Engine.ParticleModuleCollisionBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleCollisionBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D483 RID: 54403 RVA: 0x001383DD File Offset: 0x001365DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleCollisionBase._ClassPtr;
		}

		// Token: 0x0600D484 RID: 54404 RVA: 0x001383E9 File Offset: 0x001365E9
		static UParticleModuleCollisionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleCollisionBase");
		}

		// Token: 0x0600D485 RID: 54405 RVA: 0x001383F8 File Offset: 0x001365F8
		protected UParticleModuleCollisionBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCollisionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D486 RID: 54406 RVA: 0x00138420 File Offset: 0x00136620
		protected UParticleModuleCollisionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007263 RID: 29283
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleCollisionBase";

		// Token: 0x04007264 RID: 29284
		private static IntPtr _ClassPtr;

		// Token: 0x04007265 RID: 29285
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
