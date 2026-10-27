using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020EF RID: 8431
	[UnrealObjectPath("/Script/LGUI.MultiTemplateScrollViewTemplateInfo")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FMultiTemplateScrollViewTemplateInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FBE1 RID: 130017 RVA: 0x002F329C File Offset: 0x002F149C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMultiTemplateScrollViewTemplateInfo._ScriptStructPtr != 0) ? FMultiTemplateScrollViewTemplateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.MultiTemplateScrollViewTemplateInfo", ref FMultiTemplateScrollViewTemplateInfo._ScriptStructPtr);
		}

		// Token: 0x17007CF3 RID: 31987
		// (get) Token: 0x0601FBE2 RID: 130018 RVA: 0x002F32C0 File Offset: 0x002F14C0
		// (set) Token: 0x0601FBE3 RID: 130019 RVA: 0x002F32D0 File Offset: 0x002F14D0
		public unsafe bool bIsMultiGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_bIsMultiGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_bIsMultiGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007CF4 RID: 31988
		// (get) Token: 0x0601FBE4 RID: 130020 RVA: 0x002F32E1 File Offset: 0x002F14E1
		// (set) Token: 0x0601FBE5 RID: 130021 RVA: 0x002F32F5 File Offset: 0x002F14F5
		public unsafe FMargin AreaPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_AreaPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_AreaPadding) = value;
			}
		}

		// Token: 0x17007CF5 RID: 31989
		// (get) Token: 0x0601FBE6 RID: 130022 RVA: 0x002F330A File Offset: 0x002F150A
		// (set) Token: 0x0601FBE7 RID: 130023 RVA: 0x002F331E File Offset: 0x002F151E
		public unsafe FVector2D GridSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_GridSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_GridSpacing) = value;
			}
		}

		// Token: 0x17007CF6 RID: 31990
		// (get) Token: 0x0601FBE8 RID: 130024 RVA: 0x002F3333 File Offset: 0x002F1533
		// (set) Token: 0x0601FBE9 RID: 130025 RVA: 0x002F3347 File Offset: 0x002F1547
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> TemplateActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_TemplateActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMultiTemplateScrollViewTemplateInfo.__PropertyOffset_TemplateActor) = value;
			}
		}

		// Token: 0x0601FBEA RID: 130026 RVA: 0x002F335C File Offset: 0x002F155C
		public FMultiTemplateScrollViewTemplateInfo()
		{
		}

		// Token: 0x0601FBEB RID: 130027 RVA: 0x002F3364 File Offset: 0x002F1564
		public FMultiTemplateScrollViewTemplateInfo(bool bIsMultiGrid, FMargin AreaPadding, FVector2D GridSpacing, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AUIBaseActor> TemplateActor)
		{
			this.bIsMultiGrid = bIsMultiGrid;
			this.AreaPadding = AreaPadding;
			this.GridSpacing = GridSpacing;
			this.TemplateActor = TemplateActor;
		}

		// Token: 0x0601FBEC RID: 130028 RVA: 0x002F3389 File Offset: 0x002F1589
		protected override IntPtr GetUStructPtr()
		{
			return FMultiTemplateScrollViewTemplateInfo.StaticStruct();
		}

		// Token: 0x0601FBED RID: 130029 RVA: 0x002F3395 File Offset: 0x002F1595
		[NullableContext(2)]
		public FMultiTemplateScrollViewTemplateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FBEE RID: 130030 RVA: 0x002F339F File Offset: 0x002F159F
		public FMultiTemplateScrollViewTemplateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FBEF RID: 130031 RVA: 0x002F33AA File Offset: 0x002F15AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMultiTemplateScrollViewTemplateInfo(Pointer, false, true);
		}

		// Token: 0x0601FBF0 RID: 130032 RVA: 0x002F33B4 File Offset: 0x002F15B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMultiTemplateScrollViewTemplateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040111C7 RID: 70087
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.MultiTemplateScrollViewTemplateInfo";

		// Token: 0x040111C8 RID: 70088
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111C9 RID: 70089
		internal static int __PropertyOffset_bIsMultiGrid;

		// Token: 0x040111CA RID: 70090
		internal static int __PropertyOffset_AreaPadding;

		// Token: 0x040111CB RID: 70091
		internal static int __PropertyOffset_GridSpacing;

		// Token: 0x040111CC RID: 70092
		internal static int __PropertyOffset_TemplateActor;
	}
}
