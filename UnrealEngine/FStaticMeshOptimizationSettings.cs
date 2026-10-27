using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001196 RID: 4502
	[UnrealObjectPath("/Script/Engine.StaticMeshOptimizationSettings")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FStaticMeshOptimizationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010954 RID: 67924 RVA: 0x00185A90 File Offset: 0x00183C90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMeshOptimizationSettings._ScriptStructPtr != 0) ? FStaticMeshOptimizationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMeshOptimizationSettings", ref FStaticMeshOptimizationSettings._ScriptStructPtr);
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x06010955 RID: 67925 RVA: 0x00185AB4 File Offset: 0x00183CB4
		// (set) Token: 0x06010956 RID: 67926 RVA: 0x00185AC8 File Offset: 0x00183CC8
		public unsafe TEnumAsByte<EOptimizationType> ReductionMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_ReductionMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_ReductionMethod) = value;
			}
		}

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x06010957 RID: 67927 RVA: 0x00185ADD File Offset: 0x00183CDD
		// (set) Token: 0x06010958 RID: 67928 RVA: 0x00185AED File Offset: 0x00183CED
		public unsafe float NumOfTrianglesPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_NumOfTrianglesPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_NumOfTrianglesPercentage) = value;
			}
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x06010959 RID: 67929 RVA: 0x00185AFE File Offset: 0x00183CFE
		// (set) Token: 0x0601095A RID: 67930 RVA: 0x00185B0E File Offset: 0x00183D0E
		public unsafe float MaxDeviationPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_MaxDeviationPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_MaxDeviationPercentage) = value;
			}
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x0601095B RID: 67931 RVA: 0x00185B1F File Offset: 0x00183D1F
		// (set) Token: 0x0601095C RID: 67932 RVA: 0x00185B2F File Offset: 0x00183D2F
		public unsafe float WeldingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_WeldingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_WeldingThreshold) = value;
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x0601095D RID: 67933 RVA: 0x00185B40 File Offset: 0x00183D40
		// (set) Token: 0x0601095E RID: 67934 RVA: 0x00185B50 File Offset: 0x00183D50
		public unsafe bool bRecalcNormals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_bRecalcNormals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_bRecalcNormals) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x0601095F RID: 67935 RVA: 0x00185B61 File Offset: 0x00183D61
		// (set) Token: 0x06010960 RID: 67936 RVA: 0x00185B71 File Offset: 0x00183D71
		public unsafe float NormalsThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_NormalsThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_NormalsThreshold) = value;
			}
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x06010961 RID: 67937 RVA: 0x00185B82 File Offset: 0x00183D82
		// (set) Token: 0x06010962 RID: 67938 RVA: 0x00185B92 File Offset: 0x00183D92
		public unsafe byte SilhouetteImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_SilhouetteImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_SilhouetteImportance) = value;
			}
		}

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x06010963 RID: 67939 RVA: 0x00185BA3 File Offset: 0x00183DA3
		// (set) Token: 0x06010964 RID: 67940 RVA: 0x00185BB3 File Offset: 0x00183DB3
		public unsafe byte TextureImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_TextureImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_TextureImportance) = value;
			}
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x06010965 RID: 67941 RVA: 0x00185BC4 File Offset: 0x00183DC4
		// (set) Token: 0x06010966 RID: 67942 RVA: 0x00185BD4 File Offset: 0x00183DD4
		public unsafe byte ShadingImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_ShadingImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshOptimizationSettings.__PropertyOffset_ShadingImportance) = value;
			}
		}

		// Token: 0x06010967 RID: 67943 RVA: 0x00185BE5 File Offset: 0x00183DE5
		public FStaticMeshOptimizationSettings()
		{
		}

		// Token: 0x06010968 RID: 67944 RVA: 0x00185BF0 File Offset: 0x00183DF0
		public FStaticMeshOptimizationSettings(TEnumAsByte<EOptimizationType> ReductionMethod, float NumOfTrianglesPercentage, float MaxDeviationPercentage, float WeldingThreshold, bool bRecalcNormals, float NormalsThreshold, byte SilhouetteImportance, byte TextureImportance, byte ShadingImportance)
		{
			this.ReductionMethod = ReductionMethod;
			this.NumOfTrianglesPercentage = NumOfTrianglesPercentage;
			this.MaxDeviationPercentage = MaxDeviationPercentage;
			this.WeldingThreshold = WeldingThreshold;
			this.bRecalcNormals = bRecalcNormals;
			this.NormalsThreshold = NormalsThreshold;
			this.SilhouetteImportance = SilhouetteImportance;
			this.TextureImportance = TextureImportance;
			this.ShadingImportance = ShadingImportance;
		}

		// Token: 0x06010969 RID: 67945 RVA: 0x00185C48 File Offset: 0x00183E48
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMeshOptimizationSettings.StaticStruct();
		}

		// Token: 0x0601096A RID: 67946 RVA: 0x00185C54 File Offset: 0x00183E54
		[NullableContext(2)]
		public FStaticMeshOptimizationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601096B RID: 67947 RVA: 0x00185C5E File Offset: 0x00183E5E
		public FStaticMeshOptimizationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601096C RID: 67948 RVA: 0x00185C69 File Offset: 0x00183E69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMeshOptimizationSettings(Pointer, false, true);
		}

		// Token: 0x0601096D RID: 67949 RVA: 0x00185C73 File Offset: 0x00183E73
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMeshOptimizationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008DF0 RID: 36336
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StaticMeshOptimizationSettings";

		// Token: 0x04008DF1 RID: 36337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008DF2 RID: 36338
		internal static int __PropertyOffset_ReductionMethod;

		// Token: 0x04008DF3 RID: 36339
		internal static int __PropertyOffset_NumOfTrianglesPercentage;

		// Token: 0x04008DF4 RID: 36340
		internal static int __PropertyOffset_MaxDeviationPercentage;

		// Token: 0x04008DF5 RID: 36341
		internal static int __PropertyOffset_WeldingThreshold;

		// Token: 0x04008DF6 RID: 36342
		internal static int __PropertyOffset_bRecalcNormals;

		// Token: 0x04008DF7 RID: 36343
		internal static int __PropertyOffset_NormalsThreshold;

		// Token: 0x04008DF8 RID: 36344
		internal static int __PropertyOffset_SilhouetteImportance;

		// Token: 0x04008DF9 RID: 36345
		internal static int __PropertyOffset_TextureImportance;

		// Token: 0x04008DFA RID: 36346
		internal static int __PropertyOffset_ShadingImportance;
	}
}
