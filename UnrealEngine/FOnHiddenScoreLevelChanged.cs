using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200050B RID: 1291
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHiddenScoreLevelChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007918 RID: 31000 RVA: 0x000B18CE File Offset: 0x000AFACE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHiddenScoreLevelChanged.StaticFunctionPtr();
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x000B18DA File Offset: 0x000AFADA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHiddenScoreLevelChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnHiddenScoreLevelChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHiddenScoreLevelChanged__DelegateSignature");
			}
			return FOnHiddenScoreLevelChanged._FunctionPtr;
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x000B18FD File Offset: 0x000AFAFD
		public FOnHiddenScoreLevelChanged()
		{
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x000B1905 File Offset: 0x000AFB05
		[NullableContext(2)]
		public FOnHiddenScoreLevelChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x000B190F File Offset: 0x000AFB0F
		public FOnHiddenScoreLevelChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x000B191A File Offset: 0x000AFB1A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x000B194C File Offset: 0x000AFB4C
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnHiddenScoreLevelChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHiddenScoreLevelChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHiddenScoreLevelChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHiddenScoreLevelChanged.OnScriptCallback));
				}
				FOnHiddenScoreLevelChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHiddenScoreLevelChanged.RegisterId);
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x000B1986 File Offset: 0x000AFB86
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x000B1990 File Offset: 0x000AFB90
		[SkipLocalsInit]
		public unsafe void Broadcast(int NewLevel, int OldLevel)
		{
			FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams* ptr = stackalloc FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHiddenScoreLevelChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewLevel = NewLevel;
			ptr->OldLevel = OldLevel;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x000B19D4 File Offset: 0x000AFBD4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams*)__Parameters)->NewLevel, ((FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams*)__Parameters)->OldLevel);
		}

		// Token: 0x0400337E RID: 13182
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400337F RID: 13183
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHiddenScoreLevelChanged__DelegateSignature";

		// Token: 0x04003380 RID: 13184
		private static int RegisterId;

		// Token: 0x02000C6F RID: 3183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnHiddenScoreLevelChanged_DelegateParams
		{
			// Token: 0x04005EC9 RID: 24265
			[FieldOffset(0)]
			public int NewLevel;

			// Token: 0x04005ECA RID: 24266
			[FieldOffset(4)]
			public int OldLevel;
		}

		// Token: 0x02000C70 RID: 3184
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005ECB RID: 24267
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
