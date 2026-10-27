using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C4 RID: 8388
	public sealed class FLGUISliderDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F99B RID: 129435 RVA: 0x002EFBDA File Offset: 0x002EDDDA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISliderDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F99C RID: 129436 RVA: 0x002EFBE6 File Offset: 0x002EDDE6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISliderDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISliderDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISliderDynamicDelegate__DelegateSignature");
			}
			return FLGUISliderDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F99D RID: 129437 RVA: 0x002EFC09 File Offset: 0x002EDE09
		public FLGUISliderDynamicDelegate()
		{
		}

		// Token: 0x0601F99E RID: 129438 RVA: 0x002EFC11 File Offset: 0x002EDE11
		[NullableContext(2)]
		public FLGUISliderDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F99F RID: 129439 RVA: 0x002EFC1B File Offset: 0x002EDE1B
		public FLGUISliderDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F9A0 RID: 129440 RVA: 0x002EFC26 File Offset: 0x002EDE26
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F9A1 RID: 129441 RVA: 0x002EFC58 File Offset: 0x002EDE58
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUISliderDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISliderDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISliderDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISliderDynamicDelegate.OnScriptCallback));
				}
				FLGUISliderDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISliderDynamicDelegate.RegisterId);
		}

		// Token: 0x0601F9A2 RID: 129442 RVA: 0x002EFC94 File Offset: 0x002EDE94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float InFloat)
		{
			FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams* ptr = stackalloc FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISliderDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InFloat = InFloat;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F9A3 RID: 129443 RVA: 0x002EFCD4 File Offset: 0x002EDED4
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
			action(((FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams*)__Parameters)->InFloat);
		}

		// Token: 0x040110E7 RID: 69863
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110E8 RID: 69864
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISliderDynamicDelegate__DelegateSignature";

		// Token: 0x040110E9 RID: 69865
		private static int RegisterId;

		// Token: 0x020034BC RID: 13500
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUISliderDynamicDelegate_DelegateParams
		{
			// Token: 0x040174C5 RID: 95429
			[FieldOffset(0)]
			public float InFloat;
		}

		// Token: 0x020034BD RID: 13501
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174C6 RID: 95430
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
