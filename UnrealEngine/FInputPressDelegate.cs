using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013A3 RID: 5027
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FInputPressDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012750 RID: 75600 RVA: 0x001B2221 File Offset: 0x001B0421
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FInputPressDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012751 RID: 75601 RVA: 0x001B222D File Offset: 0x001B042D
		private static IntPtr StaticFunctionPtr()
		{
			if (FInputPressDelegate._FunctionPtr == IntPtr.Zero)
			{
				FInputPressDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.InputPressDelegate__DelegateSignature");
			}
			return FInputPressDelegate._FunctionPtr;
		}

		// Token: 0x06012752 RID: 75602 RVA: 0x001B2250 File Offset: 0x001B0450
		public FInputPressDelegate()
		{
		}

		// Token: 0x06012753 RID: 75603 RVA: 0x001B2258 File Offset: 0x001B0458
		[NullableContext(2)]
		public FInputPressDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012754 RID: 75604 RVA: 0x001B2262 File Offset: 0x001B0462
		public FInputPressDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012755 RID: 75605 RVA: 0x001B226D File Offset: 0x001B046D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012756 RID: 75606 RVA: 0x001B229F File Offset: 0x001B049F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FInputPressDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FInputPressDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FInputPressDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FInputPressDelegate.OnScriptCallback));
				}
				FInputPressDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FInputPressDelegate.RegisterId);
		}

		// Token: 0x06012757 RID: 75607 RVA: 0x001B22D9 File Offset: 0x001B04D9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012758 RID: 75608 RVA: 0x001B22E4 File Offset: 0x001B04E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float TimeWaited)
		{
			FInputPressDelegate.__FInputPressDelegate_DelegateParams* ptr = stackalloc FInputPressDelegate.__FInputPressDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FInputPressDelegate.__FInputPressDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FInputPressDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TimeWaited = TimeWaited;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012759 RID: 75609 RVA: 0x001B2320 File Offset: 0x001B0520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FInputPressDelegate.__FInputPressDelegate_DelegateParams*)__Parameters)->TimeWaited);
		}

		// Token: 0x04009E1E RID: 40478
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E1F RID: 40479
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.InputPressDelegate__DelegateSignature";

		// Token: 0x04009E20 RID: 40480
		private static int RegisterId;

		// Token: 0x02002E44 RID: 11844
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FInputPressDelegate_DelegateParams
		{
			// Token: 0x040168FE RID: 92414
			[FieldOffset(0)]
			public float TimeWaited;
		}

		// Token: 0x02002E45 RID: 11845
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168FF RID: 92415
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
