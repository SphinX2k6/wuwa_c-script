using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001070 RID: 4208
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RBFPrecomputation")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FRBFPrecomputation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF66 RID: 61286 RVA: 0x00163013 File Offset: 0x00161213
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFPrecomputation._ScriptStructPtr != 0) ? FRBFPrecomputation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RBFPrecomputation", ref FRBFPrecomputation._ScriptStructPtr);
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600EF67 RID: 61287 RVA: 0x00163037 File Offset: 0x00161237
		// (set) Token: 0x0600EF68 RID: 61288 RVA: 0x00163047 File Offset: 0x00161247
		public unsafe float RotationLimitX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_RotationLimitX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_RotationLimitX) = value;
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600EF69 RID: 61289 RVA: 0x00163058 File Offset: 0x00161258
		// (set) Token: 0x0600EF6A RID: 61290 RVA: 0x00163068 File Offset: 0x00161268
		public unsafe float RotationLimitY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_RotationLimitY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_RotationLimitY) = value;
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0600EF6B RID: 61291 RVA: 0x00163079 File Offset: 0x00161279
		// (set) Token: 0x0600EF6C RID: 61292 RVA: 0x00163089 File Offset: 0x00161289
		public unsafe float RotationLimitZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_RotationLimitZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_RotationLimitZ) = value;
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0600EF6D RID: 61293 RVA: 0x0016309A File Offset: 0x0016129A
		// (set) Token: 0x0600EF6E RID: 61294 RVA: 0x001630AA File Offset: 0x001612AA
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0600EF6F RID: 61295 RVA: 0x001630BC File Offset: 0x001612BC
		// (set) Token: 0x0600EF70 RID: 61296 RVA: 0x001630FF File Offset: 0x001612FF
		public TArray<FRBFDataList> PreWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRBFDataList> result;
				if ((result = this._PreWeights) == null)
				{
					result = (this._PreWeights = new TArray<FRBFDataList>(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_PreWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PreWeights.CopyAssign(value);
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0600EF71 RID: 61297 RVA: 0x0016310D File Offset: 0x0016130D
		// (set) Token: 0x0600EF72 RID: 61298 RVA: 0x0016311D File Offset: 0x0016131D
		public unsafe float PrecomputeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_PrecomputeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_PrecomputeRadius) = value;
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0600EF73 RID: 61299 RVA: 0x00163130 File Offset: 0x00161330
		// (set) Token: 0x0600EF74 RID: 61300 RVA: 0x00163173 File Offset: 0x00161373
		public TArray<float> LookupAngleXY
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LookupAngleXY) == null)
				{
					result = (this._LookupAngleXY = new TArray<float>(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_LookupAngleXY, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LookupAngleXY.CopyAssign(value);
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0600EF75 RID: 61301 RVA: 0x00163184 File Offset: 0x00161384
		// (set) Token: 0x0600EF76 RID: 61302 RVA: 0x001631C7 File Offset: 0x001613C7
		public TArray<float> LookupAngleZ
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LookupAngleZ) == null)
				{
					result = (this._LookupAngleZ = new TArray<float>(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_LookupAngleZ, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LookupAngleZ.CopyAssign(value);
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600EF77 RID: 61303 RVA: 0x001631D8 File Offset: 0x001613D8
		// (set) Token: 0x0600EF78 RID: 61304 RVA: 0x0016321B File Offset: 0x0016141B
		public TMap<FRBFLookupIndex, int> WeightLookupTable
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FRBFLookupIndex, int> result;
				if ((result = this._WeightLookupTable) == null)
				{
					result = (this._WeightLookupTable = new TMap<FRBFLookupIndex, int>(base.NativePtr + (IntPtr)FRBFPrecomputation.__PropertyOffset_WeightLookupTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WeightLookupTable.CopyAssign(value);
			}
		}

		// Token: 0x0600EF79 RID: 61305 RVA: 0x00163229 File Offset: 0x00161429
		public FRBFPrecomputation()
		{
		}

		// Token: 0x0600EF7A RID: 61306 RVA: 0x00163234 File Offset: 0x00161434
		public FRBFPrecomputation(float RotationLimitX, float RotationLimitY, float RotationLimitZ, float Interval, int NumData, TArray<FVector> PreLocations, TArray<FRBFDataList> PreWeights, float PrecomputeRadius, TArray<float> LookupAngleXY, TArray<float> LookupAngleZ, TMap<FRBFLookupIndex, int> WeightLookupTable)
		{
			this.RotationLimitX = RotationLimitX;
			this.RotationLimitY = RotationLimitY;
			this.RotationLimitZ = RotationLimitZ;
			this.Interval = Interval;
			this.PreWeights = PreWeights;
			this.PrecomputeRadius = PrecomputeRadius;
			this.LookupAngleXY = LookupAngleXY;
			this.LookupAngleZ = LookupAngleZ;
			this.WeightLookupTable = WeightLookupTable;
		}

		// Token: 0x0600EF7B RID: 61307 RVA: 0x0016328C File Offset: 0x0016148C
		protected override IntPtr GetUStructPtr()
		{
			return FRBFPrecomputation.StaticStruct();
		}

		// Token: 0x0600EF7C RID: 61308 RVA: 0x00163298 File Offset: 0x00161498
		[NullableContext(2)]
		public FRBFPrecomputation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF7D RID: 61309 RVA: 0x001632A2 File Offset: 0x001614A2
		public FRBFPrecomputation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF7E RID: 61310 RVA: 0x001632AD File Offset: 0x001614AD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFPrecomputation(Pointer, false, true);
		}

		// Token: 0x0600EF7F RID: 61311 RVA: 0x001632B7 File Offset: 0x001614B7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFPrecomputation(Pointer, MemoryOwner);
		}

		// Token: 0x04008187 RID: 33159
		public const string __ObjectPath = "/Script/Engine.RBFPrecomputation";

		// Token: 0x04008188 RID: 33160
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008189 RID: 33161
		internal static int __PropertyOffset_RotationLimitX;

		// Token: 0x0400818A RID: 33162
		internal static int __PropertyOffset_RotationLimitY;

		// Token: 0x0400818B RID: 33163
		internal static int __PropertyOffset_RotationLimitZ;

		// Token: 0x0400818C RID: 33164
		internal static int __PropertyOffset_Interval;

		// Token: 0x0400818D RID: 33165
		internal static int __PropertyOffset_PreWeights;

		// Token: 0x0400818E RID: 33166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRBFDataList> _PreWeights;

		// Token: 0x0400818F RID: 33167
		internal static int __PropertyOffset_PrecomputeRadius;

		// Token: 0x04008190 RID: 33168
		internal static int __PropertyOffset_LookupAngleXY;

		// Token: 0x04008191 RID: 33169
		[Nullable(2)]
		private TArray<float> _LookupAngleXY;

		// Token: 0x04008192 RID: 33170
		internal static int __PropertyOffset_LookupAngleZ;

		// Token: 0x04008193 RID: 33171
		[Nullable(2)]
		private TArray<float> _LookupAngleZ;

		// Token: 0x04008194 RID: 33172
		internal static int __PropertyOffset_WeightLookupTable;

		// Token: 0x04008195 RID: 33173
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FRBFLookupIndex, int> _WeightLookupTable;
	}
}
