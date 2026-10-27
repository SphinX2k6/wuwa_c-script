using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F8D RID: 3981
	[UnrealObjectPath("/Script/Engine.ParticleModuleOrbitBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UParticleModuleOrbitBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D66E RID: 54894 RVA: 0x0013BD81 File Offset: 0x00139F81
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleOrbitBase._ClassPtr;
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600D66F RID: 54895 RVA: 0x0013BD8D File Offset: 0x00139F8D
		// (set) Token: 0x0600D670 RID: 54896 RVA: 0x0013BDA6 File Offset: 0x00139FA6
		public unsafe bool bUseEmitterTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleOrbitBase.__PropertyOffset_bUseEmitterTime) & UParticleModuleOrbitBase.__PropertyMask_bUseEmitterTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleOrbitBase.__PropertyOffset_bUseEmitterTime) = ((*(base.NativePtr + (IntPtr)UParticleModuleOrbitBase.__PropertyOffset_bUseEmitterTime) & ~UParticleModuleOrbitBase.__PropertyMask_bUseEmitterTime) | (value ? UParticleModuleOrbitBase.__PropertyMask_bUseEmitterTime : 0));
			}
		}

		// Token: 0x0600D671 RID: 54897 RVA: 0x0013BDD6 File Offset: 0x00139FD6
		static UParticleModuleOrbitBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleOrbitBase");
		}

		// Token: 0x0600D672 RID: 54898 RVA: 0x0013BDE4 File Offset: 0x00139FE4
		protected UParticleModuleOrbitBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleOrbitBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x0013BE0C File Offset: 0x0013A00C
		protected UParticleModuleOrbitBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073D3 RID: 29651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleOrbitBase";

		// Token: 0x040073D4 RID: 29652
		private static IntPtr _ClassPtr;

		// Token: 0x040073D5 RID: 29653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073D6 RID: 29654
		internal static int __PropertyOffset_bUseEmitterTime;

		// Token: 0x040073D7 RID: 29655
		internal static byte __PropertyMask_bUseEmitterTime;
	}
}
