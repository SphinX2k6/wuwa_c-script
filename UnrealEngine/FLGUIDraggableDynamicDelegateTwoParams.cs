using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000678 RID: 1656
	public sealed class FLGUIDraggableDynamicDelegateTwoParams : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009026 RID: 36902 RVA: 0x000D83D9 File Offset: 0x000D65D9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDraggableDynamicDelegateTwoParams.StaticFunctionPtr();
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x000D83E5 File Offset: 0x000D65E5
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDraggableDynamicDelegateTwoParams._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDraggableDynamicDelegateTwoParams._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDraggableDynamicDelegateTwoParams__DelegateSignature");
			}
			return FLGUIDraggableDynamicDelegateTwoParams._FunctionPtr;
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x000D8408 File Offset: 0x000D6608
		public FLGUIDraggableDynamicDelegateTwoParams()
		{
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x000D8410 File Offset: 0x000D6610
		[NullableContext(2)]
		public FLGUIDraggableDynamicDelegateTwoParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x000D841A File Offset: 0x000D661A
		public FLGUIDraggableDynamicDelegateTwoParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x000D8425 File Offset: 0x000D6625
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, bool>) ?? ((Action<bool, bool>)Delegate.CreateDelegate(typeof(Action<bool, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x000D8457 File Offset: 0x000D6657
		[NullableContext(1)]
		public void Bind(Action<bool, bool> Callback)
		{
			if (FLGUIDraggableDynamicDelegateTwoParams.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDraggableDynamicDelegateTwoParams.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDraggableDynamicDelegateTwoParams.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDraggableDynamicDelegateTwoParams.OnScriptCallback));
				}
				FLGUIDraggableDynamicDelegateTwoParams.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDraggableDynamicDelegateTwoParams.RegisterId);
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x000D8494 File Offset: 0x000D6694
		[SkipLocalsInit]
		public unsafe void Execute(bool PositionChanged, bool SizeChanged)
		{
			FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams* ptr = stackalloc FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams[(UIntPtr)17] + 15L / (long)sizeof(FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDraggableDynamicDelegateTwoParams.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PositionChanged = PositionChanged;
			ptr->SizeChanged = SizeChanged;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x000D84D8 File Offset: 0x000D66D8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, bool> action = target as Action<bool, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams*)__Parameters)->PositionChanged, ((FLGUIDraggableDynamicDelegateTwoParams.__FLGUIDraggableDynamicDelegateTwoParams_DelegateParams*)__Parameters)->SizeChanged);
		}

		// Token: 0x04003F01 RID: 16129
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F02 RID: 16130
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDraggableDynamicDelegateTwoParams__DelegateSignature";

		// Token: 0x04003F03 RID: 16131
		private static int RegisterId;

		// Token: 0x02000E85 RID: 3717
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		private ref struct __FLGUIDraggableDynamicDelegateTwoParams_DelegateParams
		{
			// Token: 0x04006233 RID: 25139
			[FieldOffset(0)]
			public bool PositionChanged;

			// Token: 0x04006234 RID: 25140
			[FieldOffset(1)]
			public bool SizeChanged;
		}

		// Token: 0x02000E86 RID: 3718
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006235 RID: 25141
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
