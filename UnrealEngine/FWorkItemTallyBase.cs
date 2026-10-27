using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200150F RID: 5391
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.WorkItemTallyBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FWorkItemTallyBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060139F9 RID: 80377 RVA: 0x001CD32E File Offset: 0x001CB52E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorkItemTallyBase._ScriptStructPtr != 0) ? FWorkItemTallyBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.WorkItemTallyBase", ref FWorkItemTallyBase._ScriptStructPtr);
		}

		// Token: 0x060139FA RID: 80378 RVA: 0x001CD352 File Offset: 0x001CB552
		public FWorkItemTallyBase()
		{
		}

		// Token: 0x060139FB RID: 80379 RVA: 0x001CD35A File Offset: 0x001CB55A
		protected override IntPtr GetUStructPtr()
		{
			return FWorkItemTallyBase.StaticStruct();
		}

		// Token: 0x060139FC RID: 80380 RVA: 0x001CD366 File Offset: 0x001CB566
		[NullableContext(2)]
		public FWorkItemTallyBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060139FD RID: 80381 RVA: 0x001CD370 File Offset: 0x001CB570
		public FWorkItemTallyBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060139FE RID: 80382 RVA: 0x001CD37B File Offset: 0x001CB57B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorkItemTallyBase(Pointer, false, true);
		}

		// Token: 0x060139FF RID: 80383 RVA: 0x001CD385 File Offset: 0x001CB585
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorkItemTallyBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400A99B RID: 43419
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.WorkItemTallyBase";

		// Token: 0x0400A99C RID: 43420
		private static IntPtr _ScriptStructPtr;
	}
}
