using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004D3 RID: 1235
	[UnrealObjectPath("/Script/ControlRig.ControlRigSequencerAnimInstanceProxy")]
	[UnrealStructLayout(3936, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3936)]
	public class FControlRigSequencerAnimInstanceProxy : FAnimSequencerInstanceProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004259 RID: 16985 RVA: 0x000632E6 File Offset: 0x000614E6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigSequencerAnimInstanceProxy._ScriptStructPtr != 0) ? FControlRigSequencerAnimInstanceProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigSequencerAnimInstanceProxy", ref FControlRigSequencerAnimInstanceProxy._ScriptStructPtr);
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0006330A File Offset: 0x0006150A
		public FControlRigSequencerAnimInstanceProxy()
		{
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00063312 File Offset: 0x00061512
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigSequencerAnimInstanceProxy.StaticStruct();
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0006331E File Offset: 0x0006151E
		[NullableContext(2)]
		public FControlRigSequencerAnimInstanceProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x00063328 File Offset: 0x00061528
		public FControlRigSequencerAnimInstanceProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x00063333 File Offset: 0x00061533
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigSequencerAnimInstanceProxy(Pointer, false, true);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x0006333D File Offset: 0x0006153D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigSequencerAnimInstanceProxy(Pointer, MemoryOwner);
		}

		// Token: 0x04001F89 RID: 8073
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigSequencerAnimInstanceProxy";

		// Token: 0x04001F8A RID: 8074
		private static IntPtr _ScriptStructPtr;
	}
}
