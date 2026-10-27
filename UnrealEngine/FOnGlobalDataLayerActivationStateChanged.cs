using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F0F RID: 3855
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGlobalDataLayerActivationStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D086 RID: 53382 RVA: 0x00130932 File Offset: 0x0012EB32
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGlobalDataLayerActivationStateChanged.StaticFunctionPtr();
		}

		// Token: 0x0600D087 RID: 53383 RVA: 0x0013093E File Offset: 0x0012EB3E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGlobalDataLayerActivationStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnGlobalDataLayerActivationStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnGlobalDataLayerActivationStateChanged__DelegateSignature");
			}
			return FOnGlobalDataLayerActivationStateChanged._FunctionPtr;
		}

		// Token: 0x0600D088 RID: 53384 RVA: 0x00130961 File Offset: 0x0012EB61
		public FOnGlobalDataLayerActivationStateChanged()
		{
		}

		// Token: 0x0600D089 RID: 53385 RVA: 0x00130969 File Offset: 0x0012EB69
		[NullableContext(2)]
		public FOnGlobalDataLayerActivationStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D08A RID: 53386 RVA: 0x00130973 File Offset: 0x0012EB73
		public FOnGlobalDataLayerActivationStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D08B RID: 53387 RVA: 0x0013097E File Offset: 0x0012EB7E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, bool>) ?? ((Action<FName, bool>)Delegate.CreateDelegate(typeof(Action<FName, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D08C RID: 53388 RVA: 0x001309B0 File Offset: 0x0012EBB0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName, bool> Callback)
		{
			if (FOnGlobalDataLayerActivationStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGlobalDataLayerActivationStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGlobalDataLayerActivationStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGlobalDataLayerActivationStateChanged.OnScriptCallback));
				}
				FOnGlobalDataLayerActivationStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGlobalDataLayerActivationStateChanged.RegisterId);
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x001309EA File Offset: 0x0012EBEA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D08E RID: 53390 RVA: 0x001309F4 File Offset: 0x0012EBF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName DataLayerLabel, bool bIsActive)
		{
			FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams* ptr = stackalloc FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGlobalDataLayerActivationStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DataLayerLabel = DataLayerLabel;
			ptr->bIsActive = bIsActive;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D08F RID: 53391 RVA: 0x00130A38 File Offset: 0x0012EC38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, bool> action = target as Action<FName, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams*)__Parameters)->DataLayerLabel, ((FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams*)__Parameters)->bIsActive);
		}

		// Token: 0x04007042 RID: 28738
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007043 RID: 28739
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnGlobalDataLayerActivationStateChanged__DelegateSignature";

		// Token: 0x04007044 RID: 28740
		private static int RegisterId;

		// Token: 0x02002D6D RID: 11629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnGlobalDataLayerActivationStateChanged_DelegateParams
		{
			// Token: 0x04016787 RID: 92039
			[FieldOffset(0)]
			public FName DataLayerLabel;

			// Token: 0x04016788 RID: 92040
			[FieldOffset(12)]
			public bool bIsActive;
		}

		// Token: 0x02002D6E RID: 11630
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016789 RID: 92041
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
