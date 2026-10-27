using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F10 RID: 3856
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGlobalDataLayerStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D090 RID: 53392 RVA: 0x00130A88 File Offset: 0x0012EC88
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGlobalDataLayerStateChanged.StaticFunctionPtr();
		}

		// Token: 0x0600D091 RID: 53393 RVA: 0x00130A94 File Offset: 0x0012EC94
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGlobalDataLayerStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnGlobalDataLayerStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnGlobalDataLayerStateChanged__DelegateSignature");
			}
			return FOnGlobalDataLayerStateChanged._FunctionPtr;
		}

		// Token: 0x0600D092 RID: 53394 RVA: 0x00130AB7 File Offset: 0x0012ECB7
		public FOnGlobalDataLayerStateChanged()
		{
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x00130ABF File Offset: 0x0012ECBF
		[NullableContext(2)]
		public FOnGlobalDataLayerStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x00130AC9 File Offset: 0x0012ECC9
		public FOnGlobalDataLayerStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D095 RID: 53397 RVA: 0x00130AD4 File Offset: 0x0012ECD4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, EDataLayerState>) ?? ((Action<FName, EDataLayerState>)Delegate.CreateDelegate(typeof(Action<FName, EDataLayerState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D096 RID: 53398 RVA: 0x00130B06 File Offset: 0x0012ED06
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName, EDataLayerState> Callback)
		{
			if (FOnGlobalDataLayerStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGlobalDataLayerStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGlobalDataLayerStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGlobalDataLayerStateChanged.OnScriptCallback));
				}
				FOnGlobalDataLayerStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGlobalDataLayerStateChanged.RegisterId);
		}

		// Token: 0x0600D097 RID: 53399 RVA: 0x00130B40 File Offset: 0x0012ED40
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName, EDataLayerState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D098 RID: 53400 RVA: 0x00130B4C File Offset: 0x0012ED4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName DataLayerLabel, EDataLayerState State)
		{
			FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams* ptr = stackalloc FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGlobalDataLayerStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DataLayerLabel = DataLayerLabel;
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D099 RID: 53401 RVA: 0x00130B90 File Offset: 0x0012ED90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, EDataLayerState> action = target as Action<FName, EDataLayerState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams*)__Parameters)->DataLayerLabel, ((FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x04007045 RID: 28741
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007046 RID: 28742
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnGlobalDataLayerStateChanged__DelegateSignature";

		// Token: 0x04007047 RID: 28743
		private static int RegisterId;

		// Token: 0x02002D6F RID: 11631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnGlobalDataLayerStateChanged_DelegateParams
		{
			// Token: 0x0401678A RID: 92042
			[FieldOffset(0)]
			public FName DataLayerLabel;

			// Token: 0x0401678B RID: 92043
			[FieldOffset(12)]
			public EDataLayerState State;
		}

		// Token: 0x02002D70 RID: 11632
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401678C RID: 92044
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
