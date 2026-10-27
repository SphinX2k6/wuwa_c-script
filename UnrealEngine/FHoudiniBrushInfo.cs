using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014BD RID: 5309
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniBrushInfo")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FHoudiniBrushInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601336E RID: 78702 RVA: 0x001C4344 File Offset: 0x001C2544
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniBrushInfo._ScriptStructPtr != 0) ? FHoudiniBrushInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniBrushInfo", ref FHoudiniBrushInfo._ScriptStructPtr);
		}

		// Token: 0x17004AB8 RID: 19128
		// (get) Token: 0x0601336F RID: 78703 RVA: 0x001C4368 File Offset: 0x001C2568
		// (set) Token: 0x06013370 RID: 78704 RVA: 0x001C437C File Offset: 0x001C257C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<ABrush> BrushActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_BrushActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_BrushActor) = value;
			}
		}

		// Token: 0x17004AB9 RID: 19129
		// (get) Token: 0x06013371 RID: 78705 RVA: 0x001C4391 File Offset: 0x001C2591
		// (set) Token: 0x06013372 RID: 78706 RVA: 0x001C43A5 File Offset: 0x001C25A5
		public unsafe FTransform CachedTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedTransform) = value;
			}
		}

		// Token: 0x17004ABA RID: 19130
		// (get) Token: 0x06013373 RID: 78707 RVA: 0x001C43BA File Offset: 0x001C25BA
		// (set) Token: 0x06013374 RID: 78708 RVA: 0x001C43CE File Offset: 0x001C25CE
		public unsafe FVector CachedOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedOrigin) = value;
			}
		}

		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x06013375 RID: 78709 RVA: 0x001C43E3 File Offset: 0x001C25E3
		// (set) Token: 0x06013376 RID: 78710 RVA: 0x001C43F7 File Offset: 0x001C25F7
		public unsafe FVector CachedExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedExtent) = value;
			}
		}

		// Token: 0x17004ABC RID: 19132
		// (get) Token: 0x06013377 RID: 78711 RVA: 0x001C440C File Offset: 0x001C260C
		// (set) Token: 0x06013378 RID: 78712 RVA: 0x001C4420 File Offset: 0x001C2620
		public unsafe TEnumAsByte<EBrushType> CachedBrushType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedBrushType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedBrushType) = value;
			}
		}

		// Token: 0x17004ABD RID: 19133
		// (get) Token: 0x06013379 RID: 78713 RVA: 0x001C4435 File Offset: 0x001C2635
		// (set) Token: 0x0601337A RID: 78714 RVA: 0x001C4445 File Offset: 0x001C2645
		public unsafe ulong CachedSurfaceHash
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedSurfaceHash));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniBrushInfo.__PropertyOffset_CachedSurfaceHash) = (long)value;
			}
		}

		// Token: 0x0601337B RID: 78715 RVA: 0x001C4456 File Offset: 0x001C2656
		public FHoudiniBrushInfo()
		{
		}

		// Token: 0x0601337C RID: 78716 RVA: 0x001C445E File Offset: 0x001C265E
		public FHoudiniBrushInfo([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<ABrush> BrushActor, FTransform CachedTransform, FVector CachedOrigin, FVector CachedExtent, TEnumAsByte<EBrushType> CachedBrushType, ulong CachedSurfaceHash)
		{
			this.BrushActor = BrushActor;
			this.CachedTransform = CachedTransform;
			this.CachedOrigin = CachedOrigin;
			this.CachedExtent = CachedExtent;
			this.CachedBrushType = CachedBrushType;
			this.CachedSurfaceHash = CachedSurfaceHash;
		}

		// Token: 0x0601337D RID: 78717 RVA: 0x001C4493 File Offset: 0x001C2693
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniBrushInfo.StaticStruct();
		}

		// Token: 0x0601337E RID: 78718 RVA: 0x001C449F File Offset: 0x001C269F
		[NullableContext(2)]
		public FHoudiniBrushInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601337F RID: 78719 RVA: 0x001C44A9 File Offset: 0x001C26A9
		public FHoudiniBrushInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013380 RID: 78720 RVA: 0x001C44B4 File Offset: 0x001C26B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniBrushInfo(Pointer, false, true);
		}

		// Token: 0x06013381 RID: 78721 RVA: 0x001C44BE File Offset: 0x001C26BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniBrushInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400A608 RID: 42504
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniBrushInfo";

		// Token: 0x0400A609 RID: 42505
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A60A RID: 42506
		internal static int __PropertyOffset_BrushActor;

		// Token: 0x0400A60B RID: 42507
		internal static int __PropertyOffset_CachedTransform;

		// Token: 0x0400A60C RID: 42508
		internal static int __PropertyOffset_CachedOrigin;

		// Token: 0x0400A60D RID: 42509
		internal static int __PropertyOffset_CachedExtent;

		// Token: 0x0400A60E RID: 42510
		internal static int __PropertyOffset_CachedBrushType;

		// Token: 0x0400A60F RID: 42511
		internal static int __PropertyOffset_CachedSurfaceHash;
	}
}
