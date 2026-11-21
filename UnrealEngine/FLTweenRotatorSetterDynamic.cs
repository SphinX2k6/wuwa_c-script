using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074A RID: 1866
	public sealed class FLTweenRotatorSetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2D5 RID: 41685 RVA: 0x000F091A File Offset: 0x000EEB1A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenRotatorSetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x000F0926 File Offset: 0x000EEB26
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenRotatorSetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenRotatorSetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenRotatorSetterDynamic__DelegateSignature");
			}
			return FLTweenRotatorSetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x000F0949 File Offset: 0x000EEB49
		public FLTweenRotatorSetterDynamic()
		{
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x000F0951 File Offset: 0x000EEB51
		[NullableContext(2)]
		public FLTweenRotatorSetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x000F095B File Offset: 0x000EEB5B
		public FLTweenRotatorSetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x000F0966 File Offset: 0x000EEB66
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FRotator>) ?? ((Action<FRotator>)Delegate.CreateDelegate(typeof(Action<FRotator>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x000F0998 File Offset: 0x000EEB98
		[NullableContext(1)]
		public void Bind(Action<FRotator> Callback)
		{
			if (FLTweenRotatorSetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenRotatorSetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenRotatorSetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenRotatorSetterDynamic.OnScriptCallback));
				}
				FLTweenRotatorSetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenRotatorSetterDynamic.RegisterId);
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x000F09D4 File Offset: 0x000EEBD4
		[SkipLocalsInit]
		public unsafe void Execute(in FRotator value)
		{
			FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams* ptr = stackalloc FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenRotatorSetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x000F0A18 File Offset: 0x000EEC18
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FRotator> action = target as Action<FRotator>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenRotatorSetterDynamic.__FLTweenRotatorSetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x040045A3 RID: 17827
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045A4 RID: 17828
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenRotatorSetterDynamic__DelegateSignature";

		// Token: 0x040045A5 RID: 17829
		private static int RegisterId;

		// Token: 0x02000F34 RID: 3892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FLTweenRotatorSetterDynamic_DelegateParams
		{
			// Token: 0x04006308 RID: 25352
			[FieldOffset(0)]
			public FRotator value;
		}

		// Token: 0x02000F35 RID: 3893
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006309 RID: 25353
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
