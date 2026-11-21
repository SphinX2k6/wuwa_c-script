using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000749 RID: 1865
	public sealed class FLTweenQuaternionSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2CC RID: 41676 RVA: 0x000F07D2 File Offset: 0x000EE9D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenQuaternionSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x000F07DE File Offset: 0x000EE9DE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenQuaternionSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenQuaternionSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenQuaternionSetterDynamic__DelegateSignature");
			}
			return FLTweenQuaternionSetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x000F0801 File Offset: 0x000EEA01
		public FLTweenQuaternionSetterDynamic()
		{
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x000F0809 File Offset: 0x000EEA09
		[NullableContext(2)]
		public FLTweenQuaternionSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x000F0813 File Offset: 0x000EEA13
		public FLTweenQuaternionSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x000F081E File Offset: 0x000EEA1E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FQuat>) ?? ((Action<FQuat>)Delegate.CreateDelegate(typeof(Action<FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x000F0850 File Offset: 0x000EEA50
		[NullableContext(1)]
		public void Bind(Action<FQuat> Callback)
		{
			if (FLTweenQuaternionSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenQuaternionSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenQuaternionSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenQuaternionSetterDynamic.OnScriptCallback));
				}
				FLTweenQuaternionSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenQuaternionSetterDynamic.RegisterId);
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x000F088C File Offset: 0x000EEA8C
		[SkipLocalsInit]
		public unsafe void Execute(in FQuat value)
		{
			FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams* ptr = stackalloc FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenQuaternionSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x000F08D0 File Offset: 0x000EEAD0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FQuat> action = target as Action<FQuat>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenQuaternionSetterDynamic.__FLTweenQuaternionSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x040045A0 RID: 17824
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045A1 RID: 17825
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenQuaternionSetterDynamic__DelegateSignature";

		// Token: 0x040045A2 RID: 17826
		private static int RegisterId;

		// Token: 0x02000F32 RID: 3890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLTweenQuaternionSetterDynamic_DelegateParams
		{
			// Token: 0x04006306 RID: 25350
			[FieldOffset(0)]
			public FQuat value;
		}

		// Token: 0x02000F33 RID: 3891
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006307 RID: 25351
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
