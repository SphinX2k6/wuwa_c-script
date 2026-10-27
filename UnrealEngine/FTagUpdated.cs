using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013B7 RID: 5047
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTagUpdated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012832 RID: 75826 RVA: 0x001B37A1 File Offset: 0x001B19A1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTagUpdated.StaticFunctionPtr();
		}

		// Token: 0x06012833 RID: 75827 RVA: 0x001B37AD File Offset: 0x001B19AD
		private static IntPtr StaticFunctionPtr()
		{
			if (FTagUpdated._FunctionPtr == IntPtr.Zero)
			{
				FTagUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.TagUpdated__DelegateSignature");
			}
			return FTagUpdated._FunctionPtr;
		}

		// Token: 0x06012834 RID: 75828 RVA: 0x001B37D0 File Offset: 0x001B19D0
		public FTagUpdated()
		{
		}

		// Token: 0x06012835 RID: 75829 RVA: 0x001B37D8 File Offset: 0x001B19D8
		[NullableContext(2)]
		public FTagUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012836 RID: 75830 RVA: 0x001B37E2 File Offset: 0x001B19E2
		public FTagUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012837 RID: 75831 RVA: 0x001B37ED File Offset: 0x001B19ED
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayTag, bool, int>) ?? ((Action<FGameplayTag, bool, int>)Delegate.CreateDelegate(typeof(Action<FGameplayTag, bool, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012838 RID: 75832 RVA: 0x001B381F File Offset: 0x001B1A1F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayTag, bool, int> Callback)
		{
			if (FTagUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTagUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTagUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTagUpdated.OnScriptCallback));
				}
				FTagUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTagUpdated.RegisterId);
		}

		// Token: 0x06012839 RID: 75833 RVA: 0x001B3859 File Offset: 0x001B1A59
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayTag, bool, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601283A RID: 75834 RVA: 0x001B3864 File Offset: 0x001B1A64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FGameplayTag Tag, bool TagExists, int CountDelta)
		{
			FTagUpdated.__FTagUpdated_DelegateParams* ptr = stackalloc FTagUpdated.__FTagUpdated_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FTagUpdated.__FTagUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTagUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Tag = Tag;
			ptr->TagExists = TagExists;
			ptr->CountDelta = CountDelta;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601283B RID: 75835 RVA: 0x001B38B4 File Offset: 0x001B1AB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayTag, bool, int> action = target as Action<FGameplayTag, bool, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTagUpdated.__FTagUpdated_DelegateParams*)__Parameters)->Tag, ((FTagUpdated.__FTagUpdated_DelegateParams*)__Parameters)->TagExists, ((FTagUpdated.__FTagUpdated_DelegateParams*)__Parameters)->CountDelta);
		}

		// Token: 0x04009E72 RID: 40562
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E73 RID: 40563
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.TagUpdated__DelegateSignature";

		// Token: 0x04009E74 RID: 40564
		private static int RegisterId;

		// Token: 0x02002E51 RID: 11857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __FTagUpdated_DelegateParams
		{
			// Token: 0x0401690B RID: 92427
			[FieldOffset(0)]
			public FGameplayTag Tag;

			// Token: 0x0401690C RID: 92428
			[FieldOffset(12)]
			public bool TagExists;

			// Token: 0x0401690D RID: 92429
			[FieldOffset(16)]
			public int CountDelta;
		}

		// Token: 0x02002E52 RID: 11858
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401690E RID: 92430
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
