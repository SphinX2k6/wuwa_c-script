using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D66 RID: 7526
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ListenCollisionEvent")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_DA_Buff_ListenCollisionEvent : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD1F RID: 118047 RVA: 0x002A99BB File Offset: 0x002A7BBB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ListenCollisionEvent._ClassPtr;
		}

		// Token: 0x0601CD20 RID: 118048 RVA: 0x002A99C8 File Offset: 0x002A7BC8
		public UKSC_DA_Buff_ListenCollisionEvent() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ListenCollisionEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD21 RID: 118049 RVA: 0x002A99F0 File Offset: 0x002A7BF0
		public UKSC_DA_Buff_ListenCollisionEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ListenCollisionEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007414 RID: 29716
		// (get) Token: 0x0601CD22 RID: 118050 RVA: 0x002A9A23 File Offset: 0x002A7C23
		// (set) Token: 0x0601CD23 RID: 118051 RVA: 0x002A9A33 File Offset: 0x002A7C33
		public unsafe float ListenEventCoolDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ListenEventCoolDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ListenEventCoolDown) = value;
			}
		}

		// Token: 0x17007415 RID: 29717
		// (get) Token: 0x0601CD24 RID: 118052 RVA: 0x002A9A44 File Offset: 0x002A7C44
		// (set) Token: 0x0601CD25 RID: 118053 RVA: 0x002A9A54 File Offset: 0x002A7C54
		public unsafe EKSC_ListenCollisionEvent_ListenType ListenEvent
		{
			get
			{
				return (EKSC_ListenCollisionEvent_ListenType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ListenEvent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ListenEvent) = (byte)value;
			}
		}

		// Token: 0x17007416 RID: 29718
		// (get) Token: 0x0601CD26 RID: 118054 RVA: 0x002A9A65 File Offset: 0x002A7C65
		// (set) Token: 0x0601CD27 RID: 118055 RVA: 0x002A9A75 File Offset: 0x002A7C75
		public unsafe EKSC_ListenCollisionEvent_CollisionType CollisionType
		{
			get
			{
				return (EKSC_ListenCollisionEvent_CollisionType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_CollisionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_CollisionType) = (byte)value;
			}
		}

		// Token: 0x17007417 RID: 29719
		// (get) Token: 0x0601CD28 RID: 118056 RVA: 0x002A9A86 File Offset: 0x002A7C86
		// (set) Token: 0x0601CD29 RID: 118057 RVA: 0x002A9A96 File Offset: 0x002A7C96
		public unsafe bool IsFinishAfterResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_IsFinishAfterResponse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_IsFinishAfterResponse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007418 RID: 29720
		// (get) Token: 0x0601CD2A RID: 118058 RVA: 0x002A9AA8 File Offset: 0x002A7CA8
		// (set) Token: 0x0601CD2B RID: 118059 RVA: 0x002A9AE1 File Offset: 0x002A7CE1
		public FKSC_TagFilter ResponseCheckTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._ResponseCheckTagFilter) == null)
				{
					result = (this._ResponseCheckTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ResponseCheckTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ResponseCheckTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007419 RID: 29721
		// (get) Token: 0x0601CD2C RID: 118060 RVA: 0x002A9B02 File Offset: 0x002A7D02
		// (set) Token: 0x0601CD2D RID: 118061 RVA: 0x002A9B12 File Offset: 0x002A7D12
		public unsafe EKSC_ListenCollisionEvent_Response Response
		{
			get
			{
				return (EKSC_ListenCollisionEvent_Response)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_Response));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_Response) = (byte)value;
			}
		}

		// Token: 0x1700741A RID: 29722
		// (get) Token: 0x0601CD2E RID: 118062 RVA: 0x002A9B23 File Offset: 0x002A7D23
		// (set) Token: 0x0601CD2F RID: 118063 RVA: 0x002A9B33 File Offset: 0x002A7D33
		public unsafe EKSC_ListenCollisionEvent_ResponseTarget ResponseTarget
		{
			get
			{
				return (EKSC_ListenCollisionEvent_ResponseTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ResponseTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_ResponseTarget) = (byte)value;
			}
		}

		// Token: 0x1700741B RID: 29723
		// (get) Token: 0x0601CD30 RID: 118064 RVA: 0x002A9B44 File Offset: 0x002A7D44
		// (set) Token: 0x0601CD31 RID: 118065 RVA: 0x002A9B58 File Offset: 0x002A7D58
		[Nullable(2)]
		public unsafe UKSC_DA_Buff AddBuff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_AddBuff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_AddBuff, value);
			}
		}

		// Token: 0x1700741C RID: 29724
		// (get) Token: 0x0601CD32 RID: 118066 RVA: 0x002A9B6D File Offset: 0x002A7D6D
		// (set) Token: 0x0601CD33 RID: 118067 RVA: 0x002A9B7D File Offset: 0x002A7D7D
		public unsafe int BulletID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_BulletID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ListenCollisionEvent.__PropertyOffset_BulletID) = value;
			}
		}

		// Token: 0x0601CD34 RID: 118068 RVA: 0x002A9B8E File Offset: 0x002A7D8E
		static UKSC_DA_Buff_ListenCollisionEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ListenCollisionEvent");
		}

		// Token: 0x0601CD35 RID: 118069 RVA: 0x002A9B9C File Offset: 0x002A7D9C
		protected UKSC_DA_Buff_ListenCollisionEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA1C RID: 64028
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ListenCollisionEvent";

		// Token: 0x0400FA1D RID: 64029
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA1E RID: 64030
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA1F RID: 64031
		internal static int __PropertyOffset_ListenEventCoolDown;

		// Token: 0x0400FA20 RID: 64032
		internal static int __PropertyOffset_ListenEvent;

		// Token: 0x0400FA21 RID: 64033
		internal static int __PropertyOffset_CollisionType;

		// Token: 0x0400FA22 RID: 64034
		internal static int __PropertyOffset_IsFinishAfterResponse;

		// Token: 0x0400FA23 RID: 64035
		internal static int __PropertyOffset_ResponseCheckTagFilter;

		// Token: 0x0400FA24 RID: 64036
		[Nullable(2)]
		private FKSC_TagFilter _ResponseCheckTagFilter;

		// Token: 0x0400FA25 RID: 64037
		internal static int __PropertyOffset_Response;

		// Token: 0x0400FA26 RID: 64038
		internal static int __PropertyOffset_ResponseTarget;

		// Token: 0x0400FA27 RID: 64039
		internal static int __PropertyOffset_AddBuff;

		// Token: 0x0400FA28 RID: 64040
		internal static int __PropertyOffset_BulletID;
	}
}
