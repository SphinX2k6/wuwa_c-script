using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001175 RID: 4469
	[UnrealObjectPath("/Script/Engine.SphereReflectionCaptureComponent")]
	[UnrealStructLayout(784, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 784)]
	public class USphereReflectionCaptureComponent : UReflectionCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601052D RID: 66861 RVA: 0x00180B6B File Offset: 0x0017ED6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USphereReflectionCaptureComponent._ClassPtr;
		}

		// Token: 0x0601052E RID: 66862 RVA: 0x00180B78 File Offset: 0x0017ED78
		public USphereReflectionCaptureComponent() : this(BuiltinUtils.AllocNativeUObject(USphereReflectionCaptureComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601052F RID: 66863 RVA: 0x00180BA0 File Offset: 0x0017EDA0
		[NullableContext(1)]
		public USphereReflectionCaptureComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USphereReflectionCaptureComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x06010530 RID: 66864 RVA: 0x00180BD3 File Offset: 0x0017EDD3
		// (set) Token: 0x06010531 RID: 66865 RVA: 0x00180BE3 File Offset: 0x0017EDE3
		public unsafe float InfluenceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USphereReflectionCaptureComponent.__PropertyOffset_InfluenceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USphereReflectionCaptureComponent.__PropertyOffset_InfluenceRadius) = value;
			}
		}

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x06010532 RID: 66866 RVA: 0x00180BF4 File Offset: 0x0017EDF4
		// (set) Token: 0x06010533 RID: 66867 RVA: 0x00180C04 File Offset: 0x0017EE04
		public unsafe float CaptureDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USphereReflectionCaptureComponent.__PropertyOffset_CaptureDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USphereReflectionCaptureComponent.__PropertyOffset_CaptureDistanceScale) = value;
			}
		}

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x06010534 RID: 66868 RVA: 0x00180C15 File Offset: 0x0017EE15
		// (set) Token: 0x06010535 RID: 66869 RVA: 0x00180C29 File Offset: 0x0017EE29
		[Nullable(2)]
		public unsafe UDrawSphereComponent PreviewInfluenceRadius
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDrawSphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USphereReflectionCaptureComponent.__PropertyOffset_PreviewInfluenceRadius);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USphereReflectionCaptureComponent.__PropertyOffset_PreviewInfluenceRadius, value);
			}
		}

		// Token: 0x06010536 RID: 66870 RVA: 0x00180C3E File Offset: 0x0017EE3E
		static USphereReflectionCaptureComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SphereReflectionCaptureComponent");
		}

		// Token: 0x06010537 RID: 66871 RVA: 0x00180C4C File Offset: 0x0017EE4C
		protected USphereReflectionCaptureComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C75 RID: 35957
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SphereReflectionCaptureComponent";

		// Token: 0x04008C76 RID: 35958
		private static IntPtr _ClassPtr;

		// Token: 0x04008C77 RID: 35959
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C78 RID: 35960
		internal static int __PropertyOffset_InfluenceRadius;

		// Token: 0x04008C79 RID: 35961
		internal static int __PropertyOffset_CaptureDistanceScale;

		// Token: 0x04008C7A RID: 35962
		internal static int __PropertyOffset_PreviewInfluenceRadius;
	}
}
