using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002269 RID: 8809
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMagtAPOnAdviceChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060217B0 RID: 137136 RVA: 0x00317488 File Offset: 0x00315688
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMagtAPOnAdviceChanged.StaticFunctionPtr();
		}

		// Token: 0x060217B1 RID: 137137 RVA: 0x00317494 File Offset: 0x00315694
		private static IntPtr StaticFunctionPtr()
		{
			if (FMagtAPOnAdviceChanged._FunctionPtr == IntPtr.Zero)
			{
				FMagtAPOnAdviceChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MagtModule.MagtAPOnAdviceChanged__DelegateSignature");
			}
			return FMagtAPOnAdviceChanged._FunctionPtr;
		}

		// Token: 0x060217B2 RID: 137138 RVA: 0x003174B7 File Offset: 0x003156B7
		public FMagtAPOnAdviceChanged()
		{
		}

		// Token: 0x060217B3 RID: 137139 RVA: 0x003174BF File Offset: 0x003156BF
		[NullableContext(2)]
		public FMagtAPOnAdviceChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060217B4 RID: 137140 RVA: 0x003174C9 File Offset: 0x003156C9
		public FMagtAPOnAdviceChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060217B5 RID: 137141 RVA: 0x003174D4 File Offset: 0x003156D4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EMagtAPWorkloadAdvice, EMagtAPWorkloadAdvice>) ?? ((Action<EMagtAPWorkloadAdvice, EMagtAPWorkloadAdvice>)Delegate.CreateDelegate(typeof(Action<EMagtAPWorkloadAdvice, EMagtAPWorkloadAdvice>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060217B6 RID: 137142 RVA: 0x00317506 File Offset: 0x00315706
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EMagtAPWorkloadAdvice, EMagtAPWorkloadAdvice> Callback)
		{
			if (FMagtAPOnAdviceChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMagtAPOnAdviceChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMagtAPOnAdviceChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMagtAPOnAdviceChanged.OnScriptCallback));
				}
				FMagtAPOnAdviceChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMagtAPOnAdviceChanged.RegisterId);
		}

		// Token: 0x060217B7 RID: 137143 RVA: 0x00317540 File Offset: 0x00315740
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EMagtAPWorkloadAdvice, EMagtAPWorkloadAdvice> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060217B8 RID: 137144 RVA: 0x0031754C File Offset: 0x0031574C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EMagtAPWorkloadAdvice OldAdvice, EMagtAPWorkloadAdvice NewAdvice)
		{
			FMagtAPOnAdviceChanged.__FMagtAPOnAdviceChanged_DelegateParams* ptr = stackalloc FMagtAPOnAdviceChanged.__FMagtAPOnAdviceChanged_DelegateParams[(UIntPtr)17] + 15L / (long)sizeof(FMagtAPOnAdviceChanged.__FMagtAPOnAdviceChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMagtAPOnAdviceChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OldAdvice = OldAdvice;
			ptr->NewAdvice = NewAdvice;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060217B9 RID: 137145 RVA: 0x00317590 File Offset: 0x00315790
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EMagtAPWorkloadAdvice, EMagtAPWorkloadAdvice> action = target as Action<EMagtAPWorkloadAdvice, EMagtAPWorkloadAdvice>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FMagtAPOnAdviceChanged.__FMagtAPOnAdviceChanged_DelegateParams*)__Parameters)->OldAdvice, ((FMagtAPOnAdviceChanged.__FMagtAPOnAdviceChanged_DelegateParams*)__Parameters)->NewAdvice);
		}

		// Token: 0x04011E08 RID: 73224
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011E09 RID: 73225
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtAPOnAdviceChanged__DelegateSignature";

		// Token: 0x04011E0A RID: 73226
		private static int RegisterId;

		// Token: 0x020035A9 RID: 13737
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __FMagtAPOnAdviceChanged_DelegateParams
		{
			// Token: 0x040175E5 RID: 95717
			[FieldOffset(0)]
			public EMagtAPWorkloadAdvice OldAdvice;

			// Token: 0x040175E6 RID: 95718
			[FieldOffset(1)]
			public EMagtAPWorkloadAdvice NewAdvice;
		}

		// Token: 0x020035AA RID: 13738
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040175E7 RID: 95719
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
