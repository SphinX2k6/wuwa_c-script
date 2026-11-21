using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200032D RID: 813
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBulletModifyBuff : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005505 RID: 21765 RVA: 0x00076FAE File Offset: 0x000751AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBulletModifyBuff.StaticFunctionPtr();
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x00076FBA File Offset: 0x000751BA
		private static IntPtr StaticFunctionPtr()
		{
			if (UBulletWorld.__OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UBulletWorld.__OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBulletCore.BulletWorld:OnBulletModifyBuff__DelegateSignature");
			}
			return UBulletWorld.__OnBulletModifyBuff__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x00076FDD File Offset: 0x000751DD
		public FOnBulletModifyBuff()
		{
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x00076FE5 File Offset: 0x000751E5
		[NullableContext(2)]
		public FOnBulletModifyBuff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00076FEF File Offset: 0x000751EF
		public FOnBulletModifyBuff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x00076FFA File Offset: 0x000751FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, long, bool>) ?? ((Action<int, long, bool>)Delegate.CreateDelegate(typeof(Action<int, long, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x0007702C File Offset: 0x0007522C
		[NullableContext(1)]
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

		// Token: 0x0600550C RID: 21772 RVA: 0x00077066 File Offset: 0x00075266
		[NullableContext(1)]
		public void Remove(Action<int, long, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00077070 File Offset: 0x00075270
		[SkipLocalsInit]
		public unsafe void Broadcast(int EntityId, long BuffId, bool bAdd)
		{
			FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams* ptr = stackalloc FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBulletModifyBuff.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->BuffId = BuffId;
			ptr->bAdd = bAdd;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x000770BC File Offset: 0x000752BC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, long, bool> action = target as Action<int, long, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams*)__Parameters)->EntityId, ((FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams*)__Parameters)->BuffId, ((FOnBulletModifyBuff.__FOnBulletModifyBuff_DelegateParams*)__Parameters)->bAdd);
		}

		// Token: 0x040022BB RID: 8891
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.BulletWorld:OnBulletModifyBuff__DelegateSignature";

		// Token: 0x040022BC RID: 8892
		private static int RegisterId;

		// Token: 0x02000A29 RID: 2601
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnBulletModifyBuff_DelegateParams
		{
			// Token: 0x040059FD RID: 23037
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x040059FE RID: 23038
			[FieldOffset(8)]
			public long BuffId;

			// Token: 0x040059FF RID: 23039
			[FieldOffset(16)]
			public bool bAdd;
		}

		// Token: 0x02000A2A RID: 2602
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005A00 RID: 23040
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
