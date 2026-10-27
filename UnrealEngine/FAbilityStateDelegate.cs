using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012EA RID: 4842
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAbilityStateDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06011BEF RID: 72687 RVA: 0x001A0BC3 File Offset: 0x0019EDC3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAbilityStateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06011BF0 RID: 72688 RVA: 0x001A0BCF File Offset: 0x0019EDCF
		private static IntPtr StaticFunctionPtr()
		{
			if (FAbilityStateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAbilityStateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.AbilityStateDelegate__DelegateSignature");
			}
			return FAbilityStateDelegate._FunctionPtr;
		}

		// Token: 0x06011BF1 RID: 72689 RVA: 0x001A0BF2 File Offset: 0x0019EDF2
		public FAbilityStateDelegate()
		{
		}

		// Token: 0x06011BF2 RID: 72690 RVA: 0x001A0BFA File Offset: 0x0019EDFA
		[NullableContext(2)]
		public FAbilityStateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011BF3 RID: 72691 RVA: 0x001A0C04 File Offset: 0x0019EE04
		public FAbilityStateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011BF4 RID: 72692 RVA: 0x001A0C0F File Offset: 0x0019EE0F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06011BF5 RID: 72693 RVA: 0x001A0C41 File Offset: 0x0019EE41
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FAbilityStateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAbilityStateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAbilityStateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAbilityStateDelegate.OnScriptCallback));
				}
				FAbilityStateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAbilityStateDelegate.RegisterId);
		}

		// Token: 0x06011BF6 RID: 72694 RVA: 0x001A0C7B File Offset: 0x0019EE7B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06011BF7 RID: 72695 RVA: 0x001A0C84 File Offset: 0x0019EE84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06011BF8 RID: 72696 RVA: 0x001A0C90 File Offset: 0x0019EE90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04009861 RID: 39009
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009862 RID: 39010
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.AbilityStateDelegate__DelegateSignature";

		// Token: 0x04009863 RID: 39011
		private static int RegisterId;

		// Token: 0x02002E20 RID: 11808
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040168B5 RID: 92341
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
