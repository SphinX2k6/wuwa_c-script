using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074C RID: 1868
	public sealed class FLTweenVector3SetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2E7 RID: 41703 RVA: 0x000F0BAA File Offset: 0x000EEDAA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenVector3SetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x000F0BB6 File Offset: 0x000EEDB6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenVector3SetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenVector3SetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenVector3SetterDynamic__DelegateSignature");
			}
			return FLTweenVector3SetterDynamic._FunctionPtr;
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x000F0BD9 File Offset: 0x000EEDD9
		public FLTweenVector3SetterDynamic()
		{
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x000F0BE1 File Offset: 0x000EEDE1
		[NullableContext(2)]
		public FLTweenVector3SetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x000F0BEB File Offset: 0x000EEDEB
		public FLTweenVector3SetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x000F0BF6 File Offset: 0x000EEDF6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x000F0C28 File Offset: 0x000EEE28
		[NullableContext(1)]
		public void Bind(Action<FVector> Callback)
		{
			if (FLTweenVector3SetterDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLTweenVector3SetterDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLTweenVector3SetterDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLTweenVector3SetterDynamic.OnScriptCallback));
				}
				FLTweenVector3SetterDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLTweenVector3SetterDynamic.RegisterId);
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x000F0C64 File Offset: 0x000EEE64
		[SkipLocalsInit]
		public unsafe void Execute(in FVector value)
		{
			FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams* ptr = stackalloc FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenVector3SetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x000F0CA8 File Offset: 0x000EEEA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x040045A9 RID: 17833
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045AA RID: 17834
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenVector3SetterDynamic__DelegateSignature";

		// Token: 0x040045AB RID: 17835
		private static int RegisterId;

		// Token: 0x02000F38 RID: 3896
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FLTweenVector3SetterDynamic_DelegateParams
		{
			// Token: 0x0400630C RID: 25356
			[FieldOffset(0)]
			public FVector value;
		}

		// Token: 0x02000F39 RID: 3897
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400630D RID: 25357
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
