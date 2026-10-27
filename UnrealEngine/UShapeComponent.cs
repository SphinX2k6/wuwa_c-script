using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010E7 RID: 4327
	[UnrealObjectPath("/Script/Engine.ShapeComponent")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public abstract class UShapeComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F85B RID: 63579 RVA: 0x0016F52F File Offset: 0x0016D72F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UShapeComponent._ClassPtr;
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0600F85C RID: 63580 RVA: 0x0016F53B File Offset: 0x0016D73B
		// (set) Token: 0x0600F85D RID: 63581 RVA: 0x0016F54F File Offset: 0x0016D74F
		[Nullable(2)]
		public unsafe UBodySetup ShapeBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UShapeComponent.__PropertyOffset_ShapeBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UShapeComponent.__PropertyOffset_ShapeBodySetup, value);
			}
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600F85E RID: 63582 RVA: 0x0016F564 File Offset: 0x0016D764
		// (set) Token: 0x0600F85F RID: 63583 RVA: 0x0016F578 File Offset: 0x0016D778
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavAreaBase> AreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_AreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_AreaClass) = value;
			}
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600F860 RID: 63584 RVA: 0x0016F58D File Offset: 0x0016D78D
		// (set) Token: 0x0600F861 RID: 63585 RVA: 0x0016F5A1 File Offset: 0x0016D7A1
		public unsafe FColor ShapeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_ShapeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_ShapeColor) = value;
			}
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0600F862 RID: 63586 RVA: 0x0016F5B6 File Offset: 0x0016D7B6
		// (set) Token: 0x0600F863 RID: 63587 RVA: 0x0016F5CF File Offset: 0x0016D7CF
		public unsafe bool bDrawOnlyIfSelected
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bDrawOnlyIfSelected) & UShapeComponent.__PropertyMask_bDrawOnlyIfSelected) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bDrawOnlyIfSelected) = ((*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bDrawOnlyIfSelected) & ~UShapeComponent.__PropertyMask_bDrawOnlyIfSelected) | (value ? UShapeComponent.__PropertyMask_bDrawOnlyIfSelected : 0));
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0600F864 RID: 63588 RVA: 0x0016F5FF File Offset: 0x0016D7FF
		// (set) Token: 0x0600F865 RID: 63589 RVA: 0x0016F618 File Offset: 0x0016D818
		public unsafe bool bShouldCollideWhenPlacing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bShouldCollideWhenPlacing) & UShapeComponent.__PropertyMask_bShouldCollideWhenPlacing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bShouldCollideWhenPlacing) = ((*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bShouldCollideWhenPlacing) & ~UShapeComponent.__PropertyMask_bShouldCollideWhenPlacing) | (value ? UShapeComponent.__PropertyMask_bShouldCollideWhenPlacing : 0));
			}
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0600F866 RID: 63590 RVA: 0x0016F648 File Offset: 0x0016D848
		// (set) Token: 0x0600F867 RID: 63591 RVA: 0x0016F661 File Offset: 0x0016D861
		public unsafe bool bDynamicObstacle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bDynamicObstacle) & UShapeComponent.__PropertyMask_bDynamicObstacle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bDynamicObstacle) = ((*(base.NativePtr + (IntPtr)UShapeComponent.__PropertyOffset_bDynamicObstacle) & ~UShapeComponent.__PropertyMask_bDynamicObstacle) | (value ? UShapeComponent.__PropertyMask_bDynamicObstacle : 0));
			}
		}

		// Token: 0x0600F868 RID: 63592 RVA: 0x0016F691 File Offset: 0x0016D891
		static UShapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ShapeComponent");
		}

		// Token: 0x0600F869 RID: 63593 RVA: 0x0016F6A0 File Offset: 0x0016D8A0
		protected UShapeComponent() : this(BuiltinUtils.AllocNativeUObject(UShapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F86A RID: 63594 RVA: 0x0016F6C8 File Offset: 0x0016D8C8
		protected UShapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400862B RID: 34347
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ShapeComponent";

		// Token: 0x0400862C RID: 34348
		private static IntPtr _ClassPtr;

		// Token: 0x0400862D RID: 34349
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400862E RID: 34350
		internal static int __PropertyOffset_ShapeBodySetup;

		// Token: 0x0400862F RID: 34351
		internal static int __PropertyOffset_AreaClass;

		// Token: 0x04008630 RID: 34352
		internal static int __PropertyOffset_ShapeColor;

		// Token: 0x04008631 RID: 34353
		internal static int __PropertyOffset_bDrawOnlyIfSelected;

		// Token: 0x04008632 RID: 34354
		internal static byte __PropertyMask_bDrawOnlyIfSelected;

		// Token: 0x04008633 RID: 34355
		internal static int __PropertyOffset_bShouldCollideWhenPlacing;

		// Token: 0x04008634 RID: 34356
		internal static byte __PropertyMask_bShouldCollideWhenPlacing;

		// Token: 0x04008635 RID: 34357
		internal static int __PropertyOffset_bDynamicObstacle;

		// Token: 0x04008636 RID: 34358
		internal static byte __PropertyMask_bDynamicObstacle;
	}
}
