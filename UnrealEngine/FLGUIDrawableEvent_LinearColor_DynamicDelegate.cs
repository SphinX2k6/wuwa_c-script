using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000684 RID: 1668
	public sealed class FLGUIDrawableEvent_LinearColor_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009092 RID: 37010 RVA: 0x000D9296 File Offset: 0x000D7496
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_LinearColor_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x000D92A2 File Offset: 0x000D74A2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_LinearColor_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_LinearColor_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_LinearColor_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_LinearColor_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x000D92C5 File Offset: 0x000D74C5
		public FLGUIDrawableEvent_LinearColor_DynamicDelegate()
		{
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x000D92CD File Offset: 0x000D74CD
		[NullableContext(2)]
		public FLGUIDrawableEvent_LinearColor_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x000D92D7 File Offset: 0x000D74D7
		public FLGUIDrawableEvent_LinearColor_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x000D92E2 File Offset: 0x000D74E2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FLinearColor>) ?? ((Action<FLinearColor>)Delegate.CreateDelegate(typeof(Action<FLinearColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x000D9314 File Offset: 0x000D7514
		[NullableContext(1)]
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

		// Token: 0x06009099 RID: 37017 RVA: 0x000D9350 File Offset: 0x000D7550
		[SkipLocalsInit]
		public unsafe void Execute(FLinearColor value)
		{
			FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_LinearColor_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600909A RID: 37018 RVA: 0x000D9390 File Offset: 0x000D7590
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FLinearColor> action = target as Action<FLinearColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_LinearColor_DynamicDelegate.__FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F25 RID: 16165
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F26 RID: 16166
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_LinearColor_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F27 RID: 16167
		private static int RegisterId;

		// Token: 0x02000E9B RID: 3739
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDrawableEvent_LinearColor_DynamicDelegate_DelegateParams
		{
			// Token: 0x0400624A RID: 25162
			[FieldOffset(0)]
			public FLinearColor value;
		}

		// Token: 0x02000E9C RID: 3740
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400624B RID: 25163
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
