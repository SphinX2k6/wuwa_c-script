using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000696 RID: 1686
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MultiFABRIK_WorkData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_MultiFABRIK_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600599F RID: 22943 RVA: 0x00080CC5 File Offset: 0x0007EEC5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MultiFABRIK_WorkData._ScriptStructPtr != 0) ? FRigUnit_MultiFABRIK_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MultiFABRIK_WorkData", ref FRigUnit_MultiFABRIK_WorkData._ScriptStructPtr);
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00080CE9 File Offset: 0x0007EEE9
		public FRigUnit_MultiFABRIK_WorkData()
		{
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x00080CF1 File Offset: 0x0007EEF1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MultiFABRIK_WorkData.StaticStruct();
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x00080CFD File Offset: 0x0007EEFD
		[NullableContext(2)]
		public FRigUnit_MultiFABRIK_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00080D07 File Offset: 0x0007EF07
		public FRigUnit_MultiFABRIK_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x00080D12 File Offset: 0x0007EF12
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MultiFABRIK_WorkData(Pointer, false, true);
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x00080D1C File Offset: 0x0007EF1C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MultiFABRIK_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002A01 RID: 10753
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_MultiFABRIK_WorkData";

		// Token: 0x04002A02 RID: 10754
		private static IntPtr _ScriptStructPtr;
	}
}
