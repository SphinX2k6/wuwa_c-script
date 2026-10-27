using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A27 RID: 6695
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudCache")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroPointCloudCache : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018C41 RID: 101441 RVA: 0x002498C1 File Offset: 0x00247AC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPointCloudCache._ClassPtr;
		}

		// Token: 0x06018C42 RID: 101442 RVA: 0x002498D0 File Offset: 0x00247AD0
		public UKuroPointCloudCache() : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018C43 RID: 101443 RVA: 0x002498F8 File Offset: 0x00247AF8
		public UKuroPointCloudCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700622C RID: 25132
		// (get) Token: 0x06018C44 RID: 101444 RVA: 0x0024992C File Offset: 0x00247B2C
		// (set) Token: 0x06018C45 RID: 101445 RVA: 0x00249965 File Offset: 0x00247B65
		public TArray<FVector> PositionCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PositionCache) == null)
				{
					result = (this._PositionCache = new TArray<FVector>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_PositionCache, this));
				}
				return result;
			}
			set
			{
				this.PositionCache.CopyAssign(value);
			}
		}

		// Token: 0x1700622D RID: 25133
		// (get) Token: 0x06018C46 RID: 101446 RVA: 0x00249974 File Offset: 0x00247B74
		// (set) Token: 0x06018C47 RID: 101447 RVA: 0x002499AD File Offset: 0x00247BAD
		public TArray<FQuat> RotationCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._RotationCache) == null)
				{
					result = (this._RotationCache = new TArray<FQuat>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_RotationCache, this));
				}
				return result;
			}
			set
			{
				this.RotationCache.CopyAssign(value);
			}
		}

		// Token: 0x1700622E RID: 25134
		// (get) Token: 0x06018C48 RID: 101448 RVA: 0x002499BC File Offset: 0x00247BBC
		// (set) Token: 0x06018C49 RID: 101449 RVA: 0x002499F5 File Offset: 0x00247BF5
		public TArray<FVector> ScaleCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ScaleCache) == null)
				{
					result = (this._ScaleCache = new TArray<FVector>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_ScaleCache, this));
				}
				return result;
			}
			set
			{
				this.ScaleCache.CopyAssign(value);
			}
		}

		// Token: 0x1700622F RID: 25135
		// (get) Token: 0x06018C4A RID: 101450 RVA: 0x00249A04 File Offset: 0x00247C04
		// (set) Token: 0x06018C4B RID: 101451 RVA: 0x00249A3D File Offset: 0x00247C3D
		public TArray<float> AgeCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AgeCache) == null)
				{
					result = (this._AgeCache = new TArray<float>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_AgeCache, this));
				}
				return result;
			}
			set
			{
				this.AgeCache.CopyAssign(value);
			}
		}

		// Token: 0x17006230 RID: 25136
		// (get) Token: 0x06018C4C RID: 101452 RVA: 0x00249A4C File Offset: 0x00247C4C
		// (set) Token: 0x06018C4D RID: 101453 RVA: 0x00249A85 File Offset: 0x00247C85
		public TArray<int> IndexCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IndexCache) == null)
				{
					result = (this._IndexCache = new TArray<int>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_IndexCache, this));
				}
				return result;
			}
			set
			{
				this.IndexCache.CopyAssign(value);
			}
		}

		// Token: 0x17006231 RID: 25137
		// (get) Token: 0x06018C4E RID: 101454 RVA: 0x00249A94 File Offset: 0x00247C94
		// (set) Token: 0x06018C4F RID: 101455 RVA: 0x00249ACD File Offset: 0x00247CCD
		public TArray<float> FlatCustomFloatCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FlatCustomFloatCache) == null)
				{
					result = (this._FlatCustomFloatCache = new TArray<float>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_FlatCustomFloatCache, this));
				}
				return result;
			}
			set
			{
				this.FlatCustomFloatCache.CopyAssign(value);
			}
		}

		// Token: 0x17006232 RID: 25138
		// (get) Token: 0x06018C50 RID: 101456 RVA: 0x00249ADB File Offset: 0x00247CDB
		// (set) Token: 0x06018C51 RID: 101457 RVA: 0x00249AEB File Offset: 0x00247CEB
		public unsafe int CustomFloatCacheStride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CustomFloatCacheStride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CustomFloatCacheStride) = value;
			}
		}

		// Token: 0x17006233 RID: 25139
		// (get) Token: 0x06018C52 RID: 101458 RVA: 0x00249AFC File Offset: 0x00247CFC
		// (set) Token: 0x06018C53 RID: 101459 RVA: 0x00249B35 File Offset: 0x00247D35
		public TMap<FName, int> CustomFloatCacheDataOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._CustomFloatCacheDataOffsets) == null)
				{
					result = (this._CustomFloatCacheDataOffsets = new TMap<FName, int>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CustomFloatCacheDataOffsets, this));
				}
				return result;
			}
			set
			{
				this.CustomFloatCacheDataOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17006234 RID: 25140
		// (get) Token: 0x06018C54 RID: 101460 RVA: 0x00249B44 File Offset: 0x00247D44
		// (set) Token: 0x06018C55 RID: 101461 RVA: 0x00249B7D File Offset: 0x00247D7D
		public TArray<FKuroPointCloudCacheCustomFloat> CustomFloatCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPointCloudCacheCustomFloat> result;
				if ((result = this._CustomFloatCache) == null)
				{
					result = (this._CustomFloatCache = new TArray<FKuroPointCloudCacheCustomFloat>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CustomFloatCache, this));
				}
				return result;
			}
			set
			{
				this.CustomFloatCache.CopyAssign(value);
			}
		}

		// Token: 0x17006235 RID: 25141
		// (get) Token: 0x06018C56 RID: 101462 RVA: 0x00249B8C File Offset: 0x00247D8C
		// (set) Token: 0x06018C57 RID: 101463 RVA: 0x00249BC5 File Offset: 0x00247DC5
		public TArray<int> CurveMapCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._CurveMapCache) == null)
				{
					result = (this._CurveMapCache = new TArray<int>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CurveMapCache, this));
				}
				return result;
			}
			set
			{
				this.CurveMapCache.CopyAssign(value);
			}
		}

		// Token: 0x17006236 RID: 25142
		// (get) Token: 0x06018C58 RID: 101464 RVA: 0x00249BD4 File Offset: 0x00247DD4
		// (set) Token: 0x06018C59 RID: 101465 RVA: 0x00249C0D File Offset: 0x00247E0D
		public TArray<float> CurveStartTimeCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CurveStartTimeCache) == null)
				{
					result = (this._CurveStartTimeCache = new TArray<float>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CurveStartTimeCache, this));
				}
				return result;
			}
			set
			{
				this.CurveStartTimeCache.CopyAssign(value);
			}
		}

		// Token: 0x17006237 RID: 25143
		// (get) Token: 0x06018C5A RID: 101466 RVA: 0x00249C1C File Offset: 0x00247E1C
		// (set) Token: 0x06018C5B RID: 101467 RVA: 0x00249C55 File Offset: 0x00247E55
		public TArray<float> FlatCurveCustomFloatCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FlatCurveCustomFloatCache) == null)
				{
					result = (this._FlatCurveCustomFloatCache = new TArray<float>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_FlatCurveCustomFloatCache, this));
				}
				return result;
			}
			set
			{
				this.FlatCurveCustomFloatCache.CopyAssign(value);
			}
		}

		// Token: 0x17006238 RID: 25144
		// (get) Token: 0x06018C5C RID: 101468 RVA: 0x00249C63 File Offset: 0x00247E63
		// (set) Token: 0x06018C5D RID: 101469 RVA: 0x00249C73 File Offset: 0x00247E73
		public unsafe int CurveCustomFloatCacheStride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CurveCustomFloatCacheStride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CurveCustomFloatCacheStride) = value;
			}
		}

		// Token: 0x17006239 RID: 25145
		// (get) Token: 0x06018C5E RID: 101470 RVA: 0x00249C84 File Offset: 0x00247E84
		// (set) Token: 0x06018C5F RID: 101471 RVA: 0x00249CBD File Offset: 0x00247EBD
		public TMap<FName, int> CurveCustomFloatCacheDataOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._CurveCustomFloatCacheDataOffsets) == null)
				{
					result = (this._CurveCustomFloatCacheDataOffsets = new TMap<FName, int>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CurveCustomFloatCacheDataOffsets, this));
				}
				return result;
			}
			set
			{
				this.CurveCustomFloatCacheDataOffsets.CopyAssign(value);
			}
		}

		// Token: 0x1700623A RID: 25146
		// (get) Token: 0x06018C60 RID: 101472 RVA: 0x00249CCC File Offset: 0x00247ECC
		// (set) Token: 0x06018C61 RID: 101473 RVA: 0x00249D05 File Offset: 0x00247F05
		public TArray<FKuroPointCloudCacheCustomFloat> CurveCustomFloatCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPointCloudCacheCustomFloat> result;
				if ((result = this._CurveCustomFloatCache) == null)
				{
					result = (this._CurveCustomFloatCache = new TArray<FKuroPointCloudCacheCustomFloat>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_CurveCustomFloatCache, this));
				}
				return result;
			}
			set
			{
				this.CurveCustomFloatCache.CopyAssign(value);
			}
		}

		// Token: 0x1700623B RID: 25147
		// (get) Token: 0x06018C62 RID: 101474 RVA: 0x00249D14 File Offset: 0x00247F14
		// (set) Token: 0x06018C63 RID: 101475 RVA: 0x00249D4D File Offset: 0x00247F4D
		public TMap<FName, int> MetaDataInt
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._MetaDataInt) == null)
				{
					result = (this._MetaDataInt = new TMap<FName, int>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_MetaDataInt, this));
				}
				return result;
			}
			set
			{
				this.MetaDataInt.CopyAssign(value);
			}
		}

		// Token: 0x1700623C RID: 25148
		// (get) Token: 0x06018C64 RID: 101476 RVA: 0x00249D5C File Offset: 0x00247F5C
		// (set) Token: 0x06018C65 RID: 101477 RVA: 0x00249D95 File Offset: 0x00247F95
		public TMap<FName, float> MetaDataFloat
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MetaDataFloat) == null)
				{
					result = (this._MetaDataFloat = new TMap<FName, float>(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_MetaDataFloat, this));
				}
				return result;
			}
			set
			{
				this.MetaDataFloat.CopyAssign(value);
			}
		}

		// Token: 0x1700623D RID: 25149
		// (get) Token: 0x06018C66 RID: 101478 RVA: 0x00249DA3 File Offset: 0x00247FA3
		// (set) Token: 0x06018C67 RID: 101479 RVA: 0x00249DB3 File Offset: 0x00247FB3
		public unsafe int NumPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_NumPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_NumPoints) = value;
			}
		}

		// Token: 0x1700623E RID: 25150
		// (get) Token: 0x06018C68 RID: 101480 RVA: 0x00249DC4 File Offset: 0x00247FC4
		// (set) Token: 0x06018C69 RID: 101481 RVA: 0x00249DD4 File Offset: 0x00247FD4
		public unsafe int NumCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_NumCurves);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_NumCurves) = value;
			}
		}

		// Token: 0x1700623F RID: 25151
		// (get) Token: 0x06018C6A RID: 101482 RVA: 0x00249DE5 File Offset: 0x00247FE5
		// (set) Token: 0x06018C6B RID: 101483 RVA: 0x00249DF5 File Offset: 0x00247FF5
		public unsafe bool ReleaseCPUData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_ReleaseCPUData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_ReleaseCPUData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006240 RID: 25152
		// (get) Token: 0x06018C6C RID: 101484 RVA: 0x00249E06 File Offset: 0x00248006
		// (set) Token: 0x06018C6D RID: 101485 RVA: 0x00249E16 File Offset: 0x00248016
		public unsafe bool bIsCookedPlatformWithCPUDataReleased
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_bIsCookedPlatformWithCPUDataReleased) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudCache.__PropertyOffset_bIsCookedPlatformWithCPUDataReleased) = (value ? 1 : 0);
			}
		}

		// Token: 0x06018C6E RID: 101486 RVA: 0x00249E28 File Offset: 0x00248028
		[NullableContext(2)]
		public bool UpdateFromDataEx(in TArray<FVector> Positions, in TArray<FQuat> Rotations, in TArray<FVector> Scales, in TArray<float> Ages, in TArray<int> Indices, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroPointCloudCacheCustomFloat> CustomFloats, in TArray<float> CurveStartTimes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroPointCloudCacheCustomFloat> CurveCustomFloats)
		{
			return UKuroPointCloudCache.__UpdateFromDataEx_Internal(base.NativePtr, (Positions ?? new TArray<FVector>()).NativePtr, (Rotations ?? new TArray<FQuat>()).NativePtr, (Scales ?? new TArray<FVector>()).NativePtr, (Ages ?? new TArray<float>()).NativePtr, (Indices ?? new TArray<int>()).NativePtr, (CustomFloats ?? new TArray<FKuroPointCloudCacheCustomFloat>()).NativePtr, (CurveStartTimes ?? new TArray<float>()).NativePtr, (CurveCustomFloats ?? new TArray<FKuroPointCloudCacheCustomFloat>()).NativePtr);
		}

		// Token: 0x06018C6F RID: 101487 RVA: 0x00249EC5 File Offset: 0x002480C5
		[NullableContext(2)]
		public bool UpdateFromData(in TArray<FVector> Positions, in TArray<FQuat> Rotations, in TArray<FVector> Scales)
		{
			return UKuroPointCloudCache.__UpdateFromData_Internal(base.NativePtr, (Positions ?? new TArray<FVector>()).NativePtr, (Rotations ?? new TArray<FQuat>()).NativePtr, (Scales ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06018C70 RID: 101488 RVA: 0x00249F02 File Offset: 0x00248102
		public void SetMetaDataInt(FName Name, int Value)
		{
			UKuroPointCloudCache.__SetMetaDataInt_Internal(base.NativePtr, Name, Value);
		}

		// Token: 0x06018C71 RID: 101489 RVA: 0x00249F11 File Offset: 0x00248111
		public void SetMetaDataFloat(FName Name, float Value)
		{
			UKuroPointCloudCache.__SetMetaDataFloat_Internal(base.NativePtr, Name, Value);
		}

		// Token: 0x06018C72 RID: 101490 RVA: 0x00249F20 File Offset: 0x00248120
		public bool HasMetaDataInt(FName Name)
		{
			return UKuroPointCloudCache.__HasMetaDataInt_Internal(base.NativePtr, Name);
		}

		// Token: 0x06018C73 RID: 101491 RVA: 0x00249F2E File Offset: 0x0024812E
		public bool HasMetaDataFloat(FName Name)
		{
			return UKuroPointCloudCache.__HasMetaDataFloat_Internal(base.NativePtr, Name);
		}

		// Token: 0x06018C74 RID: 101492 RVA: 0x00249F3C File Offset: 0x0024813C
		public int GetMetaDataInt(FName Name)
		{
			return UKuroPointCloudCache.__GetMetaDataInt_Internal(base.NativePtr, Name);
		}

		// Token: 0x06018C75 RID: 101493 RVA: 0x00249F4A File Offset: 0x0024814A
		public float GetMetaDataFloat(FName Name)
		{
			return UKuroPointCloudCache.__GetMetaDataFloat_Internal(base.NativePtr, Name);
		}

		// Token: 0x06018C76 RID: 101494 RVA: 0x00249F58 File Offset: 0x00248158
		public bool CheckConsistency(bool Verbosity = true)
		{
			return UKuroPointCloudCache.__CheckConsistency_Internal(base.NativePtr, Verbosity);
		}

		// Token: 0x06018C77 RID: 101495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UpdateFromDataEx_Internal(IntPtr @this, IntPtr Positions, IntPtr Rotations, IntPtr Scales, IntPtr Ages, IntPtr Indices, IntPtr CustomFloats, IntPtr CurveStartTimes, IntPtr CurveCustomFloats);

		// Token: 0x06018C78 RID: 101496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UpdateFromData_Internal(IntPtr @this, IntPtr Positions, IntPtr Rotations, IntPtr Scales);

		// Token: 0x06018C79 RID: 101497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMetaDataInt_Internal(IntPtr @this, FName Name, int Value);

		// Token: 0x06018C7A RID: 101498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMetaDataFloat_Internal(IntPtr @this, FName Name, float Value);

		// Token: 0x06018C7B RID: 101499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMetaDataInt_Internal(IntPtr @this, FName Name);

		// Token: 0x06018C7C RID: 101500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMetaDataFloat_Internal(IntPtr @this, FName Name);

		// Token: 0x06018C7D RID: 101501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMetaDataInt_Internal(IntPtr @this, FName Name);

		// Token: 0x06018C7E RID: 101502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMetaDataFloat_Internal(IntPtr @this, FName Name);

		// Token: 0x06018C7F RID: 101503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckConsistency_Internal(IntPtr @this, bool Verbosity);

		// Token: 0x06018C80 RID: 101504 RVA: 0x00249F66 File Offset: 0x00248166
		static UKuroPointCloudCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudCache");
		}

		// Token: 0x06018C81 RID: 101505 RVA: 0x00249F74 File Offset: 0x00248174
		protected UKuroPointCloudCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D643 RID: 54851
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudCache";

		// Token: 0x0400D644 RID: 54852
		private static IntPtr _ClassPtr;

		// Token: 0x0400D645 RID: 54853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D646 RID: 54854
		internal static int __PropertyOffset_PositionCache;

		// Token: 0x0400D647 RID: 54855
		[Nullable(2)]
		private TArray<FVector> _PositionCache;

		// Token: 0x0400D648 RID: 54856
		internal static int __PropertyOffset_RotationCache;

		// Token: 0x0400D649 RID: 54857
		[Nullable(2)]
		private TArray<FQuat> _RotationCache;

		// Token: 0x0400D64A RID: 54858
		internal static int __PropertyOffset_ScaleCache;

		// Token: 0x0400D64B RID: 54859
		[Nullable(2)]
		private TArray<FVector> _ScaleCache;

		// Token: 0x0400D64C RID: 54860
		internal static int __PropertyOffset_AgeCache;

		// Token: 0x0400D64D RID: 54861
		[Nullable(2)]
		private TArray<float> _AgeCache;

		// Token: 0x0400D64E RID: 54862
		internal static int __PropertyOffset_IndexCache;

		// Token: 0x0400D64F RID: 54863
		[Nullable(2)]
		private TArray<int> _IndexCache;

		// Token: 0x0400D650 RID: 54864
		internal static int __PropertyOffset_FlatCustomFloatCache;

		// Token: 0x0400D651 RID: 54865
		[Nullable(2)]
		private TArray<float> _FlatCustomFloatCache;

		// Token: 0x0400D652 RID: 54866
		internal static int __PropertyOffset_CustomFloatCacheStride;

		// Token: 0x0400D653 RID: 54867
		internal static int __PropertyOffset_CustomFloatCacheDataOffsets;

		// Token: 0x0400D654 RID: 54868
		[Nullable(2)]
		private TMap<FName, int> _CustomFloatCacheDataOffsets;

		// Token: 0x0400D655 RID: 54869
		internal static int __PropertyOffset_CustomFloatCache;

		// Token: 0x0400D656 RID: 54870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPointCloudCacheCustomFloat> _CustomFloatCache;

		// Token: 0x0400D657 RID: 54871
		internal static int __PropertyOffset_CurveMapCache;

		// Token: 0x0400D658 RID: 54872
		[Nullable(2)]
		private TArray<int> _CurveMapCache;

		// Token: 0x0400D659 RID: 54873
		internal static int __PropertyOffset_CurveStartTimeCache;

		// Token: 0x0400D65A RID: 54874
		[Nullable(2)]
		private TArray<float> _CurveStartTimeCache;

		// Token: 0x0400D65B RID: 54875
		internal static int __PropertyOffset_FlatCurveCustomFloatCache;

		// Token: 0x0400D65C RID: 54876
		[Nullable(2)]
		private TArray<float> _FlatCurveCustomFloatCache;

		// Token: 0x0400D65D RID: 54877
		internal static int __PropertyOffset_CurveCustomFloatCacheStride;

		// Token: 0x0400D65E RID: 54878
		internal static int __PropertyOffset_CurveCustomFloatCacheDataOffsets;

		// Token: 0x0400D65F RID: 54879
		[Nullable(2)]
		private TMap<FName, int> _CurveCustomFloatCacheDataOffsets;

		// Token: 0x0400D660 RID: 54880
		internal static int __PropertyOffset_CurveCustomFloatCache;

		// Token: 0x0400D661 RID: 54881
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPointCloudCacheCustomFloat> _CurveCustomFloatCache;

		// Token: 0x0400D662 RID: 54882
		internal static int __PropertyOffset_MetaDataInt;

		// Token: 0x0400D663 RID: 54883
		[Nullable(2)]
		private TMap<FName, int> _MetaDataInt;

		// Token: 0x0400D664 RID: 54884
		internal static int __PropertyOffset_MetaDataFloat;

		// Token: 0x0400D665 RID: 54885
		[Nullable(2)]
		private TMap<FName, float> _MetaDataFloat;

		// Token: 0x0400D666 RID: 54886
		internal static int __PropertyOffset_NumPoints;

		// Token: 0x0400D667 RID: 54887
		internal static int __PropertyOffset_NumCurves;

		// Token: 0x0400D668 RID: 54888
		internal static int __PropertyOffset_ReleaseCPUData;

		// Token: 0x0400D669 RID: 54889
		internal static int __PropertyOffset_bIsCookedPlatformWithCPUDataReleased;
	}
}
