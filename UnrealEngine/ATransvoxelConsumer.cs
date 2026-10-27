using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026A1 RID: 9889
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelConsumer")]
	[UnrealStructLayout(6688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6688)]
	public class ATransvoxelConsumer : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024BB4 RID: 150452 RVA: 0x00365F8C File Offset: 0x0036418C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATransvoxelConsumer._ClassPtr;
		}

		// Token: 0x06024BB5 RID: 150453 RVA: 0x00365F98 File Offset: 0x00364198
		public ATransvoxelConsumer() : this(BuiltinUtils.AllocNativeUObject(ATransvoxelConsumer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024BB6 RID: 150454 RVA: 0x00365FC0 File Offset: 0x003641C0
		[NullableContext(1)]
		public ATransvoxelConsumer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATransvoxelConsumer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008DC3 RID: 36291
		// (get) Token: 0x06024BB7 RID: 150455 RVA: 0x00365FF3 File Offset: 0x003641F3
		// (set) Token: 0x06024BB8 RID: 150456 RVA: 0x00366003 File Offset: 0x00364203
		public unsafe bool bTransvoxelDestroyed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bTransvoxelDestroyed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bTransvoxelDestroyed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DC4 RID: 36292
		// (get) Token: 0x06024BB9 RID: 150457 RVA: 0x00366014 File Offset: 0x00364214
		// (set) Token: 0x06024BBA RID: 150458 RVA: 0x00366028 File Offset: 0x00364228
		public unsafe UTransvoxelConfigDataAsset ConfigDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTransvoxelConfigDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_ConfigDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_ConfigDataAsset, value);
			}
		}

		// Token: 0x17008DC5 RID: 36293
		// (get) Token: 0x06024BBB RID: 150459 RVA: 0x0036603D File Offset: 0x0036423D
		// (set) Token: 0x06024BBC RID: 150460 RVA: 0x00366051 File Offset: 0x00364251
		public unsafe UTransvoxelCompressedDataAsset CompressedDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTransvoxelCompressedDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CompressedDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CompressedDataAsset, value);
			}
		}

		// Token: 0x17008DC6 RID: 36294
		// (get) Token: 0x06024BBD RID: 150461 RVA: 0x00366066 File Offset: 0x00364266
		// (set) Token: 0x06024BBE RID: 150462 RVA: 0x0036607A File Offset: 0x0036427A
		public unsafe UTransvoxelRenderConfigDataAsset RenderConfigDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTransvoxelRenderConfigDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_RenderConfigDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_RenderConfigDataAsset, value);
			}
		}

		// Token: 0x17008DC7 RID: 36295
		// (get) Token: 0x06024BBF RID: 150463 RVA: 0x00366090 File Offset: 0x00364290
		// (set) Token: 0x06024BC0 RID: 150464 RVA: 0x003660C9 File Offset: 0x003642C9
		[Nullable(1)]
		public FTransvoxelHeightMapCompressedGenerationSettings HeightMapCompressedGenerationSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTransvoxelHeightMapCompressedGenerationSettings result;
				if ((result = this._HeightMapCompressedGenerationSettings) == null)
				{
					result = (this._HeightMapCompressedGenerationSettings = new FTransvoxelHeightMapCompressedGenerationSettings(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_HeightMapCompressedGenerationSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTransvoxelHeightMapCompressedGenerationSettings.StaticStruct(), base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_HeightMapCompressedGenerationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008DC8 RID: 36296
		// (get) Token: 0x06024BC1 RID: 150465 RVA: 0x003660EA File Offset: 0x003642EA
		// (set) Token: 0x06024BC2 RID: 150466 RVA: 0x003660FA File Offset: 0x003642FA
		public unsafe bool bPlacePlayerOnTerrainAtBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bPlacePlayerOnTerrainAtBeginPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bPlacePlayerOnTerrainAtBeginPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DC9 RID: 36297
		// (get) Token: 0x06024BC3 RID: 150467 RVA: 0x0036610B File Offset: 0x0036430B
		// (set) Token: 0x06024BC4 RID: 150468 RVA: 0x0036611B File Offset: 0x0036431B
		public unsafe float IsoLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_IsoLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_IsoLevel) = value;
			}
		}

		// Token: 0x17008DCA RID: 36298
		// (get) Token: 0x06024BC5 RID: 150469 RVA: 0x0036612C File Offset: 0x0036432C
		// (set) Token: 0x06024BC6 RID: 150470 RVA: 0x0036613C File Offset: 0x0036433C
		public unsafe bool bEnableDebugDraw_cornerPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_cornerPoints) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_cornerPoints) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DCB RID: 36299
		// (get) Token: 0x06024BC7 RID: 150471 RVA: 0x0036614D File Offset: 0x0036434D
		// (set) Token: 0x06024BC8 RID: 150472 RVA: 0x0036615D File Offset: 0x0036435D
		public unsafe bool bEnableDebugDraw_triangleWireframe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_triangleWireframe) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_triangleWireframe) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DCC RID: 36300
		// (get) Token: 0x06024BC9 RID: 150473 RVA: 0x0036616E File Offset: 0x0036436E
		// (set) Token: 0x06024BCA RID: 150474 RVA: 0x0036617E File Offset: 0x0036437E
		public unsafe bool bEnableDebugDraw_normals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_normals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_normals) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DCD RID: 36301
		// (get) Token: 0x06024BCB RID: 150475 RVA: 0x0036618F File Offset: 0x0036438F
		// (set) Token: 0x06024BCC RID: 150476 RVA: 0x0036619F File Offset: 0x0036439F
		public unsafe bool bEnableDebugDraw_collisionBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_collisionBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_collisionBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DCE RID: 36302
		// (get) Token: 0x06024BCD RID: 150477 RVA: 0x003661B0 File Offset: 0x003643B0
		// (set) Token: 0x06024BCE RID: 150478 RVA: 0x003661C0 File Offset: 0x003643C0
		public unsafe bool bEnableDebugDraw_digSphere
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_digSphere) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebugDraw_digSphere) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DCF RID: 36303
		// (get) Token: 0x06024BCF RID: 150479 RVA: 0x003661D1 File Offset: 0x003643D1
		// (set) Token: 0x06024BD0 RID: 150480 RVA: 0x003661E1 File Offset: 0x003643E1
		public unsafe bool showColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_showColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_showColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DD0 RID: 36304
		// (get) Token: 0x06024BD1 RID: 150481 RVA: 0x003661F2 File Offset: 0x003643F2
		// (set) Token: 0x06024BD2 RID: 150482 RVA: 0x00366202 File Offset: 0x00364402
		public unsafe bool bEnableDigGradientCache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDigGradientCache) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDigGradientCache) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DD1 RID: 36305
		// (get) Token: 0x06024BD3 RID: 150483 RVA: 0x00366213 File Offset: 0x00364413
		// (set) Token: 0x06024BD4 RID: 150484 RVA: 0x00366223 File Offset: 0x00364423
		public unsafe bool bForceFullStableCacheRebuildOnDig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bForceFullStableCacheRebuildOnDig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bForceFullStableCacheRebuildOnDig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DD2 RID: 36306
		// (get) Token: 0x06024BD5 RID: 150485 RVA: 0x00366234 File Offset: 0x00364434
		// (set) Token: 0x06024BD6 RID: 150486 RVA: 0x00366244 File Offset: 0x00364444
		public unsafe int DensitySmoothIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DensitySmoothIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DensitySmoothIterations) = value;
			}
		}

		// Token: 0x17008DD3 RID: 36307
		// (get) Token: 0x06024BD7 RID: 150487 RVA: 0x00366255 File Offset: 0x00364455
		// (set) Token: 0x06024BD8 RID: 150488 RVA: 0x00366265 File Offset: 0x00364465
		public unsafe bool bFilterDegenerateTriangles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bFilterDegenerateTriangles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bFilterDegenerateTriangles) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DD4 RID: 36308
		// (get) Token: 0x06024BD9 RID: 150489 RVA: 0x00366276 File Offset: 0x00364476
		// (set) Token: 0x06024BDA RID: 150490 RVA: 0x00366286 File Offset: 0x00364486
		public unsafe float DegenerateTriangleAreaThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DegenerateTriangleAreaThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DegenerateTriangleAreaThreshold) = value;
			}
		}

		// Token: 0x17008DD5 RID: 36309
		// (get) Token: 0x06024BDB RID: 150491 RVA: 0x00366297 File Offset: 0x00364497
		// (set) Token: 0x06024BDC RID: 150492 RVA: 0x003662A7 File Offset: 0x003644A7
		public unsafe float EdgeClampMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_EdgeClampMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_EdgeClampMargin) = value;
			}
		}

		// Token: 0x17008DD6 RID: 36310
		// (get) Token: 0x06024BDD RID: 150493 RVA: 0x003662B8 File Offset: 0x003644B8
		// (set) Token: 0x06024BDE RID: 150494 RVA: 0x003662C8 File Offset: 0x003644C8
		public unsafe bool bEnableAdaptiveEdgeClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableAdaptiveEdgeClamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableAdaptiveEdgeClamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DD7 RID: 36311
		// (get) Token: 0x06024BDF RID: 150495 RVA: 0x003662D9 File Offset: 0x003644D9
		// (set) Token: 0x06024BE0 RID: 150496 RVA: 0x003662E9 File Offset: 0x003644E9
		public unsafe float AdaptiveEdgeClampTriggerMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_AdaptiveEdgeClampTriggerMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_AdaptiveEdgeClampTriggerMargin) = value;
			}
		}

		// Token: 0x17008DD8 RID: 36312
		// (get) Token: 0x06024BE1 RID: 150497 RVA: 0x003662FA File Offset: 0x003644FA
		// (set) Token: 0x06024BE2 RID: 150498 RVA: 0x0036630A File Offset: 0x0036450A
		public unsafe float AdaptiveEdgeClampMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_AdaptiveEdgeClampMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_AdaptiveEdgeClampMargin) = value;
			}
		}

		// Token: 0x17008DD9 RID: 36313
		// (get) Token: 0x06024BE3 RID: 150499 RVA: 0x0036631B File Offset: 0x0036451B
		// (set) Token: 0x06024BE4 RID: 150500 RVA: 0x0036632B File Offset: 0x0036452B
		public unsafe bool bBatchDigStableCacheSubmit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bBatchDigStableCacheSubmit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bBatchDigStableCacheSubmit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DDA RID: 36314
		// (get) Token: 0x06024BE5 RID: 150501 RVA: 0x0036633C File Offset: 0x0036453C
		// (set) Token: 0x06024BE6 RID: 150502 RVA: 0x0036634C File Offset: 0x0036454C
		public unsafe float RuntimeDigRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigRadius) = value;
			}
		}

		// Token: 0x17008DDB RID: 36315
		// (get) Token: 0x06024BE7 RID: 150503 RVA: 0x0036635D File Offset: 0x0036455D
		// (set) Token: 0x06024BE8 RID: 150504 RVA: 0x0036636D File Offset: 0x0036456D
		public unsafe float RuntimeDigDensityGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensityGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensityGain) = value;
			}
		}

		// Token: 0x17008DDC RID: 36316
		// (get) Token: 0x06024BE9 RID: 150505 RVA: 0x0036637E File Offset: 0x0036457E
		// (set) Token: 0x06024BEA RID: 150506 RVA: 0x0036638E File Offset: 0x0036458E
		public unsafe float RuntimeDigFeatherVoxelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigFeatherVoxelCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigFeatherVoxelCount) = value;
			}
		}

		// Token: 0x17008DDD RID: 36317
		// (get) Token: 0x06024BEB RID: 150507 RVA: 0x0036639F File Offset: 0x0036459F
		// (set) Token: 0x06024BEC RID: 150508 RVA: 0x003663AF File Offset: 0x003645AF
		public unsafe bool bEnableRuntimeDigDensitySmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableRuntimeDigDensitySmoothing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableRuntimeDigDensitySmoothing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DDE RID: 36318
		// (get) Token: 0x06024BED RID: 150509 RVA: 0x003663C0 File Offset: 0x003645C0
		// (set) Token: 0x06024BEE RID: 150510 RVA: 0x003663D0 File Offset: 0x003645D0
		public unsafe int RuntimeDigDensitySmoothIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothIterations) = value;
			}
		}

		// Token: 0x17008DDF RID: 36319
		// (get) Token: 0x06024BEF RID: 150511 RVA: 0x003663E1 File Offset: 0x003645E1
		// (set) Token: 0x06024BF0 RID: 150512 RVA: 0x003663F1 File Offset: 0x003645F1
		public unsafe float RuntimeDigDensitySmoothStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothStrength) = value;
			}
		}

		// Token: 0x17008DE0 RID: 36320
		// (get) Token: 0x06024BF1 RID: 150513 RVA: 0x00366402 File Offset: 0x00364602
		// (set) Token: 0x06024BF2 RID: 150514 RVA: 0x00366412 File Offset: 0x00364612
		public unsafe float RuntimeDigDensitySmoothRadiusVoxelPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothRadiusVoxelPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothRadiusVoxelPadding) = value;
			}
		}

		// Token: 0x17008DE1 RID: 36321
		// (get) Token: 0x06024BF3 RID: 150515 RVA: 0x00366423 File Offset: 0x00364623
		// (set) Token: 0x06024BF4 RID: 150516 RVA: 0x00366433 File Offset: 0x00364633
		public unsafe float RuntimeDigDensitySmoothBandDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothBandDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeDigDensitySmoothBandDensity) = value;
			}
		}

		// Token: 0x17008DE2 RID: 36322
		// (get) Token: 0x06024BF5 RID: 150517 RVA: 0x00366444 File Offset: 0x00364644
		// (set) Token: 0x06024BF6 RID: 150518 RVA: 0x00366454 File Offset: 0x00364654
		public unsafe bool bEnableDebris
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebris) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDebris) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DE3 RID: 36323
		// (get) Token: 0x06024BF7 RID: 150519 RVA: 0x00366465 File Offset: 0x00364665
		// (set) Token: 0x06024BF8 RID: 150520 RVA: 0x00366475 File Offset: 0x00364675
		public unsafe float CharacterUpDigOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CharacterUpDigOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CharacterUpDigOffset) = value;
			}
		}

		// Token: 0x17008DE4 RID: 36324
		// (get) Token: 0x06024BF9 RID: 150521 RVA: 0x00366486 File Offset: 0x00364686
		// (set) Token: 0x06024BFA RID: 150522 RVA: 0x00366496 File Offset: 0x00364696
		public unsafe float CharacterForwardDigOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CharacterForwardDigOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CharacterForwardDigOffset) = value;
			}
		}

		// Token: 0x17008DE5 RID: 36325
		// (get) Token: 0x06024BFB RID: 150523 RVA: 0x003664A7 File Offset: 0x003646A7
		// (set) Token: 0x06024BFC RID: 150524 RVA: 0x003664B7 File Offset: 0x003646B7
		public unsafe bool bEnableTessellation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableTessellation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableTessellation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DE6 RID: 36326
		// (get) Token: 0x06024BFD RID: 150525 RVA: 0x003664C8 File Offset: 0x003646C8
		// (set) Token: 0x06024BFE RID: 150526 RVA: 0x003664D8 File Offset: 0x003646D8
		public unsafe bool bShowExactTessWireframe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bShowExactTessWireframe) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bShowExactTessWireframe) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DE7 RID: 36327
		// (get) Token: 0x06024BFF RID: 150527 RVA: 0x003664E9 File Offset: 0x003646E9
		// (set) Token: 0x06024C00 RID: 150528 RVA: 0x003664F9 File Offset: 0x003646F9
		public unsafe float TessNearDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessNearDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessNearDistance) = value;
			}
		}

		// Token: 0x17008DE8 RID: 36328
		// (get) Token: 0x06024C01 RID: 150529 RVA: 0x0036650A File Offset: 0x0036470A
		// (set) Token: 0x06024C02 RID: 150530 RVA: 0x0036651A File Offset: 0x0036471A
		public unsafe float TessFarDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessFarDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessFarDistance) = value;
			}
		}

		// Token: 0x17008DE9 RID: 36329
		// (get) Token: 0x06024C03 RID: 150531 RVA: 0x0036652B File Offset: 0x0036472B
		// (set) Token: 0x06024C04 RID: 150532 RVA: 0x0036653B File Offset: 0x0036473B
		public unsafe float TessMinFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessMinFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessMinFactor) = value;
			}
		}

		// Token: 0x17008DEA RID: 36330
		// (get) Token: 0x06024C05 RID: 150533 RVA: 0x0036654C File Offset: 0x0036474C
		// (set) Token: 0x06024C06 RID: 150534 RVA: 0x0036655C File Offset: 0x0036475C
		public unsafe float TessMaxFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessMaxFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessMaxFactor) = value;
			}
		}

		// Token: 0x17008DEB RID: 36331
		// (get) Token: 0x06024C07 RID: 150535 RVA: 0x0036656D File Offset: 0x0036476D
		// (set) Token: 0x06024C08 RID: 150536 RVA: 0x0036657D File Offset: 0x0036477D
		public unsafe float TessBulgeStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessBulgeStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TessBulgeStrength) = value;
			}
		}

		// Token: 0x17008DEC RID: 36332
		// (get) Token: 0x06024C09 RID: 150537 RVA: 0x0036658E File Offset: 0x0036478E
		// (set) Token: 0x06024C0A RID: 150538 RVA: 0x0036659E File Offset: 0x0036479E
		public unsafe ETransvoxelRuntimeRenderMode RuntimeRenderMode
		{
			get
			{
				return (ETransvoxelRuntimeRenderMode)(*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeRenderMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeRenderMode) = (byte)value;
			}
		}

		// Token: 0x17008DED RID: 36333
		// (get) Token: 0x06024C0B RID: 150539 RVA: 0x003665AF File Offset: 0x003647AF
		// (set) Token: 0x06024C0C RID: 150540 RVA: 0x003665C3 File Offset: 0x003647C3
		public unsafe UMaterialInterface RuntimeChunkMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_RuntimeChunkMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_RuntimeChunkMaterial, value);
			}
		}

		// Token: 0x17008DEE RID: 36334
		// (get) Token: 0x06024C0D RID: 150541 RVA: 0x003665D8 File Offset: 0x003647D8
		// (set) Token: 0x06024C0E RID: 150542 RVA: 0x003665E8 File Offset: 0x003647E8
		public unsafe bool bCustomRendererEnableTexturedShading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bCustomRendererEnableTexturedShading) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bCustomRendererEnableTexturedShading) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DEF RID: 36335
		// (get) Token: 0x06024C0F RID: 150543 RVA: 0x003665F9 File Offset: 0x003647F9
		// (set) Token: 0x06024C10 RID: 150544 RVA: 0x00366609 File Offset: 0x00364809
		public unsafe bool bCustomRendererUseDitheredMaterialSampling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bCustomRendererUseDitheredMaterialSampling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bCustomRendererUseDitheredMaterialSampling) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DF0 RID: 36336
		// (get) Token: 0x06024C11 RID: 150545 RVA: 0x0036661A File Offset: 0x0036481A
		// (set) Token: 0x06024C12 RID: 150546 RVA: 0x0036662E File Offset: 0x0036482E
		public unsafe UTexture2D CustomRendererSurfaceWeightTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CustomRendererSurfaceWeightTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CustomRendererSurfaceWeightTexture, value);
			}
		}

		// Token: 0x17008DF1 RID: 36337
		// (get) Token: 0x06024C13 RID: 150547 RVA: 0x00366644 File Offset: 0x00364844
		// (set) Token: 0x06024C14 RID: 150548 RVA: 0x0036667D File Offset: 0x0036487D
		[Nullable(1)]
		public TArray<UTexture2D> CustomRendererSurfaceDiffuseTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._CustomRendererSurfaceDiffuseTextures) == null)
				{
					result = (this._CustomRendererSurfaceDiffuseTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererSurfaceDiffuseTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomRendererSurfaceDiffuseTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008DF2 RID: 36338
		// (get) Token: 0x06024C15 RID: 150549 RVA: 0x0036668C File Offset: 0x0036488C
		// (set) Token: 0x06024C16 RID: 150550 RVA: 0x003666C5 File Offset: 0x003648C5
		[Nullable(1)]
		public TArray<UTexture2D> CustomRendererSurfaceNormalTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._CustomRendererSurfaceNormalTextures) == null)
				{
					result = (this._CustomRendererSurfaceNormalTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererSurfaceNormalTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomRendererSurfaceNormalTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008DF3 RID: 36339
		// (get) Token: 0x06024C17 RID: 150551 RVA: 0x003666D4 File Offset: 0x003648D4
		// (set) Token: 0x06024C18 RID: 150552 RVA: 0x0036670D File Offset: 0x0036490D
		[Nullable(1)]
		public TArray<UTexture2D> CustomRendererInteriorDiffuseTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._CustomRendererInteriorDiffuseTextures) == null)
				{
					result = (this._CustomRendererInteriorDiffuseTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererInteriorDiffuseTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomRendererInteriorDiffuseTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008DF4 RID: 36340
		// (get) Token: 0x06024C19 RID: 150553 RVA: 0x0036671C File Offset: 0x0036491C
		// (set) Token: 0x06024C1A RID: 150554 RVA: 0x00366755 File Offset: 0x00364955
		[Nullable(1)]
		public TArray<UTexture2D> CustomRendererInteriorNormalTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._CustomRendererInteriorNormalTextures) == null)
				{
					result = (this._CustomRendererInteriorNormalTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererInteriorNormalTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomRendererInteriorNormalTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008DF5 RID: 36341
		// (get) Token: 0x06024C1B RID: 150555 RVA: 0x00366763 File Offset: 0x00364963
		// (set) Token: 0x06024C1C RID: 150556 RVA: 0x00366777 File Offset: 0x00364977
		public unsafe UTexture2D CustomRendererLockedDiffuseTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CustomRendererLockedDiffuseTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CustomRendererLockedDiffuseTexture, value);
			}
		}

		// Token: 0x17008DF6 RID: 36342
		// (get) Token: 0x06024C1D RID: 150557 RVA: 0x0036678C File Offset: 0x0036498C
		// (set) Token: 0x06024C1E RID: 150558 RVA: 0x003667A0 File Offset: 0x003649A0
		public unsafe UTexture2D CustomRendererLockedNormalTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CustomRendererLockedNormalTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_CustomRendererLockedNormalTexture, value);
			}
		}

		// Token: 0x17008DF7 RID: 36343
		// (get) Token: 0x06024C1F RID: 150559 RVA: 0x003667B5 File Offset: 0x003649B5
		// (set) Token: 0x06024C20 RID: 150560 RVA: 0x003667C5 File Offset: 0x003649C5
		public unsafe float CustomRendererSurfaceHeightBlendWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererSurfaceHeightBlendWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererSurfaceHeightBlendWidth) = value;
			}
		}

		// Token: 0x17008DF8 RID: 36344
		// (get) Token: 0x06024C21 RID: 150561 RVA: 0x003667D6 File Offset: 0x003649D6
		// (set) Token: 0x06024C22 RID: 150562 RVA: 0x003667EA File Offset: 0x003649EA
		public unsafe FVector2D CustomRendererMaterialWorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererMaterialWorldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererMaterialWorldSize) = value;
			}
		}

		// Token: 0x17008DF9 RID: 36345
		// (get) Token: 0x06024C23 RID: 150563 RVA: 0x003667FF File Offset: 0x003649FF
		// (set) Token: 0x06024C24 RID: 150564 RVA: 0x0036680F File Offset: 0x00364A0F
		public unsafe float CustomRendererWorldTextureScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererWorldTextureScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererWorldTextureScale) = value;
			}
		}

		// Token: 0x17008DFA RID: 36346
		// (get) Token: 0x06024C25 RID: 150565 RVA: 0x00366820 File Offset: 0x00364A20
		// (set) Token: 0x06024C26 RID: 150566 RVA: 0x00366830 File Offset: 0x00364A30
		public unsafe bool bCustomRendererUseTriplanarMaterialSampling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bCustomRendererUseTriplanarMaterialSampling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bCustomRendererUseTriplanarMaterialSampling) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DFB RID: 36347
		// (get) Token: 0x06024C27 RID: 150567 RVA: 0x00366841 File Offset: 0x00364A41
		// (set) Token: 0x06024C28 RID: 150568 RVA: 0x00366851 File Offset: 0x00364A51
		public unsafe float CustomRendererTriplanarBlendSharpness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererTriplanarBlendSharpness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererTriplanarBlendSharpness) = value;
			}
		}

		// Token: 0x17008DFC RID: 36348
		// (get) Token: 0x06024C29 RID: 150569 RVA: 0x00366862 File Offset: 0x00364A62
		// (set) Token: 0x06024C2A RID: 150570 RVA: 0x00366872 File Offset: 0x00364A72
		public unsafe float CustomRendererNormalMapStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererNormalMapStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CustomRendererNormalMapStrength) = value;
			}
		}

		// Token: 0x17008DFD RID: 36349
		// (get) Token: 0x06024C2B RID: 150571 RVA: 0x00366884 File Offset: 0x00364A84
		// (set) Token: 0x06024C2C RID: 150572 RVA: 0x003668BD File Offset: 0x00364ABD
		[Nullable(1)]
		public TArray<FTransvoxelHeightSplatPoint> HeightSplatPoints
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransvoxelHeightSplatPoint> result;
				if ((result = this._HeightSplatPoints) == null)
				{
					result = (this._HeightSplatPoints = new TArray<FTransvoxelHeightSplatPoint>(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_HeightSplatPoints, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HeightSplatPoints.CopyAssign(value);
			}
		}

		// Token: 0x17008DFE RID: 36350
		// (get) Token: 0x06024C2D RID: 150573 RVA: 0x003668CB File Offset: 0x00364ACB
		// (set) Token: 0x06024C2E RID: 150574 RVA: 0x003668DB File Offset: 0x00364ADB
		public unsafe bool bEnableRuntimeLog_queue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableRuntimeLog_queue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableRuntimeLog_queue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008DFF RID: 36351
		// (get) Token: 0x06024C2F RID: 150575 RVA: 0x003668EC File Offset: 0x00364AEC
		// (set) Token: 0x06024C30 RID: 150576 RVA: 0x003668FC File Offset: 0x00364AFC
		public unsafe bool bEnableRuntimeStatsOverlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableRuntimeStatsOverlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableRuntimeStatsOverlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E00 RID: 36352
		// (get) Token: 0x06024C31 RID: 150577 RVA: 0x0036690D File Offset: 0x00364B0D
		// (set) Token: 0x06024C32 RID: 150578 RVA: 0x0036691D File Offset: 0x00364B1D
		public unsafe bool bDigInterruptsLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bDigInterruptsLod) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bDigInterruptsLod) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E01 RID: 36353
		// (get) Token: 0x06024C33 RID: 150579 RVA: 0x0036692E File Offset: 0x00364B2E
		// (set) Token: 0x06024C34 RID: 150580 RVA: 0x0036693E File Offset: 0x00364B3E
		public unsafe float MinDigInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MinDigInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MinDigInterval) = value;
			}
		}

		// Token: 0x17008E02 RID: 36354
		// (get) Token: 0x06024C35 RID: 150581 RVA: 0x0036694F File Offset: 0x00364B4F
		// (set) Token: 0x06024C36 RID: 150582 RVA: 0x0036695F File Offset: 0x00364B5F
		public unsafe int MaxCompressedVoxelRebuildChunksPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxCompressedVoxelRebuildChunksPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxCompressedVoxelRebuildChunksPerFrame) = value;
			}
		}

		// Token: 0x17008E03 RID: 36355
		// (get) Token: 0x06024C37 RID: 150583 RVA: 0x00366970 File Offset: 0x00364B70
		// (set) Token: 0x06024C38 RID: 150584 RVA: 0x00366980 File Offset: 0x00364B80
		public unsafe int MaxUpdateUnitsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxUpdateUnitsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxUpdateUnitsPerFrame) = value;
			}
		}

		// Token: 0x17008E04 RID: 36356
		// (get) Token: 0x06024C39 RID: 150585 RVA: 0x00366991 File Offset: 0x00364B91
		// (set) Token: 0x06024C3A RID: 150586 RVA: 0x003669A1 File Offset: 0x00364BA1
		public unsafe int MaxQueuedChunkUpdates
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxQueuedChunkUpdates);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxQueuedChunkUpdates) = value;
			}
		}

		// Token: 0x17008E05 RID: 36357
		// (get) Token: 0x06024C3B RID: 150587 RVA: 0x003669B2 File Offset: 0x00364BB2
		// (set) Token: 0x06024C3C RID: 150588 RVA: 0x003669C2 File Offset: 0x00364BC2
		public unsafe int SlicesPerTask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_SlicesPerTask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_SlicesPerTask) = value;
			}
		}

		// Token: 0x17008E06 RID: 36358
		// (get) Token: 0x06024C3D RID: 150589 RVA: 0x003669D3 File Offset: 0x00364BD3
		// (set) Token: 0x06024C3E RID: 150590 RVA: 0x003669E3 File Offset: 0x00364BE3
		public unsafe int DigSlicesPerTask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DigSlicesPerTask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DigSlicesPerTask) = value;
			}
		}

		// Token: 0x17008E07 RID: 36359
		// (get) Token: 0x06024C3F RID: 150591 RVA: 0x003669F4 File Offset: 0x00364BF4
		// (set) Token: 0x06024C40 RID: 150592 RVA: 0x00366A04 File Offset: 0x00364C04
		public unsafe int DigStableRegularCellsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DigStableRegularCellsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_DigStableRegularCellsPerFrame) = value;
			}
		}

		// Token: 0x17008E08 RID: 36360
		// (get) Token: 0x06024C41 RID: 150593 RVA: 0x00366A15 File Offset: 0x00364C15
		// (set) Token: 0x06024C42 RID: 150594 RVA: 0x00366A25 File Offset: 0x00364C25
		public unsafe bool bEnableDigStableRegularWorker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDigStableRegularWorker) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableDigStableRegularWorker) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E09 RID: 36361
		// (get) Token: 0x06024C43 RID: 150595 RVA: 0x00366A36 File Offset: 0x00364C36
		// (set) Token: 0x06024C44 RID: 150596 RVA: 0x00366A46 File Offset: 0x00364C46
		public unsafe int LodOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_LodOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_LodOffset) = value;
			}
		}

		// Token: 0x17008E0A RID: 36362
		// (get) Token: 0x06024C45 RID: 150597 RVA: 0x00366A57 File Offset: 0x00364C57
		// (set) Token: 0x06024C46 RID: 150598 RVA: 0x00366A6B File Offset: 0x00364C6B
		public unsafe UTextureRenderTarget2D GrassMaskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_GrassMaskTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_GrassMaskTexture, value);
			}
		}

		// Token: 0x17008E0B RID: 36363
		// (get) Token: 0x06024C47 RID: 150599 RVA: 0x00366A80 File Offset: 0x00364C80
		// (set) Token: 0x06024C48 RID: 150600 RVA: 0x00366A90 File Offset: 0x00364C90
		public unsafe float GrassMaskWorldUnitsPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskWorldUnitsPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskWorldUnitsPerPixel) = value;
			}
		}

		// Token: 0x17008E0C RID: 36364
		// (get) Token: 0x06024C49 RID: 150601 RVA: 0x00366AA1 File Offset: 0x00364CA1
		// (set) Token: 0x06024C4A RID: 150602 RVA: 0x00366AB1 File Offset: 0x00364CB1
		public unsafe bool bEnableGrassMaskRuntimePaint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableGrassMaskRuntimePaint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableGrassMaskRuntimePaint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E0D RID: 36365
		// (get) Token: 0x06024C4B RID: 150603 RVA: 0x00366AC2 File Offset: 0x00364CC2
		// (set) Token: 0x06024C4C RID: 150604 RVA: 0x00366AD2 File Offset: 0x00364CD2
		public unsafe float GrassMaskDigExtraRadiusVoxelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskDigExtraRadiusVoxelCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskDigExtraRadiusVoxelCount) = value;
			}
		}

		// Token: 0x17008E0E RID: 36366
		// (get) Token: 0x06024C4D RID: 150605 RVA: 0x00366AE3 File Offset: 0x00364CE3
		// (set) Token: 0x06024C4E RID: 150606 RVA: 0x00366AF7 File Offset: 0x00364CF7
		public unsafe UFoliageType_InstancedStaticMesh GrassFoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType_InstancedStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_GrassFoliageType);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_GrassFoliageType, value);
			}
		}

		// Token: 0x17008E0F RID: 36367
		// (get) Token: 0x06024C4F RID: 150607 RVA: 0x00366B0C File Offset: 0x00364D0C
		// (set) Token: 0x06024C50 RID: 150608 RVA: 0x00366B1C File Offset: 0x00364D1C
		public unsafe int GrassMaterialSlot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaterialSlot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaterialSlot) = value;
			}
		}

		// Token: 0x17008E10 RID: 36368
		// (get) Token: 0x06024C51 RID: 150609 RVA: 0x00366B2D File Offset: 0x00364D2D
		// (set) Token: 0x06024C52 RID: 150610 RVA: 0x00366B41 File Offset: 0x00364D41
		public unsafe FVector2D GrassMaskWorldOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskWorldOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskWorldOrigin) = value;
			}
		}

		// Token: 0x17008E11 RID: 36369
		// (get) Token: 0x06024C53 RID: 150611 RVA: 0x00366B56 File Offset: 0x00364D56
		// (set) Token: 0x06024C54 RID: 150612 RVA: 0x00366B6A File Offset: 0x00364D6A
		public unsafe FVector2D GrassMaskWorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskWorldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_GrassMaskWorldSize) = value;
			}
		}

		// Token: 0x17008E12 RID: 36370
		// (get) Token: 0x06024C55 RID: 150613 RVA: 0x00366B7F File Offset: 0x00364D7F
		// (set) Token: 0x06024C56 RID: 150614 RVA: 0x00366B93 File Offset: 0x00364D93
		public unsafe FVector VoxelVolumeWorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_VoxelVolumeWorldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_VoxelVolumeWorldSize) = value;
			}
		}

		// Token: 0x17008E13 RID: 36371
		// (get) Token: 0x06024C57 RID: 150615 RVA: 0x00366BA8 File Offset: 0x00364DA8
		// (set) Token: 0x06024C58 RID: 150616 RVA: 0x00366BBC File Offset: 0x00364DBC
		public unsafe UMaterialInstanceDynamic RuntimeGrassRenderMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_RuntimeGrassRenderMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_RuntimeGrassRenderMaterial, value);
			}
		}

		// Token: 0x17008E14 RID: 36372
		// (get) Token: 0x06024C59 RID: 150617 RVA: 0x00366BD1 File Offset: 0x00364DD1
		// (set) Token: 0x06024C5A RID: 150618 RVA: 0x00366BE1 File Offset: 0x00364DE1
		public unsafe int MaxDeferredCollisionUnitsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionUnitsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionUnitsPerFrame) = value;
			}
		}

		// Token: 0x17008E15 RID: 36373
		// (get) Token: 0x06024C5B RID: 150619 RVA: 0x00366BF2 File Offset: 0x00364DF2
		// (set) Token: 0x06024C5C RID: 150620 RVA: 0x00366C02 File Offset: 0x00364E02
		public unsafe int MaxDeferredCollisionChunksPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionChunksPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionChunksPerFrame) = value;
			}
		}

		// Token: 0x17008E16 RID: 36374
		// (get) Token: 0x06024C5D RID: 150621 RVA: 0x00366C13 File Offset: 0x00364E13
		// (set) Token: 0x06024C5E RID: 150622 RVA: 0x00366C23 File Offset: 0x00364E23
		public unsafe int MaxDeferredCollisionPagesPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionPagesPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionPagesPerFrame) = value;
			}
		}

		// Token: 0x17008E17 RID: 36375
		// (get) Token: 0x06024C5F RID: 150623 RVA: 0x00366C34 File Offset: 0x00364E34
		// (set) Token: 0x06024C60 RID: 150624 RVA: 0x00366C44 File Offset: 0x00364E44
		public unsafe int MaxDeferredCollisionPairsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionPairsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_MaxDeferredCollisionPairsPerFrame) = value;
			}
		}

		// Token: 0x17008E18 RID: 36376
		// (get) Token: 0x06024C61 RID: 150625 RVA: 0x00366C55 File Offset: 0x00364E55
		// (set) Token: 0x06024C62 RID: 150626 RVA: 0x00366C65 File Offset: 0x00364E65
		public unsafe bool bEnableCollisionPageComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableCollisionPageComponents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableCollisionPageComponents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E19 RID: 36377
		// (get) Token: 0x06024C63 RID: 150627 RVA: 0x00366C76 File Offset: 0x00364E76
		// (set) Token: 0x06024C64 RID: 150628 RVA: 0x00366C86 File Offset: 0x00364E86
		public unsafe int CollisionPageDivisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CollisionPageDivisions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CollisionPageDivisions) = value;
			}
		}

		// Token: 0x17008E1A RID: 36378
		// (get) Token: 0x06024C65 RID: 150629 RVA: 0x00366C97 File Offset: 0x00364E97
		// (set) Token: 0x06024C66 RID: 150630 RVA: 0x00366CA7 File Offset: 0x00364EA7
		public unsafe bool bEnableCollisionPageDiagnostics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableCollisionPageDiagnostics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_bEnableCollisionPageDiagnostics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E1B RID: 36379
		// (get) Token: 0x06024C67 RID: 150631 RVA: 0x00366CB8 File Offset: 0x00364EB8
		// (set) Token: 0x06024C68 RID: 150632 RVA: 0x00366CC8 File Offset: 0x00364EC8
		public unsafe int CollisionPageDiagnosticDivisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CollisionPageDiagnosticDivisions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_CollisionPageDiagnosticDivisions) = value;
			}
		}

		// Token: 0x17008E1C RID: 36380
		// (get) Token: 0x06024C69 RID: 150633 RVA: 0x00366CD9 File Offset: 0x00364ED9
		// (set) Token: 0x06024C6A RID: 150634 RVA: 0x00366CE9 File Offset: 0x00364EE9
		public unsafe int TriangleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TriangleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_TriangleCount) = value;
			}
		}

		// Token: 0x17008E1D RID: 36381
		// (get) Token: 0x06024C6B RID: 150635 RVA: 0x00366CFC File Offset: 0x00364EFC
		// (set) Token: 0x06024C6C RID: 150636 RVA: 0x00366D35 File Offset: 0x00364F35
		[Nullable(1)]
		public TArray<FTransvoxelGrassMaterialRestore> RuntimeGrassMaterialRestores
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransvoxelGrassMaterialRestore> result;
				if ((result = this._RuntimeGrassMaterialRestores) == null)
				{
					result = (this._RuntimeGrassMaterialRestores = new TArray<FTransvoxelGrassMaterialRestore>(base.NativePtr + (IntPtr)ATransvoxelConsumer.__PropertyOffset_RuntimeGrassMaterialRestores, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RuntimeGrassMaterialRestores.CopyAssign(value);
			}
		}

		// Token: 0x17008E1E RID: 36382
		// (get) Token: 0x06024C6D RID: 150637 RVA: 0x00366D43 File Offset: 0x00364F43
		// (set) Token: 0x06024C6E RID: 150638 RVA: 0x00366D57 File Offset: 0x00364F57
		public unsafe UMaterialInstanceDynamic MeshPassMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_MeshPassMaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_MeshPassMaterialInstance, value);
			}
		}

		// Token: 0x17008E1F RID: 36383
		// (get) Token: 0x06024C6F RID: 150639 RVA: 0x00366D6C File Offset: 0x00364F6C
		// (set) Token: 0x06024C70 RID: 150640 RVA: 0x00366D80 File Offset: 0x00364F80
		public unsafe UMaterialInterface MeshPassMaterialSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_MeshPassMaterialSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransvoxelConsumer.__PropertyOffset_MeshPassMaterialSource, value);
			}
		}

		// Token: 0x06024C71 RID: 150641 RVA: 0x00366D95 File Offset: 0x00364F95
		public void TriggerDemoDig()
		{
			ATransvoxelConsumer.__TriggerDemoDig_Internal(base.NativePtr);
		}

		// Token: 0x06024C72 RID: 150642 RVA: 0x00366DA2 File Offset: 0x00364FA2
		public void SetTransvoxelDestroyed(bool bDestroyed)
		{
			ATransvoxelConsumer.__SetTransvoxelDestroyed_Internal(base.NativePtr, bDestroyed);
		}

		// Token: 0x06024C73 RID: 150643 RVA: 0x00366DB0 File Offset: 0x00364FB0
		public bool RequestDigSphere(in FVector WorldPosition, float Radius)
		{
			return ATransvoxelConsumer.__RequestDigSphere_Internal(base.NativePtr, WorldPosition, Radius);
		}

		// Token: 0x06024C74 RID: 150644 RVA: 0x00366DC0 File Offset: 0x00364FC0
		public void ProcessTransitionCell(int VoxelX, int VoxelY, int VoxelZ, int ChunkX0, int ChunkY0, int ChunkZ0, int ChunkX1, int ChunkY1, int ChunkZ1, bool bAppend = false)
		{
			ATransvoxelConsumer.__ProcessTransitionCell_Internal(base.NativePtr, VoxelX, VoxelY, VoxelZ, ChunkX0, ChunkY0, ChunkZ0, ChunkX1, ChunkY1, ChunkZ1, bAppend);
		}

		// Token: 0x06024C75 RID: 150645 RVA: 0x00366DE9 File Offset: 0x00364FE9
		public void OnKeyKPressed()
		{
			ATransvoxelConsumer.__OnKeyKPressed_Internal(base.NativePtr);
		}

		// Token: 0x06024C76 RID: 150646 RVA: 0x00366DF6 File Offset: 0x00364FF6
		public void InitializeGrassMaskTextures()
		{
			ATransvoxelConsumer.__InitializeGrassMaskTextures_Internal(base.NativePtr);
		}

		// Token: 0x06024C77 RID: 150647 RVA: 0x00366E03 File Offset: 0x00365003
		public UMaterialInstanceDynamic GetRuntimeGrassRenderMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ATransvoxelConsumer.__GetRuntimeGrassRenderMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06024C78 RID: 150648 RVA: 0x00366E15 File Offset: 0x00365015
		public void GenerateTransvoxelMesh(bool bReloadFromConfig = true)
		{
			ATransvoxelConsumer.__GenerateTransvoxelMesh_Internal(base.NativePtr, bReloadFromConfig);
		}

		// Token: 0x06024C79 RID: 150649 RVA: 0x00366E23 File Offset: 0x00365023
		public void GenerateCompressedDataFromHeightMap()
		{
			ATransvoxelConsumer.__GenerateCompressedDataFromHeightMap_Internal(base.NativePtr);
		}

		// Token: 0x06024C7A RID: 150650 RVA: 0x00366E30 File Offset: 0x00365030
		public void ExportGeneratedMeshJson()
		{
			ATransvoxelConsumer.__ExportGeneratedMeshJson_Internal(base.NativePtr);
		}

		// Token: 0x06024C7B RID: 150651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerDemoDig_Internal(IntPtr @this);

		// Token: 0x06024C7C RID: 150652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransvoxelDestroyed_Internal(IntPtr @this, bool bDestroyed);

		// Token: 0x06024C7D RID: 150653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RequestDigSphere_Internal(IntPtr @this, in FVector WorldPosition, float Radius);

		// Token: 0x06024C7E RID: 150654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ProcessTransitionCell_Internal(IntPtr @this, int VoxelX, int VoxelY, int VoxelZ, int ChunkX0, int ChunkY0, int ChunkZ0, int ChunkX1, int ChunkY1, int ChunkZ1, bool bAppend);

		// Token: 0x06024C7F RID: 150655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnKeyKPressed_Internal(IntPtr @this);

		// Token: 0x06024C80 RID: 150656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeGrassMaskTextures_Internal(IntPtr @this);

		// Token: 0x06024C81 RID: 150657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRuntimeGrassRenderMaterial_Internal(IntPtr @this);

		// Token: 0x06024C82 RID: 150658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateTransvoxelMesh_Internal(IntPtr @this, bool bReloadFromConfig);

		// Token: 0x06024C83 RID: 150659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateCompressedDataFromHeightMap_Internal(IntPtr @this);

		// Token: 0x06024C84 RID: 150660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExportGeneratedMeshJson_Internal(IntPtr @this);

		// Token: 0x06024C85 RID: 150661 RVA: 0x00366E3D File Offset: 0x0036503D
		static ATransvoxelConsumer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.TransvoxelConsumer");
		}

		// Token: 0x06024C86 RID: 150662 RVA: 0x00366E4B File Offset: 0x0036504B
		protected ATransvoxelConsumer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013BF4 RID: 80884
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Renderer.TransvoxelConsumer";

		// Token: 0x04013BF5 RID: 80885
		private static IntPtr _ClassPtr;

		// Token: 0x04013BF6 RID: 80886
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013BF7 RID: 80887
		internal static int __PropertyOffset_bTransvoxelDestroyed;

		// Token: 0x04013BF8 RID: 80888
		internal static int __PropertyOffset_ConfigDataAsset;

		// Token: 0x04013BF9 RID: 80889
		internal static int __PropertyOffset_CompressedDataAsset;

		// Token: 0x04013BFA RID: 80890
		internal static int __PropertyOffset_RenderConfigDataAsset;

		// Token: 0x04013BFB RID: 80891
		internal static int __PropertyOffset_HeightMapCompressedGenerationSettings;

		// Token: 0x04013BFC RID: 80892
		private FTransvoxelHeightMapCompressedGenerationSettings _HeightMapCompressedGenerationSettings;

		// Token: 0x04013BFD RID: 80893
		internal static int __PropertyOffset_bPlacePlayerOnTerrainAtBeginPlay;

		// Token: 0x04013BFE RID: 80894
		internal static int __PropertyOffset_IsoLevel;

		// Token: 0x04013BFF RID: 80895
		internal static int __PropertyOffset_bEnableDebugDraw_cornerPoints;

		// Token: 0x04013C00 RID: 80896
		internal static int __PropertyOffset_bEnableDebugDraw_triangleWireframe;

		// Token: 0x04013C01 RID: 80897
		internal static int __PropertyOffset_bEnableDebugDraw_normals;

		// Token: 0x04013C02 RID: 80898
		internal static int __PropertyOffset_bEnableDebugDraw_collisionBounds;

		// Token: 0x04013C03 RID: 80899
		internal static int __PropertyOffset_bEnableDebugDraw_digSphere;

		// Token: 0x04013C04 RID: 80900
		internal static int __PropertyOffset_showColor;

		// Token: 0x04013C05 RID: 80901
		internal static int __PropertyOffset_bEnableDigGradientCache;

		// Token: 0x04013C06 RID: 80902
		internal static int __PropertyOffset_bForceFullStableCacheRebuildOnDig;

		// Token: 0x04013C07 RID: 80903
		internal static int __PropertyOffset_DensitySmoothIterations;

		// Token: 0x04013C08 RID: 80904
		internal static int __PropertyOffset_bFilterDegenerateTriangles;

		// Token: 0x04013C09 RID: 80905
		internal static int __PropertyOffset_DegenerateTriangleAreaThreshold;

		// Token: 0x04013C0A RID: 80906
		internal static int __PropertyOffset_EdgeClampMargin;

		// Token: 0x04013C0B RID: 80907
		internal static int __PropertyOffset_bEnableAdaptiveEdgeClamp;

		// Token: 0x04013C0C RID: 80908
		internal static int __PropertyOffset_AdaptiveEdgeClampTriggerMargin;

		// Token: 0x04013C0D RID: 80909
		internal static int __PropertyOffset_AdaptiveEdgeClampMargin;

		// Token: 0x04013C0E RID: 80910
		internal static int __PropertyOffset_bBatchDigStableCacheSubmit;

		// Token: 0x04013C0F RID: 80911
		internal static int __PropertyOffset_RuntimeDigRadius;

		// Token: 0x04013C10 RID: 80912
		internal static int __PropertyOffset_RuntimeDigDensityGain;

		// Token: 0x04013C11 RID: 80913
		internal static int __PropertyOffset_RuntimeDigFeatherVoxelCount;

		// Token: 0x04013C12 RID: 80914
		internal static int __PropertyOffset_bEnableRuntimeDigDensitySmoothing;

		// Token: 0x04013C13 RID: 80915
		internal static int __PropertyOffset_RuntimeDigDensitySmoothIterations;

		// Token: 0x04013C14 RID: 80916
		internal static int __PropertyOffset_RuntimeDigDensitySmoothStrength;

		// Token: 0x04013C15 RID: 80917
		internal static int __PropertyOffset_RuntimeDigDensitySmoothRadiusVoxelPadding;

		// Token: 0x04013C16 RID: 80918
		internal static int __PropertyOffset_RuntimeDigDensitySmoothBandDensity;

		// Token: 0x04013C17 RID: 80919
		internal static int __PropertyOffset_bEnableDebris;

		// Token: 0x04013C18 RID: 80920
		internal static int __PropertyOffset_CharacterUpDigOffset;

		// Token: 0x04013C19 RID: 80921
		internal static int __PropertyOffset_CharacterForwardDigOffset;

		// Token: 0x04013C1A RID: 80922
		internal static int __PropertyOffset_bEnableTessellation;

		// Token: 0x04013C1B RID: 80923
		internal static int __PropertyOffset_bShowExactTessWireframe;

		// Token: 0x04013C1C RID: 80924
		internal static int __PropertyOffset_TessNearDistance;

		// Token: 0x04013C1D RID: 80925
		internal static int __PropertyOffset_TessFarDistance;

		// Token: 0x04013C1E RID: 80926
		internal static int __PropertyOffset_TessMinFactor;

		// Token: 0x04013C1F RID: 80927
		internal static int __PropertyOffset_TessMaxFactor;

		// Token: 0x04013C20 RID: 80928
		internal static int __PropertyOffset_TessBulgeStrength;

		// Token: 0x04013C21 RID: 80929
		internal static int __PropertyOffset_RuntimeRenderMode;

		// Token: 0x04013C22 RID: 80930
		internal static int __PropertyOffset_RuntimeChunkMaterial;

		// Token: 0x04013C23 RID: 80931
		internal static int __PropertyOffset_bCustomRendererEnableTexturedShading;

		// Token: 0x04013C24 RID: 80932
		internal static int __PropertyOffset_bCustomRendererUseDitheredMaterialSampling;

		// Token: 0x04013C25 RID: 80933
		internal static int __PropertyOffset_CustomRendererSurfaceWeightTexture;

		// Token: 0x04013C26 RID: 80934
		internal static int __PropertyOffset_CustomRendererSurfaceDiffuseTextures;

		// Token: 0x04013C27 RID: 80935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _CustomRendererSurfaceDiffuseTextures;

		// Token: 0x04013C28 RID: 80936
		internal static int __PropertyOffset_CustomRendererSurfaceNormalTextures;

		// Token: 0x04013C29 RID: 80937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _CustomRendererSurfaceNormalTextures;

		// Token: 0x04013C2A RID: 80938
		internal static int __PropertyOffset_CustomRendererInteriorDiffuseTextures;

		// Token: 0x04013C2B RID: 80939
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _CustomRendererInteriorDiffuseTextures;

		// Token: 0x04013C2C RID: 80940
		internal static int __PropertyOffset_CustomRendererInteriorNormalTextures;

		// Token: 0x04013C2D RID: 80941
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _CustomRendererInteriorNormalTextures;

		// Token: 0x04013C2E RID: 80942
		internal static int __PropertyOffset_CustomRendererLockedDiffuseTexture;

		// Token: 0x04013C2F RID: 80943
		internal static int __PropertyOffset_CustomRendererLockedNormalTexture;

		// Token: 0x04013C30 RID: 80944
		internal static int __PropertyOffset_CustomRendererSurfaceHeightBlendWidth;

		// Token: 0x04013C31 RID: 80945
		internal static int __PropertyOffset_CustomRendererMaterialWorldSize;

		// Token: 0x04013C32 RID: 80946
		internal static int __PropertyOffset_CustomRendererWorldTextureScale;

		// Token: 0x04013C33 RID: 80947
		internal static int __PropertyOffset_bCustomRendererUseTriplanarMaterialSampling;

		// Token: 0x04013C34 RID: 80948
		internal static int __PropertyOffset_CustomRendererTriplanarBlendSharpness;

		// Token: 0x04013C35 RID: 80949
		internal static int __PropertyOffset_CustomRendererNormalMapStrength;

		// Token: 0x04013C36 RID: 80950
		internal static int __PropertyOffset_HeightSplatPoints;

		// Token: 0x04013C37 RID: 80951
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransvoxelHeightSplatPoint> _HeightSplatPoints;

		// Token: 0x04013C38 RID: 80952
		internal static int __PropertyOffset_bEnableRuntimeLog_queue;

		// Token: 0x04013C39 RID: 80953
		internal static int __PropertyOffset_bEnableRuntimeStatsOverlay;

		// Token: 0x04013C3A RID: 80954
		internal static int __PropertyOffset_bDigInterruptsLod;

		// Token: 0x04013C3B RID: 80955
		internal static int __PropertyOffset_MinDigInterval;

		// Token: 0x04013C3C RID: 80956
		internal static int __PropertyOffset_MaxCompressedVoxelRebuildChunksPerFrame;

		// Token: 0x04013C3D RID: 80957
		internal static int __PropertyOffset_MaxUpdateUnitsPerFrame;

		// Token: 0x04013C3E RID: 80958
		internal static int __PropertyOffset_MaxQueuedChunkUpdates;

		// Token: 0x04013C3F RID: 80959
		internal static int __PropertyOffset_SlicesPerTask;

		// Token: 0x04013C40 RID: 80960
		internal static int __PropertyOffset_DigSlicesPerTask;

		// Token: 0x04013C41 RID: 80961
		internal static int __PropertyOffset_DigStableRegularCellsPerFrame;

		// Token: 0x04013C42 RID: 80962
		internal static int __PropertyOffset_bEnableDigStableRegularWorker;

		// Token: 0x04013C43 RID: 80963
		internal static int __PropertyOffset_LodOffset;

		// Token: 0x04013C44 RID: 80964
		internal static int __PropertyOffset_GrassMaskTexture;

		// Token: 0x04013C45 RID: 80965
		internal static int __PropertyOffset_GrassMaskWorldUnitsPerPixel;

		// Token: 0x04013C46 RID: 80966
		internal static int __PropertyOffset_bEnableGrassMaskRuntimePaint;

		// Token: 0x04013C47 RID: 80967
		internal static int __PropertyOffset_GrassMaskDigExtraRadiusVoxelCount;

		// Token: 0x04013C48 RID: 80968
		internal static int __PropertyOffset_GrassFoliageType;

		// Token: 0x04013C49 RID: 80969
		internal static int __PropertyOffset_GrassMaterialSlot;

		// Token: 0x04013C4A RID: 80970
		internal static int __PropertyOffset_GrassMaskWorldOrigin;

		// Token: 0x04013C4B RID: 80971
		internal static int __PropertyOffset_GrassMaskWorldSize;

		// Token: 0x04013C4C RID: 80972
		internal static int __PropertyOffset_VoxelVolumeWorldSize;

		// Token: 0x04013C4D RID: 80973
		internal static int __PropertyOffset_RuntimeGrassRenderMaterial;

		// Token: 0x04013C4E RID: 80974
		internal static int __PropertyOffset_MaxDeferredCollisionUnitsPerFrame;

		// Token: 0x04013C4F RID: 80975
		internal static int __PropertyOffset_MaxDeferredCollisionChunksPerFrame;

		// Token: 0x04013C50 RID: 80976
		internal static int __PropertyOffset_MaxDeferredCollisionPagesPerFrame;

		// Token: 0x04013C51 RID: 80977
		internal static int __PropertyOffset_MaxDeferredCollisionPairsPerFrame;

		// Token: 0x04013C52 RID: 80978
		internal static int __PropertyOffset_bEnableCollisionPageComponents;

		// Token: 0x04013C53 RID: 80979
		internal static int __PropertyOffset_CollisionPageDivisions;

		// Token: 0x04013C54 RID: 80980
		internal static int __PropertyOffset_bEnableCollisionPageDiagnostics;

		// Token: 0x04013C55 RID: 80981
		internal static int __PropertyOffset_CollisionPageDiagnosticDivisions;

		// Token: 0x04013C56 RID: 80982
		internal static int __PropertyOffset_TriangleCount;

		// Token: 0x04013C57 RID: 80983
		internal static int __PropertyOffset_RuntimeGrassMaterialRestores;

		// Token: 0x04013C58 RID: 80984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransvoxelGrassMaterialRestore> _RuntimeGrassMaterialRestores;

		// Token: 0x04013C59 RID: 80985
		internal static int __PropertyOffset_MeshPassMaterialInstance;

		// Token: 0x04013C5A RID: 80986
		internal static int __PropertyOffset_MeshPassMaterialSource;
	}
}
