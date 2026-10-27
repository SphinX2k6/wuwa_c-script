using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F8F RID: 3983
	[UnrealObjectPath("/Script/Engine.ParticleModuleOrientationBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UParticleModuleOrientationBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D67B RID: 54907 RVA: 0x0013BEBF File Offset: 0x0013A0BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleOrientationBase._ClassPtr;
		}

		// Token: 0x0600D67C RID: 54908 RVA: 0x0013BECB File Offset: 0x0013A0CB
		static UParticleModuleOrientationBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleOrientationBase");
		}

		// Token: 0x0600D67D RID: 54909 RVA: 0x0013BEDC File Offset: 0x0013A0DC
		protected UParticleModuleOrientationBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleOrientationBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D67E RID: 54910 RVA: 0x0013BF04 File Offset: 0x0013A104
		protected UParticleModuleOrientationBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073DC RID: 29660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleOrientationBase";

		// Token: 0x040073DD RID: 29661
		private static IntPtr _ClassPtr;

		// Token: 0x040073DE RID: 29662
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
