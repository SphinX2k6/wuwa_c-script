using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000251 RID: 593
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnClientEntityStreamingStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032E1 RID: 13025 RVA: 0x00048B4C File Offset: 0x00046D4C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnClientEntityStreamingStateChanged.StaticFunctionPtr();
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00048B58 File Offset: 0x00046D58
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnClientEntityStreamingStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnClientEntityStreamingStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnClientEntityStreamingStateChanged__DelegateSignature");
			}
			return FOnClientEntityStreamingStateChanged._FunctionPtr;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00048B7B File Offset: 0x00046D7B
		public FOnClientEntityStreamingStateChanged()
		{
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00048B83 File Offset: 0x00046D83
		[NullableContext(2)]
		public FOnClientEntityStreamingStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00048B8D File Offset: 0x00046D8D
		public FOnClientEntityStreamingStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00048B98 File Offset: 0x00046D98
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate) ?? ((FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x00048BCA File Offset: 0x00046DCA
		[NullableContext(1)]
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

		// Token: 0x060032E8 RID: 13032 RVA: 0x00048C04 File Offset: 0x00046E04
		[NullableContext(1)]
		public void Remove(FOnClientEntityStreamingStateChanged.FOnClientEntityStreamingStateChanged_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x00048C10 File Offset: 0x00046E10
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060032EA RID: 13034 RVA: 0x00048C88 File Offset: 0x00046E88
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040011BF RID: 4543
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011C0 RID: 4544
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnClientEntityStreamingStateChanged__DelegateSignature";

		// Token: 0x040011C1 RID: 4545
		private static int RegisterId;

		// Token: 0x020009CD RID: 2509
		// (Invoke) Token: 0x0600BEE7 RID: 48871
		public delegate void FOnClientEntityStreamingStateChanged_ScriptDelegate(in TArray<int> EntityIDs, EClientEntityStreamingState State);

		// Token: 0x020009CE RID: 2510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnClientEntityStreamingStateChanged_DelegateParams
		{
			// Token: 0x0400595A RID: 22874
			[FieldOffset(0)]
			public byte EntityIDs;

			// Token: 0x0400595B RID: 22875
			[FieldOffset(16)]
			public EClientEntityStreamingState State;
		}

		// Token: 0x020009CF RID: 2511
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400595C RID: 22876
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
