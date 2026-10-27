using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018BA RID: 6330
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroActorStreamingCompleted : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017664 RID: 95844 RVA: 0x00223728 File Offset: 0x00221928
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroActorStreamingCompleted.StaticFunctionPtr();
		}

		// Token: 0x06017665 RID: 95845 RVA: 0x00223734 File Offset: 0x00221934
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroActorStreamingCompleted._FunctionPtr == IntPtr.Zero)
			{
				FKuroActorStreamingCompleted._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroActorStreamingCompleted__DelegateSignature");
			}
			return FKuroActorStreamingCompleted._FunctionPtr;
		}

		// Token: 0x06017666 RID: 95846 RVA: 0x00223757 File Offset: 0x00221957
		public FKuroActorStreamingCompleted()
		{
		}

		// Token: 0x06017667 RID: 95847 RVA: 0x0022375F File Offset: 0x0022195F
		[NullableContext(2)]
		public FKuroActorStreamingCompleted(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017668 RID: 95848 RVA: 0x00223769 File Offset: 0x00221969
		public FKuroActorStreamingCompleted(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017669 RID: 95849 RVA: 0x00223774 File Offset: 0x00221974
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601766A RID: 95850 RVA: 0x002237A6 File Offset: 0x002219A6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FKuroActorStreamingCompleted.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroActorStreamingCompleted.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroActorStreamingCompleted.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroActorStreamingCompleted.OnScriptCallback));
				}
				FKuroActorStreamingCompleted.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroActorStreamingCompleted.RegisterId);
		}

		// Token: 0x0601766B RID: 95851 RVA: 0x002237E0 File Offset: 0x002219E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601766C RID: 95852 RVA: 0x002237E9 File Offset: 0x002219E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601766D RID: 95853 RVA: 0x002237F4 File Offset: 0x002219F4
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

		// Token: 0x0400CBA9 RID: 52137
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CBAA RID: 52138
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroActorStreamingCompleted__DelegateSignature";

		// Token: 0x0400CBAB RID: 52139
		private static int RegisterId;

		// Token: 0x02002FAF RID: 12207
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B92 RID: 93074
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
