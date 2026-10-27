using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001570 RID: 5488
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InputRayHit")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInputRayHit : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013DD1 RID: 81361 RVA: 0x001D2B52 File Offset: 0x001D0D52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputRayHit._ScriptStructPtr != 0) ? FInputRayHit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InteractiveToolsFramework.InputRayHit", ref FInputRayHit._ScriptStructPtr);
		}

		// Token: 0x06013DD2 RID: 81362 RVA: 0x001D2B76 File Offset: 0x001D0D76
		public FInputRayHit()
		{
		}

		// Token: 0x06013DD3 RID: 81363 RVA: 0x001D2B7E File Offset: 0x001D0D7E
		protected override IntPtr GetUStructPtr()
		{
			return FInputRayHit.StaticStruct();
		}

		// Token: 0x06013DD4 RID: 81364 RVA: 0x001D2B8A File Offset: 0x001D0D8A
		[NullableContext(2)]
		public FInputRayHit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013DD5 RID: 81365 RVA: 0x001D2B94 File Offset: 0x001D0D94
		public FInputRayHit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013DD6 RID: 81366 RVA: 0x001D2B9F File Offset: 0x001D0D9F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputRayHit(Pointer, false, true);
		}

		// Token: 0x06013DD7 RID: 81367 RVA: 0x001D2BA9 File Offset: 0x001D0DA9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputRayHit(Pointer, MemoryOwner);
		}

		// Token: 0x0400ABF1 RID: 44017
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.InputRayHit";

		// Token: 0x0400ABF2 RID: 44018
		private static IntPtr _ScriptStructPtr;
	}
}
