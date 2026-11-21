using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BD RID: 1725
	public sealed class FLGUISliderDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093CB RID: 37835 RVA: 0x000DEB3A File Offset: 0x000DCD3A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISliderDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x000DEB46 File Offset: 0x000DCD46
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISliderDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISliderDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISliderDynamicDelegate__DelegateSignature");
			}
			return FLGUISliderDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x000DEB69 File Offset: 0x000DCD69
		public FLGUISliderDynamicDelegate()
		{
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x000DEB71 File Offset: 0x000DCD71
		[NullableContext(2)]
		public FLGUISliderDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x000DEB7B File Offset: 0x000DCD7B
		public FLGUISliderDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x000DEB86 File Offset: 0x000DCD86
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093D1 RID: 37841 RVA: 0x000DEBB8 File Offset: 0x000DCDB8
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FLGUISliderDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISliderDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISliderDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISliderDynamicDelegate.OnScriptCallback));
				}
				FLGUISliderDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISliderDynamicDelegate.RegisterId);
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x000DEBF4 File Offset: 0x000DCDF4
		[SkipLocalsInit]
		public unsafe void Execute(float InFloat)
		{
			FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams* ptr = stackalloc FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISliderDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InFloat = InFloat;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x000DEC34 File Offset: 0x000DCE34
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUISliderDynamicDelegate.__FLGUISliderDynamicDelegate_DelegateParams*)__Parameters)->InFloat);
		}

		// Token: 0x0400406C RID: 16492
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400406D RID: 16493
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISliderDynamicDelegate__DelegateSignature";

		// Token: 0x0400406E RID: 16494
		private static int RegisterId;

		// Token: 0x02000EEA RID: 3818
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLGUISliderDynamicDelegate_DelegateParams
		{
			// Token: 0x040062AC RID: 25260
			[FieldOffset(0)]
			public float InFloat;
		}

		// Token: 0x02000EEB RID: 3819
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062AD RID: 25261
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
