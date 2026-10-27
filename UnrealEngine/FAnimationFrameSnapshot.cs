using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E0 RID: 2016
	[UnrealObjectPath("/Script/Engine.AnimationFrameSnapshot")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAnimationFrameSnapshot : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B61 RID: 27489 RVA: 0x0009A941 File Offset: 0x00098B41
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationFrameSnapshot._ScriptStructPtr != 0) ? FAnimationFrameSnapshot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationFrameSnapshot", ref FAnimationFrameSnapshot._ScriptStructPtr);
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x0009A965 File Offset: 0x00098B65
		public FAnimationFrameSnapshot()
		{
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x0009A96D File Offset: 0x00098B6D
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationFrameSnapshot.StaticStruct();
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x0009A979 File Offset: 0x00098B79
		[NullableContext(2)]
		public FAnimationFrameSnapshot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x0009A983 File Offset: 0x00098B83
		public FAnimationFrameSnapshot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x0009A98E File Offset: 0x00098B8E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationFrameSnapshot(Pointer, false, true);
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x0009A998 File Offset: 0x00098B98
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationFrameSnapshot(Pointer, MemoryOwner);
		}

		// Token: 0x040033AE RID: 13230
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationFrameSnapshot";

		// Token: 0x040033AF RID: 13231
		private static IntPtr _ScriptStructPtr;
	}
}
