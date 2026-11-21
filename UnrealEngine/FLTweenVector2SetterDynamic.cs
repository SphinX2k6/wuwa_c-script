using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074B RID: 1867
	public sealed class FLTweenVector2SetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2DE RID: 41694 RVA: 0x000F0A62 File Offset: 0x000EEC62
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenVector2SetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x000F0A6E File Offset: 0x000EEC6E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenVector2SetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenVector2SetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenVector2SetterDynamic__DelegateSignature");
			}
			return FLTweenVector2SetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x000F0A91 File Offset: 0x000EEC91
		public FLTweenVector2SetterDynamic()
		{
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x000F0A99 File Offset: 0x000EEC99
		[NullableContext(2)]
		public FLTweenVector2SetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x000F0AA3 File Offset: 0x000EECA3
		public FLTweenVector2SetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x000F0AAE File Offset: 0x000EECAE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector2D>) ?? ((Action<FVector2D>)Delegate.CreateDelegate(typeof(Action<FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x000F0AE0 File Offset: 0x000EECE0
		[NullableContext(1)]
		public void Bind(Action<FVector2D> Callback)
		{
			if (FLTweenVector2SetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenVector2SetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenVector2SetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenVector2SetterDynamic.OnScriptCallback));
				}
				FLTweenVector2SetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenVector2SetterDynamic.RegisterId);
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x000F0B1C File Offset: 0x000EED1C
		[SkipLocalsInit]
		public unsafe void Execute(in FVector2D value)
		{
			FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams* ptr = stackalloc FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenVector2SetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x000F0B60 File Offset: 0x000EED60
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector2D> action = target as Action<FVector2D>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenVector2SetterDynamic.__FLTweenVector2SetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x040045A6 RID: 17830
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045A7 RID: 17831
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenVector2SetterDynamic__DelegateSignature";

		// Token: 0x040045A8 RID: 17832
		private static int RegisterId;

		// Token: 0x02000F36 RID: 3894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLTweenVector2SetterDynamic_DelegateParams
		{
			// Token: 0x0400630A RID: 25354
			[FieldOffset(0)]
			public FVector2D value;
		}

		// Token: 0x02000F37 RID: 3895
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400630B RID: 25355
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
