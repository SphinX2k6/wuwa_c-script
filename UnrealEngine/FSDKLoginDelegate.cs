using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA5 RID: 7333
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLoginDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C756 RID: 116566 RVA: 0x002A0EF2 File Offset: 0x0029F0F2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLoginDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C757 RID: 116567 RVA: 0x002A0EFE File Offset: 0x0029F0FE
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLoginDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKLoginDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLoginDelegate__DelegateSignature");
			}
			return FSDKLoginDelegate._FunctionPtr;
		}

		// Token: 0x0601C758 RID: 116568 RVA: 0x002A0F21 File Offset: 0x0029F121
		public FSDKLoginDelegate()
		{
		}

		// Token: 0x0601C759 RID: 116569 RVA: 0x002A0F29 File Offset: 0x0029F129
		[NullableContext(2)]
		public FSDKLoginDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C75A RID: 116570 RVA: 0x002A0F33 File Offset: 0x0029F133
		public FSDKLoginDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C75B RID: 116571 RVA: 0x002A0F3E File Offset: 0x0029F13E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FLoginStruct>) ?? ((Action<FLoginStruct>)Delegate.CreateDelegate(typeof(Action<FLoginStruct>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C75C RID: 116572 RVA: 0x002A0F70 File Offset: 0x0029F170
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FLoginStruct> Callback)
		{
			if (FSDKLoginDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKLoginDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKLoginDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKLoginDelegate.OnScriptCallback));
				}
				FSDKLoginDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKLoginDelegate.RegisterId);
		}

		// Token: 0x0601C75D RID: 116573 RVA: 0x002A0FAA File Offset: 0x0029F1AA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FLoginStruct> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C75E RID: 116574 RVA: 0x002A0FB4 File Offset: 0x0029F1B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FLoginStruct LoginInfo)
		{
			FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams* ptr = stackalloc FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams[(UIntPtr)103] + 15L / (long)sizeof(FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKLoginDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (LoginInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FLoginStruct.StaticStruct(), &ptr->LoginInfo, LoginInfo.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKLoginDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C75F RID: 116575 RVA: 0x002A101C File Offset: 0x0029F21C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FLoginStruct> action = target as Action<FLoginStruct>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FLoginStruct obj = new FLoginStruct(&((FSDKLoginDelegate.__FSDKLoginDelegate_DelegateParams*)__Parameters)->LoginInfo, true, true);
			action(obj);
		}

		// Token: 0x0400F4D0 RID: 62672
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4D1 RID: 62673
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLoginDelegate__DelegateSignature";

		// Token: 0x0400F4D2 RID: 62674
		private static int RegisterId;

		// Token: 0x0200327C RID: 12924
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __FSDKLoginDelegate_DelegateParams
		{
			// Token: 0x04017104 RID: 94468
			[FieldOffset(0)]
			public byte LoginInfo;
		}

		// Token: 0x0200327D RID: 12925
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017105 RID: 94469
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
