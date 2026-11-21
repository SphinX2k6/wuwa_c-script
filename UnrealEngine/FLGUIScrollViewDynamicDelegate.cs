using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B9 RID: 1721
	public sealed class FLGUIScrollViewDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093A7 RID: 37799 RVA: 0x000DE609 File Offset: 0x000DC809
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollViewDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x000DE615 File Offset: 0x000DC815
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollViewDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollViewDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollViewDynamicDelegate__DelegateSignature");
			}
			return FLGUIScrollViewDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x000DE638 File Offset: 0x000DC838
		public FLGUIScrollViewDynamicDelegate()
		{
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x000DE640 File Offset: 0x000DC840
		[NullableContext(2)]
		public FLGUIScrollViewDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x000DE64A File Offset: 0x000DC84A
		public FLGUIScrollViewDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x000DE655 File Offset: 0x000DC855
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FVector2D>) ?? ((Action<FVector2D>)Delegate.CreateDelegate(typeof(Action<FVector2D>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x000DE687 File Offset: 0x000DC887
		[NullableContext(1)]
		public void Bind(Action<FVector2D> Callback)
		{
			if (FLGUIScrollViewDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollViewDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollViewDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollViewDynamicDelegate.OnScriptCallback));
				}
				FLGUIScrollViewDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollViewDynamicDelegate.RegisterId);
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x000DE6C4 File Offset: 0x000DC8C4
		[SkipLocalsInit]
		public unsafe void Execute(FVector2D InVector2)
		{
			FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollViewDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InVector2 = InVector2;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x000DE704 File Offset: 0x000DC904
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector2D> action = target as Action<FVector2D>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIScrollViewDynamicDelegate.__FLGUIScrollViewDynamicDelegate_DelegateParams*)__Parameters)->InVector2);
		}

		// Token: 0x04004060 RID: 16480
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004061 RID: 16481
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollViewDynamicDelegate__DelegateSignature";

		// Token: 0x04004062 RID: 16482
		private static int RegisterId;

		// Token: 0x02000EE2 RID: 3810
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FLGUIScrollViewDynamicDelegate_DelegateParams
		{
			// Token: 0x040062A3 RID: 25251
			[FieldOffset(0)]
			public FVector2D InVector2;
		}

		// Token: 0x02000EE3 RID: 3811
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062A4 RID: 25252
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
