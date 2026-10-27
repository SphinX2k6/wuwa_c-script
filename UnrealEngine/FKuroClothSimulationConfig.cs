using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200179C RID: 6044
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothSimulationConfig")]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroClothSimulationConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015C8F RID: 89231 RVA: 0x00200024 File Offset: 0x001FE224
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroClothSimulationConfig._ScriptStructPtr != 0) ? FKuroClothSimulationConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroClothSimulationConfig", ref FKuroClothSimulationConfig._ScriptStructPtr);
		}

		// Token: 0x17005648 RID: 22088
		// (get) Token: 0x06015C90 RID: 89232 RVA: 0x00200048 File Offset: 0x001FE248
		// (set) Token: 0x06015C91 RID: 89233 RVA: 0x00200058 File Offset: 0x001FE258
		public unsafe float DistanceStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_DistanceStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_DistanceStiffness) = value;
			}
		}

		// Token: 0x17005649 RID: 22089
		// (get) Token: 0x06015C92 RID: 89234 RVA: 0x00200069 File Offset: 0x001FE269
		// (set) Token: 0x06015C93 RID: 89235 RVA: 0x00200079 File Offset: 0x001FE279
		public unsafe float BendingStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_BendingStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_BendingStiffness) = value;
			}
		}

		// Token: 0x1700564A RID: 22090
		// (get) Token: 0x06015C94 RID: 89236 RVA: 0x0020008A File Offset: 0x001FE28A
		// (set) Token: 0x06015C95 RID: 89237 RVA: 0x0020009A File Offset: 0x001FE29A
		public unsafe EKuroClothBendingTopology BendingTopology
		{
			get
			{
				return (EKuroClothBendingTopology)(*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_BendingTopology));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_BendingTopology) = (byte)value;
			}
		}

		// Token: 0x1700564B RID: 22091
		// (get) Token: 0x06015C96 RID: 89238 RVA: 0x002000AB File Offset: 0x001FE2AB
		// (set) Token: 0x06015C97 RID: 89239 RVA: 0x002000BB File Offset: 0x001FE2BB
		public unsafe float VolumeDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_VolumeDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_VolumeDamping) = value;
			}
		}

		// Token: 0x1700564C RID: 22092
		// (get) Token: 0x06015C98 RID: 89240 RVA: 0x002000CC File Offset: 0x001FE2CC
		// (set) Token: 0x06015C99 RID: 89241 RVA: 0x002000E0 File Offset: 0x001FE2E0
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x1700564D RID: 22093
		// (get) Token: 0x06015C9A RID: 89242 RVA: 0x002000F5 File Offset: 0x001FE2F5
		// (set) Token: 0x06015C9B RID: 89243 RVA: 0x00200105 File Offset: 0x001FE305
		public unsafe float GravityDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_GravityDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_GravityDistance) = value;
			}
		}

		// Token: 0x1700564E RID: 22094
		// (get) Token: 0x06015C9C RID: 89244 RVA: 0x00200116 File Offset: 0x001FE316
		// (set) Token: 0x06015C9D RID: 89245 RVA: 0x00200126 File Offset: 0x001FE326
		public unsafe bool bClothPathEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_bClothPathEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_bClothPathEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700564F RID: 22095
		// (get) Token: 0x06015C9E RID: 89246 RVA: 0x00200137 File Offset: 0x001FE337
		// (set) Token: 0x06015C9F RID: 89247 RVA: 0x00200147 File Offset: 0x001FE347
		public unsafe float ClothPathRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathRadius) = value;
			}
		}

		// Token: 0x17005650 RID: 22096
		// (get) Token: 0x06015CA0 RID: 89248 RVA: 0x00200158 File Offset: 0x001FE358
		// (set) Token: 0x06015CA1 RID: 89249 RVA: 0x00200168 File Offset: 0x001FE368
		public unsafe float ClothPathUpOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathUpOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathUpOffset) = value;
			}
		}

		// Token: 0x17005651 RID: 22097
		// (get) Token: 0x06015CA2 RID: 89250 RVA: 0x00200179 File Offset: 0x001FE379
		// (set) Token: 0x06015CA3 RID: 89251 RVA: 0x00200189 File Offset: 0x001FE389
		public unsafe float ClothPathAttenuationPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathAttenuationPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathAttenuationPower) = value;
			}
		}

		// Token: 0x17005652 RID: 22098
		// (get) Token: 0x06015CA4 RID: 89252 RVA: 0x0020019A File Offset: 0x001FE39A
		// (set) Token: 0x06015CA5 RID: 89253 RVA: 0x002001AA File Offset: 0x001FE3AA
		public unsafe float ClothPathRecoveryStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathRecoveryStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathRecoveryStiffness) = value;
			}
		}

		// Token: 0x17005653 RID: 22099
		// (get) Token: 0x06015CA6 RID: 89254 RVA: 0x002001BB File Offset: 0x001FE3BB
		// (set) Token: 0x06015CA7 RID: 89255 RVA: 0x002001CB File Offset: 0x001FE3CB
		public unsafe float ClothPathNormalThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathNormalThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothSimulationConfig.__PropertyOffset_ClothPathNormalThreshold) = value;
			}
		}

		// Token: 0x06015CA8 RID: 89256 RVA: 0x002001DC File Offset: 0x001FE3DC
		public FKuroClothSimulationConfig()
		{
		}

		// Token: 0x06015CA9 RID: 89257 RVA: 0x002001E4 File Offset: 0x001FE3E4
		public FKuroClothSimulationConfig(float DistanceStiffness, float BendingStiffness, EKuroClothBendingTopology BendingTopology, float VolumeDamping, FVector Gravity, float GravityDistance, bool bClothPathEnabled, float ClothPathRadius, float ClothPathUpOffset, float ClothPathAttenuationPower, float ClothPathRecoveryStiffness, float ClothPathNormalThreshold)
		{
			this.DistanceStiffness = DistanceStiffness;
			this.BendingStiffness = BendingStiffness;
			this.BendingTopology = BendingTopology;
			this.VolumeDamping = VolumeDamping;
			this.Gravity = Gravity;
			this.GravityDistance = GravityDistance;
			this.bClothPathEnabled = bClothPathEnabled;
			this.ClothPathRadius = ClothPathRadius;
			this.ClothPathUpOffset = ClothPathUpOffset;
			this.ClothPathAttenuationPower = ClothPathAttenuationPower;
			this.ClothPathRecoveryStiffness = ClothPathRecoveryStiffness;
			this.ClothPathNormalThreshold = ClothPathNormalThreshold;
		}

		// Token: 0x06015CAA RID: 89258 RVA: 0x00200254 File Offset: 0x001FE454
		protected override IntPtr GetUStructPtr()
		{
			return FKuroClothSimulationConfig.StaticStruct();
		}

		// Token: 0x06015CAB RID: 89259 RVA: 0x00200260 File Offset: 0x001FE460
		[NullableContext(2)]
		public FKuroClothSimulationConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015CAC RID: 89260 RVA: 0x0020026A File Offset: 0x001FE46A
		public FKuroClothSimulationConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015CAD RID: 89261 RVA: 0x00200275 File Offset: 0x001FE475
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroClothSimulationConfig(Pointer, false, true);
		}

		// Token: 0x06015CAE RID: 89262 RVA: 0x0020027F File Offset: 0x001FE47F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroClothSimulationConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE31 RID: 48689
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroClothSimulationConfig";

		// Token: 0x0400BE32 RID: 48690
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE33 RID: 48691
		internal static int __PropertyOffset_DistanceStiffness;

		// Token: 0x0400BE34 RID: 48692
		internal static int __PropertyOffset_BendingStiffness;

		// Token: 0x0400BE35 RID: 48693
		internal static int __PropertyOffset_BendingTopology;

		// Token: 0x0400BE36 RID: 48694
		internal static int __PropertyOffset_VolumeDamping;

		// Token: 0x0400BE37 RID: 48695
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400BE38 RID: 48696
		internal static int __PropertyOffset_GravityDistance;

		// Token: 0x0400BE39 RID: 48697
		internal static int __PropertyOffset_bClothPathEnabled;

		// Token: 0x0400BE3A RID: 48698
		internal static int __PropertyOffset_ClothPathRadius;

		// Token: 0x0400BE3B RID: 48699
		internal static int __PropertyOffset_ClothPathUpOffset;

		// Token: 0x0400BE3C RID: 48700
		internal static int __PropertyOffset_ClothPathAttenuationPower;

		// Token: 0x0400BE3D RID: 48701
		internal static int __PropertyOffset_ClothPathRecoveryStiffness;

		// Token: 0x0400BE3E RID: 48702
		internal static int __PropertyOffset_ClothPathNormalThreshold;
	}
}
