using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002712 RID: 10002
	[UnrealObjectPath("/Script/SequenceDialogue.Translate")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FTranslate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025149 RID: 151881 RVA: 0x0036E88E File Offset: 0x0036CA8E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTranslate._ScriptStructPtr != 0) ? FTranslate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.Translate", ref FTranslate._ScriptStructPtr);
		}

		// Token: 0x0602514A RID: 151882 RVA: 0x0036E8B2 File Offset: 0x0036CAB2
		public FTranslate()
		{
		}

		// Token: 0x0602514B RID: 151883 RVA: 0x0036E8BA File Offset: 0x0036CABA
		protected override IntPtr GetUStructPtr()
		{
			return FTranslate.StaticStruct();
		}

		// Token: 0x0602514C RID: 151884 RVA: 0x0036E8C6 File Offset: 0x0036CAC6
		[NullableContext(2)]
		public FTranslate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602514D RID: 151885 RVA: 0x0036E8D0 File Offset: 0x0036CAD0
		public FTranslate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602514E RID: 151886 RVA: 0x0036E8DB File Offset: 0x0036CADB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTranslate(Pointer, false, true);
		}

		// Token: 0x0602514F RID: 151887 RVA: 0x0036E8E5 File Offset: 0x0036CAE5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTranslate(Pointer, MemoryOwner);
		}

		// Token: 0x04013F8D RID: 81805
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.Translate";

		// Token: 0x04013F8E RID: 81806
		private static IntPtr _ScriptStructPtr;
	}
}
