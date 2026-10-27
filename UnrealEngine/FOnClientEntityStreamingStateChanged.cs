using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F0C RID: 3852
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnClientEntityStreamingStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D068 RID: 53352 RVA: 0x00130515 File Offset: 0x0012E715
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnClientEntityStreamingStateChanged.StaticFunctionPtr();
		}

		// Token: 0x0600D069 RID: 53353 RVA: 0x00130521 File Offset: 0x0012E721
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnClientEntityStreamingStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnClientEntityStreamingStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnClientEntityStreamingStateChanged__DelegateSignature");
			}
			return FOnClientEntityStreamingStateChanged._FunctionPtr;
		}

		// Token: 0x0600D06A RID: 53354 RVA: 0x00130544 File Offset: 0x0012E744
		public FOnClientEntityStreamingStateChanged()
		{
		}

		// Token: 0x0600D06B RID: 53355 RVA: 0x0013054C File Offset: 0x0012E74C
		[NullableContext(2)]
		public FOnClientEntityStreamingStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D06C RID: 53356 RVA: 0x00130556 File Offset: 0x0012E756
		public FOnClientEntityStreamingStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D06D RID: 53357 RVA: 0x00130561 File Offset: 0x0012E761
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate) ?? ((FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D06E RID: 53358 RVA: 0x00130593 File Offset: 0x0012E793
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate Callback)
		{
			if (FOnClientEntityStreamingStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnClientEntityStreamingStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnClientEntityStreamingStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnClientEntityStreamingStateChanged.OnScriptCallback));
				}
				FOnClientEntityStreamingStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnClientEntityStreamingStateChanged.RegisterId);
		}

		// Token: 0x0600D06F RID: 53359 RVA: 0x001305CD File Offset: 0x0012E7CD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D070 RID: 53360 RVA: 0x001305D8 File Offset: 0x0012E7D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in TArray<int> EntityIDs, EClientEntityStreamingState State)
		{
			FOnClientEntityStreamingStateChanged.__FOnClientEntityStreamingStateChanged_DelegateParams* ptr = stackalloc FOnClientEntityStreamingStateChanged.__FOnClientEntityStreamingStateChanged_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnClientEntityStreamingStateChanged.__FOnClientEntityStreamingStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnClientEntityStreamingStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<int> tarray = EntityIDs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->EntityIDs);
			}
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
			TArray<int> tarray2 = EntityIDs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->EntityIDs);
			}
			UnrealReflectionUtils.DestroyStruct(FOnClientEntityStreamingStateChanged._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600D071 RID: 53361 RVA: 0x00130650 File Offset: 0x0012E850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate fonClientEntityStreamingStateChanged_ScriptDelegate = target as FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate;
			if (fonClientEntityStreamingStateChanged_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<int> tarray = new TArray<int>(&((FOnClientEntityStreamingStateChanged.__FOnClientEntityStreamingStateChanged_DelegateParams*)__Parameters)->EntityIDs, true, true);
			fonClientEntityStreamingStateChanged_ScriptDelegate(tarray, ((FOnClientEntityStreamingStateChanged.__FOnClientEntityStreamingStateChanged_DelegateParams*)__Parameters)->State);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnClientEntityStreamingStateChanged.__FOnClientEntityStreamingStateChanged_DelegateParams*)__Parameters)->EntityIDs, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04007039 RID: 28729
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400703A RID: 28730
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnClientEntityStreamingStateChanged__DelegateSignature";

		// Token: 0x0400703B RID: 28731
		private static int RegisterId;

		// Token: 0x02002D67 RID: 11623
		// (Invoke) Token: 0x0602853A RID: 165178
		public delegate void FOnClientEntityStreamingStateChanged_ScriptDelegate(in TArray<int> EntityIDs, EClientEntityStreamingState State);

		// Token: 0x02002D68 RID: 11624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnClientEntityStreamingStateChanged_DelegateParams
		{
			// Token: 0x04016781 RID: 92033
			[FieldOffset(0)]
			public byte EntityIDs;

			// Token: 0x04016782 RID: 92034
			[FieldOffset(16)]
			public EClientEntityStreamingState State;
		}

		// Token: 0x02002D69 RID: 11625
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016783 RID: 92035
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
