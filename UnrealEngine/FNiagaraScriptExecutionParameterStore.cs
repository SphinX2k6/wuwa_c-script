using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025E1 RID: 9697
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptExecutionParameterStore")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FNiagaraScriptExecutionParameterStore : FNiagaraParameterStore, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060240C3 RID: 147651 RVA: 0x00355560 File Offset: 0x00353760
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptExecutionParameterStore._ScriptStructPtr != 0) ? FNiagaraScriptExecutionParameterStore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptExecutionParameterStore", ref FNiagaraScriptExecutionParameterStore._ScriptStructPtr);
		}

		// Token: 0x17008AB2 RID: 35506
		// (get) Token: 0x060240C4 RID: 147652 RVA: 0x00355584 File Offset: 0x00353784
		// (set) Token: 0x060240C5 RID: 147653 RVA: 0x00355594 File Offset: 0x00353794
		public unsafe int ParameterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_ParameterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_ParameterSize) = value;
			}
		}

		// Token: 0x17008AB3 RID: 35507
		// (get) Token: 0x060240C6 RID: 147654 RVA: 0x003555A5 File Offset: 0x003537A5
		// (set) Token: 0x060240C7 RID: 147655 RVA: 0x003555B5 File Offset: 0x003537B5
		public unsafe uint PaddedParameterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_PaddedParameterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_PaddedParameterSize) = (int)value;
			}
		}

		// Token: 0x17008AB4 RID: 35508
		// (get) Token: 0x060240C8 RID: 147656 RVA: 0x003555C8 File Offset: 0x003537C8
		// (set) Token: 0x060240C9 RID: 147657 RVA: 0x0035560B File Offset: 0x0035380B
		public TArray<FNiagaraScriptExecutionPaddingInfo> PaddingInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraScriptExecutionPaddingInfo> result;
				if ((result = this._PaddingInfo) == null)
				{
					result = (this._PaddingInfo = new TArray<FNiagaraScriptExecutionPaddingInfo>(base.NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_PaddingInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PaddingInfo.CopyAssign(value);
			}
		}

		// Token: 0x17008AB5 RID: 35509
		// (get) Token: 0x060240CA RID: 147658 RVA: 0x00355619 File Offset: 0x00353819
		// (set) Token: 0x060240CB RID: 147659 RVA: 0x00355632 File Offset: 0x00353832
		public unsafe bool bInitialized
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_bInitialized) & FNiagaraScriptExecutionParameterStore.__PropertyMask_bInitialized) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_bInitialized) = ((*(base.NativePtr + (IntPtr)FNiagaraScriptExecutionParameterStore.__PropertyOffset_bInitialized) & ~FNiagaraScriptExecutionParameterStore.__PropertyMask_bInitialized) | (value ? FNiagaraScriptExecutionParameterStore.__PropertyMask_bInitialized : 0));
			}
		}

		// Token: 0x060240CC RID: 147660 RVA: 0x00355662 File Offset: 0x00353862
		public FNiagaraScriptExecutionParameterStore()
		{
		}

		// Token: 0x060240CD RID: 147661 RVA: 0x0035566C File Offset: 0x0035386C
		public FNiagaraScriptExecutionParameterStore(int ParameterSize, uint PaddedParameterSize, TArray<FNiagaraScriptExecutionPaddingInfo> PaddingInfo, bool bInitialized, UObject Owner, TMap<FNiagaraVariable, int> ParameterOffsets, TArray<FNiagaraVariableWithOffset> SortedParameterOffsets, TArray<byte> ParameterData, TArray<UNiagaraDataInterface> DataInterfaces, TArray<UObject> UObjects, string DebugName)
		{
			this.ParameterSize = ParameterSize;
			this.PaddedParameterSize = PaddedParameterSize;
			this.PaddingInfo = PaddingInfo;
			this.bInitialized = bInitialized;
			base.Owner = Owner;
			base.SortedParameterOffsets = SortedParameterOffsets;
			base.ParameterData = ParameterData;
			base.DataInterfaces = DataInterfaces;
			base.UObjects = UObjects;
		}

		// Token: 0x060240CE RID: 147662 RVA: 0x003556C4 File Offset: 0x003538C4
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptExecutionParameterStore.StaticStruct();
		}

		// Token: 0x060240CF RID: 147663 RVA: 0x003556D0 File Offset: 0x003538D0
		[NullableContext(2)]
		public FNiagaraScriptExecutionParameterStore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060240D0 RID: 147664 RVA: 0x003556DA File Offset: 0x003538DA
		public FNiagaraScriptExecutionParameterStore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060240D1 RID: 147665 RVA: 0x003556E5 File Offset: 0x003538E5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptExecutionParameterStore(Pointer, false, true);
		}

		// Token: 0x060240D2 RID: 147666 RVA: 0x003556EF File Offset: 0x003538EF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptExecutionParameterStore(Pointer, MemoryOwner);
		}

		// Token: 0x04013550 RID: 79184
		public new const string __ObjectPath = "/Script/Niagara.NiagaraScriptExecutionParameterStore";

		// Token: 0x04013551 RID: 79185
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013552 RID: 79186
		internal static int __PropertyOffset_ParameterSize;

		// Token: 0x04013553 RID: 79187
		internal static int __PropertyOffset_PaddedParameterSize;

		// Token: 0x04013554 RID: 79188
		internal static int __PropertyOffset_PaddingInfo;

		// Token: 0x04013555 RID: 79189
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraScriptExecutionPaddingInfo> _PaddingInfo;

		// Token: 0x04013556 RID: 79190
		internal static int __PropertyOffset_bInitialized;

		// Token: 0x04013557 RID: 79191
		internal static byte __PropertyMask_bInitialized;
	}
}
