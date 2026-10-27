using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000408 RID: 1032
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnARTrackingStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003778 RID: 14200 RVA: 0x00054521 File Offset: 0x00052721
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnARTrackingStateChanged.StaticFunctionPtr();
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x0005452D File Offset: 0x0005272D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnARTrackingStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnARTrackingStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.OnARTrackingStateChanged__DelegateSignature");
			}
			return FOnARTrackingStateChanged._FunctionPtr;
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00054550 File Offset: 0x00052750
		public FOnARTrackingStateChanged()
		{
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x00054558 File Offset: 0x00052758
		[NullableContext(2)]
		public FOnARTrackingStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00054562 File Offset: 0x00052762
		public FOnARTrackingStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0005456D File Offset: 0x0005276D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EARTrackingState>) ?? ((Action<EARTrackingState>)Delegate.CreateDelegate(typeof(Action<EARTrackingState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0005459F File Offset: 0x0005279F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EARTrackingState> Callback)
		{
			if (FOnARTrackingStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnARTrackingStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnARTrackingStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnARTrackingStateChanged.OnScriptCallback));
				}
				FOnARTrackingStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnARTrackingStateChanged.RegisterId);
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x000545D9 File Offset: 0x000527D9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EARTrackingState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x000545E4 File Offset: 0x000527E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EARTrackingState NewTrackingState)
		{
			FOnARTrackingStateChanged.__FOnARTrackingStateChanged_DelegateParams* ptr = stackalloc FOnARTrackingStateChanged.__FOnARTrackingStateChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnARTrackingStateChanged.__FOnARTrackingStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnARTrackingStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewTrackingState = NewTrackingState;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00054620 File Offset: 0x00052820
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EARTrackingState> action = target as Action<EARTrackingState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnARTrackingStateChanged.__FOnARTrackingStateChanged_DelegateParams*)__Parameters)->NewTrackingState);
		}

		// Token: 0x04001936 RID: 6454
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001937 RID: 6455
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.OnARTrackingStateChanged__DelegateSignature";

		// Token: 0x04001938 RID: 6456
		private static int RegisterId;

		// Token: 0x02002C27 RID: 11303
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnARTrackingStateChanged_DelegateParams
		{
			// Token: 0x04016530 RID: 91440
			[FieldOffset(0)]
			public EARTrackingState NewTrackingState;
		}

		// Token: 0x02002C28 RID: 11304
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016531 RID: 91441
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
