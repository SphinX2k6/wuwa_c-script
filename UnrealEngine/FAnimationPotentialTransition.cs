using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E2 RID: 2018
	[UnrealObjectPath("/Script/Engine.AnimationPotentialTransition")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAnimationPotentialTransition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B76 RID: 27510 RVA: 0x0009AA91 File Offset: 0x00098C91
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationPotentialTransition._ScriptStructPtr != 0) ? FAnimationPotentialTransition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationPotentialTransition", ref FAnimationPotentialTransition._ScriptStructPtr);
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x0009AAB5 File Offset: 0x00098CB5
		public FAnimationPotentialTransition()
		{
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x0009AABD File Offset: 0x00098CBD
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationPotentialTransition.StaticStruct();
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x0009AAC9 File Offset: 0x00098CC9
		[NullableContext(2)]
		public FAnimationPotentialTransition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x0009AAD3 File Offset: 0x00098CD3
		public FAnimationPotentialTransition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x0009AADE File Offset: 0x00098CDE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationPotentialTransition(Pointer, false, true);
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x0009AAE8 File Offset: 0x00098CE8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationPotentialTransition(Pointer, MemoryOwner);
		}

		// Token: 0x040033B5 RID: 13237
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationPotentialTransition";

		// Token: 0x040033B6 RID: 13238
		private static IntPtr _ScriptStructPtr;
	}
}
