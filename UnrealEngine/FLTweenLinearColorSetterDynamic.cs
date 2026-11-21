using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000748 RID: 1864
	public sealed class FLTweenLinearColorSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2C3 RID: 41667 RVA: 0x000F068A File Offset: 0x000EE88A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenLinearColorSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2C4 RID: 41668 RVA: 0x000F0696 File Offset: 0x000EE896
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenLinearColorSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenLinearColorSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenLinearColorSetterDynamic__DelegateSignature");
			}
			return FLTweenLinearColorSetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2C5 RID: 41669 RVA: 0x000F06B9 File Offset: 0x000EE8B9
		public FLTweenLinearColorSetterDynamic()
		{
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x000F06C1 File Offset: 0x000EE8C1
		[NullableContext(2)]
		public FLTweenLinearColorSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x000F06CB File Offset: 0x000EE8CB
		public FLTweenLinearColorSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x000F06D6 File Offset: 0x000EE8D6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FLinearColor>) ?? ((Action<FLinearColor>)Delegate.CreateDelegate(typeof(Action<FLinearColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x000F0708 File Offset: 0x000EE908
		[NullableContext(1)]
		public void Bind(Action<FLinearColor> Callback)
		{
			if (FLTweenLinearColorSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenLinearColorSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenLinearColorSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenLinearColorSetterDynamic.OnScriptCallback));
				}
				FLTweenLinearColorSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenLinearColorSetterDynamic.RegisterId);
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x000F0744 File Offset: 0x000EE944
		[SkipLocalsInit]
		public unsafe void Execute(in FLinearColor value)
		{
			FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams* ptr = stackalloc FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenLinearColorSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x000F0788 File Offset: 0x000EE988
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FLinearColor> action = target as Action<FLinearColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenLinearColorSetterDynamic.__FLTweenLinearColorSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x0400459D RID: 17821
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400459E RID: 17822
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenLinearColorSetterDynamic__DelegateSignature";

		// Token: 0x0400459F RID: 17823
		private static int RegisterId;

		// Token: 0x02000F30 RID: 3888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLTweenLinearColorSetterDynamic_DelegateParams
		{
			// Token: 0x04006304 RID: 25348
			[FieldOffset(0)]
			public FLinearColor value;
		}

		// Token: 0x02000F31 RID: 3889
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006305 RID: 25349
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
