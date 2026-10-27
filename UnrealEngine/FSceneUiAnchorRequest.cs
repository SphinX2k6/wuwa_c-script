using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C86 RID: 7302
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiAnchorRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C57B RID: 116091 RVA: 0x0029C4CE File Offset: 0x0029A6CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiAnchorRequest.StaticFunctionPtr();
		}

		// Token: 0x0601C57C RID: 116092 RVA: 0x0029C4DA File Offset: 0x0029A6DA
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiAnchorRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiAnchorRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiAnchorRequest__DelegateSignature");
			}
			return FSceneUiAnchorRequest._FunctionPtr;
		}

		// Token: 0x0601C57D RID: 116093 RVA: 0x0029C4FD File Offset: 0x0029A6FD
		public FSceneUiAnchorRequest()
		{
		}

		// Token: 0x0601C57E RID: 116094 RVA: 0x0029C505 File Offset: 0x0029A705
		[NullableContext(2)]
		public FSceneUiAnchorRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C57F RID: 116095 RVA: 0x0029C50F File Offset: 0x0029A70F
		public FSceneUiAnchorRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C580 RID: 116096 RVA: 0x0029C51A File Offset: 0x0029A71A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor>) ?? ((Action<ASceneUiAnchorActor>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C581 RID: 116097 RVA: 0x0029C54C File Offset: 0x0029A74C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<ASceneUiAnchorActor> Callback)
		{
			if (FSceneUiAnchorRequest.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSceneUiAnchorRequest.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSceneUiAnchorRequest.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSceneUiAnchorRequest.OnScriptCallback));
				}
				FSceneUiAnchorRequest.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSceneUiAnchorRequest.RegisterId);
		}

		// Token: 0x0601C582 RID: 116098 RVA: 0x0029C586 File Offset: 0x0029A786
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<ASceneUiAnchorActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C583 RID: 116099 RVA: 0x0029C590 File Offset: 0x0029A790
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ASceneUiAnchorActor Anchor)
		{
			FSceneUiAnchorRequest.__FSceneUiAnchorRequest_DelegateParams* ptr = stackalloc FSceneUiAnchorRequest.__FSceneUiAnchorRequest_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSceneUiAnchorRequest.__FSceneUiAnchorRequest_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSceneUiAnchorRequest.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Anchor = ((Anchor != null) ? Anchor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C584 RID: 116100 RVA: 0x0029C5DC File Offset: 0x0029A7DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ASceneUiAnchorActor> action = target as Action<ASceneUiAnchorActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ASceneUiAnchorActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASceneUiAnchorActor>(((FSceneUiAnchorRequest.__FSceneUiAnchorRequest_DelegateParams*)__Parameters)->Anchor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400F3C3 RID: 62403
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F3C4 RID: 62404
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiAnchorRequest__DelegateSignature";

		// Token: 0x0400F3C5 RID: 62405
		private static int RegisterId;

		// Token: 0x02003218 RID: 12824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSceneUiAnchorRequest_DelegateParams
		{
			// Token: 0x0401707E RID: 94334
			[FieldOffset(0)]
			public IntPtr Anchor;
		}

		// Token: 0x02003219 RID: 12825
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401707F RID: 94335
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
