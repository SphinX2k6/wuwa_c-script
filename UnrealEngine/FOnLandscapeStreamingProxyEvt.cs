using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F16 RID: 3862
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLandscapeStreamingProxyEvt : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D0CC RID: 53452 RVA: 0x00131362 File Offset: 0x0012F562
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLandscapeStreamingProxyEvt.StaticFunctionPtr();
		}

		// Token: 0x0600D0CD RID: 53453 RVA: 0x0013136E File Offset: 0x0012F56E
		private static IntPtr StaticFunctionPtr()
		{
			if (UHLODLandscapeSubsystem.__OnLandscapeStreamingProxyEvt__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UHLODLandscapeSubsystem.__OnLandscapeStreamingProxyEvt__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.HLODLandscapeSubsystem:OnLandscapeStreamingProxyEvt__DelegateSignature");
			}
			return UHLODLandscapeSubsystem.__OnLandscapeStreamingProxyEvt__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D0CE RID: 53454 RVA: 0x00131391 File Offset: 0x0012F591
		public FOnLandscapeStreamingProxyEvt()
		{
		}

		// Token: 0x0600D0CF RID: 53455 RVA: 0x00131399 File Offset: 0x0012F599
		[NullableContext(2)]
		public FOnLandscapeStreamingProxyEvt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D0D0 RID: 53456 RVA: 0x001313A3 File Offset: 0x0012F5A3
		public FOnLandscapeStreamingProxyEvt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D0D1 RID: 53457 RVA: 0x001313AE File Offset: 0x0012F5AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ALandscapeStreamingProxy>) ?? ((Action<ALandscapeStreamingProxy>)Delegate.CreateDelegate(typeof(Action<ALandscapeStreamingProxy>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x001313E0 File Offset: 0x0012F5E0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<ALandscapeStreamingProxy> Callback)
		{
			if (FOnLandscapeStreamingProxyEvt.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnLandscapeStreamingProxyEvt.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnLandscapeStreamingProxyEvt.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnLandscapeStreamingProxyEvt.OnScriptCallback));
				}
				FOnLandscapeStreamingProxyEvt.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnLandscapeStreamingProxyEvt.RegisterId);
		}

		// Token: 0x0600D0D3 RID: 53459 RVA: 0x0013141A File Offset: 0x0012F61A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<ALandscapeStreamingProxy> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D0D4 RID: 53460 RVA: 0x00131424 File Offset: 0x0012F624
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ALandscapeStreamingProxy Proxy)
		{
			FOnLandscapeStreamingProxyEvt.__FOnLandscapeStreamingProxyEvt_DelegateParams* ptr = stackalloc FOnLandscapeStreamingProxyEvt.__FOnLandscapeStreamingProxyEvt_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnLandscapeStreamingProxyEvt.__FOnLandscapeStreamingProxyEvt_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnLandscapeStreamingProxyEvt.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D0D5 RID: 53461 RVA: 0x00131470 File Offset: 0x0012F670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ALandscapeStreamingProxy> action = target as Action<ALandscapeStreamingProxy>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ALandscapeStreamingProxy orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALandscapeStreamingProxy>(((FOnLandscapeStreamingProxyEvt.__FOnLandscapeStreamingProxyEvt_DelegateParams*)__Parameters)->Proxy);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04007052 RID: 28754
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HLODLandscapeSubsystem:OnLandscapeStreamingProxyEvt__DelegateSignature";

		// Token: 0x04007053 RID: 28755
		private static int RegisterId;

		// Token: 0x02002D7B RID: 11643
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnLandscapeStreamingProxyEvt_DelegateParams
		{
			// Token: 0x0401679C RID: 92060
			[FieldOffset(0)]
			public IntPtr Proxy;
		}

		// Token: 0x02002D7C RID: 11644
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401679D RID: 92061
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
