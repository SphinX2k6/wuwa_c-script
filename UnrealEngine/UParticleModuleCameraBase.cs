using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F5B RID: 3931
	[UnrealObjectPath("/Script/Engine.ParticleModuleCameraBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleCameraBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D44D RID: 54349 RVA: 0x00137D23 File Offset: 0x00135F23
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleCameraBase._ClassPtr;
		}

		// Token: 0x0600D44E RID: 54350 RVA: 0x00137D2F File Offset: 0x00135F2F
		static UParticleModuleCameraBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleCameraBase");
		}

		// Token: 0x0600D44F RID: 54351 RVA: 0x00137D40 File Offset: 0x00135F40
		protected UParticleModuleCameraBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCameraBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D450 RID: 54352 RVA: 0x00137D68 File Offset: 0x00135F68
		protected UParticleModuleCameraBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007237 RID: 29239
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleCameraBase";

		// Token: 0x04007238 RID: 29240
		private static IntPtr _ClassPtr;

		// Token: 0x04007239 RID: 29241
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
