using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002706 RID: 9990
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnQteAnimEnd : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060250A7 RID: 151719 RVA: 0x0036D14E File Offset: 0x0036B34E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQteAnimEnd.StaticFunctionPtr();
		}

		// Token: 0x060250A8 RID: 151720 RVA: 0x0036D15A File Offset: 0x0036B35A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQteAnimEnd._FunctionPtr == IntPtr.Zero)
			{
				FOnQteAnimEnd._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnQteAnimEnd__DelegateSignature");
			}
			return FOnQteAnimEnd._FunctionPtr;
		}

		// Token: 0x060250A9 RID: 151721 RVA: 0x0036D17D File Offset: 0x0036B37D
		public FOnQteAnimEnd()
		{
		}

		// Token: 0x060250AA RID: 151722 RVA: 0x0036D185 File Offset: 0x0036B385
		[NullableContext(2)]
		public FOnQteAnimEnd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060250AB RID: 151723 RVA: 0x0036D18F File Offset: 0x0036B38F
		public FOnQteAnimEnd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060250AC RID: 151724 RVA: 0x0036D19A File Offset: 0x0036B39A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060250AD RID: 151725 RVA: 0x0036D1CC File Offset: 0x0036B3CC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FOnQteAnimEnd.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnQteAnimEnd.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnQteAnimEnd.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnQteAnimEnd.OnScriptCallback));
				}
				FOnQteAnimEnd.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnQteAnimEnd.RegisterId);
		}

		// Token: 0x060250AE RID: 151726 RVA: 0x0036D206 File Offset: 0x0036B406
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060250AF RID: 151727 RVA: 0x0036D210 File Offset: 0x0036B410
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int QteId)
		{
			FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams* ptr = stackalloc FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnQteAnimEnd.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->QteId = QteId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060250B0 RID: 151728 RVA: 0x0036D24C File Offset: 0x0036B44C
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
			action(((FOnQteAnimEnd.__FOnQteAnimEnd_DelegateParams*)__Parameters)->QteId);
		}

		// Token: 0x04013F4A RID: 81738
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F4B RID: 81739
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnQteAnimEnd__DelegateSignature";

		// Token: 0x04013F4C RID: 81740
		private static int RegisterId;

		// Token: 0x020036A8 RID: 13992
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnQteAnimEnd_DelegateParams
		{
			// Token: 0x040177BB RID: 96187
			[FieldOffset(0)]
			public int QteId;
		}

		// Token: 0x020036A9 RID: 13993
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177BC RID: 96188
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
