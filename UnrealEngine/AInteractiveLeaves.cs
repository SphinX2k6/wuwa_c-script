using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA0 RID: 6816
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.InteractiveLeaves")]
	[UnrealStructLayout(1520, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class AInteractiveLeaves : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060193A0 RID: 103328 RVA: 0x002550C7 File Offset: 0x002532C7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AInteractiveLeaves._ClassPtr;
		}

		// Token: 0x060193A1 RID: 103329 RVA: 0x002550D4 File Offset: 0x002532D4
		public AInteractiveLeaves() : this(BuiltinUtils.AllocNativeUObject(AInteractiveLeaves.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060193A2 RID: 103330 RVA: 0x002550FC File Offset: 0x002532FC
		[NullableContext(1)]
		public AInteractiveLeaves(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AInteractiveLeaves.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006489 RID: 25737
		// (get) Token: 0x060193A3 RID: 103331 RVA: 0x0025512F File Offset: 0x0025332F
		// (set) Token: 0x060193A4 RID: 103332 RVA: 0x00255143 File Offset: 0x00253343
		public unsafe UInstancedStaticMeshComponent IsmComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveLeaves.__PropertyOffset_IsmComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveLeaves.__PropertyOffset_IsmComponent, value);
			}
		}

		// Token: 0x1700648A RID: 25738
		// (get) Token: 0x060193A5 RID: 103333 RVA: 0x00255158 File Offset: 0x00253358
		// (set) Token: 0x060193A6 RID: 103334 RVA: 0x0025516C File Offset: 0x0025336C
		public unsafe UStaticMeshComponent StaticComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveLeaves.__PropertyOffset_StaticComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveLeaves.__PropertyOffset_StaticComponent, value);
			}
		}

		// Token: 0x1700648B RID: 25739
		// (get) Token: 0x060193A7 RID: 103335 RVA: 0x00255181 File Offset: 0x00253381
		// (set) Token: 0x060193A8 RID: 103336 RVA: 0x00255195 File Offset: 0x00253395
		public unsafe UInteractiveLeavesConfigData Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInteractiveLeavesConfigData>(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveLeaves.__PropertyOffset_Config);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AInteractiveLeaves.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x060193A9 RID: 103337 RVA: 0x002551AA File Offset: 0x002533AA
		static AInteractiveLeaves()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.InteractiveLeaves");
		}

		// Token: 0x060193AA RID: 103338 RVA: 0x002551B8 File Offset: 0x002533B8
		protected AInteractiveLeaves(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC2E RID: 56366
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.InteractiveLeaves";

		// Token: 0x0400DC2F RID: 56367
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC30 RID: 56368
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC31 RID: 56369
		internal static int __PropertyOffset_IsmComponent;

		// Token: 0x0400DC32 RID: 56370
		internal static int __PropertyOffset_StaticComponent;

		// Token: 0x0400DC33 RID: 56371
		internal static int __PropertyOffset_Config;
	}
}
