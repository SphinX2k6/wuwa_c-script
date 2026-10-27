using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002601 RID: 9729
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariableBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraVariableBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242F0 RID: 148208 RVA: 0x00358FA8 File Offset: 0x003571A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariableBase._ScriptStructPtr != 0) ? FNiagaraVariableBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariableBase", ref FNiagaraVariableBase._ScriptStructPtr);
		}

		// Token: 0x17008B57 RID: 35671
		// (get) Token: 0x060242F1 RID: 148209 RVA: 0x00358FCC File Offset: 0x003571CC
		// (set) Token: 0x060242F2 RID: 148210 RVA: 0x00358FE0 File Offset: 0x003571E0
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableBase.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableBase.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008B58 RID: 35672
		// (get) Token: 0x060242F3 RID: 148211 RVA: 0x00358FF8 File Offset: 0x003571F8
		// (set) Token: 0x060242F4 RID: 148212 RVA: 0x0035903B File Offset: 0x0035723B
		public FNiagaraTypeDefinitionHandle TypeDefHandle
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraTypeDefinitionHandle result;
				if ((result = this._TypeDefHandle) == null)
				{
					result = (this._TypeDefHandle = new FNiagaraTypeDefinitionHandle(base.NativePtr + (IntPtr)FNiagaraVariableBase.__PropertyOffset_TypeDefHandle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraTypeDefinitionHandle.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableBase.__PropertyOffset_TypeDefHandle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060242F5 RID: 148213 RVA: 0x0035905C File Offset: 0x0035725C
		public FNiagaraVariableBase()
		{
		}

		// Token: 0x060242F6 RID: 148214 RVA: 0x00359064 File Offset: 0x00357264
		public FNiagaraVariableBase(FName Name, FNiagaraTypeDefinitionHandle TypeDefHandle, FNiagaraTypeDefinition TypeDef_DEPRECATED)
		{
			this.Name = Name;
			this.TypeDefHandle = TypeDefHandle;
		}

		// Token: 0x060242F7 RID: 148215 RVA: 0x0035907A File Offset: 0x0035727A
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariableBase.StaticStruct();
		}

		// Token: 0x060242F8 RID: 148216 RVA: 0x00359086 File Offset: 0x00357286
		[NullableContext(2)]
		public FNiagaraVariableBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060242F9 RID: 148217 RVA: 0x00359090 File Offset: 0x00357290
		public FNiagaraVariableBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060242FA RID: 148218 RVA: 0x0035909B File Offset: 0x0035729B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariableBase(Pointer, false, true);
		}

		// Token: 0x060242FB RID: 148219 RVA: 0x003590A5 File Offset: 0x003572A5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariableBase(Pointer, MemoryOwner);
		}

		// Token: 0x040136A2 RID: 79522
		public const string __ObjectPath = "/Script/Niagara.NiagaraVariableBase";

		// Token: 0x040136A3 RID: 79523
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136A4 RID: 79524
		internal static int __PropertyOffset_Name;

		// Token: 0x040136A5 RID: 79525
		internal static int __PropertyOffset_TypeDefHandle;

		// Token: 0x040136A6 RID: 79526
		[Nullable(2)]
		private FNiagaraTypeDefinitionHandle _TypeDefHandle;
	}
}
