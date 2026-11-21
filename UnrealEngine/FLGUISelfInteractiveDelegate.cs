using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BB RID: 1723
	public sealed class FLGUISelfInteractiveDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093B9 RID: 37817 RVA: 0x000DE8B3 File Offset: 0x000DCAB3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISelfInteractiveDelegate.StaticFunctionPtr();
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x000DE8BF File Offset: 0x000DCABF
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISelfInteractiveDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISelfInteractiveDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISelfInteractiveDelegate__DelegateSignature");
			}
			return FLGUISelfInteractiveDelegate._FunctionPtr;
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x000DE8E2 File Offset: 0x000DCAE2
		public FLGUISelfInteractiveDelegate()
		{
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x000DE8EA File Offset: 0x000DCAEA
		[NullableContext(2)]
		public FLGUISelfInteractiveDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x000DE8F4 File Offset: 0x000DCAF4
		public FLGUISelfInteractiveDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x000DE8FF File Offset: 0x000DCAFF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x000DE931 File Offset: 0x000DCB31
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUISelfInteractiveDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISelfInteractiveDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISelfInteractiveDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISelfInteractiveDelegate.OnScriptCallback));
				}
				FLGUISelfInteractiveDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISelfInteractiveDelegate.RegisterId);
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x000DE96C File Offset: 0x000DCB6C
		[SkipLocalsInit]
		public unsafe void Execute(bool CurrentSelfInteractive)
		{
			FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams* ptr = stackalloc FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISelfInteractiveDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentSelfInteractive = CurrentSelfInteractive;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060093C1 RID: 37825 RVA: 0x000DE9AC File Offset: 0x000DCBAC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams*)__Parameters)->CurrentSelfInteractive);
		}

		// Token: 0x04004066 RID: 16486
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004067 RID: 16487
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISelfInteractiveDelegate__DelegateSignature";

		// Token: 0x04004068 RID: 16488
		private static int RegisterId;

		// Token: 0x02000EE6 RID: 3814
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUISelfInteractiveDelegate_DelegateParams
		{
			// Token: 0x040062A8 RID: 25256
			[FieldOffset(0)]
			public bool CurrentSelfInteractive;
		}

		// Token: 0x02000EE7 RID: 3815
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062A9 RID: 25257
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
