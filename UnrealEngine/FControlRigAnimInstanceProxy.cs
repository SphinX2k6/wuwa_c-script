using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004B9 RID: 1209
	[UnrealObjectPath("/Script/ControlRig.ControlRigAnimInstanceProxy")]
	[UnrealStructLayout(2560, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2560)]
	public class FControlRigAnimInstanceProxy : FAnimInstanceProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004073 RID: 16499 RVA: 0x00060E1E File Offset: 0x0005F01E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigAnimInstanceProxy._ScriptStructPtr != 0) ? FControlRigAnimInstanceProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigAnimInstanceProxy", ref FControlRigAnimInstanceProxy._ScriptStructPtr);
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00060E42 File Offset: 0x0005F042
		public FControlRigAnimInstanceProxy()
		{
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00060E4A File Offset: 0x0005F04A
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigAnimInstanceProxy.StaticStruct();
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00060E56 File Offset: 0x0005F056
		[NullableContext(2)]
		public FControlRigAnimInstanceProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x00060E60 File Offset: 0x0005F060
		public FControlRigAnimInstanceProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x00060E6B File Offset: 0x0005F06B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigAnimInstanceProxy(Pointer, false, true);
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x00060E75 File Offset: 0x0005F075
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigAnimInstanceProxy(Pointer, MemoryOwner);
		}

		// Token: 0x04001ED7 RID: 7895
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigAnimInstanceProxy";

		// Token: 0x04001ED8 RID: 7896
		private static IntPtr _ScriptStructPtr;
	}
}
