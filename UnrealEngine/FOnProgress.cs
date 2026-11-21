using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F8 RID: 1528
	public sealed class FOnProgress : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008797 RID: 34711 RVA: 0x000CBAE3 File Offset: 0x000C9CE3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnProgress.StaticFunctionPtr();
		}

		// Token: 0x06008798 RID: 34712 RVA: 0x000CBAEF File Offset: 0x000C9CEF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnProgress._FunctionPtr == IntPtr.Zero)
			{
				FOnProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnProgress__DelegateSignature");
			}
			return FOnProgress._FunctionPtr;
		}

		// Token: 0x06008799 RID: 34713 RVA: 0x000CBB12 File Offset: 0x000C9D12
		public FOnProgress()
		{
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x000CBB1A File Offset: 0x000C9D1A
		[NullableContext(2)]
		public FOnProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x000CBB24 File Offset: 0x000C9D24
		public FOnProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x000CBB2F File Offset: 0x000C9D2F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, float>) ?? ((Action<int, float>)Delegate.CreateDelegate(typeof(Action<int, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x000CBB61 File Offset: 0x000C9D61
		[NullableContext(1)]
		public void Bind(Action<int, float> Callback)
		{
			if (FOnProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnProgress.OnScriptCallback));
				}
				FOnProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnProgress.RegisterId);
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x000CBB9C File Offset: 0x000C9D9C
		[SkipLocalsInit]
		public unsafe void Execute(int State, float Rate)
		{
			FOnProgress.__FOnProgress_DelegateParams* ptr = stackalloc FOnProgress.__FOnProgress_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnProgress.__FOnProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			ptr->Rate = Rate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x000CBBE0 File Offset: 0x000C9DE0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float> action = target as Action<int, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnProgress.__FOnProgress_DelegateParams*)__Parameters)->State, ((FOnProgress.__FOnProgress_DelegateParams*)__Parameters)->Rate);
		}

		// Token: 0x04003AF3 RID: 15091
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AF4 RID: 15092
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnProgress__DelegateSignature";

		// Token: 0x04003AF5 RID: 15093
		private static int RegisterId;

		// Token: 0x02000E0E RID: 3598
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnProgress_DelegateParams
		{
			// Token: 0x040061A2 RID: 24994
			[FieldOffset(0)]
			public int State;

			// Token: 0x040061A3 RID: 24995
			[FieldOffset(4)]
			public float Rate;
		}

		// Token: 0x02000E0F RID: 3599
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061A4 RID: 24996
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
