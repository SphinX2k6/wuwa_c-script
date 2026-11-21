using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200044F RID: 1103
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroEnviInteractionData")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FKuroEnviInteractionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006A8B RID: 27275 RVA: 0x0009B400 File Offset: 0x00099600
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEnviInteractionData._ScriptStructPtr != 0) ? FKuroEnviInteractionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroEnviInteractionData", ref FKuroEnviInteractionData._ScriptStructPtr);
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06006A8C RID: 27276 RVA: 0x0009B424 File Offset: 0x00099624
		// (set) Token: 0x06006A8D RID: 27277 RVA: 0x0009B434 File Offset: 0x00099634
		public unsafe bool bInWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bInWater) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bInWater) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06006A8E RID: 27278 RVA: 0x0009B445 File Offset: 0x00099645
		// (set) Token: 0x06006A8F RID: 27279 RVA: 0x0009B455 File Offset: 0x00099655
		public unsafe bool bTraceWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bTraceWater) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bTraceWater) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06006A90 RID: 27280 RVA: 0x0009B466 File Offset: 0x00099666
		// (set) Token: 0x06006A91 RID: 27281 RVA: 0x0009B47A File Offset: 0x0009967A
		public unsafe FVector HitWaterLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitWaterLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitWaterLocation) = value;
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06006A92 RID: 27282 RVA: 0x0009B48F File Offset: 0x0009968F
		// (set) Token: 0x06006A93 RID: 27283 RVA: 0x0009B4A3 File Offset: 0x000996A3
		public unsafe FVector HitWaterNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitWaterNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitWaterNormal) = value;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06006A94 RID: 27284 RVA: 0x0009B4B8 File Offset: 0x000996B8
		// (set) Token: 0x06006A95 RID: 27285 RVA: 0x0009B4CC File Offset: 0x000996CC
		[Nullable(2)]
		public unsafe UPhysicalMaterial HitPhysicMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEnviInteractionData.__PropertyOffset_HitPhysicMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEnviInteractionData.__PropertyOffset_HitPhysicMaterial, value);
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06006A96 RID: 27286 RVA: 0x0009B4E4 File Offset: 0x000996E4
		// (set) Token: 0x06006A97 RID: 27287 RVA: 0x0009B527 File Offset: 0x00099727
		public TArray<string> HitPhysicMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HitPhysicMaterialArray) == null)
				{
					result = (this._HitPhysicMaterialArray = new TArray<string>(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitPhysicMaterialArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HitPhysicMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x0009B538 File Offset: 0x00099738
		// (set) Token: 0x06006A99 RID: 27289 RVA: 0x0009B57B File Offset: 0x0009977B
		public TArray<string> HitTagArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HitTagArray) == null)
				{
					result = (this._HitTagArray = new TArray<string>(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitTagArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HitTagArray.CopyAssign(value);
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06006A9A RID: 27290 RVA: 0x0009B589 File Offset: 0x00099789
		// (set) Token: 0x06006A9B RID: 27291 RVA: 0x0009B599 File Offset: 0x00099799
		public unsafe float CapsuleToBlock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_CapsuleToBlock);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_CapsuleToBlock) = value;
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06006A9C RID: 27292 RVA: 0x0009B5AA File Offset: 0x000997AA
		// (set) Token: 0x06006A9D RID: 27293 RVA: 0x0009B5BA File Offset: 0x000997BA
		public unsafe float CapsuleToWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_CapsuleToWater);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_CapsuleToWater) = value;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06006A9E RID: 27294 RVA: 0x0009B5CB File Offset: 0x000997CB
		// (set) Token: 0x06006A9F RID: 27295 RVA: 0x0009B5DB File Offset: 0x000997DB
		public unsafe float WaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_WaterDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_WaterDepth) = value;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06006AA0 RID: 27296 RVA: 0x0009B5EC File Offset: 0x000997EC
		// (set) Token: 0x06006AA1 RID: 27297 RVA: 0x0009B5FC File Offset: 0x000997FC
		public unsafe int WaterType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_WaterType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_WaterType) = value;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x0009B60D File Offset: 0x0009980D
		// (set) Token: 0x06006AA3 RID: 27299 RVA: 0x0009B61D File Offset: 0x0009981D
		public unsafe bool bHideOnBush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bHideOnBush) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bHideOnBush) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06006AA4 RID: 27300 RVA: 0x0009B62E File Offset: 0x0009982E
		// (set) Token: 0x06006AA5 RID: 27301 RVA: 0x0009B63E File Offset: 0x0009983E
		public unsafe bool bHitAudioShrub
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bHitAudioShrub) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bHitAudioShrub) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06006AA6 RID: 27302 RVA: 0x0009B64F File Offset: 0x0009984F
		// (set) Token: 0x06006AA7 RID: 27303 RVA: 0x0009B663 File Offset: 0x00099863
		public unsafe FName AudioShrubFirstMaterialName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_AudioShrubFirstMaterialName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_AudioShrubFirstMaterialName) = value;
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06006AA8 RID: 27304 RVA: 0x0009B678 File Offset: 0x00099878
		// (set) Token: 0x06006AA9 RID: 27305 RVA: 0x0009B68C File Offset: 0x0009988C
		[Nullable(2)]
		public unsafe UStaticMeshComponent AudioShrubStaticMeshComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEnviInteractionData.__PropertyOffset_AudioShrubStaticMeshComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEnviInteractionData.__PropertyOffset_AudioShrubStaticMeshComp, value);
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06006AAA RID: 27306 RVA: 0x0009B6A1 File Offset: 0x000998A1
		// (set) Token: 0x06006AAB RID: 27307 RVA: 0x0009B6B5 File Offset: 0x000998B5
		public unsafe FVector TriggerHitPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_TriggerHitPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_TriggerHitPoint) = value;
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x0009B6CA File Offset: 0x000998CA
		// (set) Token: 0x06006AAD RID: 27309 RVA: 0x0009B6DA File Offset: 0x000998DA
		public unsafe float HitBushLUTIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitBushLUTIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitBushLUTIndex) = value;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06006AAE RID: 27310 RVA: 0x0009B6EB File Offset: 0x000998EB
		// (set) Token: 0x06006AAF RID: 27311 RVA: 0x0009B6FF File Offset: 0x000998FF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> HitBushActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitBushActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitBushActor) = value;
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x0009B714 File Offset: 0x00099914
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x0009B757 File Offset: 0x00099957
		public FKuroBushIEParameter BushIEParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBushIEParameter result;
				if ((result = this._BushIEParam) == null)
				{
					result = (this._BushIEParam = new FKuroBushIEParameter(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_BushIEParam, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBushIEParameter.StaticStruct(), base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_BushIEParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x0009B778 File Offset: 0x00099978
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x0009B788 File Offset: 0x00099988
		public unsafe bool OverlapTriggerMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_OverlapTriggerMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_OverlapTriggerMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x0009B799 File Offset: 0x00099999
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x0009B7AD File Offset: 0x000999AD
		public unsafe FVector OverlapTriggerParam0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_OverlapTriggerParam0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_OverlapTriggerParam0) = value;
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x0009B7C2 File Offset: 0x000999C2
		// (set) Token: 0x06006AB7 RID: 27319 RVA: 0x0009B7D2 File Offset: 0x000999D2
		public unsafe bool bTouchBlackWave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bTouchBlackWave) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_bTouchBlackWave) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x0009B7E3 File Offset: 0x000999E3
		// (set) Token: 0x06006AB9 RID: 27321 RVA: 0x0009B7F7 File Offset: 0x000999F7
		public unsafe FVector HitWaterLocationWithOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitWaterLocationWithOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEnviInteractionData.__PropertyOffset_HitWaterLocationWithOffset) = value;
			}
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x0009B80C File Offset: 0x00099A0C
		public FKuroEnviInteractionData()
		{
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x0009B814 File Offset: 0x00099A14
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEnviInteractionData.StaticStruct();
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x0009B820 File Offset: 0x00099A20
		[NullableContext(2)]
		public FKuroEnviInteractionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x0009B82A File Offset: 0x00099A2A
		public FKuroEnviInteractionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x0009B835 File Offset: 0x00099A35
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEnviInteractionData(Pointer, false, true);
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x0009B83F File Offset: 0x00099A3F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEnviInteractionData(Pointer, MemoryOwner);
		}

		// Token: 0x04002D2C RID: 11564
		public const string __ObjectPath = "/Script/KuroInteractionEffect.KuroEnviInteractionData";

		// Token: 0x04002D2D RID: 11565
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D2E RID: 11566
		internal static int __PropertyOffset_bInWater;

		// Token: 0x04002D2F RID: 11567
		internal static int __PropertyOffset_bTraceWater;

		// Token: 0x04002D30 RID: 11568
		internal static int __PropertyOffset_HitWaterLocation;

		// Token: 0x04002D31 RID: 11569
		internal static int __PropertyOffset_HitWaterNormal;

		// Token: 0x04002D32 RID: 11570
		internal static int __PropertyOffset_HitPhysicMaterial;

		// Token: 0x04002D33 RID: 11571
		internal static int __PropertyOffset_HitPhysicMaterialArray;

		// Token: 0x04002D34 RID: 11572
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HitPhysicMaterialArray;

		// Token: 0x04002D35 RID: 11573
		internal static int __PropertyOffset_HitTagArray;

		// Token: 0x04002D36 RID: 11574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HitTagArray;

		// Token: 0x04002D37 RID: 11575
		internal static int __PropertyOffset_CapsuleToBlock;

		// Token: 0x04002D38 RID: 11576
		internal static int __PropertyOffset_CapsuleToWater;

		// Token: 0x04002D39 RID: 11577
		internal static int __PropertyOffset_WaterDepth;

		// Token: 0x04002D3A RID: 11578
		internal static int __PropertyOffset_WaterType;

		// Token: 0x04002D3B RID: 11579
		internal static int __PropertyOffset_bHideOnBush;

		// Token: 0x04002D3C RID: 11580
		internal static int __PropertyOffset_bHitAudioShrub;

		// Token: 0x04002D3D RID: 11581
		internal static int __PropertyOffset_AudioShrubFirstMaterialName;

		// Token: 0x04002D3E RID: 11582
		internal static int __PropertyOffset_AudioShrubStaticMeshComp;

		// Token: 0x04002D3F RID: 11583
		internal static int __PropertyOffset_TriggerHitPoint;

		// Token: 0x04002D40 RID: 11584
		internal static int __PropertyOffset_HitBushLUTIndex;

		// Token: 0x04002D41 RID: 11585
		internal static int __PropertyOffset_HitBushActor;

		// Token: 0x04002D42 RID: 11586
		internal static int __PropertyOffset_BushIEParam;

		// Token: 0x04002D43 RID: 11587
		[Nullable(2)]
		private FKuroBushIEParameter _BushIEParam;

		// Token: 0x04002D44 RID: 11588
		internal static int __PropertyOffset_OverlapTriggerMesh;

		// Token: 0x04002D45 RID: 11589
		internal static int __PropertyOffset_OverlapTriggerParam0;

		// Token: 0x04002D46 RID: 11590
		internal static int __PropertyOffset_bTouchBlackWave;

		// Token: 0x04002D47 RID: 11591
		internal static int __PropertyOffset_HitWaterLocationWithOffset;
	}
}
