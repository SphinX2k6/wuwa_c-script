using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200067E RID: 1662
	public sealed class FLGUIDrawableEvent_Class_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600905C RID: 36956 RVA: 0x000D8B3A File Offset: 0x000D6D3A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Class_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x000D8B46 File Offset: 0x000D6D46
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Class_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Class_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Class_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Class_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x000D8B69 File Offset: 0x000D6D69
		public FLGUIDrawableEvent_Class_DynamicDelegate()
		{
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x000D8B71 File Offset: 0x000D6D71
		[NullableContext(2)]
		public FLGUIDrawableEvent_Class_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x000D8B7B File Offset: 0x000D6D7B
		public FLGUIDrawableEvent_Class_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x000D8B86 File Offset: 0x000D6D86
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate) ?? ((FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x000D8BB8 File Offset: 0x000D6DB8
		[NullableContext(1)]
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

		// Token: 0x06009063 RID: 36963 RVA: 0x000D8BF4 File Offset: 0x000D6DF4
		[SkipLocalsInit]
		public unsafe void Execute(UClassStackOnlyPtr value)
		{
			FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Class_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x000D8C34 File Offset: 0x000D6E34
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate flguidrawableEvent_Class_DynamicDelegate_ScriptDelegate = target as FLGUIDrawableEvent_Class_DynamicDelegate.FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate;
			if (flguidrawableEvent_Class_DynamicDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			flguidrawableEvent_Class_DynamicDelegate_ScriptDelegate(((FLGUIDrawableEvent_Class_DynamicDelegate.__FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F13 RID: 16147
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F14 RID: 16148
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Class_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F15 RID: 16149
		private static int RegisterId;

		// Token: 0x02000E8F RID: 3727
		// (Invoke) Token: 0x0600BF27 RID: 48935
		public delegate void FLGUIDrawableEvent_Class_DynamicDelegate_ScriptDelegate(UClassStackOnlyPtr value);

		// Token: 0x02000E90 RID: 3728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIDrawableEvent_Class_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400623F RID: 25151
			[FieldOffset(0)]
			public UClassStackOnlyPtr value;
		}

		// Token: 0x02000E91 RID: 3729
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006240 RID: 25152
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
