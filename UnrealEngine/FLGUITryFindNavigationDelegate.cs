using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C8 RID: 1736
	public sealed class FLGUITryFindNavigationDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600942D RID: 37933 RVA: 0x000DF882 File Offset: 0x000DDA82
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITryFindNavigationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x000DF88E File Offset: 0x000DDA8E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITryFindNavigationDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITryFindNavigationDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITryFindNavigationDelegate__DelegateSignature");
			}
			return FLGUITryFindNavigationDelegate._FunctionPtr;
		}

		// Token: 0x0600942F RID: 37935 RVA: 0x000DF8B1 File Offset: 0x000DDAB1
		public FLGUITryFindNavigationDelegate()
		{
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x000DF8B9 File Offset: 0x000DDAB9
		[NullableContext(2)]
		public FLGUITryFindNavigationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x000DF8C3 File Offset: 0x000DDAC3
		public FLGUITryFindNavigationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x000DF8CE File Offset: 0x000DDACE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>) ?? ((Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>)Delegate.CreateDelegate(typeof(Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x000DF900 File Offset: 0x000DDB00
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent> Callback)
		{
			if (FLGUITryFindNavigationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITryFindNavigationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITryFindNavigationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITryFindNavigationDelegate.OnScriptCallback));
				}
				FLGUITryFindNavigationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITryFindNavigationDelegate.RegisterId);
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x000DF93C File Offset: 0x000DDB3C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USceneComponent Execute(ELGUINavigationDirection direction, UUISelectableComponent SelectableComponent)
		{
			FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams* ptr = stackalloc FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITryFindNavigationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->direction = direction;
			ptr->SelectableComponent = ((SelectableComponent != null) ? SelectableComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ptr->__Result);
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x000DF99C File Offset: 0x000DDB9C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent> func = target as Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUISelectableComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(((FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams*)__Parameters)->SelectableComponent);
			USceneComponent usceneComponent = func(((FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams*)__Parameters)->direction, orCreateUObjectByNativePointer);
			((FLGUITryFindNavigationDelegate.__FLGUITryFindNavigationDelegate_DelegateParams*)__Parameters)->__Result = ((usceneComponent != null) ? usceneComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400408D RID: 16525
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400408E RID: 16526
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITryFindNavigationDelegate__DelegateSignature";

		// Token: 0x0400408F RID: 16527
		private static int RegisterId;

		// Token: 0x02000EFC RID: 3836
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FLGUITryFindNavigationDelegate_DelegateParams
		{
			// Token: 0x040062C0 RID: 25280
			[FieldOffset(0)]
			public ELGUINavigationDirection direction;

			// Token: 0x040062C1 RID: 25281
			[FieldOffset(8)]
			public IntPtr SelectableComponent;

			// Token: 0x040062C2 RID: 25282
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02000EFD RID: 3837
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062C3 RID: 25283
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
