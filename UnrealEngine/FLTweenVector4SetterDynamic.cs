using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074D RID: 1869
	public sealed class FLTweenVector4SetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2F0 RID: 41712 RVA: 0x000F0CF2 File Offset: 0x000EEEF2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenVector4SetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x000F0CFE File Offset: 0x000EEEFE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenVector4SetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenVector4SetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenVector4SetterDynamic__DelegateSignature");
			}
			return FLTweenVector4SetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x000F0D21 File Offset: 0x000EEF21
		public FLTweenVector4SetterDynamic()
		{
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x000F0D29 File Offset: 0x000EEF29
		[NullableContext(2)]
		public FLTweenVector4SetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x000F0D33 File Offset: 0x000EEF33
		public FLTweenVector4SetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x000F0D3E File Offset: 0x000EEF3E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector4>) ?? ((Action<FVector4>)Delegate.CreateDelegate(typeof(Action<FVector4>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x000F0D70 File Offset: 0x000EEF70
		[NullableContext(1)]
		public void Bind(Action<FVector4> Callback)
		{
			if (FLTweenVector4SetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenVector4SetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenVector4SetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenVector4SetterDynamic.OnScriptCallback));
				}
				FLTweenVector4SetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenVector4SetterDynamic.RegisterId);
		}

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x000F0DAC File Offset: 0x000EEFAC
		[SkipLocalsInit]
		public unsafe void Execute(in FVector4 value)
		{
			FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams* ptr = stackalloc FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenVector4SetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x000F0DF0 File Offset: 0x000EEFF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector4> action = target as Action<FVector4>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenVector4SetterDynamic.__FLTweenVector4SetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x040045AC RID: 17836
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045AD RID: 17837
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenVector4SetterDynamic__DelegateSignature";

		// Token: 0x040045AE RID: 17838
		private static int RegisterId;

		// Token: 0x02000F3A RID: 3898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLTweenVector4SetterDynamic_DelegateParams
		{
			// Token: 0x0400630E RID: 25358
			[FieldOffset(0)]
			public FVector4 value;
		}

		// Token: 0x02000F3B RID: 3899
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400630F RID: 25359
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
