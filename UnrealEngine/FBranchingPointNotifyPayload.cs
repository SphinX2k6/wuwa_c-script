using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008F2 RID: 2290
	[UnrealObjectPath("/Script/Engine.BranchingPointNotifyPayload")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBranchingPointNotifyPayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007DA1 RID: 32161 RVA: 0x000B404C File Offset: 0x000B224C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBranchingPointNotifyPayload._ScriptStructPtr != 0) ? FBranchingPointNotifyPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BranchingPointNotifyPayload", ref FBranchingPointNotifyPayload._ScriptStructPtr);
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x000B4070 File Offset: 0x000B2270
		public FBranchingPointNotifyPayload()
		{
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x000B4078 File Offset: 0x000B2278
		protected override IntPtr GetUStructPtr()
		{
			return FBranchingPointNotifyPayload.StaticStruct();
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x000B4084 File Offset: 0x000B2284
		[NullableContext(2)]
		public FBranchingPointNotifyPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x000B408E File Offset: 0x000B228E
		public FBranchingPointNotifyPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x000B4099 File Offset: 0x000B2299
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBranchingPointNotifyPayload(Pointer, false, true);
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x000B40A3 File Offset: 0x000B22A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBranchingPointNotifyPayload(Pointer, MemoryOwner);
		}

		// Token: 0x04003C2D RID: 15405
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BranchingPointNotifyPayload";

		// Token: 0x04003C2E RID: 15406
		private static IntPtr _ScriptStructPtr;
	}
}
