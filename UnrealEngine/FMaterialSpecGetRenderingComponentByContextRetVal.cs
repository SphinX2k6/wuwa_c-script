using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040D RID: 1037
	public sealed class FMaterialSpecGetRenderingComponentByContextRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006536 RID: 25910 RVA: 0x00090869 File Offset: 0x0008EA69
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecGetRenderingComponentByContextRetVal.StaticFunctionPtr();
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x00090875 File Offset: 0x0008EA75
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecGetRenderingComponentByContextRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecGetRenderingComponentByContextRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByContextRetVal__DelegateSignature");
			}
			return FMaterialSpecGetRenderingComponentByContextRetVal._FunctionPtr;
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00090898 File Offset: 0x0008EA98
		public FMaterialSpecGetRenderingComponentByContextRetVal()
		{
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x000908A0 File Offset: 0x0008EAA0
		[NullableContext(2)]
		public FMaterialSpecGetRenderingComponentByContextRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x000908AA File Offset: 0x0008EAAA
		public FMaterialSpecGetRenderingComponentByContextRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x000908B5 File Offset: 0x0008EAB5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, UObject, UKuroCharRenderingComponent>) ?? ((Func<int, UObject, UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Func<int, UObject, UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x000908E7 File Offset: 0x0008EAE7
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<int, UObject, UKuroCharRenderingComponent> Callback)
		{
			if (FMaterialSpecGetRenderingComponentByContextRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecGetRenderingComponentByContextRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecGetRenderingComponentByContextRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecGetRenderingComponentByContextRetVal.OnScriptCallback));
				}
				FMaterialSpecGetRenderingComponentByContextRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecGetRenderingComponentByContextRetVal.RegisterId);
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x00090924 File Offset: 0x0008EB24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UKuroCharRenderingComponent Execute(int EntityId, UObject ContextSourceObject)
		{
			FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams* ptr = stackalloc FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecGetRenderingComponentByContextRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->ContextSourceObject = ((ContextSourceObject != null) ? ContextSourceObject.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(ptr->__Result);
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x00090984 File Offset: 0x0008EB84
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int, UObject, UKuroCharRenderingComponent> func = target as Func<int, UObject, UKuroCharRenderingComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams*)__Parameters)->ContextSourceObject);
			UKuroCharRenderingComponent ukuroCharRenderingComponent = func(((FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams*)__Parameters)->EntityId, orCreateUObjectByNativePointer);
			((FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams*)__Parameters)->__Result = ((ukuroCharRenderingComponent != null) ? ukuroCharRenderingComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04002A93 RID: 10899
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A94 RID: 10900
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByContextRetVal__DelegateSignature";

		// Token: 0x04002A95 RID: 10901
		private static int RegisterId;

		// Token: 0x02000AFB RID: 2811
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams
		{
			// Token: 0x04005B8C RID: 23436
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B8D RID: 23437
			[FieldOffset(8)]
			public IntPtr ContextSourceObject;

			// Token: 0x04005B8E RID: 23438
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02000AFC RID: 2812
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B8F RID: 23439
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
