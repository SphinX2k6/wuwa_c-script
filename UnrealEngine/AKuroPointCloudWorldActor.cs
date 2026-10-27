using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A32 RID: 6706
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudWorldActor")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AKuroPointCloudWorldActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018D06 RID: 101638 RVA: 0x0024AA8E File Offset: 0x00248C8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroPointCloudWorldActor._ClassPtr;
		}

		// Token: 0x06018D07 RID: 101639 RVA: 0x0024AA9C File Offset: 0x00248C9C
		public AKuroPointCloudWorldActor() : this(BuiltinUtils.AllocNativeUObject(AKuroPointCloudWorldActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018D08 RID: 101640 RVA: 0x0024AAC4 File Offset: 0x00248CC4
		[NullableContext(1)]
		public AKuroPointCloudWorldActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroPointCloudWorldActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006256 RID: 25174
		// (get) Token: 0x06018D09 RID: 101641 RVA: 0x0024AAF7 File Offset: 0x00248CF7
		// (set) Token: 0x06018D0A RID: 101642 RVA: 0x0024AB0B File Offset: 0x00248D0B
		public unsafe USceneComponent SceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudWorldActor.__PropertyOffset_SceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudWorldActor.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x17006257 RID: 25175
		// (get) Token: 0x06018D0B RID: 101643 RVA: 0x0024AB20 File Offset: 0x00248D20
		// (set) Token: 0x06018D0C RID: 101644 RVA: 0x0024AB34 File Offset: 0x00248D34
		public unsafe UKuroPointCloudWorldComponent PointCloudWorldComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudWorldComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudWorldActor.__PropertyOffset_PointCloudWorldComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudWorldActor.__PropertyOffset_PointCloudWorldComponent, value);
			}
		}

		// Token: 0x17006258 RID: 25176
		// (get) Token: 0x06018D0D RID: 101645 RVA: 0x0024AB49 File Offset: 0x00248D49
		// (set) Token: 0x06018D0E RID: 101646 RVA: 0x0024AB5D File Offset: 0x00248D5D
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPointCloudWorldActor.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPointCloudWorldActor.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x17006259 RID: 25177
		// (get) Token: 0x06018D0F RID: 101647 RVA: 0x0024AB72 File Offset: 0x00248D72
		// (set) Token: 0x06018D10 RID: 101648 RVA: 0x0024AB86 File Offset: 0x00248D86
		public unsafe FName SubGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPointCloudWorldActor.__PropertyOffset_SubGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPointCloudWorldActor.__PropertyOffset_SubGroupName) = value;
			}
		}

		// Token: 0x06018D11 RID: 101649 RVA: 0x0024AB9B File Offset: 0x00248D9B
		public static void DeleteAllActorsInGroup(UObject WorldContextObject, FName TargetGroupName, FName TargetSubGroupName)
		{
			AKuroPointCloudWorldActor.__DeleteAllActorsInGroup_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, TargetGroupName, TargetSubGroupName);
		}

		// Token: 0x06018D12 RID: 101650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteAllActorsInGroup_Internal(IntPtr WorldContextObject, FName TargetGroupName, FName TargetSubGroupName);

		// Token: 0x06018D13 RID: 101651 RVA: 0x0024ABB4 File Offset: 0x00248DB4
		static AKuroPointCloudWorldActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudWorldActor");
		}

		// Token: 0x06018D14 RID: 101652 RVA: 0x0024ABC2 File Offset: 0x00248DC2
		protected AKuroPointCloudWorldActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6A0 RID: 54944
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudWorldActor";

		// Token: 0x0400D6A1 RID: 54945
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6A2 RID: 54946
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6A3 RID: 54947
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x0400D6A4 RID: 54948
		internal static int __PropertyOffset_PointCloudWorldComponent;

		// Token: 0x0400D6A5 RID: 54949
		internal static int __PropertyOffset_GroupName;

		// Token: 0x0400D6A6 RID: 54950
		internal static int __PropertyOffset_SubGroupName;
	}
}
