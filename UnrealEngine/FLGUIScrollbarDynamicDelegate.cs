using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B7 RID: 1719
	public sealed class FLGUIScrollbarDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009395 RID: 37781 RVA: 0x000DE36F File Offset: 0x000DC56F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollbarDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x000DE37B File Offset: 0x000DC57B
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollbarDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollbarDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollbarDynamicDelegate__DelegateSignature");
			}
			return FLGUIScrollbarDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x000DE39E File Offset: 0x000DC59E
		public FLGUIScrollbarDynamicDelegate()
		{
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x000DE3A6 File Offset: 0x000DC5A6
		[NullableContext(2)]
		public FLGUIScrollbarDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x000DE3B0 File Offset: 0x000DC5B0
		public FLGUIScrollbarDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x000DE3BB File Offset: 0x000DC5BB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600939B RID: 37787 RVA: 0x000DE3ED File Offset: 0x000DC5ED
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUIScrollbarDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollbarDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollbarDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollbarDynamicDelegate.OnScriptCallback));
				}
				FLGUIScrollbarDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollbarDynamicDelegate.RegisterId);
		}

		// Token: 0x0600939C RID: 37788 RVA: 0x000DE428 File Offset: 0x000DC628
		[SkipLocalsInit]
		public unsafe void Execute(float InFloat)
		{
			FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollbarDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InFloat = InFloat;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x000DE468 File Offset: 0x000DC668
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIScrollbarDynamicDelegate.__FLGUIScrollbarDynamicDelegate_DelegateParams*)__Parameters)->InFloat);
		}

		// Token: 0x0400405A RID: 16474
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400405B RID: 16475
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollbarDynamicDelegate__DelegateSignature";

		// Token: 0x0400405C RID: 16476
		private static int RegisterId;

		// Token: 0x02000EDE RID: 3806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLGUIScrollbarDynamicDelegate_DelegateParams
		{
			// Token: 0x0400629F RID: 25247
			[FieldOffset(0)]
			public float InFloat;
		}

		// Token: 0x02000EDF RID: 3807
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062A0 RID: 25248
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
