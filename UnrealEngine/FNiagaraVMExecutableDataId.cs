using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002609 RID: 9737
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraVMExecutableDataId")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FNiagaraVMExecutableDataId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024394 RID: 148372 RVA: 0x0035A0B8 File Offset: 0x003582B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVMExecutableDataId._ScriptStructPtr != 0) ? FNiagaraVMExecutableDataId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVMExecutableDataId", ref FNiagaraVMExecutableDataId._ScriptStructPtr);
		}

		// Token: 0x17008B89 RID: 35721
		// (get) Token: 0x06024395 RID: 148373 RVA: 0x0035A0DC File Offset: 0x003582DC
		// (set) Token: 0x06024396 RID: 148374 RVA: 0x0035A0F0 File Offset: 0x003582F0
		public unsafe FGuid CompilerVersionID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_CompilerVersionID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_CompilerVersionID) = value;
			}
		}

		// Token: 0x17008B8A RID: 35722
		// (get) Token: 0x06024397 RID: 148375 RVA: 0x0035A105 File Offset: 0x00358305
		// (set) Token: 0x06024398 RID: 148376 RVA: 0x0035A115 File Offset: 0x00358315
		public unsafe ENiagaraScriptUsage ScriptUsageType
		{
			get
			{
				return (ENiagaraScriptUsage)(*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_ScriptUsageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_ScriptUsageType) = (byte)value;
			}
		}

		// Token: 0x17008B8B RID: 35723
		// (get) Token: 0x06024399 RID: 148377 RVA: 0x0035A126 File Offset: 0x00358326
		// (set) Token: 0x0602439A RID: 148378 RVA: 0x0035A13A File Offset: 0x0035833A
		public unsafe FGuid ScriptUsageTypeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_ScriptUsageTypeID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_ScriptUsageTypeID) = value;
			}
		}

		// Token: 0x17008B8C RID: 35724
		// (get) Token: 0x0602439B RID: 148379 RVA: 0x0035A14F File Offset: 0x0035834F
		// (set) Token: 0x0602439C RID: 148380 RVA: 0x0035A168 File Offset: 0x00358368
		public unsafe bool bUsesRapidIterationParams
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bUsesRapidIterationParams) & FNiagaraVMExecutableDataId.__PropertyMask_bUsesRapidIterationParams) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bUsesRapidIterationParams) = ((*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bUsesRapidIterationParams) & ~FNiagaraVMExecutableDataId.__PropertyMask_bUsesRapidIterationParams) | (value ? FNiagaraVMExecutableDataId.__PropertyMask_bUsesRapidIterationParams : 0));
			}
		}

		// Token: 0x17008B8D RID: 35725
		// (get) Token: 0x0602439D RID: 148381 RVA: 0x0035A198 File Offset: 0x00358398
		// (set) Token: 0x0602439E RID: 148382 RVA: 0x0035A1B1 File Offset: 0x003583B1
		public unsafe bool bInterpolatedSpawn
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bInterpolatedSpawn) & FNiagaraVMExecutableDataId.__PropertyMask_bInterpolatedSpawn) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bInterpolatedSpawn) = ((*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bInterpolatedSpawn) & ~FNiagaraVMExecutableDataId.__PropertyMask_bInterpolatedSpawn) | (value ? FNiagaraVMExecutableDataId.__PropertyMask_bInterpolatedSpawn : 0));
			}
		}

		// Token: 0x17008B8E RID: 35726
		// (get) Token: 0x0602439F RID: 148383 RVA: 0x0035A1E1 File Offset: 0x003583E1
		// (set) Token: 0x060243A0 RID: 148384 RVA: 0x0035A1FA File Offset: 0x003583FA
		public unsafe bool bRequiresPersistentIDs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bRequiresPersistentIDs) & FNiagaraVMExecutableDataId.__PropertyMask_bRequiresPersistentIDs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bRequiresPersistentIDs) = ((*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_bRequiresPersistentIDs) & ~FNiagaraVMExecutableDataId.__PropertyMask_bRequiresPersistentIDs) | (value ? FNiagaraVMExecutableDataId.__PropertyMask_bRequiresPersistentIDs : 0));
			}
		}

		// Token: 0x17008B8F RID: 35727
		// (get) Token: 0x060243A1 RID: 148385 RVA: 0x0035A22A File Offset: 0x0035842A
		// (set) Token: 0x060243A2 RID: 148386 RVA: 0x0035A23E File Offset: 0x0035843E
		public unsafe FGuid BaseScriptID_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_BaseScriptID_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_BaseScriptID_DEPRECATED) = value;
			}
		}

		// Token: 0x17008B90 RID: 35728
		// (get) Token: 0x060243A3 RID: 148387 RVA: 0x0035A254 File Offset: 0x00358454
		// (set) Token: 0x060243A4 RID: 148388 RVA: 0x0035A297 File Offset: 0x00358497
		public FNiagaraCompileHash BaseScriptCompileHash
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraCompileHash result;
				if ((result = this._BaseScriptCompileHash) == null)
				{
					result = (this._BaseScriptCompileHash = new FNiagaraCompileHash(base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_BaseScriptCompileHash, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraCompileHash.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVMExecutableDataId.__PropertyOffset_BaseScriptCompileHash, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060243A5 RID: 148389 RVA: 0x0035A2B8 File Offset: 0x003584B8
		public FNiagaraVMExecutableDataId()
		{
		}

		// Token: 0x060243A6 RID: 148390 RVA: 0x0035A2C0 File Offset: 0x003584C0
		public FNiagaraVMExecutableDataId(FGuid CompilerVersionID, ENiagaraScriptUsage ScriptUsageType, FGuid ScriptUsageTypeID, TArray<string> AdditionalDefines, bool bUsesRapidIterationParams, bool bInterpolatedSpawn, bool bRequiresPersistentIDs, FGuid BaseScriptID_DEPRECATED, FNiagaraCompileHash BaseScriptCompileHash, TArray<FNiagaraCompileHash> ReferencedCompileHashes)
		{
			this.CompilerVersionID = CompilerVersionID;
			this.ScriptUsageType = ScriptUsageType;
			this.ScriptUsageTypeID = ScriptUsageTypeID;
			this.bUsesRapidIterationParams = bUsesRapidIterationParams;
			this.bInterpolatedSpawn = bInterpolatedSpawn;
			this.bRequiresPersistentIDs = bRequiresPersistentIDs;
			this.BaseScriptID_DEPRECATED = BaseScriptID_DEPRECATED;
			this.BaseScriptCompileHash = BaseScriptCompileHash;
		}

		// Token: 0x060243A7 RID: 148391 RVA: 0x0035A310 File Offset: 0x00358510
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVMExecutableDataId.StaticStruct();
		}

		// Token: 0x060243A8 RID: 148392 RVA: 0x0035A31C File Offset: 0x0035851C
		[NullableContext(2)]
		public FNiagaraVMExecutableDataId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243A9 RID: 148393 RVA: 0x0035A326 File Offset: 0x00358526
		public FNiagaraVMExecutableDataId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243AA RID: 148394 RVA: 0x0035A331 File Offset: 0x00358531
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVMExecutableDataId(Pointer, false, true);
		}

		// Token: 0x060243AB RID: 148395 RVA: 0x0035A33B File Offset: 0x0035853B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVMExecutableDataId(Pointer, MemoryOwner);
		}

		// Token: 0x040136FD RID: 79613
		public const string __ObjectPath = "/Script/Niagara.NiagaraVMExecutableDataId";

		// Token: 0x040136FE RID: 79614
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136FF RID: 79615
		internal static int __PropertyOffset_CompilerVersionID;

		// Token: 0x04013700 RID: 79616
		internal static int __PropertyOffset_ScriptUsageType;

		// Token: 0x04013701 RID: 79617
		internal static int __PropertyOffset_ScriptUsageTypeID;

		// Token: 0x04013702 RID: 79618
		internal static int __PropertyOffset_bUsesRapidIterationParams;

		// Token: 0x04013703 RID: 79619
		internal static byte __PropertyMask_bUsesRapidIterationParams;

		// Token: 0x04013704 RID: 79620
		internal static int __PropertyOffset_bInterpolatedSpawn;

		// Token: 0x04013705 RID: 79621
		internal static byte __PropertyMask_bInterpolatedSpawn;

		// Token: 0x04013706 RID: 79622
		internal static int __PropertyOffset_bRequiresPersistentIDs;

		// Token: 0x04013707 RID: 79623
		internal static byte __PropertyMask_bRequiresPersistentIDs;

		// Token: 0x04013708 RID: 79624
		internal static int __PropertyOffset_BaseScriptID_DEPRECATED;

		// Token: 0x04013709 RID: 79625
		internal static int __PropertyOffset_BaseScriptCompileHash;

		// Token: 0x0401370A RID: 79626
		[Nullable(2)]
		private FNiagaraCompileHash _BaseScriptCompileHash;
	}
}
