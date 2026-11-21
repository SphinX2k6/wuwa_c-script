using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000219 RID: 537
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HighLevelMemTrackerSubSystem")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UHighLevelMemTrackerSubSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600244C RID: 9292 RVA: 0x00034615 File Offset: 0x00032815
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHighLevelMemTrackerSubSystem._ClassPtr;
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00034624 File Offset: 0x00032824
		public UHighLevelMemTrackerSubSystem() : this(BuiltinUtils.AllocNativeUObject(UHighLevelMemTrackerSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x0003464C File Offset: 0x0003284C
		[NullableContext(1)]
		public UHighLevelMemTrackerSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHighLevelMemTrackerSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0003467F File Offset: 0x0003287F
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0003468F File Offset: 0x0003288F
		public unsafe int CheckCellNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CheckCellNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CheckCellNum) = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x000346A0 File Offset: 0x000328A0
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x000346B0 File Offset: 0x000328B0
		public unsafe float StepSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeX) = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000346C1 File Offset: 0x000328C1
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x000346D1 File Offset: 0x000328D1
		public unsafe float StepSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeY) = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000346E2 File Offset: 0x000328E2
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x000346F2 File Offset: 0x000328F2
		public unsafe float StepSizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_StepSizeZ) = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x00034703 File Offset: 0x00032903
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x00034717 File Offset: 0x00032917
		public unsafe AActor StreamingSourceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UHighLevelMemTrackerSubSystem.__PropertyOffset_StreamingSourceActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHighLevelMemTrackerSubSystem.__PropertyOffset_StreamingSourceActor, value);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x0003472C File Offset: 0x0003292C
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0003473C File Offset: 0x0003293C
		public unsafe int ProcessMemoryThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ProcessMemoryThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ProcessMemoryThresholds) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x0003474D File Offset: 0x0003294D
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0003475D File Offset: 0x0003295D
		public unsafe int OneCellMemoryThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_OneCellMemoryThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_OneCellMemoryThresholds) = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x0003476E File Offset: 0x0003296E
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0003477E File Offset: 0x0003297E
		public unsafe int CellLoadingThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CellLoadingThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_CellLoadingThresholds) = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x0003478F File Offset: 0x0003298F
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0003479F File Offset: 0x0003299F
		public unsafe int ActorMemoryThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ActorMemoryThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_ActorMemoryThresholds) = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000347B0 File Offset: 0x000329B0
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x000347C0 File Offset: 0x000329C0
		public unsafe int SequenceThresholds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_SequenceThresholds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_SequenceThresholds) = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000347D4 File Offset: 0x000329D4
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0003480D File Offset: 0x00032A0D
		[Nullable(1)]
		public FKuroRunMapTickDelegate RunMapTickCallBack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroRunMapTickDelegate result;
				if ((result = this._RunMapTickCallBack) == null)
				{
					result = (this._RunMapTickCallBack = new FKuroRunMapTickDelegate(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_RunMapTickCallBack, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UHighLevelMemTrackerSubSystem.__PropertyOffset_RunMapTickCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0003482E File Offset: 0x00032A2E
		public void SetOpenFlag(bool bFlag)
		{
			UHighLevelMemTrackerSubSystem.__SetOpenFlag_Internal(base.NativePtr, bFlag);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0003483C File Offset: 0x00032A3C
		public bool IsRunFinish()
		{
			return UHighLevelMemTrackerSubSystem.__IsRunFinish_Internal(base.NativePtr);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00034849 File Offset: 0x00032A49
		public static UHighLevelMemTrackerSubSystem GetSubSystem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UHighLevelMemTrackerSubSystem>(UHighLevelMemTrackerSubSystem.__GetSubSystem_Internal());
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00034855 File Offset: 0x00032A55
		public void CheckMemory()
		{
			UHighLevelMemTrackerSubSystem.__CheckMemory_Internal(base.NativePtr);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00034862 File Offset: 0x00032A62
		public bool CalculateMapBounds()
		{
			return UHighLevelMemTrackerSubSystem.__CalculateMapBounds_Internal(base.NativePtr);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0003486F File Offset: 0x00032A6F
		public bool AutoRunMap(AActor Actor)
		{
			return UHighLevelMemTrackerSubSystem.__AutoRunMap_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600246B RID: 9323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOpenFlag_Internal(IntPtr @this, bool bFlag);

		// Token: 0x0600246C RID: 9324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRunFinish_Internal(IntPtr @this);

		// Token: 0x0600246D RID: 9325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubSystem_Internal();

		// Token: 0x0600246E RID: 9326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheckMemory_Internal(IntPtr @this);

		// Token: 0x0600246F RID: 9327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CalculateMapBounds_Internal(IntPtr @this);

		// Token: 0x06002470 RID: 9328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AutoRunMap_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06002471 RID: 9329 RVA: 0x0003488C File Offset: 0x00032A8C
		static UHighLevelMemTrackerSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HighLevelMemTrackerSubSystem");
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x0003489A File Offset: 0x00032A9A
		protected UHighLevelMemTrackerSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D9C RID: 3484
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HighLevelMemTrackerSubSystem";

		// Token: 0x04000D9D RID: 3485
		private static IntPtr _ClassPtr;

		// Token: 0x04000D9E RID: 3486
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D9F RID: 3487
		internal static int __PropertyOffset_CheckCellNum;

		// Token: 0x04000DA0 RID: 3488
		internal static int __PropertyOffset_StepSizeX;

		// Token: 0x04000DA1 RID: 3489
		internal static int __PropertyOffset_StepSizeY;

		// Token: 0x04000DA2 RID: 3490
		internal static int __PropertyOffset_StepSizeZ;

		// Token: 0x04000DA3 RID: 3491
		internal static int __PropertyOffset_StreamingSourceActor;

		// Token: 0x04000DA4 RID: 3492
		internal static int __PropertyOffset_ProcessMemoryThresholds;

		// Token: 0x04000DA5 RID: 3493
		internal static int __PropertyOffset_OneCellMemoryThresholds;

		// Token: 0x04000DA6 RID: 3494
		internal static int __PropertyOffset_CellLoadingThresholds;

		// Token: 0x04000DA7 RID: 3495
		internal static int __PropertyOffset_ActorMemoryThresholds;

		// Token: 0x04000DA8 RID: 3496
		internal static int __PropertyOffset_SequenceThresholds;

		// Token: 0x04000DA9 RID: 3497
		internal static int __PropertyOffset_RunMapTickCallBack;

		// Token: 0x04000DAA RID: 3498
		private FKuroRunMapTickDelegate _RunMapTickCallBack;
	}
}
