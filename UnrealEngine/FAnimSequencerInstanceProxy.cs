using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000310 RID: 784
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimSequencerInstanceProxy")]
	[UnrealStructLayout(3136, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3136)]
	public class FAnimSequencerInstanceProxy : FAnimInstanceProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D35 RID: 11573 RVA: 0x000455EA File Offset: 0x000437EA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSequencerInstanceProxy._ScriptStructPtr != 0) ? FAnimSequencerInstanceProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimSequencerInstanceProxy", ref FAnimSequencerInstanceProxy._ScriptStructPtr);
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0004560E File Offset: 0x0004380E
		public FAnimSequencerInstanceProxy()
		{
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00045616 File Offset: 0x00043816
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSequencerInstanceProxy.StaticStruct();
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00045622 File Offset: 0x00043822
		[NullableContext(2)]
		public FAnimSequencerInstanceProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x0004562C File Offset: 0x0004382C
		public FAnimSequencerInstanceProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00045637 File Offset: 0x00043837
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSequencerInstanceProxy(Pointer, false, true);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00045641 File Offset: 0x00043841
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSequencerInstanceProxy(Pointer, MemoryOwner);
		}

		// Token: 0x040012BD RID: 4797
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimSequencerInstanceProxy";

		// Token: 0x040012BE RID: 4798
		private static IntPtr _ScriptStructPtr;
	}
}
