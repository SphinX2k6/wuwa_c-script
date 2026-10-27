using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001584 RID: 5508
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.IntervalGizmoActor")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AIntervalGizmoActor : AGizmoActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E52 RID: 81490 RVA: 0x001D3668 File Offset: 0x001D1868
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AIntervalGizmoActor._ClassPtr;
		}

		// Token: 0x06013E53 RID: 81491 RVA: 0x001D3674 File Offset: 0x001D1874
		public AIntervalGizmoActor() : this(BuiltinUtils.AllocNativeUObject(AIntervalGizmoActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E54 RID: 81492 RVA: 0x001D369C File Offset: 0x001D189C
		[NullableContext(1)]
		public AIntervalGizmoActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AIntervalGizmoActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DE6 RID: 19942
		// (get) Token: 0x06013E55 RID: 81493 RVA: 0x001D36CF File Offset: 0x001D18CF
		// (set) Token: 0x06013E56 RID: 81494 RVA: 0x001D36E3 File Offset: 0x001D18E3
		public unsafe UGizmoLineHandleComponent UpIntervalComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoLineHandleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AIntervalGizmoActor.__PropertyOffset_UpIntervalComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIntervalGizmoActor.__PropertyOffset_UpIntervalComponent, value);
			}
		}

		// Token: 0x17004DE7 RID: 19943
		// (get) Token: 0x06013E57 RID: 81495 RVA: 0x001D36F8 File Offset: 0x001D18F8
		// (set) Token: 0x06013E58 RID: 81496 RVA: 0x001D370C File Offset: 0x001D190C
		public unsafe UGizmoLineHandleComponent DownIntervalComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoLineHandleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AIntervalGizmoActor.__PropertyOffset_DownIntervalComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIntervalGizmoActor.__PropertyOffset_DownIntervalComponent, value);
			}
		}

		// Token: 0x17004DE8 RID: 19944
		// (get) Token: 0x06013E59 RID: 81497 RVA: 0x001D3721 File Offset: 0x001D1921
		// (set) Token: 0x06013E5A RID: 81498 RVA: 0x001D3735 File Offset: 0x001D1935
		public unsafe UGizmoLineHandleComponent ForwardIntervalComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGizmoLineHandleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AIntervalGizmoActor.__PropertyOffset_ForwardIntervalComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIntervalGizmoActor.__PropertyOffset_ForwardIntervalComponent, value);
			}
		}

		// Token: 0x06013E5B RID: 81499 RVA: 0x001D374A File Offset: 0x001D194A
		static AIntervalGizmoActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.IntervalGizmoActor");
		}

		// Token: 0x06013E5C RID: 81500 RVA: 0x001D3758 File Offset: 0x001D1958
		protected AIntervalGizmoActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC43 RID: 44099
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.IntervalGizmoActor";

		// Token: 0x0400AC44 RID: 44100
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC45 RID: 44101
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC46 RID: 44102
		internal static int __PropertyOffset_UpIntervalComponent;

		// Token: 0x0400AC47 RID: 44103
		internal static int __PropertyOffset_DownIntervalComponent;

		// Token: 0x0400AC48 RID: 44104
		internal static int __PropertyOffset_ForwardIntervalComponent;
	}
}
