using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004F2 RID: 1266
	public sealed class FOnForbidWeatherStateChangedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600772D RID: 30509 RVA: 0x000AE28E File Offset: 0x000AC48E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnForbidWeatherStateChangedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x000AE29A File Offset: 0x000AC49A
		private static IntPtr StaticFunctionPtr()
		{
			if (AKuroGlobalGI.__OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKuroGlobalGI.__OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnForbidWeatherStateChangedDelegate__DelegateSignature");
			}
			return AKuroGlobalGI.__OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x000AE2BD File Offset: 0x000AC4BD
		public FOnForbidWeatherStateChangedDelegate()
		{
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x000AE2C5 File Offset: 0x000AC4C5
		[NullableContext(2)]
		public FOnForbidWeatherStateChangedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x000AE2CF File Offset: 0x000AC4CF
		public FOnForbidWeatherStateChangedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x000AE2DA File Offset: 0x000AC4DA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x000AE30C File Offset: 0x000AC50C
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnForbidWeatherStateChangedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnForbidWeatherStateChangedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnForbidWeatherStateChangedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnForbidWeatherStateChangedDelegate.OnScriptCallback));
				}
				FOnForbidWeatherStateChangedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnForbidWeatherStateChangedDelegate.RegisterId);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x000AE348 File Offset: 0x000AC548
		[SkipLocalsInit]
		public unsafe void Execute(bool InForbidWeather)
		{
			FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams* ptr = stackalloc FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnForbidWeatherStateChangedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InForbidWeather = InForbidWeather;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x000AE388 File Offset: 0x000AC588
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams*)__Parameters)->InForbidWeather);
		}

		// Token: 0x0400323E RID: 12862
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnForbidWeatherStateChangedDelegate__DelegateSignature";

		// Token: 0x0400323F RID: 12863
		private static int RegisterId;

		// Token: 0x02000C32 RID: 3122
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnForbidWeatherStateChangedDelegate_DelegateParams
		{
			// Token: 0x04005E7F RID: 24191
			[FieldOffset(0)]
			public bool InForbidWeather;
		}

		// Token: 0x02000C33 RID: 3123
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E80 RID: 24192
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
