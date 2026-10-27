using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F72 RID: 3954
	[UnrealObjectPath("/Script/Engine.ParticleModuleLightBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleLightBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D54A RID: 54602 RVA: 0x00139AB4 File Offset: 0x00137CB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLightBase._ClassPtr;
		}

		// Token: 0x0600D54B RID: 54603 RVA: 0x00139AC0 File Offset: 0x00137CC0
		static UParticleModuleLightBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLightBase");
		}

		// Token: 0x0600D54C RID: 54604 RVA: 0x00139AD0 File Offset: 0x00137CD0
		protected UParticleModuleLightBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLightBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D54D RID: 54605 RVA: 0x00139AF8 File Offset: 0x00137CF8
		protected UParticleModuleLightBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072F9 RID: 29433
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLightBase";

		// Token: 0x040072FA RID: 29434
		private static IntPtr _ClassPtr;

		// Token: 0x040072FB RID: 29435
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
