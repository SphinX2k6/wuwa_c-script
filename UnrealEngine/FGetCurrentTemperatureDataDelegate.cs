using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A1B RID: 6683
	public sealed class FGetCurrentTemperatureDataDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018BA0 RID: 101280 RVA: 0x00247DBA File Offset: 0x00245FBA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetCurrentTemperatureDataDelegate.StaticFunctionPtr();
		}

		// Token: 0x06018BA1 RID: 101281 RVA: 0x00247DC6 File Offset: 0x00245FC6
		private static IntPtr StaticFunctionPtr()
		{
			if (FGetCurrentTemperatureDataDelegate._FunctionPtr == IntPtr.Zero)
			{
				FGetCurrentTemperatureDataDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroPerformance.GetCurrentTemperatureDataDelegate__DelegateSignature");
			}
			return FGetCurrentTemperatureDataDelegate._FunctionPtr;
		}

		// Token: 0x06018BA2 RID: 101282 RVA: 0x00247DE9 File Offset: 0x00245FE9
		public FGetCurrentTemperatureDataDelegate()
		{
		}

		// Token: 0x06018BA3 RID: 101283 RVA: 0x00247DF1 File Offset: 0x00245FF1
		[NullableContext(2)]
		public FGetCurrentTemperatureDataDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018BA4 RID: 101284 RVA: 0x00247DFB File Offset: 0x00245FFB
		public FGetCurrentTemperatureDataDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018BA5 RID: 101285 RVA: 0x00247E06 File Offset: 0x00246006
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, float, float>) ?? ((Action<bool, float, float>)Delegate.CreateDelegate(typeof(Action<bool, float, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018BA6 RID: 101286 RVA: 0x00247E38 File Offset: 0x00246038
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool, float, float> Callback)
		{
			if (FGetCurrentTemperatureDataDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetCurrentTemperatureDataDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetCurrentTemperatureDataDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetCurrentTemperatureDataDelegate.OnScriptCallback));
				}
				FGetCurrentTemperatureDataDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGetCurrentTemperatureDataDelegate.RegisterId);
		}

		// Token: 0x06018BA7 RID: 101287 RVA: 0x00247E74 File Offset: 0x00246074
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool bResult, float CurrentTemperature, float TempBudget)
		{
			FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams* ptr = stackalloc FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetCurrentTemperatureDataDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bResult = bResult;
			ptr->CurrentTemperature = CurrentTemperature;
			ptr->TempBudget = TempBudget;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06018BA8 RID: 101288 RVA: 0x00247EC0 File Offset: 0x002460C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, float, float> action = target as Action<bool, float, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams*)__Parameters)->bResult, ((FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams*)__Parameters)->CurrentTemperature, ((FGetCurrentTemperatureDataDelegate.__FGetCurrentTemperatureDataDelegate_DelegateParams*)__Parameters)->TempBudget);
		}

		// Token: 0x0400D5C6 RID: 54726
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D5C7 RID: 54727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPerformance.GetCurrentTemperatureDataDelegate__DelegateSignature";

		// Token: 0x0400D5C8 RID: 54728
		private static int RegisterId;

		// Token: 0x020030CD RID: 12493
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FGetCurrentTemperatureDataDelegate_DelegateParams
		{
			// Token: 0x04016E2C RID: 93740
			[FieldOffset(0)]
			public bool bResult;

			// Token: 0x04016E2D RID: 93741
			[FieldOffset(4)]
			public float CurrentTemperature;

			// Token: 0x04016E2E RID: 93742
			[FieldOffset(8)]
			public float TempBudget;
		}

		// Token: 0x020030CE RID: 12494
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016E2F RID: 93743
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
