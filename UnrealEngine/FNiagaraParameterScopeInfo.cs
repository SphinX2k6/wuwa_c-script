using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025C5 RID: 9669
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameterScopeInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraParameterScopeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023F16 RID: 147222 RVA: 0x003528B0 File Offset: 0x00350AB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraParameterScopeInfo._ScriptStructPtr != 0) ? FNiagaraParameterScopeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraParameterScopeInfo", ref FNiagaraParameterScopeInfo._ScriptStructPtr);
		}

		// Token: 0x17008A37 RID: 35383
		// (get) Token: 0x06023F17 RID: 147223 RVA: 0x003528D4 File Offset: 0x00350AD4
		// (set) Token: 0x06023F18 RID: 147224 RVA: 0x003528E4 File Offset: 0x00350AE4
		public unsafe ENiagaraParameterScope Scope
		{
			get
			{
				return (ENiagaraParameterScope)(*(base.NativePtr + (IntPtr)FNiagaraParameterScopeInfo.__PropertyOffset_Scope));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraParameterScopeInfo.__PropertyOffset_Scope) = (int)value;
			}
		}

		// Token: 0x17008A38 RID: 35384
		// (get) Token: 0x06023F19 RID: 147225 RVA: 0x003528F5 File Offset: 0x00350AF5
		// (set) Token: 0x06023F1A RID: 147226 RVA: 0x00352909 File Offset: 0x00350B09
		public unsafe string NamespaceString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraParameterScopeInfo.__PropertyOffset_NamespaceString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraParameterScopeInfo.__PropertyOffset_NamespaceString)), value);
			}
		}

		// Token: 0x06023F1B RID: 147227 RVA: 0x0035291E File Offset: 0x00350B1E
		public FNiagaraParameterScopeInfo()
		{
		}

		// Token: 0x06023F1C RID: 147228 RVA: 0x00352926 File Offset: 0x00350B26
		public FNiagaraParameterScopeInfo(ENiagaraParameterScope Scope, string NamespaceString)
		{
			this.Scope = Scope;
			this.NamespaceString = NamespaceString;
		}

		// Token: 0x06023F1D RID: 147229 RVA: 0x0035293C File Offset: 0x00350B3C
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraParameterScopeInfo.StaticStruct();
		}

		// Token: 0x06023F1E RID: 147230 RVA: 0x00352948 File Offset: 0x00350B48
		[NullableContext(2)]
		public FNiagaraParameterScopeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F1F RID: 147231 RVA: 0x00352952 File Offset: 0x00350B52
		public FNiagaraParameterScopeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F20 RID: 147232 RVA: 0x0035295D File Offset: 0x00350B5D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraParameterScopeInfo(Pointer, false, true);
		}

		// Token: 0x06023F21 RID: 147233 RVA: 0x00352967 File Offset: 0x00350B67
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraParameterScopeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013456 RID: 78934
		public const string __ObjectPath = "/Script/Niagara.NiagaraParameterScopeInfo";

		// Token: 0x04013457 RID: 78935
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013458 RID: 78936
		internal static int __PropertyOffset_Scope;

		// Token: 0x04013459 RID: 78937
		internal static int __PropertyOffset_NamespaceString;
	}
}
