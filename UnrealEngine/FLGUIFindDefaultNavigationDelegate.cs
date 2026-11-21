using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000699 RID: 1689
	public sealed class FLGUIFindDefaultNavigationDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600919B RID: 37275 RVA: 0x000DB24F File Offset: 0x000D944F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIFindDefaultNavigationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x000DB25B File Offset: 0x000D945B
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIFindDefaultNavigationDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIFindDefaultNavigationDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIFindDefaultNavigationDelegate__DelegateSignature");
			}
			return FLGUIFindDefaultNavigationDelegate._FunctionPtr;
		}

		// Token: 0x0600919D RID: 37277 RVA: 0x000DB27E File Offset: 0x000D947E
		public FLGUIFindDefaultNavigationDelegate()
		{
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x000DB286 File Offset: 0x000D9486
		[NullableContext(2)]
		public FLGUIFindDefaultNavigationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600919F RID: 37279 RVA: 0x000DB290 File Offset: 0x000D9490
		public FLGUIFindDefaultNavigationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x000DB29B File Offset: 0x000D949B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ELGUINavigationDirection, USceneComponent>) ?? ((Func<ELGUINavigationDirection, USceneComponent>)Delegate.CreateDelegate(typeof(Func<ELGUINavigationDirection, USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x000DB2CD File Offset: 0x000D94CD
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<ELGUINavigationDirection, USceneComponent> Callback)
		{
			if (FLGUIFindDefaultNavigationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIFindDefaultNavigationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIFindDefaultNavigationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIFindDefaultNavigationDelegate.OnScriptCallback));
				}
				FLGUIFindDefaultNavigationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIFindDefaultNavigationDelegate.RegisterId);
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x000DB308 File Offset: 0x000D9508
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USceneComponent Execute(ELGUINavigationDirection direction)
		{
			FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams* ptr = stackalloc FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIFindDefaultNavigationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->direction = direction;
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ptr->__Result);
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x000DB350 File Offset: 0x000D9550
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<ELGUINavigationDirection, USceneComponent> func = target as Func<ELGUINavigationDirection, USceneComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USceneComponent usceneComponent = func(((FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams*)__Parameters)->direction);
			((FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams*)__Parameters)->__Result = ((usceneComponent != null) ? usceneComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04003F78 RID: 16248
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F79 RID: 16249
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIFindDefaultNavigationDelegate__DelegateSignature";

		// Token: 0x04003F7A RID: 16250
		private static int RegisterId;

		// Token: 0x02000EC1 RID: 3777
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIFindDefaultNavigationDelegate_DelegateParams
		{
			// Token: 0x04006278 RID: 25208
			[FieldOffset(0)]
			public ELGUINavigationDirection direction;

			// Token: 0x04006279 RID: 25209
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000EC2 RID: 3778
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400627A RID: 25210
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
