using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B5B RID: 7003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_XRay")]
	[UnrealStructLayout(2520, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2520)]
	public class FKuroMaterialControllerParam_XRay : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A843 RID: 108611 RVA: 0x00271800 File Offset: 0x0026FA00
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_XRay._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_XRay._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_XRay", ref FKuroMaterialControllerParam_XRay._ScriptStructPtr);
		}

		// Token: 0x17006A99 RID: 27289
		// (get) Token: 0x0601A844 RID: 108612 RVA: 0x00271824 File Offset: 0x0026FA24
		// (set) Token: 0x0601A845 RID: 108613 RVA: 0x00271867 File Offset: 0x0026FA67
		public FKuroMaterialCurveColorGroup XRayColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._XRayColor) == null)
				{
					result = (this._XRayColor = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A9A RID: 27290
		// (get) Token: 0x0601A846 RID: 108614 RVA: 0x00271888 File Offset: 0x0026FA88
		// (set) Token: 0x0601A847 RID: 108615 RVA: 0x002718CB File Offset: 0x0026FACB
		public FKuroMaterialCurveFloatGroup XRayDistance
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._XRayDistance) == null)
				{
					result = (this._XRayDistance = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayDistance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A9B RID: 27291
		// (get) Token: 0x0601A848 RID: 108616 RVA: 0x002718EC File Offset: 0x0026FAEC
		// (set) Token: 0x0601A849 RID: 108617 RVA: 0x0027192F File Offset: 0x0026FB2F
		public FKuroMaterialCurveFloatGroup XRayOutlineWidth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._XRayOutlineWidth) == null)
				{
					result = (this._XRayOutlineWidth = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayOutlineWidth, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayOutlineWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A9C RID: 27292
		// (get) Token: 0x0601A84A RID: 108618 RVA: 0x00271950 File Offset: 0x0026FB50
		// (set) Token: 0x0601A84B RID: 108619 RVA: 0x00271964 File Offset: 0x0026FB64
		[Nullable(2)]
		public unsafe UMaterialInterface XRayMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayMaterial, value);
			}
		}

		// Token: 0x17006A9D RID: 27293
		// (get) Token: 0x0601A84C RID: 108620 RVA: 0x00271979 File Offset: 0x0026FB79
		// (set) Token: 0x0601A84D RID: 108621 RVA: 0x0027198D File Offset: 0x0026FB8D
		[Nullable(2)]
		public unsafe UMaterialInterface XRayOutlineMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayOutlineMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialControllerParam_XRay.__PropertyOffset_XRayOutlineMaterial, value);
			}
		}

		// Token: 0x17006A9E RID: 27294
		// (get) Token: 0x0601A84E RID: 108622 RVA: 0x002719A2 File Offset: 0x0026FBA2
		// (set) Token: 0x0601A84F RID: 108623 RVA: 0x002719B2 File Offset: 0x0026FBB2
		public unsafe bool bPenetrateCharacters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_bPenetrateCharacters) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_XRay.__PropertyOffset_bPenetrateCharacters) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A850 RID: 108624 RVA: 0x002719C3 File Offset: 0x0026FBC3
		public FKuroMaterialControllerParam_XRay()
		{
		}

		// Token: 0x0601A851 RID: 108625 RVA: 0x002719CB File Offset: 0x0026FBCB
		public FKuroMaterialControllerParam_XRay(FKuroMaterialCurveColorGroup XRayColor, FKuroMaterialCurveFloatGroup XRayDistance, FKuroMaterialCurveFloatGroup XRayOutlineWidth, UMaterialInterface XRayMaterial, UMaterialInterface XRayOutlineMaterial, bool bPenetrateCharacters)
		{
			this.XRayColor = XRayColor;
			this.XRayDistance = XRayDistance;
			this.XRayOutlineWidth = XRayOutlineWidth;
			this.XRayMaterial = XRayMaterial;
			this.XRayOutlineMaterial = XRayOutlineMaterial;
			this.bPenetrateCharacters = bPenetrateCharacters;
		}

		// Token: 0x0601A852 RID: 108626 RVA: 0x00271A00 File Offset: 0x0026FC00
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_XRay.StaticStruct();
		}

		// Token: 0x0601A853 RID: 108627 RVA: 0x00271A0C File Offset: 0x0026FC0C
		[NullableContext(2)]
		public FKuroMaterialControllerParam_XRay(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A854 RID: 108628 RVA: 0x00271A16 File Offset: 0x0026FC16
		public FKuroMaterialControllerParam_XRay(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A855 RID: 108629 RVA: 0x00271A21 File Offset: 0x0026FC21
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_XRay(Pointer, false, true);
		}

		// Token: 0x0601A856 RID: 108630 RVA: 0x00271A2B File Offset: 0x0026FC2B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_XRay(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5CA RID: 58826
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_XRay";

		// Token: 0x0400E5CB RID: 58827
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5CC RID: 58828
		internal static int __PropertyOffset_XRayColor;

		// Token: 0x0400E5CD RID: 58829
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _XRayColor;

		// Token: 0x0400E5CE RID: 58830
		internal static int __PropertyOffset_XRayDistance;

		// Token: 0x0400E5CF RID: 58831
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _XRayDistance;

		// Token: 0x0400E5D0 RID: 58832
		internal static int __PropertyOffset_XRayOutlineWidth;

		// Token: 0x0400E5D1 RID: 58833
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _XRayOutlineWidth;

		// Token: 0x0400E5D2 RID: 58834
		internal static int __PropertyOffset_XRayMaterial;

		// Token: 0x0400E5D3 RID: 58835
		internal static int __PropertyOffset_XRayOutlineMaterial;

		// Token: 0x0400E5D4 RID: 58836
		internal static int __PropertyOffset_bPenetrateCharacters;
	}
}
