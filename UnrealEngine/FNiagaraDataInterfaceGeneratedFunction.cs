using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024D0 RID: 9424
	[UnrealObjectPath("/Script/NiagaraShader.NiagaraDataInterfaceGeneratedFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraDataInterfaceGeneratedFunction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060233C8 RID: 144328 RVA: 0x00341E5E File Offset: 0x0034005E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataInterfaceGeneratedFunction._ScriptStructPtr != 0) ? FNiagaraDataInterfaceGeneratedFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NiagaraShader.NiagaraDataInterfaceGeneratedFunction", ref FNiagaraDataInterfaceGeneratedFunction._ScriptStructPtr);
		}

		// Token: 0x060233C9 RID: 144329 RVA: 0x00341E82 File Offset: 0x00340082
		public FNiagaraDataInterfaceGeneratedFunction()
		{
		}

		// Token: 0x060233CA RID: 144330 RVA: 0x00341E8A File Offset: 0x0034008A
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataInterfaceGeneratedFunction.StaticStruct();
		}

		// Token: 0x060233CB RID: 144331 RVA: 0x00341E96 File Offset: 0x00340096
		[NullableContext(2)]
		public FNiagaraDataInterfaceGeneratedFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060233CC RID: 144332 RVA: 0x00341EA0 File Offset: 0x003400A0
		public FNiagaraDataInterfaceGeneratedFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060233CD RID: 144333 RVA: 0x00341EAB File Offset: 0x003400AB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataInterfaceGeneratedFunction(Pointer, false, true);
		}

		// Token: 0x060233CE RID: 144334 RVA: 0x00341EB5 File Offset: 0x003400B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataInterfaceGeneratedFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04012D43 RID: 77123
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NiagaraShader.NiagaraDataInterfaceGeneratedFunction";

		// Token: 0x04012D44 RID: 77124
		private static IntPtr _ScriptStructPtr;
	}
}
