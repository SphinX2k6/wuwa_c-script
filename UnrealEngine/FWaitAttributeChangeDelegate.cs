using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013BC RID: 5052
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FWaitAttributeChangeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601285B RID: 75867 RVA: 0x001B3CD9 File Offset: 0x001B1ED9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWaitAttributeChangeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601285C RID: 75868 RVA: 0x001B3CE5 File Offset: 0x001B1EE5
		private static IntPtr StaticFunctionPtr()
		{
			if (FWaitAttributeChangeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FWaitAttributeChangeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.WaitAttributeChangeDelegate__DelegateSignature");
			}
			return FWaitAttributeChangeDelegate._FunctionPtr;
		}

		// Token: 0x0601285D RID: 75869 RVA: 0x001B3D08 File Offset: 0x001B1F08
		public FWaitAttributeChangeDelegate()
		{
		}

		// Token: 0x0601285E RID: 75870 RVA: 0x001B3D10 File Offset: 0x001B1F10
		[NullableContext(2)]
		public FWaitAttributeChangeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601285F RID: 75871 RVA: 0x001B3D1A File Offset: 0x001B1F1A
		public FWaitAttributeChangeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012860 RID: 75872 RVA: 0x001B3D25 File Offset: 0x001B1F25
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06012861 RID: 75873 RVA: 0x001B3D57 File Offset: 0x001B1F57
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FWaitAttributeChangeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWaitAttributeChangeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWaitAttributeChangeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWaitAttributeChangeDelegate.OnScriptCallback));
				}
				FWaitAttributeChangeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FWaitAttributeChangeDelegate.RegisterId);
		}

		// Token: 0x06012862 RID: 75874 RVA: 0x001B3D91 File Offset: 0x001B1F91
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06012863 RID: 75875 RVA: 0x001B3D9A File Offset: 0x001B1F9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06012864 RID: 75876 RVA: 0x001B3DA4 File Offset: 0x001B1FA4
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

		// Token: 0x04009E7F RID: 40575
		internal static IntPtr _FunctionPtr;

		// Token: 0x04009E80 RID: 40576
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.WaitAttributeChangeDelegate__DelegateSignature";

		// Token: 0x04009E81 RID: 40577
		private static int RegisterId;

		// Token: 0x02002E58 RID: 11864
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016914 RID: 92436
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
