using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FBA RID: 4026
	[UnrealObjectPath("/Script/Engine.ParticleModuleVelocityBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UParticleModuleVelocityBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8C2 RID: 55490 RVA: 0x0013FE0D File Offset: 0x0013E00D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVelocityBase._ClassPtr;
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600D8C3 RID: 55491 RVA: 0x0013FE19 File Offset: 0x0013E019
		// (set) Token: 0x0600D8C4 RID: 55492 RVA: 0x0013FE32 File Offset: 0x0013E032
		public unsafe bool bInWorldSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVelocityBase.__PropertyOffset_bInWorldSpace) & UParticleModuleVelocityBase.__PropertyMask_bInWorldSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVelocityBase.__PropertyOffset_bInWorldSpace) = ((*(base.NativePtr + (IntPtr)UParticleModuleVelocityBase.__PropertyOffset_bInWorldSpace) & ~UParticleModuleVelocityBase.__PropertyMask_bInWorldSpace) | (value ? UParticleModuleVelocityBase.__PropertyMask_bInWorldSpace : 0));
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600D8C5 RID: 55493 RVA: 0x0013FE62 File Offset: 0x0013E062
		// (set) Token: 0x0600D8C6 RID: 55494 RVA: 0x0013FE7B File Offset: 0x0013E07B
		public unsafe bool bApplyOwnerScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVelocityBase.__PropertyOffset_bApplyOwnerScale) & UParticleModuleVelocityBase.__PropertyMask_bApplyOwnerScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVelocityBase.__PropertyOffset_bApplyOwnerScale) = ((*(base.NativePtr + (IntPtr)UParticleModuleVelocityBase.__PropertyOffset_bApplyOwnerScale) & ~UParticleModuleVelocityBase.__PropertyMask_bApplyOwnerScale) | (value ? UParticleModuleVelocityBase.__PropertyMask_bApplyOwnerScale : 0));
			}
		}

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x0013FEAB File Offset: 0x0013E0AB
		static UParticleModuleVelocityBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVelocityBase");
		}

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x0013FEBC File Offset: 0x0013E0BC
		protected UParticleModuleVelocityBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocityBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8C9 RID: 55497 RVA: 0x0013FEE4 File Offset: 0x0013E0E4
		protected UParticleModuleVelocityBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007581 RID: 30081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVelocityBase";

		// Token: 0x04007582 RID: 30082
		private static IntPtr _ClassPtr;

		// Token: 0x04007583 RID: 30083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007584 RID: 30084
		internal static int __PropertyOffset_bInWorldSpace;

		// Token: 0x04007585 RID: 30085
		internal static byte __PropertyMask_bInWorldSpace;

		// Token: 0x04007586 RID: 30086
		internal static int __PropertyOffset_bApplyOwnerScale;

		// Token: 0x04007587 RID: 30087
		internal static byte __PropertyMask_bApplyOwnerScale;
	}
}
