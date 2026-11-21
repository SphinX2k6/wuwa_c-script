using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000167 RID: 359
	[UnrealObjectPath("/Script/Engine.ActorComponentTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FActorComponentTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001642 RID: 5698 RVA: 0x00022401 File Offset: 0x00020601
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorComponentTickFunction._ScriptStructPtr != 0) ? FActorComponentTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorComponentTickFunction", ref FActorComponentTickFunction._ScriptStructPtr);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00022425 File Offset: 0x00020625
		public FActorComponentTickFunction()
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0002242D File Offset: 0x0002062D
		protected override IntPtr GetUStructPtr()
		{
			return FActorComponentTickFunction.StaticStruct();
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00022439 File Offset: 0x00020639
		[NullableContext(2)]
		public FActorComponentTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00022443 File Offset: 0x00020643
		public FActorComponentTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0002244E File Offset: 0x0002064E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorComponentTickFunction(Pointer, false, true);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00022458 File Offset: 0x00020658
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorComponentTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04000714 RID: 1812
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorComponentTickFunction";

		// Token: 0x04000715 RID: 1813
		private static IntPtr _ScriptStructPtr;
	}
}
