using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200067C RID: 1660
	public sealed class FLGUIDrawableEvent_Actor_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600904A RID: 36938 RVA: 0x000D889E File Offset: 0x000D6A9E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Actor_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x000D88AA File Offset: 0x000D6AAA
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Actor_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Actor_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Actor_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Actor_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600904C RID: 36940 RVA: 0x000D88CD File Offset: 0x000D6ACD
		public FLGUIDrawableEvent_Actor_DynamicDelegate()
		{
		}

		// Token: 0x0600904D RID: 36941 RVA: 0x000D88D5 File Offset: 0x000D6AD5
		[NullableContext(2)]
		public FLGUIDrawableEvent_Actor_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600904E RID: 36942 RVA: 0x000D88DF File Offset: 0x000D6ADF
		public FLGUIDrawableEvent_Actor_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600904F RID: 36943 RVA: 0x000D88EA File Offset: 0x000D6AEA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x000D891C File Offset: 0x000D6B1C
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

		// Token: 0x06009051 RID: 36945 RVA: 0x000D8958 File Offset: 0x000D6B58
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(AActor value)
		{
			FLGUIDrawableEvent_Actor_DynamicDelegate.__FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Actor_DynamicDelegate.__FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Actor_DynamicDelegate.__FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Actor_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = ((value != null) ? value.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009052 RID: 36946 RVA: 0x000D89A4 File Offset: 0x000D6BA4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003F0D RID: 16141
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F0E RID: 16142
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Actor_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F0F RID: 16143
		private static int RegisterId;

		// Token: 0x02000E8B RID: 3723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIDrawableEvent_Actor_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400623B RID: 25147
			[FieldOffset(0)]
			public IntPtr value;
		}

		// Token: 0x02000E8C RID: 3724
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400623C RID: 25148
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
