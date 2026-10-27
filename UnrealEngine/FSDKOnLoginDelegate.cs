using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA9 RID: 7337
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKOnLoginDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C77E RID: 116606 RVA: 0x002A148D File Offset: 0x0029F68D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKOnLoginDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C77F RID: 116607 RVA: 0x002A1499 File Offset: 0x0029F699
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKOnLoginDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKOnLoginDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKOnLoginDelegate__DelegateSignature");
			}
			return FSDKOnLoginDelegate._FunctionPtr;
		}

		// Token: 0x0601C780 RID: 116608 RVA: 0x002A14BC File Offset: 0x0029F6BC
		public FSDKOnLoginDelegate()
		{
		}

		// Token: 0x0601C781 RID: 116609 RVA: 0x002A14C4 File Offset: 0x0029F6C4
		[NullableContext(2)]
		public FSDKOnLoginDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C782 RID: 116610 RVA: 0x002A14CE File Offset: 0x0029F6CE
		public FSDKOnLoginDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C783 RID: 116611 RVA: 0x002A14D9 File Offset: 0x0029F6D9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C784 RID: 116612 RVA: 0x002A150B File Offset: 0x0029F70B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKOnLoginDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKOnLoginDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKOnLoginDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKOnLoginDelegate.OnScriptCallback));
				}
				FSDKOnLoginDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKOnLoginDelegate.RegisterId);
		}

		// Token: 0x0601C785 RID: 116613 RVA: 0x002A1545 File Offset: 0x0029F745
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C786 RID: 116614 RVA: 0x002A1550 File Offset: 0x0029F750
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string result)
		{
			FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams* ptr = stackalloc FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKOnLoginDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKOnLoginDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C787 RID: 116615 RVA: 0x002A15A4 File Offset: 0x0029F7A4
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
			string obj = FString.ToString((void*)(&((FSDKOnLoginDelegate.__FSDKOnLoginDelegate_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400F4DC RID: 62684
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4DD RID: 62685
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKOnLoginDelegate__DelegateSignature";

		// Token: 0x0400F4DE RID: 62686
		private static int RegisterId;

		// Token: 0x02003283 RID: 12931
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKOnLoginDelegate_DelegateParams
		{
			// Token: 0x0401710D RID: 94477
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x02003284 RID: 12932
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401710E RID: 94478
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
