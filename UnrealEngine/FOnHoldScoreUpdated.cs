using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200050F RID: 1295
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoldScoreUpdated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007940 RID: 31040 RVA: 0x000B1D98 File Offset: 0x000AFF98
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoldScoreUpdated.StaticFunctionPtr();
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x000B1DA4 File Offset: 0x000AFFA4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoldScoreUpdated._FunctionPtr == IntPtr.Zero)
			{
				FOnHoldScoreUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHoldScoreUpdated__DelegateSignature");
			}
			return FOnHoldScoreUpdated._FunctionPtr;
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x000B1DC7 File Offset: 0x000AFFC7
		public FOnHoldScoreUpdated()
		{
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x000B1DCF File Offset: 0x000AFFCF
		[NullableContext(2)]
		public FOnHoldScoreUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x000B1DD9 File Offset: 0x000AFFD9
		public FOnHoldScoreUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x000B1DE4 File Offset: 0x000AFFE4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x000B1E16 File Offset: 0x000B0016
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnHoldScoreUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHoldScoreUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHoldScoreUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHoldScoreUpdated.OnScriptCallback));
				}
				FOnHoldScoreUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHoldScoreUpdated.RegisterId);
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x000B1E50 File Offset: 0x000B0050
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x000B1E5C File Offset: 0x000B005C
		[SkipLocalsInit]
		public unsafe void Broadcast(int ScoreGained, int CurrentBeat)
		{
			FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams* ptr = stackalloc FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHoldScoreUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ScoreGained = ScoreGained;
			ptr->CurrentBeat = CurrentBeat;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x000B1EA0 File Offset: 0x000B00A0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams*)__Parameters)->ScoreGained, ((FOnHoldScoreUpdated.__FOnHoldScoreUpdated_DelegateParams*)__Parameters)->CurrentBeat);
		}

		// Token: 0x0400338A RID: 13194
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400338B RID: 13195
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHoldScoreUpdated__DelegateSignature";

		// Token: 0x0400338C RID: 13196
		private static int RegisterId;

		// Token: 0x02000C75 RID: 3189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnHoldScoreUpdated_DelegateParams
		{
			// Token: 0x04005ED1 RID: 24273
			[FieldOffset(0)]
			public int ScoreGained;

			// Token: 0x04005ED2 RID: 24274
			[FieldOffset(4)]
			public int CurrentBeat;
		}

		// Token: 0x02000C76 RID: 3190
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ED3 RID: 24275
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
