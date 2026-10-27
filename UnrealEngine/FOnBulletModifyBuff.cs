using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001708 RID: 5896
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBulletModifyBuff : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06015491 RID: 87185 RVA: 0x001F4856 File Offset: 0x001F2A56
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBulletModifyBuff.StaticFunctionPtr();
		}

		// Token: 0x06015492 RID: 87186 RVA: 0x001F4862 File Offset: 0x001F2A62
		private static IntPtr StaticFunctionPtr()
		{
			if (UBulletWorld.__OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UBulletWorld.__OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBulletCore.BulletWorld:OnBulletModifyBuff__DelegateSignature");
			}
			return UBulletWorld.__OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06015493 RID: 87187 RVA: 0x001F4885 File Offset: 0x001F2A85
		public FOnBulletModifyBuff()
		{
		}

		// Token: 0x06015494 RID: 87188 RVA: 0x001F488D File Offset: 0x001F2A8D
		[NullableContext(2)]
		public FOnBulletModifyBuff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015495 RID: 87189 RVA: 0x001F4897 File Offset: 0x001F2A97
		public FOnBulletModifyBuff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015496 RID: 87190 RVA: 0x001F48A2 File Offset: 0x001F2AA2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, long, bool>) ?? ((Action<int, long, bool>)Delegate.CreateDelegate(typeof(Action<int, long, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06015497 RID: 87191 RVA: 0x001F48D4 File Offset: 0x001F2AD4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, long, bool> Callback)
		{
			if (FOnBulletModifyBuff.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnBulletModifyBuff.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnBulletModifyBuff.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnBulletModifyBuff.OnScriptCallback));
				}
				FOnBulletModifyBuff.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnBulletModifyBuff.RegisterId);
		}

		// Token: 0x06015498 RID: 87192 RVA: 0x001F490E File Offset: 0x001F2B0E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, long, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06015499 RID: 87193 RVA: 0x001F4918 File Offset: 0x001F2B18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int EntityId, long BuffId, bool bAdd)
		{
			FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams* ptr = stackalloc FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBulletModifyBuff.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->BuffId = BuffId;
			ptr->bAdd = bAdd;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601549A RID: 87194 RVA: 0x001F4964 File Offset: 0x001F2B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, long, bool> action = target as Action<int, long, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams*)__Parameters)->EntityId, ((FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams*)__Parameters)->BuffId, ((FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams*)__Parameters)->bAdd);
		}

		// Token: 0x0400B9A6 RID: 47526
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletWorld:OnBulletModifyBuff__DelegateSignature";

		// Token: 0x0400B9A7 RID: 47527
		private static int RegisterId;

		// Token: 0x02002EF4 RID: 12020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnBulletModifyBuff_DelegateParams
		{
			// Token: 0x04016A29 RID: 92713
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016A2A RID: 92714
			[FieldOffset(8)]
			public long BuffId;

			// Token: 0x04016A2B RID: 92715
			[FieldOffset(16)]
			public bool bAdd;
		}

		// Token: 0x02002EF5 RID: 12021
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A2C RID: 92716
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
