using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025F3 RID: 9715
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemScalabilityOverrides")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraSystemScalabilityOverrides : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024239 RID: 148025 RVA: 0x00357E48 File Offset: 0x00356048
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemScalabilityOverrides._ScriptStructPtr != 0) ? FNiagaraSystemScalabilityOverrides._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemScalabilityOverrides", ref FNiagaraSystemScalabilityOverrides._ScriptStructPtr);
		}

		// Token: 0x17008B33 RID: 35635
		// (get) Token: 0x0602423A RID: 148026 RVA: 0x00357E6C File Offset: 0x0035606C
		// (set) Token: 0x0602423B RID: 148027 RVA: 0x00357EAF File Offset: 0x003560AF
		public TArray<FNiagaraSystemScalabilityOverride> Overrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraSystemScalabilityOverride> result;
				if ((result = this._Overrides) == null)
				{
					result = (this._Overrides = new TArray<FNiagaraSystemScalabilityOverride>(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverrides.__PropertyOffset_Overrides, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Overrides.CopyAssign(value);
			}
		}

		// Token: 0x0602423C RID: 148028 RVA: 0x00357EBD File Offset: 0x003560BD
		public FNiagaraSystemScalabilityOverrides()
		{
		}

		// Token: 0x0602423D RID: 148029 RVA: 0x00357EC5 File Offset: 0x003560C5
		public FNiagaraSystemScalabilityOverrides(TArray<FNiagaraSystemScalabilityOverride> Overrides)
		{
			this.Overrides = Overrides;
		}

		// Token: 0x0602423E RID: 148030 RVA: 0x00357ED4 File Offset: 0x003560D4
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemScalabilityOverrides.StaticStruct();
		}

		// Token: 0x0602423F RID: 148031 RVA: 0x00357EE0 File Offset: 0x003560E0
		[NullableContext(2)]
		public FNiagaraSystemScalabilityOverrides(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024240 RID: 148032 RVA: 0x00357EEA File Offset: 0x003560EA
		public FNiagaraSystemScalabilityOverrides(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024241 RID: 148033 RVA: 0x00357EF5 File Offset: 0x003560F5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemScalabilityOverrides(Pointer, false, true);
		}

		// Token: 0x06024242 RID: 148034 RVA: 0x00357EFF File Offset: 0x003560FF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemScalabilityOverrides(Pointer, MemoryOwner);
		}

		// Token: 0x04013645 RID: 79429
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemScalabilityOverrides";

		// Token: 0x04013646 RID: 79430
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013647 RID: 79431
		internal static int __PropertyOffset_Overrides;

		// Token: 0x04013648 RID: 79432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraSystemScalabilityOverride> _Overrides;
	}
}
