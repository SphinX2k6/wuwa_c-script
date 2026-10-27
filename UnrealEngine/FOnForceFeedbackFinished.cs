using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F0D RID: 3853
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnForceFeedbackFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D072 RID: 53362 RVA: 0x001306C5 File Offset: 0x0012E8C5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnForceFeedbackFinished.StaticFunctionPtr();
		}

		// Token: 0x0600D073 RID: 53363 RVA: 0x001306D1 File Offset: 0x0012E8D1
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnForceFeedbackFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnForceFeedbackFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnForceFeedbackFinished__DelegateSignature");
			}
			return FOnForceFeedbackFinished._FunctionPtr;
		}

		// Token: 0x0600D074 RID: 53364 RVA: 0x001306F4 File Offset: 0x0012E8F4
		public FOnForceFeedbackFinished()
		{
		}

		// Token: 0x0600D075 RID: 53365 RVA: 0x001306FC File Offset: 0x0012E8FC
		[NullableContext(2)]
		public FOnForceFeedbackFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D076 RID: 53366 RVA: 0x00130706 File Offset: 0x0012E906
		public FOnForceFeedbackFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D077 RID: 53367 RVA: 0x00130711 File Offset: 0x0012E911
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UForceFeedbackComponent>) ?? ((Action<UForceFeedbackComponent>)Delegate.CreateDelegate(typeof(Action<UForceFeedbackComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D078 RID: 53368 RVA: 0x00130743 File Offset: 0x0012E943
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UForceFeedbackComponent> Callback)
		{
			if (FOnForceFeedbackFinished.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnForceFeedbackFinished.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnForceFeedbackFinished.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnForceFeedbackFinished.OnScriptCallback));
				}
				FOnForceFeedbackFinished.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnForceFeedbackFinished.RegisterId);
		}

		// Token: 0x0600D079 RID: 53369 RVA: 0x0013077D File Offset: 0x0012E97D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UForceFeedbackComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D07A RID: 53370 RVA: 0x00130788 File Offset: 0x0012E988
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UForceFeedbackComponent ForceFeedbackComponent)
		{
			FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams* ptr = stackalloc FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnForceFeedbackFinished.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ForceFeedbackComponent = ((ForceFeedbackComponent != null) ? ForceFeedbackComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D07B RID: 53371 RVA: 0x001307D4 File Offset: 0x0012E9D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UForceFeedbackComponent> action = target as Action<UForceFeedbackComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UForceFeedbackComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(((FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams*)__Parameters)->ForceFeedbackComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400703C RID: 28732
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400703D RID: 28733
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnForceFeedbackFinished__DelegateSignature";

		// Token: 0x0400703E RID: 28734
		private static int RegisterId;

		// Token: 0x02002D6A RID: 11626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnForceFeedbackFinished_DelegateParams
		{
			// Token: 0x04016784 RID: 92036
			[FieldOffset(0)]
			public IntPtr ForceFeedbackComponent;
		}

		// Token: 0x02002D6B RID: 11627
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016785 RID: 92037
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
