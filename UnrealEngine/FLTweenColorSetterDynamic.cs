using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200223C RID: 8764
	public sealed class FLTweenColorSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060215DA RID: 136666 RVA: 0x00312B69 File Offset: 0x00310D69
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenColorSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x060215DB RID: 136667 RVA: 0x00312B75 File Offset: 0x00310D75
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenColorSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenColorSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenColorSetterDynamic__DelegateSignature");
			}
			return FLTweenColorSetterDynamic._FunctionPtr;
		}

		// Token: 0x060215DC RID: 136668 RVA: 0x00312B98 File Offset: 0x00310D98
		public FLTweenColorSetterDynamic()
		{
		}

		// Token: 0x060215DD RID: 136669 RVA: 0x00312BA0 File Offset: 0x00310DA0
		[NullableContext(2)]
		public FLTweenColorSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060215DE RID: 136670 RVA: 0x00312BAA File Offset: 0x00310DAA
		public FLTweenColorSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060215DF RID: 136671 RVA: 0x00312BB5 File Offset: 0x00310DB5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FColor>) ?? ((Action<FColor>)Delegate.CreateDelegate(typeof(Action<FColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060215E0 RID: 136672 RVA: 0x00312BE7 File Offset: 0x00310DE7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FColor> Callback)
		{
			if (FLTweenColorSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenColorSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenColorSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenColorSetterDynamic.OnScriptCallback));
				}
				FLTweenColorSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenColorSetterDynamic.RegisterId);
		}

		// Token: 0x060215E1 RID: 136673 RVA: 0x00312C24 File Offset: 0x00310E24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FColor value)
		{
			FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams* ptr = stackalloc FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenColorSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060215E2 RID: 136674 RVA: 0x00312C68 File Offset: 0x00310E68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FColor> action = target as Action<FColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011C78 RID: 72824
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011C79 RID: 72825
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenColorSetterDynamic__DelegateSignature";

		// Token: 0x04011C7A RID: 72826
		private static int RegisterId;

		// Token: 0x0200350C RID: 13580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLTweenColorSetterDynamic_DelegateParams
		{
			// Token: 0x0401753E RID: 95550
			[FieldOffset(0)]
			public FColor value;
		}

		// Token: 0x0200350D RID: 13581
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401753F RID: 95551
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
