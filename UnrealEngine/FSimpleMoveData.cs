using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200176B RID: 5995
	[UnrealObjectPath("/Script/KuroComponent.SimpleMoveData")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FSimpleMoveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060158F8 RID: 88312 RVA: 0x001FB923 File Offset: 0x001F9B23
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimpleMoveData._ScriptStructPtr != 0) ? FSimpleMoveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.SimpleMoveData", ref FSimpleMoveData._ScriptStructPtr);
		}

		// Token: 0x060158F9 RID: 88313 RVA: 0x001FB947 File Offset: 0x001F9B47
		public FSimpleMoveData()
		{
		}

		// Token: 0x060158FA RID: 88314 RVA: 0x001FB94F File Offset: 0x001F9B4F
		protected override IntPtr GetUStructPtr()
		{
			return FSimpleMoveData.StaticStruct();
		}

		// Token: 0x060158FB RID: 88315 RVA: 0x001FB95B File Offset: 0x001F9B5B
		[NullableContext(2)]
		public FSimpleMoveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060158FC RID: 88316 RVA: 0x001FB965 File Offset: 0x001F9B65
		public FSimpleMoveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060158FD RID: 88317 RVA: 0x001FB970 File Offset: 0x001F9B70
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimpleMoveData(Pointer, false, true);
		}

		// Token: 0x060158FE RID: 88318 RVA: 0x001FB97A File Offset: 0x001F9B7A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimpleMoveData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC3D RID: 48189
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.SimpleMoveData";

		// Token: 0x0400BC3E RID: 48190
		private static IntPtr _ScriptStructPtr;
	}
}
