using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200254C RID: 9548
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelGameDataLayout")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FNiagaraDataChannelGameDataLayout : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060237A8 RID: 145320 RVA: 0x0034723A File Offset: 0x0034543A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataChannelGameDataLayout._ScriptStructPtr != 0) ? FNiagaraDataChannelGameDataLayout._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataChannelGameDataLayout", ref FNiagaraDataChannelGameDataLayout._ScriptStructPtr);
		}

		// Token: 0x17008844 RID: 34884
		// (get) Token: 0x060237A9 RID: 145321 RVA: 0x00347260 File Offset: 0x00345460
		// (set) Token: 0x060237AA RID: 145322 RVA: 0x003472A3 File Offset: 0x003454A3
		public TMap<FNiagaraVariableBase, int> VariableIndices
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FNiagaraVariableBase, int> result;
				if ((result = this._VariableIndices) == null)
				{
					result = (this._VariableIndices = new TMap<FNiagaraVariableBase, int>(base.NativePtr + (IntPtr)FNiagaraDataChannelGameDataLayout.__PropertyOffset_VariableIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VariableIndices.CopyAssign(value);
			}
		}

		// Token: 0x060237AB RID: 145323 RVA: 0x003472B1 File Offset: 0x003454B1
		public FNiagaraDataChannelGameDataLayout()
		{
		}

		// Token: 0x060237AC RID: 145324 RVA: 0x003472B9 File Offset: 0x003454B9
		public FNiagaraDataChannelGameDataLayout(TMap<FNiagaraVariableBase, int> VariableIndices)
		{
			this.VariableIndices = VariableIndices;
		}

		// Token: 0x060237AD RID: 145325 RVA: 0x003472C8 File Offset: 0x003454C8
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataChannelGameDataLayout.StaticStruct();
		}

		// Token: 0x060237AE RID: 145326 RVA: 0x003472D4 File Offset: 0x003454D4
		[NullableContext(2)]
		public FNiagaraDataChannelGameDataLayout(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060237AF RID: 145327 RVA: 0x003472DE File Offset: 0x003454DE
		public FNiagaraDataChannelGameDataLayout(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060237B0 RID: 145328 RVA: 0x003472E9 File Offset: 0x003454E9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataChannelGameDataLayout(Pointer, false, true);
		}

		// Token: 0x060237B1 RID: 145329 RVA: 0x003472F3 File Offset: 0x003454F3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataChannelGameDataLayout(Pointer, MemoryOwner);
		}

		// Token: 0x04013063 RID: 77923
		public const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelGameDataLayout";

		// Token: 0x04013064 RID: 77924
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013065 RID: 77925
		internal static int __PropertyOffset_VariableIndices;

		// Token: 0x04013066 RID: 77926
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FNiagaraVariableBase, int> _VariableIndices;
	}
}
