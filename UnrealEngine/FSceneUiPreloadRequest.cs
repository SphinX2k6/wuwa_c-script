using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000524 RID: 1316
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiPreloadRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007AF2 RID: 31474 RVA: 0x000B4794 File Offset: 0x000B2994
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiPreloadRequest.StaticFunctionPtr();
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x000B47A0 File Offset: 0x000B29A0
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiPreloadRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiPreloadRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiPreloadRequest__DelegateSignature");
			}
			return FSceneUiPreloadRequest._FunctionPtr;
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x000B47C3 File Offset: 0x000B29C3
		public FSceneUiPreloadRequest()
		{
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x000B47CB File Offset: 0x000B29CB
		[NullableContext(2)]
		public FSceneUiPreloadRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x000B47D5 File Offset: 0x000B29D5
		public FSceneUiPreloadRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x000B47E0 File Offset: 0x000B29E0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor, string>) ?? ((Action<ASceneUiAnchorActor, string>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x000B4812 File Offset: 0x000B2A12
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

		// Token: 0x06007AF9 RID: 31481 RVA: 0x000B484C File Offset: 0x000B2A4C
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<ASceneUiAnchorActor, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x000B4858 File Offset: 0x000B2A58
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast([Nullable(2)] ASceneUiAnchorActor Anchor, string ViewName)
		{
			FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams* ptr = stackalloc FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSceneUiPreloadRequest.__FSceneUiPreloadRequest_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSceneUiPreloadRequest.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Anchor = ((Anchor != null) ? Anchor.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->ViewName), ViewName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSceneUiPreloadRequest._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x000B48C4 File Offset: 0x000B2AC4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003449 RID: 13385
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400344A RID: 13386
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiPreloadRequest__DelegateSignature";

		// Token: 0x0400344B RID: 13387
		private static int RegisterId;

		// Token: 0x02000C93 RID: 3219
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FSceneUiPreloadRequest_DelegateParams
		{
			// Token: 0x04005EFB RID: 24315
			[FieldOffset(0)]
			public IntPtr Anchor;

			// Token: 0x04005EFC RID: 24316
			[FieldOffset(8)]
			public FString ViewName;
		}

		// Token: 0x02000C94 RID: 3220
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EFD RID: 24317
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
