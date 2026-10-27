using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001523 RID: 5411
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ImposterManager.ImposterStreamingManager")]
	[UnrealStructLayout(1200, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class UImposterStreamingManager : UTickableWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B13 RID: 80659 RVA: 0x001CEC8C File Offset: 0x001CCE8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImposterStreamingManager._ClassPtr;
		}

		// Token: 0x06013B14 RID: 80660 RVA: 0x001CEC98 File Offset: 0x001CCE98
		public UImposterStreamingManager() : this(BuiltinUtils.AllocNativeUObject(UImposterStreamingManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B15 RID: 80661 RVA: 0x001CECC0 File Offset: 0x001CCEC0
		[NullableContext(1)]
		public UImposterStreamingManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImposterStreamingManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x06013B16 RID: 80662 RVA: 0x001CECF3 File Offset: 0x001CCEF3
		// (set) Token: 0x06013B17 RID: 80663 RVA: 0x001CED07 File Offset: 0x001CCF07
		public unsafe AActor PoolHolderActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_PoolHolderActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_PoolHolderActor, value);
			}
		}

		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x06013B18 RID: 80664 RVA: 0x001CED1C File Offset: 0x001CCF1C
		// (set) Token: 0x06013B19 RID: 80665 RVA: 0x001CED30 File Offset: 0x001CCF30
		public unsafe UMaterialInterface MasterMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_MasterMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_MasterMaterial, value);
			}
		}

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x06013B1A RID: 80666 RVA: 0x001CED45 File Offset: 0x001CCF45
		// (set) Token: 0x06013B1B RID: 80667 RVA: 0x001CED59 File Offset: 0x001CCF59
		public unsafe UStaticMesh ImposterPlaneMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_ImposterPlaneMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_ImposterPlaneMesh, value);
			}
		}

		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x06013B1C RID: 80668 RVA: 0x001CED6E File Offset: 0x001CCF6E
		// (set) Token: 0x06013B1D RID: 80669 RVA: 0x001CED82 File Offset: 0x001CCF82
		public unsafe UMaterialParameterCollection SeasonalMPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_SeasonalMPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UImposterStreamingManager.__PropertyOffset_SeasonalMPC, value);
			}
		}

		// Token: 0x06013B1E RID: 80670 RVA: 0x001CED97 File Offset: 0x001CCF97
		static UImposterStreamingManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImposterManager.ImposterStreamingManager");
		}

		// Token: 0x06013B1F RID: 80671 RVA: 0x001CEDA5 File Offset: 0x001CCFA5
		protected UImposterStreamingManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA23 RID: 43555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ImposterManager.ImposterStreamingManager";

		// Token: 0x0400AA24 RID: 43556
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA25 RID: 43557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AA26 RID: 43558
		internal static int __PropertyOffset_PoolHolderActor;

		// Token: 0x0400AA27 RID: 43559
		internal static int __PropertyOffset_MasterMaterial;

		// Token: 0x0400AA28 RID: 43560
		internal static int __PropertyOffset_ImposterPlaneMesh;

		// Token: 0x0400AA29 RID: 43561
		internal static int __PropertyOffset_SeasonalMPC;
	}
}
