using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021ED RID: 8685
	[UnrealObjectPath("/Script/LiveLinkInterface.CachedSubjectFrame")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 352)]
	public class FCachedSubjectFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021206 RID: 135686 RVA: 0x0030D962 File Offset: 0x0030BB62
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedSubjectFrame._ScriptStructPtr != 0) ? FCachedSubjectFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.CachedSubjectFrame", ref FCachedSubjectFrame._ScriptStructPtr);
		}

		// Token: 0x06021207 RID: 135687 RVA: 0x0030D986 File Offset: 0x0030BB86
		public FCachedSubjectFrame()
		{
		}

		// Token: 0x06021208 RID: 135688 RVA: 0x0030D98E File Offset: 0x0030BB8E
		protected override IntPtr GetUStructPtr()
		{
			return FCachedSubjectFrame.StaticStruct();
		}

		// Token: 0x06021209 RID: 135689 RVA: 0x0030D99A File Offset: 0x0030BB9A
		[NullableContext(2)]
		public FCachedSubjectFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602120A RID: 135690 RVA: 0x0030D9A4 File Offset: 0x0030BBA4
		public FCachedSubjectFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602120B RID: 135691 RVA: 0x0030D9AF File Offset: 0x0030BBAF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedSubjectFrame(Pointer, false, true);
		}

		// Token: 0x0602120C RID: 135692 RVA: 0x0030D9B9 File Offset: 0x0030BBB9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedSubjectFrame(Pointer, MemoryOwner);
		}

		// Token: 0x04011AD0 RID: 72400
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.CachedSubjectFrame";

		// Token: 0x04011AD1 RID: 72401
		private static IntPtr _ScriptStructPtr;
	}
}
