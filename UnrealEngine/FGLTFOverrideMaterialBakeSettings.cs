using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200144E RID: 5198
	[UnrealObjectPath("/Script/GLTFExporter.GLTFOverrideMaterialBakeSettings")]
	[UnrealStructLayout(6, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 6)]
	public class FGLTFOverrideMaterialBakeSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601302A RID: 77866 RVA: 0x001BF326 File Offset: 0x001BD526
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGLTFOverrideMaterialBakeSettings._ScriptStructPtr != 0) ? FGLTFOverrideMaterialBakeSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GLTFExporter.GLTFOverrideMaterialBakeSettings", ref FGLTFOverrideMaterialBakeSettings._ScriptStructPtr);
		}

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x0601302B RID: 77867 RVA: 0x001BF34A File Offset: 0x001BD54A
		// (set) Token: 0x0601302C RID: 77868 RVA: 0x001BF35A File Offset: 0x001BD55A
		public unsafe bool bOverrideSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_bOverrideSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_bOverrideSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x0601302D RID: 77869 RVA: 0x001BF36B File Offset: 0x001BD56B
		// (set) Token: 0x0601302E RID: 77870 RVA: 0x001BF37B File Offset: 0x001BD57B
		public unsafe EGLTFMaterialBakeSizePOT Size
		{
			get
			{
				return (EGLTFMaterialBakeSizePOT)(*(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_Size));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_Size) = (byte)value;
			}
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x0601302F RID: 77871 RVA: 0x001BF38C File Offset: 0x001BD58C
		// (set) Token: 0x06013030 RID: 77872 RVA: 0x001BF39C File Offset: 0x001BD59C
		public unsafe bool bOverrideFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_bOverrideFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_bOverrideFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x06013031 RID: 77873 RVA: 0x001BF3AD File Offset: 0x001BD5AD
		// (set) Token: 0x06013032 RID: 77874 RVA: 0x001BF3C1 File Offset: 0x001BD5C1
		public unsafe TEnumAsByte<TextureFilter> Filter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_Filter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_Filter) = value;
			}
		}

		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x06013033 RID: 77875 RVA: 0x001BF3D6 File Offset: 0x001BD5D6
		// (set) Token: 0x06013034 RID: 77876 RVA: 0x001BF3E6 File Offset: 0x001BD5E6
		public unsafe bool bOverrideTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_bOverrideTiling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_bOverrideTiling) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x06013035 RID: 77877 RVA: 0x001BF3F7 File Offset: 0x001BD5F7
		// (set) Token: 0x06013036 RID: 77878 RVA: 0x001BF40B File Offset: 0x001BD60B
		public unsafe TEnumAsByte<TextureAddress> Tiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_Tiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGLTFOverrideMaterialBakeSettings.__PropertyOffset_Tiling) = value;
			}
		}

		// Token: 0x06013037 RID: 77879 RVA: 0x001BF420 File Offset: 0x001BD620
		public FGLTFOverrideMaterialBakeSettings()
		{
		}

		// Token: 0x06013038 RID: 77880 RVA: 0x001BF428 File Offset: 0x001BD628
		public FGLTFOverrideMaterialBakeSettings(bool bOverrideSize, EGLTFMaterialBakeSizePOT Size, bool bOverrideFilter, TEnumAsByte<TextureFilter> Filter, bool bOverrideTiling, TEnumAsByte<TextureAddress> Tiling)
		{
			this.bOverrideSize = bOverrideSize;
			this.Size = Size;
			this.bOverrideFilter = bOverrideFilter;
			this.Filter = Filter;
			this.bOverrideTiling = bOverrideTiling;
			this.Tiling = Tiling;
		}

		// Token: 0x06013039 RID: 77881 RVA: 0x001BF45D File Offset: 0x001BD65D
		protected override IntPtr GetUStructPtr()
		{
			return FGLTFOverrideMaterialBakeSettings.StaticStruct();
		}

		// Token: 0x0601303A RID: 77882 RVA: 0x001BF469 File Offset: 0x001BD669
		[NullableContext(2)]
		public FGLTFOverrideMaterialBakeSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601303B RID: 77883 RVA: 0x001BF473 File Offset: 0x001BD673
		public FGLTFOverrideMaterialBakeSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601303C RID: 77884 RVA: 0x001BF47E File Offset: 0x001BD67E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGLTFOverrideMaterialBakeSettings(Pointer, false, true);
		}

		// Token: 0x0601303D RID: 77885 RVA: 0x001BF488 File Offset: 0x001BD688
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGLTFOverrideMaterialBakeSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400A2AD RID: 41645
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GLTFExporter.GLTFOverrideMaterialBakeSettings";

		// Token: 0x0400A2AE RID: 41646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A2AF RID: 41647
		internal static int __PropertyOffset_bOverrideSize;

		// Token: 0x0400A2B0 RID: 41648
		internal static int __PropertyOffset_Size;

		// Token: 0x0400A2B1 RID: 41649
		internal static int __PropertyOffset_bOverrideFilter;

		// Token: 0x0400A2B2 RID: 41650
		internal static int __PropertyOffset_Filter;

		// Token: 0x0400A2B3 RID: 41651
		internal static int __PropertyOffset_bOverrideTiling;

		// Token: 0x0400A2B4 RID: 41652
		internal static int __PropertyOffset_Tiling;
	}
}
