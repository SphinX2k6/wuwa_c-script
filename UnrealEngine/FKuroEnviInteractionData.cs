using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019A2 RID: 6562
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroEnviInteractionData")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FKuroEnviInteractionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018677 RID: 99959 RVA: 0x0023F874 File Offset: 0x0023DA74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEnviInteractionData._ScriptStructPtr != 0) ? FKuroEnviInteractionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroEnviInteractionData", ref FKuroEnviInteractionData._ScriptStructPtr);
		}

		// Token: 0x17006171 RID: 24945
		// (get) Token: 0x06018678 RID: 99960 RVA: 0x0023F898 File Offset: 0x0023DA98
		// (set) Token: 0x06018679 RID: 99961 RVA: 0x0023F8A8 File Offset: 0x0023DAA8
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

		// Token: 0x17006172 RID: 24946
		// (get) Token: 0x0601867A RID: 99962 RVA: 0x0023F8B9 File Offset: 0x0023DAB9
		// (set) Token: 0x0601867B RID: 99963 RVA: 0x0023F8C9 File Offset: 0x0023DAC9
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

		// Token: 0x17006173 RID: 24947
		// (get) Token: 0x0601867C RID: 99964 RVA: 0x0023F8DA File Offset: 0x0023DADA
		// (set) Token: 0x0601867D RID: 99965 RVA: 0x0023F8EE File Offset: 0x0023DAEE
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

		// Token: 0x17006174 RID: 24948
		// (get) Token: 0x0601867E RID: 99966 RVA: 0x0023F903 File Offset: 0x0023DB03
		// (set) Token: 0x0601867F RID: 99967 RVA: 0x0023F917 File Offset: 0x0023DB17
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

		// Token: 0x17006175 RID: 24949
		// (get) Token: 0x06018680 RID: 99968 RVA: 0x0023F92C File Offset: 0x0023DB2C
		// (set) Token: 0x06018681 RID: 99969 RVA: 0x0023F940 File Offset: 0x0023DB40
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

		// Token: 0x17006176 RID: 24950
		// (get) Token: 0x06018682 RID: 99970 RVA: 0x0023F958 File Offset: 0x0023DB58
		// (set) Token: 0x06018683 RID: 99971 RVA: 0x0023F99B File Offset: 0x0023DB9B
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

		// Token: 0x17006177 RID: 24951
		// (get) Token: 0x06018684 RID: 99972 RVA: 0x0023F9AC File Offset: 0x0023DBAC
		// (set) Token: 0x06018685 RID: 99973 RVA: 0x0023F9EF File Offset: 0x0023DBEF
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

		// Token: 0x17006178 RID: 24952
		// (get) Token: 0x06018686 RID: 99974 RVA: 0x0023F9FD File Offset: 0x0023DBFD
		// (set) Token: 0x06018687 RID: 99975 RVA: 0x0023FA0D File Offset: 0x0023DC0D
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

		// Token: 0x17006179 RID: 24953
		// (get) Token: 0x06018688 RID: 99976 RVA: 0x0023FA1E File Offset: 0x0023DC1E
		// (set) Token: 0x06018689 RID: 99977 RVA: 0x0023FA2E File Offset: 0x0023DC2E
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

		// Token: 0x1700617A RID: 24954
		// (get) Token: 0x0601868A RID: 99978 RVA: 0x0023FA3F File Offset: 0x0023DC3F
		// (set) Token: 0x0601868B RID: 99979 RVA: 0x0023FA4F File Offset: 0x0023DC4F
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

		// Token: 0x1700617B RID: 24955
		// (get) Token: 0x0601868C RID: 99980 RVA: 0x0023FA60 File Offset: 0x0023DC60
		// (set) Token: 0x0601868D RID: 99981 RVA: 0x0023FA70 File Offset: 0x0023DC70
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

		// Token: 0x1700617C RID: 24956
		// (get) Token: 0x0601868E RID: 99982 RVA: 0x0023FA81 File Offset: 0x0023DC81
		// (set) Token: 0x0601868F RID: 99983 RVA: 0x0023FA91 File Offset: 0x0023DC91
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

		// Token: 0x1700617D RID: 24957
		// (get) Token: 0x06018690 RID: 99984 RVA: 0x0023FAA2 File Offset: 0x0023DCA2
		// (set) Token: 0x06018691 RID: 99985 RVA: 0x0023FAB2 File Offset: 0x0023DCB2
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

		// Token: 0x1700617E RID: 24958
		// (get) Token: 0x06018692 RID: 99986 RVA: 0x0023FAC3 File Offset: 0x0023DCC3
		// (set) Token: 0x06018693 RID: 99987 RVA: 0x0023FAD7 File Offset: 0x0023DCD7
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

		// Token: 0x1700617F RID: 24959
		// (get) Token: 0x06018694 RID: 99988 RVA: 0x0023FAEC File Offset: 0x0023DCEC
		// (set) Token: 0x06018695 RID: 99989 RVA: 0x0023FB00 File Offset: 0x0023DD00
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

		// Token: 0x17006180 RID: 24960
		// (get) Token: 0x06018696 RID: 99990 RVA: 0x0023FB15 File Offset: 0x0023DD15
		// (set) Token: 0x06018697 RID: 99991 RVA: 0x0023FB29 File Offset: 0x0023DD29
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

		// Token: 0x17006181 RID: 24961
		// (get) Token: 0x06018698 RID: 99992 RVA: 0x0023FB3E File Offset: 0x0023DD3E
		// (set) Token: 0x06018699 RID: 99993 RVA: 0x0023FB4E File Offset: 0x0023DD4E
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

		// Token: 0x17006182 RID: 24962
		// (get) Token: 0x0601869A RID: 99994 RVA: 0x0023FB5F File Offset: 0x0023DD5F
		// (set) Token: 0x0601869B RID: 99995 RVA: 0x0023FB73 File Offset: 0x0023DD73
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

		// Token: 0x17006183 RID: 24963
		// (get) Token: 0x0601869C RID: 99996 RVA: 0x0023FB88 File Offset: 0x0023DD88
		// (set) Token: 0x0601869D RID: 99997 RVA: 0x0023FBCB File Offset: 0x0023DDCB
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

		// Token: 0x17006184 RID: 24964
		// (get) Token: 0x0601869E RID: 99998 RVA: 0x0023FBEC File Offset: 0x0023DDEC
		// (set) Token: 0x0601869F RID: 99999 RVA: 0x0023FBFC File Offset: 0x0023DDFC
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

		// Token: 0x17006185 RID: 24965
		// (get) Token: 0x060186A0 RID: 100000 RVA: 0x0023FC0D File Offset: 0x0023DE0D
		// (set) Token: 0x060186A1 RID: 100001 RVA: 0x0023FC21 File Offset: 0x0023DE21
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

		// Token: 0x17006186 RID: 24966
		// (get) Token: 0x060186A2 RID: 100002 RVA: 0x0023FC36 File Offset: 0x0023DE36
		// (set) Token: 0x060186A3 RID: 100003 RVA: 0x0023FC46 File Offset: 0x0023DE46
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

		// Token: 0x17006187 RID: 24967
		// (get) Token: 0x060186A4 RID: 100004 RVA: 0x0023FC57 File Offset: 0x0023DE57
		// (set) Token: 0x060186A5 RID: 100005 RVA: 0x0023FC6B File Offset: 0x0023DE6B
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

		// Token: 0x060186A6 RID: 100006 RVA: 0x0023FC80 File Offset: 0x0023DE80
		public FKuroEnviInteractionData()
		{
		}

		// Token: 0x060186A7 RID: 100007 RVA: 0x0023FC88 File Offset: 0x0023DE88
		public FKuroEnviInteractionData(bool bInWater, bool bTraceWater, FVector HitWaterLocation, FVector HitWaterNormal, UPhysicalMaterial HitPhysicMaterial, TArray<string> HitPhysicMaterialArray, TArray<string> HitTagArray, float CapsuleToBlock, float CapsuleToWater, float WaterDepth, int WaterType, bool bHideOnBush, bool bHitAudioShrub, FName AudioShrubFirstMaterialName, UStaticMeshComponent AudioShrubStaticMeshComp, FVector TriggerHitPoint, float HitBushLUTIndex, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> HitBushActor, FKuroBushIEParameter BushIEParam, bool OverlapTriggerMesh, FVector OverlapTriggerParam0, bool bTouchBlackWave, FVector HitWaterLocationWithOffset)
		{
			this.bInWater = bInWater;
			this.bTraceWater = bTraceWater;
			this.HitWaterLocation = HitWaterLocation;
			this.HitWaterNormal = HitWaterNormal;
			this.HitPhysicMaterial = HitPhysicMaterial;
			this.HitPhysicMaterialArray = HitPhysicMaterialArray;
			this.HitTagArray = HitTagArray;
			this.CapsuleToBlock = CapsuleToBlock;
			this.CapsuleToWater = CapsuleToWater;
			this.WaterDepth = WaterDepth;
			this.WaterType = WaterType;
			this.bHideOnBush = bHideOnBush;
			this.bHitAudioShrub = bHitAudioShrub;
			this.AudioShrubFirstMaterialName = AudioShrubFirstMaterialName;
			this.AudioShrubStaticMeshComp = AudioShrubStaticMeshComp;
			this.TriggerHitPoint = TriggerHitPoint;
			this.HitBushLUTIndex = HitBushLUTIndex;
			this.HitBushActor = HitBushActor;
			this.BushIEParam = BushIEParam;
			this.OverlapTriggerMesh = OverlapTriggerMesh;
			this.OverlapTriggerParam0 = OverlapTriggerParam0;
			this.bTouchBlackWave = bTouchBlackWave;
			this.HitWaterLocationWithOffset = HitWaterLocationWithOffset;
		}

		// Token: 0x060186A8 RID: 100008 RVA: 0x0023FD50 File Offset: 0x0023DF50
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEnviInteractionData.StaticStruct();
		}

		// Token: 0x060186A9 RID: 100009 RVA: 0x0023FD5C File Offset: 0x0023DF5C
		[NullableContext(2)]
		public FKuroEnviInteractionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060186AA RID: 100010 RVA: 0x0023FD66 File Offset: 0x0023DF66
		public FKuroEnviInteractionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060186AB RID: 100011 RVA: 0x0023FD71 File Offset: 0x0023DF71
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEnviInteractionData(Pointer, false, true);
		}

		// Token: 0x060186AC RID: 100012 RVA: 0x0023FD7B File Offset: 0x0023DF7B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEnviInteractionData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D30A RID: 54026
		public const string __ObjectPath = "/Script/KuroInteractionEffect.KuroEnviInteractionData";

		// Token: 0x0400D30B RID: 54027
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D30C RID: 54028
		internal static int __PropertyOffset_bInWater;

		// Token: 0x0400D30D RID: 54029
		internal static int __PropertyOffset_bTraceWater;

		// Token: 0x0400D30E RID: 54030
		internal static int __PropertyOffset_HitWaterLocation;

		// Token: 0x0400D30F RID: 54031
		internal static int __PropertyOffset_HitWaterNormal;

		// Token: 0x0400D310 RID: 54032
		internal static int __PropertyOffset_HitPhysicMaterial;

		// Token: 0x0400D311 RID: 54033
		internal static int __PropertyOffset_HitPhysicMaterialArray;

		// Token: 0x0400D312 RID: 54034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HitPhysicMaterialArray;

		// Token: 0x0400D313 RID: 54035
		internal static int __PropertyOffset_HitTagArray;

		// Token: 0x0400D314 RID: 54036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HitTagArray;

		// Token: 0x0400D315 RID: 54037
		internal static int __PropertyOffset_CapsuleToBlock;

		// Token: 0x0400D316 RID: 54038
		internal static int __PropertyOffset_CapsuleToWater;

		// Token: 0x0400D317 RID: 54039
		internal static int __PropertyOffset_WaterDepth;

		// Token: 0x0400D318 RID: 54040
		internal static int __PropertyOffset_WaterType;

		// Token: 0x0400D319 RID: 54041
		internal static int __PropertyOffset_bHideOnBush;

		// Token: 0x0400D31A RID: 54042
		internal static int __PropertyOffset_bHitAudioShrub;

		// Token: 0x0400D31B RID: 54043
		internal static int __PropertyOffset_AudioShrubFirstMaterialName;

		// Token: 0x0400D31C RID: 54044
		internal static int __PropertyOffset_AudioShrubStaticMeshComp;

		// Token: 0x0400D31D RID: 54045
		internal static int __PropertyOffset_TriggerHitPoint;

		// Token: 0x0400D31E RID: 54046
		internal static int __PropertyOffset_HitBushLUTIndex;

		// Token: 0x0400D31F RID: 54047
		internal static int __PropertyOffset_HitBushActor;

		// Token: 0x0400D320 RID: 54048
		internal static int __PropertyOffset_BushIEParam;

		// Token: 0x0400D321 RID: 54049
		[Nullable(2)]
		private FKuroBushIEParameter _BushIEParam;

		// Token: 0x0400D322 RID: 54050
		internal static int __PropertyOffset_OverlapTriggerMesh;

		// Token: 0x0400D323 RID: 54051
		internal static int __PropertyOffset_OverlapTriggerParam0;

		// Token: 0x0400D324 RID: 54052
		internal static int __PropertyOffset_bTouchBlackWave;

		// Token: 0x0400D325 RID: 54053
		internal static int __PropertyOffset_HitWaterLocationWithOffset;
	}
}
