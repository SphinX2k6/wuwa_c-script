using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000687 RID: 1671
	public sealed class FLGUIDrawableEvent_Quaternion_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060090AD RID: 37037 RVA: 0x000D9689 File Offset: 0x000D7889
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Quaternion_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x000D9695 File Offset: 0x000D7895
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Quaternion_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Quaternion_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Quaternion_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Quaternion_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x060090AF RID: 37039 RVA: 0x000D96B8 File Offset: 0x000D78B8
		public FLGUIDrawableEvent_Quaternion_DynamicDelegate()
		{
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x000D96C0 File Offset: 0x000D78C0
		[NullableContext(2)]
		public FLGUIDrawableEvent_Quaternion_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x000D96CA File Offset: 0x000D78CA
		public FLGUIDrawableEvent_Quaternion_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060090B2 RID: 37042 RVA: 0x000D96D5 File Offset: 0x000D78D5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FQuat>) ?? ((Action<FQuat>)Delegate.CreateDelegate(typeof(Action<FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x000D9707 File Offset: 0x000D7907
		[NullableContext(1)]
		public void Bind(Action<FQuat> Callback)
		{
			if (FLGUIDrawableEvent_Quaternion_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Quaternion_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Quaternion_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Quaternion_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Quaternion_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Quaternion_DynamicDelegate.RegisterId);
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x000D9744 File Offset: 0x000D7944
		[SkipLocalsInit]
		public unsafe void Execute(FQuat value)
		{
			FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Quaternion_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060090B5 RID: 37045 RVA: 0x000D9784 File Offset: 0x000D7984
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FQuat> action = target as Action<FQuat>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F2E RID: 16174
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F2F RID: 16175
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Quaternion_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F30 RID: 16176
		private static int RegisterId;

		// Token: 0x02000EA1 RID: 3745
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006250 RID: 25168
			[FieldOffset(0)]
			public FQuat value;
		}

		// Token: 0x02000EA2 RID: 3746
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006251 RID: 25169
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
