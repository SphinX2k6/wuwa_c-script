using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F3 RID: 1779
	public sealed class FUIDropdownComponentShowHideDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600973A RID: 38714 RVA: 0x000E428E File Offset: 0x000E248E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIDropdownComponentShowHideDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x000E429A File Offset: 0x000E249A
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIDropdownComponentShowHideDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUIDropdownComponentShowHideDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIDropdownComponentShowHideDynamicDelegate__DelegateSignature");
			}
			return FUIDropdownComponentShowHideDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600973C RID: 38716 RVA: 0x000E42BD File Offset: 0x000E24BD
		public FUIDropdownComponentShowHideDynamicDelegate()
		{
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x000E42C5 File Offset: 0x000E24C5
		[NullableContext(2)]
		public FUIDropdownComponentShowHideDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x000E42CF File Offset: 0x000E24CF
		public FUIDropdownComponentShowHideDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600973F RID: 38719 RVA: 0x000E42DA File Offset: 0x000E24DA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x000E430C File Offset: 0x000E250C
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FUIDropdownComponentShowHideDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIDropdownComponentShowHideDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIDropdownComponentShowHideDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIDropdownComponentShowHideDynamicDelegate.OnScriptCallback));
				}
				FUIDropdownComponentShowHideDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIDropdownComponentShowHideDynamicDelegate.RegisterId);
		}

		// Token: 0x06009741 RID: 38721 RVA: 0x000E4348 File Offset: 0x000E2548
		[SkipLocalsInit]
		public unsafe void Execute(bool IsShow)
		{
			FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams* ptr = stackalloc FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIDropdownComponentShowHideDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsShow = IsShow;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009742 RID: 38722 RVA: 0x000E4388 File Offset: 0x000E2588
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FUIDropdownComponentShowHideDynamicDelegate.__FUIDropdownComponentShowHideDynamicDelegate_DelegateParams*)__Parameters)->IsShow);
		}

		// Token: 0x040041CD RID: 16845
		internal static IntPtr _FunctionPtr;

		// Token: 0x040041CE RID: 16846
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIDropdownComponentShowHideDynamicDelegate__DelegateSignature";

		// Token: 0x040041CF RID: 16847
		private static int RegisterId;

		// Token: 0x02000F18 RID: 3864
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FUIDropdownComponentShowHideDynamicDelegate_DelegateParams
		{
			// Token: 0x040062E7 RID: 25319
			[FieldOffset(0)]
			public bool IsShow;
		}

		// Token: 0x02000F19 RID: 3865
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062E8 RID: 25320
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
