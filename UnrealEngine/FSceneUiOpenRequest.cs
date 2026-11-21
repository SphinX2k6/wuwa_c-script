using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000522 RID: 1314
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiOpenRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007ADE RID: 31454 RVA: 0x000B4459 File Offset: 0x000B2659
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiOpenRequest.StaticFunctionPtr();
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x000B4465 File Offset: 0x000B2665
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiOpenRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiOpenRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiOpenRequest__DelegateSignature");
			}
			return FSceneUiOpenRequest._FunctionPtr;
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x000B4488 File Offset: 0x000B2688
		public FSceneUiOpenRequest()
		{
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x000B4490 File Offset: 0x000B2690
		[NullableContext(2)]
		public FSceneUiOpenRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x000B449A File Offset: 0x000B269A
		public FSceneUiOpenRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x000B44A5 File Offset: 0x000B26A5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor, string, string>) ?? ((Action<ASceneUiAnchorActor, string, string>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x000B44D7 File Offset: 0x000B26D7
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

		// Token: 0x06007AE5 RID: 31461 RVA: 0x000B4511 File Offset: 0x000B2711
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

		// Token: 0x06007AE6 RID: 31462 RVA: 0x000B451C File Offset: 0x000B271C
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x06007AE7 RID: 31463 RVA: 0x000B4594 File Offset: 0x000B2794
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003443 RID: 13379
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003444 RID: 13380
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiOpenRequest__DelegateSignature";

		// Token: 0x04003445 RID: 13381
		private static int RegisterId;

		// Token: 0x02000C8F RID: 3215
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FSceneUiOpenRequest_DelegateParams
		{
			// Token: 0x04005EF4 RID: 24308
			[FieldOffset(0)]
			public IntPtr Anchor;

			// Token: 0x04005EF5 RID: 24309
			[FieldOffset(8)]
			public FString ViewName;

			// Token: 0x04005EF6 RID: 24310
			[FieldOffset(24)]
			public FString Param;
		}

		// Token: 0x02000C90 RID: 3216
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EF7 RID: 24311
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
