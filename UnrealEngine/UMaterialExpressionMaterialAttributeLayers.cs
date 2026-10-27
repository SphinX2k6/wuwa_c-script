using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF4 RID: 3572
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMaterialAttributeLayers")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UMaterialExpressionMaterialAttributeLayers : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C142 RID: 49474 RVA: 0x001164E1 File Offset: 0x001146E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMaterialAttributeLayers._ClassPtr;
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x001164F0 File Offset: 0x001146F0
		public UMaterialExpressionMaterialAttributeLayers() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialAttributeLayers.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C144 RID: 49476 RVA: 0x00116518 File Offset: 0x00114718
		public UMaterialExpressionMaterialAttributeLayers(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialAttributeLayers.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0600C145 RID: 49477 RVA: 0x0011654B File Offset: 0x0011474B
		// (set) Token: 0x0600C146 RID: 49478 RVA: 0x0011655F File Offset: 0x0011475F
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x0600C147 RID: 49479 RVA: 0x00116574 File Offset: 0x00114774
		// (set) Token: 0x0600C148 RID: 49480 RVA: 0x00116588 File Offset: 0x00114788
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x0600C149 RID: 49481 RVA: 0x001165A0 File Offset: 0x001147A0
		// (set) Token: 0x0600C14A RID: 49482 RVA: 0x001165D9 File Offset: 0x001147D9
		public FMaterialAttributesInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialAttributesInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FMaterialAttributesInput(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialAttributesInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x0600C14B RID: 49483 RVA: 0x001165FC File Offset: 0x001147FC
		// (set) Token: 0x0600C14C RID: 49484 RVA: 0x00116635 File Offset: 0x00114835
		public FMaterialLayersFunctions DefaultLayers
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialLayersFunctions result;
				if ((result = this._DefaultLayers) == null)
				{
					result = (this._DefaultLayers = new FMaterialLayersFunctions(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_DefaultLayers, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialLayersFunctions.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_DefaultLayers, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x0600C14D RID: 49485 RVA: 0x00116658 File Offset: 0x00114858
		// (set) Token: 0x0600C14E RID: 49486 RVA: 0x00116691 File Offset: 0x00114891
		public TArray<UMaterialExpressionMaterialFunctionCall> LayerCallers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialExpressionMaterialFunctionCall> result;
				if ((result = this._LayerCallers) == null)
				{
					result = (this._LayerCallers = new TArray<UMaterialExpressionMaterialFunctionCall>(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_LayerCallers, this));
				}
				return result;
			}
			set
			{
				this.LayerCallers.CopyAssign(value);
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x0600C14F RID: 49487 RVA: 0x0011669F File Offset: 0x0011489F
		// (set) Token: 0x0600C150 RID: 49488 RVA: 0x001166AF File Offset: 0x001148AF
		public unsafe int NumActiveLayerCallers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_NumActiveLayerCallers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_NumActiveLayerCallers) = value;
			}
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x0600C151 RID: 49489 RVA: 0x001166C0 File Offset: 0x001148C0
		// (set) Token: 0x0600C152 RID: 49490 RVA: 0x001166F9 File Offset: 0x001148F9
		public TArray<UMaterialExpressionMaterialFunctionCall> BlendCallers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialExpressionMaterialFunctionCall> result;
				if ((result = this._BlendCallers) == null)
				{
					result = (this._BlendCallers = new TArray<UMaterialExpressionMaterialFunctionCall>(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_BlendCallers, this));
				}
				return result;
			}
			set
			{
				this.BlendCallers.CopyAssign(value);
			}
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x0600C153 RID: 49491 RVA: 0x00116707 File Offset: 0x00114907
		// (set) Token: 0x0600C154 RID: 49492 RVA: 0x00116717 File Offset: 0x00114917
		public unsafe int NumActiveBlendCallers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_NumActiveBlendCallers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_NumActiveBlendCallers) = value;
			}
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x0600C155 RID: 49493 RVA: 0x00116728 File Offset: 0x00114928
		// (set) Token: 0x0600C156 RID: 49494 RVA: 0x00116738 File Offset: 0x00114938
		public unsafe bool bIsLayerGraphBuilt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_bIsLayerGraphBuilt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMaterialAttributeLayers.__PropertyOffset_bIsLayerGraphBuilt) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C157 RID: 49495 RVA: 0x00116749 File Offset: 0x00114949
		static UMaterialExpressionMaterialAttributeLayers()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMaterialAttributeLayers");
		}

		// Token: 0x0600C158 RID: 49496 RVA: 0x00116757 File Offset: 0x00114957
		protected UMaterialExpressionMaterialAttributeLayers(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066B9 RID: 26297
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMaterialAttributeLayers";

		// Token: 0x040066BA RID: 26298
		private static IntPtr _ClassPtr;

		// Token: 0x040066BB RID: 26299
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066BC RID: 26300
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040066BD RID: 26301
		internal static int __PropertyOffset_ExpressionGUID;

		// Token: 0x040066BE RID: 26302
		internal static int __PropertyOffset_Input;

		// Token: 0x040066BF RID: 26303
		[Nullable(2)]
		private FMaterialAttributesInput _Input;

		// Token: 0x040066C0 RID: 26304
		internal static int __PropertyOffset_DefaultLayers;

		// Token: 0x040066C1 RID: 26305
		[Nullable(2)]
		private FMaterialLayersFunctions _DefaultLayers;

		// Token: 0x040066C2 RID: 26306
		internal static int __PropertyOffset_LayerCallers;

		// Token: 0x040066C3 RID: 26307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialExpressionMaterialFunctionCall> _LayerCallers;

		// Token: 0x040066C4 RID: 26308
		internal static int __PropertyOffset_NumActiveLayerCallers;

		// Token: 0x040066C5 RID: 26309
		internal static int __PropertyOffset_BlendCallers;

		// Token: 0x040066C6 RID: 26310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialExpressionMaterialFunctionCall> _BlendCallers;

		// Token: 0x040066C7 RID: 26311
		internal static int __PropertyOffset_NumActiveBlendCallers;

		// Token: 0x040066C8 RID: 26312
		internal static int __PropertyOffset_bIsLayerGraphBuilt;
	}
}
