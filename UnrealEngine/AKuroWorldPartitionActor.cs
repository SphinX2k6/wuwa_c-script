using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F4A RID: 8010
	[UnrealObjectPath("/Script/KuroWorldPartition.KuroWorldPartitionActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public abstract class AKuroWorldPartitionActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E776 RID: 124790 RVA: 0x002D4A33 File Offset: 0x002D2C33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWorldPartitionActor._ClassPtr;
		}

		// Token: 0x17007929 RID: 31017
		// (get) Token: 0x0601E777 RID: 124791 RVA: 0x002D4A3F File Offset: 0x002D2C3F
		// (set) Token: 0x0601E778 RID: 124792 RVA: 0x002D4A53 File Offset: 0x002D2C53
		[Nullable(2)]
		public unsafe UKuroWorldPartitionLocationComponent LocationComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldPartitionLocationComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWorldPartitionActor.__PropertyOffset_LocationComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWorldPartitionActor.__PropertyOffset_LocationComponent, value);
			}
		}

		// Token: 0x0601E779 RID: 124793 RVA: 0x002D4A68 File Offset: 0x002D2C68
		static AKuroWorldPartitionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroWorldPartition.KuroWorldPartitionActor");
		}

		// Token: 0x0601E77A RID: 124794 RVA: 0x002D4A78 File Offset: 0x002D2C78
		protected AKuroWorldPartitionActor() : this(BuiltinUtils.AllocNativeUObject(AKuroWorldPartitionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E77B RID: 124795 RVA: 0x002D4AA0 File Offset: 0x002D2CA0
		protected AKuroWorldPartitionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106F5 RID: 67317
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroWorldPartition.KuroWorldPartitionActor";

		// Token: 0x040106F6 RID: 67318
		private static IntPtr _ClassPtr;

		// Token: 0x040106F7 RID: 67319
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106F8 RID: 67320
		internal static int __PropertyOffset_LocationComponent;
	}
}
