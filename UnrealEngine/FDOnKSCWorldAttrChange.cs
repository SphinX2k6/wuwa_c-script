using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CB3 RID: 7347
	public sealed class FDOnKSCWorldAttrChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C7D8 RID: 116696 RVA: 0x002A20BA File Offset: 0x002A02BA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDOnKSCWorldAttrChange.StaticFunctionPtr();
		}

		// Token: 0x0601C7D9 RID: 116697 RVA: 0x002A20C6 File Offset: 0x002A02C6
		private static IntPtr StaticFunctionPtr()
		{
			if (FDOnKSCWorldAttrChange._FunctionPtr == IntPtr.Zero)
			{
				FDOnKSCWorldAttrChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.DOnKSCWorldAttrChange__DelegateSignature");
			}
			return FDOnKSCWorldAttrChange._FunctionPtr;
		}

		// Token: 0x0601C7DA RID: 116698 RVA: 0x002A20E9 File Offset: 0x002A02E9
		public FDOnKSCWorldAttrChange()
		{
		}

		// Token: 0x0601C7DB RID: 116699 RVA: 0x002A20F1 File Offset: 0x002A02F1
		[NullableContext(2)]
		public FDOnKSCWorldAttrChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7DC RID: 116700 RVA: 0x002A20FB File Offset: 0x002A02FB
		public FDOnKSCWorldAttrChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7DD RID: 116701 RVA: 0x002A2106 File Offset: 0x002A0306
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EKSC_WorldAttrType, int, int>) ?? ((Action<EKSC_WorldAttrType, int, int>)Delegate.CreateDelegate(typeof(Action<EKSC_WorldAttrType, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C7DE RID: 116702 RVA: 0x002A2138 File Offset: 0x002A0338
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601C7DF RID: 116703 RVA: 0x002A2174 File Offset: 0x002A0374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EKSC_WorldAttrType AttrType, int OldValue, int NewValue)
		{
			FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams* ptr = stackalloc FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FDOnKSCWorldAttrChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AttrType = AttrType;
			ptr->OldValue = OldValue;
			ptr->NewValue = NewValue;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601C7E0 RID: 116704 RVA: 0x002A21C0 File Offset: 0x002A03C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKSC_WorldAttrType, int, int> action = target as Action<EKSC_WorldAttrType, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams*)__Parameters)->AttrType, ((FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams*)__Parameters)->OldValue, ((FDOnKSCWorldAttrChange.__FDOnKSCWorldAttrChange_DelegateParams*)__Parameters)->NewValue);
		}

		// Token: 0x0400F50B RID: 62731
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F50C RID: 62732
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.DOnKSCWorldAttrChange__DelegateSignature";

		// Token: 0x0400F50D RID: 62733
		private static int RegisterId;

		// Token: 0x02003294 RID: 12948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FDOnKSCWorldAttrChange_DelegateParams
		{
			// Token: 0x04017121 RID: 94497
			[FieldOffset(0)]
			public EKSC_WorldAttrType AttrType;

			// Token: 0x04017122 RID: 94498
			[FieldOffset(4)]
			public int OldValue;

			// Token: 0x04017123 RID: 94499
			[FieldOffset(8)]
			public int NewValue;
		}

		// Token: 0x02003295 RID: 12949
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017124 RID: 94500
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
