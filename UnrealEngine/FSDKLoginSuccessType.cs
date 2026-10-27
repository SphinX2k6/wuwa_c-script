using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA6 RID: 7334
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKLoginSuccessType : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C760 RID: 116576 RVA: 0x002A1070 File Offset: 0x0029F270
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKLoginSuccessType.StaticFunctionPtr();
		}

		// Token: 0x0601C761 RID: 116577 RVA: 0x002A107C File Offset: 0x0029F27C
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKLoginSuccessType._FunctionPtr == IntPtr.Zero)
			{
				FSDKLoginSuccessType._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKLoginSuccessType__DelegateSignature");
			}
			return FSDKLoginSuccessType._FunctionPtr;
		}

		// Token: 0x0601C762 RID: 116578 RVA: 0x002A109F File Offset: 0x0029F29F
		public FSDKLoginSuccessType()
		{
		}

		// Token: 0x0601C763 RID: 116579 RVA: 0x002A10A7 File Offset: 0x0029F2A7
		[NullableContext(2)]
		public FSDKLoginSuccessType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C764 RID: 116580 RVA: 0x002A10B1 File Offset: 0x0029F2B1
		public FSDKLoginSuccessType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C765 RID: 116581 RVA: 0x002A10BC File Offset: 0x0029F2BC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C766 RID: 116582 RVA: 0x002A10EE File Offset: 0x0029F2EE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FSDKLoginSuccessType.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKLoginSuccessType.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKLoginSuccessType.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKLoginSuccessType.OnScriptCallback));
				}
				FSDKLoginSuccessType.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKLoginSuccessType.RegisterId);
		}

		// Token: 0x0601C767 RID: 116583 RVA: 0x002A1128 File Offset: 0x0029F328
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C768 RID: 116584 RVA: 0x002A1134 File Offset: 0x0029F334
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string result)
		{
			FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams* ptr = stackalloc FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKLoginSuccessType.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->result), result);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKLoginSuccessType._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C769 RID: 116585 RVA: 0x002A1188 File Offset: 0x0029F388
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
			string obj = FString.ToString((void*)(&((FSDKLoginSuccessType.__FSDKLoginSuccessType_DelegateParams*)__Parameters)->result));
			action(obj);
		}

		// Token: 0x0400F4D3 RID: 62675
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4D4 RID: 62676
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKLoginSuccessType__DelegateSignature";

		// Token: 0x0400F4D5 RID: 62677
		private static int RegisterId;

		// Token: 0x0200327E RID: 12926
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSDKLoginSuccessType_DelegateParams
		{
			// Token: 0x04017106 RID: 94470
			[FieldOffset(0)]
			public FString result;
		}

		// Token: 0x0200327F RID: 12927
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017107 RID: 94471
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
