using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007DF RID: 2015
	[UnrealObjectPath("/Script/Engine.AnimationErrorStats")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimationErrorStats : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B5A RID: 27482 RVA: 0x0009A8E1 File Offset: 0x00098AE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationErrorStats._ScriptStructPtr != 0) ? FAnimationErrorStats._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationErrorStats", ref FAnimationErrorStats._ScriptStructPtr);
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x0009A905 File Offset: 0x00098B05
		public FAnimationErrorStats()
		{
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x0009A90D File Offset: 0x00098B0D
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationErrorStats.StaticStruct();
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x0009A919 File Offset: 0x00098B19
		[NullableContext(2)]
		public FAnimationErrorStats(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x0009A923 File Offset: 0x00098B23
		public FAnimationErrorStats(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x0009A92E File Offset: 0x00098B2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationErrorStats(Pointer, false, true);
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x0009A938 File Offset: 0x00098B38
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationErrorStats(Pointer, MemoryOwner);
		}

		// Token: 0x040033AC RID: 13228
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationErrorStats";

		// Token: 0x040033AD RID: 13229
		private static IntPtr _ScriptStructPtr;
	}
}
