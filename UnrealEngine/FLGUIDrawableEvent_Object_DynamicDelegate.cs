using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000685 RID: 1669
	public sealed class FLGUIDrawableEvent_Object_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600909B RID: 37019 RVA: 0x000D93DA File Offset: 0x000D75DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Object_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600909C RID: 37020 RVA: 0x000D93E6 File Offset: 0x000D75E6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Object_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Object_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Object_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Object_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x000D9409 File Offset: 0x000D7609
		public FLGUIDrawableEvent_Object_DynamicDelegate()
		{
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x000D9411 File Offset: 0x000D7611
		[NullableContext(2)]
		public FLGUIDrawableEvent_Object_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600909F RID: 37023 RVA: 0x000D941B File Offset: 0x000D761B
		public FLGUIDrawableEvent_Object_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090A0 RID: 37024 RVA: 0x000D9426 File Offset: 0x000D7626
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UObject>) ?? ((Action<UObject>)Delegate.CreateDelegate(typeof(Action<UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x000D9458 File Offset: 0x000D7658
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

		// Token: 0x060090A2 RID: 37026 RVA: 0x000D9494 File Offset: 0x000D7694
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UObject value)
		{
			FLGUIDrawableEvent_Object_DynamicDelegate.__FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Object_DynamicDelegate.__FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Object_DynamicDelegate.__FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Object_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = ((value != null) ? value.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x000D94E0 File Offset: 0x000D76E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003F28 RID: 16168
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F29 RID: 16169
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Object_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F2A RID: 16170
		private static int RegisterId;

		// Token: 0x02000E9D RID: 3741
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIDrawableEvent_Object_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400624C RID: 25164
			[FieldOffset(0)]
			public IntPtr value;
		}

		// Token: 0x02000E9E RID: 3742
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400624D RID: 25165
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
