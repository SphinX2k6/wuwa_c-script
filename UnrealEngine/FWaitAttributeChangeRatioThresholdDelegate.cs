using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013BD RID: 5053
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitAttributeChangeRatioThresholdDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012865 RID: 75877 RVA: 0x001B3DE6 File Offset: 0x001B1FE6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitAttributeChangeRatioThresholdDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012866 RID: 75878 RVA: 0x001B3DF2 File Offset: 0x001B1FF2
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitAttributeChangeRatioThresholdDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitAttributeChangeRatioThresholdDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitAttributeChangeRatioThresholdDelegate__DelegateSignature");
			}
			return FWaitAttributeChangeRatioThresholdDelegate._FunctionPtr;
		}

		// Token: 0x06012867 RID: 75879 RVA: 0x001B3E15 File Offset: 0x001B2015
		public FWaitAttributeChangeRatioThresholdDelegate()
		{
		}

		// Token: 0x06012868 RID: 75880 RVA: 0x001B3E1D File Offset: 0x001B201D
		[NullableContext(2)]
		public FWaitAttributeChangeRatioThresholdDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012869 RID: 75881 RVA: 0x001B3E27 File Offset: 0x001B2027
		public FWaitAttributeChangeRatioThresholdDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601286A RID: 75882 RVA: 0x001B3E32 File Offset: 0x001B2032
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, float>) ?? ((Action<bool, float>)Delegate.CreateDelegate(typeof(Action<bool, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601286B RID: 75883 RVA: 0x001B3E64 File Offset: 0x001B2064
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, float> Callback)
		{
			if (FWaitAttributeChangeRatioThresholdDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitAttributeChangeRatioThresholdDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitAttributeChangeRatioThresholdDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitAttributeChangeRatioThresholdDelegate.OnScriptCallback));
				}
				FWaitAttributeChangeRatioThresholdDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitAttributeChangeRatioThresholdDelegate.RegisterId);
		}

		// Token: 0x0601286C RID: 75884 RVA: 0x001B3E9E File Offset: 0x001B209E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601286D RID: 75885 RVA: 0x001B3EA8 File Offset: 0x001B20A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bMatchesComparison, float CurrentRatio)
		{
			FWaitAttributeChangeRatioThresholdDelegate.__FWaitAttributeChangeRatioThresholdDelegate_DelegateParams* ptr = stackalloc FWaitAttributeChangeRatioThresholdDelegate.__FWaitAttributeChangeRatioThresholdDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FWaitAttributeChangeRatioThresholdDelegate.__FWaitAttributeChangeRatioThresholdDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitAttributeChangeRatioThresholdDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bMatchesComparison = bMatchesComparison;
			ptr->CurrentRatio = CurrentRatio;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601286E RID: 75886 RVA: 0x001B3EEC File Offset: 0x001B20EC
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
			action(((FWaitAttributeChangeRatioThresholdDelegate.__FWaitAttributeChangeRatioThresholdDelegate_DelegateParams*)__Parameters)->bMatchesComparison, ((FWaitAttributeChangeRatioThresholdDelegate.__FWaitAttributeChangeRatioThresholdDelegate_DelegateParams*)__Parameters)->CurrentRatio);
		}

		// Token: 0x04009E82 RID: 40578
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E83 RID: 40579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitAttributeChangeRatioThresholdDelegate__DelegateSignature";

		// Token: 0x04009E84 RID: 40580
		private static int RegisterId;

		// Token: 0x02002E59 RID: 11865
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FWaitAttributeChangeRatioThresholdDelegate_DelegateParams
		{
			// Token: 0x04016915 RID: 92437
			[FieldOffset(0)]
			public bool bMatchesComparison;

			// Token: 0x04016916 RID: 92438
			[FieldOffset(4)]
			public float CurrentRatio;
		}

		// Token: 0x02002E5A RID: 11866
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016917 RID: 92439
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
