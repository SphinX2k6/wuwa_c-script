using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018F RID: 399
	[UnrealObjectPath("/Script/Engine.BlueprintCore")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UBlueprintCore : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x0002700F File Offset: 0x0002520F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintCore._ClassPtr;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0002701C File Offset: 0x0002521C
		public UBlueprintCore() : this(BuiltinUtils.AllocNativeUObject(UBlueprintCore.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00027044 File Offset: 0x00025244
		[NullableContext(1)]
		public UBlueprintCore(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintCore.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00027077 File Offset: 0x00025277
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x0002708B File Offset: 0x0002528B
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

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x000270A0 File Offset: 0x000252A0
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x000270B4 File Offset: 0x000252B4
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

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x000270C9 File Offset: 0x000252C9
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x000270D9 File Offset: 0x000252D9
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x000270EA File Offset: 0x000252EA
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x000270FE File Offset: 0x000252FE
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

		// Token: 0x06001A06 RID: 6662 RVA: 0x00027113 File Offset: 0x00025313
		static UBlueprintCore()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintCore");
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00027121 File Offset: 0x00025321
		protected UBlueprintCore(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000859 RID: 2137
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintCore";

		// Token: 0x0400085A RID: 2138
		private static IntPtr _ClassPtr;

		// Token: 0x0400085B RID: 2139
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400085C RID: 2140
		internal static int __PropertyOffset_SkeletonGeneratedClass;

		// Token: 0x0400085D RID: 2141
		internal static int __PropertyOffset_GeneratedClass;

		// Token: 0x0400085E RID: 2142
		internal static int __PropertyOffset_bLegacyNeedToPurgeSkelRefs;

		// Token: 0x0400085F RID: 2143
		internal static int __PropertyOffset_BlueprintGuid;
	}
}
