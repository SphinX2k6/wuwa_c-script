using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025A8 RID: 9640
	[UnrealObjectPath("/Script/Niagara.NiagaraEventScriptProperties")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FNiagaraEventScriptProperties : FNiagaraEmitterScriptProperties, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023CD0 RID: 146640 RVA: 0x0034F187 File Offset: 0x0034D387
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEventScriptProperties._ScriptStructPtr != 0) ? FNiagaraEventScriptProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEventScriptProperties", ref FNiagaraEventScriptProperties._ScriptStructPtr);
		}

		// Token: 0x17008998 RID: 35224
		// (get) Token: 0x06023CD1 RID: 146641 RVA: 0x0034F1AB File Offset: 0x0034D3AB
		// (set) Token: 0x06023CD2 RID: 146642 RVA: 0x0034F1BB File Offset: 0x0034D3BB
		public unsafe EScriptExecutionMode ExecutionMode
		{
			get
			{
				return (EScriptExecutionMode)(*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_ExecutionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_ExecutionMode) = (byte)value;
			}
		}

		// Token: 0x17008999 RID: 35225
		// (get) Token: 0x06023CD3 RID: 146643 RVA: 0x0034F1CC File Offset: 0x0034D3CC
		// (set) Token: 0x06023CD4 RID: 146644 RVA: 0x0034F1DC File Offset: 0x0034D3DC
		public unsafe uint SpawnNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_SpawnNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_SpawnNumber) = (int)value;
			}
		}

		// Token: 0x1700899A RID: 35226
		// (get) Token: 0x06023CD5 RID: 146645 RVA: 0x0034F1ED File Offset: 0x0034D3ED
		// (set) Token: 0x06023CD6 RID: 146646 RVA: 0x0034F1FD File Offset: 0x0034D3FD
		public unsafe uint MaxEventsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_MaxEventsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_MaxEventsPerFrame) = (int)value;
			}
		}

		// Token: 0x1700899B RID: 35227
		// (get) Token: 0x06023CD7 RID: 146647 RVA: 0x0034F20E File Offset: 0x0034D40E
		// (set) Token: 0x06023CD8 RID: 146648 RVA: 0x0034F222 File Offset: 0x0034D422
		public unsafe FGuid SourceEmitterID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_SourceEmitterID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_SourceEmitterID) = value;
			}
		}

		// Token: 0x1700899C RID: 35228
		// (get) Token: 0x06023CD9 RID: 146649 RVA: 0x0034F237 File Offset: 0x0034D437
		// (set) Token: 0x06023CDA RID: 146650 RVA: 0x0034F24B File Offset: 0x0034D44B
		public unsafe FName SourceEventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_SourceEventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_SourceEventName) = value;
			}
		}

		// Token: 0x1700899D RID: 35229
		// (get) Token: 0x06023CDB RID: 146651 RVA: 0x0034F260 File Offset: 0x0034D460
		// (set) Token: 0x06023CDC RID: 146652 RVA: 0x0034F270 File Offset: 0x0034D470
		public unsafe bool bRandomSpawnNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_bRandomSpawnNumber) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_bRandomSpawnNumber) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700899E RID: 35230
		// (get) Token: 0x06023CDD RID: 146653 RVA: 0x0034F281 File Offset: 0x0034D481
		// (set) Token: 0x06023CDE RID: 146654 RVA: 0x0034F291 File Offset: 0x0034D491
		public unsafe uint MinSpawnNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_MinSpawnNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventScriptProperties.__PropertyOffset_MinSpawnNumber) = (int)value;
			}
		}

		// Token: 0x06023CDF RID: 146655 RVA: 0x0034F2A2 File Offset: 0x0034D4A2
		public FNiagaraEventScriptProperties()
		{
		}

		// Token: 0x06023CE0 RID: 146656 RVA: 0x0034F2AC File Offset: 0x0034D4AC
		[NullableContext(1)]
		public FNiagaraEventScriptProperties(EScriptExecutionMode ExecutionMode, uint SpawnNumber, uint MaxEventsPerFrame, FGuid SourceEmitterID, FName SourceEventName, bool bRandomSpawnNumber, uint MinSpawnNumber, UNiagaraScript Script, TArray<FNiagaraEventReceiverProperties> EventReceivers, TArray<FNiagaraEventGeneratorProperties> EventGenerators)
		{
			this.ExecutionMode = ExecutionMode;
			this.SpawnNumber = SpawnNumber;
			this.MaxEventsPerFrame = MaxEventsPerFrame;
			this.SourceEmitterID = SourceEmitterID;
			this.SourceEventName = SourceEventName;
			this.bRandomSpawnNumber = bRandomSpawnNumber;
			this.MinSpawnNumber = MinSpawnNumber;
			base.Script = Script;
			base.EventReceivers = EventReceivers;
			base.EventGenerators = EventGenerators;
		}

		// Token: 0x06023CE1 RID: 146657 RVA: 0x0034F30C File Offset: 0x0034D50C
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEventScriptProperties.StaticStruct();
		}

		// Token: 0x06023CE2 RID: 146658 RVA: 0x0034F318 File Offset: 0x0034D518
		[NullableContext(2)]
		public FNiagaraEventScriptProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023CE3 RID: 146659 RVA: 0x0034F322 File Offset: 0x0034D522
		public FNiagaraEventScriptProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023CE4 RID: 146660 RVA: 0x0034F32D File Offset: 0x0034D52D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEventScriptProperties(Pointer, false, true);
		}

		// Token: 0x06023CE5 RID: 146661 RVA: 0x0034F337 File Offset: 0x0034D537
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEventScriptProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04013337 RID: 78647
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEventScriptProperties";

		// Token: 0x04013338 RID: 78648
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013339 RID: 78649
		internal static int __PropertyOffset_ExecutionMode;

		// Token: 0x0401333A RID: 78650
		internal static int __PropertyOffset_SpawnNumber;

		// Token: 0x0401333B RID: 78651
		internal static int __PropertyOffset_MaxEventsPerFrame;

		// Token: 0x0401333C RID: 78652
		internal static int __PropertyOffset_SourceEmitterID;

		// Token: 0x0401333D RID: 78653
		internal static int __PropertyOffset_SourceEventName;

		// Token: 0x0401333E RID: 78654
		internal static int __PropertyOffset_bRandomSpawnNumber;

		// Token: 0x0401333F RID: 78655
		internal static int __PropertyOffset_MinSpawnNumber;
	}
}
