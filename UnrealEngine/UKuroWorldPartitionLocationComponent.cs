using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F4B RID: 8011
	[UnrealObjectPath("/Script/KuroWorldPartition.KuroWorldPartitionLocationComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UKuroWorldPartitionLocationComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E77C RID: 124796 RVA: 0x002D4AA9 File Offset: 0x002D2CA9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldPartitionLocationComponent._ClassPtr;
		}

		// Token: 0x0601E77D RID: 124797 RVA: 0x002D4AB8 File Offset: 0x002D2CB8
		public UKuroWorldPartitionLocationComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldPartitionLocationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E77E RID: 124798 RVA: 0x002D4AE0 File Offset: 0x002D2CE0
		[NullableContext(1)]
		public UKuroWorldPartitionLocationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldPartitionLocationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700792A RID: 31018
		// (get) Token: 0x0601E77F RID: 124799 RVA: 0x002D4B13 File Offset: 0x002D2D13
		// (set) Token: 0x0601E780 RID: 124800 RVA: 0x002D4B23 File Offset: 0x002D2D23
		public unsafe int X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldPartitionLocationComponent.__PropertyOffset_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldPartitionLocationComponent.__PropertyOffset_X) = value;
			}
		}

		// Token: 0x1700792B RID: 31019
		// (get) Token: 0x0601E781 RID: 124801 RVA: 0x002D4B34 File Offset: 0x002D2D34
		// (set) Token: 0x0601E782 RID: 124802 RVA: 0x002D4B44 File Offset: 0x002D2D44
		public unsafe int Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldPartitionLocationComponent.__PropertyOffset_Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldPartitionLocationComponent.__PropertyOffset_Y) = value;
			}
		}

		// Token: 0x1700792C RID: 31020
		// (get) Token: 0x0601E783 RID: 124803 RVA: 0x002D4B55 File Offset: 0x002D2D55
		// (set) Token: 0x0601E784 RID: 124804 RVA: 0x002D4B69 File Offset: 0x002D2D69
		public unsafe FBox DataChunkActorBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldPartitionLocationComponent.__PropertyOffset_DataChunkActorBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldPartitionLocationComponent.__PropertyOffset_DataChunkActorBounds) = value;
			}
		}

		// Token: 0x0601E785 RID: 124805 RVA: 0x002D4B7E File Offset: 0x002D2D7E
		static UKuroWorldPartitionLocationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroWorldPartition.KuroWorldPartitionLocationComponent");
		}

		// Token: 0x0601E786 RID: 124806 RVA: 0x002D4B8C File Offset: 0x002D2D8C
		protected UKuroWorldPartitionLocationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106F9 RID: 67321
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroWorldPartition.KuroWorldPartitionLocationComponent";

		// Token: 0x040106FA RID: 67322
		private static IntPtr _ClassPtr;

		// Token: 0x040106FB RID: 67323
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106FC RID: 67324
		internal static int __PropertyOffset_X;

		// Token: 0x040106FD RID: 67325
		internal static int __PropertyOffset_Y;

		// Token: 0x040106FE RID: 67326
		internal static int __PropertyOffset_DataChunkActorBounds;
	}
}
