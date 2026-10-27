using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C59 RID: 7257
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameSkillEffectManager")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroRhythmGameSkillEffectManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C299 RID: 115353 RVA: 0x002980CE File Offset: 0x002962CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameSkillEffectManager._ClassPtr;
		}

		// Token: 0x0601C29A RID: 115354 RVA: 0x002980DC File Offset: 0x002962DC
		public UKuroRhythmGameSkillEffectManager() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameSkillEffectManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C29B RID: 115355 RVA: 0x00298104 File Offset: 0x00296304
		public UKuroRhythmGameSkillEffectManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameSkillEffectManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170071EF RID: 29167
		// (get) Token: 0x0601C29C RID: 115356 RVA: 0x00298138 File Offset: 0x00296338
		// (set) Token: 0x0601C29D RID: 115357 RVA: 0x00298171 File Offset: 0x00296371
		public TMap<EKuroRhythmSkillEffectType, UKuroRhythmGameSkillEffectBase> EffectMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroRhythmSkillEffectType, UKuroRhythmGameSkillEffectBase> result;
				if ((result = this._EffectMap) == null)
				{
					result = (this._EffectMap = new TMap<EKuroRhythmSkillEffectType, UKuroRhythmGameSkillEffectBase>(base.NativePtr + (IntPtr)UKuroRhythmGameSkillEffectManager.__PropertyOffset_EffectMap, this));
				}
				return result;
			}
			set
			{
				this.EffectMap.CopyAssign(value);
			}
		}

		// Token: 0x170071F0 RID: 29168
		// (get) Token: 0x0601C29E RID: 115358 RVA: 0x00298180 File Offset: 0x00296380
		// (set) Token: 0x0601C29F RID: 115359 RVA: 0x002981B9 File Offset: 0x002963B9
		public FKuroRhythmSkillContext SkillContext
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmSkillContext result;
				if ((result = this._SkillContext) == null)
				{
					result = (this._SkillContext = new FKuroRhythmSkillContext(base.NativePtr + (IntPtr)UKuroRhythmGameSkillEffectManager.__PropertyOffset_SkillContext, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmSkillContext.StaticStruct(), base.NativePtr + (IntPtr)UKuroRhythmGameSkillEffectManager.__PropertyOffset_SkillContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601C2A0 RID: 115360 RVA: 0x002981DC File Offset: 0x002963DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Initialize([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroRhythmSkillEffectParam> InSkillEffectParams, UKuroRhythmGameManager GameManager, UKuroRhythmGameJudgement Judgement)
		{
			UKuroRhythmGameSkillEffectManager.__Initialize_FunctionParams* ptr = stackalloc UKuroRhythmGameSkillEffectManager.__Initialize_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroRhythmGameSkillEffectManager.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameSkillEffectManager.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FKuroRhythmSkillEffectParam> tarray = InSkillEffectParams;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSkillEffectParams);
			}
			ptr->GameManager = ((GameManager != null) ? GameManager.NativePtr : IntPtr.Zero);
			ptr->Judgement = ((Judgement != null) ? Judgement.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameSkillEffectManager.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FKuroRhythmSkillEffectParam> tarray2 = InSkillEffectParams;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSkillEffectParams);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameSkillEffectManager.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C2A1 RID: 115361 RVA: 0x00298284 File Offset: 0x00296484
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroRhythmGameSkillEffectBase CreateSkillEffect(ref FKuroRhythmSkillEffectParam SkillEffectParam)
		{
			UKuroRhythmGameSkillEffectManager.__CreateSkillEffect_FunctionParams* ptr = stackalloc UKuroRhythmGameSkillEffectManager.__CreateSkillEffect_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroRhythmGameSkillEffectManager.__CreateSkillEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameSkillEffectManager.__CreateSkillEffect_NativeFunctionPtr, (void*)ptr, 1);
			if (SkillEffectParam != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmSkillEffectParam.StaticStruct(), &ptr->SkillEffectParam, SkillEffectParam.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameSkillEffectManager.__CreateSkillEffect_NativeFunctionPtr, (void*)ptr, 0);
			if (SkillEffectParam != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmSkillEffectParam.StaticStruct(), SkillEffectParam.NativePtr, &ptr->SkillEffectParam, 1, false);
			}
			UKuroRhythmGameSkillEffectBase orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRhythmGameSkillEffectBase>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameSkillEffectManager.__CreateSkillEffect_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601C2A2 RID: 115362 RVA: 0x00298328 File Offset: 0x00296528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Clear()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameSkillEffectManager.__Clear_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C2A3 RID: 115363 RVA: 0x0029833D File Offset: 0x0029653D
		static UKuroRhythmGameSkillEffectManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameSkillEffectManager");
		}

		// Token: 0x0601C2A4 RID: 115364 RVA: 0x0029834B File Offset: 0x0029654B
		protected UKuroRhythmGameSkillEffectManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F27B RID: 62075
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameSkillEffectManager";

		// Token: 0x0400F27C RID: 62076
		private static IntPtr _ClassPtr;

		// Token: 0x0400F27D RID: 62077
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F27E RID: 62078
		internal static int __PropertyOffset_EffectMap;

		// Token: 0x0400F27F RID: 62079
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroRhythmSkillEffectType, UKuroRhythmGameSkillEffectBase> _EffectMap;

		// Token: 0x0400F280 RID: 62080
		internal static int __PropertyOffset_SkillContext;

		// Token: 0x0400F281 RID: 62081
		[Nullable(2)]
		private FKuroRhythmSkillContext _SkillContext;

		// Token: 0x0400F282 RID: 62082
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400F283 RID: 62083
		private static IntPtr __CreateSkillEffect_NativeFunctionPtr;

		// Token: 0x0400F284 RID: 62084
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x020031EF RID: 12783
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04017046 RID: 94278
			[FieldOffset(0)]
			public byte InSkillEffectParams;

			// Token: 0x04017047 RID: 94279
			[FieldOffset(16)]
			public IntPtr GameManager;

			// Token: 0x04017048 RID: 94280
			[FieldOffset(24)]
			public IntPtr Judgement;
		}

		// Token: 0x020031F0 RID: 12784
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CreateSkillEffect_FunctionParams
		{
			// Token: 0x04017049 RID: 94281
			[FieldOffset(0)]
			public byte SkillEffectParam;

			// Token: 0x0401704A RID: 94282
			[FieldOffset(24)]
			public IntPtr __Result;
		}
	}
}
