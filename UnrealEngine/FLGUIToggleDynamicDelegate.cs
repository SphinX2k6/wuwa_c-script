using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C7 RID: 1735
	public sealed class FLGUIToggleDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009424 RID: 37924 RVA: 0x000DF73D File Offset: 0x000DD93D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIToggleDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x000DF749 File Offset: 0x000DD949
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIToggleDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIToggleDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIToggleDynamicDelegate__DelegateSignature");
			}
			return FLGUIToggleDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x000DF76C File Offset: 0x000DD96C
		public FLGUIToggleDynamicDelegate()
		{
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x000DF774 File Offset: 0x000DD974
		[NullableContext(2)]
		public FLGUIToggleDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x000DF77E File Offset: 0x000DD97E
		public FLGUIToggleDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x000DF789 File Offset: 0x000DD989
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x000DF7BB File Offset: 0x000DD9BB
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUIToggleDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIToggleDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIToggleDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIToggleDynamicDelegate.OnScriptCallback));
				}
				FLGUIToggleDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIToggleDynamicDelegate.RegisterId);
		}

		// Token: 0x0600942B RID: 37931 RVA: 0x000DF7F8 File Offset: 0x000DD9F8
		[SkipLocalsInit]
		public unsafe void Execute(bool InBool)
		{
			FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIToggleDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InBool = InBool;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x000DF838 File Offset: 0x000DDA38
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIToggleDynamicDelegate.__FLGUIToggleDynamicDelegate_DelegateParams*)__Parameters)->InBool);
		}

		// Token: 0x0400408A RID: 16522
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400408B RID: 16523
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIToggleDynamicDelegate__DelegateSignature";

		// Token: 0x0400408C RID: 16524
		private static int RegisterId;

		// Token: 0x02000EFA RID: 3834
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FLGUIToggleDynamicDelegate_DelegateParams
		{
			// Token: 0x040062BE RID: 25278
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x02000EFB RID: 3835
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062BF RID: 25279
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
