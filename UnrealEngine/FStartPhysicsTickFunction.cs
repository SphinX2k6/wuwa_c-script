using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001186 RID: 4486
	[UnrealObjectPath("/Script/Engine.StartPhysicsTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FStartPhysicsTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060107D3 RID: 67539 RVA: 0x0018373E File Offset: 0x0018193E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStartPhysicsTickFunction._ScriptStructPtr != 0) ? FStartPhysicsTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StartPhysicsTickFunction", ref FStartPhysicsTickFunction._ScriptStructPtr);
		}

		// Token: 0x060107D4 RID: 67540 RVA: 0x00183762 File Offset: 0x00181962
		public FStartPhysicsTickFunction()
		{
		}

		// Token: 0x060107D5 RID: 67541 RVA: 0x0018376A File Offset: 0x0018196A
		public FStartPhysicsTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x060107D6 RID: 67542 RVA: 0x001837A7 File Offset: 0x001819A7
		protected override IntPtr GetUStructPtr()
		{
			return FStartPhysicsTickFunction.StaticStruct();
		}

		// Token: 0x060107D7 RID: 67543 RVA: 0x001837B3 File Offset: 0x001819B3
		[NullableContext(2)]
		public FStartPhysicsTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060107D8 RID: 67544 RVA: 0x001837BD File Offset: 0x001819BD
		public FStartPhysicsTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060107D9 RID: 67545 RVA: 0x001837C8 File Offset: 0x001819C8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStartPhysicsTickFunction(Pointer, false, true);
		}

		// Token: 0x060107DA RID: 67546 RVA: 0x001837D2 File Offset: 0x001819D2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStartPhysicsTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04008D23 RID: 36131
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StartPhysicsTickFunction";

		// Token: 0x04008D24 RID: 36132
		private static IntPtr _ScriptStructPtr;
	}
}
