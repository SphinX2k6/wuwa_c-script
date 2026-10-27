using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C7C RID: 7292
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeVerletDataAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class URopeVerletDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C4F3 RID: 115955 RVA: 0x0029BA40 File Offset: 0x00299C40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeVerletDataAsset._ClassPtr;
		}

		// Token: 0x0601C4F4 RID: 115956 RVA: 0x0029BA4C File Offset: 0x00299C4C
		public URopeVerletDataAsset() : this(BuiltinUtils.AllocNativeUObject(URopeVerletDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C4F5 RID: 115957 RVA: 0x0029BA74 File Offset: 0x00299C74
		[NullableContext(1)]
		public URopeVerletDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeVerletDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007274 RID: 29300
		// (get) Token: 0x0601C4F6 RID: 115958 RVA: 0x0029BAA7 File Offset: 0x00299CA7
		// (set) Token: 0x0601C4F7 RID: 115959 RVA: 0x0029BAB7 File Offset: 0x00299CB7
		public unsafe int SegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_SegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_SegmentCount) = value;
			}
		}

		// Token: 0x17007275 RID: 29301
		// (get) Token: 0x0601C4F8 RID: 115960 RVA: 0x0029BAC8 File Offset: 0x00299CC8
		// (set) Token: 0x0601C4F9 RID: 115961 RVA: 0x0029BADC File Offset: 0x00299CDC
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17007276 RID: 29302
		// (get) Token: 0x0601C4FA RID: 115962 RVA: 0x0029BAF1 File Offset: 0x00299CF1
		// (set) Token: 0x0601C4FB RID: 115963 RVA: 0x0029BB01 File Offset: 0x00299D01
		public unsafe float MaxTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_MaxTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_MaxTimeStep) = value;
			}
		}

		// Token: 0x17007277 RID: 29303
		// (get) Token: 0x0601C4FC RID: 115964 RVA: 0x0029BB12 File Offset: 0x00299D12
		// (set) Token: 0x0601C4FD RID: 115965 RVA: 0x0029BB22 File Offset: 0x00299D22
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17007278 RID: 29304
		// (get) Token: 0x0601C4FE RID: 115966 RVA: 0x0029BB33 File Offset: 0x00299D33
		// (set) Token: 0x0601C4FF RID: 115967 RVA: 0x0029BB43 File Offset: 0x00299D43
		public unsafe int ConstraintIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_ConstraintIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_ConstraintIterations) = value;
			}
		}

		// Token: 0x17007279 RID: 29305
		// (get) Token: 0x0601C500 RID: 115968 RVA: 0x0029BB54 File Offset: 0x00299D54
		// (set) Token: 0x0601C501 RID: 115969 RVA: 0x0029BB64 File Offset: 0x00299D64
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x1700727A RID: 29306
		// (get) Token: 0x0601C502 RID: 115970 RVA: 0x0029BB75 File Offset: 0x00299D75
		// (set) Token: 0x0601C503 RID: 115971 RVA: 0x0029BB85 File Offset: 0x00299D85
		public unsafe bool bPinStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_bPinStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_bPinStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700727B RID: 29307
		// (get) Token: 0x0601C504 RID: 115972 RVA: 0x0029BB96 File Offset: 0x00299D96
		// (set) Token: 0x0601C505 RID: 115973 RVA: 0x0029BBA6 File Offset: 0x00299DA6
		public unsafe bool bPinEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_bPinEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_bPinEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700727C RID: 29308
		// (get) Token: 0x0601C506 RID: 115974 RVA: 0x0029BBB7 File Offset: 0x00299DB7
		// (set) Token: 0x0601C507 RID: 115975 RVA: 0x0029BBC7 File Offset: 0x00299DC7
		public unsafe float TensionPropagation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_TensionPropagation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_TensionPropagation) = value;
			}
		}

		// Token: 0x1700727D RID: 29309
		// (get) Token: 0x0601C508 RID: 115976 RVA: 0x0029BBD8 File Offset: 0x00299DD8
		// (set) Token: 0x0601C509 RID: 115977 RVA: 0x0029BBE8 File Offset: 0x00299DE8
		public unsafe float TensionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_TensionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_TensionStrength) = value;
			}
		}

		// Token: 0x1700727E RID: 29310
		// (get) Token: 0x0601C50A RID: 115978 RVA: 0x0029BBF9 File Offset: 0x00299DF9
		// (set) Token: 0x0601C50B RID: 115979 RVA: 0x0029BC09 File Offset: 0x00299E09
		public unsafe float VelocityAmplification
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_VelocityAmplification);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_VelocityAmplification) = value;
			}
		}

		// Token: 0x1700727F RID: 29311
		// (get) Token: 0x0601C50C RID: 115980 RVA: 0x0029BC1A File Offset: 0x00299E1A
		// (set) Token: 0x0601C50D RID: 115981 RVA: 0x0029BC2A File Offset: 0x00299E2A
		public unsafe float QuickStabilizeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_QuickStabilizeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_QuickStabilizeThreshold) = value;
			}
		}

		// Token: 0x17007280 RID: 29312
		// (get) Token: 0x0601C50E RID: 115982 RVA: 0x0029BC3B File Offset: 0x00299E3B
		// (set) Token: 0x0601C50F RID: 115983 RVA: 0x0029BC4B File Offset: 0x00299E4B
		public unsafe float QuickStabilizeDampingMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_QuickStabilizeDampingMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_QuickStabilizeDampingMultiplier) = value;
			}
		}

		// Token: 0x17007281 RID: 29313
		// (get) Token: 0x0601C510 RID: 115984 RVA: 0x0029BC5C File Offset: 0x00299E5C
		// (set) Token: 0x0601C511 RID: 115985 RVA: 0x0029BC6C File Offset: 0x00299E6C
		public unsafe float FallbackForwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_FallbackForwardOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletDataAsset.__PropertyOffset_FallbackForwardOffset) = value;
			}
		}

		// Token: 0x0601C512 RID: 115986 RVA: 0x0029BC7D File Offset: 0x00299E7D
		static URopeVerletDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeVerletDataAsset");
		}

		// Token: 0x0601C513 RID: 115987 RVA: 0x0029BC8B File Offset: 0x00299E8B
		protected URopeVerletDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F384 RID: 62340
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeVerletDataAsset";

		// Token: 0x0400F385 RID: 62341
		private static IntPtr _ClassPtr;

		// Token: 0x0400F386 RID: 62342
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F387 RID: 62343
		internal static int __PropertyOffset_SegmentCount;

		// Token: 0x0400F388 RID: 62344
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400F389 RID: 62345
		internal static int __PropertyOffset_MaxTimeStep;

		// Token: 0x0400F38A RID: 62346
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400F38B RID: 62347
		internal static int __PropertyOffset_ConstraintIterations;

		// Token: 0x0400F38C RID: 62348
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400F38D RID: 62349
		internal static int __PropertyOffset_bPinStart;

		// Token: 0x0400F38E RID: 62350
		internal static int __PropertyOffset_bPinEnd;

		// Token: 0x0400F38F RID: 62351
		internal static int __PropertyOffset_TensionPropagation;

		// Token: 0x0400F390 RID: 62352
		internal static int __PropertyOffset_TensionStrength;

		// Token: 0x0400F391 RID: 62353
		internal static int __PropertyOffset_VelocityAmplification;

		// Token: 0x0400F392 RID: 62354
		internal static int __PropertyOffset_QuickStabilizeThreshold;

		// Token: 0x0400F393 RID: 62355
		internal static int __PropertyOffset_QuickStabilizeDampingMultiplier;

		// Token: 0x0400F394 RID: 62356
		internal static int __PropertyOffset_FallbackForwardOffset;
	}
}
