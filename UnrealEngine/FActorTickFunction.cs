using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007CC RID: 1996
	[UnrealObjectPath("/Script/Engine.ActorTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FActorTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006A75 RID: 27253 RVA: 0x00099702 File Offset: 0x00097902
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorTickFunction._ScriptStructPtr != 0) ? FActorTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorTickFunction", ref FActorTickFunction._ScriptStructPtr);
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x00099726 File Offset: 0x00097926
		public FActorTickFunction()
		{
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0009972E File Offset: 0x0009792E
		public FActorTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x0009976B File Offset: 0x0009796B
		protected override IntPtr GetUStructPtr()
		{
			return FActorTickFunction.StaticStruct();
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00099777 File Offset: 0x00097977
		[NullableContext(2)]
		public FActorTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x00099781 File Offset: 0x00097981
		public FActorTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x0009978C File Offset: 0x0009798C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorTickFunction(Pointer, false, true);
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x00099796 File Offset: 0x00097996
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04003342 RID: 13122
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorTickFunction";

		// Token: 0x04003343 RID: 13123
		private static IntPtr _ScriptStructPtr;
	}
}
