using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002055 RID: 8277
	public sealed class FLGUIDrawableEvent_Object_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F435 RID: 128053 RVA: 0x002E6BD4 File Offset: 0x002E4DD4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Object_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F436 RID: 128054 RVA: 0x002E6BE0 File Offset: 0x002E4DE0
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Object_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Object_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Object_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Object_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F437 RID: 128055 RVA: 0x002E6C03 File Offset: 0x002E4E03
		public FLGUIDrawableEvent_Object_DynamicDelegate()
		{
		}

		// Token: 0x0601F438 RID: 128056 RVA: 0x002E6C0B File Offset: 0x002E4E0B
		[NullableContext(2)]
		public FLGUIDrawableEvent_Object_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F439 RID: 128057 RVA: 0x002E6C15 File Offset: 0x002E4E15
		public FLGUIDrawableEvent_Object_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F43A RID: 128058 RVA: 0x002E6C20 File Offset: 0x002E4E20
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UObject>) ?? ((Action<UObject>)Delegate.CreateDelegate(typeof(Action<UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F43B RID: 128059 RVA: 0x002E6C52 File Offset: 0x002E4E52
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			if (FLGUIDrawableEvent_Object_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Object_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Object_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Object_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Object_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Object_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F43C RID: 128060 RVA: 0x002E6C8C File Offset: 0x002E4E8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UObject value)
		{
			FLGUIDrawableEvent_Object_DynamicDelegate.__FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Object_DynamicDelegate.__FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Object_DynamicDelegate.__FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Object_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = ((value != null) ? value.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F43D RID: 128061 RVA: 0x002E6CD8 File Offset: 0x002E4ED8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject> action = target as Action<UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FLGUIDrawableEvent_Object_DynamicDelegate.__FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams*)__Parameters)->value);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04010E9A RID: 69274
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E9B RID: 69275
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Object_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E9C RID: 69276
		private static int RegisterId;

		// Token: 0x0200345A RID: 13402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams
		{
			// Token: 0x0401743D RID: 95293
			[FieldOffset(0)]
			public IntPtr value;
		}

		// Token: 0x0200345B RID: 13403
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401743E RID: 95294
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
