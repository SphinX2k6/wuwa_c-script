using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000681 RID: 1665
	public sealed class FLGUIDrawableEvent_Float_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009077 RID: 36983 RVA: 0x000D8ECA File Offset: 0x000D70CA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Float_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009078 RID: 36984 RVA: 0x000D8ED6 File Offset: 0x000D70D6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Float_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Float_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Float_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Float_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x000D8EF9 File Offset: 0x000D70F9
		public FLGUIDrawableEvent_Float_DynamicDelegate()
		{
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x000D8F01 File Offset: 0x000D7101
		[NullableContext(2)]
		public FLGUIDrawableEvent_Float_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x000D8F0B File Offset: 0x000D710B
		public FLGUIDrawableEvent_Float_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x000D8F16 File Offset: 0x000D7116
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x000D8F48 File Offset: 0x000D7148
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUIDrawableEvent_Float_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Float_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Float_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Float_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Float_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Float_DynamicDelegate.RegisterId);
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x000D8F84 File Offset: 0x000D7184
		[SkipLocalsInit]
		public unsafe void Execute(float value)
		{
			FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Float_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x000D8FC4 File Offset: 0x000D71C4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Float_DynamicDelegate.__FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F1C RID: 16156
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F1D RID: 16157
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Float_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F1E RID: 16158
		private static int RegisterId;

		// Token: 0x02000E95 RID: 3733
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLGUIDrawableEvent_Float_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006244 RID: 25156
			[FieldOffset(0)]
			public float value;
		}

		// Token: 0x02000E96 RID: 3734
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006245 RID: 25157
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
