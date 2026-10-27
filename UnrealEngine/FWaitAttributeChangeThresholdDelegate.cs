using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013BE RID: 5054
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitAttributeChangeThresholdDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601286F RID: 75887 RVA: 0x001B3F3C File Offset: 0x001B213C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitAttributeChangeThresholdDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012870 RID: 75888 RVA: 0x001B3F48 File Offset: 0x001B2148
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitAttributeChangeThresholdDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitAttributeChangeThresholdDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitAttributeChangeThresholdDelegate__DelegateSignature");
			}
			return FWaitAttributeChangeThresholdDelegate._FunctionPtr;
		}

		// Token: 0x06012871 RID: 75889 RVA: 0x001B3F6B File Offset: 0x001B216B
		public FWaitAttributeChangeThresholdDelegate()
		{
		}

		// Token: 0x06012872 RID: 75890 RVA: 0x001B3F73 File Offset: 0x001B2173
		[NullableContext(2)]
		public FWaitAttributeChangeThresholdDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012873 RID: 75891 RVA: 0x001B3F7D File Offset: 0x001B217D
		public FWaitAttributeChangeThresholdDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012874 RID: 75892 RVA: 0x001B3F88 File Offset: 0x001B2188
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, float>) ?? ((Action<bool, float>)Delegate.CreateDelegate(typeof(Action<bool, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012875 RID: 75893 RVA: 0x001B3FBA File Offset: 0x001B21BA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, float> Callback)
		{
			if (FWaitAttributeChangeThresholdDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitAttributeChangeThresholdDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitAttributeChangeThresholdDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitAttributeChangeThresholdDelegate.OnScriptCallback));
				}
				FWaitAttributeChangeThresholdDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitAttributeChangeThresholdDelegate.RegisterId);
		}

		// Token: 0x06012876 RID: 75894 RVA: 0x001B3FF4 File Offset: 0x001B21F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012877 RID: 75895 RVA: 0x001B4000 File Offset: 0x001B2200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bMatchesComparison, float CurrentValue)
		{
			FWaitAttributeChangeThresholdDelegate.__FWaitAttributeChangeThresholdDelegate_DelegateParams* ptr = stackalloc FWaitAttributeChangeThresholdDelegate.__FWaitAttributeChangeThresholdDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FWaitAttributeChangeThresholdDelegate.__FWaitAttributeChangeThresholdDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitAttributeChangeThresholdDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bMatchesComparison = bMatchesComparison;
			ptr->CurrentValue = CurrentValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012878 RID: 75896 RVA: 0x001B4044 File Offset: 0x001B2244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, float> action = target as Action<bool, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FWaitAttributeChangeThresholdDelegate.__FWaitAttributeChangeThresholdDelegate_DelegateParams*)__Parameters)->bMatchesComparison, ((FWaitAttributeChangeThresholdDelegate.__FWaitAttributeChangeThresholdDelegate_DelegateParams*)__Parameters)->CurrentValue);
		}

		// Token: 0x04009E85 RID: 40581
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E86 RID: 40582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitAttributeChangeThresholdDelegate__DelegateSignature";

		// Token: 0x04009E87 RID: 40583
		private static int RegisterId;

		// Token: 0x02002E5B RID: 11867
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FWaitAttributeChangeThresholdDelegate_DelegateParams
		{
			// Token: 0x04016918 RID: 92440
			[FieldOffset(0)]
			public bool bMatchesComparison;

			// Token: 0x04016919 RID: 92441
			[FieldOffset(4)]
			public float CurrentValue;
		}

		// Token: 0x02002E5C RID: 11868
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401691A RID: 92442
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
