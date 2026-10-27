using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002066 RID: 8294
	public sealed class FLGUIDrawableEvent_Vector3_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4C4 RID: 128196 RVA: 0x002E7984 File Offset: 0x002E5B84
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Vector3_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4C5 RID: 128197 RVA: 0x002E7990 File Offset: 0x002E5B90
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Vector3_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Vector3_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Vector3_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Vector3_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F4C6 RID: 128198 RVA: 0x002E79B3 File Offset: 0x002E5BB3
		public FLGUIDrawableEvent_Vector3_DynamicDelegate()
		{
		}

		// Token: 0x0601F4C7 RID: 128199 RVA: 0x002E79BB File Offset: 0x002E5BBB
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector3_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4C8 RID: 128200 RVA: 0x002E79C5 File Offset: 0x002E5BC5
		public FLGUIDrawableEvent_Vector3_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4C9 RID: 128201 RVA: 0x002E79D0 File Offset: 0x002E5BD0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4CA RID: 128202 RVA: 0x002E7A02 File Offset: 0x002E5C02
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FVector> Callback)
		{
			if (FLGUIDrawableEvent_Vector3_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Vector3_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Vector3_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Vector3_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Vector3_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Vector3_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F4CB RID: 128203 RVA: 0x002E7A3C File Offset: 0x002E5C3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FVector value)
		{
			FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Vector3_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F4CC RID: 128204 RVA: 0x002E7A7C File Offset: 0x002E5C7C
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
			action(((FLGUIDrawableEvent_Vector3_DynamicDelegate.__FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010EC3 RID: 69315
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EC4 RID: 69316
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector3_DynamicDelegate__DelegateSignature";

		// Token: 0x04010EC5 RID: 69317
		private static int RegisterId;

		// Token: 0x02003468 RID: 13416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FLGUIDrawableEvent_Vector3_DynamicDelegate_DelegateParams
		{
			// Token: 0x0401744B RID: 95307
			[FieldOffset(0)]
			public FVector value;
		}

		// Token: 0x02003469 RID: 13417
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401744C RID: 95308
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
