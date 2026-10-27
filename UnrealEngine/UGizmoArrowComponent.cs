using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001544 RID: 5444
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoArrowComponent")]
	[UnrealStructLayout(1632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class UGizmoArrowComponent : UGizmoBaseComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C0B RID: 80907 RVA: 0x001D014E File Offset: 0x001CE34E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoArrowComponent._ClassPtr;
		}

		// Token: 0x06013C0C RID: 80908 RVA: 0x001D015C File Offset: 0x001CE35C
		public UGizmoArrowComponent() : this(BuiltinUtils.AllocNativeUObject(UGizmoArrowComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C0D RID: 80909 RVA: 0x001D0184 File Offset: 0x001CE384
		[NullableContext(1)]
		public UGizmoArrowComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoArrowComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D5C RID: 19804
		// (get) Token: 0x06013C0E RID: 80910 RVA: 0x001D01B7 File Offset: 0x001CE3B7
		// (set) Token: 0x06013C0F RID: 80911 RVA: 0x001D01CB File Offset: 0x001CE3CB
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x06013C10 RID: 80912 RVA: 0x001D01E0 File Offset: 0x001CE3E0
		// (set) Token: 0x06013C11 RID: 80913 RVA: 0x001D01F0 File Offset: 0x001CE3F0
		public unsafe float Gap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Gap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Gap) = value;
			}
		}

		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x06013C12 RID: 80914 RVA: 0x001D0201 File Offset: 0x001CE401
		// (set) Token: 0x06013C13 RID: 80915 RVA: 0x001D0211 File Offset: 0x001CE411
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x06013C14 RID: 80916 RVA: 0x001D0222 File Offset: 0x001CE422
		// (set) Token: 0x06013C15 RID: 80917 RVA: 0x001D0232 File Offset: 0x001CE432
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoArrowComponent.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x06013C16 RID: 80918 RVA: 0x001D0243 File Offset: 0x001CE443
		static UGizmoArrowComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoArrowComponent");
		}

		// Token: 0x06013C17 RID: 80919 RVA: 0x001D0251 File Offset: 0x001CE451
		protected UGizmoArrowComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAF8 RID: 43768
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoArrowComponent";

		// Token: 0x0400AAF9 RID: 43769
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAFA RID: 43770
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AAFB RID: 43771
		internal static int __PropertyOffset_Direction;

		// Token: 0x0400AAFC RID: 43772
		internal static int __PropertyOffset_Gap;

		// Token: 0x0400AAFD RID: 43773
		internal static int __PropertyOffset_Length;

		// Token: 0x0400AAFE RID: 43774
		internal static int __PropertyOffset_Thickness;
	}
}
