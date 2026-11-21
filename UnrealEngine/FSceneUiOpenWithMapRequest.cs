using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000523 RID: 1315
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiOpenWithMapRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007AE8 RID: 31464 RVA: 0x000B4604 File Offset: 0x000B2804
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiOpenWithMapRequest.StaticFunctionPtr();
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x000B4610 File Offset: 0x000B2810
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiOpenWithMapRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiOpenWithMapRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiOpenWithMapRequest__DelegateSignature");
			}
			return FSceneUiOpenWithMapRequest._FunctionPtr;
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x000B4633 File Offset: 0x000B2833
		public FSceneUiOpenWithMapRequest()
		{
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x000B463B File Offset: 0x000B283B
		[NullableContext(2)]
		public FSceneUiOpenWithMapRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x000B4645 File Offset: 0x000B2845
		public FSceneUiOpenWithMapRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x000B4650 File Offset: 0x000B2850
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor, string>) ?? ((Action<ASceneUiAnchorActor, string>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x000B4682 File Offset: 0x000B2882
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

		// Token: 0x06007AEF RID: 31471 RVA: 0x000B46BC File Offset: 0x000B28BC
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<ASceneUiAnchorActor, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x000B46C8 File Offset: 0x000B28C8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast([Nullable(2)] ASceneUiAnchorActor Anchor, string ViewName)
		{
			FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams* ptr = stackalloc FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FSceneUiOpenWithMapRequest.__FSceneUiOpenWithMapRequest_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSceneUiOpenWithMapRequest.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Anchor = ((Anchor != null) ? Anchor.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->ViewName), ViewName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSceneUiOpenWithMapRequest._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x000B4734 File Offset: 0x000B2934
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003446 RID: 13382
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003447 RID: 13383
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiOpenWithMapRequest__DelegateSignature";

		// Token: 0x04003448 RID: 13384
		private static int RegisterId;

		// Token: 0x02000C91 RID: 3217
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FSceneUiOpenWithMapRequest_DelegateParams
		{
			// Token: 0x04005EF8 RID: 24312
			[FieldOffset(0)]
			public IntPtr Anchor;

			// Token: 0x04005EF9 RID: 24313
			[FieldOffset(8)]
			public FString ViewName;
		}

		// Token: 0x02000C92 RID: 3218
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EFA RID: 24314
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
