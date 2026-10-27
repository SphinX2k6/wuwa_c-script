using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025A0 RID: 9632
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterScalabilityOverrides")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraEmitterScalabilityOverrides : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C69 RID: 146537 RVA: 0x0034E838 File Offset: 0x0034CA38
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterScalabilityOverrides._ScriptStructPtr != 0) ? FNiagaraEmitterScalabilityOverrides._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterScalabilityOverrides", ref FNiagaraEmitterScalabilityOverrides._ScriptStructPtr);
		}

		// Token: 0x17008981 RID: 35201
		// (get) Token: 0x06023C6A RID: 146538 RVA: 0x0034E85C File Offset: 0x0034CA5C
		// (set) Token: 0x06023C6B RID: 146539 RVA: 0x0034E89F File Offset: 0x0034CA9F
		public TArray<FNiagaraEmitterScalabilityOverride> Overrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraEmitterScalabilityOverride> result;
				if ((result = this._Overrides) == null)
				{
					result = (this._Overrides = new TArray<FNiagaraEmitterScalabilityOverride>(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilityOverrides.__PropertyOffset_Overrides, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Overrides.CopyAssign(value);
			}
		}

		// Token: 0x06023C6C RID: 146540 RVA: 0x0034E8AD File Offset: 0x0034CAAD
		public FNiagaraEmitterScalabilityOverrides()
		{
		}

		// Token: 0x06023C6D RID: 146541 RVA: 0x0034E8B5 File Offset: 0x0034CAB5
		public FNiagaraEmitterScalabilityOverrides(TArray<FNiagaraEmitterScalabilityOverride> Overrides)
		{
			this.Overrides = Overrides;
		}

		// Token: 0x06023C6E RID: 146542 RVA: 0x0034E8C4 File Offset: 0x0034CAC4
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterScalabilityOverrides.StaticStruct();
		}

		// Token: 0x06023C6F RID: 146543 RVA: 0x0034E8D0 File Offset: 0x0034CAD0
		[NullableContext(2)]
		public FNiagaraEmitterScalabilityOverrides(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C70 RID: 146544 RVA: 0x0034E8DA File Offset: 0x0034CADA
		public FNiagaraEmitterScalabilityOverrides(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C71 RID: 146545 RVA: 0x0034E8E5 File Offset: 0x0034CAE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterScalabilityOverrides(Pointer, false, true);
		}

		// Token: 0x06023C72 RID: 146546 RVA: 0x0034E8EF File Offset: 0x0034CAEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterScalabilityOverrides(Pointer, MemoryOwner);
		}

		// Token: 0x04013302 RID: 78594
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterScalabilityOverrides";

		// Token: 0x04013303 RID: 78595
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013304 RID: 78596
		internal static int __PropertyOffset_Overrides;

		// Token: 0x04013305 RID: 78597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraEmitterScalabilityOverride> _Overrides;
	}
}
