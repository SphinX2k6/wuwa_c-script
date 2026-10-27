using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000927 RID: 2343
	[UnrealObjectPath("/Script/Engine.CharacterMovementComponentPostPhysicsTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCharacterMovementComponentPostPhysicsTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600842E RID: 33838 RVA: 0x000BCEBA File Offset: 0x000BB0BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCharacterMovementComponentPostPhysicsTickFunction._ScriptStructPtr != 0) ? FCharacterMovementComponentPostPhysicsTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CharacterMovementComponentPostPhysicsTickFunction", ref FCharacterMovementComponentPostPhysicsTickFunction._ScriptStructPtr);
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x000BCEDE File Offset: 0x000BB0DE
		public FCharacterMovementComponentPostPhysicsTickFunction()
		{
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x000BCEE6 File Offset: 0x000BB0E6
		public FCharacterMovementComponentPostPhysicsTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x000BCF23 File Offset: 0x000BB123
		protected override IntPtr GetUStructPtr()
		{
			return FCharacterMovementComponentPostPhysicsTickFunction.StaticStruct();
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x000BCF2F File Offset: 0x000BB12F
		[NullableContext(2)]
		public FCharacterMovementComponentPostPhysicsTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x000BCF39 File Offset: 0x000BB139
		public FCharacterMovementComponentPostPhysicsTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x000BCF44 File Offset: 0x000BB144
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCharacterMovementComponentPostPhysicsTickFunction(Pointer, false, true);
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x000BCF4E File Offset: 0x000BB14E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCharacterMovementComponentPostPhysicsTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04003F26 RID: 16166
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CharacterMovementComponentPostPhysicsTickFunction";

		// Token: 0x04003F27 RID: 16167
		private static IntPtr _ScriptStructPtr;
	}
}
