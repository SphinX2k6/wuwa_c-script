using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008BD RID: 2237
	[UnrealObjectPath("/Script/Engine.BlueprintCore")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UBlueprintCore : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A3B RID: 31291 RVA: 0x000AED04 File Offset: 0x000ACF04
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintCore._ClassPtr;
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x000AED10 File Offset: 0x000ACF10
		public UBlueprintCore() : this(BuiltinUtils.AllocNativeUObject(UBlueprintCore.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x000AED38 File Offset: 0x000ACF38
		[NullableContext(1)]
		public UBlueprintCore(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintCore.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06007A3E RID: 31294 RVA: 0x000AED6B File Offset: 0x000ACF6B
		// (set) Token: 0x06007A3F RID: 31295 RVA: 0x000AED7F File Offset: 0x000ACF7F
		public unsafe UClassStackOnlyPtr SkeletonGeneratedClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_SkeletonGeneratedClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_SkeletonGeneratedClass) = value;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06007A40 RID: 31296 RVA: 0x000AED94 File Offset: 0x000ACF94
		// (set) Token: 0x06007A41 RID: 31297 RVA: 0x000AEDA8 File Offset: 0x000ACFA8
		public unsafe UClassStackOnlyPtr GeneratedClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_GeneratedClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_GeneratedClass) = value;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06007A42 RID: 31298 RVA: 0x000AEDBD File Offset: 0x000ACFBD
		// (set) Token: 0x06007A43 RID: 31299 RVA: 0x000AEDCD File Offset: 0x000ACFCD
		public unsafe bool bLegacyNeedToPurgeSkelRefs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_bLegacyNeedToPurgeSkelRefs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_bLegacyNeedToPurgeSkelRefs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x000AEDDE File Offset: 0x000ACFDE
		// (set) Token: 0x06007A45 RID: 31301 RVA: 0x000AEDF2 File Offset: 0x000ACFF2
		public unsafe FGuid BlueprintGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_BlueprintGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlueprintCore.__PropertyOffset_BlueprintGuid) = value;
			}
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x000AEE07 File Offset: 0x000AD007
		static UBlueprintCore()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintCore");
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x000AEE15 File Offset: 0x000AD015
		protected UBlueprintCore(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AC3 RID: 15043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintCore";

		// Token: 0x04003AC4 RID: 15044
		private static IntPtr _ClassPtr;

		// Token: 0x04003AC5 RID: 15045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003AC6 RID: 15046
		internal static int __PropertyOffset_SkeletonGeneratedClass;

		// Token: 0x04003AC7 RID: 15047
		internal static int __PropertyOffset_GeneratedClass;

		// Token: 0x04003AC8 RID: 15048
		internal static int __PropertyOffset_bLegacyNeedToPurgeSkelRefs;

		// Token: 0x04003AC9 RID: 15049
		internal static int __PropertyOffset_BlueprintGuid;
	}
}
