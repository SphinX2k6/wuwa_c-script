using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025B3 RID: 9651
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraInputConditionMetadata")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNiagaraInputConditionMetadata : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D9F RID: 146847 RVA: 0x00350335 File Offset: 0x0034E535
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraInputConditionMetadata._ScriptStructPtr != 0) ? FNiagaraInputConditionMetadata._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraInputConditionMetadata", ref FNiagaraInputConditionMetadata._ScriptStructPtr);
		}

		// Token: 0x170089C7 RID: 35271
		// (get) Token: 0x06023DA0 RID: 146848 RVA: 0x00350359 File Offset: 0x0034E559
		// (set) Token: 0x06023DA1 RID: 146849 RVA: 0x0035036D File Offset: 0x0034E56D
		public unsafe FName InputName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraInputConditionMetadata.__PropertyOffset_InputName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraInputConditionMetadata.__PropertyOffset_InputName) = value;
			}
		}

		// Token: 0x170089C8 RID: 35272
		// (get) Token: 0x06023DA2 RID: 146850 RVA: 0x00350384 File Offset: 0x0034E584
		// (set) Token: 0x06023DA3 RID: 146851 RVA: 0x003503C7 File Offset: 0x0034E5C7
		public TArray<string> TargetValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TargetValues) == null)
				{
					result = (this._TargetValues = new TArray<string>(base.NativePtr + (IntPtr)FNiagaraInputConditionMetadata.__PropertyOffset_TargetValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TargetValues.CopyAssign(value);
			}
		}

		// Token: 0x06023DA4 RID: 146852 RVA: 0x003503D5 File Offset: 0x0034E5D5
		public FNiagaraInputConditionMetadata()
		{
		}

		// Token: 0x06023DA5 RID: 146853 RVA: 0x003503DD File Offset: 0x0034E5DD
		public FNiagaraInputConditionMetadata(FName InputName, TArray<string> TargetValues)
		{
			this.InputName = InputName;
			this.TargetValues = TargetValues;
		}

		// Token: 0x06023DA6 RID: 146854 RVA: 0x003503F3 File Offset: 0x0034E5F3
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraInputConditionMetadata.StaticStruct();
		}

		// Token: 0x06023DA7 RID: 146855 RVA: 0x003503FF File Offset: 0x0034E5FF
		[NullableContext(2)]
		public FNiagaraInputConditionMetadata(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023DA8 RID: 146856 RVA: 0x00350409 File Offset: 0x0034E609
		public FNiagaraInputConditionMetadata(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023DA9 RID: 146857 RVA: 0x00350414 File Offset: 0x0034E614
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraInputConditionMetadata(Pointer, false, true);
		}

		// Token: 0x06023DAA RID: 146858 RVA: 0x0035041E File Offset: 0x0034E61E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraInputConditionMetadata(Pointer, MemoryOwner);
		}

		// Token: 0x04013388 RID: 78728
		public const string __ObjectPath = "/Script/Niagara.NiagaraInputConditionMetadata";

		// Token: 0x04013389 RID: 78729
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401338A RID: 78730
		internal static int __PropertyOffset_InputName;

		// Token: 0x0401338B RID: 78731
		internal static int __PropertyOffset_TargetValues;

		// Token: 0x0401338C RID: 78732
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TargetValues;
	}
}
