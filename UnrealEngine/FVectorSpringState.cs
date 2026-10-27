using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001228 RID: 4648
	[UnrealObjectPath("/Script/Engine.VectorSpringState")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FVectorSpringState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060111A8 RID: 70056 RVA: 0x001918F0 File Offset: 0x0018FAF0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorSpringState._ScriptStructPtr != 0) ? FVectorSpringState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VectorSpringState", ref FVectorSpringState._ScriptStructPtr);
		}

		// Token: 0x060111A9 RID: 70057 RVA: 0x00191914 File Offset: 0x0018FB14
		public FVectorSpringState()
		{
		}

		// Token: 0x060111AA RID: 70058 RVA: 0x0019191C File Offset: 0x0018FB1C
		protected override IntPtr GetUStructPtr()
		{
			return FVectorSpringState.StaticStruct();
		}

		// Token: 0x060111AB RID: 70059 RVA: 0x00191928 File Offset: 0x0018FB28
		[NullableContext(2)]
		public FVectorSpringState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060111AC RID: 70060 RVA: 0x00191932 File Offset: 0x0018FB32
		public FVectorSpringState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060111AD RID: 70061 RVA: 0x0019193D File Offset: 0x0018FB3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVectorSpringState(Pointer, false, true);
		}

		// Token: 0x060111AE RID: 70062 RVA: 0x00191947 File Offset: 0x0018FB47
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVectorSpringState(Pointer, MemoryOwner);
		}

		// Token: 0x0400927F RID: 37503
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.VectorSpringState";

		// Token: 0x04009280 RID: 37504
		private static IntPtr _ScriptStructPtr;
	}
}
