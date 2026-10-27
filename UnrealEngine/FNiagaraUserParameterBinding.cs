using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025FD RID: 9725
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraUserParameterBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNiagaraUserParameterBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242BE RID: 148158 RVA: 0x00358A9E File Offset: 0x00356C9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraUserParameterBinding._ScriptStructPtr != 0) ? FNiagaraUserParameterBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraUserParameterBinding", ref FNiagaraUserParameterBinding._ScriptStructPtr);
		}

		// Token: 0x17008B4E RID: 35662
		// (get) Token: 0x060242BF RID: 148159 RVA: 0x00358AC4 File Offset: 0x00356CC4
		// (set) Token: 0x060242C0 RID: 148160 RVA: 0x00358B07 File Offset: 0x00356D07
		public FNiagaraVariable Parameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._Parameter) == null)
				{
					result = (this._Parameter = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraUserParameterBinding.__PropertyOffset_Parameter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraUserParameterBinding.__PropertyOffset_Parameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060242C1 RID: 148161 RVA: 0x00358B28 File Offset: 0x00356D28
		public FNiagaraUserParameterBinding()
		{
		}

		// Token: 0x060242C2 RID: 148162 RVA: 0x00358B30 File Offset: 0x00356D30
		public FNiagaraUserParameterBinding(FNiagaraVariable Parameter)
		{
			this.Parameter = Parameter;
		}

		// Token: 0x060242C3 RID: 148163 RVA: 0x00358B3F File Offset: 0x00356D3F
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraUserParameterBinding.StaticStruct();
		}

		// Token: 0x060242C4 RID: 148164 RVA: 0x00358B4B File Offset: 0x00356D4B
		[NullableContext(2)]
		public FNiagaraUserParameterBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060242C5 RID: 148165 RVA: 0x00358B55 File Offset: 0x00356D55
		public FNiagaraUserParameterBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060242C6 RID: 148166 RVA: 0x00358B60 File Offset: 0x00356D60
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraUserParameterBinding(Pointer, false, true);
		}

		// Token: 0x060242C7 RID: 148167 RVA: 0x00358B6A File Offset: 0x00356D6A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraUserParameterBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04013689 RID: 79497
		public const string __ObjectPath = "/Script/Niagara.NiagaraUserParameterBinding";

		// Token: 0x0401368A RID: 79498
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401368B RID: 79499
		internal static int __PropertyOffset_Parameter;

		// Token: 0x0401368C RID: 79500
		[Nullable(2)]
		private FNiagaraVariable _Parameter;
	}
}
