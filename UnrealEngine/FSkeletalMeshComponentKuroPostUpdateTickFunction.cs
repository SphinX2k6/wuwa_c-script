using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010FA RID: 4346
	[UnrealObjectPath("/Script/Engine.SkeletalMeshComponentKuroPostUpdateTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSkeletalMeshComponentKuroPostUpdateTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FC1C RID: 64540 RVA: 0x001741BC File Offset: 0x001723BC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshComponentKuroPostUpdateTickFunction._ScriptStructPtr != 0) ? FSkeletalMeshComponentKuroPostUpdateTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshComponentKuroPostUpdateTickFunction", ref FSkeletalMeshComponentKuroPostUpdateTickFunction._ScriptStructPtr);
		}

		// Token: 0x0600FC1D RID: 64541 RVA: 0x001741E0 File Offset: 0x001723E0
		public FSkeletalMeshComponentKuroPostUpdateTickFunction()
		{
		}

		// Token: 0x0600FC1E RID: 64542 RVA: 0x001741E8 File Offset: 0x001723E8
		public FSkeletalMeshComponentKuroPostUpdateTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x0600FC1F RID: 64543 RVA: 0x00174225 File Offset: 0x00172425
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshComponentKuroPostUpdateTickFunction.StaticStruct();
		}

		// Token: 0x0600FC20 RID: 64544 RVA: 0x00174231 File Offset: 0x00172431
		[NullableContext(2)]
		public FSkeletalMeshComponentKuroPostUpdateTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FC21 RID: 64545 RVA: 0x0017423B File Offset: 0x0017243B
		public FSkeletalMeshComponentKuroPostUpdateTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FC22 RID: 64546 RVA: 0x00174246 File Offset: 0x00172446
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshComponentKuroPostUpdateTickFunction(Pointer, false, true);
		}

		// Token: 0x0600FC23 RID: 64547 RVA: 0x00174250 File Offset: 0x00172450
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshComponentKuroPostUpdateTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x040087CC RID: 34764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshComponentKuroPostUpdateTickFunction";

		// Token: 0x040087CD RID: 34765
		private static IntPtr _ScriptStructPtr;
	}
}
