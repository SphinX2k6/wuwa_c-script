using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014CC RID: 5324
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputCameraComponent")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UHoudiniInputCameraComponent : UHoudiniInputSceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134D6 RID: 79062 RVA: 0x001C61ED File Offset: 0x001C43ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputCameraComponent._ClassPtr;
		}

		// Token: 0x060134D7 RID: 79063 RVA: 0x001C61FC File Offset: 0x001C43FC
		public UHoudiniInputCameraComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputCameraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134D8 RID: 79064 RVA: 0x001C6224 File Offset: 0x001C4424
		[NullableContext(1)]
		public UHoudiniInputCameraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputCameraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x060134D9 RID: 79065 RVA: 0x001C6257 File Offset: 0x001C4457
		// (set) Token: 0x060134DA RID: 79066 RVA: 0x001C6267 File Offset: 0x001C4467
		public unsafe float FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_FOV) = value;
			}
		}

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x060134DB RID: 79067 RVA: 0x001C6278 File Offset: 0x001C4478
		// (set) Token: 0x060134DC RID: 79068 RVA: 0x001C6288 File Offset: 0x001C4488
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x060134DD RID: 79069 RVA: 0x001C6299 File Offset: 0x001C4499
		// (set) Token: 0x060134DE RID: 79070 RVA: 0x001C62A9 File Offset: 0x001C44A9
		public unsafe bool bIsOrthographic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_bIsOrthographic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_bIsOrthographic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x060134DF RID: 79071 RVA: 0x001C62BA File Offset: 0x001C44BA
		// (set) Token: 0x060134E0 RID: 79072 RVA: 0x001C62CA File Offset: 0x001C44CA
		public unsafe float OrthoWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_OrthoWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_OrthoWidth) = value;
			}
		}

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x060134E1 RID: 79073 RVA: 0x001C62DB File Offset: 0x001C44DB
		// (set) Token: 0x060134E2 RID: 79074 RVA: 0x001C62EB File Offset: 0x001C44EB
		public unsafe float OrthoNearClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_OrthoNearClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_OrthoNearClipPlane) = value;
			}
		}

		// Token: 0x17004B44 RID: 19268
		// (get) Token: 0x060134E3 RID: 79075 RVA: 0x001C62FC File Offset: 0x001C44FC
		// (set) Token: 0x060134E4 RID: 79076 RVA: 0x001C630C File Offset: 0x001C450C
		public unsafe float OrthoFarClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_OrthoFarClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputCameraComponent.__PropertyOffset_OrthoFarClipPlane) = value;
			}
		}

		// Token: 0x060134E5 RID: 79077 RVA: 0x001C631D File Offset: 0x001C451D
		static UHoudiniInputCameraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputCameraComponent");
		}

		// Token: 0x060134E6 RID: 79078 RVA: 0x001C632B File Offset: 0x001C452B
		protected UHoudiniInputCameraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6D0 RID: 42704
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputCameraComponent";

		// Token: 0x0400A6D1 RID: 42705
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6D2 RID: 42706
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6D3 RID: 42707
		internal static int __PropertyOffset_FOV;

		// Token: 0x0400A6D4 RID: 42708
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x0400A6D5 RID: 42709
		internal static int __PropertyOffset_bIsOrthographic;

		// Token: 0x0400A6D6 RID: 42710
		internal static int __PropertyOffset_OrthoWidth;

		// Token: 0x0400A6D7 RID: 42711
		internal static int __PropertyOffset_OrthoNearClipPlane;

		// Token: 0x0400A6D8 RID: 42712
		internal static int __PropertyOffset_OrthoFarClipPlane;
	}
}
