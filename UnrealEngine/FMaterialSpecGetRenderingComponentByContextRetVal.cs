using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200191F RID: 6431
	public sealed class FMaterialSpecGetRenderingComponentByContextRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DC0 RID: 97728 RVA: 0x0022F269 File Offset: 0x0022D469
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecGetRenderingComponentByContextRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017DC1 RID: 97729 RVA: 0x0022F275 File Offset: 0x0022D475
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecGetRenderingComponentByContextRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecGetRenderingComponentByContextRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByContextRetVal__DelegateSignature");
			}
			return FMaterialSpecGetRenderingComponentByContextRetVal._FunctionPtr;
		}

		// Token: 0x06017DC2 RID: 97730 RVA: 0x0022F298 File Offset: 0x0022D498
		public FMaterialSpecGetRenderingComponentByContextRetVal()
		{
		}

		// Token: 0x06017DC3 RID: 97731 RVA: 0x0022F2A0 File Offset: 0x0022D4A0
		[NullableContext(2)]
		public FMaterialSpecGetRenderingComponentByContextRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DC4 RID: 97732 RVA: 0x0022F2AA File Offset: 0x0022D4AA
		public FMaterialSpecGetRenderingComponentByContextRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DC5 RID: 97733 RVA: 0x0022F2B5 File Offset: 0x0022D4B5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int, UObject, UKuroCharRenderingComponent>) ?? ((Func<int, UObject, UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Func<int, UObject, UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DC6 RID: 97734 RVA: 0x0022F2E7 File Offset: 0x0022D4E7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017DC7 RID: 97735 RVA: 0x0022F324 File Offset: 0x0022D524
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroCharRenderingComponent Execute(int EntityId, UObject ContextSourceObject)
		{
			FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams* ptr = stackalloc FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FMaterialSpecGetRenderingComponentByContextRetVal.__FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecGetRenderingComponentByContextRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->ContextSourceObject = ((ContextSourceObject != null) ? ContextSourceObject.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(ptr->__Result);
		}

		// Token: 0x06017DC8 RID: 97736 RVA: 0x0022F384 File Offset: 0x0022D584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400CECE RID: 52942
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CECF RID: 52943
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByContextRetVal__DelegateSignature";

		// Token: 0x0400CED0 RID: 52944
		private static int RegisterId;

		// Token: 0x02002FE7 RID: 12263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FMaterialSpecGetRenderingComponentByContextRetVal_DelegateParams
		{
			// Token: 0x04016BE3 RID: 93155
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BE4 RID: 93156
			[FieldOffset(8)]
			public IntPtr ContextSourceObject;

			// Token: 0x04016BE5 RID: 93157
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02002FE8 RID: 12264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BE6 RID: 93158
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
