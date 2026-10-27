using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007B6 RID: 1974
	[UnrealObjectPath("/Script/Engine.ActorComponentTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FActorComponentTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060069A9 RID: 27049 RVA: 0x00097BE2 File Offset: 0x00095DE2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorComponentTickFunction._ScriptStructPtr != 0) ? FActorComponentTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorComponentTickFunction", ref FActorComponentTickFunction._ScriptStructPtr);
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x00097C06 File Offset: 0x00095E06
		public FActorComponentTickFunction()
		{
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x00097C0E File Offset: 0x00095E0E
		public FActorComponentTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x00097C4B File Offset: 0x00095E4B
		protected override IntPtr GetUStructPtr()
		{
			return FActorComponentTickFunction.StaticStruct();
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00097C57 File Offset: 0x00095E57
		[NullableContext(2)]
		public FActorComponentTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x00097C61 File Offset: 0x00095E61
		public FActorComponentTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x00097C6C File Offset: 0x00095E6C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorComponentTickFunction(Pointer, false, true);
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x00097C76 File Offset: 0x00095E76
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorComponentTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x040032F2 RID: 13042
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorComponentTickFunction";

		// Token: 0x040032F3 RID: 13043
		private static IntPtr _ScriptStructPtr;
	}
}
