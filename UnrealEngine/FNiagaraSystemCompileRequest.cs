using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025F1 RID: 9713
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemCompileRequest")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FNiagaraSystemCompileRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602421F RID: 147999 RVA: 0x00357B8C File Offset: 0x00355D8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemCompileRequest._ScriptStructPtr != 0) ? FNiagaraSystemCompileRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemCompileRequest", ref FNiagaraSystemCompileRequest._ScriptStructPtr);
		}

		// Token: 0x17008B2E RID: 35630
		// (get) Token: 0x06024220 RID: 148000 RVA: 0x00357BB0 File Offset: 0x00355DB0
		// (set) Token: 0x06024221 RID: 148001 RVA: 0x00357BF3 File Offset: 0x00355DF3
		public TArray<UObject> RootObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._RootObjects) == null)
				{
					result = (this._RootObjects = new TArray<UObject>(base.NativePtr + (IntPtr)FNiagaraSystemCompileRequest.__PropertyOffset_RootObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RootObjects.CopyAssign(value);
			}
		}

		// Token: 0x06024222 RID: 148002 RVA: 0x00357C01 File Offset: 0x00355E01
		public FNiagaraSystemCompileRequest()
		{
		}

		// Token: 0x06024223 RID: 148003 RVA: 0x00357C09 File Offset: 0x00355E09
		public FNiagaraSystemCompileRequest(TArray<UObject> RootObjects)
		{
			this.RootObjects = RootObjects;
		}

		// Token: 0x06024224 RID: 148004 RVA: 0x00357C18 File Offset: 0x00355E18
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemCompileRequest.StaticStruct();
		}

		// Token: 0x06024225 RID: 148005 RVA: 0x00357C24 File Offset: 0x00355E24
		[NullableContext(2)]
		public FNiagaraSystemCompileRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024226 RID: 148006 RVA: 0x00357C2E File Offset: 0x00355E2E
		public FNiagaraSystemCompileRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024227 RID: 148007 RVA: 0x00357C39 File Offset: 0x00355E39
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemCompileRequest(Pointer, false, true);
		}

		// Token: 0x06024228 RID: 148008 RVA: 0x00357C43 File Offset: 0x00355E43
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemCompileRequest(Pointer, MemoryOwner);
		}

		// Token: 0x04013637 RID: 79415
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemCompileRequest";

		// Token: 0x04013638 RID: 79416
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013639 RID: 79417
		internal static int __PropertyOffset_RootObjects;

		// Token: 0x0401363A RID: 79418
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _RootObjects;
	}
}
