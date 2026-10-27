using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013FA RID: 5114
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnClaimedResourcesChangeSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012ABC RID: 76476 RVA: 0x001B7C2A File Offset: 0x001B5E2A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnClaimedResourcesChangeSignature.StaticFunctionPtr();
		}

		// Token: 0x06012ABD RID: 76477 RVA: 0x001B7C36 File Offset: 0x001B5E36
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnClaimedResourcesChangeSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnClaimedResourcesChangeSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayTasks.OnClaimedResourcesChangeSignature__DelegateSignature");
			}
			return FOnClaimedResourcesChangeSignature._FunctionPtr;
		}

		// Token: 0x06012ABE RID: 76478 RVA: 0x001B7C59 File Offset: 0x001B5E59
		public FOnClaimedResourcesChangeSignature()
		{
		}

		// Token: 0x06012ABF RID: 76479 RVA: 0x001B7C61 File Offset: 0x001B5E61
		[NullableContext(2)]
		public FOnClaimedResourcesChangeSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012AC0 RID: 76480 RVA: 0x001B7C6B File Offset: 0x001B5E6B
		public FOnClaimedResourcesChangeSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012AC1 RID: 76481 RVA: 0x001B7C76 File Offset: 0x001B5E76
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayResourceSet, FGameplayResourceSet>) ?? ((Action<FGameplayResourceSet, FGameplayResourceSet>)Delegate.CreateDelegate(typeof(Action<FGameplayResourceSet, FGameplayResourceSet>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012AC2 RID: 76482 RVA: 0x001B7CA8 File Offset: 0x001B5EA8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayResourceSet, FGameplayResourceSet> Callback)
		{
			if (FOnClaimedResourcesChangeSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnClaimedResourcesChangeSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnClaimedResourcesChangeSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnClaimedResourcesChangeSignature.OnScriptCallback));
				}
				FOnClaimedResourcesChangeSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnClaimedResourcesChangeSignature.RegisterId);
		}

		// Token: 0x06012AC3 RID: 76483 RVA: 0x001B7CE2 File Offset: 0x001B5EE2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayResourceSet, FGameplayResourceSet> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012AC4 RID: 76484 RVA: 0x001B7CEC File Offset: 0x001B5EEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FGameplayResourceSet NewlyClaimed, FGameplayResourceSet FreshlyReleased)
		{
			FOnClaimedResourcesChangeSignature.__FOnClaimedResourcesChangeSignature_DelegateParams* ptr = stackalloc FOnClaimedResourcesChangeSignature.__FOnClaimedResourcesChangeSignature_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnClaimedResourcesChangeSignature.__FOnClaimedResourcesChangeSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnClaimedResourcesChangeSignature.StaticFunctionPtr(), (void*)ptr, 1);
			if (NewlyClaimed != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayResourceSet.StaticStruct(), &ptr->NewlyClaimed, NewlyClaimed.NativePtr, 1, false);
			}
			if (FreshlyReleased != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayResourceSet.StaticStruct(), &ptr->FreshlyReleased, FreshlyReleased.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06012AC5 RID: 76485 RVA: 0x001B7D68 File Offset: 0x001B5F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayResourceSet, FGameplayResourceSet> action = target as Action<FGameplayResourceSet, FGameplayResourceSet>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGameplayResourceSet arg = new FGameplayResourceSet(&((FOnClaimedResourcesChangeSignature.__FOnClaimedResourcesChangeSignature_DelegateParams*)__Parameters)->NewlyClaimed, true, true);
			FGameplayResourceSet arg2 = new FGameplayResourceSet(&((FOnClaimedResourcesChangeSignature.__FOnClaimedResourcesChangeSignature_DelegateParams*)__Parameters)->FreshlyReleased, true, true);
			action(arg, arg2);
		}

		// Token: 0x04009FAC RID: 40876
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009FAD RID: 40877
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.OnClaimedResourcesChangeSignature__DelegateSignature";

		// Token: 0x04009FAE RID: 40878
		private static int RegisterId;

		// Token: 0x02002E7B RID: 11899
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnClaimedResourcesChangeSignature_DelegateParams
		{
			// Token: 0x0401694E RID: 92494
			[FieldOffset(0)]
			public byte NewlyClaimed;

			// Token: 0x0401694F RID: 92495
			[FieldOffset(2)]
			public byte FreshlyReleased;
		}

		// Token: 0x02002E7C RID: 11900
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016950 RID: 92496
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
