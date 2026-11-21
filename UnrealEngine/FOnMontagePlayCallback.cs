using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000436 RID: 1078
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontagePlayCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060068B1 RID: 26801 RVA: 0x00098BFA File Offset: 0x00096DFA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontagePlayCallback.StaticFunctionPtr();
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x00098C06 File Offset: 0x00096E06
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontagePlayCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnMontagePlayCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnMontagePlayCallback__DelegateSignature");
			}
			return FOnMontagePlayCallback._FunctionPtr;
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00098C29 File Offset: 0x00096E29
		public FOnMontagePlayCallback()
		{
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x00098C31 File Offset: 0x00096E31
		[NullableContext(2)]
		public FOnMontagePlayCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x00098C3B File Offset: 0x00096E3B
		public FOnMontagePlayCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00098C46 File Offset: 0x00096E46
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00098C78 File Offset: 0x00096E78
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FOnMontagePlayCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontagePlayCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontagePlayCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontagePlayCallback.OnScriptCallback));
				}
				FOnMontagePlayCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontagePlayCallback.RegisterId);
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00098CB2 File Offset: 0x00096EB2
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x00098CBC File Offset: 0x00096EBC
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bInterrupted)
		{
			FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams* ptr = stackalloc FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontagePlayCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bInterrupted = bInterrupted;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00098CF8 File Offset: 0x00096EF8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnMontagePlayCallback.__FOnMontagePlayCallback_DelegateParams*)__Parameters)->bInterrupted);
		}

		// Token: 0x04002CA1 RID: 11425
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CA2 RID: 11426
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnMontagePlayCallback__DelegateSignature";

		// Token: 0x04002CA3 RID: 11427
		private static int RegisterId;

		// Token: 0x02000B54 RID: 2900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnMontagePlayCallback_DelegateParams
		{
			// Token: 0x04005C67 RID: 23655
			[FieldOffset(0)]
			public bool bInterrupted;
		}

		// Token: 0x02000B55 RID: 2901
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C68 RID: 23656
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
