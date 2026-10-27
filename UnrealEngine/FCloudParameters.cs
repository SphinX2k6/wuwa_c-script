using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A5C RID: 6748
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CloudParameters")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FCloudParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018F91 RID: 102289 RVA: 0x0024E9AF File Offset: 0x0024CBAF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCloudParameters._ScriptStructPtr != 0) ? FCloudParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CloudParameters", ref FCloudParameters._ScriptStructPtr);
		}

		// Token: 0x170062F5 RID: 25333
		// (get) Token: 0x06018F92 RID: 102290 RVA: 0x0024E9D3 File Offset: 0x0024CBD3
		// (set) Token: 0x06018F93 RID: 102291 RVA: 0x0024E9E3 File Offset: 0x0024CBE3
		public unsafe bool bYesUV1NoUV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_bYesUV1NoUV2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_bYesUV1NoUV2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062F6 RID: 25334
		// (get) Token: 0x06018F94 RID: 102292 RVA: 0x0024E9F4 File Offset: 0x0024CBF4
		// (set) Token: 0x06018F95 RID: 102293 RVA: 0x0024EA04 File Offset: 0x0024CC04
		public unsafe bool bCloudRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_bCloudRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_bCloudRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062F7 RID: 25335
		// (get) Token: 0x06018F96 RID: 102294 RVA: 0x0024EA15 File Offset: 0x0024CC15
		// (set) Token: 0x06018F97 RID: 102295 RVA: 0x0024EA25 File Offset: 0x0024CC25
		public unsafe bool bSDF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_bSDF) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_bSDF) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062F8 RID: 25336
		// (get) Token: 0x06018F98 RID: 102296 RVA: 0x0024EA36 File Offset: 0x0024CC36
		// (set) Token: 0x06018F99 RID: 102297 RVA: 0x0024EA4A File Offset: 0x0024CC4A
		public unsafe UTexture Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FCloudParameters.__PropertyOffset_Mask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCloudParameters.__PropertyOffset_Mask, value);
			}
		}

		// Token: 0x170062F9 RID: 25337
		// (get) Token: 0x06018F9A RID: 102298 RVA: 0x0024EA5F File Offset: 0x0024CC5F
		// (set) Token: 0x06018F9B RID: 102299 RVA: 0x0024EA73 File Offset: 0x0024CC73
		public unsafe UTexture NoiseMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FCloudParameters.__PropertyOffset_NoiseMap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCloudParameters.__PropertyOffset_NoiseMap, value);
			}
		}

		// Token: 0x170062FA RID: 25338
		// (get) Token: 0x06018F9C RID: 102300 RVA: 0x0024EA88 File Offset: 0x0024CC88
		// (set) Token: 0x06018F9D RID: 102301 RVA: 0x0024EA98 File Offset: 0x0024CC98
		public unsafe int UVTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_UVTiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_UVTiling) = value;
			}
		}

		// Token: 0x170062FB RID: 25339
		// (get) Token: 0x06018F9E RID: 102302 RVA: 0x0024EAA9 File Offset: 0x0024CCA9
		// (set) Token: 0x06018F9F RID: 102303 RVA: 0x0024EAB9 File Offset: 0x0024CCB9
		public unsafe float CloudAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_CloudAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_CloudAngle) = value;
			}
		}

		// Token: 0x170062FC RID: 25340
		// (get) Token: 0x06018FA0 RID: 102304 RVA: 0x0024EACA File Offset: 0x0024CCCA
		// (set) Token: 0x06018FA1 RID: 102305 RVA: 0x0024EADA File Offset: 0x0024CCDA
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_CloudSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_CloudSpeed) = value;
			}
		}

		// Token: 0x170062FD RID: 25341
		// (get) Token: 0x06018FA2 RID: 102306 RVA: 0x0024EAEB File Offset: 0x0024CCEB
		// (set) Token: 0x06018FA3 RID: 102307 RVA: 0x0024EAFB File Offset: 0x0024CCFB
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_NoiseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_NoiseSpeed) = value;
			}
		}

		// Token: 0x170062FE RID: 25342
		// (get) Token: 0x06018FA4 RID: 102308 RVA: 0x0024EB0C File Offset: 0x0024CD0C
		// (set) Token: 0x06018FA5 RID: 102309 RVA: 0x0024EB1C File Offset: 0x0024CD1C
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_NoiseStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_NoiseStrength) = value;
			}
		}

		// Token: 0x170062FF RID: 25343
		// (get) Token: 0x06018FA6 RID: 102310 RVA: 0x0024EB2D File Offset: 0x0024CD2D
		// (set) Token: 0x06018FA7 RID: 102311 RVA: 0x0024EB3D File Offset: 0x0024CD3D
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_NoiseTilling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_NoiseTilling) = value;
			}
		}

		// Token: 0x17006300 RID: 25344
		// (get) Token: 0x06018FA8 RID: 102312 RVA: 0x0024EB50 File Offset: 0x0024CD50
		// (set) Token: 0x06018FA9 RID: 102313 RVA: 0x0024EB93 File Offset: 0x0024CD93
		[Nullable(1)]
		public FKuroCurveFloat SDFTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SDFTime) == null)
				{
					result = (this._SDFTime = new FKuroCurveFloat(base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_SDFTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FCloudParameters.__PropertyOffset_SDFTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006301 RID: 25345
		// (get) Token: 0x06018FAA RID: 102314 RVA: 0x0024EBB4 File Offset: 0x0024CDB4
		// (set) Token: 0x06018FAB RID: 102315 RVA: 0x0024EBC8 File Offset: 0x0024CDC8
		public unsafe UMaterialInstance OverrideMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FCloudParameters.__PropertyOffset_OverrideMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCloudParameters.__PropertyOffset_OverrideMaterial, value);
			}
		}

		// Token: 0x06018FAC RID: 102316 RVA: 0x0024EBDD File Offset: 0x0024CDDD
		public FCloudParameters()
		{
		}

		// Token: 0x06018FAD RID: 102317 RVA: 0x0024EBE8 File Offset: 0x0024CDE8
		[NullableContext(1)]
		public FCloudParameters(bool bYesUV1NoUV2, bool bCloudRotation, bool bSDF, UTexture Mask, UTexture NoiseMap, int UVTiling, float CloudAngle, float CloudSpeed, float NoiseSpeed, float NoiseStrength, float NoiseTilling, FKuroCurveFloat SDFTime, UMaterialInstance OverrideMaterial)
		{
			this.bYesUV1NoUV2 = bYesUV1NoUV2;
			this.bCloudRotation = bCloudRotation;
			this.bSDF = bSDF;
			this.Mask = Mask;
			this.NoiseMap = NoiseMap;
			this.UVTiling = UVTiling;
			this.CloudAngle = CloudAngle;
			this.CloudSpeed = CloudSpeed;
			this.NoiseSpeed = NoiseSpeed;
			this.NoiseStrength = NoiseStrength;
			this.NoiseTilling = NoiseTilling;
			this.SDFTime = SDFTime;
			this.OverrideMaterial = OverrideMaterial;
		}

		// Token: 0x06018FAE RID: 102318 RVA: 0x0024EC60 File Offset: 0x0024CE60
		protected override IntPtr GetUStructPtr()
		{
			return FCloudParameters.StaticStruct();
		}

		// Token: 0x06018FAF RID: 102319 RVA: 0x0024EC6C File Offset: 0x0024CE6C
		public FCloudParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018FB0 RID: 102320 RVA: 0x0024EC76 File Offset: 0x0024CE76
		public FCloudParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018FB1 RID: 102321 RVA: 0x0024EC81 File Offset: 0x0024CE81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCloudParameters(Pointer, false, true);
		}

		// Token: 0x06018FB2 RID: 102322 RVA: 0x0024EC8B File Offset: 0x0024CE8B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCloudParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400D82D RID: 55341
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CloudParameters";

		// Token: 0x0400D82E RID: 55342
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D82F RID: 55343
		internal static int __PropertyOffset_bYesUV1NoUV2;

		// Token: 0x0400D830 RID: 55344
		internal static int __PropertyOffset_bCloudRotation;

		// Token: 0x0400D831 RID: 55345
		internal static int __PropertyOffset_bSDF;

		// Token: 0x0400D832 RID: 55346
		internal static int __PropertyOffset_Mask;

		// Token: 0x0400D833 RID: 55347
		internal static int __PropertyOffset_NoiseMap;

		// Token: 0x0400D834 RID: 55348
		internal static int __PropertyOffset_UVTiling;

		// Token: 0x0400D835 RID: 55349
		internal static int __PropertyOffset_CloudAngle;

		// Token: 0x0400D836 RID: 55350
		internal static int __PropertyOffset_CloudSpeed;

		// Token: 0x0400D837 RID: 55351
		internal static int __PropertyOffset_NoiseSpeed;

		// Token: 0x0400D838 RID: 55352
		internal static int __PropertyOffset_NoiseStrength;

		// Token: 0x0400D839 RID: 55353
		internal static int __PropertyOffset_NoiseTilling;

		// Token: 0x0400D83A RID: 55354
		internal static int __PropertyOffset_SDFTime;

		// Token: 0x0400D83B RID: 55355
		private FKuroCurveFloat _SDFTime;

		// Token: 0x0400D83C RID: 55356
		internal static int __PropertyOffset_OverrideMaterial;
	}
}
