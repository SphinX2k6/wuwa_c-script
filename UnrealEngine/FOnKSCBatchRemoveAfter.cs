using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E65 RID: 7781
	public sealed class FOnKSCBatchRemoveAfter : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DA73 RID: 121459 RVA: 0x002BC7F0 File Offset: 0x002BA9F0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCBatchRemoveAfter.StaticFunctionPtr();
		}

		// Token: 0x0601DA74 RID: 121460 RVA: 0x002BC7FC File Offset: 0x002BA9FC
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCBatchRemoveAfter._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCBatchRemoveAfter._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCBatchRemoveAfter__DelegateSignature");
			}
			return FOnKSCBatchRemoveAfter._FunctionPtr;
		}

		// Token: 0x0601DA75 RID: 121461 RVA: 0x002BC81F File Offset: 0x002BAA1F
		public FOnKSCBatchRemoveAfter()
		{
		}

		// Token: 0x0601DA76 RID: 121462 RVA: 0x002BC827 File Offset: 0x002BAA27
		[NullableContext(2)]
		public FOnKSCBatchRemoveAfter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA77 RID: 121463 RVA: 0x002BC831 File Offset: 0x002BAA31
		public FOnKSCBatchRemoveAfter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA78 RID: 121464 RVA: 0x002BC83C File Offset: 0x002BAA3C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate) ?? ((FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DA79 RID: 121465 RVA: 0x002BC86E File Offset: 0x002BAA6E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate Callback)
		{
			if (FOnKSCBatchRemoveAfter.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCBatchRemoveAfter.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCBatchRemoveAfter.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCBatchRemoveAfter.OnScriptCallback));
				}
				FOnKSCBatchRemoveAfter.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCBatchRemoveAfter.RegisterId);
		}

		// Token: 0x0601DA7A RID: 121466 RVA: 0x002BC8A8 File Offset: 0x002BAAA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_RemoveContext> RemoveContext)
		{
			FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams* ptr = stackalloc FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCBatchRemoveAfter.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FKSC_RemoveContext> tarray = RemoveContext;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->RemoveContext);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FKSC_RemoveContext> tarray2 = RemoveContext;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->RemoveContext);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKSCBatchRemoveAfter._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DA7B RID: 121467 RVA: 0x002BC918 File Offset: 0x002BAB18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate fonKSCBatchRemoveAfter_ScriptDelegate = target as FOnKSCBatchRemoveAfter.FOnKSCBatchRemoveAfter_ScriptDelegate;
			if (fonKSCBatchRemoveAfter_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FKSC_RemoveContext> tarray = new TArray<FKSC_RemoveContext>(&((FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams*)__Parameters)->RemoveContext, true, true);
			fonKSCBatchRemoveAfter_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKSCBatchRemoveAfter.__FOnKSCBatchRemoveAfter_DelegateParams*)__Parameters)->RemoveContext, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04010112 RID: 65810
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010113 RID: 65811
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCBatchRemoveAfter__DelegateSignature";

		// Token: 0x04010114 RID: 65812
		private static int RegisterId;

		// Token: 0x020032B0 RID: 12976
		// (Invoke) Token: 0x06028592 RID: 165266
		public delegate void FOnKSCBatchRemoveAfter_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_RemoveContext> RemoveContext);

		// Token: 0x020032B1 RID: 12977
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnKSCBatchRemoveAfter_DelegateParams
		{
			// Token: 0x04017154 RID: 94548
			[FieldOffset(0)]
			public byte RemoveContext;
		}

		// Token: 0x020032B2 RID: 12978
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017155 RID: 94549
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
