using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000911 RID: 2321
	[UnrealObjectPath("/Script/Engine.CameraShakeBase")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UCameraShakeBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FC0 RID: 32704 RVA: 0x000B71C9 File Offset: 0x000B53C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraShakeBase._ClassPtr;
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x06007FC1 RID: 32705 RVA: 0x000B71D5 File Offset: 0x000B53D5
		// (set) Token: 0x06007FC2 RID: 32706 RVA: 0x000B71E5 File Offset: 0x000B53E5
		public unsafe bool bSingleInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraShakeBase.__PropertyOffset_bSingleInstance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeBase.__PropertyOffset_bSingleInstance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x06007FC3 RID: 32707 RVA: 0x000B71F6 File Offset: 0x000B53F6
		// (set) Token: 0x06007FC4 RID: 32708 RVA: 0x000B7206 File Offset: 0x000B5406
		public unsafe float ShakeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraShakeBase.__PropertyOffset_ShakeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeBase.__PropertyOffset_ShakeScale) = value;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x06007FC5 RID: 32709 RVA: 0x000B7217 File Offset: 0x000B5417
		// (set) Token: 0x06007FC6 RID: 32710 RVA: 0x000B7227 File Offset: 0x000B5427
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraShakeBase.__PropertyOffset_TimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraShakeBase.__PropertyOffset_TimeDilation) = value;
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x000B7238 File Offset: 0x000B5438
		// (set) Token: 0x06007FC8 RID: 32712 RVA: 0x000B724C File Offset: 0x000B544C
		[Nullable(2)]
		public unsafe APlayerCameraManager CameraManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerCameraManager>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraShakeBase.__PropertyOffset_CameraManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraShakeBase.__PropertyOffset_CameraManager, value);
			}
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x000B7261 File Offset: 0x000B5461
		static UCameraShakeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraShakeBase");
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x000B7270 File Offset: 0x000B5470
		protected UCameraShakeBase() : this(BuiltinUtils.AllocNativeUObject(UCameraShakeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x000B7298 File Offset: 0x000B5498
		protected UCameraShakeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D3E RID: 15678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraShakeBase";

		// Token: 0x04003D3F RID: 15679
		private static IntPtr _ClassPtr;

		// Token: 0x04003D40 RID: 15680
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D41 RID: 15681
		internal static int __PropertyOffset_bSingleInstance;

		// Token: 0x04003D42 RID: 15682
		internal static int __PropertyOffset_ShakeScale;

		// Token: 0x04003D43 RID: 15683
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04003D44 RID: 15684
		internal static int __PropertyOffset_CameraManager;
	}
}
