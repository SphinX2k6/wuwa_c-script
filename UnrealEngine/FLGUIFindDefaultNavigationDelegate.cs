using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002077 RID: 8311
	public sealed class FLGUIFindDefaultNavigationDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F59E RID: 128414 RVA: 0x002E9127 File Offset: 0x002E7327
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIFindDefaultNavigationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F59F RID: 128415 RVA: 0x002E9133 File Offset: 0x002E7333
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIFindDefaultNavigationDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIFindDefaultNavigationDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIFindDefaultNavigationDelegate__DelegateSignature");
			}
			return FLGUIFindDefaultNavigationDelegate._FunctionPtr;
		}

		// Token: 0x0601F5A0 RID: 128416 RVA: 0x002E9156 File Offset: 0x002E7356
		public FLGUIFindDefaultNavigationDelegate()
		{
		}

		// Token: 0x0601F5A1 RID: 128417 RVA: 0x002E915E File Offset: 0x002E735E
		[NullableContext(2)]
		public FLGUIFindDefaultNavigationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5A2 RID: 128418 RVA: 0x002E9168 File Offset: 0x002E7368
		public FLGUIFindDefaultNavigationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5A3 RID: 128419 RVA: 0x002E9173 File Offset: 0x002E7373
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<ELGUINavigationDirection, USceneComponent>) ?? ((Func<ELGUINavigationDirection, USceneComponent>)Delegate.CreateDelegate(typeof(Func<ELGUINavigationDirection, USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F5A4 RID: 128420 RVA: 0x002E91A5 File Offset: 0x002E73A5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F5A5 RID: 128421 RVA: 0x002E91E0 File Offset: 0x002E73E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USceneComponent Execute(ELGUINavigationDirection direction)
		{
			FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams* ptr = stackalloc FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIFindDefaultNavigationDelegate.__FLGUIFindDefaultNavigationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIFindDefaultNavigationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->direction = direction;
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ptr->__Result);
		}

		// Token: 0x0601F5A6 RID: 128422 RVA: 0x002E9228 File Offset: 0x002E7428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010F0B RID: 69387
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F0C RID: 69388
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIFindDefaultNavigationDelegate__DelegateSignature";

		// Token: 0x04010F0D RID: 69389
		private static int RegisterId;

		// Token: 0x0200347E RID: 13438
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIFindDefaultNavigationDelegate_DelegateParams
		{
			// Token: 0x04017469 RID: 95337
			[FieldOffset(0)]
			public ELGUINavigationDirection direction;

			// Token: 0x0401746A RID: 95338
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x0200347F RID: 13439
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401746B RID: 95339
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
