using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006DD RID: 1757
	[UnrealObjectPath("/Script/ControlRig.RigUnit_StartProfilingTimer")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_StartProfilingTimer : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E4A RID: 24138 RVA: 0x00087579 File Offset: 0x00085779
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_StartProfilingTimer._ScriptStructPtr != 0) ? FRigUnit_StartProfilingTimer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_StartProfilingTimer", ref FRigUnit_StartProfilingTimer._ScriptStructPtr);
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x0008759D File Offset: 0x0008579D
		public FRigUnit_StartProfilingTimer()
		{
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x000875A5 File Offset: 0x000857A5
		[NullableContext(1)]
		public FRigUnit_StartProfilingTimer(FControlRigExecuteContext ExecuteContext)
		{
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x000875B4 File Offset: 0x000857B4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_StartProfilingTimer.StaticStruct();
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x000875C0 File Offset: 0x000857C0
		[NullableContext(2)]
		public FRigUnit_StartProfilingTimer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x000875CA File Offset: 0x000857CA
		public FRigUnit_StartProfilingTimer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x000875D5 File Offset: 0x000857D5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_StartProfilingTimer(Pointer, false, true);
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x000875DF File Offset: 0x000857DF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_StartProfilingTimer(Pointer, MemoryOwner);
		}

		// Token: 0x04002C20 RID: 11296
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_StartProfilingTimer";

		// Token: 0x04002C21 RID: 11297
		private static IntPtr _ScriptStructPtr;
	}
}
