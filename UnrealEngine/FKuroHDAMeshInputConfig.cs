using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001508 RID: 5384
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.KuroHDAMeshInputConfig")]
	[UnrealStructLayout(14, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 14)]
	public class FKuroHDAMeshInputConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013953 RID: 80211 RVA: 0x001CC40C File Offset: 0x001CA60C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHDAMeshInputConfig._ScriptStructPtr != 0) ? FKuroHDAMeshInputConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.KuroHDAMeshInputConfig", ref FKuroHDAMeshInputConfig._ScriptStructPtr);
		}

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x06013954 RID: 80212 RVA: 0x001CC430 File Offset: 0x001CA630
		// (set) Token: 0x06013955 RID: 80213 RVA: 0x001CC440 File Offset: 0x001CA640
		public unsafe bool CombineMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_CombineMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_CombineMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x06013956 RID: 80214 RVA: 0x001CC451 File Offset: 0x001CA651
		// (set) Token: 0x06013957 RID: 80215 RVA: 0x001CC461 File Offset: 0x001CA661
		public unsafe bool UVS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_UVS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_UVS) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x06013958 RID: 80216 RVA: 0x001CC472 File Offset: 0x001CA672
		// (set) Token: 0x06013959 RID: 80217 RVA: 0x001CC482 File Offset: 0x001CA682
		public unsafe bool Normals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Normals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Normals) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x0601395A RID: 80218 RVA: 0x001CC493 File Offset: 0x001CA693
		// (set) Token: 0x0601395B RID: 80219 RVA: 0x001CC4A3 File Offset: 0x001CA6A3
		public unsafe bool Tangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Tangent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Tangent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x0601395C RID: 80220 RVA: 0x001CC4B4 File Offset: 0x001CA6B4
		// (set) Token: 0x0601395D RID: 80221 RVA: 0x001CC4C4 File Offset: 0x001CA6C4
		public unsafe bool Binomal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Binomal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Binomal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x0601395E RID: 80222 RVA: 0x001CC4D5 File Offset: 0x001CA6D5
		// (set) Token: 0x0601395F RID: 80223 RVA: 0x001CC4E5 File Offset: 0x001CA6E5
		public unsafe bool VertexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_VertexColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_VertexColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x06013960 RID: 80224 RVA: 0x001CC4F6 File Offset: 0x001CA6F6
		// (set) Token: 0x06013961 RID: 80225 RVA: 0x001CC506 File Offset: 0x001CA706
		public unsafe bool SmoothingMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_SmoothingMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_SmoothingMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x06013962 RID: 80226 RVA: 0x001CC517 File Offset: 0x001CA717
		// (set) Token: 0x06013963 RID: 80227 RVA: 0x001CC527 File Offset: 0x001CA727
		public unsafe bool Material
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Material) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Material) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB3 RID: 19635
		// (get) Token: 0x06013964 RID: 80228 RVA: 0x001CC538 File Offset: 0x001CA738
		// (set) Token: 0x06013965 RID: 80229 RVA: 0x001CC548 File Offset: 0x001CA748
		public unsafe bool Lightmap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Lightmap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Lightmap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB4 RID: 19636
		// (get) Token: 0x06013966 RID: 80230 RVA: 0x001CC559 File Offset: 0x001CA759
		// (set) Token: 0x06013967 RID: 80231 RVA: 0x001CC569 File Offset: 0x001CA769
		public unsafe bool MeshName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_MeshName) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_MeshName) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB5 RID: 19637
		// (get) Token: 0x06013968 RID: 80232 RVA: 0x001CC57A File Offset: 0x001CA77A
		// (set) Token: 0x06013969 RID: 80233 RVA: 0x001CC58A File Offset: 0x001CA78A
		public unsafe bool SourceFile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_SourceFile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_SourceFile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB6 RID: 19638
		// (get) Token: 0x0601396A RID: 80234 RVA: 0x001CC59B File Offset: 0x001CA79B
		// (set) Token: 0x0601396B RID: 80235 RVA: 0x001CC5AB File Offset: 0x001CA7AB
		public unsafe bool Tags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Tags) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_Tags) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x0601396C RID: 80236 RVA: 0x001CC5BC File Offset: 0x001CA7BC
		// (set) Token: 0x0601396D RID: 80237 RVA: 0x001CC5CC File Offset: 0x001CA7CC
		public unsafe bool KuroAssetTags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_KuroAssetTags) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHDAMeshInputConfig.__PropertyOffset_KuroAssetTags) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601396E RID: 80238 RVA: 0x001CC5DD File Offset: 0x001CA7DD
		public FKuroHDAMeshInputConfig()
		{
		}

		// Token: 0x0601396F RID: 80239 RVA: 0x001CC5E8 File Offset: 0x001CA7E8
		public FKuroHDAMeshInputConfig(bool CombineMesh, bool UVS, bool Normals, bool Tangent, bool Binomal, bool VertexColor, bool SmoothingMask, bool Material, bool Lightmap, bool MeshName, bool SourceFile, bool Tags, bool KuroAssetTags)
		{
			this.CombineMesh = CombineMesh;
			this.UVS = UVS;
			this.Normals = Normals;
			this.Tangent = Tangent;
			this.Binomal = Binomal;
			this.VertexColor = VertexColor;
			this.SmoothingMask = SmoothingMask;
			this.Material = Material;
			this.Lightmap = Lightmap;
			this.MeshName = MeshName;
			this.SourceFile = SourceFile;
			this.Tags = Tags;
			this.KuroAssetTags = KuroAssetTags;
		}

		// Token: 0x06013970 RID: 80240 RVA: 0x001CC660 File Offset: 0x001CA860
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHDAMeshInputConfig.StaticStruct();
		}

		// Token: 0x06013971 RID: 80241 RVA: 0x001CC66C File Offset: 0x001CA86C
		[NullableContext(2)]
		public FKuroHDAMeshInputConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013972 RID: 80242 RVA: 0x001CC676 File Offset: 0x001CA876
		public FKuroHDAMeshInputConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013973 RID: 80243 RVA: 0x001CC681 File Offset: 0x001CA881
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHDAMeshInputConfig(Pointer, false, true);
		}

		// Token: 0x06013974 RID: 80244 RVA: 0x001CC68B File Offset: 0x001CA88B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHDAMeshInputConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400A940 RID: 43328
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.KuroHDAMeshInputConfig";

		// Token: 0x0400A941 RID: 43329
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A942 RID: 43330
		internal static int __PropertyOffset_CombineMesh;

		// Token: 0x0400A943 RID: 43331
		internal static int __PropertyOffset_UVS;

		// Token: 0x0400A944 RID: 43332
		internal static int __PropertyOffset_Normals;

		// Token: 0x0400A945 RID: 43333
		internal static int __PropertyOffset_Tangent;

		// Token: 0x0400A946 RID: 43334
		internal static int __PropertyOffset_Binomal;

		// Token: 0x0400A947 RID: 43335
		internal static int __PropertyOffset_VertexColor;

		// Token: 0x0400A948 RID: 43336
		internal static int __PropertyOffset_SmoothingMask;

		// Token: 0x0400A949 RID: 43337
		internal static int __PropertyOffset_Material;

		// Token: 0x0400A94A RID: 43338
		internal static int __PropertyOffset_Lightmap;

		// Token: 0x0400A94B RID: 43339
		internal static int __PropertyOffset_MeshName;

		// Token: 0x0400A94C RID: 43340
		internal static int __PropertyOffset_SourceFile;

		// Token: 0x0400A94D RID: 43341
		internal static int __PropertyOffset_Tags;

		// Token: 0x0400A94E RID: 43342
		internal static int __PropertyOffset_KuroAssetTags;
	}
}
