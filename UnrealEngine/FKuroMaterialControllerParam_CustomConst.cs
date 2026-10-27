using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B40 RID: 6976
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_CustomConst")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroMaterialControllerParam_CustomConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A69F RID: 108191 RVA: 0x0026F162 File Offset: 0x0026D362
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_CustomConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_CustomConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_CustomConst", ref FKuroMaterialControllerParam_CustomConst._ScriptStructPtr);
		}

		// Token: 0x17006A33 RID: 27187
		// (get) Token: 0x0601A6A0 RID: 108192 RVA: 0x0026F188 File Offset: 0x0026D388
		// (set) Token: 0x0601A6A1 RID: 108193 RVA: 0x0026F1CB File Offset: 0x0026D3CB
		public TArray<FKuroMaterialNamedFloat> CustomFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedFloat> result;
				if ((result = this._CustomFloatParameters) == null)
				{
					result = (this._CustomFloatParameters = new TArray<FKuroMaterialNamedFloat>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_CustomConst.__PropertyOffset_CustomFloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A34 RID: 27188
		// (get) Token: 0x0601A6A2 RID: 108194 RVA: 0x0026F1DC File Offset: 0x0026D3DC
		// (set) Token: 0x0601A6A3 RID: 108195 RVA: 0x0026F21F File Offset: 0x0026D41F
		public TArray<FKuroMaterialNamedColor> CustomColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedColor> result;
				if ((result = this._CustomColorParameters) == null)
				{
					result = (this._CustomColorParameters = new TArray<FKuroMaterialNamedColor>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_CustomConst.__PropertyOffset_CustomColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A35 RID: 27189
		// (get) Token: 0x0601A6A4 RID: 108196 RVA: 0x0026F230 File Offset: 0x0026D430
		// (set) Token: 0x0601A6A5 RID: 108197 RVA: 0x0026F273 File Offset: 0x0026D473
		public TArray<FKuroMaterialNamedTexture> CustomTextureParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedTexture> result;
				if ((result = this._CustomTextureParameters) == null)
				{
					result = (this._CustomTextureParameters = new TArray<FKuroMaterialNamedTexture>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_CustomConst.__PropertyOffset_CustomTextureParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomTextureParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006A36 RID: 27190
		// (get) Token: 0x0601A6A6 RID: 108198 RVA: 0x0026F284 File Offset: 0x0026D484
		// (set) Token: 0x0601A6A7 RID: 108199 RVA: 0x0026F2C7 File Offset: 0x0026D4C7
		public TArray<FKuroMaterialCustomParamsForEachMaterial> CustomParametersForEachMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialCustomParamsForEachMaterial> result;
				if ((result = this._CustomParametersForEachMaterials) == null)
				{
					result = (this._CustomParametersForEachMaterials = new TArray<FKuroMaterialCustomParamsForEachMaterial>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_CustomConst.__PropertyOffset_CustomParametersForEachMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomParametersForEachMaterials.CopyAssign(value);
			}
		}

		// Token: 0x0601A6A8 RID: 108200 RVA: 0x0026F2D5 File Offset: 0x0026D4D5
		public FKuroMaterialControllerParam_CustomConst()
		{
		}

		// Token: 0x0601A6A9 RID: 108201 RVA: 0x0026F2DD File Offset: 0x0026D4DD
		public FKuroMaterialControllerParam_CustomConst(TArray<FKuroMaterialNamedFloat> CustomFloatParameters, TArray<FKuroMaterialNamedColor> CustomColorParameters, TArray<FKuroMaterialNamedTexture> CustomTextureParameters, TArray<FKuroMaterialCustomParamsForEachMaterial> CustomParametersForEachMaterials)
		{
			this.CustomFloatParameters = CustomFloatParameters;
			this.CustomColorParameters = CustomColorParameters;
			this.CustomTextureParameters = CustomTextureParameters;
			this.CustomParametersForEachMaterials = CustomParametersForEachMaterials;
		}

		// Token: 0x0601A6AA RID: 108202 RVA: 0x0026F302 File Offset: 0x0026D502
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_CustomConst.StaticStruct();
		}

		// Token: 0x0601A6AB RID: 108203 RVA: 0x0026F30E File Offset: 0x0026D50E
		[NullableContext(2)]
		public FKuroMaterialControllerParam_CustomConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A6AC RID: 108204 RVA: 0x0026F318 File Offset: 0x0026D518
		public FKuroMaterialControllerParam_CustomConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A6AD RID: 108205 RVA: 0x0026F323 File Offset: 0x0026D523
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_CustomConst(Pointer, false, true);
		}

		// Token: 0x0601A6AE RID: 108206 RVA: 0x0026F32D File Offset: 0x0026D52D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_CustomConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E502 RID: 58626
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_CustomConst";

		// Token: 0x0400E503 RID: 58627
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E504 RID: 58628
		internal static int __PropertyOffset_CustomFloatParameters;

		// Token: 0x0400E505 RID: 58629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedFloat> _CustomFloatParameters;

		// Token: 0x0400E506 RID: 58630
		internal static int __PropertyOffset_CustomColorParameters;

		// Token: 0x0400E507 RID: 58631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedColor> _CustomColorParameters;

		// Token: 0x0400E508 RID: 58632
		internal static int __PropertyOffset_CustomTextureParameters;

		// Token: 0x0400E509 RID: 58633
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedTexture> _CustomTextureParameters;

		// Token: 0x0400E50A RID: 58634
		internal static int __PropertyOffset_CustomParametersForEachMaterials;

		// Token: 0x0400E50B RID: 58635
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialCustomParamsForEachMaterial> _CustomParametersForEachMaterials;
	}
}
