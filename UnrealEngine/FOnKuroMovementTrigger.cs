using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000474 RID: 1140
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKuroMovementTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006C53 RID: 27731 RVA: 0x0009DD43 File Offset: 0x0009BF43
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKuroMovementTrigger.StaticFunctionPtr();
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x0009DD4F File Offset: 0x0009BF4F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKuroMovementTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnKuroMovementTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroMovement.OnKuroMovementTrigger__DelegateSignature");
			}
			return FOnKuroMovementTrigger._FunctionPtr;
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x0009DD72 File Offset: 0x0009BF72
		public FOnKuroMovementTrigger()
		{
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x0009DD7A File Offset: 0x0009BF7A
		[NullableContext(2)]
		public FOnKuroMovementTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x0009DD84 File Offset: 0x0009BF84
		public FOnKuroMovementTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x0009DD8F File Offset: 0x0009BF8F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate) ?? ((FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x0009DDC1 File Offset: 0x0009BFC1
		[NullableContext(1)]
		public void Add(FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate Callback)
		{
			if (FOnKuroMovementTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKuroMovementTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKuroMovementTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKuroMovementTrigger.OnScriptCallback));
				}
				FOnKuroMovementTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnKuroMovementTrigger.RegisterId);
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x0009DDFB File Offset: 0x0009BFFB
		[NullableContext(1)]
		public void Remove(FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x0009DE04 File Offset: 0x0009C004
		[SkipLocalsInit]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FOverlapActorRecord> Records)
		{
			FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams* ptr = stackalloc FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKuroMovementTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FOverlapActorRecord> tarray = Records;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Records);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FOverlapActorRecord> tarray2 = Records;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Records);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKuroMovementTrigger._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x0009DE74 File Offset: 0x0009C074
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate fonKuroMovementTrigger_ScriptDelegate = target as FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate;
			if (fonKuroMovementTrigger_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FOverlapActorRecord> tarray = new TArray<FOverlapActorRecord>(&((FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams*)__Parameters)->Records, true, true);
			fonKuroMovementTrigger_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams*)__Parameters)->Records, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04002E46 RID: 11846
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002E47 RID: 11847
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMovement.OnKuroMovementTrigger__DelegateSignature";

		// Token: 0x04002E48 RID: 11848
		private static int RegisterId;

		// Token: 0x02000B78 RID: 2936
		// (Invoke) Token: 0x0600BEFF RID: 48895
		public delegate void FOnKuroMovementTrigger_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FOverlapActorRecord> Records);

		// Token: 0x02000B79 RID: 2937
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnKuroMovementTrigger_DelegateParams
		{
			// Token: 0x04005CD0 RID: 23760
			[FieldOffset(0)]
			public byte Records;
		}

		// Token: 0x02000B7A RID: 2938
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005CD1 RID: 23761
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
