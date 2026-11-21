using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000746 RID: 1862
	public sealed class FLTweenFloatSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2B1 RID: 41649 RVA: 0x000F0402 File Offset: 0x000EE602
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenFloatSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x000F040E File Offset: 0x000EE60E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenFloatSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenFloatSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenFloatSetterDynamic__DelegateSignature");
			}
			return FLTweenFloatSetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x000F0431 File Offset: 0x000EE631
		public FLTweenFloatSetterDynamic()
		{
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x000F0439 File Offset: 0x000EE639
		[NullableContext(2)]
		public FLTweenFloatSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x000F0443 File Offset: 0x000EE643
		public FLTweenFloatSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x000F044E File Offset: 0x000EE64E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x000F0480 File Offset: 0x000EE680
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FLTweenFloatSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenFloatSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenFloatSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenFloatSetterDynamic.OnScriptCallback));
				}
				FLTweenFloatSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenFloatSetterDynamic.RegisterId);
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x000F04BC File Offset: 0x000EE6BC
		[SkipLocalsInit]
		public unsafe void Execute(float value)
		{
			FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams* ptr = stackalloc FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenFloatSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x000F04FC File Offset: 0x000EE6FC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenFloatSetterDynamic.__FLTweenFloatSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04004597 RID: 17815
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004598 RID: 17816
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenFloatSetterDynamic__DelegateSignature";

		// Token: 0x04004599 RID: 17817
		private static int RegisterId;

		// Token: 0x02000F2C RID: 3884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLTweenFloatSetterDynamic_DelegateParams
		{
			// Token: 0x04006300 RID: 25344
			[FieldOffset(0)]
			public float value;
		}

		// Token: 0x02000F2D RID: 3885
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006301 RID: 25345
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
