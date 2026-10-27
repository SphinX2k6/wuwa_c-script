using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F74 RID: 8052
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeGrassType")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class ULandscapeGrassType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E8C8 RID: 125128 RVA: 0x002D6796 File Offset: 0x002D4996
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeGrassType._ClassPtr;
		}

		// Token: 0x0601E8C9 RID: 125129 RVA: 0x002D67A4 File Offset: 0x002D49A4
		public ULandscapeGrassType() : this(BuiltinUtils.AllocNativeUObject(ULandscapeGrassType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E8CA RID: 125130 RVA: 0x002D67CC File Offset: 0x002D49CC
		public ULandscapeGrassType(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeGrassType.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007987 RID: 31111
		// (get) Token: 0x0601E8CB RID: 125131 RVA: 0x002D6800 File Offset: 0x002D4A00
		// (set) Token: 0x0601E8CC RID: 125132 RVA: 0x002D6839 File Offset: 0x002D4A39
		public TArray<FGrassVariety> GrassVarieties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGrassVariety> result;
				if ((result = this._GrassVarieties) == null)
				{
					result = (this._GrassVarieties = new TArray<FGrassVariety>(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_GrassVarieties, this));
				}
				return result;
			}
			set
			{
				this.GrassVarieties.CopyAssign(value);
			}
		}

		// Token: 0x17007988 RID: 31112
		// (get) Token: 0x0601E8CD RID: 125133 RVA: 0x002D6847 File Offset: 0x002D4A47
		// (set) Token: 0x0601E8CE RID: 125134 RVA: 0x002D6860 File Offset: 0x002D4A60
		public unsafe bool bEnableDensityScaling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_bEnableDensityScaling) & ULandscapeGrassType.__PropertyMask_bEnableDensityScaling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_bEnableDensityScaling) = ((*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_bEnableDensityScaling) & ~ULandscapeGrassType.__PropertyMask_bEnableDensityScaling) | (value ? ULandscapeGrassType.__PropertyMask_bEnableDensityScaling : 0));
			}
		}

		// Token: 0x17007989 RID: 31113
		// (get) Token: 0x0601E8CF RID: 125135 RVA: 0x002D6890 File Offset: 0x002D4A90
		// (set) Token: 0x0601E8D0 RID: 125136 RVA: 0x002D68A4 File Offset: 0x002D4AA4
		[Nullable(2)]
		public unsafe UStaticMesh GrassMesh_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeGrassType.__PropertyOffset_GrassMesh_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeGrassType.__PropertyOffset_GrassMesh_DEPRECATED, value);
			}
		}

		// Token: 0x1700798A RID: 31114
		// (get) Token: 0x0601E8D1 RID: 125137 RVA: 0x002D68B9 File Offset: 0x002D4AB9
		// (set) Token: 0x0601E8D2 RID: 125138 RVA: 0x002D68C9 File Offset: 0x002D4AC9
		public unsafe float GrassDensity_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_GrassDensity_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_GrassDensity_DEPRECATED) = value;
			}
		}

		// Token: 0x1700798B RID: 31115
		// (get) Token: 0x0601E8D3 RID: 125139 RVA: 0x002D68DA File Offset: 0x002D4ADA
		// (set) Token: 0x0601E8D4 RID: 125140 RVA: 0x002D68EA File Offset: 0x002D4AEA
		public unsafe float PlacementJitter_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_PlacementJitter_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_PlacementJitter_DEPRECATED) = value;
			}
		}

		// Token: 0x1700798C RID: 31116
		// (get) Token: 0x0601E8D5 RID: 125141 RVA: 0x002D68FB File Offset: 0x002D4AFB
		// (set) Token: 0x0601E8D6 RID: 125142 RVA: 0x002D690B File Offset: 0x002D4B0B
		public unsafe int StartCullDistance_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_StartCullDistance_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_StartCullDistance_DEPRECATED) = value;
			}
		}

		// Token: 0x1700798D RID: 31117
		// (get) Token: 0x0601E8D7 RID: 125143 RVA: 0x002D691C File Offset: 0x002D4B1C
		// (set) Token: 0x0601E8D8 RID: 125144 RVA: 0x002D692C File Offset: 0x002D4B2C
		public unsafe int EndCullDistance_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_EndCullDistance_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_EndCullDistance_DEPRECATED) = value;
			}
		}

		// Token: 0x1700798E RID: 31118
		// (get) Token: 0x0601E8D9 RID: 125145 RVA: 0x002D693D File Offset: 0x002D4B3D
		// (set) Token: 0x0601E8DA RID: 125146 RVA: 0x002D694D File Offset: 0x002D4B4D
		public unsafe bool RandomRotation_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_RandomRotation_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_RandomRotation_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700798F RID: 31119
		// (get) Token: 0x0601E8DB RID: 125147 RVA: 0x002D695E File Offset: 0x002D4B5E
		// (set) Token: 0x0601E8DC RID: 125148 RVA: 0x002D696E File Offset: 0x002D4B6E
		public unsafe bool AlignToSurface_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_AlignToSurface_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeGrassType.__PropertyOffset_AlignToSurface_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E8DD RID: 125149 RVA: 0x002D697F File Offset: 0x002D4B7F
		static ULandscapeGrassType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeGrassType");
		}

		// Token: 0x0601E8DE RID: 125150 RVA: 0x002D698D File Offset: 0x002D4B8D
		protected ULandscapeGrassType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010825 RID: 67621
		public new const string __ObjectPath = "/Script/Landscape.LandscapeGrassType";

		// Token: 0x04010826 RID: 67622
		private static IntPtr _ClassPtr;

		// Token: 0x04010827 RID: 67623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010828 RID: 67624
		internal static int __PropertyOffset_GrassVarieties;

		// Token: 0x04010829 RID: 67625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGrassVariety> _GrassVarieties;

		// Token: 0x0401082A RID: 67626
		internal static int __PropertyOffset_bEnableDensityScaling;

		// Token: 0x0401082B RID: 67627
		internal static byte __PropertyMask_bEnableDensityScaling;

		// Token: 0x0401082C RID: 67628
		internal static int __PropertyOffset_GrassMesh_DEPRECATED;

		// Token: 0x0401082D RID: 67629
		internal static int __PropertyOffset_GrassDensity_DEPRECATED;

		// Token: 0x0401082E RID: 67630
		internal static int __PropertyOffset_PlacementJitter_DEPRECATED;

		// Token: 0x0401082F RID: 67631
		internal static int __PropertyOffset_StartCullDistance_DEPRECATED;

		// Token: 0x04010830 RID: 67632
		internal static int __PropertyOffset_EndCullDistance_DEPRECATED;

		// Token: 0x04010831 RID: 67633
		internal static int __PropertyOffset_RandomRotation_DEPRECATED;

		// Token: 0x04010832 RID: 67634
		internal static int __PropertyOffset_AlignToSurface_DEPRECATED;
	}
}
