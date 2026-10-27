using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002016 RID: 8214
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FHoverEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EF4C RID: 126796 RVA: 0x002E0937 File Offset: 0x002DEB37
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHoverEvent.StaticFunctionPtr();
		}

		// Token: 0x0601EF4D RID: 126797 RVA: 0x002E0943 File Offset: 0x002DEB43
		private static IntPtr StaticFunctionPtr()
		{
			if (FHoverEvent._FunctionPtr == IntPtr.Zero)
			{
				FHoverEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.HoverEvent__DelegateSignature");
			}
			return FHoverEvent._FunctionPtr;
		}

		// Token: 0x0601EF4E RID: 126798 RVA: 0x002E0966 File Offset: 0x002DEB66
		public FHoverEvent()
		{
		}

		// Token: 0x0601EF4F RID: 126799 RVA: 0x002E096E File Offset: 0x002DEB6E
		[NullableContext(2)]
		public FHoverEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EF50 RID: 126800 RVA: 0x002E0978 File Offset: 0x002DEB78
		public FHoverEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EF51 RID: 126801 RVA: 0x002E0983 File Offset: 0x002DEB83
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EF52 RID: 126802 RVA: 0x002E09B5 File Offset: 0x002DEBB5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FHoverEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FHoverEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FHoverEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FHoverEvent.OnScriptCallback));
				}
				FHoverEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FHoverEvent.RegisterId);
		}

		// Token: 0x0601EF53 RID: 126803 RVA: 0x002E09EF File Offset: 0x002DEBEF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601EF54 RID: 126804 RVA: 0x002E09F8 File Offset: 0x002DEBF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601EF55 RID: 126805 RVA: 0x002E0A04 File Offset: 0x002DEC04
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

		// Token: 0x04010D4A RID: 68938
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010D4B RID: 68939
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.HoverEvent__DelegateSignature";

		// Token: 0x04010D4C RID: 68940
		private static int RegisterId;

		// Token: 0x02003427 RID: 13351
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017403 RID: 95235
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
