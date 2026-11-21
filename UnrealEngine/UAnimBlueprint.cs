using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000176 RID: 374
	[UnrealObjectPath("/Script/Engine.AnimBlueprint")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class UAnimBlueprint : UBlueprint, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016C5 RID: 5829 RVA: 0x00023839 File Offset: 0x00021A39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBlueprint._ClassPtr;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00023848 File Offset: 0x00021A48
		public UAnimBlueprint() : this(BuiltinUtils.AllocNativeUObject(UAnimBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00023870 File Offset: 0x00021A70
		[NullableContext(1)]
		public UAnimBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x000238A3 File Offset: 0x00021AA3
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x000238B7 File Offset: 0x00021AB7
		[Nullable(2)]
		public unsafe USkeleton TargetSkeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBlueprint.__PropertyOffset_TargetSkeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBlueprint.__PropertyOffset_TargetSkeleton, value);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000238CC File Offset: 0x00021ACC
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x000238DC File Offset: 0x00021ADC
		public unsafe bool bUseMultiThreadedAnimationUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bUseMultiThreadedAnimationUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bUseMultiThreadedAnimationUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x000238ED File Offset: 0x00021AED
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x000238FD File Offset: 0x00021AFD
		public unsafe bool bWarnAboutBlueprintUsage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bWarnAboutBlueprintUsage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bWarnAboutBlueprintUsage) = (value ? 1 : 0);
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0002390E File Offset: 0x00021B0E
		static UAnimBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimBlueprint");
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0002391C File Offset: 0x00021B1C
		protected UAnimBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000741 RID: 1857
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimBlueprint";

		// Token: 0x04000742 RID: 1858
		private static IntPtr _ClassPtr;

		// Token: 0x04000743 RID: 1859
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000744 RID: 1860
		internal static int __PropertyOffset_TargetSkeleton;

		// Token: 0x04000745 RID: 1861
		internal static int __PropertyOffset_bUseMultiThreadedAnimationUpdate;

		// Token: 0x04000746 RID: 1862
		internal static int __PropertyOffset_bWarnAboutBlueprintUsage;
	}
}
