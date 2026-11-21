using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000547 RID: 1351
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKRequestPermissionResultDelagate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007CED RID: 31981 RVA: 0x000B953E File Offset: 0x000B773E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKRequestPermissionResultDelagate.StaticFunctionPtr();
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x000B954A File Offset: 0x000B774A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKRequestPermissionResultDelagate._FunctionPtr == IntPtr.Zero)
			{
				FSDKRequestPermissionResultDelagate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKRequestPermissionResultDelagate__DelegateSignature");
			}
			return FSDKRequestPermissionResultDelagate._FunctionPtr;
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x000B956D File Offset: 0x000B776D
		public FSDKRequestPermissionResultDelagate()
		{
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x000B9575 File Offset: 0x000B7775
		[NullableContext(2)]
		public FSDKRequestPermissionResultDelagate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x000B957F File Offset: 0x000B777F
		public FSDKRequestPermissionResultDelagate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x000B958A File Offset: 0x000B778A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x000B95BC File Offset: 0x000B77BC
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FSDKRequestPermissionResultDelagate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKRequestPermissionResultDelagate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKRequestPermissionResultDelagate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKRequestPermissionResultDelagate.OnScriptCallback));
				}
				FSDKRequestPermissionResultDelagate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKRequestPermissionResultDelagate.RegisterId);
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x000B95F6 File Offset: 0x000B77F6
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x000B9600 File Offset: 0x000B7800
		[SkipLocalsInit]
		public unsafe void Broadcast(bool result)
		{
			FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams* ptr = stackalloc FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKRequestPermissionResultDelagate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->result = result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x000B963C File Offset: 0x000B783C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSDKRequestPermissionResultDelagate.__FSDKRequestPermissionResultDelagate_DelegateParams*)__Parameters)->result);
		}

		// Token: 0x04003555 RID: 13653
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003556 RID: 13654
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKRequestPermissionResultDelagate__DelegateSignature";

		// Token: 0x04003557 RID: 13655
		private static int RegisterId;

		// Token: 0x02000D02 RID: 3330
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FSDKRequestPermissionResultDelagate_DelegateParams
		{
			// Token: 0x04005F8C RID: 24460
			[FieldOffset(0)]
			public bool result;
		}

		// Token: 0x02000D03 RID: 3331
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F8D RID: 24461
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
