using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F69 RID: 3945
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleEventReceiverSpawn")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UParticleModuleEventReceiverSpawn : UParticleModuleEventReceiverBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4E4 RID: 54500 RVA: 0x00138E7B File Offset: 0x0013707B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleEventReceiverSpawn._ClassPtr;
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x00138E88 File Offset: 0x00137088
		public UParticleModuleEventReceiverSpawn() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventReceiverSpawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x00138EB0 File Offset: 0x001370B0
		public UParticleModuleEventReceiverSpawn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventReceiverSpawn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600D4E7 RID: 54503 RVA: 0x00138EE4 File Offset: 0x001370E4
		// (set) Token: 0x0600D4E8 RID: 54504 RVA: 0x00138F1D File Offset: 0x0013711D
		public FRawDistributionFloat SpawnCount
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._SpawnCount) == null)
				{
					result = (this._SpawnCount = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_SpawnCount, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_SpawnCount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600D4E9 RID: 54505 RVA: 0x00138F3E File Offset: 0x0013713E
		// (set) Token: 0x0600D4EA RID: 54506 RVA: 0x00138F57 File Offset: 0x00137157
		public unsafe bool bUseParticleTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bUseParticleTime) & UParticleModuleEventReceiverSpawn.__PropertyMask_bUseParticleTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bUseParticleTime) = ((*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bUseParticleTime) & ~UParticleModuleEventReceiverSpawn.__PropertyMask_bUseParticleTime) | (value ? UParticleModuleEventReceiverSpawn.__PropertyMask_bUseParticleTime : 0));
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600D4EB RID: 54507 RVA: 0x00138F87 File Offset: 0x00137187
		// (set) Token: 0x0600D4EC RID: 54508 RVA: 0x00138FA0 File Offset: 0x001371A0
		public unsafe bool bUsePSysLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bUsePSysLocation) & UParticleModuleEventReceiverSpawn.__PropertyMask_bUsePSysLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bUsePSysLocation) = ((*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bUsePSysLocation) & ~UParticleModuleEventReceiverSpawn.__PropertyMask_bUsePSysLocation) | (value ? UParticleModuleEventReceiverSpawn.__PropertyMask_bUsePSysLocation : 0));
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600D4ED RID: 54509 RVA: 0x00138FD0 File Offset: 0x001371D0
		// (set) Token: 0x0600D4EE RID: 54510 RVA: 0x00138FE9 File Offset: 0x001371E9
		public unsafe bool bInheritVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bInheritVelocity) & UParticleModuleEventReceiverSpawn.__PropertyMask_bInheritVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bInheritVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bInheritVelocity) & ~UParticleModuleEventReceiverSpawn.__PropertyMask_bInheritVelocity) | (value ? UParticleModuleEventReceiverSpawn.__PropertyMask_bInheritVelocity : 0));
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600D4EF RID: 54511 RVA: 0x0013901C File Offset: 0x0013721C
		// (set) Token: 0x0600D4F0 RID: 54512 RVA: 0x00139055 File Offset: 0x00137255
		public FRawDistributionVector InheritVelocityScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._InheritVelocityScale) == null)
				{
					result = (this._InheritVelocityScale = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_InheritVelocityScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_InheritVelocityScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600D4F1 RID: 54513 RVA: 0x00139078 File Offset: 0x00137278
		// (set) Token: 0x0600D4F2 RID: 54514 RVA: 0x001390B1 File Offset: 0x001372B1
		public TArray<UPhysicalMaterial> PhysicalMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicalMaterial> result;
				if ((result = this._PhysicalMaterials) == null)
				{
					result = (this._PhysicalMaterials = new TArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_PhysicalMaterials, this));
				}
				return result;
			}
			set
			{
				this.PhysicalMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600D4F3 RID: 54515 RVA: 0x001390BF File Offset: 0x001372BF
		// (set) Token: 0x0600D4F4 RID: 54516 RVA: 0x001390D8 File Offset: 0x001372D8
		public unsafe bool bBanPhysicalMaterials
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bBanPhysicalMaterials) & UParticleModuleEventReceiverSpawn.__PropertyMask_bBanPhysicalMaterials) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bBanPhysicalMaterials) = ((*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverSpawn.__PropertyOffset_bBanPhysicalMaterials) & ~UParticleModuleEventReceiverSpawn.__PropertyMask_bBanPhysicalMaterials) | (value ? UParticleModuleEventReceiverSpawn.__PropertyMask_bBanPhysicalMaterials : 0));
			}
		}

		// Token: 0x0600D4F5 RID: 54517 RVA: 0x00139108 File Offset: 0x00137308
		static UParticleModuleEventReceiverSpawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleEventReceiverSpawn");
		}

		// Token: 0x0600D4F6 RID: 54518 RVA: 0x00139116 File Offset: 0x00137316
		protected UParticleModuleEventReceiverSpawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072A9 RID: 29353
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleEventReceiverSpawn";

		// Token: 0x040072AA RID: 29354
		private static IntPtr _ClassPtr;

		// Token: 0x040072AB RID: 29355
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072AC RID: 29356
		internal static int __PropertyOffset_SpawnCount;

		// Token: 0x040072AD RID: 29357
		[Nullable(2)]
		private FRawDistributionFloat _SpawnCount;

		// Token: 0x040072AE RID: 29358
		internal static int __PropertyOffset_bUseParticleTime;

		// Token: 0x040072AF RID: 29359
		internal static byte __PropertyMask_bUseParticleTime;

		// Token: 0x040072B0 RID: 29360
		internal static int __PropertyOffset_bUsePSysLocation;

		// Token: 0x040072B1 RID: 29361
		internal static byte __PropertyMask_bUsePSysLocation;

		// Token: 0x040072B2 RID: 29362
		internal static int __PropertyOffset_bInheritVelocity;

		// Token: 0x040072B3 RID: 29363
		internal static byte __PropertyMask_bInheritVelocity;

		// Token: 0x040072B4 RID: 29364
		internal static int __PropertyOffset_InheritVelocityScale;

		// Token: 0x040072B5 RID: 29365
		[Nullable(2)]
		private FRawDistributionVector _InheritVelocityScale;

		// Token: 0x040072B6 RID: 29366
		internal static int __PropertyOffset_PhysicalMaterials;

		// Token: 0x040072B7 RID: 29367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _PhysicalMaterials;

		// Token: 0x040072B8 RID: 29368
		internal static int __PropertyOffset_bBanPhysicalMaterials;

		// Token: 0x040072B9 RID: 29369
		internal static byte __PropertyMask_bBanPhysicalMaterials;
	}
}
