using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA8 RID: 4008
	[UnrealObjectPath("/Script/Engine.ParticleModuleSubUVBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleSubUVBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D7A4 RID: 55204 RVA: 0x0013DF5A File Offset: 0x0013C15A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSubUVBase._ClassPtr;
		}

		// Token: 0x0600D7A5 RID: 55205 RVA: 0x0013DF66 File Offset: 0x0013C166
		static UParticleModuleSubUVBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSubUVBase");
		}

		// Token: 0x0600D7A6 RID: 55206 RVA: 0x0013DF74 File Offset: 0x0013C174
		protected UParticleModuleSubUVBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSubUVBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x0013DF9C File Offset: 0x0013C19C
		protected UParticleModuleSubUVBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074B3 RID: 29875
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSubUVBase";

		// Token: 0x040074B4 RID: 29876
		private static IntPtr _ClassPtr;

		// Token: 0x040074B5 RID: 29877
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
