using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C62 RID: 7266
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnFeverScoreChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C2FE RID: 115454 RVA: 0x00298B0E File Offset: 0x00296D0E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnFeverScoreChanged.StaticFunctionPtr();
		}

		// Token: 0x0601C2FF RID: 115455 RVA: 0x00298B1A File Offset: 0x00296D1A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnFeverScoreChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnFeverScoreChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnFeverScoreChanged__DelegateSignature");
			}
			return FOnFeverScoreChanged._FunctionPtr;
		}

		// Token: 0x0601C300 RID: 115456 RVA: 0x00298B3D File Offset: 0x00296D3D
		public FOnFeverScoreChanged()
		{
		}

		// Token: 0x0601C301 RID: 115457 RVA: 0x00298B45 File Offset: 0x00296D45
		[NullableContext(2)]
		public FOnFeverScoreChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C302 RID: 115458 RVA: 0x00298B4F File Offset: 0x00296D4F
		public FOnFeverScoreChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C303 RID: 115459 RVA: 0x00298B5A File Offset: 0x00296D5A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C304 RID: 115460 RVA: 0x00298B8C File Offset: 0x00296D8C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnFeverScoreChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnFeverScoreChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnFeverScoreChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnFeverScoreChanged.OnScriptCallback));
				}
				FOnFeverScoreChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnFeverScoreChanged.RegisterId);
		}

		// Token: 0x0601C305 RID: 115461 RVA: 0x00298BC6 File Offset: 0x00296DC6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C306 RID: 115462 RVA: 0x00298BD0 File Offset: 0x00296DD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int NewFeverScore, int OldFeverScore)
		{
			FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams* ptr = stackalloc FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnFeverScoreChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewFeverScore = NewFeverScore;
			ptr->OldFeverScore = OldFeverScore;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C307 RID: 115463 RVA: 0x00298C14 File Offset: 0x00296E14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams*)__Parameters)->NewFeverScore, ((FOnFeverScoreChanged.__FOnFeverScoreChanged_DelegateParams*)__Parameters)->OldFeverScore);
		}

		// Token: 0x0400F2AA RID: 62122
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2AB RID: 62123
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnFeverScoreChanged__DelegateSignature";

		// Token: 0x0400F2AC RID: 62124
		private static int RegisterId;

		// Token: 0x020031F4 RID: 12788
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnFeverScoreChanged_DelegateParams
		{
			// Token: 0x0401704E RID: 94286
			[FieldOffset(0)]
			public int NewFeverScore;

			// Token: 0x0401704F RID: 94287
			[FieldOffset(4)]
			public int OldFeverScore;
		}

		// Token: 0x020031F5 RID: 12789
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017050 RID: 94288
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
