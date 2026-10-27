using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F84 RID: 3972
	[UnrealObjectPath("/Script/Engine.ParticleModuleMaterialBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleMaterialBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D622 RID: 54818 RVA: 0x0013B3E5 File Offset: 0x001395E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMaterialBase._ClassPtr;
		}

		// Token: 0x0600D623 RID: 54819 RVA: 0x0013B3F1 File Offset: 0x001395F1
		static UParticleModuleMaterialBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMaterialBase");
		}

		// Token: 0x0600D624 RID: 54820 RVA: 0x0013B400 File Offset: 0x00139600
		protected UParticleModuleMaterialBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMaterialBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D625 RID: 54821 RVA: 0x0013B428 File Offset: 0x00139628
		protected UParticleModuleMaterialBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007399 RID: 29593
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMaterialBase";

		// Token: 0x0400739A RID: 29594
		private static IntPtr _ClassPtr;

		// Token: 0x0400739B RID: 29595
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
