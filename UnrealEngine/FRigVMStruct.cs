using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026CF RID: 9935
	[UnrealObjectPath("/Script/RigVM.RigVMStruct")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigVMStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024E2A RID: 151082 RVA: 0x00368FC4 File Offset: 0x003671C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMStruct._ScriptStructPtr != 0) ? FRigVMStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMStruct", ref FRigVMStruct._ScriptStructPtr);
		}

		// Token: 0x06024E2B RID: 151083 RVA: 0x00368FE8 File Offset: 0x003671E8
		public FRigVMStruct()
		{
		}

		// Token: 0x06024E2C RID: 151084 RVA: 0x00368FF0 File Offset: 0x003671F0
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMStruct.StaticStruct();
		}

		// Token: 0x06024E2D RID: 151085 RVA: 0x00368FFC File Offset: 0x003671FC
		[NullableContext(2)]
		public FRigVMStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024E2E RID: 151086 RVA: 0x00369006 File Offset: 0x00367206
		public FRigVMStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024E2F RID: 151087 RVA: 0x00369011 File Offset: 0x00367211
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMStruct(Pointer, false, true);
		}

		// Token: 0x06024E30 RID: 151088 RVA: 0x0036901B File Offset: 0x0036721B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04013DEE RID: 81390
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMStruct";

		// Token: 0x04013DEF RID: 81391
		private static IntPtr _ScriptStructPtr;
	}
}
