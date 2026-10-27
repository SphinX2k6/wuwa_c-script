using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002068 RID: 8296
	public sealed class FLGUIDrawableEvent_Vector4_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4D5 RID: 128213 RVA: 0x002E7B3C File Offset: 0x002E5D3C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Vector4_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4D6 RID: 128214 RVA: 0x002E7B48 File Offset: 0x002E5D48
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Vector4_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Vector4_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Vector4_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Vector4_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F4D7 RID: 128215 RVA: 0x002E7B6B File Offset: 0x002E5D6B
		public FLGUIDrawableEvent_Vector4_DynamicDelegate()
		{
		}

		// Token: 0x0601F4D8 RID: 128216 RVA: 0x002E7B73 File Offset: 0x002E5D73
		[NullableContext(2)]
		public FLGUIDrawableEvent_Vector4_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4D9 RID: 128217 RVA: 0x002E7B7D File Offset: 0x002E5D7D
		public FLGUIDrawableEvent_Vector4_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4DA RID: 128218 RVA: 0x002E7B88 File Offset: 0x002E5D88
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector4>) ?? ((Action<FVector4>)Delegate.CreateDelegate(typeof(Action<FVector4>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4DB RID: 128219 RVA: 0x002E7BBA File Offset: 0x002E5DBA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FVector4> Callback)
		{
			if (FLGUIDrawableEvent_Vector4_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Vector4_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Vector4_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Vector4_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Vector4_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Vector4_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F4DC RID: 128220 RVA: 0x002E7BF4 File Offset: 0x002E5DF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FVector4 value)
		{
			FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Vector4_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F4DD RID: 128221 RVA: 0x002E7C34 File Offset: 0x002E5E34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector4> action = target as Action<FVector4>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Vector4_DynamicDelegate.__FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010EC8 RID: 69320
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EC9 RID: 69321
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Vector4_DynamicDelegate__DelegateSignature";

		// Token: 0x04010ECA RID: 69322
		private static int RegisterId;

		// Token: 0x0200346A RID: 13418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDrawableEvent_Vector4_DynamicDelegate_DelegateParams
		{
			// Token: 0x0401744D RID: 95309
			[FieldOffset(0)]
			public FVector4 value;
		}

		// Token: 0x0200346B RID: 13419
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401744E RID: 95310
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
