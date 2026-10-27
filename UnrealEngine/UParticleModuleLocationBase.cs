using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F75 RID: 3957
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleLocationBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D560 RID: 54624 RVA: 0x00139CFB File Offset: 0x00137EFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationBase._ClassPtr;
		}

		// Token: 0x0600D561 RID: 54625 RVA: 0x00139D07 File Offset: 0x00137F07
		static UParticleModuleLocationBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationBase");
		}

		// Token: 0x0600D562 RID: 54626 RVA: 0x00139D18 File Offset: 0x00137F18
		protected UParticleModuleLocationBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D563 RID: 54627 RVA: 0x00139D40 File Offset: 0x00137F40
		protected UParticleModuleLocationBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007308 RID: 29448
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationBase";

		// Token: 0x04007309 RID: 29449
		private static IntPtr _ClassPtr;

		// Token: 0x0400730A RID: 29450
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
