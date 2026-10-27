using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C0 RID: 8384
	public sealed class FLGUISelfInteractiveDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F939 RID: 129337 RVA: 0x002EF22F File Offset: 0x002ED42F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISelfInteractiveDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F93A RID: 129338 RVA: 0x002EF23B File Offset: 0x002ED43B
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISelfInteractiveDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISelfInteractiveDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISelfInteractiveDelegate__DelegateSignature");
			}
			return FLGUISelfInteractiveDelegate._FunctionPtr;
		}

		// Token: 0x0601F93B RID: 129339 RVA: 0x002EF25E File Offset: 0x002ED45E
		public FLGUISelfInteractiveDelegate()
		{
		}

		// Token: 0x0601F93C RID: 129340 RVA: 0x002EF266 File Offset: 0x002ED466
		[NullableContext(2)]
		public FLGUISelfInteractiveDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F93D RID: 129341 RVA: 0x002EF270 File Offset: 0x002ED470
		public FLGUISelfInteractiveDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F93E RID: 129342 RVA: 0x002EF27B File Offset: 0x002ED47B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F93F RID: 129343 RVA: 0x002EF2AD File Offset: 0x002ED4AD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FLGUISelfInteractiveDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISelfInteractiveDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISelfInteractiveDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISelfInteractiveDelegate.OnScriptCallback));
				}
				FLGUISelfInteractiveDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISelfInteractiveDelegate.RegisterId);
		}

		// Token: 0x0601F940 RID: 129344 RVA: 0x002EF2E8 File Offset: 0x002ED4E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool CurrentSelfInteractive)
		{
			FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams* ptr = stackalloc FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISelfInteractiveDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentSelfInteractive = CurrentSelfInteractive;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F941 RID: 129345 RVA: 0x002EF328 File Offset: 0x002ED528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUISelfInteractiveDelegate.__FLGUISelfInteractiveDelegate_DelegateParams*)__Parameters)->CurrentSelfInteractive);
		}

		// Token: 0x040110B3 RID: 69811
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110B4 RID: 69812
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISelfInteractiveDelegate__DelegateSignature";

		// Token: 0x040110B5 RID: 69813
		private static int RegisterId;

		// Token: 0x020034B8 RID: 13496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUISelfInteractiveDelegate_DelegateParams
		{
			// Token: 0x040174C1 RID: 95425
			[FieldOffset(0)]
			public bool CurrentSelfInteractive;
		}

		// Token: 0x020034B9 RID: 13497
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174C2 RID: 95426
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
