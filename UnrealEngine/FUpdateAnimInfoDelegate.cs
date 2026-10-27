using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001687 RID: 5767
	public sealed class FUpdateAnimInfoDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014ED6 RID: 85718 RVA: 0x001EC31C File Offset: 0x001EA51C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUpdateAnimInfoDelegate.StaticFunctionPtr();
		}

		// Token: 0x06014ED7 RID: 85719 RVA: 0x001EC328 File Offset: 0x001EA528
		private static IntPtr StaticFunctionPtr()
		{
			if (FUpdateAnimInfoDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUpdateAnimInfoDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAnim.UpdateAnimInfoDelegate__DelegateSignature");
			}
			return FUpdateAnimInfoDelegate._FunctionPtr;
		}

		// Token: 0x06014ED8 RID: 85720 RVA: 0x001EC34B File Offset: 0x001EA54B
		public FUpdateAnimInfoDelegate()
		{
		}

		// Token: 0x06014ED9 RID: 85721 RVA: 0x001EC353 File Offset: 0x001EA553
		[NullableContext(2)]
		public FUpdateAnimInfoDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014EDA RID: 85722 RVA: 0x001EC35D File Offset: 0x001EA55D
		public FUpdateAnimInfoDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014EDB RID: 85723 RVA: 0x001EC368 File Offset: 0x001EA568
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014EDC RID: 85724 RVA: 0x001EC39A File Offset: 0x001EA59A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int> Callback)
		{
			if (FUpdateAnimInfoDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUpdateAnimInfoDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUpdateAnimInfoDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUpdateAnimInfoDelegate.OnScriptCallback));
				}
				FUpdateAnimInfoDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUpdateAnimInfoDelegate.RegisterId);
		}

		// Token: 0x06014EDD RID: 85725 RVA: 0x001EC3D4 File Offset: 0x001EA5D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int EntityId)
		{
			FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams* ptr = stackalloc FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUpdateAnimInfoDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06014EDE RID: 85726 RVA: 0x001EC414 File Offset: 0x001EA614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FUpdateAnimInfoDelegate.__FUpdateAnimInfoDelegate_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x0400B669 RID: 46697
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B66A RID: 46698
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.UpdateAnimInfoDelegate__DelegateSignature";

		// Token: 0x0400B66B RID: 46699
		private static int RegisterId;

		// Token: 0x02002EDB RID: 11995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FUpdateAnimInfoDelegate_DelegateParams
		{
			// Token: 0x040169F9 RID: 92665
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x02002EDC RID: 11996
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169FA RID: 92666
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
