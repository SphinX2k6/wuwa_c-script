using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200024C RID: 588
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAllMontageInstancesEndedMCDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032B1 RID: 12977 RVA: 0x0004853A File Offset: 0x0004673A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAllMontageInstancesEndedMCDelegate.StaticFunctionPtr();
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00048546 File Offset: 0x00046746
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAllMontageInstancesEndedMCDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnAllMontageInstancesEndedMCDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature");
			}
			return FOnAllMontageInstancesEndedMCDelegate._FunctionPtr;
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00048569 File Offset: 0x00046769
		public FOnAllMontageInstancesEndedMCDelegate()
		{
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00048571 File Offset: 0x00046771
		[NullableContext(2)]
		public FOnAllMontageInstancesEndedMCDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0004857B File Offset: 0x0004677B
		public FOnAllMontageInstancesEndedMCDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00048586 File Offset: 0x00046786
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000485B8 File Offset: 0x000467B8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnAllMontageInstancesEndedMCDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAllMontageInstancesEndedMCDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAllMontageInstancesEndedMCDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAllMontageInstancesEndedMCDelegate.OnScriptCallback));
				}
				FOnAllMontageInstancesEndedMCDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAllMontageInstancesEndedMCDelegate.RegisterId);
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x000485F2 File Offset: 0x000467F2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000485FB File Offset: 0x000467FB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00048608 File Offset: 0x00046808
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040011B2 RID: 4530
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011B3 RID: 4531
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAllMontageInstancesEndedMCDelegate__DelegateSignature";

		// Token: 0x040011B4 RID: 4532
		private static int RegisterId;

		// Token: 0x020009C4 RID: 2500
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005951 RID: 22865
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
