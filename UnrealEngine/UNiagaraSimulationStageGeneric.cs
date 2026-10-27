using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025EB RID: 9707
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSimulationStageGeneric")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UNiagaraSimulationStageGeneric : UNiagaraSimulationStageBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024130 RID: 147760 RVA: 0x00355FFD File Offset: 0x003541FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSimulationStageGeneric._ClassPtr;
		}

		// Token: 0x06024131 RID: 147761 RVA: 0x0035600C File Offset: 0x0035420C
		public UNiagaraSimulationStageGeneric() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSimulationStageGeneric.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024132 RID: 147762 RVA: 0x00356034 File Offset: 0x00354234
		public UNiagaraSimulationStageGeneric(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSimulationStageGeneric.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008ACA RID: 35530
		// (get) Token: 0x06024133 RID: 147763 RVA: 0x00356067 File Offset: 0x00354267
		// (set) Token: 0x06024134 RID: 147764 RVA: 0x00356077 File Offset: 0x00354277
		public unsafe ENiagaraIterationSource IterationSource
		{
			get
			{
				return (ENiagaraIterationSource)(*(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_IterationSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_IterationSource) = (byte)value;
			}
		}

		// Token: 0x17008ACB RID: 35531
		// (get) Token: 0x06024135 RID: 147765 RVA: 0x00356088 File Offset: 0x00354288
		// (set) Token: 0x06024136 RID: 147766 RVA: 0x00356098 File Offset: 0x00354298
		public unsafe int Iterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_Iterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_Iterations) = value;
			}
		}

		// Token: 0x17008ACC RID: 35532
		// (get) Token: 0x06024137 RID: 147767 RVA: 0x003560A9 File Offset: 0x003542A9
		// (set) Token: 0x06024138 RID: 147768 RVA: 0x003560C2 File Offset: 0x003542C2
		public unsafe bool bSpawnOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_bSpawnOnly) & UNiagaraSimulationStageGeneric.__PropertyMask_bSpawnOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_bSpawnOnly) = ((*(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_bSpawnOnly) & ~UNiagaraSimulationStageGeneric.__PropertyMask_bSpawnOnly) | (value ? UNiagaraSimulationStageGeneric.__PropertyMask_bSpawnOnly : 0));
			}
		}

		// Token: 0x17008ACD RID: 35533
		// (get) Token: 0x06024139 RID: 147769 RVA: 0x003560F2 File Offset: 0x003542F2
		// (set) Token: 0x0602413A RID: 147770 RVA: 0x0035610B File Offset: 0x0035430B
		public unsafe bool bDisablePartialParticleUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_bDisablePartialParticleUpdate) & UNiagaraSimulationStageGeneric.__PropertyMask_bDisablePartialParticleUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_bDisablePartialParticleUpdate) = ((*(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_bDisablePartialParticleUpdate) & ~UNiagaraSimulationStageGeneric.__PropertyMask_bDisablePartialParticleUpdate) | (value ? UNiagaraSimulationStageGeneric.__PropertyMask_bDisablePartialParticleUpdate : 0));
			}
		}

		// Token: 0x17008ACE RID: 35534
		// (get) Token: 0x0602413B RID: 147771 RVA: 0x0035613C File Offset: 0x0035433C
		// (set) Token: 0x0602413C RID: 147772 RVA: 0x00356175 File Offset: 0x00354375
		public FNiagaraVariableDataInterfaceBinding DataInterface
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableDataInterfaceBinding result;
				if ((result = this._DataInterface) == null)
				{
					result = (this._DataInterface = new FNiagaraVariableDataInterfaceBinding(base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_DataInterface, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableDataInterfaceBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSimulationStageGeneric.__PropertyOffset_DataInterface, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602413D RID: 147773 RVA: 0x00356196 File Offset: 0x00354396
		static UNiagaraSimulationStageGeneric()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSimulationStageGeneric");
		}

		// Token: 0x0602413E RID: 147774 RVA: 0x003561A4 File Offset: 0x003543A4
		protected UNiagaraSimulationStageGeneric(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013590 RID: 79248
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSimulationStageGeneric";

		// Token: 0x04013591 RID: 79249
		private static IntPtr _ClassPtr;

		// Token: 0x04013592 RID: 79250
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013593 RID: 79251
		internal static int __PropertyOffset_IterationSource;

		// Token: 0x04013594 RID: 79252
		internal static int __PropertyOffset_Iterations;

		// Token: 0x04013595 RID: 79253
		internal static int __PropertyOffset_bSpawnOnly;

		// Token: 0x04013596 RID: 79254
		internal static byte __PropertyMask_bSpawnOnly;

		// Token: 0x04013597 RID: 79255
		internal static int __PropertyOffset_bDisablePartialParticleUpdate;

		// Token: 0x04013598 RID: 79256
		internal static byte __PropertyMask_bDisablePartialParticleUpdate;

		// Token: 0x04013599 RID: 79257
		internal static int __PropertyOffset_DataInterface;

		// Token: 0x0401359A RID: 79258
		[Nullable(2)]
		private FNiagaraVariableDataInterfaceBinding _DataInterface;
	}
}
