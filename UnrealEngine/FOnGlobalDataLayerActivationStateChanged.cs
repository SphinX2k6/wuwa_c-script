using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000254 RID: 596
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGlobalDataLayerActivationStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032FF RID: 13055 RVA: 0x00048F6A File Offset: 0x0004716A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGlobalDataLayerActivationStateChanged.StaticFunctionPtr();
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00048F76 File Offset: 0x00047176
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGlobalDataLayerActivationStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnGlobalDataLayerActivationStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnGlobalDataLayerActivationStateChanged__DelegateSignature");
			}
			return FOnGlobalDataLayerActivationStateChanged._FunctionPtr;
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00048F99 File Offset: 0x00047199
		public FOnGlobalDataLayerActivationStateChanged()
		{
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00048FA1 File Offset: 0x000471A1
		[NullableContext(2)]
		public FOnGlobalDataLayerActivationStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00048FAB File Offset: 0x000471AB
		public FOnGlobalDataLayerActivationStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x00048FB6 File Offset: 0x000471B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, bool>) ?? ((Action<FName, bool>)Delegate.CreateDelegate(typeof(Action<FName, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x00048FE8 File Offset: 0x000471E8
		[NullableContext(1)]
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

		// Token: 0x06003306 RID: 13062 RVA: 0x00049022 File Offset: 0x00047222
		[NullableContext(1)]
		public void Remove(Action<FName, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x0004902C File Offset: 0x0004722C
		[SkipLocalsInit]
		public unsafe void Broadcast(FName DataLayerLabel, bool bIsActive)
		{
			FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams* ptr = stackalloc FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGlobalDataLayerActivationStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DataLayerLabel = DataLayerLabel;
			ptr->bIsActive = bIsActive;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00049070 File Offset: 0x00047270
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, bool> action = target as Action<FName, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams*)__Parameters)->DataLayerLabel, ((FOnGlobalDataLayerActivationStateChanged.__FOnGlobalDataLayerActivationStateChanged_DelegateParams*)__Parameters)->bIsActive);
		}

		// Token: 0x040011C8 RID: 4552
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011C9 RID: 4553
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnGlobalDataLayerActivationStateChanged__DelegateSignature";

		// Token: 0x040011CA RID: 4554
		private static int RegisterId;

		// Token: 0x020009D3 RID: 2515
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnGlobalDataLayerActivationStateChanged_DelegateParams
		{
			// Token: 0x04005960 RID: 22880
			[FieldOffset(0)]
			public FName DataLayerLabel;

			// Token: 0x04005961 RID: 22881
			[FieldOffset(12)]
			public bool bIsActive;
		}

		// Token: 0x020009D4 RID: 2516
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005962 RID: 22882
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
