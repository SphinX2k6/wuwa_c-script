using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200027B RID: 635
	[UnrealObjectPath("/Script/Engine.ShapeComponent")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public abstract class UShapeComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060041E1 RID: 16865 RVA: 0x0005E296 File Offset: 0x0005C496
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UShapeComponent._ClassPtr;
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x0005E2A2 File Offset: 0x0005C4A2
		// (set) Token: 0x060041E3 RID: 16867 RVA: 0x0005E2B6 File Offset: 0x0005C4B6
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

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x0005E2CB File Offset: 0x0005C4CB
		// (set) Token: 0x060041E5 RID: 16869 RVA: 0x0005E2DF File Offset: 0x0005C4DF
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

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x0005E2F4 File Offset: 0x0005C4F4
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x0005E30D File Offset: 0x0005C50D
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

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x0005E33D File Offset: 0x0005C53D
		// (set) Token: 0x060041E9 RID: 16873 RVA: 0x0005E356 File Offset: 0x0005C556
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

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x0005E386 File Offset: 0x0005C586
		// (set) Token: 0x060041EB RID: 16875 RVA: 0x0005E39F File Offset: 0x0005C59F
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

		// Token: 0x060041EC RID: 16876 RVA: 0x0005E3CF File Offset: 0x0005C5CF
		static UShapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ShapeComponent");
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x0005E3E0 File Offset: 0x0005C5E0
		protected UShapeComponent() : this(BuiltinUtils.AllocNativeUObject(UShapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x0005E408 File Offset: 0x0005C608
		protected UShapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040019BD RID: 6589
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ShapeComponent";

		// Token: 0x040019BE RID: 6590
		private static IntPtr _ClassPtr;

		// Token: 0x040019BF RID: 6591
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040019C0 RID: 6592
		internal static int __PropertyOffset_ShapeBodySetup;

		// Token: 0x040019C1 RID: 6593
		internal static int __PropertyOffset_ShapeColor;

		// Token: 0x040019C2 RID: 6594
		internal static int __PropertyOffset_bDrawOnlyIfSelected;

		// Token: 0x040019C3 RID: 6595
		internal static byte __PropertyMask_bDrawOnlyIfSelected;

		// Token: 0x040019C4 RID: 6596
		internal static int __PropertyOffset_bShouldCollideWhenPlacing;

		// Token: 0x040019C5 RID: 6597
		internal static byte __PropertyMask_bShouldCollideWhenPlacing;

		// Token: 0x040019C6 RID: 6598
		internal static int __PropertyOffset_bDynamicObstacle;

		// Token: 0x040019C7 RID: 6599
		internal static byte __PropertyMask_bDynamicObstacle;
	}
}
