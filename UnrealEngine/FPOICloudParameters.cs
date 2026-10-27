using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C20 RID: 7200
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.POICloudParameters")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPOICloudParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BC81 RID: 113793 RVA: 0x0028E584 File Offset: 0x0028C784
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPOICloudParameters._ScriptStructPtr != 0) ? FPOICloudParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.POICloudParameters", ref FPOICloudParameters._ScriptStructPtr);
		}

		// Token: 0x17006FFB RID: 28667
		// (get) Token: 0x0601BC82 RID: 113794 RVA: 0x0028E5A8 File Offset: 0x0028C7A8
		// (set) Token: 0x0601BC83 RID: 113795 RVA: 0x0028E5B8 File Offset: 0x0028C7B8
		public unsafe bool bYesUV1NoUV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_bYesUV1NoUV2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_bYesUV1NoUV2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FFC RID: 28668
		// (get) Token: 0x0601BC84 RID: 113796 RVA: 0x0028E5C9 File Offset: 0x0028C7C9
		// (set) Token: 0x0601BC85 RID: 113797 RVA: 0x0028E5D9 File Offset: 0x0028C7D9
		public unsafe bool bCloudRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_bCloudRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_bCloudRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FFD RID: 28669
		// (get) Token: 0x0601BC86 RID: 113798 RVA: 0x0028E5EA File Offset: 0x0028C7EA
		// (set) Token: 0x0601BC87 RID: 113799 RVA: 0x0028E5FA File Offset: 0x0028C7FA
		public unsafe bool bSDF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_bSDF) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_bSDF) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FFE RID: 28670
		// (get) Token: 0x0601BC88 RID: 113800 RVA: 0x0028E60B File Offset: 0x0028C80B
		// (set) Token: 0x0601BC89 RID: 113801 RVA: 0x0028E61F File Offset: 0x0028C81F
		public unsafe UTexture Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_Mask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_Mask, value);
			}
		}

		// Token: 0x17006FFF RID: 28671
		// (get) Token: 0x0601BC8A RID: 113802 RVA: 0x0028E634 File Offset: 0x0028C834
		// (set) Token: 0x0601BC8B RID: 113803 RVA: 0x0028E648 File Offset: 0x0028C848
		public unsafe UTexture NoiseMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_NoiseMap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_NoiseMap, value);
			}
		}

		// Token: 0x17007000 RID: 28672
		// (get) Token: 0x0601BC8C RID: 113804 RVA: 0x0028E65D File Offset: 0x0028C85D
		// (set) Token: 0x0601BC8D RID: 113805 RVA: 0x0028E671 File Offset: 0x0028C871
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17007001 RID: 28673
		// (get) Token: 0x0601BC8E RID: 113806 RVA: 0x0028E686 File Offset: 0x0028C886
		// (set) Token: 0x0601BC8F RID: 113807 RVA: 0x0028E696 File Offset: 0x0028C896
		public unsafe int UVTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_UVTiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_UVTiling) = value;
			}
		}

		// Token: 0x17007002 RID: 28674
		// (get) Token: 0x0601BC90 RID: 113808 RVA: 0x0028E6A7 File Offset: 0x0028C8A7
		// (set) Token: 0x0601BC91 RID: 113809 RVA: 0x0028E6B7 File Offset: 0x0028C8B7
		public unsafe float CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_CloudAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_CloudAngle) = value;
			}
		}

		// Token: 0x17007003 RID: 28675
		// (get) Token: 0x0601BC92 RID: 113810 RVA: 0x0028E6C8 File Offset: 0x0028C8C8
		// (set) Token: 0x0601BC93 RID: 113811 RVA: 0x0028E6D8 File Offset: 0x0028C8D8
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_CloudSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_CloudSpeed) = value;
			}
		}

		// Token: 0x17007004 RID: 28676
		// (get) Token: 0x0601BC94 RID: 113812 RVA: 0x0028E6E9 File Offset: 0x0028C8E9
		// (set) Token: 0x0601BC95 RID: 113813 RVA: 0x0028E6F9 File Offset: 0x0028C8F9
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_NoiseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_NoiseSpeed) = value;
			}
		}

		// Token: 0x17007005 RID: 28677
		// (get) Token: 0x0601BC96 RID: 113814 RVA: 0x0028E70A File Offset: 0x0028C90A
		// (set) Token: 0x0601BC97 RID: 113815 RVA: 0x0028E71A File Offset: 0x0028C91A
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_NoiseStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_NoiseStrength) = value;
			}
		}

		// Token: 0x17007006 RID: 28678
		// (get) Token: 0x0601BC98 RID: 113816 RVA: 0x0028E72B File Offset: 0x0028C92B
		// (set) Token: 0x0601BC99 RID: 113817 RVA: 0x0028E73B File Offset: 0x0028C93B
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_NoiseTilling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOICloudParameters.__PropertyOffset_NoiseTilling) = value;
			}
		}

		// Token: 0x17007007 RID: 28679
		// (get) Token: 0x0601BC9A RID: 113818 RVA: 0x0028E74C File Offset: 0x0028C94C
		// (set) Token: 0x0601BC9B RID: 113819 RVA: 0x0028E760 File Offset: 0x0028C960
		public unsafe UMaterialInstance OverrideMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_OverrideMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPOICloudParameters.__PropertyOffset_OverrideMaterial, value);
			}
		}

		// Token: 0x0601BC9C RID: 113820 RVA: 0x0028E775 File Offset: 0x0028C975
		public FPOICloudParameters()
		{
		}

		// Token: 0x0601BC9D RID: 113821 RVA: 0x0028E780 File Offset: 0x0028C980
		[NullableContext(1)]
		public FPOICloudParameters(bool bYesUV1NoUV2, bool bCloudRotation, bool bSDF, UTexture Mask, UTexture NoiseMap, UStaticMesh Mesh, int UVTiling, float CloudAngle, float CloudSpeed, float NoiseSpeed, float NoiseStrength, float NoiseTilling, UMaterialInstance OverrideMaterial)
		{
			this.bYesUV1NoUV2 = bYesUV1NoUV2;
			this.bCloudRotation = bCloudRotation;
			this.bSDF = bSDF;
			this.Mask = Mask;
			this.NoiseMap = NoiseMap;
			this.Mesh = Mesh;
			this.UVTiling = UVTiling;
			this.CloudAngle = CloudAngle;
			this.CloudSpeed = CloudSpeed;
			this.NoiseSpeed = NoiseSpeed;
			this.NoiseStrength = NoiseStrength;
			this.NoiseTilling = NoiseTilling;
			this.OverrideMaterial = OverrideMaterial;
		}

		// Token: 0x0601BC9E RID: 113822 RVA: 0x0028E7F8 File Offset: 0x0028C9F8
		protected override IntPtr GetUStructPtr()
		{
			return FPOICloudParameters.StaticStruct();
		}

		// Token: 0x0601BC9F RID: 113823 RVA: 0x0028E804 File Offset: 0x0028CA04
		public FPOICloudParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BCA0 RID: 113824 RVA: 0x0028E80E File Offset: 0x0028CA0E
		public FPOICloudParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BCA1 RID: 113825 RVA: 0x0028E819 File Offset: 0x0028CA19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPOICloudParameters(Pointer, false, true);
		}

		// Token: 0x0601BCA2 RID: 113826 RVA: 0x0028E823 File Offset: 0x0028CA23
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPOICloudParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400EEEE RID: 61166
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.POICloudParameters";

		// Token: 0x0400EEEF RID: 61167
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EEF0 RID: 61168
		internal static int __PropertyOffset_bYesUV1NoUV2;

		// Token: 0x0400EEF1 RID: 61169
		internal static int __PropertyOffset_bCloudRotation;

		// Token: 0x0400EEF2 RID: 61170
		internal static int __PropertyOffset_bSDF;

		// Token: 0x0400EEF3 RID: 61171
		internal static int __PropertyOffset_Mask;

		// Token: 0x0400EEF4 RID: 61172
		internal static int __PropertyOffset_NoiseMap;

		// Token: 0x0400EEF5 RID: 61173
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400EEF6 RID: 61174
		internal static int __PropertyOffset_UVTiling;

		// Token: 0x0400EEF7 RID: 61175
		internal static int __PropertyOffset_CloudAngle;

		// Token: 0x0400EEF8 RID: 61176
		internal static int __PropertyOffset_CloudSpeed;

		// Token: 0x0400EEF9 RID: 61177
		internal static int __PropertyOffset_NoiseSpeed;

		// Token: 0x0400EEFA RID: 61178
		internal static int __PropertyOffset_NoiseStrength;

		// Token: 0x0400EEFB RID: 61179
		internal static int __PropertyOffset_NoiseTilling;

		// Token: 0x0400EEFC RID: 61180
		internal static int __PropertyOffset_OverrideMaterial;
	}
}
