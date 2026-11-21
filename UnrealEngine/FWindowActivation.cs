using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200061D RID: 1565
	public sealed class FWindowActivation : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008915 RID: 35093 RVA: 0x000CED40 File Offset: 0x000CCF40
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWindowActivation.StaticFunctionPtr();
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x000CED4C File Offset: 0x000CCF4C
		private static IntPtr StaticFunctionPtr()
		{
			if (FWindowActivation._FunctionPtr == IntPtr.Zero)
			{
				FWindowActivation._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.WindowActivation__DelegateSignature");
			}
			return FWindowActivation._FunctionPtr;
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x000CED6F File Offset: 0x000CCF6F
		public FWindowActivation()
		{
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x000CED77 File Offset: 0x000CCF77
		[NullableContext(2)]
		public FWindowActivation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x000CED81 File Offset: 0x000CCF81
		public FWindowActivation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x000CED8C File Offset: 0x000CCF8C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x000CEDBE File Offset: 0x000CCFBE
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FWindowActivation.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWindowActivation.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWindowActivation.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWindowActivation.OnScriptCallback));
				}
				FWindowActivation.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FWindowActivation.RegisterId);
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x000CEDF8 File Offset: 0x000CCFF8
		[SkipLocalsInit]
		public unsafe void Execute(bool Activated)
		{
			FWindowActivation.__FWindowActivation_DelegateParams* ptr = stackalloc FWindowActivation.__FWindowActivation_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FWindowActivation.__FWindowActivation_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWindowActivation.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Activated = Activated;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x000CEE38 File Offset: 0x000CD038
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FWindowActivation.__FWindowActivation_DelegateParams*)__Parameters)->Activated);
		}

		// Token: 0x04003B81 RID: 15233
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B82 RID: 15234
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.WindowActivation__DelegateSignature";

		// Token: 0x04003B83 RID: 15235
		private static int RegisterId;

		// Token: 0x02000E4E RID: 3662
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FWindowActivation_DelegateParams
		{
			// Token: 0x040061E9 RID: 25065
			[FieldOffset(0)]
			public bool Activated;
		}

		// Token: 0x02000E4F RID: 3663
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061EA RID: 25066
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
