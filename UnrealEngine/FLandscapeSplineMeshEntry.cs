using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F8C RID: 8076
	[UnrealObjectPath("/Script/Landscape.LandscapeSplineMeshEntry")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLandscapeSplineMeshEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EABF RID: 125631 RVA: 0x002D9750 File Offset: 0x002D7950
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeSplineMeshEntry._ScriptStructPtr != 0) ? FLandscapeSplineMeshEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeSplineMeshEntry", ref FLandscapeSplineMeshEntry._ScriptStructPtr);
		}

		// Token: 0x17007A2C RID: 31276
		// (get) Token: 0x0601EAC0 RID: 125632 RVA: 0x002D9774 File Offset: 0x002D7974
		// (set) Token: 0x0601EAC1 RID: 125633 RVA: 0x002D9788 File Offset: 0x002D7988
		[Nullable(2)]
		public unsafe UStaticMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeSplineMeshEntry.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeSplineMeshEntry.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17007A2D RID: 31277
		// (get) Token: 0x0601EAC2 RID: 125634 RVA: 0x002D97A0 File Offset: 0x002D79A0
		// (set) Token: 0x0601EAC3 RID: 125635 RVA: 0x002D97E3 File Offset: 0x002D79E3
		[Nullable(1)]
		public TArray<UMaterialInterface> MaterialOverrides
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MaterialOverrides) == null)
				{
					result = (this._MaterialOverrides = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_MaterialOverrides, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialOverrides.CopyAssign(value);
			}
		}

		// Token: 0x17007A2E RID: 31278
		// (get) Token: 0x0601EAC4 RID: 125636 RVA: 0x002D97F1 File Offset: 0x002D79F1
		// (set) Token: 0x0601EAC5 RID: 125637 RVA: 0x002D980A File Offset: 0x002D7A0A
		public unsafe bool bCenterH
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_bCenterH) & FLandscapeSplineMeshEntry.__PropertyMask_bCenterH) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_bCenterH) = ((*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_bCenterH) & ~FLandscapeSplineMeshEntry.__PropertyMask_bCenterH) | (value ? FLandscapeSplineMeshEntry.__PropertyMask_bCenterH : 0));
			}
		}

		// Token: 0x17007A2F RID: 31279
		// (get) Token: 0x0601EAC6 RID: 125638 RVA: 0x002D983A File Offset: 0x002D7A3A
		// (set) Token: 0x0601EAC7 RID: 125639 RVA: 0x002D984E File Offset: 0x002D7A4E
		public unsafe FVector2D CenterAdjust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_CenterAdjust);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_CenterAdjust) = value;
			}
		}

		// Token: 0x17007A30 RID: 31280
		// (get) Token: 0x0601EAC8 RID: 125640 RVA: 0x002D9863 File Offset: 0x002D7A63
		// (set) Token: 0x0601EAC9 RID: 125641 RVA: 0x002D987C File Offset: 0x002D7A7C
		public unsafe bool bScaleToWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_bScaleToWidth) & FLandscapeSplineMeshEntry.__PropertyMask_bScaleToWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_bScaleToWidth) = ((*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_bScaleToWidth) & ~FLandscapeSplineMeshEntry.__PropertyMask_bScaleToWidth) | (value ? FLandscapeSplineMeshEntry.__PropertyMask_bScaleToWidth : 0));
			}
		}

		// Token: 0x17007A31 RID: 31281
		// (get) Token: 0x0601EACA RID: 125642 RVA: 0x002D98AC File Offset: 0x002D7AAC
		// (set) Token: 0x0601EACB RID: 125643 RVA: 0x002D98C0 File Offset: 0x002D7AC0
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17007A32 RID: 31282
		// (get) Token: 0x0601EACC RID: 125644 RVA: 0x002D98D5 File Offset: 0x002D7AD5
		// (set) Token: 0x0601EACD RID: 125645 RVA: 0x002D98E9 File Offset: 0x002D7AE9
		public unsafe TEnumAsByte<LandscapeSplineMeshOrientation> Orientation_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_Orientation_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_Orientation_DEPRECATED) = value;
			}
		}

		// Token: 0x17007A33 RID: 31283
		// (get) Token: 0x0601EACE RID: 125646 RVA: 0x002D98FE File Offset: 0x002D7AFE
		// (set) Token: 0x0601EACF RID: 125647 RVA: 0x002D9912 File Offset: 0x002D7B12
		public unsafe TEnumAsByte<ESplineMeshAxis> ForwardAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_ForwardAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_ForwardAxis) = value;
			}
		}

		// Token: 0x17007A34 RID: 31284
		// (get) Token: 0x0601EAD0 RID: 125648 RVA: 0x002D9927 File Offset: 0x002D7B27
		// (set) Token: 0x0601EAD1 RID: 125649 RVA: 0x002D993B File Offset: 0x002D7B3B
		public unsafe TEnumAsByte<ESplineMeshAxis> UpAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_UpAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeSplineMeshEntry.__PropertyOffset_UpAxis) = value;
			}
		}

		// Token: 0x0601EAD2 RID: 125650 RVA: 0x002D9950 File Offset: 0x002D7B50
		public FLandscapeSplineMeshEntry()
		{
		}

		// Token: 0x0601EAD3 RID: 125651 RVA: 0x002D9958 File Offset: 0x002D7B58
		public FLandscapeSplineMeshEntry([Nullable(1)] UStaticMesh Mesh, [Nullable(1)] TArray<UMaterialInterface> MaterialOverrides, bool bCenterH, FVector2D CenterAdjust, bool bScaleToWidth, FVector Scale, TEnumAsByte<LandscapeSplineMeshOrientation> Orientation_DEPRECATED, TEnumAsByte<ESplineMeshAxis> ForwardAxis, TEnumAsByte<ESplineMeshAxis> UpAxis)
		{
			this.Mesh = Mesh;
			this.MaterialOverrides = MaterialOverrides;
			this.bCenterH = bCenterH;
			this.CenterAdjust = CenterAdjust;
			this.bScaleToWidth = bScaleToWidth;
			this.Scale = Scale;
			this.Orientation_DEPRECATED = Orientation_DEPRECATED;
			this.ForwardAxis = ForwardAxis;
			this.UpAxis = UpAxis;
		}

		// Token: 0x0601EAD4 RID: 125652 RVA: 0x002D99B0 File Offset: 0x002D7BB0
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeSplineMeshEntry.StaticStruct();
		}

		// Token: 0x0601EAD5 RID: 125653 RVA: 0x002D99BC File Offset: 0x002D7BBC
		[NullableContext(2)]
		public FLandscapeSplineMeshEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EAD6 RID: 125654 RVA: 0x002D99C6 File Offset: 0x002D7BC6
		public FLandscapeSplineMeshEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EAD7 RID: 125655 RVA: 0x002D99D1 File Offset: 0x002D7BD1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeSplineMeshEntry(Pointer, false, true);
		}

		// Token: 0x0601EAD8 RID: 125656 RVA: 0x002D99DB File Offset: 0x002D7BDB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeSplineMeshEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04010946 RID: 67910
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeSplineMeshEntry";

		// Token: 0x04010947 RID: 67911
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010948 RID: 67912
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04010949 RID: 67913
		internal static int __PropertyOffset_MaterialOverrides;

		// Token: 0x0401094A RID: 67914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MaterialOverrides;

		// Token: 0x0401094B RID: 67915
		internal static int __PropertyOffset_bCenterH;

		// Token: 0x0401094C RID: 67916
		internal static byte __PropertyMask_bCenterH;

		// Token: 0x0401094D RID: 67917
		internal static int __PropertyOffset_CenterAdjust;

		// Token: 0x0401094E RID: 67918
		internal static int __PropertyOffset_bScaleToWidth;

		// Token: 0x0401094F RID: 67919
		internal static byte __PropertyMask_bScaleToWidth;

		// Token: 0x04010950 RID: 67920
		internal static int __PropertyOffset_Scale;

		// Token: 0x04010951 RID: 67921
		internal static int __PropertyOffset_Orientation_DEPRECATED;

		// Token: 0x04010952 RID: 67922
		internal static int __PropertyOffset_ForwardAxis;

		// Token: 0x04010953 RID: 67923
		internal static int __PropertyOffset_UpAxis;
	}
}
