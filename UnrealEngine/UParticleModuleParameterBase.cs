using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F90 RID: 3984
	[UnrealObjectPath("/Script/Engine.ParticleModuleParameterBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleParameterBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D67F RID: 54911 RVA: 0x0013BF0D File Offset: 0x0013A10D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleParameterBase._ClassPtr;
		}

		// Token: 0x0600D680 RID: 54912 RVA: 0x0013BF19 File Offset: 0x0013A119
		static UParticleModuleParameterBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleParameterBase");
		}

		// Token: 0x0600D681 RID: 54913 RVA: 0x0013BF28 File Offset: 0x0013A128
		protected UParticleModuleParameterBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleParameterBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D682 RID: 54914 RVA: 0x0013BF50 File Offset: 0x0013A150
		protected UParticleModuleParameterBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073DF RID: 29663
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleParameterBase";

		// Token: 0x040073E0 RID: 29664
		private static IntPtr _ClassPtr;

		// Token: 0x040073E1 RID: 29665
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
