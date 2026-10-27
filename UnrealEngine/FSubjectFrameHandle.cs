using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002234 RID: 8756
	[UnrealObjectPath("/Script/LiveLinkInterface.SubjectFrameHandle")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSubjectFrameHandle : FLiveLinkBaseBlueprintData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021543 RID: 136515 RVA: 0x00311DC1 File Offset: 0x0030FFC1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubjectFrameHandle._ScriptStructPtr != 0) ? FSubjectFrameHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.SubjectFrameHandle", ref FSubjectFrameHandle._ScriptStructPtr);
		}

		// Token: 0x06021544 RID: 136516 RVA: 0x00311DE5 File Offset: 0x0030FFE5
		public FSubjectFrameHandle()
		{
		}

		// Token: 0x06021545 RID: 136517 RVA: 0x00311DED File Offset: 0x0030FFED
		protected override IntPtr GetUStructPtr()
		{
			return FSubjectFrameHandle.StaticStruct();
		}

		// Token: 0x06021546 RID: 136518 RVA: 0x00311DF9 File Offset: 0x0030FFF9
		[NullableContext(2)]
		public FSubjectFrameHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021547 RID: 136519 RVA: 0x00311E03 File Offset: 0x00310003
		public FSubjectFrameHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021548 RID: 136520 RVA: 0x00311E0E File Offset: 0x0031000E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubjectFrameHandle(Pointer, false, true);
		}

		// Token: 0x06021549 RID: 136521 RVA: 0x00311E18 File Offset: 0x00310018
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubjectFrameHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04011C52 RID: 72786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.SubjectFrameHandle";

		// Token: 0x04011C53 RID: 72787
		private static IntPtr _ScriptStructPtr;
	}
}
