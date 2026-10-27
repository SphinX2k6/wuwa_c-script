using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013B9 RID: 5049
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FVisualizeTargetingDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601283D RID: 75837 RVA: 0x001B390A File Offset: 0x001B1B0A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FVisualizeTargetingDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601283E RID: 75838 RVA: 0x001B3916 File Offset: 0x001B1B16
		private static IntPtr StaticFunctionPtr()
		{
			if (FVisualizeTargetingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FVisualizeTargetingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.VisualizeTargetingDelegate__DelegateSignature");
			}
			return FVisualizeTargetingDelegate._FunctionPtr;
		}

		// Token: 0x0601283F RID: 75839 RVA: 0x001B3939 File Offset: 0x001B1B39
		public FVisualizeTargetingDelegate()
		{
		}

		// Token: 0x06012840 RID: 75840 RVA: 0x001B3941 File Offset: 0x001B1B41
		[NullableContext(2)]
		public FVisualizeTargetingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012841 RID: 75841 RVA: 0x001B394B File Offset: 0x001B1B4B
		public FVisualizeTargetingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012842 RID: 75842 RVA: 0x001B3956 File Offset: 0x001B1B56
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012843 RID: 75843 RVA: 0x001B3988 File Offset: 0x001B1B88
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FVisualizeTargetingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FVisualizeTargetingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FVisualizeTargetingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FVisualizeTargetingDelegate.OnScriptCallback));
				}
				FVisualizeTargetingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FVisualizeTargetingDelegate.RegisterId);
		}

		// Token: 0x06012844 RID: 75844 RVA: 0x001B39C2 File Offset: 0x001B1BC2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012845 RID: 75845 RVA: 0x001B39CB File Offset: 0x001B1BCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06012846 RID: 75846 RVA: 0x001B39D8 File Offset: 0x001B1BD8
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

		// Token: 0x04009E76 RID: 40566
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E77 RID: 40567
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.VisualizeTargetingDelegate__DelegateSignature";

		// Token: 0x04009E78 RID: 40568
		private static int RegisterId;

		// Token: 0x02002E53 RID: 11859
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401690F RID: 92431
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
