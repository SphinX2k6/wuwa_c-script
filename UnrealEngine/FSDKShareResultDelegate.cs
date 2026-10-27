using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CB0 RID: 7344
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKShareResultDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C7C4 RID: 116676 RVA: 0x002A1E1A File Offset: 0x002A001A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKShareResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601C7C5 RID: 116677 RVA: 0x002A1E26 File Offset: 0x002A0026
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKShareResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSDKShareResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKShareResultDelegate__DelegateSignature");
			}
			return FSDKShareResultDelegate._FunctionPtr;
		}

		// Token: 0x0601C7C6 RID: 116678 RVA: 0x002A1E49 File Offset: 0x002A0049
		public FSDKShareResultDelegate()
		{
		}

		// Token: 0x0601C7C7 RID: 116679 RVA: 0x002A1E51 File Offset: 0x002A0051
		[NullableContext(2)]
		public FSDKShareResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7C8 RID: 116680 RVA: 0x002A1E5B File Offset: 0x002A005B
		public FSDKShareResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7C9 RID: 116681 RVA: 0x002A1E66 File Offset: 0x002A0066
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, string, string>) ?? ((Action<int, string, string>)Delegate.CreateDelegate(typeof(Action<int, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C7CA RID: 116682 RVA: 0x002A1E98 File Offset: 0x002A0098
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, string, string> Callback)
		{
			if (FSDKShareResultDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKShareResultDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKShareResultDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKShareResultDelegate.OnScriptCallback));
				}
				FSDKShareResultDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKShareResultDelegate.RegisterId);
		}

		// Token: 0x0601C7CB RID: 116683 RVA: 0x002A1ED2 File Offset: 0x002A00D2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C7CC RID: 116684 RVA: 0x002A1EDC File Offset: 0x002A00DC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int code, string platform, string msg)
		{
			FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams* ptr = stackalloc FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKShareResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->code = code;
			FString.CopyFrom((void*)(&ptr->platform), platform);
			FString.CopyFrom((void*)(&ptr->msg), msg);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKShareResultDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C7CD RID: 116685 RVA: 0x002A1F44 File Offset: 0x002A0144
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string, string> action = target as Action<int, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams*)__Parameters)->platform));
			string arg2 = FString.ToString((void*)(&((FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams*)__Parameters)->msg));
			action(((FSDKShareResultDelegate.__FSDKShareResultDelegate_DelegateParams*)__Parameters)->code, arg, arg2);
		}

		// Token: 0x0400F4F1 RID: 62705
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4F2 RID: 62706
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKShareResultDelegate__DelegateSignature";

		// Token: 0x0400F4F3 RID: 62707
		private static int RegisterId;

		// Token: 0x02003291 RID: 12945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FSDKShareResultDelegate_DelegateParams
		{
			// Token: 0x0401711C RID: 94492
			[FieldOffset(0)]
			public int code;

			// Token: 0x0401711D RID: 94493
			[FieldOffset(8)]
			public FString platform;

			// Token: 0x0401711E RID: 94494
			[FieldOffset(24)]
			public FString msg;
		}

		// Token: 0x02003292 RID: 12946
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401711F RID: 94495
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
