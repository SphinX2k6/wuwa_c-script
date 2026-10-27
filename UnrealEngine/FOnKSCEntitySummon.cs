using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E68 RID: 7784
	public sealed class FOnKSCEntitySummon : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DA8F RID: 121487 RVA: 0x002BCC99 File Offset: 0x002BAE99
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCEntitySummon.StaticFunctionPtr();
		}

		// Token: 0x0601DA90 RID: 121488 RVA: 0x002BCCA5 File Offset: 0x002BAEA5
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCEntitySummon._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCEntitySummon._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCEntitySummon__DelegateSignature");
			}
			return FOnKSCEntitySummon._FunctionPtr;
		}

		// Token: 0x0601DA91 RID: 121489 RVA: 0x002BCCC8 File Offset: 0x002BAEC8
		public FOnKSCEntitySummon()
		{
		}

		// Token: 0x0601DA92 RID: 121490 RVA: 0x002BCCD0 File Offset: 0x002BAED0
		[NullableContext(2)]
		public FOnKSCEntitySummon(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA93 RID: 121491 RVA: 0x002BCCDA File Offset: 0x002BAEDA
		public FOnKSCEntitySummon(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA94 RID: 121492 RVA: 0x002BCCE5 File Offset: 0x002BAEE5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate) ?? ((FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DA95 RID: 121493 RVA: 0x002BCD17 File Offset: 0x002BAF17
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate Callback)
		{
			if (FOnKSCEntitySummon.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCEntitySummon.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCEntitySummon.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCEntitySummon.OnScriptCallback));
				}
				FOnKSCEntitySummon.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCEntitySummon.RegisterId);
		}

		// Token: 0x0601DA96 RID: 121494 RVA: 0x002BCD54 File Offset: 0x002BAF54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FTransformDouble OwnerTransform, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_SpawnEntity> SummonEntities, int SummonerID)
		{
			FOnKSCEntitySummon.__FOnKSCEntitySummon_DelegateParams* ptr = stackalloc FOnKSCEntitySummon.__FOnKSCEntitySummon_DelegateParams[(UIntPtr)111] + 15L / (long)sizeof(FOnKSCEntitySummon.__FOnKSCEntitySummon_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCEntitySummon.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OwnerTransform = OwnerTransform;
			TArray<FKSC_SpawnEntity> tarray = SummonEntities;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SummonEntities);
			}
			ptr->SummonerID = SummonerID;
			base.ExecuteInternal((void*)ptr);
			TArray<FKSC_SpawnEntity> tarray2 = SummonEntities;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SummonEntities);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKSCEntitySummon._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DA97 RID: 121495 RVA: 0x002BCDD4 File Offset: 0x002BAFD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate fonKSCEntitySummon_ScriptDelegate = target as FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate;
			if (fonKSCEntitySummon_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FKSC_SpawnEntity> tarray = new TArray<FKSC_SpawnEntity>(&((FOnKSCEntitySummon.__FOnKSCEntitySummon_DelegateParams*)__Parameters)->SummonEntities, true, true);
			fonKSCEntitySummon_ScriptDelegate(((FOnKSCEntitySummon.__FOnKSCEntitySummon_DelegateParams*)__Parameters)->OwnerTransform, tarray, ((FOnKSCEntitySummon.__FOnKSCEntitySummon_DelegateParams*)__Parameters)->SummonerID);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKSCEntitySummon.__FOnKSCEntitySummon_DelegateParams*)__Parameters)->SummonEntities, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0401011B RID: 65819
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401011C RID: 65820
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCEntitySummon__DelegateSignature";

		// Token: 0x0401011D RID: 65821
		private static int RegisterId;

		// Token: 0x020032B8 RID: 12984
		// (Invoke) Token: 0x0602859A RID: 165274
		public delegate void FOnKSCEntitySummon_ScriptDelegate(FTransformDouble OwnerTransform, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_SpawnEntity> SummonEntities, int SummonerID);

		// Token: 0x020032B9 RID: 12985
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __FOnKSCEntitySummon_DelegateParams
		{
			// Token: 0x0401715C RID: 94556
			[FieldOffset(0)]
			public FTransformDouble OwnerTransform;

			// Token: 0x0401715D RID: 94557
			[FieldOffset(64)]
			public byte SummonEntities;

			// Token: 0x0401715E RID: 94558
			[FieldOffset(80)]
			public int SummonerID;
		}

		// Token: 0x020032BA RID: 12986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401715F RID: 94559
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
