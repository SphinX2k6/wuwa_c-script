using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200054C RID: 1356
	public sealed class FDOnKSCWorldAttrChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007D15 RID: 32021 RVA: 0x000B9A6E File Offset: 0x000B7C6E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDOnKSCWorldAttrChange.StaticFunctionPtr();
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x000B9A7A File Offset: 0x000B7C7A
		private static IntPtr StaticFunctionPtr()
		{
			if (FDOnKSCWorldAttrChange._FunctionPtr == IntPtr.Zero)
			{
				FDOnKSCWorldAttrChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.DOnKSCWorldAttrChange__DelegateSignature");
			}
			return FDOnKSCWorldAttrChange._FunctionPtr;
		}

		// Token: 0x06007D17 RID: 32023 RVA: 0x000B9A9D File Offset: 0x000B7C9D
		public FDOnKSCWorldAttrChange()
		{
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x000B9AA5 File Offset: 0x000B7CA5
		[NullableContext(2)]
		public FDOnKSCWorldAttrChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x000B9AAF File Offset: 0x000B7CAF
		public FDOnKSCWorldAttrChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x000B9ABA File Offset: 0x000B7CBA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EKSC_WorldAttrType, int, int>) ?? ((Action<EKSC_WorldAttrType, int, int>)Delegate.CreateDelegate(typeof(Action<EKSC_WorldAttrType, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007D1B RID: 32027 RVA: 0x000B9AEC File Offset: 0x000B7CEC
		[NullableContext(1)]
		public void Bind(Action<EKSC_WorldAttrType, int, int> Callback)
		{
			if (FDOnKSCWorldAttrChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FDOnKSCWorldAttrChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FDOnKSCWorldAttrChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FDOnKSCWorldAttrChange.OnScriptCallback));
				}
				FDOnKSCWorldAttrChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FDOnKSCWorldAttrChange.RegisterId);
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x000B9B28 File Offset: 0x000B7D28
		[SkipLocalsInit]
		public unsafe void Execute(EKSC_WorldAttrType AttrType, int OldValue, int NewValue)
		{
			FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams* ptr = stackalloc FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FDOnKSCWorldAttrChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AttrType = AttrType;
			ptr->OldValue = OldValue;
			ptr->NewValue = NewValue;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x000B9B74 File Offset: 0x000B7D74
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKSC_WorldAttrType, int, int> action = target as Action<EKSC_WorldAttrType, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams*)__Parameters)->AttrType, ((FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams*)__Parameters)->OldValue, ((FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams*)__Parameters)->NewValue);
		}

		// Token: 0x04003575 RID: 13685
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003576 RID: 13686
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.DOnKSCWorldAttrChange__DelegateSignature";

		// Token: 0x04003577 RID: 13687
		private static int RegisterId;

		// Token: 0x02000D09 RID: 3337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FDOnKSCWorldAttrChange_DelegateParams
		{
			// Token: 0x04005F95 RID: 24469
			[FieldOffset(0)]
			public EKSC_WorldAttrType AttrType;

			// Token: 0x04005F96 RID: 24470
			[FieldOffset(4)]
			public int OldValue;

			// Token: 0x04005F97 RID: 24471
			[FieldOffset(8)]
			public int NewValue;
		}

		// Token: 0x02000D0A RID: 3338
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005F98 RID: 24472
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
