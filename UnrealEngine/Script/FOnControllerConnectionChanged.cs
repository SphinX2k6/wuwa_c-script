using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine.Script
{
	// Token: 0x02002ADA RID: 10970
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnControllerConnectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060283CB RID: 164811 RVA: 0x003D32B0 File Offset: 0x003D14B0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnControllerConnectionChanged.StaticFunctionPtr();
		}

		// Token: 0x060283CC RID: 164812 RVA: 0x003D32BC File Offset: 0x003D14BC
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnControllerConnectionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnControllerConnectionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnControllerConnectionChanged__DelegateSignature");
			}
			return FOnControllerConnectionChanged._FunctionPtr;
		}

		// Token: 0x060283CD RID: 164813 RVA: 0x003D32DF File Offset: 0x003D14DF
		public FOnControllerConnectionChanged()
		{
		}

		// Token: 0x060283CE RID: 164814 RVA: 0x003D32E7 File Offset: 0x003D14E7
		[NullableContext(2)]
		public FOnControllerConnectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060283CF RID: 164815 RVA: 0x003D32F1 File Offset: 0x003D14F1
		public FOnControllerConnectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060283D0 RID: 164816 RVA: 0x003D32FC File Offset: 0x003D14FC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, int, int>) ?? ((Action<bool, int, int>)Delegate.CreateDelegate(typeof(Action<bool, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060283D1 RID: 164817 RVA: 0x003D332E File Offset: 0x003D152E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, int, int> Callback)
		{
			if (FOnControllerConnectionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnControllerConnectionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnControllerConnectionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnControllerConnectionChanged.OnScriptCallback));
				}
				FOnControllerConnectionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnControllerConnectionChanged.RegisterId);
		}

		// Token: 0x060283D2 RID: 164818 RVA: 0x003D3368 File Offset: 0x003D1568
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060283D3 RID: 164819 RVA: 0x003D3374 File Offset: 0x003D1574
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsConnected, int PlatformUserId, int ControllerId)
		{
			FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams* ptr = stackalloc FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnControllerConnectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsConnected = bIsConnected;
			ptr->PlatformUserId = PlatformUserId;
			ptr->ControllerId = ControllerId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060283D4 RID: 164820 RVA: 0x003D33C0 File Offset: 0x003D15C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int, int> action = target as Action<bool, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->bIsConnected, ((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->PlatformUserId, ((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->ControllerId);
		}

		// Token: 0x0401627F RID: 90751
		internal static IntPtr _FunctionPtr;

		// Token: 0x04016280 RID: 90752
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnControllerConnectionChanged__DelegateSignature";

		// Token: 0x04016281 RID: 90753
		private static int RegisterId;

		// Token: 0x02003C0A RID: 15370
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnControllerConnectionChanged_DelegateParams
		{
			// Token: 0x04017E40 RID: 97856
			[FieldOffset(0)]
			public bool bIsConnected;

			// Token: 0x04017E41 RID: 97857
			[FieldOffset(4)]
			public int PlatformUserId;

			// Token: 0x04017E42 RID: 97858
			[FieldOffset(8)]
			public int ControllerId;
		}

		// Token: 0x02003C0B RID: 15371
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017E43 RID: 97859
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
