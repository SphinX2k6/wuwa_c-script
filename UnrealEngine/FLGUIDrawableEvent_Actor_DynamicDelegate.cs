using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002040 RID: 8256
	public sealed class FLGUIDrawableEvent_Actor_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F384 RID: 127876 RVA: 0x002E5B19 File Offset: 0x002E3D19
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Actor_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F385 RID: 127877 RVA: 0x002E5B25 File Offset: 0x002E3D25
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Actor_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Actor_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Actor_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Actor_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F386 RID: 127878 RVA: 0x002E5B48 File Offset: 0x002E3D48
		public FLGUIDrawableEvent_Actor_DynamicDelegate()
		{
		}

		// Token: 0x0601F387 RID: 127879 RVA: 0x002E5B50 File Offset: 0x002E3D50
		[NullableContext(2)]
		public FLGUIDrawableEvent_Actor_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F388 RID: 127880 RVA: 0x002E5B5A File Offset: 0x002E3D5A
		public FLGUIDrawableEvent_Actor_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F389 RID: 127881 RVA: 0x002E5B65 File Offset: 0x002E3D65
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F38A RID: 127882 RVA: 0x002E5B97 File Offset: 0x002E3D97
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FLGUIDrawableEvent_Actor_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Actor_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Actor_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Actor_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Actor_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Actor_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F38B RID: 127883 RVA: 0x002E5BD4 File Offset: 0x002E3DD4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(AActor value)
		{
			FLGUIDrawableEvent_Actor_DynamicDelegate.__FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Actor_DynamicDelegate.__FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Actor_DynamicDelegate.__FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Actor_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = ((value != null) ? value.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F38C RID: 127884 RVA: 0x002E5C20 File Offset: 0x002E3E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FLGUIDrawableEvent_Actor_DynamicDelegate.__FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams*)__Parameters)->value);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04010E67 RID: 69223
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E68 RID: 69224
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Actor_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E69 RID: 69225
		private static int RegisterId;

		// Token: 0x02003448 RID: 13384
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams
		{
			// Token: 0x0401742C RID: 95276
			[FieldOffset(0)]
			public IntPtr value;
		}

		// Token: 0x02003449 RID: 13385
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401742D RID: 95277
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
