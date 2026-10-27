using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F99 RID: 3993
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotationRateBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleRotationRateBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D716 RID: 55062 RVA: 0x0013CE85 File Offset: 0x0013B085
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotationRateBase._ClassPtr;
		}

		// Token: 0x0600D717 RID: 55063 RVA: 0x0013CE91 File Offset: 0x0013B091
		static UParticleModuleRotationRateBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotationRateBase");
		}

		// Token: 0x0600D718 RID: 55064 RVA: 0x0013CEA0 File Offset: 0x0013B0A0
		protected UParticleModuleRotationRateBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationRateBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D719 RID: 55065 RVA: 0x0013CEC8 File Offset: 0x0013B0C8
		protected UParticleModuleRotationRateBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007447 RID: 29767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotationRateBase";

		// Token: 0x04007448 RID: 29768
		private static IntPtr _ClassPtr;

		// Token: 0x04007449 RID: 29769
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
