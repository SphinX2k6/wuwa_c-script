using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028D RID: 653
	public sealed class FOnEventCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024A2 RID: 9378 RVA: 0x000365A6 File Offset: 0x000347A6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEventCallback.StaticFunctionPtr();
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000365B2 File Offset: 0x000347B2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnEventCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnEventCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnEventCallback__DelegateSignature");
			}
			return FOnEventCallback._FunctionPtr;
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x000365D5 File Offset: 0x000347D5
		public FOnEventCallback()
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x000365DD File Offset: 0x000347DD
		[NullableContext(2)]
		public FOnEventCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x000365E7 File Offset: 0x000347E7
		public FOnEventCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x000365F2 File Offset: 0x000347F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FAkWaapiSubscriptionId, FAKWaapiJsonObject>) ?? ((Action<FAkWaapiSubscriptionId, FAKWaapiJsonObject>)Delegate.CreateDelegate(typeof(Action<FAkWaapiSubscriptionId, FAKWaapiJsonObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00036624 File Offset: 0x00034824
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FAkWaapiSubscriptionId, FAKWaapiJsonObject> Callback)
		{
			if (FOnEventCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEventCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEventCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEventCallback.OnScriptCallback));
				}
				FOnEventCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnEventCallback.RegisterId);
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00036660 File Offset: 0x00034860
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FAkWaapiSubscriptionId SubscriptionId, FAKWaapiJsonObject WaapiJsonObject)
		{
			FOnEventCallback.__FOnEventCallback_DelegateParams* ptr = stackalloc FOnEventCallback.__FOnEventCallback_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnEventCallback.__FOnEventCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnEventCallback.StaticFunctionPtr(), (void*)ptr, 1);
			if (SubscriptionId != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkWaapiSubscriptionId.StaticStruct(), &ptr->SubscriptionId, SubscriptionId.NativePtr, 1, false);
			}
			if (WaapiJsonObject != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAKWaapiJsonObject.StaticStruct(), &ptr->WaapiJsonObject, WaapiJsonObject.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnEventCallback._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000366EC File Offset: 0x000348EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FAkWaapiSubscriptionId, FAKWaapiJsonObject> action = target as Action<FAkWaapiSubscriptionId, FAKWaapiJsonObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FAkWaapiSubscriptionId arg = new FAkWaapiSubscriptionId(&((FOnEventCallback.__FOnEventCallback_DelegateParams*)__Parameters)->SubscriptionId, true, true);
			FAKWaapiJsonObject arg2 = new FAKWaapiJsonObject(&((FOnEventCallback.__FOnEventCallback_DelegateParams*)__Parameters)->WaapiJsonObject, true, true);
			action(arg, arg2);
		}

		// Token: 0x04000DF1 RID: 3569
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000DF2 RID: 3570
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnEventCallback__DelegateSignature";

		// Token: 0x04000DF3 RID: 3571
		private static int RegisterId;

		// Token: 0x02002B8F RID: 11151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnEventCallback_DelegateParams
		{
			// Token: 0x04016423 RID: 91171
			[FieldOffset(0)]
			public byte SubscriptionId;

			// Token: 0x04016424 RID: 91172
			[FieldOffset(8)]
			public byte WaapiJsonObject;
		}

		// Token: 0x02002B90 RID: 11152
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016425 RID: 91173
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
