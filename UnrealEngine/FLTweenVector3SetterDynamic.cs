using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002259 RID: 8793
	public sealed class FLTweenVector3SetterDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060216B0 RID: 136880 RVA: 0x00314142 File Offset: 0x00312342
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLTweenVector3SetterDynamic.StaticFunctionPtr();
		}

		// Token: 0x060216B1 RID: 136881 RVA: 0x0031414E File Offset: 0x0031234E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLTweenVector3SetterDynamic._FunctionPtr == IntPtr.Zero)
			{
				FLTweenVector3SetterDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.LTweenVector3SetterDynamic__DelegateSignature");
			}
			return FLTweenVector3SetterDynamic._FunctionPtr;
		}

		// Token: 0x060216B2 RID: 136882 RVA: 0x00314171 File Offset: 0x00312371
		public FLTweenVector3SetterDynamic()
		{
		}

		// Token: 0x060216B3 RID: 136883 RVA: 0x00314179 File Offset: 0x00312379
		[NullableContext(2)]
		public FLTweenVector3SetterDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216B4 RID: 136884 RVA: 0x00314183 File Offset: 0x00312383
		public FLTweenVector3SetterDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216B5 RID: 136885 RVA: 0x0031418E File Offset: 0x0031238E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060216B6 RID: 136886 RVA: 0x003141C0 File Offset: 0x003123C0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060216B7 RID: 136887 RVA: 0x003141FC File Offset: 0x003123FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FVector value)
		{
			FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams* ptr = stackalloc FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLTweenVector3SetterDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060216B8 RID: 136888 RVA: 0x00314240 File Offset: 0x00312440
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLTweenVector3SetterDynamic.__FLTweenVector3SetterDynamic_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04011CF3 RID: 72947
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CF4 RID: 72948
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenVector3SetterDynamic__DelegateSignature";

		// Token: 0x04011CF5 RID: 72949
		private static int RegisterId;

		// Token: 0x0200351B RID: 13595
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FLTweenVector3SetterDynamic_DelegateParams
		{
			// Token: 0x0401754D RID: 95565
			[FieldOffset(0)]
			public FVector value;
		}

		// Token: 0x0200351C RID: 13596
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401754E RID: 95566
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
