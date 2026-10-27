using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E63 RID: 7779
	public sealed class FOnKSCAllAttrChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DA61 RID: 121441 RVA: 0x002BC546 File Offset: 0x002BA746
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCAllAttrChange.StaticFunctionPtr();
		}

		// Token: 0x0601DA62 RID: 121442 RVA: 0x002BC552 File Offset: 0x002BA752
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCAllAttrChange._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCAllAttrChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCAllAttrChange__DelegateSignature");
			}
			return FOnKSCAllAttrChange._FunctionPtr;
		}

		// Token: 0x0601DA63 RID: 121443 RVA: 0x002BC575 File Offset: 0x002BA775
		public FOnKSCAllAttrChange()
		{
		}

		// Token: 0x0601DA64 RID: 121444 RVA: 0x002BC57D File Offset: 0x002BA77D
		[NullableContext(2)]
		public FOnKSCAllAttrChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA65 RID: 121445 RVA: 0x002BC587 File Offset: 0x002BA787
		public FOnKSCAllAttrChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA66 RID: 121446 RVA: 0x002BC592 File Offset: 0x002BA792
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EKSC_AttrType, int, int>) ?? ((Action<EKSC_AttrType, int, int>)Delegate.CreateDelegate(typeof(Action<EKSC_AttrType, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DA67 RID: 121447 RVA: 0x002BC5C4 File Offset: 0x002BA7C4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<EKSC_AttrType, int, int> Callback)
		{
			if (FOnKSCAllAttrChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCAllAttrChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCAllAttrChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCAllAttrChange.OnScriptCallback));
				}
				FOnKSCAllAttrChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCAllAttrChange.RegisterId);
		}

		// Token: 0x0601DA68 RID: 121448 RVA: 0x002BC600 File Offset: 0x002BA800
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EKSC_AttrType AttrType, int OldValue, int NewValue)
		{
			FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams* ptr = stackalloc FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCAllAttrChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AttrType = AttrType;
			ptr->OldValue = OldValue;
			ptr->NewValue = NewValue;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601DA69 RID: 121449 RVA: 0x002BC64C File Offset: 0x002BA84C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKSC_AttrType, int, int> action = target as Action<EKSC_AttrType, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams*)__Parameters)->AttrType, ((FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams*)__Parameters)->OldValue, ((FOnKSCAllAttrChange.__FOnKSCAllAttrChange_DelegateParams*)__Parameters)->NewValue);
		}

		// Token: 0x0401010C RID: 65804
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401010D RID: 65805
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCAllAttrChange__DelegateSignature";

		// Token: 0x0401010E RID: 65806
		private static int RegisterId;

		// Token: 0x020032AC RID: 12972
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnKSCAllAttrChange_DelegateParams
		{
			// Token: 0x0401714D RID: 94541
			[FieldOffset(0)]
			public EKSC_AttrType AttrType;

			// Token: 0x0401714E RID: 94542
			[FieldOffset(4)]
			public int OldValue;

			// Token: 0x0401714F RID: 94543
			[FieldOffset(8)]
			public int NewValue;
		}

		// Token: 0x020032AD RID: 12973
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017150 RID: 94544
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
