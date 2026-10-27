using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012CA RID: 4810
	[UnrealObjectPath("/Script/Foliage.FoliageType_Actor")]
	[UnrealStructLayout(2496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2496)]
	public class UFoliageType_Actor : UFoliageType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011A6C RID: 72300 RVA: 0x0019E896 File Offset: 0x0019CA96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFoliageType_Actor._ClassPtr;
		}

		// Token: 0x06011A6D RID: 72301 RVA: 0x0019E8A4 File Offset: 0x0019CAA4
		public UFoliageType_Actor() : this(BuiltinUtils.AllocNativeUObject(UFoliageType_Actor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011A6E RID: 72302 RVA: 0x0019E8CC File Offset: 0x0019CACC
		[NullableContext(1)]
		public UFoliageType_Actor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFoliageType_Actor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x06011A6F RID: 72303 RVA: 0x0019E8FF File Offset: 0x0019CAFF
		// (set) Token: 0x06011A70 RID: 72304 RVA: 0x0019E913 File Offset: 0x0019CB13
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> ActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_ActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_ActorClass) = value;
			}
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x06011A71 RID: 72305 RVA: 0x0019E928 File Offset: 0x0019CB28
		// (set) Token: 0x06011A72 RID: 72306 RVA: 0x0019E938 File Offset: 0x0019CB38
		public unsafe bool bShouldAttachToBaseComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_bShouldAttachToBaseComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_bShouldAttachToBaseComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x06011A73 RID: 72307 RVA: 0x0019E949 File Offset: 0x0019CB49
		// (set) Token: 0x06011A74 RID: 72308 RVA: 0x0019E959 File Offset: 0x0019CB59
		public unsafe bool bStaticMeshOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_bStaticMeshOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_bStaticMeshOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x06011A75 RID: 72309 RVA: 0x0019E96A File Offset: 0x0019CB6A
		// (set) Token: 0x06011A76 RID: 72310 RVA: 0x0019E97E File Offset: 0x0019CB7E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UFoliageInstancedStaticMeshComponent> StaticMeshOnlyComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_StaticMeshOnlyComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType_Actor.__PropertyOffset_StaticMeshOnlyComponentClass) = value;
			}
		}

		// Token: 0x06011A77 RID: 72311 RVA: 0x0019E993 File Offset: 0x0019CB93
		static UFoliageType_Actor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.FoliageType_Actor");
		}

		// Token: 0x06011A78 RID: 72312 RVA: 0x0019E9A1 File Offset: 0x0019CBA1
		protected UFoliageType_Actor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400977C RID: 38780
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Foliage.FoliageType_Actor";

		// Token: 0x0400977D RID: 38781
		private static IntPtr _ClassPtr;

		// Token: 0x0400977E RID: 38782
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400977F RID: 38783
		internal static int __PropertyOffset_ActorClass;

		// Token: 0x04009780 RID: 38784
		internal static int __PropertyOffset_bShouldAttachToBaseComponent;

		// Token: 0x04009781 RID: 38785
		internal static int __PropertyOffset_bStaticMeshOnly;

		// Token: 0x04009782 RID: 38786
		internal static int __PropertyOffset_StaticMeshOnlyComponentClass;
	}
}
