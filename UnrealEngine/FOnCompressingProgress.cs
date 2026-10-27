using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE5 RID: 7909
	public sealed class FOnCompressingProgress : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E114 RID: 123156 RVA: 0x002CA186 File Offset: 0x002C8386
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCompressingProgress.StaticFunctionPtr();
		}

		// Token: 0x0601E115 RID: 123157 RVA: 0x002CA192 File Offset: 0x002C8392
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCompressingProgress._FunctionPtr == IntPtr.Zero)
			{
				FOnCompressingProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnCompressingProgress__DelegateSignature");
			}
			return FOnCompressingProgress._FunctionPtr;
		}

		// Token: 0x0601E116 RID: 123158 RVA: 0x002CA1B5 File Offset: 0x002C83B5
		public FOnCompressingProgress()
		{
		}

		// Token: 0x0601E117 RID: 123159 RVA: 0x002CA1BD File Offset: 0x002C83BD
		[NullableContext(2)]
		public FOnCompressingProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E118 RID: 123160 RVA: 0x002CA1C7 File Offset: 0x002C83C7
		public FOnCompressingProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E119 RID: 123161 RVA: 0x002CA1D2 File Offset: 0x002C83D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E11A RID: 123162 RVA: 0x002CA204 File Offset: 0x002C8404
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FOnCompressingProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCompressingProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCompressingProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCompressingProgress.OnScriptCallback));
				}
				FOnCompressingProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnCompressingProgress.RegisterId);
		}

		// Token: 0x0601E11B RID: 123163 RVA: 0x002CA240 File Offset: 0x002C8440
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float Rate)
		{
			FOnCompressingProgress.__FOnCompressingProgress_DelegateParams* ptr = stackalloc FOnCompressingProgress.__FOnCompressingProgress_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnCompressingProgress.__FOnCompressingProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnCompressingProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Rate = Rate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E11C RID: 123164 RVA: 0x002CA280 File Offset: 0x002C8480
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnCompressingProgress.__FOnCompressingProgress_DelegateParams*)__Parameters)->Rate);
		}

		// Token: 0x04010409 RID: 66569
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401040A RID: 66570
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnCompressingProgress__DelegateSignature";

		// Token: 0x0401040B RID: 66571
		private static int RegisterId;

		// Token: 0x020033B2 RID: 13234
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnCompressingProgress_DelegateParams
		{
			// Token: 0x04017366 RID: 95078
			[FieldOffset(0)]
			public float Rate;
		}

		// Token: 0x020033B3 RID: 13235
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017367 RID: 95079
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
