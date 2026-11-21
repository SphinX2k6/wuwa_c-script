using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000520 RID: 1312
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSceneUiAnchorRequest : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007AC3 RID: 31427 RVA: 0x000B4052 File Offset: 0x000B2252
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSceneUiAnchorRequest.StaticFunctionPtr();
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x000B405E File Offset: 0x000B225E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSceneUiAnchorRequest._FunctionPtr == IntPtr.Zero)
			{
				FSceneUiAnchorRequest._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSceneUI.SceneUiAnchorRequest__DelegateSignature");
			}
			return FSceneUiAnchorRequest._FunctionPtr;
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x000B4081 File Offset: 0x000B2281
		public FSceneUiAnchorRequest()
		{
		}

		// Token: 0x06007AC6 RID: 31430 RVA: 0x000B4089 File Offset: 0x000B2289
		[NullableContext(2)]
		public FSceneUiAnchorRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x000B4093 File Offset: 0x000B2293
		public FSceneUiAnchorRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x000B409E File Offset: 0x000B229E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ASceneUiAnchorActor>) ?? ((Action<ASceneUiAnchorActor>)Delegate.CreateDelegate(typeof(Action<ASceneUiAnchorActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x000B40D0 File Offset: 0x000B22D0
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

		// Token: 0x06007ACA RID: 31434 RVA: 0x000B410A File Offset: 0x000B230A
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<ASceneUiAnchorActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x000B4114 File Offset: 0x000B2314
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ASceneUiAnchorActor Anchor)
		{
			FSceneUiAnchorRequest.__FSceneUiAnchorRequest_DelegateParams* ptr = stackalloc FSceneUiAnchorRequest.__FSceneUiAnchorRequest_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSceneUiAnchorRequest.__FSceneUiAnchorRequest_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSceneUiAnchorRequest.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Anchor = ((Anchor != null) ? Anchor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x000B4160 File Offset: 0x000B2360
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003431 RID: 13361
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003432 RID: 13362
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneUI.SceneUiAnchorRequest__DelegateSignature";

		// Token: 0x04003433 RID: 13363
		private static int RegisterId;

		// Token: 0x02000C8D RID: 3213
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSceneUiAnchorRequest_DelegateParams
		{
			// Token: 0x04005EF2 RID: 24306
			[FieldOffset(0)]
			public IntPtr Anchor;
		}

		// Token: 0x02000C8E RID: 3214
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EF3 RID: 24307
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
