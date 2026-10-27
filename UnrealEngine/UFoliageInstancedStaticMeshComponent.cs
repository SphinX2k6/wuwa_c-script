using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C6 RID: 4806
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.FoliageInstancedStaticMeshComponent")]
	[UnrealStructLayout(3312, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3312)]
	public class UFoliageInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011950 RID: 72016 RVA: 0x0019CA46 File Offset: 0x0019AC46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFoliageInstancedStaticMeshComponent._ClassPtr;
		}

		// Token: 0x06011951 RID: 72017 RVA: 0x0019CA54 File Offset: 0x0019AC54
		public UFoliageInstancedStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UFoliageInstancedStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011952 RID: 72018 RVA: 0x0019CA7C File Offset: 0x0019AC7C
		public UFoliageInstancedStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFoliageInstancedStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x06011953 RID: 72019 RVA: 0x0019CAB0 File Offset: 0x0019ACB0
		// (set) Token: 0x06011954 RID: 72020 RVA: 0x0019CAE9 File Offset: 0x0019ACE9
		public FInstancePointDamageSignature OnInstanceTakePointDamage
		{
			get
			{
				base.FastCheckIsValid();
				FInstancePointDamageSignature result;
				if ((result = this._OnInstanceTakePointDamage) == null)
				{
					result = (this._OnInstanceTakePointDamage = new FInstancePointDamageSignature(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_OnInstanceTakePointDamage, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_OnInstanceTakePointDamage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x06011955 RID: 72021 RVA: 0x0019CB0C File Offset: 0x0019AD0C
		// (set) Token: 0x06011956 RID: 72022 RVA: 0x0019CB45 File Offset: 0x0019AD45
		public FInstanceRadialDamageSignature OnInstanceTakeRadialDamage
		{
			get
			{
				base.FastCheckIsValid();
				FInstanceRadialDamageSignature result;
				if ((result = this._OnInstanceTakeRadialDamage) == null)
				{
					result = (this._OnInstanceTakeRadialDamage = new FInstanceRadialDamageSignature(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_OnInstanceTakeRadialDamage, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_OnInstanceTakeRadialDamage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x06011957 RID: 72023 RVA: 0x0019CB66 File Offset: 0x0019AD66
		// (set) Token: 0x06011958 RID: 72024 RVA: 0x0019CB76 File Offset: 0x0019AD76
		public unsafe bool bEnableDiscardOnLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_bEnableDiscardOnLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_bEnableDiscardOnLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x06011959 RID: 72025 RVA: 0x0019CB87 File Offset: 0x0019AD87
		// (set) Token: 0x0601195A RID: 72026 RVA: 0x0019CB97 File Offset: 0x0019AD97
		public unsafe bool bCachedTextureStreamingValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_bCachedTextureStreamingValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_bCachedTextureStreamingValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004498 RID: 17560
		// (get) Token: 0x0601195B RID: 72027 RVA: 0x0019CBA8 File Offset: 0x0019ADA8
		// (set) Token: 0x0601195C RID: 72028 RVA: 0x0019CBB8 File Offset: 0x0019ADB8
		public unsafe bool bCachedMinMaxScaleValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_bCachedMinMaxScaleValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_bCachedMinMaxScaleValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004499 RID: 17561
		// (get) Token: 0x0601195D RID: 72029 RVA: 0x0019CBC9 File Offset: 0x0019ADC9
		// (set) Token: 0x0601195E RID: 72030 RVA: 0x0019CBDD File Offset: 0x0019ADDD
		public unsafe FVector CachedMinScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_CachedMinScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_CachedMinScale) = value;
			}
		}

		// Token: 0x1700449A RID: 17562
		// (get) Token: 0x0601195F RID: 72031 RVA: 0x0019CBF2 File Offset: 0x0019ADF2
		// (set) Token: 0x06011960 RID: 72032 RVA: 0x0019CC06 File Offset: 0x0019AE06
		public unsafe FVector CachedMaxScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_CachedMaxScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_CachedMaxScale) = value;
			}
		}

		// Token: 0x1700449B RID: 17563
		// (get) Token: 0x06011961 RID: 72033 RVA: 0x0019CC1B File Offset: 0x0019AE1B
		// (set) Token: 0x06011962 RID: 72034 RVA: 0x0019CC2B File Offset: 0x0019AE2B
		public unsafe float CachedWeightedTextureStreamingScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_CachedWeightedTextureStreamingScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_CachedWeightedTextureStreamingScale) = value;
			}
		}

		// Token: 0x1700449C RID: 17564
		// (get) Token: 0x06011963 RID: 72035 RVA: 0x0019CC3C File Offset: 0x0019AE3C
		// (set) Token: 0x06011964 RID: 72036 RVA: 0x0019CC50 File Offset: 0x0019AE50
		public unsafe FGuid GenerationGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_GenerationGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageInstancedStaticMeshComponent.__PropertyOffset_GenerationGuid) = value;
			}
		}

		// Token: 0x06011965 RID: 72037 RVA: 0x0019CC65 File Offset: 0x0019AE65
		static UFoliageInstancedStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.FoliageInstancedStaticMeshComponent");
		}

		// Token: 0x06011966 RID: 72038 RVA: 0x0019CC73 File Offset: 0x0019AE73
		protected UFoliageInstancedStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040096B2 RID: 38578
		public new const string __ObjectPath = "/Script/Foliage.FoliageInstancedStaticMeshComponent";

		// Token: 0x040096B3 RID: 38579
		private static IntPtr _ClassPtr;

		// Token: 0x040096B4 RID: 38580
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040096B5 RID: 38581
		internal static int __PropertyOffset_OnInstanceTakePointDamage;

		// Token: 0x040096B6 RID: 38582
		[Nullable(2)]
		private FInstancePointDamageSignature _OnInstanceTakePointDamage;

		// Token: 0x040096B7 RID: 38583
		internal static int __PropertyOffset_OnInstanceTakeRadialDamage;

		// Token: 0x040096B8 RID: 38584
		[Nullable(2)]
		private FInstanceRadialDamageSignature _OnInstanceTakeRadialDamage;

		// Token: 0x040096B9 RID: 38585
		internal static int __PropertyOffset_bEnableDiscardOnLoad;

		// Token: 0x040096BA RID: 38586
		internal static int __PropertyOffset_bCachedTextureStreamingValid;

		// Token: 0x040096BB RID: 38587
		internal static int __PropertyOffset_bCachedMinMaxScaleValid;

		// Token: 0x040096BC RID: 38588
		internal static int __PropertyOffset_CachedMinScale;

		// Token: 0x040096BD RID: 38589
		internal static int __PropertyOffset_CachedMaxScale;

		// Token: 0x040096BE RID: 38590
		internal static int __PropertyOffset_CachedWeightedTextureStreamingScale;

		// Token: 0x040096BF RID: 38591
		internal static int __PropertyOffset_GenerationGuid;
	}
}
