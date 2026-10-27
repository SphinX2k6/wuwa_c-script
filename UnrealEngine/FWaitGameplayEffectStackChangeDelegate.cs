using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013C3 RID: 5059
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitGameplayEffectStackChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060128A1 RID: 75937 RVA: 0x001B4544 File Offset: 0x001B2744
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitGameplayEffectStackChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x060128A2 RID: 75938 RVA: 0x001B4550 File Offset: 0x001B2750
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitGameplayEffectStackChangeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitGameplayEffectStackChangeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitGameplayEffectStackChangeDelegate__DelegateSignature");
			}
			return FWaitGameplayEffectStackChangeDelegate._FunctionPtr;
		}

		// Token: 0x060128A3 RID: 75939 RVA: 0x001B4573 File Offset: 0x001B2773
		public FWaitGameplayEffectStackChangeDelegate()
		{
		}

		// Token: 0x060128A4 RID: 75940 RVA: 0x001B457B File Offset: 0x001B277B
		[NullableContext(2)]
		public FWaitGameplayEffectStackChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128A5 RID: 75941 RVA: 0x001B4585 File Offset: 0x001B2785
		public FWaitGameplayEffectStackChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128A6 RID: 75942 RVA: 0x001B4590 File Offset: 0x001B2790
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FActiveGameplayEffectHandle, int, int, bool>) ?? ((Action<FActiveGameplayEffectHandle, int, int, bool>)Delegate.CreateDelegate(typeof(Action<FActiveGameplayEffectHandle, int, int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060128A7 RID: 75943 RVA: 0x001B45C2 File Offset: 0x001B27C2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FActiveGameplayEffectHandle, int, int, bool> Callback)
		{
			if (FWaitGameplayEffectStackChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitGameplayEffectStackChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitGameplayEffectStackChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitGameplayEffectStackChangeDelegate.OnScriptCallback));
				}
				FWaitGameplayEffectStackChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitGameplayEffectStackChangeDelegate.RegisterId);
		}

		// Token: 0x060128A8 RID: 75944 RVA: 0x001B45FC File Offset: 0x001B27FC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FActiveGameplayEffectHandle, int, int, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060128A9 RID: 75945 RVA: 0x001B4608 File Offset: 0x001B2808
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FActiveGameplayEffectHandle Handle, int NewCount, int OldCount, bool bPremature)
		{
			FWaitGameplayEffectStackChangeDelegate.__FWaitGameplayEffectStackChangeDelegate_DelegateParams* ptr = stackalloc FWaitGameplayEffectStackChangeDelegate.__FWaitGameplayEffectStackChangeDelegate_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FWaitGameplayEffectStackChangeDelegate.__FWaitGameplayEffectStackChangeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitGameplayEffectStackChangeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (Handle != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), &ptr->Handle, Handle.NativePtr, 1, false);
			}
			ptr->NewCount = NewCount;
			ptr->OldCount = OldCount;
			ptr->bPremature = bPremature;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060128AA RID: 75946 RVA: 0x001B4678 File Offset: 0x001B2878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FActiveGameplayEffectHandle, int, int, bool> action = target as Action<FActiveGameplayEffectHandle, int, int, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FActiveGameplayEffectHandle arg = new FActiveGameplayEffectHandle(&((FWaitGameplayEffectStackChangeDelegate.__FWaitGameplayEffectStackChangeDelegate_DelegateParams*)__Parameters)->Handle, true, true);
			action(arg, ((FWaitGameplayEffectStackChangeDelegate.__FWaitGameplayEffectStackChangeDelegate_DelegateParams*)__Parameters)->NewCount, ((FWaitGameplayEffectStackChangeDelegate.__FWaitGameplayEffectStackChangeDelegate_DelegateParams*)__Parameters)->OldCount, ((FWaitGameplayEffectStackChangeDelegate.__FWaitGameplayEffectStackChangeDelegate_DelegateParams*)__Parameters)->bPremature);
		}

		// Token: 0x04009E94 RID: 40596
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E95 RID: 40597
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitGameplayEffectStackChangeDelegate__DelegateSignature";

		// Token: 0x04009E96 RID: 40598
		private static int RegisterId;

		// Token: 0x02002E62 RID: 11874
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __FWaitGameplayEffectStackChangeDelegate_DelegateParams
		{
			// Token: 0x04016920 RID: 92448
			[FieldOffset(0)]
			public byte Handle;

			// Token: 0x04016921 RID: 92449
			[FieldOffset(8)]
			public int NewCount;

			// Token: 0x04016922 RID: 92450
			[FieldOffset(12)]
			public int OldCount;

			// Token: 0x04016923 RID: 92451
			[FieldOffset(16)]
			public bool bPremature;
		}

		// Token: 0x02002E63 RID: 11875
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016924 RID: 92452
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
