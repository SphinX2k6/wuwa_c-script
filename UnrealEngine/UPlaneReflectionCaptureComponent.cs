using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF1 RID: 4081
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlaneReflectionCaptureComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD1E RID: 56606 RVA: 0x001458F9 File Offset: 0x00143AF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlaneReflectionCaptureComponent._ClassPtr;
		}

		// Token: 0x0600DD1F RID: 56607 RVA: 0x00145908 File Offset: 0x00143B08
		public UPlaneReflectionCaptureComponent() : this(BuiltinUtils.AllocNativeUObject(UPlaneReflectionCaptureComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x00145930 File Offset: 0x00143B30
		[NullableContext(1)]
		public UPlaneReflectionCaptureComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlaneReflectionCaptureComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600DD21 RID: 56609 RVA: 0x00145963 File Offset: 0x00143B63
		// (set) Token: 0x0600DD22 RID: 56610 RVA: 0x00145973 File Offset: 0x00143B73
		public unsafe float InfluenceRadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlaneReflectionCaptureComponent.__PropertyOffset_InfluenceRadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlaneReflectionCaptureComponent.__PropertyOffset_InfluenceRadiusScale) = value;
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600DD23 RID: 56611 RVA: 0x00145984 File Offset: 0x00143B84
		// (set) Token: 0x0600DD24 RID: 56612 RVA: 0x00145998 File Offset: 0x00143B98
		public unsafe UDrawSphereComponent PreviewInfluenceRadius
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDrawSphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPlaneReflectionCaptureComponent.__PropertyOffset_PreviewInfluenceRadius);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPlaneReflectionCaptureComponent.__PropertyOffset_PreviewInfluenceRadius, value);
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600DD25 RID: 56613 RVA: 0x001459AD File Offset: 0x00143BAD
		// (set) Token: 0x0600DD26 RID: 56614 RVA: 0x001459C1 File Offset: 0x00143BC1
		public unsafe UBoxComponent PreviewCaptureBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPlaneReflectionCaptureComponent.__PropertyOffset_PreviewCaptureBox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPlaneReflectionCaptureComponent.__PropertyOffset_PreviewCaptureBox, value);
			}
		}

		// Token: 0x0600DD27 RID: 56615 RVA: 0x001459D6 File Offset: 0x00143BD6
		static UPlaneReflectionCaptureComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlaneReflectionCaptureComponent");
		}

		// Token: 0x0600DD28 RID: 56616 RVA: 0x001459E4 File Offset: 0x00143BE4
		protected UPlaneReflectionCaptureComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007785 RID: 30597
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlaneReflectionCaptureComponent";

		// Token: 0x04007786 RID: 30598
		private static IntPtr _ClassPtr;

		// Token: 0x04007787 RID: 30599
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007788 RID: 30600
		internal static int __PropertyOffset_InfluenceRadiusScale;

		// Token: 0x04007789 RID: 30601
		internal static int __PropertyOffset_PreviewInfluenceRadius;

		// Token: 0x0400778A RID: 30602
		internal static int __PropertyOffset_PreviewCaptureBox;
	}
}
