using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019C RID: 412
	[UnrealObjectPath("/Script/Engine.CameraShakeBase")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UCameraShakeBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001BD4 RID: 7124 RVA: 0x00029563 File Offset: 0x00027763
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraShakeBase._ClassPtr;
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x0002956F File Offset: 0x0002776F
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0002957F File Offset: 0x0002777F
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

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00029590 File Offset: 0x00027790
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x000295A0 File Offset: 0x000277A0
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

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x000295B1 File Offset: 0x000277B1
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x000295C1 File Offset: 0x000277C1
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000295D2 File Offset: 0x000277D2
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x000295E6 File Offset: 0x000277E6
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

		// Token: 0x06001BDD RID: 7133 RVA: 0x000295FB File Offset: 0x000277FB
		static UCameraShakeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraShakeBase");
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0002960C File Offset: 0x0002780C
		protected UCameraShakeBase() : this(BuiltinUtils.AllocNativeUObject(UCameraShakeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00029634 File Offset: 0x00027834
		protected UCameraShakeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400090D RID: 2317
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraShakeBase";

		// Token: 0x0400090E RID: 2318
		private static IntPtr _ClassPtr;

		// Token: 0x0400090F RID: 2319
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000910 RID: 2320
		internal static int __PropertyOffset_bSingleInstance;

		// Token: 0x04000911 RID: 2321
		internal static int __PropertyOffset_ShakeScale;

		// Token: 0x04000912 RID: 2322
		internal static int __PropertyOffset_TimeDilation;

		// Token: 0x04000913 RID: 2323
		internal static int __PropertyOffset_CameraManager;
	}
}
