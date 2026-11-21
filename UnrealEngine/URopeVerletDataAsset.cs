using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200051C RID: 1308
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeVerletDataAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class URopeVerletDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A7B RID: 31355 RVA: 0x000B3AC7 File Offset: 0x000B1CC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeVerletDataAsset._ClassPtr;
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x000B3AD4 File Offset: 0x000B1CD4
		public URopeVerletDataAsset() : this(BuiltinUtils.AllocNativeUObject(URopeVerletDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x000B3AFC File Offset: 0x000B1CFC
		[NullableContext(1)]
		public URopeVerletDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeVerletDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x000B3B2F File Offset: 0x000B1D2F
		// (set) Token: 0x06007A7F RID: 31359 RVA: 0x000B3B3F File Offset: 0x000B1D3F
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

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x000B3B50 File Offset: 0x000B1D50
		// (set) Token: 0x06007A81 RID: 31361 RVA: 0x000B3B64 File Offset: 0x000B1D64
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

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06007A82 RID: 31362 RVA: 0x000B3B79 File Offset: 0x000B1D79
		// (set) Token: 0x06007A83 RID: 31363 RVA: 0x000B3B89 File Offset: 0x000B1D89
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

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06007A84 RID: 31364 RVA: 0x000B3B9A File Offset: 0x000B1D9A
		// (set) Token: 0x06007A85 RID: 31365 RVA: 0x000B3BAA File Offset: 0x000B1DAA
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

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06007A86 RID: 31366 RVA: 0x000B3BBB File Offset: 0x000B1DBB
		// (set) Token: 0x06007A87 RID: 31367 RVA: 0x000B3BCB File Offset: 0x000B1DCB
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

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x000B3BDC File Offset: 0x000B1DDC
		// (set) Token: 0x06007A89 RID: 31369 RVA: 0x000B3BEC File Offset: 0x000B1DEC
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

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06007A8A RID: 31370 RVA: 0x000B3BFD File Offset: 0x000B1DFD
		// (set) Token: 0x06007A8B RID: 31371 RVA: 0x000B3C0D File Offset: 0x000B1E0D
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

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x000B3C1E File Offset: 0x000B1E1E
		// (set) Token: 0x06007A8D RID: 31373 RVA: 0x000B3C2E File Offset: 0x000B1E2E
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

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x000B3C3F File Offset: 0x000B1E3F
		// (set) Token: 0x06007A8F RID: 31375 RVA: 0x000B3C4F File Offset: 0x000B1E4F
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

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x000B3C60 File Offset: 0x000B1E60
		// (set) Token: 0x06007A91 RID: 31377 RVA: 0x000B3C70 File Offset: 0x000B1E70
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

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x000B3C81 File Offset: 0x000B1E81
		// (set) Token: 0x06007A93 RID: 31379 RVA: 0x000B3C91 File Offset: 0x000B1E91
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

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x000B3CA2 File Offset: 0x000B1EA2
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x000B3CB2 File Offset: 0x000B1EB2
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

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06007A96 RID: 31382 RVA: 0x000B3CC3 File Offset: 0x000B1EC3
		// (set) Token: 0x06007A97 RID: 31383 RVA: 0x000B3CD3 File Offset: 0x000B1ED3
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

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06007A98 RID: 31384 RVA: 0x000B3CE4 File Offset: 0x000B1EE4
		// (set) Token: 0x06007A99 RID: 31385 RVA: 0x000B3CF4 File Offset: 0x000B1EF4
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

		// Token: 0x06007A9A RID: 31386 RVA: 0x000B3D05 File Offset: 0x000B1F05
		static URopeVerletDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeVerletDataAsset");
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x000B3D13 File Offset: 0x000B1F13
		protected URopeVerletDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003413 RID: 13331
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeVerletDataAsset";

		// Token: 0x04003414 RID: 13332
		private static IntPtr _ClassPtr;

		// Token: 0x04003415 RID: 13333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003416 RID: 13334
		internal static int __PropertyOffset_SegmentCount;

		// Token: 0x04003417 RID: 13335
		internal static int __PropertyOffset_Gravity;

		// Token: 0x04003418 RID: 13336
		internal static int __PropertyOffset_MaxTimeStep;

		// Token: 0x04003419 RID: 13337
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400341A RID: 13338
		internal static int __PropertyOffset_ConstraintIterations;

		// Token: 0x0400341B RID: 13339
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400341C RID: 13340
		internal static int __PropertyOffset_bPinStart;

		// Token: 0x0400341D RID: 13341
		internal static int __PropertyOffset_bPinEnd;

		// Token: 0x0400341E RID: 13342
		internal static int __PropertyOffset_TensionPropagation;

		// Token: 0x0400341F RID: 13343
		internal static int __PropertyOffset_TensionStrength;

		// Token: 0x04003420 RID: 13344
		internal static int __PropertyOffset_VelocityAmplification;

		// Token: 0x04003421 RID: 13345
		internal static int __PropertyOffset_QuickStabilizeThreshold;

		// Token: 0x04003422 RID: 13346
		internal static int __PropertyOffset_QuickStabilizeDampingMultiplier;

		// Token: 0x04003423 RID: 13347
		internal static int __PropertyOffset_FallbackForwardOffset;
	}
}
