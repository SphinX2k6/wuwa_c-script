using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010F9 RID: 4345
	[UnrealObjectPath("/Script/Engine.SkeletalMeshComponentEndPhysicsTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSkeletalMeshComponentEndPhysicsTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FC14 RID: 64532 RVA: 0x0017411F File Offset: 0x0017231F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshComponentEndPhysicsTickFunction._ScriptStructPtr != 0) ? FSkeletalMeshComponentEndPhysicsTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshComponentEndPhysicsTickFunction", ref FSkeletalMeshComponentEndPhysicsTickFunction._ScriptStructPtr);
		}

		// Token: 0x0600FC15 RID: 64533 RVA: 0x00174143 File Offset: 0x00172343
		public FSkeletalMeshComponentEndPhysicsTickFunction()
		{
		}

		// Token: 0x0600FC16 RID: 64534 RVA: 0x0017414B File Offset: 0x0017234B
		public FSkeletalMeshComponentEndPhysicsTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x0600FC17 RID: 64535 RVA: 0x00174188 File Offset: 0x00172388
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshComponentEndPhysicsTickFunction.StaticStruct();
		}

		// Token: 0x0600FC18 RID: 64536 RVA: 0x00174194 File Offset: 0x00172394
		[NullableContext(2)]
		public FSkeletalMeshComponentEndPhysicsTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FC19 RID: 64537 RVA: 0x0017419E File Offset: 0x0017239E
		public FSkeletalMeshComponentEndPhysicsTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FC1A RID: 64538 RVA: 0x001741A9 File Offset: 0x001723A9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshComponentEndPhysicsTickFunction(Pointer, false, true);
		}

		// Token: 0x0600FC1B RID: 64539 RVA: 0x001741B3 File Offset: 0x001723B3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshComponentEndPhysicsTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x040087CA RID: 34762
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshComponentEndPhysicsTickFunction";

		// Token: 0x040087CB RID: 34763
		private static IntPtr _ScriptStructPtr;
	}
}
