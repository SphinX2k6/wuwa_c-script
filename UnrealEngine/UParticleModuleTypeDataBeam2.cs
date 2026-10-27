using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FAE RID: 4014
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleTypeDataBeam2")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UParticleModuleTypeDataBeam2 : UParticleModuleTypeDataBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D7E3 RID: 55267 RVA: 0x0013E5B1 File Offset: 0x0013C7B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTypeDataBeam2._ClassPtr;
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x0013E5C0 File Offset: 0x0013C7C0
		public UParticleModuleTypeDataBeam2() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataBeam2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x0013E5E8 File Offset: 0x0013C7E8
		public UParticleModuleTypeDataBeam2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataBeam2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600D7E6 RID: 55270 RVA: 0x0013E61B File Offset: 0x0013C81B
		// (set) Token: 0x0600D7E7 RID: 55271 RVA: 0x0013E62F File Offset: 0x0013C82F
		[Nullable(0)]
		public unsafe TEnumAsByte<EBeam2Method> BeamMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_BeamMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_BeamMethod) = value;
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600D7E8 RID: 55272 RVA: 0x0013E644 File Offset: 0x0013C844
		// (set) Token: 0x0600D7E9 RID: 55273 RVA: 0x0013E654 File Offset: 0x0013C854
		public unsafe int TextureTile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TextureTile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TextureTile) = value;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600D7EA RID: 55274 RVA: 0x0013E665 File Offset: 0x0013C865
		// (set) Token: 0x0600D7EB RID: 55275 RVA: 0x0013E675 File Offset: 0x0013C875
		public unsafe float TextureTileDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TextureTileDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TextureTileDistance) = value;
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600D7EC RID: 55276 RVA: 0x0013E686 File Offset: 0x0013C886
		// (set) Token: 0x0600D7ED RID: 55277 RVA: 0x0013E696 File Offset: 0x0013C896
		public unsafe int Sheets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_Sheets);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_Sheets) = value;
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600D7EE RID: 55278 RVA: 0x0013E6A7 File Offset: 0x0013C8A7
		// (set) Token: 0x0600D7EF RID: 55279 RVA: 0x0013E6B7 File Offset: 0x0013C8B7
		public unsafe int MaxBeamCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_MaxBeamCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_MaxBeamCount) = value;
			}
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600D7F0 RID: 55280 RVA: 0x0013E6C8 File Offset: 0x0013C8C8
		// (set) Token: 0x0600D7F1 RID: 55281 RVA: 0x0013E6D8 File Offset: 0x0013C8D8
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600D7F2 RID: 55282 RVA: 0x0013E6E9 File Offset: 0x0013C8E9
		// (set) Token: 0x0600D7F3 RID: 55283 RVA: 0x0013E6F9 File Offset: 0x0013C8F9
		public unsafe int InterpolationPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_InterpolationPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_InterpolationPoints) = value;
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x0013E70A File Offset: 0x0013C90A
		// (set) Token: 0x0600D7F5 RID: 55285 RVA: 0x0013E723 File Offset: 0x0013C923
		public unsafe bool bAlwaysOn
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_bAlwaysOn) & UParticleModuleTypeDataBeam2.__PropertyMask_bAlwaysOn) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_bAlwaysOn) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_bAlwaysOn) & ~UParticleModuleTypeDataBeam2.__PropertyMask_bAlwaysOn) | (value ? UParticleModuleTypeDataBeam2.__PropertyMask_bAlwaysOn : 0));
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600D7F6 RID: 55286 RVA: 0x0013E753 File Offset: 0x0013C953
		// (set) Token: 0x0600D7F7 RID: 55287 RVA: 0x0013E763 File Offset: 0x0013C963
		public unsafe int UpVectorStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_UpVectorStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_UpVectorStepSize) = value;
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x0013E774 File Offset: 0x0013C974
		// (set) Token: 0x0600D7F9 RID: 55289 RVA: 0x0013E788 File Offset: 0x0013C988
		public unsafe FName BranchParentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_BranchParentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_BranchParentName) = value;
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600D7FA RID: 55290 RVA: 0x0013E7A0 File Offset: 0x0013C9A0
		// (set) Token: 0x0600D7FB RID: 55291 RVA: 0x0013E7D9 File Offset: 0x0013C9D9
		public FRawDistributionFloat Distance
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Distance) == null)
				{
					result = (this._Distance = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_Distance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_Distance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x0013E7FA File Offset: 0x0013C9FA
		// (set) Token: 0x0600D7FD RID: 55293 RVA: 0x0013E80E File Offset: 0x0013CA0E
		[Nullable(0)]
		public unsafe TEnumAsByte<EBeamTaperMethod> TaperMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TaperMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TaperMethod) = value;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x0013E824 File Offset: 0x0013CA24
		// (set) Token: 0x0600D7FF RID: 55295 RVA: 0x0013E85D File Offset: 0x0013CA5D
		public FRawDistributionFloat TaperFactor
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._TaperFactor) == null)
				{
					result = (this._TaperFactor = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TaperFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TaperFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600D800 RID: 55296 RVA: 0x0013E880 File Offset: 0x0013CA80
		// (set) Token: 0x0600D801 RID: 55297 RVA: 0x0013E8B9 File Offset: 0x0013CAB9
		public FRawDistributionFloat TaperScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._TaperScale) == null)
				{
					result = (this._TaperScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TaperScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_TaperScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600D802 RID: 55298 RVA: 0x0013E8DA File Offset: 0x0013CADA
		// (set) Token: 0x0600D803 RID: 55299 RVA: 0x0013E8F3 File Offset: 0x0013CAF3
		public unsafe bool RenderGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderGeometry) & UParticleModuleTypeDataBeam2.__PropertyMask_RenderGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderGeometry) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderGeometry) & ~UParticleModuleTypeDataBeam2.__PropertyMask_RenderGeometry) | (value ? UParticleModuleTypeDataBeam2.__PropertyMask_RenderGeometry : 0));
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600D804 RID: 55300 RVA: 0x0013E923 File Offset: 0x0013CB23
		// (set) Token: 0x0600D805 RID: 55301 RVA: 0x0013E93C File Offset: 0x0013CB3C
		public unsafe bool RenderDirectLine
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderDirectLine) & UParticleModuleTypeDataBeam2.__PropertyMask_RenderDirectLine) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderDirectLine) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderDirectLine) & ~UParticleModuleTypeDataBeam2.__PropertyMask_RenderDirectLine) | (value ? UParticleModuleTypeDataBeam2.__PropertyMask_RenderDirectLine : 0));
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600D806 RID: 55302 RVA: 0x0013E96C File Offset: 0x0013CB6C
		// (set) Token: 0x0600D807 RID: 55303 RVA: 0x0013E985 File Offset: 0x0013CB85
		public unsafe bool RenderLines
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderLines) & UParticleModuleTypeDataBeam2.__PropertyMask_RenderLines) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderLines) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderLines) & ~UParticleModuleTypeDataBeam2.__PropertyMask_RenderLines) | (value ? UParticleModuleTypeDataBeam2.__PropertyMask_RenderLines : 0));
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600D808 RID: 55304 RVA: 0x0013E9B5 File Offset: 0x0013CBB5
		// (set) Token: 0x0600D809 RID: 55305 RVA: 0x0013E9CE File Offset: 0x0013CBCE
		public unsafe bool RenderTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderTessellation) & UParticleModuleTypeDataBeam2.__PropertyMask_RenderTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderTessellation) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataBeam2.__PropertyOffset_RenderTessellation) & ~UParticleModuleTypeDataBeam2.__PropertyMask_RenderTessellation) | (value ? UParticleModuleTypeDataBeam2.__PropertyMask_RenderTessellation : 0));
			}
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x0013E9FE File Offset: 0x0013CBFE
		static UParticleModuleTypeDataBeam2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTypeDataBeam2");
		}

		// Token: 0x0600D80B RID: 55307 RVA: 0x0013EA0C File Offset: 0x0013CC0C
		protected UParticleModuleTypeDataBeam2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074E0 RID: 29920
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTypeDataBeam2";

		// Token: 0x040074E1 RID: 29921
		private static IntPtr _ClassPtr;

		// Token: 0x040074E2 RID: 29922
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040074E3 RID: 29923
		internal static int __PropertyOffset_BeamMethod;

		// Token: 0x040074E4 RID: 29924
		internal static int __PropertyOffset_TextureTile;

		// Token: 0x040074E5 RID: 29925
		internal static int __PropertyOffset_TextureTileDistance;

		// Token: 0x040074E6 RID: 29926
		internal static int __PropertyOffset_Sheets;

		// Token: 0x040074E7 RID: 29927
		internal static int __PropertyOffset_MaxBeamCount;

		// Token: 0x040074E8 RID: 29928
		internal static int __PropertyOffset_Speed;

		// Token: 0x040074E9 RID: 29929
		internal static int __PropertyOffset_InterpolationPoints;

		// Token: 0x040074EA RID: 29930
		internal static int __PropertyOffset_bAlwaysOn;

		// Token: 0x040074EB RID: 29931
		internal static byte __PropertyMask_bAlwaysOn;

		// Token: 0x040074EC RID: 29932
		internal static int __PropertyOffset_UpVectorStepSize;

		// Token: 0x040074ED RID: 29933
		internal static int __PropertyOffset_BranchParentName;

		// Token: 0x040074EE RID: 29934
		internal static int __PropertyOffset_Distance;

		// Token: 0x040074EF RID: 29935
		[Nullable(2)]
		private FRawDistributionFloat _Distance;

		// Token: 0x040074F0 RID: 29936
		internal static int __PropertyOffset_TaperMethod;

		// Token: 0x040074F1 RID: 29937
		internal static int __PropertyOffset_TaperFactor;

		// Token: 0x040074F2 RID: 29938
		[Nullable(2)]
		private FRawDistributionFloat _TaperFactor;

		// Token: 0x040074F3 RID: 29939
		internal static int __PropertyOffset_TaperScale;

		// Token: 0x040074F4 RID: 29940
		[Nullable(2)]
		private FRawDistributionFloat _TaperScale;

		// Token: 0x040074F5 RID: 29941
		internal static int __PropertyOffset_RenderGeometry;

		// Token: 0x040074F6 RID: 29942
		internal static byte __PropertyMask_RenderGeometry;

		// Token: 0x040074F7 RID: 29943
		internal static int __PropertyOffset_RenderDirectLine;

		// Token: 0x040074F8 RID: 29944
		internal static byte __PropertyMask_RenderDirectLine;

		// Token: 0x040074F9 RID: 29945
		internal static int __PropertyOffset_RenderLines;

		// Token: 0x040074FA RID: 29946
		internal static byte __PropertyMask_RenderLines;

		// Token: 0x040074FB RID: 29947
		internal static int __PropertyOffset_RenderTessellation;

		// Token: 0x040074FC RID: 29948
		internal static byte __PropertyMask_RenderTessellation;
	}
}
