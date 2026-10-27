using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F56 RID: 3926
	[UnrealObjectPath("/Script/Engine.ParticleModuleBeamBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleBeamBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D3D3 RID: 54227 RVA: 0x00136DBD File Offset: 0x00134FBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleBeamBase._ClassPtr;
		}

		// Token: 0x0600D3D4 RID: 54228 RVA: 0x00136DC9 File Offset: 0x00134FC9
		static UParticleModuleBeamBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleBeamBase");
		}

		// Token: 0x0600D3D5 RID: 54229 RVA: 0x00136DD8 File Offset: 0x00134FD8
		protected UParticleModuleBeamBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x00136E00 File Offset: 0x00135000
		protected UParticleModuleBeamBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040071D5 RID: 29141
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleBeamBase";

		// Token: 0x040071D6 RID: 29142
		private static IntPtr _ClassPtr;

		// Token: 0x040071D7 RID: 29143
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
