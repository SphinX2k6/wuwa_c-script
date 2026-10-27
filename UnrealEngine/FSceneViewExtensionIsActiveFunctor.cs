using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010DC RID: 4316
	[UnrealObjectPath("/Script/Engine.SceneViewExtensionIsActiveFunctor")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FSceneViewExtensionIsActiveFunctor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F785 RID: 63365 RVA: 0x0016E525 File Offset: 0x0016C725
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneViewExtensionIsActiveFunctor._ScriptStructPtr != 0) ? FSceneViewExtensionIsActiveFunctor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SceneViewExtensionIsActiveFunctor", ref FSceneViewExtensionIsActiveFunctor._ScriptStructPtr);
		}

		// Token: 0x0600F786 RID: 63366 RVA: 0x0016E549 File Offset: 0x0016C749
		public FSceneViewExtensionIsActiveFunctor()
		{
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x0016E551 File Offset: 0x0016C751
		protected override IntPtr GetUStructPtr()
		{
			return FSceneViewExtensionIsActiveFunctor.StaticStruct();
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x0016E55D File Offset: 0x0016C75D
		[NullableContext(2)]
		public FSceneViewExtensionIsActiveFunctor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x0016E567 File Offset: 0x0016C767
		public FSceneViewExtensionIsActiveFunctor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F78A RID: 63370 RVA: 0x0016E572 File Offset: 0x0016C772
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneViewExtensionIsActiveFunctor(Pointer, false, true);
		}

		// Token: 0x0600F78B RID: 63371 RVA: 0x0016E57C File Offset: 0x0016C77C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneViewExtensionIsActiveFunctor(Pointer, MemoryOwner);
		}

		// Token: 0x040085C2 RID: 34242
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SceneViewExtensionIsActiveFunctor";

		// Token: 0x040085C3 RID: 34243
		private static IntPtr _ScriptStructPtr;
	}
}
