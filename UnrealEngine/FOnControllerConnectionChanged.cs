using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001801 RID: 6145
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnControllerConnectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016BF7 RID: 93175 RVA: 0x002132A9 File Offset: 0x002114A9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnControllerConnectionChanged.StaticFunctionPtr();
		}

		// Token: 0x06016BF8 RID: 93176 RVA: 0x002132B5 File Offset: 0x002114B5
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnControllerConnectionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnControllerConnectionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroDevice.OnControllerConnectionChanged__DelegateSignature");
			}
			return FOnControllerConnectionChanged._FunctionPtr;
		}

		// Token: 0x06016BF9 RID: 93177 RVA: 0x002132D8 File Offset: 0x002114D8
		public FOnControllerConnectionChanged()
		{
		}

		// Token: 0x06016BFA RID: 93178 RVA: 0x002132E0 File Offset: 0x002114E0
		[NullableContext(2)]
		public FOnControllerConnectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016BFB RID: 93179 RVA: 0x002132EA File Offset: 0x002114EA
		public FOnControllerConnectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016BFC RID: 93180 RVA: 0x002132F5 File Offset: 0x002114F5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, int, int, TArray<string>>) ?? ((Action<bool, int, int, TArray<string>>)Delegate.CreateDelegate(typeof(Action<bool, int, int, TArray<string>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016BFD RID: 93181 RVA: 0x00213327 File Offset: 0x00211527
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, int, int, TArray<string>> Callback)
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

		// Token: 0x06016BFE RID: 93182 RVA: 0x00213361 File Offset: 0x00211561
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, int, int, TArray<string>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06016BFF RID: 93183 RVA: 0x0021336C File Offset: 0x0021156C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsConnected, int PlatformUserId, int ControllerId, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> PidAndVidArray)
		{
			FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams* ptr = stackalloc FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnControllerConnectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsConnected = bIsConnected;
			ptr->PlatformUserId = PlatformUserId;
			ptr->ControllerId = ControllerId;
			if (PidAndVidArray != null)
			{
				PidAndVidArray.CopyTo(&ptr->PidAndVidArray, default(UScriptStructStackOnlyPtr));
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnControllerConnectionChanged._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016C00 RID: 93184 RVA: 0x002133E4 File Offset: 0x002115E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int, int, TArray<string>> action = target as Action<bool, int, int, TArray<string>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> arg = new TArray<string>(&((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->PidAndVidArray, true, true);
			action(((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->bIsConnected, ((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->PlatformUserId, ((FOnControllerConnectionChanged.__FOnControllerConnectionChanged_DelegateParams*)__Parameters)->ControllerId, arg);
		}

		// Token: 0x0400C58E RID: 50574
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C58F RID: 50575
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDevice.OnControllerConnectionChanged__DelegateSignature";

		// Token: 0x0400C590 RID: 50576
		private static int RegisterId;

		// Token: 0x02002F4F RID: 12111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnControllerConnectionChanged_DelegateParams
		{
			// Token: 0x04016AF4 RID: 92916
			[FieldOffset(0)]
			public bool bIsConnected;

			// Token: 0x04016AF5 RID: 92917
			[FieldOffset(4)]
			public int PlatformUserId;

			// Token: 0x04016AF6 RID: 92918
			[FieldOffset(8)]
			public int ControllerId;

			// Token: 0x04016AF7 RID: 92919
			[FieldOffset(16)]
			public byte PidAndVidArray;
		}

		// Token: 0x02002F50 RID: 12112
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AF8 RID: 92920
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
