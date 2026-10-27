using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002044 RID: 8260
	public sealed class FLGUIDrawableEvent_Class_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F3A6 RID: 127910 RVA: 0x002E5EA0 File Offset: 0x002E40A0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Class_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F3A7 RID: 127911 RVA: 0x002E5EAC File Offset: 0x002E40AC
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Class_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Class_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Class_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Class_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F3A8 RID: 127912 RVA: 0x002E5ECF File Offset: 0x002E40CF
		public FLGUIDrawableEvent_Class_DynamicDelegate()
		{
		}

		// Token: 0x0601F3A9 RID: 127913 RVA: 0x002E5ED7 File Offset: 0x002E40D7
		[NullableContext(2)]
		public FLGUIDrawableEvent_Class_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3AA RID: 127914 RVA: 0x002E5EE1 File Offset: 0x002E40E1
		public FLGUIDrawableEvent_Class_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3AB RID: 127915 RVA: 0x002E5EEC File Offset: 0x002E40EC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate) ?? ((FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F3AC RID: 127916 RVA: 0x002E5F1E File Offset: 0x002E411E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate Callback)
		{
			if (FLGUIDrawableEvent_Class_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Class_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Class_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Class_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Class_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Class_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F3AD RID: 127917 RVA: 0x002E5F58 File Offset: 0x002E4158
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UClassStackOnlyPtr value)
		{
			FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Class_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F3AE RID: 127918 RVA: 0x002E5F98 File Offset: 0x002E4198
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate flguidrawableEvent_Class_DynamicDelegate_ScriptDelegate = target as FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate;
			if (flguidrawableEvent_Class_DynamicDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			flguidrawableEvent_Class_DynamicDelegate_ScriptDelegate(((FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010E71 RID: 69233
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E72 RID: 69234
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Class_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E73 RID: 69235
		private static int RegisterId;

		// Token: 0x0200344C RID: 13388
		// (Invoke) Token: 0x060285BE RID: 165310
		public delegate void FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate(UClassStackOnlyPtr value);

		// Token: 0x0200344D RID: 13389
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017430 RID: 95280
			[FieldOffset(0)]
			public UClassStackOnlyPtr value;
		}

		// Token: 0x0200344E RID: 13390
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017431 RID: 95281
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
