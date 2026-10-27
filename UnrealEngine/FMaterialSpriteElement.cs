using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E98 RID: 3736
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialSpriteElement")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMaterialSpriteElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C930 RID: 51504 RVA: 0x00124E47 File Offset: 0x00123047
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialSpriteElement._ScriptStructPtr != 0) ? FMaterialSpriteElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialSpriteElement", ref FMaterialSpriteElement._ScriptStructPtr);
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0600C931 RID: 51505 RVA: 0x00124E6B File Offset: 0x0012306B
		// (set) Token: 0x0600C932 RID: 51506 RVA: 0x00124E7F File Offset: 0x0012307F
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialSpriteElement.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialSpriteElement.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600C933 RID: 51507 RVA: 0x00124E94 File Offset: 0x00123094
		// (set) Token: 0x0600C934 RID: 51508 RVA: 0x00124EA8 File Offset: 0x001230A8
		public unsafe UCurveFloat DistanceToOpacityCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialSpriteElement.__PropertyOffset_DistanceToOpacityCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialSpriteElement.__PropertyOffset_DistanceToOpacityCurve, value);
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600C935 RID: 51509 RVA: 0x00124EBD File Offset: 0x001230BD
		// (set) Token: 0x0600C936 RID: 51510 RVA: 0x00124ED6 File Offset: 0x001230D6
		public unsafe bool bSizeIsInScreenSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialSpriteElement.__PropertyOffset_bSizeIsInScreenSpace) & FMaterialSpriteElement.__PropertyMask_bSizeIsInScreenSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialSpriteElement.__PropertyOffset_bSizeIsInScreenSpace) = ((*(base.NativePtr + (IntPtr)FMaterialSpriteElement.__PropertyOffset_bSizeIsInScreenSpace) & ~FMaterialSpriteElement.__PropertyMask_bSizeIsInScreenSpace) | (value ? FMaterialSpriteElement.__PropertyMask_bSizeIsInScreenSpace : 0));
			}
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x0600C937 RID: 51511 RVA: 0x00124F06 File Offset: 0x00123106
		// (set) Token: 0x0600C938 RID: 51512 RVA: 0x00124F16 File Offset: 0x00123116
		public unsafe float BaseSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialSpriteElement.__PropertyOffset_BaseSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialSpriteElement.__PropertyOffset_BaseSizeX) = value;
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0600C939 RID: 51513 RVA: 0x00124F27 File Offset: 0x00123127
		// (set) Token: 0x0600C93A RID: 51514 RVA: 0x00124F37 File Offset: 0x00123137
		public unsafe float BaseSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialSpriteElement.__PropertyOffset_BaseSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialSpriteElement.__PropertyOffset_BaseSizeY) = value;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600C93B RID: 51515 RVA: 0x00124F48 File Offset: 0x00123148
		// (set) Token: 0x0600C93C RID: 51516 RVA: 0x00124F5C File Offset: 0x0012315C
		public unsafe UCurveFloat DistanceToSizeCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialSpriteElement.__PropertyOffset_DistanceToSizeCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialSpriteElement.__PropertyOffset_DistanceToSizeCurve, value);
			}
		}

		// Token: 0x0600C93D RID: 51517 RVA: 0x00124F71 File Offset: 0x00123171
		public FMaterialSpriteElement()
		{
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x00124F79 File Offset: 0x00123179
		[NullableContext(1)]
		public FMaterialSpriteElement(UMaterialInterface Material, UCurveFloat DistanceToOpacityCurve, bool bSizeIsInScreenSpace, float BaseSizeX, float BaseSizeY, UCurveFloat DistanceToSizeCurve)
		{
			this.Material = Material;
			this.DistanceToOpacityCurve = DistanceToOpacityCurve;
			this.bSizeIsInScreenSpace = bSizeIsInScreenSpace;
			this.BaseSizeX = BaseSizeX;
			this.BaseSizeY = BaseSizeY;
			this.DistanceToSizeCurve = DistanceToSizeCurve;
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x00124FAE File Offset: 0x001231AE
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialSpriteElement.StaticStruct();
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x00124FBA File Offset: 0x001231BA
		public FMaterialSpriteElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x00124FC4 File Offset: 0x001231C4
		public FMaterialSpriteElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x00124FCF File Offset: 0x001231CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialSpriteElement(Pointer, false, true);
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x00124FD9 File Offset: 0x001231D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialSpriteElement(Pointer, MemoryOwner);
		}

		// Token: 0x04006C42 RID: 27714
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialSpriteElement";

		// Token: 0x04006C43 RID: 27715
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006C44 RID: 27716
		internal static int __PropertyOffset_Material;

		// Token: 0x04006C45 RID: 27717
		internal static int __PropertyOffset_DistanceToOpacityCurve;

		// Token: 0x04006C46 RID: 27718
		internal static int __PropertyOffset_bSizeIsInScreenSpace;

		// Token: 0x04006C47 RID: 27719
		internal static byte __PropertyMask_bSizeIsInScreenSpace;

		// Token: 0x04006C48 RID: 27720
		internal static int __PropertyOffset_BaseSizeX;

		// Token: 0x04006C49 RID: 27721
		internal static int __PropertyOffset_BaseSizeY;

		// Token: 0x04006C4A RID: 27722
		internal static int __PropertyOffset_DistanceToSizeCurve;
	}
}
