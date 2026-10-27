using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F70 RID: 8048
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeEditToolRenderData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLandscapeEditToolRenderData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E89F RID: 125087 RVA: 0x002D640F File Offset: 0x002D460F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeEditToolRenderData._ScriptStructPtr != 0) ? FLandscapeEditToolRenderData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeEditToolRenderData", ref FLandscapeEditToolRenderData._ScriptStructPtr);
		}

		// Token: 0x1700797E RID: 31102
		// (get) Token: 0x0601E8A0 RID: 125088 RVA: 0x002D6433 File Offset: 0x002D4633
		// (set) Token: 0x0601E8A1 RID: 125089 RVA: 0x002D6447 File Offset: 0x002D4647
		public unsafe UMaterialInterface ToolMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_ToolMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_ToolMaterial, value);
			}
		}

		// Token: 0x1700797F RID: 31103
		// (get) Token: 0x0601E8A2 RID: 125090 RVA: 0x002D645C File Offset: 0x002D465C
		// (set) Token: 0x0601E8A3 RID: 125091 RVA: 0x002D6470 File Offset: 0x002D4670
		public unsafe UMaterialInterface GizmoMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_GizmoMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_GizmoMaterial, value);
			}
		}

		// Token: 0x17007980 RID: 31104
		// (get) Token: 0x0601E8A4 RID: 125092 RVA: 0x002D6485 File Offset: 0x002D4685
		// (set) Token: 0x0601E8A5 RID: 125093 RVA: 0x002D6495 File Offset: 0x002D4695
		public unsafe int SelectedType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_SelectedType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_SelectedType) = value;
			}
		}

		// Token: 0x17007981 RID: 31105
		// (get) Token: 0x0601E8A6 RID: 125094 RVA: 0x002D64A6 File Offset: 0x002D46A6
		// (set) Token: 0x0601E8A7 RID: 125095 RVA: 0x002D64B6 File Offset: 0x002D46B6
		public unsafe int DebugChannelR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_DebugChannelR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_DebugChannelR) = value;
			}
		}

		// Token: 0x17007982 RID: 31106
		// (get) Token: 0x0601E8A8 RID: 125096 RVA: 0x002D64C7 File Offset: 0x002D46C7
		// (set) Token: 0x0601E8A9 RID: 125097 RVA: 0x002D64D7 File Offset: 0x002D46D7
		public unsafe int DebugChannelG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_DebugChannelG);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_DebugChannelG) = value;
			}
		}

		// Token: 0x17007983 RID: 31107
		// (get) Token: 0x0601E8AA RID: 125098 RVA: 0x002D64E8 File Offset: 0x002D46E8
		// (set) Token: 0x0601E8AB RID: 125099 RVA: 0x002D64F8 File Offset: 0x002D46F8
		public unsafe int DebugChannelB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_DebugChannelB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeEditToolRenderData.__PropertyOffset_DebugChannelB) = value;
			}
		}

		// Token: 0x17007984 RID: 31108
		// (get) Token: 0x0601E8AC RID: 125100 RVA: 0x002D6509 File Offset: 0x002D4709
		// (set) Token: 0x0601E8AD RID: 125101 RVA: 0x002D651D File Offset: 0x002D471D
		public unsafe UTexture2D DataTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_DataTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_DataTexture, value);
			}
		}

		// Token: 0x17007985 RID: 31109
		// (get) Token: 0x0601E8AE RID: 125102 RVA: 0x002D6532 File Offset: 0x002D4732
		// (set) Token: 0x0601E8AF RID: 125103 RVA: 0x002D6546 File Offset: 0x002D4746
		public unsafe UTexture2D LayerContributionTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_LayerContributionTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_LayerContributionTexture, value);
			}
		}

		// Token: 0x17007986 RID: 31110
		// (get) Token: 0x0601E8B0 RID: 125104 RVA: 0x002D655B File Offset: 0x002D475B
		// (set) Token: 0x0601E8B1 RID: 125105 RVA: 0x002D656F File Offset: 0x002D476F
		public unsafe UTexture2D DirtyTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_DirtyTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeEditToolRenderData.__PropertyOffset_DirtyTexture, value);
			}
		}

		// Token: 0x0601E8B2 RID: 125106 RVA: 0x002D6584 File Offset: 0x002D4784
		public FLandscapeEditToolRenderData()
		{
		}

		// Token: 0x0601E8B3 RID: 125107 RVA: 0x002D658C File Offset: 0x002D478C
		[NullableContext(1)]
		public FLandscapeEditToolRenderData(UMaterialInterface ToolMaterial, UMaterialInterface GizmoMaterial, int SelectedType, int DebugChannelR, int DebugChannelG, int DebugChannelB, UTexture2D DataTexture, UTexture2D LayerContributionTexture, UTexture2D DirtyTexture)
		{
			this.ToolMaterial = ToolMaterial;
			this.GizmoMaterial = GizmoMaterial;
			this.SelectedType = SelectedType;
			this.DebugChannelR = DebugChannelR;
			this.DebugChannelG = DebugChannelG;
			this.DebugChannelB = DebugChannelB;
			this.DataTexture = DataTexture;
			this.LayerContributionTexture = LayerContributionTexture;
			this.DirtyTexture = DirtyTexture;
		}

		// Token: 0x0601E8B4 RID: 125108 RVA: 0x002D65E4 File Offset: 0x002D47E4
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeEditToolRenderData.StaticStruct();
		}

		// Token: 0x0601E8B5 RID: 125109 RVA: 0x002D65F0 File Offset: 0x002D47F0
		public FLandscapeEditToolRenderData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E8B6 RID: 125110 RVA: 0x002D65FA File Offset: 0x002D47FA
		public FLandscapeEditToolRenderData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E8B7 RID: 125111 RVA: 0x002D6605 File Offset: 0x002D4805
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeEditToolRenderData(Pointer, false, true);
		}

		// Token: 0x0601E8B8 RID: 125112 RVA: 0x002D660F File Offset: 0x002D480F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeEditToolRenderData(Pointer, MemoryOwner);
		}

		// Token: 0x04010811 RID: 67601
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeEditToolRenderData";

		// Token: 0x04010812 RID: 67602
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010813 RID: 67603
		internal static int __PropertyOffset_ToolMaterial;

		// Token: 0x04010814 RID: 67604
		internal static int __PropertyOffset_GizmoMaterial;

		// Token: 0x04010815 RID: 67605
		internal static int __PropertyOffset_SelectedType;

		// Token: 0x04010816 RID: 67606
		internal static int __PropertyOffset_DebugChannelR;

		// Token: 0x04010817 RID: 67607
		internal static int __PropertyOffset_DebugChannelG;

		// Token: 0x04010818 RID: 67608
		internal static int __PropertyOffset_DebugChannelB;

		// Token: 0x04010819 RID: 67609
		internal static int __PropertyOffset_DataTexture;

		// Token: 0x0401081A RID: 67610
		internal static int __PropertyOffset_LayerContributionTexture;

		// Token: 0x0401081B RID: 67611
		internal static int __PropertyOffset_DirtyTexture;
	}
}
