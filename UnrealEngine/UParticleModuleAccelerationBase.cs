using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F4C RID: 3916
	[UnrealObjectPath("/Script/Engine.ParticleModuleAccelerationBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UParticleModuleAccelerationBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D359 RID: 54105 RVA: 0x00135F3A File Offset: 0x0013413A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAccelerationBase._ClassPtr;
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600D35A RID: 54106 RVA: 0x00135F46 File Offset: 0x00134146
		// (set) Token: 0x0600D35B RID: 54107 RVA: 0x00135F5F File Offset: 0x0013415F
		public unsafe bool bAlwaysInWorldSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAccelerationBase.__PropertyOffset_bAlwaysInWorldSpace) & UParticleModuleAccelerationBase.__PropertyMask_bAlwaysInWorldSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAccelerationBase.__PropertyOffset_bAlwaysInWorldSpace) = ((*(base.NativePtr + (IntPtr)UParticleModuleAccelerationBase.__PropertyOffset_bAlwaysInWorldSpace) & ~UParticleModuleAccelerationBase.__PropertyMask_bAlwaysInWorldSpace) | (value ? UParticleModuleAccelerationBase.__PropertyMask_bAlwaysInWorldSpace : 0));
			}
		}

		// Token: 0x0600D35C RID: 54108 RVA: 0x00135F8F File Offset: 0x0013418F
		static UParticleModuleAccelerationBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAccelerationBase");
		}

		// Token: 0x0600D35D RID: 54109 RVA: 0x00135FA0 File Offset: 0x001341A0
		protected UParticleModuleAccelerationBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D35E RID: 54110 RVA: 0x00135FC8 File Offset: 0x001341C8
		protected UParticleModuleAccelerationBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007178 RID: 29048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAccelerationBase";

		// Token: 0x04007179 RID: 29049
		private static IntPtr _ClassPtr;

		// Token: 0x0400717A RID: 29050
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400717B RID: 29051
		internal static int __PropertyOffset_bAlwaysInWorldSpace;

		// Token: 0x0400717C RID: 29052
		internal static byte __PropertyMask_bAlwaysInWorldSpace;
	}
}
