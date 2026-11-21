using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200059A RID: 1434
	public sealed class FOnKSCEntitySpawn : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060081F0 RID: 33264 RVA: 0x000BFDCF File Offset: 0x000BDFCF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCEntitySpawn.StaticFunctionPtr();
		}

		// Token: 0x060081F1 RID: 33265 RVA: 0x000BFDDB File Offset: 0x000BDFDB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCEntitySpawn._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCEntitySpawn._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCEntitySpawn__DelegateSignature");
			}
			return FOnKSCEntitySpawn._FunctionPtr;
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x000BFDFE File Offset: 0x000BDFFE
		public FOnKSCEntitySpawn()
		{
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x000BFE06 File Offset: 0x000BE006
		[NullableContext(2)]
		public FOnKSCEntitySpawn(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x000BFE10 File Offset: 0x000BE010
		public FOnKSCEntitySpawn(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x000BFE1B File Offset: 0x000BE01B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate) ?? ((FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x000BFE4D File Offset: 0x000BE04D
		[NullableContext(1)]
		public void Bind(FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate Callback)
		{
			if (FOnKSCEntitySpawn.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCEntitySpawn.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCEntitySpawn.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCEntitySpawn.OnScriptCallback));
				}
				FOnKSCEntitySpawn.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCEntitySpawn.RegisterId);
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x000BFE88 File Offset: 0x000BE088
		[SkipLocalsInit]
		public unsafe void Execute(FTransformDouble OwnerTransform, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_SpawnEntity> SpawnEntities)
		{
			FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams* ptr = stackalloc FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams[(UIntPtr)95] + 15L / (long)sizeof(FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCEntitySpawn.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OwnerTransform = OwnerTransform;
			TArray<FKSC_SpawnEntity> tarray = SpawnEntities;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SpawnEntities);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FKSC_SpawnEntity> tarray2 = SpawnEntities;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SpawnEntities);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKSCEntitySpawn._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060081F8 RID: 33272 RVA: 0x000BFF00 File Offset: 0x000BE100
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate fonKSCEntitySpawn_ScriptDelegate = target as FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate;
			if (fonKSCEntitySpawn_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FKSC_SpawnEntity> tarray = new TArray<FKSC_SpawnEntity>(&((FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams*)__Parameters)->SpawnEntities, true, true);
			fonKSCEntitySpawn_ScriptDelegate(((FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams*)__Parameters)->OwnerTransform, tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams*)__Parameters)->SpawnEntities, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x040038AD RID: 14509
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038AE RID: 14510
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCEntitySpawn__DelegateSignature";

		// Token: 0x040038AF RID: 14511
		private static int RegisterId;

		// Token: 0x02000D14 RID: 3348
		// (Invoke) Token: 0x0600BF07 RID: 48903
		public delegate void FOnKSCEntitySpawn_ScriptDelegate(FTransformDouble OwnerTransform, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_SpawnEntity> SpawnEntities);

		// Token: 0x02000D15 RID: 3349
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		private ref struct __FOnKSCEntitySpawn_DelegateParams
		{
			// Token: 0x04005FA5 RID: 24485
			[FieldOffset(0)]
			public FTransformDouble OwnerTransform;

			// Token: 0x04005FA6 RID: 24486
			[FieldOffset(64)]
			public byte SpawnEntities;
		}

		// Token: 0x02000D16 RID: 3350
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FA7 RID: 24487
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
