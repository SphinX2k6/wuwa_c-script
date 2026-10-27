using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C8A RID: 7306
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiPreloadRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C5AA RID: 116138 RVA: 0x0029CC10 File Offset: 0x0029AE10
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiPreloadRequest.StaticFunctionPtr();
		}

		// Token: 0x0601C5AB RID: 116139 RVA: 0x0029CC1C File Offset: 0x0029AE1C
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiPreloadRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiPreloadRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiPreloadRequest__DelegateSignature");
			}
			return FSceneUiPreloadRequest._FunctionPtr;
		}

		// Token: 0x0601C5AC RID: 116140 RVA: 0x0029CC3F File Offset: 0x0029AE3F
		public FSceneUiPreloadRequest()
		{
		}

		// Token: 0x0601C5AD RID: 116141 RVA: 0x0029CC47 File Offset: 0x0029AE47
		[NullableContext(2)]
		public FSceneUiPreloadRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C5AE RID: 116142 RVA: 0x0029CC51 File Offset: 0x0029AE51
		public FSceneUiPreloadRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C5AF RID: 116143 RVA: 0x0029CC5C File Offset: 0x0029AE5C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor, string>) ?? ((Action<ASceneUiAnchorActor, string>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C5B0 RID: 116144 RVA: 0x0029CC8E File Offset: 0x0029AE8E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<ASceneUiAnchorActor, string> Callback)
		{
			if (FSceneUiPreloadRequest.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSceneUiPreloadRequest.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSceneUiPreloadRequest.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSceneUiPreloadRequest.OnScriptCallback));
				}
				FSceneUiPreloadRequest.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSceneUiPreloadRequest.RegisterId);
		}

		// Token: 0x0601C5B1 RID: 116145 RVA: 0x0029CCC8 File Offset: 0x0029AEC8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<ASceneUiAnchorActor, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C5B2 RID: 116146 RVA: 0x0029CCD4 File Offset: 0x0029AED4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(2)] ASceneUiAnchorActor Anchor, string ViewName)
		{
			FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams* ptr = stackalloc FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSceneUiPreloadRequest.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Anchor = ((Anchor != null) ? Anchor.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->ViewName), ViewName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSceneUiPreloadRequest._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C5B3 RID: 116147 RVA: 0x0029CD40 File Offset: 0x0029AF40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ASceneUiAnchorActor, string> action = target as Action<ASceneUiAnchorActor, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ASceneUiAnchorActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASceneUiAnchorActor>(((FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams*)__Parameters)->Anchor);
			string arg = FString.ToString((void*)(&((FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams*)__Parameters)->ViewName));
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x0400F3DB RID: 62427
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F3DC RID: 62428
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiPreloadRequest__DelegateSignature";

		// Token: 0x0400F3DD RID: 62429
		private static int RegisterId;

		// Token: 0x0200321E RID: 12830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FSceneUiPreloadRequest_DelegateParams
		{
			// Token: 0x04017087 RID: 94343
			[FieldOffset(0)]
			public IntPtr Anchor;

			// Token: 0x04017088 RID: 94344
			[FieldOffset(8)]
			public FString ViewName;
		}

		// Token: 0x0200321F RID: 12831
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017089 RID: 94345
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
