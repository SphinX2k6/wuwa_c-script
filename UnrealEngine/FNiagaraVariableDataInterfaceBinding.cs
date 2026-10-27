using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002602 RID: 9730
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariableDataInterfaceBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNiagaraVariableDataInterfaceBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242FC RID: 148220 RVA: 0x003590AE File Offset: 0x003572AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariableDataInterfaceBinding._ScriptStructPtr != 0) ? FNiagaraVariableDataInterfaceBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariableDataInterfaceBinding", ref FNiagaraVariableDataInterfaceBinding._ScriptStructPtr);
		}

		// Token: 0x17008B59 RID: 35673
		// (get) Token: 0x060242FD RID: 148221 RVA: 0x003590D4 File Offset: 0x003572D4
		// (set) Token: 0x060242FE RID: 148222 RVA: 0x00359117 File Offset: 0x00357317
		public FNiagaraVariable BoundVariable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._BoundVariable) == null)
				{
					result = (this._BoundVariable = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraVariableDataInterfaceBinding.__PropertyOffset_BoundVariable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableDataInterfaceBinding.__PropertyOffset_BoundVariable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060242FF RID: 148223 RVA: 0x00359138 File Offset: 0x00357338
		public FNiagaraVariableDataInterfaceBinding()
		{
		}

		// Token: 0x06024300 RID: 148224 RVA: 0x00359140 File Offset: 0x00357340
		public FNiagaraVariableDataInterfaceBinding(FNiagaraVariable BoundVariable)
		{
			this.BoundVariable = BoundVariable;
		}

		// Token: 0x06024301 RID: 148225 RVA: 0x0035914F File Offset: 0x0035734F
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariableDataInterfaceBinding.StaticStruct();
		}

		// Token: 0x06024302 RID: 148226 RVA: 0x0035915B File Offset: 0x0035735B
		[NullableContext(2)]
		public FNiagaraVariableDataInterfaceBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024303 RID: 148227 RVA: 0x00359165 File Offset: 0x00357365
		public FNiagaraVariableDataInterfaceBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024304 RID: 148228 RVA: 0x00359170 File Offset: 0x00357370
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariableDataInterfaceBinding(Pointer, false, true);
		}

		// Token: 0x06024305 RID: 148229 RVA: 0x0035917A File Offset: 0x0035737A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariableDataInterfaceBinding(Pointer, MemoryOwner);
		}

		// Token: 0x040136A7 RID: 79527
		public const string __ObjectPath = "/Script/Niagara.NiagaraVariableDataInterfaceBinding";

		// Token: 0x040136A8 RID: 79528
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136A9 RID: 79529
		internal static int __PropertyOffset_BoundVariable;

		// Token: 0x040136AA RID: 79530
		[Nullable(2)]
		private FNiagaraVariable _BoundVariable;
	}
}
