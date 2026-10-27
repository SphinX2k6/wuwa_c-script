using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013C4 RID: 5060
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitGameplayTagDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060128AB RID: 75947 RVA: 0x001B46DE File Offset: 0x001B28DE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitGameplayTagDelegate.StaticFunctionPtr();
		}

		// Token: 0x060128AC RID: 75948 RVA: 0x001B46EA File Offset: 0x001B28EA
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitGameplayTagDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitGameplayTagDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitGameplayTagDelegate__DelegateSignature");
			}
			return FWaitGameplayTagDelegate._FunctionPtr;
		}

		// Token: 0x060128AD RID: 75949 RVA: 0x001B470D File Offset: 0x001B290D
		public FWaitGameplayTagDelegate()
		{
		}

		// Token: 0x060128AE RID: 75950 RVA: 0x001B4715 File Offset: 0x001B2915
		[NullableContext(2)]
		public FWaitGameplayTagDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060128AF RID: 75951 RVA: 0x001B471F File Offset: 0x001B291F
		public FWaitGameplayTagDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060128B0 RID: 75952 RVA: 0x001B472A File Offset: 0x001B292A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayTag>) ?? ((Action<FGameplayTag>)Delegate.CreateDelegate(typeof(Action<FGameplayTag>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060128B1 RID: 75953 RVA: 0x001B475C File Offset: 0x001B295C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayTag> Callback)
		{
			if (FWaitGameplayTagDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitGameplayTagDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitGameplayTagDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitGameplayTagDelegate.OnScriptCallback));
				}
				FWaitGameplayTagDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitGameplayTagDelegate.RegisterId);
		}

		// Token: 0x060128B2 RID: 75954 RVA: 0x001B4796 File Offset: 0x001B2996
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayTag> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060128B3 RID: 75955 RVA: 0x001B47A0 File Offset: 0x001B29A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FGameplayTag Tag)
		{
			FWaitGameplayTagDelegate.__FWaitGameplayTagDelegate_DelegateParams* ptr = stackalloc FWaitGameplayTagDelegate.__FWaitGameplayTagDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FWaitGameplayTagDelegate.__FWaitGameplayTagDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWaitGameplayTagDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Tag = Tag;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060128B4 RID: 75956 RVA: 0x001B47E4 File Offset: 0x001B29E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayTag> action = target as Action<FGameplayTag>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FWaitGameplayTagDelegate.__FWaitGameplayTagDelegate_DelegateParams*)__Parameters)->Tag);
		}

		// Token: 0x04009E97 RID: 40599
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E98 RID: 40600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitGameplayTagDelegate__DelegateSignature";

		// Token: 0x04009E99 RID: 40601
		private static int RegisterId;

		// Token: 0x02002E64 RID: 11876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FWaitGameplayTagDelegate_DelegateParams
		{
			// Token: 0x04016925 RID: 92453
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x02002E65 RID: 11877
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016926 RID: 92454
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
