using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000505 RID: 1285
	[UnrealObjectPath("/Script/ControlRig.GizmoActorCreationParam")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FGizmoActorCreationParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004324 RID: 17188 RVA: 0x000642FB File Offset: 0x000624FB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGizmoActorCreationParam._ScriptStructPtr != 0) ? FGizmoActorCreationParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.GizmoActorCreationParam", ref FGizmoActorCreationParam._ScriptStructPtr);
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x0006431F File Offset: 0x0006251F
		public FGizmoActorCreationParam()
		{
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00064327 File Offset: 0x00062527
		protected override IntPtr GetUStructPtr()
		{
			return FGizmoActorCreationParam.StaticStruct();
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x00064333 File Offset: 0x00062533
		[NullableContext(2)]
		public FGizmoActorCreationParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0006433D File Offset: 0x0006253D
		public FGizmoActorCreationParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x00064348 File Offset: 0x00062548
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGizmoActorCreationParam(Pointer, false, true);
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x00064352 File Offset: 0x00062552
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGizmoActorCreationParam(Pointer, MemoryOwner);
		}

		// Token: 0x040020C0 RID: 8384
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.GizmoActorCreationParam";

		// Token: 0x040020C1 RID: 8385
		private static IntPtr _ScriptStructPtr;
	}
}
