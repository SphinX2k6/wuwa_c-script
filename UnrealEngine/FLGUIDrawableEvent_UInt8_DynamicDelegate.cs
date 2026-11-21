using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200068A RID: 1674
	public sealed class FLGUIDrawableEvent_UInt8_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090C8 RID: 37064 RVA: 0x000D9A72 File Offset: 0x000D7C72
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_UInt8_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x000D9A7E File Offset: 0x000D7C7E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_UInt8_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_UInt8_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_UInt8_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_UInt8_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x000D9AA1 File Offset: 0x000D7CA1
		public FLGUIDrawableEvent_UInt8_DynamicDelegate()
		{
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x000D9AA9 File Offset: 0x000D7CA9
		[NullableContext(2)]
		public FLGUIDrawableEvent_UInt8_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x000D9AB3 File Offset: 0x000D7CB3
		public FLGUIDrawableEvent_UInt8_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x000D9ABE File Offset: 0x000D7CBE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x000D9AF0 File Offset: 0x000D7CF0
		[NullableContext(1)]
		public void Bind(Action<byte> Callback)
		{
			if (FLGUIDrawableEvent_UInt8_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_UInt8_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_UInt8_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_UInt8_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_UInt8_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_UInt8_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x000D9B2C File Offset: 0x000D7D2C
		[SkipLocalsInit]
		public unsafe void Execute(byte value)
		{
			FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_UInt8_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x000D9B6C File Offset: 0x000D7D6C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F37 RID: 16183
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F38 RID: 16184
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_UInt8_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F39 RID: 16185
		private static int RegisterId;

		// Token: 0x02000EA7 RID: 3751
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006256 RID: 25174
			[FieldOffset(0)]
			public byte value;
		}

		// Token: 0x02000EA8 RID: 3752
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006257 RID: 25175
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
