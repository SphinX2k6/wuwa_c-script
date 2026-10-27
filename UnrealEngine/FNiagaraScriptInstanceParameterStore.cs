using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025E3 RID: 9699
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptInstanceParameterStore")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class FNiagaraScriptInstanceParameterStore : FNiagaraParameterStore, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060240DF RID: 147679 RVA: 0x003557F8 File Offset: 0x003539F8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptInstanceParameterStore._ScriptStructPtr != 0) ? FNiagaraScriptInstanceParameterStore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptInstanceParameterStore", ref FNiagaraScriptInstanceParameterStore._ScriptStructPtr);
		}

		// Token: 0x060240E0 RID: 147680 RVA: 0x0035581C File Offset: 0x00353A1C
		public FNiagaraScriptInstanceParameterStore()
		{
		}

		// Token: 0x060240E1 RID: 147681 RVA: 0x00355824 File Offset: 0x00353A24
		[NullableContext(1)]
		public FNiagaraScriptInstanceParameterStore(UObject Owner, TMap<FNiagaraVariable, int> ParameterOffsets, TArray<FNiagaraVariableWithOffset> SortedParameterOffsets, TArray<byte> ParameterData, TArray<UNiagaraDataInterface> DataInterfaces, TArray<UObject> UObjects, string DebugName)
		{
			base.Owner = Owner;
			base.SortedParameterOffsets = SortedParameterOffsets;
			base.ParameterData = ParameterData;
			base.DataInterfaces = DataInterfaces;
			base.UObjects = UObjects;
		}

		// Token: 0x060240E2 RID: 147682 RVA: 0x00355852 File Offset: 0x00353A52
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptInstanceParameterStore.StaticStruct();
		}

		// Token: 0x060240E3 RID: 147683 RVA: 0x0035585E File Offset: 0x00353A5E
		[NullableContext(2)]
		public FNiagaraScriptInstanceParameterStore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060240E4 RID: 147684 RVA: 0x00355868 File Offset: 0x00353A68
		public FNiagaraScriptInstanceParameterStore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060240E5 RID: 147685 RVA: 0x00355873 File Offset: 0x00353A73
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptInstanceParameterStore(Pointer, false, true);
		}

		// Token: 0x060240E6 RID: 147686 RVA: 0x0035587D File Offset: 0x00353A7D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptInstanceParameterStore(Pointer, MemoryOwner);
		}

		// Token: 0x0401355D RID: 79197
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraScriptInstanceParameterStore";

		// Token: 0x0401355E RID: 79198
		private static IntPtr _ScriptStructPtr;
	}
}
