using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F49 RID: 3913
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleLODLevel")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UParticleLODLevel : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D311 RID: 54033 RVA: 0x00135694 File Offset: 0x00133894
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleLODLevel._ClassPtr;
		}

		// Token: 0x0600D312 RID: 54034 RVA: 0x001356A0 File Offset: 0x001338A0
		public UParticleLODLevel() : this(BuiltinUtils.AllocNativeUObject(UParticleLODLevel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D313 RID: 54035 RVA: 0x001356C8 File Offset: 0x001338C8
		public UParticleLODLevel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleLODLevel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600D314 RID: 54036 RVA: 0x001356FB File Offset: 0x001338FB
		// (set) Token: 0x0600D315 RID: 54037 RVA: 0x0013570B File Offset: 0x0013390B
		public unsafe int Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_Level);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_Level) = value;
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600D316 RID: 54038 RVA: 0x0013571C File Offset: 0x0013391C
		// (set) Token: 0x0600D317 RID: 54039 RVA: 0x00135735 File Offset: 0x00133935
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_bEnabled) & UParticleLODLevel.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_bEnabled) & ~UParticleLODLevel.__PropertyMask_bEnabled) | (value ? UParticleLODLevel.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600D318 RID: 54040 RVA: 0x00135765 File Offset: 0x00133965
		// (set) Token: 0x0600D319 RID: 54041 RVA: 0x00135779 File Offset: 0x00133979
		[Nullable(2)]
		public unsafe UParticleModuleRequired RequiredModule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleModuleRequired>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_RequiredModule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_RequiredModule, value);
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600D31A RID: 54042 RVA: 0x00135790 File Offset: 0x00133990
		// (set) Token: 0x0600D31B RID: 54043 RVA: 0x001357C9 File Offset: 0x001339C9
		public TArray<UParticleModule> Modules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModule> result;
				if ((result = this._Modules) == null)
				{
					result = (this._Modules = new TArray<UParticleModule>(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_Modules, this));
				}
				return result;
			}
			set
			{
				this.Modules.CopyAssign(value);
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600D31C RID: 54044 RVA: 0x001357D7 File Offset: 0x001339D7
		// (set) Token: 0x0600D31D RID: 54045 RVA: 0x001357EB File Offset: 0x001339EB
		[Nullable(2)]
		public unsafe UParticleModuleTypeDataBase TypeDataModule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleModuleTypeDataBase>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_TypeDataModule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_TypeDataModule, value);
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600D31E RID: 54046 RVA: 0x00135800 File Offset: 0x00133A00
		// (set) Token: 0x0600D31F RID: 54047 RVA: 0x00135814 File Offset: 0x00133A14
		[Nullable(2)]
		public unsafe UParticleModuleSpawn SpawnModule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleModuleSpawn>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_SpawnModule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_SpawnModule, value);
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600D320 RID: 54048 RVA: 0x00135829 File Offset: 0x00133A29
		// (set) Token: 0x0600D321 RID: 54049 RVA: 0x0013583D File Offset: 0x00133A3D
		[Nullable(2)]
		public unsafe UParticleModuleEventGenerator EventGenerator
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleModuleEventGenerator>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_EventGenerator);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleLODLevel.__PropertyOffset_EventGenerator, value);
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600D322 RID: 54050 RVA: 0x00135854 File Offset: 0x00133A54
		// (set) Token: 0x0600D323 RID: 54051 RVA: 0x0013588D File Offset: 0x00133A8D
		public TArray<UParticleModuleSpawnBase> SpawningModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModuleSpawnBase> result;
				if ((result = this._SpawningModules) == null)
				{
					result = (this._SpawningModules = new TArray<UParticleModuleSpawnBase>(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_SpawningModules, this));
				}
				return result;
			}
			set
			{
				this.SpawningModules.CopyAssign(value);
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600D324 RID: 54052 RVA: 0x0013589C File Offset: 0x00133A9C
		// (set) Token: 0x0600D325 RID: 54053 RVA: 0x001358D5 File Offset: 0x00133AD5
		public TArray<UParticleModule> SpawnModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModule> result;
				if ((result = this._SpawnModules) == null)
				{
					result = (this._SpawnModules = new TArray<UParticleModule>(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_SpawnModules, this));
				}
				return result;
			}
			set
			{
				this.SpawnModules.CopyAssign(value);
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600D326 RID: 54054 RVA: 0x001358E4 File Offset: 0x00133AE4
		// (set) Token: 0x0600D327 RID: 54055 RVA: 0x0013591D File Offset: 0x00133B1D
		public TArray<UParticleModule> UpdateModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModule> result;
				if ((result = this._UpdateModules) == null)
				{
					result = (this._UpdateModules = new TArray<UParticleModule>(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_UpdateModules, this));
				}
				return result;
			}
			set
			{
				this.UpdateModules.CopyAssign(value);
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600D328 RID: 54056 RVA: 0x0013592C File Offset: 0x00133B2C
		// (set) Token: 0x0600D329 RID: 54057 RVA: 0x00135965 File Offset: 0x00133B65
		public TArray<UParticleModuleOrbit> OrbitModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModuleOrbit> result;
				if ((result = this._OrbitModules) == null)
				{
					result = (this._OrbitModules = new TArray<UParticleModuleOrbit>(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_OrbitModules, this));
				}
				return result;
			}
			set
			{
				this.OrbitModules.CopyAssign(value);
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600D32A RID: 54058 RVA: 0x00135974 File Offset: 0x00133B74
		// (set) Token: 0x0600D32B RID: 54059 RVA: 0x001359AD File Offset: 0x00133BAD
		public TArray<UParticleModuleEventReceiverBase> EventReceiverModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleModuleEventReceiverBase> result;
				if ((result = this._EventReceiverModules) == null)
				{
					result = (this._EventReceiverModules = new TArray<UParticleModuleEventReceiverBase>(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_EventReceiverModules, this));
				}
				return result;
			}
			set
			{
				this.EventReceiverModules.CopyAssign(value);
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600D32C RID: 54060 RVA: 0x001359BB File Offset: 0x00133BBB
		// (set) Token: 0x0600D32D RID: 54061 RVA: 0x001359D4 File Offset: 0x00133BD4
		public unsafe bool ConvertedModules
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_ConvertedModules) & UParticleLODLevel.__PropertyMask_ConvertedModules) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_ConvertedModules) = ((*(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_ConvertedModules) & ~UParticleLODLevel.__PropertyMask_ConvertedModules) | (value ? UParticleLODLevel.__PropertyMask_ConvertedModules : 0));
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600D32E RID: 54062 RVA: 0x00135A04 File Offset: 0x00133C04
		// (set) Token: 0x0600D32F RID: 54063 RVA: 0x00135A14 File Offset: 0x00133C14
		public unsafe int PeakActiveParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_PeakActiveParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleLODLevel.__PropertyOffset_PeakActiveParticles) = value;
			}
		}

		// Token: 0x0600D330 RID: 54064 RVA: 0x00135A25 File Offset: 0x00133C25
		static UParticleLODLevel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleLODLevel");
		}

		// Token: 0x0600D331 RID: 54065 RVA: 0x00135A33 File Offset: 0x00133C33
		protected UParticleLODLevel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400713C RID: 28988
		public new const string __ObjectPath = "/Script/Engine.ParticleLODLevel";

		// Token: 0x0400713D RID: 28989
		private static IntPtr _ClassPtr;

		// Token: 0x0400713E RID: 28990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400713F RID: 28991
		internal static int __PropertyOffset_Level;

		// Token: 0x04007140 RID: 28992
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04007141 RID: 28993
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04007142 RID: 28994
		internal static int __PropertyOffset_RequiredModule;

		// Token: 0x04007143 RID: 28995
		internal static int __PropertyOffset_Modules;

		// Token: 0x04007144 RID: 28996
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModule> _Modules;

		// Token: 0x04007145 RID: 28997
		internal static int __PropertyOffset_TypeDataModule;

		// Token: 0x04007146 RID: 28998
		internal static int __PropertyOffset_SpawnModule;

		// Token: 0x04007147 RID: 28999
		internal static int __PropertyOffset_EventGenerator;

		// Token: 0x04007148 RID: 29000
		internal static int __PropertyOffset_SpawningModules;

		// Token: 0x04007149 RID: 29001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModuleSpawnBase> _SpawningModules;

		// Token: 0x0400714A RID: 29002
		internal static int __PropertyOffset_SpawnModules;

		// Token: 0x0400714B RID: 29003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModule> _SpawnModules;

		// Token: 0x0400714C RID: 29004
		internal static int __PropertyOffset_UpdateModules;

		// Token: 0x0400714D RID: 29005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModule> _UpdateModules;

		// Token: 0x0400714E RID: 29006
		internal static int __PropertyOffset_OrbitModules;

		// Token: 0x0400714F RID: 29007
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModuleOrbit> _OrbitModules;

		// Token: 0x04007150 RID: 29008
		internal static int __PropertyOffset_EventReceiverModules;

		// Token: 0x04007151 RID: 29009
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleModuleEventReceiverBase> _EventReceiverModules;

		// Token: 0x04007152 RID: 29010
		internal static int __PropertyOffset_ConvertedModules;

		// Token: 0x04007153 RID: 29011
		internal static byte __PropertyMask_ConvertedModules;

		// Token: 0x04007154 RID: 29012
		internal static int __PropertyOffset_PeakActiveParticles;
	}
}
