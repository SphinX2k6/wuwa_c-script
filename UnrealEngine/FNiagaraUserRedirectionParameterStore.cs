using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025FE RID: 9726
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraUserRedirectionParameterStore")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FNiagaraUserRedirectionParameterStore : FNiagaraParameterStore, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242C8 RID: 148168 RVA: 0x00358B73 File Offset: 0x00356D73
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraUserRedirectionParameterStore._ScriptStructPtr != 0) ? FNiagaraUserRedirectionParameterStore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraUserRedirectionParameterStore", ref FNiagaraUserRedirectionParameterStore._ScriptStructPtr);
		}

		// Token: 0x17008B4F RID: 35663
		// (get) Token: 0x060242C9 RID: 148169 RVA: 0x00358B98 File Offset: 0x00356D98
		// (set) Token: 0x060242CA RID: 148170 RVA: 0x00358BDB File Offset: 0x00356DDB
		public TMap<FNiagaraVariable, FNiagaraVariable> UserParameterRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FNiagaraVariable, FNiagaraVariable> result;
				if ((result = this._UserParameterRedirects) == null)
				{
					result = (this._UserParameterRedirects = new TMap<FNiagaraVariable, FNiagaraVariable>(base.NativePtr + (IntPtr)FNiagaraUserRedirectionParameterStore.__PropertyOffset_UserParameterRedirects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UserParameterRedirects.CopyAssign(value);
			}
		}

		// Token: 0x060242CB RID: 148171 RVA: 0x00358BE9 File Offset: 0x00356DE9
		public FNiagaraUserRedirectionParameterStore()
		{
		}

		// Token: 0x060242CC RID: 148172 RVA: 0x00358BF1 File Offset: 0x00356DF1
		public FNiagaraUserRedirectionParameterStore(TMap<FNiagaraVariable, FNiagaraVariable> UserParameterRedirects, UObject Owner, TMap<FNiagaraVariable, int> ParameterOffsets, TArray<FNiagaraVariableWithOffset> SortedParameterOffsets, TArray<byte> ParameterData, TArray<UNiagaraDataInterface> DataInterfaces, TArray<UObject> UObjects, string DebugName)
		{
			this.UserParameterRedirects = UserParameterRedirects;
			base.Owner = Owner;
			base.SortedParameterOffsets = SortedParameterOffsets;
			base.ParameterData = ParameterData;
			base.DataInterfaces = DataInterfaces;
			base.UObjects = UObjects;
		}

		// Token: 0x060242CD RID: 148173 RVA: 0x00358C27 File Offset: 0x00356E27
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraUserRedirectionParameterStore.StaticStruct();
		}

		// Token: 0x060242CE RID: 148174 RVA: 0x00358C33 File Offset: 0x00356E33
		[NullableContext(2)]
		public FNiagaraUserRedirectionParameterStore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060242CF RID: 148175 RVA: 0x00358C3D File Offset: 0x00356E3D
		public FNiagaraUserRedirectionParameterStore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060242D0 RID: 148176 RVA: 0x00358C48 File Offset: 0x00356E48
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraUserRedirectionParameterStore(Pointer, false, true);
		}

		// Token: 0x060242D1 RID: 148177 RVA: 0x00358C52 File Offset: 0x00356E52
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraUserRedirectionParameterStore(Pointer, MemoryOwner);
		}

		// Token: 0x0401368D RID: 79501
		public new const string __ObjectPath = "/Script/Niagara.NiagaraUserRedirectionParameterStore";

		// Token: 0x0401368E RID: 79502
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401368F RID: 79503
		internal static int __PropertyOffset_UserParameterRedirects;

		// Token: 0x04013690 RID: 79504
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FNiagaraVariable, FNiagaraVariable> _UserParameterRedirects;
	}
}
