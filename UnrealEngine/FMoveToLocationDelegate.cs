using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013AA RID: 5034
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMoveToLocationDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06012796 RID: 75670 RVA: 0x001B28D2 File Offset: 0x001B0AD2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMoveToLocationDelegate.StaticFunctionPtr();
		}

		// Token: 0x06012797 RID: 75671 RVA: 0x001B28DE File Offset: 0x001B0ADE
		private static IntPtr StaticFunctionPtr()
		{
			if (FMoveToLocationDelegate._FunctionPtr == IntPtr.Zero)
			{
				FMoveToLocationDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.MoveToLocationDelegate__DelegateSignature");
			}
			return FMoveToLocationDelegate._FunctionPtr;
		}

		// Token: 0x06012798 RID: 75672 RVA: 0x001B2901 File Offset: 0x001B0B01
		public FMoveToLocationDelegate()
		{
		}

		// Token: 0x06012799 RID: 75673 RVA: 0x001B2909 File Offset: 0x001B0B09
		[NullableContext(2)]
		public FMoveToLocationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601279A RID: 75674 RVA: 0x001B2913 File Offset: 0x001B0B13
		public FMoveToLocationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601279B RID: 75675 RVA: 0x001B291E File Offset: 0x001B0B1E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601279C RID: 75676 RVA: 0x001B2950 File Offset: 0x001B0B50
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FMoveToLocationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMoveToLocationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMoveToLocationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMoveToLocationDelegate.OnScriptCallback));
				}
				FMoveToLocationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMoveToLocationDelegate.RegisterId);
		}

		// Token: 0x0601279D RID: 75677 RVA: 0x001B298A File Offset: 0x001B0B8A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601279E RID: 75678 RVA: 0x001B2993 File Offset: 0x001B0B93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601279F RID: 75679 RVA: 0x001B29A0 File Offset: 0x001B0BA0
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

		// Token: 0x04009E33 RID: 40499
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E34 RID: 40500
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.MoveToLocationDelegate__DelegateSignature";

		// Token: 0x04009E35 RID: 40501
		private static int RegisterId;

		// Token: 0x02002E4B RID: 11851
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016905 RID: 92421
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
