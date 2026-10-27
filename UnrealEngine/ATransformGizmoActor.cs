using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200159F RID: 5535
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.TransformGizmoActor")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class ATransformGizmoActor : AGizmoActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013F2B RID: 81707 RVA: 0x001D4A67 File Offset: 0x001D2C67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATransformGizmoActor._ClassPtr;
		}

		// Token: 0x06013F2C RID: 81708 RVA: 0x001D4A74 File Offset: 0x001D2C74
		public ATransformGizmoActor() : this(BuiltinUtils.AllocNativeUObject(ATransformGizmoActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013F2D RID: 81709 RVA: 0x001D4A9C File Offset: 0x001D2C9C
		[NullableContext(1)]
		public ATransformGizmoActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATransformGizmoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E18 RID: 19992
		// (get) Token: 0x06013F2E RID: 81710 RVA: 0x001D4ACF File Offset: 0x001D2CCF
		// (set) Token: 0x06013F2F RID: 81711 RVA: 0x001D4AE3 File Offset: 0x001D2CE3
		public unsafe UPrimitiveComponent TranslateX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateX, value);
			}
		}

		// Token: 0x17004E19 RID: 19993
		// (get) Token: 0x06013F30 RID: 81712 RVA: 0x001D4AF8 File Offset: 0x001D2CF8
		// (set) Token: 0x06013F31 RID: 81713 RVA: 0x001D4B0C File Offset: 0x001D2D0C
		public unsafe UPrimitiveComponent TranslateY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateY);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateY, value);
			}
		}

		// Token: 0x17004E1A RID: 19994
		// (get) Token: 0x06013F32 RID: 81714 RVA: 0x001D4B21 File Offset: 0x001D2D21
		// (set) Token: 0x06013F33 RID: 81715 RVA: 0x001D4B35 File Offset: 0x001D2D35
		public unsafe UPrimitiveComponent TranslateZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateZ);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateZ, value);
			}
		}

		// Token: 0x17004E1B RID: 19995
		// (get) Token: 0x06013F34 RID: 81716 RVA: 0x001D4B4A File Offset: 0x001D2D4A
		// (set) Token: 0x06013F35 RID: 81717 RVA: 0x001D4B5E File Offset: 0x001D2D5E
		public unsafe UPrimitiveComponent TranslateYZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateYZ);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateYZ, value);
			}
		}

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x06013F36 RID: 81718 RVA: 0x001D4B73 File Offset: 0x001D2D73
		// (set) Token: 0x06013F37 RID: 81719 RVA: 0x001D4B87 File Offset: 0x001D2D87
		public unsafe UPrimitiveComponent TranslateXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateXZ);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateXZ, value);
			}
		}

		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x06013F38 RID: 81720 RVA: 0x001D4B9C File Offset: 0x001D2D9C
		// (set) Token: 0x06013F39 RID: 81721 RVA: 0x001D4BB0 File Offset: 0x001D2DB0
		public unsafe UPrimitiveComponent TranslateXY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateXY);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_TranslateXY, value);
			}
		}

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x06013F3A RID: 81722 RVA: 0x001D4BC5 File Offset: 0x001D2DC5
		// (set) Token: 0x06013F3B RID: 81723 RVA: 0x001D4BD9 File Offset: 0x001D2DD9
		public unsafe UPrimitiveComponent RotateX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotateX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotateX, value);
			}
		}

		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x06013F3C RID: 81724 RVA: 0x001D4BEE File Offset: 0x001D2DEE
		// (set) Token: 0x06013F3D RID: 81725 RVA: 0x001D4C02 File Offset: 0x001D2E02
		public unsafe UPrimitiveComponent RotateY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotateY);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotateY, value);
			}
		}

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x06013F3E RID: 81726 RVA: 0x001D4C17 File Offset: 0x001D2E17
		// (set) Token: 0x06013F3F RID: 81727 RVA: 0x001D4C2B File Offset: 0x001D2E2B
		public unsafe UPrimitiveComponent RotateZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotateZ);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotateZ, value);
			}
		}

		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x06013F40 RID: 81728 RVA: 0x001D4C40 File Offset: 0x001D2E40
		// (set) Token: 0x06013F41 RID: 81729 RVA: 0x001D4C54 File Offset: 0x001D2E54
		public unsafe UPrimitiveComponent RotationSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotationSphere);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_RotationSphere, value);
			}
		}

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x06013F42 RID: 81730 RVA: 0x001D4C69 File Offset: 0x001D2E69
		// (set) Token: 0x06013F43 RID: 81731 RVA: 0x001D4C7D File Offset: 0x001D2E7D
		public unsafe UPrimitiveComponent FreeRotateHandle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_FreeRotateHandle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_FreeRotateHandle, value);
			}
		}

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x06013F44 RID: 81732 RVA: 0x001D4C92 File Offset: 0x001D2E92
		// (set) Token: 0x06013F45 RID: 81733 RVA: 0x001D4CA6 File Offset: 0x001D2EA6
		public unsafe UPrimitiveComponent FreeTranslateHandle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_FreeTranslateHandle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_FreeTranslateHandle, value);
			}
		}

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x06013F46 RID: 81734 RVA: 0x001D4CBB File Offset: 0x001D2EBB
		// (set) Token: 0x06013F47 RID: 81735 RVA: 0x001D4CCF File Offset: 0x001D2ECF
		public unsafe UPrimitiveComponent UniformScale
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_UniformScale);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_UniformScale, value);
			}
		}

		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x06013F48 RID: 81736 RVA: 0x001D4CE4 File Offset: 0x001D2EE4
		// (set) Token: 0x06013F49 RID: 81737 RVA: 0x001D4CF8 File Offset: 0x001D2EF8
		public unsafe UPrimitiveComponent AxisScaleX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_AxisScaleX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_AxisScaleX, value);
			}
		}

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x06013F4A RID: 81738 RVA: 0x001D4D0D File Offset: 0x001D2F0D
		// (set) Token: 0x06013F4B RID: 81739 RVA: 0x001D4D21 File Offset: 0x001D2F21
		public unsafe UPrimitiveComponent AxisScaleY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_AxisScaleY);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_AxisScaleY, value);
			}
		}

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x06013F4C RID: 81740 RVA: 0x001D4D36 File Offset: 0x001D2F36
		// (set) Token: 0x06013F4D RID: 81741 RVA: 0x001D4D4A File Offset: 0x001D2F4A
		public unsafe UPrimitiveComponent AxisScaleZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_AxisScaleZ);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_AxisScaleZ, value);
			}
		}

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x06013F4E RID: 81742 RVA: 0x001D4D5F File Offset: 0x001D2F5F
		// (set) Token: 0x06013F4F RID: 81743 RVA: 0x001D4D73 File Offset: 0x001D2F73
		public unsafe UPrimitiveComponent PlaneScaleYZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_PlaneScaleYZ);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_PlaneScaleYZ, value);
			}
		}

		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x06013F50 RID: 81744 RVA: 0x001D4D88 File Offset: 0x001D2F88
		// (set) Token: 0x06013F51 RID: 81745 RVA: 0x001D4D9C File Offset: 0x001D2F9C
		public unsafe UPrimitiveComponent PlaneScaleXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_PlaneScaleXZ);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_PlaneScaleXZ, value);
			}
		}

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x06013F52 RID: 81746 RVA: 0x001D4DB1 File Offset: 0x001D2FB1
		// (set) Token: 0x06013F53 RID: 81747 RVA: 0x001D4DC5 File Offset: 0x001D2FC5
		public unsafe UPrimitiveComponent PlaneScaleXY
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_PlaneScaleXY);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransformGizmoActor.__PropertyOffset_PlaneScaleXY, value);
			}
		}

		// Token: 0x06013F54 RID: 81748 RVA: 0x001D4DDA File Offset: 0x001D2FDA
		static ATransformGizmoActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.TransformGizmoActor");
		}

		// Token: 0x06013F55 RID: 81749 RVA: 0x001D4DE8 File Offset: 0x001D2FE8
		protected ATransformGizmoActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACC6 RID: 44230
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.TransformGizmoActor";

		// Token: 0x0400ACC7 RID: 44231
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACC8 RID: 44232
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ACC9 RID: 44233
		internal static int __PropertyOffset_TranslateX;

		// Token: 0x0400ACCA RID: 44234
		internal static int __PropertyOffset_TranslateY;

		// Token: 0x0400ACCB RID: 44235
		internal static int __PropertyOffset_TranslateZ;

		// Token: 0x0400ACCC RID: 44236
		internal static int __PropertyOffset_TranslateYZ;

		// Token: 0x0400ACCD RID: 44237
		internal static int __PropertyOffset_TranslateXZ;

		// Token: 0x0400ACCE RID: 44238
		internal static int __PropertyOffset_TranslateXY;

		// Token: 0x0400ACCF RID: 44239
		internal static int __PropertyOffset_RotateX;

		// Token: 0x0400ACD0 RID: 44240
		internal static int __PropertyOffset_RotateY;

		// Token: 0x0400ACD1 RID: 44241
		internal static int __PropertyOffset_RotateZ;

		// Token: 0x0400ACD2 RID: 44242
		internal static int __PropertyOffset_RotationSphere;

		// Token: 0x0400ACD3 RID: 44243
		internal static int __PropertyOffset_FreeRotateHandle;

		// Token: 0x0400ACD4 RID: 44244
		internal static int __PropertyOffset_FreeTranslateHandle;

		// Token: 0x0400ACD5 RID: 44245
		internal static int __PropertyOffset_UniformScale;

		// Token: 0x0400ACD6 RID: 44246
		internal static int __PropertyOffset_AxisScaleX;

		// Token: 0x0400ACD7 RID: 44247
		internal static int __PropertyOffset_AxisScaleY;

		// Token: 0x0400ACD8 RID: 44248
		internal static int __PropertyOffset_AxisScaleZ;

		// Token: 0x0400ACD9 RID: 44249
		internal static int __PropertyOffset_PlaneScaleYZ;

		// Token: 0x0400ACDA RID: 44250
		internal static int __PropertyOffset_PlaneScaleXZ;

		// Token: 0x0400ACDB RID: 44251
		internal static int __PropertyOffset_PlaneScaleXY;
	}
}
