using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C18 RID: 7192
	public sealed class FOnForbidWeatherStateChangedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BBDD RID: 113629 RVA: 0x0028D2B2 File Offset: 0x0028B4B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnForbidWeatherStateChangedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601BBDE RID: 113630 RVA: 0x0028D2BE File Offset: 0x0028B4BE
		private static IntPtr StaticFunctionPtr()
		{
			if (AKuroGlobalGI.__OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKuroGlobalGI.__OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnForbidWeatherStateChangedDelegate__DelegateSignature");
			}
			return AKuroGlobalGI.__OnForbidWeatherStateChangedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601BBDF RID: 113631 RVA: 0x0028D2E1 File Offset: 0x0028B4E1
		public FOnForbidWeatherStateChangedDelegate()
		{
		}

		// Token: 0x0601BBE0 RID: 113632 RVA: 0x0028D2E9 File Offset: 0x0028B4E9
		[NullableContext(2)]
		public FOnForbidWeatherStateChangedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBE1 RID: 113633 RVA: 0x0028D2F3 File Offset: 0x0028B4F3
		public FOnForbidWeatherStateChangedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBE2 RID: 113634 RVA: 0x0028D2FE File Offset: 0x0028B4FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BBE3 RID: 113635 RVA: 0x0028D330 File Offset: 0x0028B530
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601BBE4 RID: 113636 RVA: 0x0028D36C File Offset: 0x0028B56C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool InForbidWeather)
		{
			FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams* ptr = stackalloc FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnForbidWeatherStateChangedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InForbidWeather = InForbidWeather;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601BBE5 RID: 113637 RVA: 0x0028D3AC File Offset: 0x0028B5AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnForbidWeatherStateChangedDelegate.__FOnForbidWeatherStateChangedDelegate_DelegateParams*)__Parameters)->InForbidWeather);
		}

		// Token: 0x0400EE99 RID: 61081
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalGI:OnForbidWeatherStateChangedDelegate__DelegateSignature";

		// Token: 0x0400EE9A RID: 61082
		private static int RegisterId;

		// Token: 0x0200319C RID: 12700
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnForbidWeatherStateChangedDelegate_DelegateParams
		{
			// Token: 0x04016FDA RID: 94170
			[FieldOffset(0)]
			public bool InForbidWeather;
		}

		// Token: 0x0200319D RID: 12701
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FDB RID: 94171
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
