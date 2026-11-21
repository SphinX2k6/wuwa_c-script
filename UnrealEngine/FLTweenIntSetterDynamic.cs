using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000747 RID: 1863
	public sealed class FLTweenIntSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2BA RID: 41658 RVA: 0x000F0546 File Offset: 0x000EE746
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenIntSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x000F0552 File Offset: 0x000EE752
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenIntSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenIntSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenIntSetterDynamic__DelegateSignature");
			}
			return FLTweenIntSetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x000F0575 File Offset: 0x000EE775
		public FLTweenIntSetterDynamic()
		{
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x000F057D File Offset: 0x000EE77D
		[NullableContext(2)]
		public FLTweenIntSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x000F0587 File Offset: 0x000EE787
		public FLTweenIntSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2BF RID: 41663 RVA: 0x000F0592 File Offset: 0x000EE792
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x000F05C4 File Offset: 0x000EE7C4
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FLTweenIntSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenIntSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenIntSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenIntSetterDynamic.OnScriptCallback));
				}
				FLTweenIntSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenIntSetterDynamic.RegisterId);
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x000F0600 File Offset: 0x000EE800
		[SkipLocalsInit]
		public unsafe void Execute(int value)
		{
			FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams* ptr = stackalloc FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenIntSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x000F0640 File Offset: 0x000EE840
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenIntSetterDynamic.__FLTweenIntSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x0400459A RID: 17818
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400459B RID: 17819
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenIntSetterDynamic__DelegateSignature";

		// Token: 0x0400459C RID: 17820
		private static int RegisterId;

		// Token: 0x02000F2E RID: 3886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLTweenIntSetterDynamic_DelegateParams
		{
			// Token: 0x04006302 RID: 25346
			[FieldOffset(0)]
			public int value;
		}

		// Token: 0x02000F2F RID: 3887
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006303 RID: 25347
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
