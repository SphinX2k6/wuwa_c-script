using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D7 RID: 1751
	public sealed class FOnViewportSizeChanged : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094F0 RID: 38128 RVA: 0x000E0C0A File Offset: 0x000DEE0A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnViewportSizeChanged.StaticFunctionPtr();
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x000E0C16 File Offset: 0x000DEE16
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnViewportSizeChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnViewportSizeChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnViewportSizeChanged__DelegateSignature");
			}
			return FOnViewportSizeChanged._FunctionPtr;
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x000E0C39 File Offset: 0x000DEE39
		public FOnViewportSizeChanged()
		{
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x000E0C41 File Offset: 0x000DEE41
		[NullableContext(2)]
		public FOnViewportSizeChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x000E0C4B File Offset: 0x000DEE4B
		public FOnViewportSizeChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x000E0C56 File Offset: 0x000DEE56
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FIntPoint>) ?? ((Action<FIntPoint>)Delegate.CreateDelegate(typeof(Action<FIntPoint>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x000E0C88 File Offset: 0x000DEE88
		[NullableContext(1)]
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

		// Token: 0x060094F7 RID: 38135 RVA: 0x000E0CC4 File Offset: 0x000DEEC4
		[SkipLocalsInit]
		public unsafe void Execute(FIntPoint NewViewportSize)
		{
			FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams* ptr = stackalloc FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnViewportSizeChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewViewportSize = NewViewportSize;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x000E0D04 File Offset: 0x000DEF04
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FIntPoint> action = target as Action<FIntPoint>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnViewportSizeChanged.__FOnViewportSizeChanged_DelegateParams*)__Parameters)->NewViewportSize);
		}

		// Token: 0x040040C3 RID: 16579
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040C4 RID: 16580
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnViewportSizeChanged__DelegateSignature";

		// Token: 0x040040C5 RID: 16581
		private static int RegisterId;

		// Token: 0x02000F0C RID: 3852
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnViewportSizeChanged_DelegateParams
		{
			// Token: 0x040062D9 RID: 25305
			[FieldOffset(0)]
			public FIntPoint NewViewportSize;
		}

		// Token: 0x02000F0D RID: 3853
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062DA RID: 25306
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
