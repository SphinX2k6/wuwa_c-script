using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001562 RID: 5474
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoRectangleComponent")]
	[UnrealStructLayout(1648, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public class UGizmoRectangleComponent : UGizmoBaseComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D5A RID: 81242 RVA: 0x001D203E File Offset: 0x001D023E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoRectangleComponent._ClassPtr;
		}

		// Token: 0x06013D5B RID: 81243 RVA: 0x001D204C File Offset: 0x001D024C
		public UGizmoRectangleComponent() : this(BuiltinUtils.AllocNativeUObject(UGizmoRectangleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D5C RID: 81244 RVA: 0x001D2074 File Offset: 0x001D0274
		[NullableContext(1)]
		public UGizmoRectangleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoRectangleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DB3 RID: 19891
		// (get) Token: 0x06013D5D RID: 81245 RVA: 0x001D20A7 File Offset: 0x001D02A7
		// (set) Token: 0x06013D5E RID: 81246 RVA: 0x001D20BB File Offset: 0x001D02BB
		public unsafe FVector DirectionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_DirectionX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_DirectionX) = value;
			}
		}

		// Token: 0x17004DB4 RID: 19892
		// (get) Token: 0x06013D5F RID: 81247 RVA: 0x001D20D0 File Offset: 0x001D02D0
		// (set) Token: 0x06013D60 RID: 81248 RVA: 0x001D20E4 File Offset: 0x001D02E4
		public unsafe FVector DirectionY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_DirectionY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_DirectionY) = value;
			}
		}

		// Token: 0x17004DB5 RID: 19893
		// (get) Token: 0x06013D61 RID: 81249 RVA: 0x001D20F9 File Offset: 0x001D02F9
		// (set) Token: 0x06013D62 RID: 81250 RVA: 0x001D2109 File Offset: 0x001D0309
		public unsafe float OffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_OffsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_OffsetX) = value;
			}
		}

		// Token: 0x17004DB6 RID: 19894
		// (get) Token: 0x06013D63 RID: 81251 RVA: 0x001D211A File Offset: 0x001D031A
		// (set) Token: 0x06013D64 RID: 81252 RVA: 0x001D212A File Offset: 0x001D032A
		public unsafe float OffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_OffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_OffsetY) = value;
			}
		}

		// Token: 0x17004DB7 RID: 19895
		// (get) Token: 0x06013D65 RID: 81253 RVA: 0x001D213B File Offset: 0x001D033B
		// (set) Token: 0x06013D66 RID: 81254 RVA: 0x001D214B File Offset: 0x001D034B
		public unsafe float LengthX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_LengthX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_LengthX) = value;
			}
		}

		// Token: 0x17004DB8 RID: 19896
		// (get) Token: 0x06013D67 RID: 81255 RVA: 0x001D215C File Offset: 0x001D035C
		// (set) Token: 0x06013D68 RID: 81256 RVA: 0x001D216C File Offset: 0x001D036C
		public unsafe float LengthY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_LengthY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_LengthY) = value;
			}
		}

		// Token: 0x17004DB9 RID: 19897
		// (get) Token: 0x06013D69 RID: 81257 RVA: 0x001D217D File Offset: 0x001D037D
		// (set) Token: 0x06013D6A RID: 81258 RVA: 0x001D218D File Offset: 0x001D038D
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17004DBA RID: 19898
		// (get) Token: 0x06013D6B RID: 81259 RVA: 0x001D219E File Offset: 0x001D039E
		// (set) Token: 0x06013D6C RID: 81260 RVA: 0x001D21AE File Offset: 0x001D03AE
		public unsafe byte SegmentFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_SegmentFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoRectangleComponent.__PropertyOffset_SegmentFlags) = value;
			}
		}

		// Token: 0x06013D6D RID: 81261 RVA: 0x001D21BF File Offset: 0x001D03BF
		static UGizmoRectangleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoRectangleComponent");
		}

		// Token: 0x06013D6E RID: 81262 RVA: 0x001D21CD File Offset: 0x001D03CD
		protected UGizmoRectangleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABB2 RID: 43954
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoRectangleComponent";

		// Token: 0x0400ABB3 RID: 43955
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABB4 RID: 43956
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABB5 RID: 43957
		internal static int __PropertyOffset_DirectionX;

		// Token: 0x0400ABB6 RID: 43958
		internal static int __PropertyOffset_DirectionY;

		// Token: 0x0400ABB7 RID: 43959
		internal static int __PropertyOffset_OffsetX;

		// Token: 0x0400ABB8 RID: 43960
		internal static int __PropertyOffset_OffsetY;

		// Token: 0x0400ABB9 RID: 43961
		internal static int __PropertyOffset_LengthX;

		// Token: 0x0400ABBA RID: 43962
		internal static int __PropertyOffset_LengthY;

		// Token: 0x0400ABBB RID: 43963
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400ABBC RID: 43964
		internal static int __PropertyOffset_SegmentFlags;
	}
}
