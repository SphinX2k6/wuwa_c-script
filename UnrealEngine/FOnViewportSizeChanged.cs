using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F8 RID: 8440
	public sealed class FOnViewportSizeChanged : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FC45 RID: 130117 RVA: 0x002F3DFA File Offset: 0x002F1FFA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnViewportSizeChanged.StaticFunctionPtr();
		}

		// Token: 0x0601FC46 RID: 130118 RVA: 0x002F3E06 File Offset: 0x002F2006
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnViewportSizeChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnViewportSizeChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnViewportSizeChanged__DelegateSignature");
			}
			return FOnViewportSizeChanged._FunctionPtr;
		}

		// Token: 0x0601FC47 RID: 130119 RVA: 0x002F3E29 File Offset: 0x002F2029
		public FOnViewportSizeChanged()
		{
		}

		// Token: 0x0601FC48 RID: 130120 RVA: 0x002F3E31 File Offset: 0x002F2031
		[NullableContext(2)]
		public FOnViewportSizeChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC49 RID: 130121 RVA: 0x002F3E3B File Offset: 0x002F203B
		public FOnViewportSizeChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC4A RID: 130122 RVA: 0x002F3E46 File Offset: 0x002F2046
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FIntPoint>) ?? ((Action<FIntPoint>)Delegate.CreateDelegate(typeof(Action<FIntPoint>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FC4B RID: 130123 RVA: 0x002F3E78 File Offset: 0x002F2078
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FIntPoint> Callback)
		{
			if (FOnViewportSizeChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnViewportSizeChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnViewportSizeChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnViewportSizeChanged.OnScriptCallback));
				}
				FOnViewportSizeChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnViewportSizeChanged.RegisterId);
		}

		// Token: 0x0601FC4C RID: 130124 RVA: 0x002F3EB4 File Offset: 0x002F20B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FIntPoint NewViewportSize)
		{
			FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams* ptr = stackalloc FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnViewportSizeChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewViewportSize = NewViewportSize;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601FC4D RID: 130125 RVA: 0x002F3EF4 File Offset: 0x002F20F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FIntPoint> action = target as Action<FIntPoint>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams*)__Parameters)->NewViewportSize);
		}

		// Token: 0x040111F5 RID: 70133
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111F6 RID: 70134
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnViewportSizeChanged__DelegateSignature";

		// Token: 0x040111F7 RID: 70135
		private static int RegisterId;

		// Token: 0x020034E0 RID: 13536
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnViewportSizeChanged_DelegateParams
		{
			// Token: 0x040174F4 RID: 95476
			[FieldOffset(0)]
			public FIntPoint NewViewportSize;
		}

		// Token: 0x020034E1 RID: 13537
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174F5 RID: 95477
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
