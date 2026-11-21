using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200059B RID: 1435
	public sealed class FOnKSCEntitySummon : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060081F9 RID: 33273 RVA: 0x000BFF75 File Offset: 0x000BE175
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCEntitySummon.StaticFunctionPtr();
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x000BFF81 File Offset: 0x000BE181
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCEntitySummon._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCEntitySummon._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCEntitySummon__DelegateSignature");
			}
			return FOnKSCEntitySummon._FunctionPtr;
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x000BFFA4 File Offset: 0x000BE1A4
		public FOnKSCEntitySummon()
		{
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x000BFFAC File Offset: 0x000BE1AC
		[NullableContext(2)]
		public FOnKSCEntitySummon(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x000BFFB6 File Offset: 0x000BE1B6
		public FOnKSCEntitySummon(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060081FE RID: 33278 RVA: 0x000BFFC1 File Offset: 0x000BE1C1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate) ?? ((FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCEntitySummon.FOnKSCEntitySummon_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060081FF RID: 33279 RVA: 0x000BFFF3 File Offset: 0x000BE1F3
		[NullableContext(1)]
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

		// Token: 0x06008200 RID: 33280 RVA: 0x000C0030 File Offset: 0x000BE230
		[SkipLocalsInit]
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

		// Token: 0x06008201 RID: 33281 RVA: 0x000C00B0 File Offset: 0x000BE2B0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040038B0 RID: 14512
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038B1 RID: 14513
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCEntitySummon__DelegateSignature";

		// Token: 0x040038B2 RID: 14514
		private static int RegisterId;

		// Token: 0x02000D17 RID: 3351
		// (Invoke) Token: 0x0600BF0B RID: 48907
		public delegate void FOnKSCEntitySummon_ScriptDelegate(FTransformDouble OwnerTransform, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_SpawnEntity> SummonEntities, int SummonerID);

		// Token: 0x02000D18 RID: 3352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		private ref struct __FOnKSCEntitySummon_DelegateParams
		{
			// Token: 0x04005FA8 RID: 24488
			[FieldOffset(0)]
			public FTransformDouble OwnerTransform;

			// Token: 0x04005FA9 RID: 24489
			[FieldOffset(64)]
			public byte SummonEntities;

			// Token: 0x04005FAA RID: 24490
			[FieldOffset(80)]
			public int SummonerID;
		}

		// Token: 0x02000D19 RID: 3353
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FAB RID: 24491
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
