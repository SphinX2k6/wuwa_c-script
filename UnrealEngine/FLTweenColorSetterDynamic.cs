using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000742 RID: 1858
	public sealed class FLTweenColorSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A271 RID: 41585 RVA: 0x000EFEDD File Offset: 0x000EE0DD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenColorSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x000EFEE9 File Offset: 0x000EE0E9
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenColorSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenColorSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenColorSetterDynamic__DelegateSignature");
			}
			return FLTweenColorSetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x000EFF0C File Offset: 0x000EE10C
		public FLTweenColorSetterDynamic()
		{
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x000EFF14 File Offset: 0x000EE114
		[NullableContext(2)]
		public FLTweenColorSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x000EFF1E File Offset: 0x000EE11E
		public FLTweenColorSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x000EFF29 File Offset: 0x000EE129
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FColor>) ?? ((Action<FColor>)Delegate.CreateDelegate(typeof(Action<FColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x000EFF5B File Offset: 0x000EE15B
		[NullableContext(1)]
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

		// Token: 0x0600A278 RID: 41592 RVA: 0x000EFF98 File Offset: 0x000EE198
		[SkipLocalsInit]
		public unsafe void Execute(in FColor value)
		{
			FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams* ptr = stackalloc FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenColorSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x000EFFDC File Offset: 0x000EE1DC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FColor> action = target as Action<FColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenColorSetterDynamic.__FLTweenColorSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04004569 RID: 17769
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400456A RID: 17770
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenColorSetterDynamic__DelegateSignature";

		// Token: 0x0400456B RID: 17771
		private static int RegisterId;

		// Token: 0x02000F29 RID: 3881
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLTweenColorSetterDynamic_DelegateParams
		{
			// Token: 0x040062FD RID: 25341
			[FieldOffset(0)]
			public FColor value;
		}

		// Token: 0x02000F2A RID: 3882
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062FE RID: 25342
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
