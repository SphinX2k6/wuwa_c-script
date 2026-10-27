using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026CD RID: 9933
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/RigVM.RigVMSlice")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FRigVMSlice : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024E1C RID: 151068 RVA: 0x00368E34 File Offset: 0x00367034
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMSlice._ScriptStructPtr != 0) ? FRigVMSlice._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMSlice", ref FRigVMSlice._ScriptStructPtr);
		}

		// Token: 0x06024E1D RID: 151069 RVA: 0x00368E58 File Offset: 0x00367058
		public FRigVMSlice()
		{
		}

		// Token: 0x06024E1E RID: 151070 RVA: 0x00368E60 File Offset: 0x00367060
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMSlice.StaticStruct();
		}

		// Token: 0x06024E1F RID: 151071 RVA: 0x00368E6C File Offset: 0x0036706C
		[NullableContext(2)]
		public FRigVMSlice(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024E20 RID: 151072 RVA: 0x00368E76 File Offset: 0x00367076
		public FRigVMSlice(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024E21 RID: 151073 RVA: 0x00368E81 File Offset: 0x00367081
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMSlice(Pointer, false, true);
		}

		// Token: 0x06024E22 RID: 151074 RVA: 0x00368E8B File Offset: 0x0036708B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMSlice(Pointer, MemoryOwner);
		}

		// Token: 0x04013DE4 RID: 81380
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMSlice";

		// Token: 0x04013DE5 RID: 81381
		private static IntPtr _ScriptStructPtr;
	}
}
