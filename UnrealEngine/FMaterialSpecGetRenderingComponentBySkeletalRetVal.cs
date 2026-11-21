using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040F RID: 1039
	public sealed class FMaterialSpecGetRenderingComponentBySkeletalRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006548 RID: 25928 RVA: 0x00090B95 File Offset: 0x0008ED95
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecGetRenderingComponentBySkeletalRetVal.StaticFunctionPtr();
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00090BA1 File Offset: 0x0008EDA1
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecGetRenderingComponentBySkeletalRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecGetRenderingComponentBySkeletalRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecGetRenderingComponentBySkeletalRetVal__DelegateSignature");
			}
			return FMaterialSpecGetRenderingComponentBySkeletalRetVal._FunctionPtr;
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x00090BC4 File Offset: 0x0008EDC4
		public FMaterialSpecGetRenderingComponentBySkeletalRetVal()
		{
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x00090BCC File Offset: 0x0008EDCC
		[NullableContext(2)]
		public FMaterialSpecGetRenderingComponentBySkeletalRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00090BD6 File Offset: 0x0008EDD6
		public FMaterialSpecGetRenderingComponentBySkeletalRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x00090BE1 File Offset: 0x0008EDE1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<USkeletalMeshComponent, UKuroCharRenderingComponent>) ?? ((Func<USkeletalMeshComponent, UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Func<USkeletalMeshComponent, UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x00090C13 File Offset: 0x0008EE13
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<USkeletalMeshComponent, UKuroCharRenderingComponent> Callback)
		{
			if (FMaterialSpecGetRenderingComponentBySkeletalRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecGetRenderingComponentBySkeletalRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecGetRenderingComponentBySkeletalRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecGetRenderingComponentBySkeletalRetVal.OnScriptCallback));
				}
				FMaterialSpecGetRenderingComponentBySkeletalRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecGetRenderingComponentBySkeletalRetVal.RegisterId);
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x00090C50 File Offset: 0x0008EE50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UKuroCharRenderingComponent Execute(USkeletalMeshComponent SkeletalMeshComponent)
		{
			FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams* ptr = stackalloc FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecGetRenderingComponentBySkeletalRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(ptr->__Result);
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x00090CA8 File Offset: 0x0008EEA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<USkeletalMeshComponent, UKuroCharRenderingComponent> func = target as Func<USkeletalMeshComponent, UKuroCharRenderingComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams*)__Parameters)->SkeletalMeshComponent);
			UKuroCharRenderingComponent ukuroCharRenderingComponent = func(orCreateUObjectByNativePointer);
			((FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams*)__Parameters)->__Result = ((ukuroCharRenderingComponent != null) ? ukuroCharRenderingComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04002A99 RID: 10905
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A9A RID: 10906
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecGetRenderingComponentBySkeletalRetVal__DelegateSignature";

		// Token: 0x04002A9B RID: 10907
		private static int RegisterId;

		// Token: 0x02000AFF RID: 2815
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams
		{
			// Token: 0x04005B94 RID: 23444
			[FieldOffset(0)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04005B95 RID: 23445
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000B00 RID: 2816
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B96 RID: 23446
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
