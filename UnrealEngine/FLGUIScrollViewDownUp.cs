using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020BD RID: 8381
	public sealed class FLGUIScrollViewDownUp : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F91E RID: 129310 RVA: 0x002EEE2E File Offset: 0x002ED02E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIScrollViewDownUp.StaticFunctionPtr();
		}

		// Token: 0x0601F91F RID: 129311 RVA: 0x002EEE3A File Offset: 0x002ED03A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIScrollViewDownUp._FunctionPtr == IntPtr.Zero)
			{
				FLGUIScrollViewDownUp._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIScrollViewDownUp__DelegateSignature");
			}
			return FLGUIScrollViewDownUp._FunctionPtr;
		}

		// Token: 0x0601F920 RID: 129312 RVA: 0x002EEE5D File Offset: 0x002ED05D
		public FLGUIScrollViewDownUp()
		{
		}

		// Token: 0x0601F921 RID: 129313 RVA: 0x002EEE65 File Offset: 0x002ED065
		[NullableContext(2)]
		public FLGUIScrollViewDownUp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F922 RID: 129314 RVA: 0x002EEE6F File Offset: 0x002ED06F
		public FLGUIScrollViewDownUp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F923 RID: 129315 RVA: 0x002EEE7A File Offset: 0x002ED07A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIPointerEventData>) ?? ((Action<ULGUIPointerEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIPointerEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F924 RID: 129316 RVA: 0x002EEEAC File Offset: 0x002ED0AC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIPointerEventData> Callback)
		{
			if (FLGUIScrollViewDownUp.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIScrollViewDownUp.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIScrollViewDownUp.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIScrollViewDownUp.OnScriptCallback));
				}
				FLGUIScrollViewDownUp.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIScrollViewDownUp.RegisterId);
		}

		// Token: 0x0601F925 RID: 129317 RVA: 0x002EEEE8 File Offset: 0x002ED0E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULGUIPointerEventData EventData)
		{
			FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams* ptr = stackalloc FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIScrollViewDownUp.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventData = ((EventData != null) ? EventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F926 RID: 129318 RVA: 0x002EEF34 File Offset: 0x002ED134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULGUIPointerEventData> action = target as Action<ULGUIPointerEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(((FLGUIScrollViewDownUp.__FLGUIScrollViewDownUp_DelegateParams*)__Parameters)->EventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040110AA RID: 69802
		internal static IntPtr _FunctionPtr;

		// Token: 0x040110AB RID: 69803
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIScrollViewDownUp__DelegateSignature";

		// Token: 0x040110AC RID: 69804
		private static int RegisterId;

		// Token: 0x020034B2 RID: 13490
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIScrollViewDownUp_DelegateParams
		{
			// Token: 0x040174BA RID: 95418
			[FieldOffset(0)]
			public IntPtr EventData;
		}

		// Token: 0x020034B3 RID: 13491
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174BB RID: 95419
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
