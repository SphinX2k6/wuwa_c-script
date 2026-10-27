using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA5 RID: 4005
	[UnrealObjectPath("/Script/Engine.ParticleModuleSpawnBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UParticleModuleSpawnBase : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D77C RID: 55164 RVA: 0x0013DACA File Offset: 0x0013BCCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSpawnBase._ClassPtr;
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600D77D RID: 55165 RVA: 0x0013DAD6 File Offset: 0x0013BCD6
		// (set) Token: 0x0600D77E RID: 55166 RVA: 0x0013DAEF File Offset: 0x0013BCEF
		public unsafe bool bProcessSpawnRate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSpawnBase.__PropertyOffset_bProcessSpawnRate) & UParticleModuleSpawnBase.__PropertyMask_bProcessSpawnRate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSpawnBase.__PropertyOffset_bProcessSpawnRate) = ((*(base.NativePtr + (IntPtr)UParticleModuleSpawnBase.__PropertyOffset_bProcessSpawnRate) & ~UParticleModuleSpawnBase.__PropertyMask_bProcessSpawnRate) | (value ? UParticleModuleSpawnBase.__PropertyMask_bProcessSpawnRate : 0));
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600D77F RID: 55167 RVA: 0x0013DB1F File Offset: 0x0013BD1F
		// (set) Token: 0x0600D780 RID: 55168 RVA: 0x0013DB38 File Offset: 0x0013BD38
		public unsafe bool bProcessBurstList
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSpawnBase.__PropertyOffset_bProcessBurstList) & UParticleModuleSpawnBase.__PropertyMask_bProcessBurstList) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSpawnBase.__PropertyOffset_bProcessBurstList) = ((*(base.NativePtr + (IntPtr)UParticleModuleSpawnBase.__PropertyOffset_bProcessBurstList) & ~UParticleModuleSpawnBase.__PropertyMask_bProcessBurstList) | (value ? UParticleModuleSpawnBase.__PropertyMask_bProcessBurstList : 0));
			}
		}

		// Token: 0x0600D781 RID: 55169 RVA: 0x0013DB68 File Offset: 0x0013BD68
		static UParticleModuleSpawnBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSpawnBase");
		}

		// Token: 0x0600D782 RID: 55170 RVA: 0x0013DB78 File Offset: 0x0013BD78
		protected UParticleModuleSpawnBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSpawnBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D783 RID: 55171 RVA: 0x0013DBA0 File Offset: 0x0013BDA0
		protected UParticleModuleSpawnBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007494 RID: 29844
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSpawnBase";

		// Token: 0x04007495 RID: 29845
		private static IntPtr _ClassPtr;

		// Token: 0x04007496 RID: 29846
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007497 RID: 29847
		internal static int __PropertyOffset_bProcessSpawnRate;

		// Token: 0x04007498 RID: 29848
		internal static byte __PropertyMask_bProcessSpawnRate;

		// Token: 0x04007499 RID: 29849
		internal static int __PropertyOffset_bProcessBurstList;

		// Token: 0x0400749A RID: 29850
		internal static byte __PropertyMask_bProcessBurstList;
	}
}
