using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C98 RID: 7320
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKCustomerServiceResultDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6D4 RID: 116436 RVA: 0x0029FCD2 File Offset: 0x0029DED2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKCustomerServiceResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C6D5 RID: 116437 RVA: 0x0029FCDE File Offset: 0x0029DEDE
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKCustomerServiceResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKCustomerServiceResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKCustomerServiceResultDelegate__DelegateSignature");
			}
			return FSDKCustomerServiceResultDelegate._FunctionPtr;
		}

		// Token: 0x0601C6D6 RID: 116438 RVA: 0x0029FD01 File Offset: 0x0029DF01
		public FSDKCustomerServiceResultDelegate()
		{
		}

		// Token: 0x0601C6D7 RID: 116439 RVA: 0x0029FD09 File Offset: 0x0029DF09
		[NullableContext(2)]
		public FSDKCustomerServiceResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6D8 RID: 116440 RVA: 0x0029FD13 File Offset: 0x0029DF13
		public FSDKCustomerServiceResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6D9 RID: 116441 RVA: 0x0029FD1E File Offset: 0x0029DF1E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6DA RID: 116442 RVA: 0x0029FD50 File Offset: 0x0029DF50
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKCustomerServiceResultDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKCustomerServiceResultDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKCustomerServiceResultDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKCustomerServiceResultDelegate.OnScriptCallback));
				}
				FSDKCustomerServiceResultDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKCustomerServiceResultDelegate.RegisterId);
		}

		// Token: 0x0601C6DB RID: 116443 RVA: 0x0029FD8A File Offset: 0x0029DF8A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C6DC RID: 116444 RVA: 0x0029FD94 File Offset: 0x0029DF94
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string result)
		{
			FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams* ptr = stackalloc FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKCustomerServiceResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKCustomerServiceResultDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C6DD RID: 116445 RVA: 0x0029FDE8 File Offset: 0x0029DFE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FSDKCustomerServiceResultDelegate.__FSDKCustomerServiceResultDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400F4A9 RID: 62633
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4AA RID: 62634
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKCustomerServiceResultDelegate__DelegateSignature";

		// Token: 0x0400F4AB RID: 62635
		private static int RegisterId;

		// Token: 0x02003264 RID: 12900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKCustomerServiceResultDelegate_DelegateParams
		{
			// Token: 0x040170E5 RID: 94437
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02003265 RID: 12901
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170E6 RID: 94438
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
