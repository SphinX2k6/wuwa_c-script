using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B5C RID: 7004
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_XRayConst")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroMaterialControllerParam_XRayConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A857 RID: 108631 RVA: 0x00271A34 File Offset: 0x0026FC34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_XRayConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_XRayConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_XRayConst", ref FKuroMaterialControllerParam_XRayConst._ScriptStructPtr);
		}

		// Token: 0x17006A9F RID: 27295
		// (get) Token: 0x0601A858 RID: 108632 RVA: 0x00271A58 File Offset: 0x0026FC58
		// (set) Token: 0x0601A859 RID: 108633 RVA: 0x00271A6C File Offset: 0x0026FC6C
		public unsafe FLinearColor XRayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayColor) = value;
			}
		}

		// Token: 0x17006AA0 RID: 27296
		// (get) Token: 0x0601A85A RID: 108634 RVA: 0x00271A81 File Offset: 0x0026FC81
		// (set) Token: 0x0601A85B RID: 108635 RVA: 0x00271A91 File Offset: 0x0026FC91
		public unsafe float XRayDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayDistance) = value;
			}
		}

		// Token: 0x17006AA1 RID: 27297
		// (get) Token: 0x0601A85C RID: 108636 RVA: 0x00271AA2 File Offset: 0x0026FCA2
		// (set) Token: 0x0601A85D RID: 108637 RVA: 0x00271AB2 File Offset: 0x0026FCB2
		public unsafe float XRayOutlineWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayOutlineWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayOutlineWidth) = value;
			}
		}

		// Token: 0x17006AA2 RID: 27298
		// (get) Token: 0x0601A85E RID: 108638 RVA: 0x00271AC3 File Offset: 0x0026FCC3
		// (set) Token: 0x0601A85F RID: 108639 RVA: 0x00271AD7 File Offset: 0x0026FCD7
		public unsafe UMaterialInterface XRayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayMaterial, value);
			}
		}

		// Token: 0x17006AA3 RID: 27299
		// (get) Token: 0x0601A860 RID: 108640 RVA: 0x00271AEC File Offset: 0x0026FCEC
		// (set) Token: 0x0601A861 RID: 108641 RVA: 0x00271B00 File Offset: 0x0026FD00
		public unsafe UMaterialInterface XRayOutlineMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayOutlineMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRayConst.__PropertyOffset_XRayOutlineMaterial, value);
			}
		}

		// Token: 0x17006AA4 RID: 27300
		// (get) Token: 0x0601A862 RID: 108642 RVA: 0x00271B15 File Offset: 0x0026FD15
		// (set) Token: 0x0601A863 RID: 108643 RVA: 0x00271B25 File Offset: 0x0026FD25
		public unsafe bool bPenetrateCharacters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_bPenetrateCharacters) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRayConst.__PropertyOffset_bPenetrateCharacters) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A864 RID: 108644 RVA: 0x00271B36 File Offset: 0x0026FD36
		public FKuroMaterialControllerParam_XRayConst()
		{
		}

		// Token: 0x0601A865 RID: 108645 RVA: 0x00271B3E File Offset: 0x0026FD3E
		[NullableContext(1)]
		public FKuroMaterialControllerParam_XRayConst(FLinearColor XRayColor, float XRayDistance, float XRayOutlineWidth, UMaterialInterface XRayMaterial, UMaterialInterface XRayOutlineMaterial, bool bPenetrateCharacters)
		{
			this.XRayColor = XRayColor;
			this.XRayDistance = XRayDistance;
			this.XRayOutlineWidth = XRayOutlineWidth;
			this.XRayMaterial = XRayMaterial;
			this.XRayOutlineMaterial = XRayOutlineMaterial;
			this.bPenetrateCharacters = bPenetrateCharacters;
		}

		// Token: 0x0601A866 RID: 108646 RVA: 0x00271B73 File Offset: 0x0026FD73
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_XRayConst.StaticStruct();
		}

		// Token: 0x0601A867 RID: 108647 RVA: 0x00271B7F File Offset: 0x0026FD7F
		public FKuroMaterialControllerParam_XRayConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A868 RID: 108648 RVA: 0x00271B89 File Offset: 0x0026FD89
		public FKuroMaterialControllerParam_XRayConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A869 RID: 108649 RVA: 0x00271B94 File Offset: 0x0026FD94
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_XRayConst(Pointer, false, true);
		}

		// Token: 0x0601A86A RID: 108650 RVA: 0x00271B9E File Offset: 0x0026FD9E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_XRayConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5D5 RID: 58837
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_XRayConst";

		// Token: 0x0400E5D6 RID: 58838
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5D7 RID: 58839
		internal static int __PropertyOffset_XRayColor;

		// Token: 0x0400E5D8 RID: 58840
		internal static int __PropertyOffset_XRayDistance;

		// Token: 0x0400E5D9 RID: 58841
		internal static int __PropertyOffset_XRayOutlineWidth;

		// Token: 0x0400E5DA RID: 58842
		internal static int __PropertyOffset_XRayMaterial;

		// Token: 0x0400E5DB RID: 58843
		internal static int __PropertyOffset_XRayOutlineMaterial;

		// Token: 0x0400E5DC RID: 58844
		internal static int __PropertyOffset_bPenetrateCharacters;
	}
}
