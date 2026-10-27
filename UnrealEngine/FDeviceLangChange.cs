using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E95 RID: 7829
	public sealed class FDeviceLangChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC64 RID: 121956 RVA: 0x002C000E File Offset: 0x002BE20E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDeviceLangChange.StaticFunctionPtr();
		}

		// Token: 0x0601DC65 RID: 121957 RVA: 0x002C001A File Offset: 0x002BE21A
		private static IntPtr StaticFunctionPtr()
		{
			if (FDeviceLangChange._FunctionPtr == IntPtr.Zero)
			{
				FDeviceLangChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.DeviceLangChange__DelegateSignature");
			}
			return FDeviceLangChange._FunctionPtr;
		}

		// Token: 0x0601DC66 RID: 121958 RVA: 0x002C003D File Offset: 0x002BE23D
		public FDeviceLangChange()
		{
		}

		// Token: 0x0601DC67 RID: 121959 RVA: 0x002C0045 File Offset: 0x002BE245
		[NullableContext(2)]
		public FDeviceLangChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC68 RID: 121960 RVA: 0x002C004F File Offset: 0x002BE24F
		public FDeviceLangChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC69 RID: 121961 RVA: 0x002C005A File Offset: 0x002BE25A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC6A RID: 121962 RVA: 0x002C008C File Offset: 0x002BE28C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FDeviceLangChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FDeviceLangChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FDeviceLangChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FDeviceLangChange.OnScriptCallback));
				}
				FDeviceLangChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FDeviceLangChange.RegisterId);
		}

		// Token: 0x0601DC6B RID: 121963 RVA: 0x002C00C6 File Offset: 0x002BE2C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DC6C RID: 121964 RVA: 0x002C00D4 File Offset: 0x002BE2D4
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

		// Token: 0x040101E1 RID: 66017
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101E2 RID: 66018
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.DeviceLangChange__DelegateSignature";

		// Token: 0x040101E3 RID: 66019
		private static int RegisterId;

		// Token: 0x020032E5 RID: 13029
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017195 RID: 94613
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
