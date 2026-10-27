using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002053 RID: 8275
	public sealed class FLGUIDrawableEvent_LinearColor_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F424 RID: 128036 RVA: 0x002E6A1A File Offset: 0x002E4C1A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_LinearColor_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F425 RID: 128037 RVA: 0x002E6A26 File Offset: 0x002E4C26
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_LinearColor_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_LinearColor_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_LinearColor_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_LinearColor_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F426 RID: 128038 RVA: 0x002E6A49 File Offset: 0x002E4C49
		public FLGUIDrawableEvent_LinearColor_DynamicDelegate()
		{
		}

		// Token: 0x0601F427 RID: 128039 RVA: 0x002E6A51 File Offset: 0x002E4C51
		[NullableContext(2)]
		public FLGUIDrawableEvent_LinearColor_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F428 RID: 128040 RVA: 0x002E6A5B File Offset: 0x002E4C5B
		public FLGUIDrawableEvent_LinearColor_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F429 RID: 128041 RVA: 0x002E6A66 File Offset: 0x002E4C66
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FLinearColor>) ?? ((Action<FLinearColor>)Delegate.CreateDelegate(typeof(Action<FLinearColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F42A RID: 128042 RVA: 0x002E6A98 File Offset: 0x002E4C98
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FLinearColor> Callback)
		{
			if (FLGUIDrawableEvent_LinearColor_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_LinearColor_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_LinearColor_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_LinearColor_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_LinearColor_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_LinearColor_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F42B RID: 128043 RVA: 0x002E6AD4 File Offset: 0x002E4CD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FLinearColor value)
		{
			FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_LinearColor_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F42C RID: 128044 RVA: 0x002E6B14 File Offset: 0x002E4D14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FLinearColor> action = target as Action<FLinearColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010E95 RID: 69269
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E96 RID: 69270
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_LinearColor_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E97 RID: 69271
		private static int RegisterId;

		// Token: 0x02003458 RID: 13400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams
		{
			// Token: 0x0401743B RID: 95291
			[FieldOffset(0)]
			public FLinearColor value;
		}

		// Token: 0x02003459 RID: 13401
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401743C RID: 95292
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
