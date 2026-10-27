using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C89 RID: 7305
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiOpenWithMapRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C5A0 RID: 116128 RVA: 0x0029CA80 File Offset: 0x0029AC80
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiOpenWithMapRequest.StaticFunctionPtr();
		}

		// Token: 0x0601C5A1 RID: 116129 RVA: 0x0029CA8C File Offset: 0x0029AC8C
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiOpenWithMapRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiOpenWithMapRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiOpenWithMapRequest__DelegateSignature");
			}
			return FSceneUiOpenWithMapRequest._FunctionPtr;
		}

		// Token: 0x0601C5A2 RID: 116130 RVA: 0x0029CAAF File Offset: 0x0029ACAF
		public FSceneUiOpenWithMapRequest()
		{
		}

		// Token: 0x0601C5A3 RID: 116131 RVA: 0x0029CAB7 File Offset: 0x0029ACB7
		[NullableContext(2)]
		public FSceneUiOpenWithMapRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C5A4 RID: 116132 RVA: 0x0029CAC1 File Offset: 0x0029ACC1
		public FSceneUiOpenWithMapRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C5A5 RID: 116133 RVA: 0x0029CACC File Offset: 0x0029ACCC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor, string>) ?? ((Action<ASceneUiAnchorActor, string>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C5A6 RID: 116134 RVA: 0x0029CAFE File Offset: 0x0029ACFE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<ASceneUiAnchorActor, string> Callback)
		{
			if (FSceneUiOpenWithMapRequest.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSceneUiOpenWithMapRequest.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSceneUiOpenWithMapRequest.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSceneUiOpenWithMapRequest.OnScriptCallback));
				}
				FSceneUiOpenWithMapRequest.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSceneUiOpenWithMapRequest.RegisterId);
		}

		// Token: 0x0601C5A7 RID: 116135 RVA: 0x0029CB38 File Offset: 0x0029AD38
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

		// Token: 0x0601C5A8 RID: 116136 RVA: 0x0029CB44 File Offset: 0x0029AD44
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(2)] ASceneUiAnchorActor Anchor, string ViewName)
		{
			FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams* ptr = stackalloc FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSceneUiOpenWithMapRequest.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Anchor = ((Anchor != null) ? Anchor.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->ViewName), ViewName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSceneUiOpenWithMapRequest._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C5A9 RID: 116137 RVA: 0x0029CBB0 File Offset: 0x0029ADB0
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
			ASceneUiAnchorActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASceneUiAnchorActor>(((FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams*)__Parameters)->Anchor);
			string arg = FString.ToString((void*)(&((FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams*)__Parameters)->ViewName));
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x0400F3D8 RID: 62424
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F3D9 RID: 62425
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiOpenWithMapRequest__DelegateSignature";

		// Token: 0x0400F3DA RID: 62426
		private static int RegisterId;

		// Token: 0x0200321C RID: 12828
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FSceneUiOpenWithMapRequest_DelegateParams
		{
			// Token: 0x04017084 RID: 94340
			[FieldOffset(0)]
			public IntPtr Anchor;

			// Token: 0x04017085 RID: 94341
			[FieldOffset(8)]
			public FString ViewName;
		}

		// Token: 0x0200321D RID: 12829
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017086 RID: 94342
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
