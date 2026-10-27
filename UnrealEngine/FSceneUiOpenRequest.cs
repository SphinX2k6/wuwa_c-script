using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C88 RID: 7304
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiOpenRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C596 RID: 116118 RVA: 0x0029C8D5 File Offset: 0x0029AAD5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiOpenRequest.StaticFunctionPtr();
		}

		// Token: 0x0601C597 RID: 116119 RVA: 0x0029C8E1 File Offset: 0x0029AAE1
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiOpenRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiOpenRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiOpenRequest__DelegateSignature");
			}
			return FSceneUiOpenRequest._FunctionPtr;
		}

		// Token: 0x0601C598 RID: 116120 RVA: 0x0029C904 File Offset: 0x0029AB04
		public FSceneUiOpenRequest()
		{
		}

		// Token: 0x0601C599 RID: 116121 RVA: 0x0029C90C File Offset: 0x0029AB0C
		[NullableContext(2)]
		public FSceneUiOpenRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C59A RID: 116122 RVA: 0x0029C916 File Offset: 0x0029AB16
		public FSceneUiOpenRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C59B RID: 116123 RVA: 0x0029C921 File Offset: 0x0029AB21
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor, string, string>) ?? ((Action<ASceneUiAnchorActor, string, string>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C59C RID: 116124 RVA: 0x0029C953 File Offset: 0x0029AB53
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<ASceneUiAnchorActor, string, string> Callback)
		{
			if (FSceneUiOpenRequest.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSceneUiOpenRequest.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSceneUiOpenRequest.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSceneUiOpenRequest.OnScriptCallback));
				}
				FSceneUiOpenRequest.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSceneUiOpenRequest.RegisterId);
		}

		// Token: 0x0601C59D RID: 116125 RVA: 0x0029C98D File Offset: 0x0029AB8D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})] Action<ASceneUiAnchorActor, string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C59E RID: 116126 RVA: 0x0029C998 File Offset: 0x0029AB98
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(2)] ASceneUiAnchorActor Anchor, string ViewName, string Param)
		{
			FSceneUiOpenRequest.__FSceneUiOpenRequest_DelegateParams* ptr = stackalloc FSceneUiOpenRequest.__FSceneUiOpenRequest_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FSceneUiOpenRequest.__FSceneUiOpenRequest_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSceneUiOpenRequest.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Anchor = ((Anchor != null) ? Anchor.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->ViewName), ViewName);
			FString.CopyFrom((void*)(&ptr->Param), Param);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSceneUiOpenRequest._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C59F RID: 116127 RVA: 0x0029CA10 File Offset: 0x0029AC10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ASceneUiAnchorActor, string, string> action = target as Action<ASceneUiAnchorActor, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ASceneUiAnchorActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASceneUiAnchorActor>(((FSceneUiOpenRequest.__FSceneUiOpenRequest_DelegateParams*)__Parameters)->Anchor);
			string arg = FString.ToString((void*)(&((FSceneUiOpenRequest.__FSceneUiOpenRequest_DelegateParams*)__Parameters)->ViewName));
			string arg2 = FString.ToString((void*)(&((FSceneUiOpenRequest.__FSceneUiOpenRequest_DelegateParams*)__Parameters)->Param));
			action(orCreateUObjectByNativePointer, arg, arg2);
		}

		// Token: 0x0400F3D5 RID: 62421
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F3D6 RID: 62422
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiOpenRequest__DelegateSignature";

		// Token: 0x0400F3D7 RID: 62423
		private static int RegisterId;

		// Token: 0x0200321A RID: 12826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FSceneUiOpenRequest_DelegateParams
		{
			// Token: 0x04017080 RID: 94336
			[FieldOffset(0)]
			public IntPtr Anchor;

			// Token: 0x04017081 RID: 94337
			[FieldOffset(8)]
			public FString ViewName;

			// Token: 0x04017082 RID: 94338
			[FieldOffset(24)]
			public FString Param;
		}

		// Token: 0x0200321B RID: 12827
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017083 RID: 94339
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
