using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C7 RID: 5831
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.BulletEntity")]
	[UnrealStructLayout(1424, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class UBulletEntity : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060151B7 RID: 86455 RVA: 0x001F08D2 File Offset: 0x001EEAD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletEntity._ClassPtr;
		}

		// Token: 0x060151B8 RID: 86456 RVA: 0x001F08E0 File Offset: 0x001EEAE0
		public UBulletEntity() : this(BuiltinUtils.AllocNativeUObject(UBulletEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151B9 RID: 86457 RVA: 0x001F0908 File Offset: 0x001EEB08
		[NullableContext(1)]
		public UBulletEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005370 RID: 21360
		// (get) Token: 0x060151BA RID: 86458 RVA: 0x001F093B File Offset: 0x001EEB3B
		// (set) Token: 0x060151BB RID: 86459 RVA: 0x001F094F File Offset: 0x001EEB4F
		public unsafe AActor Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_Actor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x17005371 RID: 21361
		// (get) Token: 0x060151BC RID: 86460 RVA: 0x001F0964 File Offset: 0x001EEB64
		// (set) Token: 0x060151BD RID: 86461 RVA: 0x001F0974 File Offset: 0x001EEB74
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x17005372 RID: 21362
		// (get) Token: 0x060151BE RID: 86462 RVA: 0x001F0985 File Offset: 0x001EEB85
		// (set) Token: 0x060151BF RID: 86463 RVA: 0x001F0995 File Offset: 0x001EEB95
		public unsafe long ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_ConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_ConfigId) = value;
			}
		}

		// Token: 0x17005373 RID: 21363
		// (get) Token: 0x060151C0 RID: 86464 RVA: 0x001F09A6 File Offset: 0x001EEBA6
		// (set) Token: 0x060151C1 RID: 86465 RVA: 0x001F09C0 File Offset: 0x001EEBC0
		public unsafe IBulletContext BulletContext
		{
			get
			{
				return (IBulletContext)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_BulletContext));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_BulletContext) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17005374 RID: 21364
		// (get) Token: 0x060151C2 RID: 86466 RVA: 0x001F09E6 File Offset: 0x001EEBE6
		// (set) Token: 0x060151C3 RID: 86467 RVA: 0x001F09FA File Offset: 0x001EEBFA
		public unsafe UPrimitiveComponent CollisionComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_CollisionComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_CollisionComponent, value);
			}
		}

		// Token: 0x17005375 RID: 21365
		// (get) Token: 0x060151C4 RID: 86468 RVA: 0x001F0A0F File Offset: 0x001EEC0F
		// (set) Token: 0x060151C5 RID: 86469 RVA: 0x001F0A23 File Offset: 0x001EEC23
		public unsafe UBulletKFCComponent KFCComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBulletKFCComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_KFCComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_KFCComponent, value);
			}
		}

		// Token: 0x17005376 RID: 21366
		// (get) Token: 0x060151C6 RID: 86470 RVA: 0x001F0A38 File Offset: 0x001EEC38
		// (set) Token: 0x060151C7 RID: 86471 RVA: 0x001F0A48 File Offset: 0x001EEC48
		public unsafe bool bNeedDetach
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_bNeedDetach) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_bNeedDetach) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005377 RID: 21367
		// (get) Token: 0x060151C8 RID: 86472 RVA: 0x001F0A5C File Offset: 0x001EEC5C
		// (set) Token: 0x060151C9 RID: 86473 RVA: 0x001F0A95 File Offset: 0x001EEC95
		[Nullable(1)]
		public TMap<UObject, UBulletHitActorData> MapHitActorData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, UBulletHitActorData> result;
				if ((result = this._MapHitActorData) == null)
				{
					result = (this._MapHitActorData = new TMap<UObject, UBulletHitActorData>(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_MapHitActorData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MapHitActorData.CopyAssign(value);
			}
		}

		// Token: 0x17005378 RID: 21368
		// (get) Token: 0x060151CA RID: 86474 RVA: 0x001F0AA4 File Offset: 0x001EECA4
		// (set) Token: 0x060151CB RID: 86475 RVA: 0x001F0ADD File Offset: 0x001EECDD
		[Nullable(1)]
		public TArray<UBulletHitActorData> ArrayHitActorData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBulletHitActorData> result;
				if ((result = this._ArrayHitActorData) == null)
				{
					result = (this._ArrayHitActorData = new TArray<UBulletHitActorData>(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_ArrayHitActorData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ArrayHitActorData.CopyAssign(value);
			}
		}

		// Token: 0x17005379 RID: 21369
		// (get) Token: 0x060151CC RID: 86476 RVA: 0x001F0AEC File Offset: 0x001EECEC
		// (set) Token: 0x060151CD RID: 86477 RVA: 0x001F0B25 File Offset: 0x001EED25
		[Nullable(1)]
		public TMap<UObject, UBulletHitActorData> LastMapHitActorData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, UBulletHitActorData> result;
				if ((result = this._LastMapHitActorData) == null)
				{
					result = (this._LastMapHitActorData = new TMap<UObject, UBulletHitActorData>(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_LastMapHitActorData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LastMapHitActorData.CopyAssign(value);
			}
		}

		// Token: 0x1700537A RID: 21370
		// (get) Token: 0x060151CE RID: 86478 RVA: 0x001F0B34 File Offset: 0x001EED34
		// (set) Token: 0x060151CF RID: 86479 RVA: 0x001F0B6D File Offset: 0x001EED6D
		[Nullable(1)]
		public TArray<UBulletHitActorData> LastArrayHitActorData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBulletHitActorData> result;
				if ((result = this._LastArrayHitActorData) == null)
				{
					result = (this._LastArrayHitActorData = new TArray<UBulletHitActorData>(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_LastArrayHitActorData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LastArrayHitActorData.CopyAssign(value);
			}
		}

		// Token: 0x1700537B RID: 21371
		// (get) Token: 0x060151D0 RID: 86480 RVA: 0x001F0B7B File Offset: 0x001EED7B
		// (set) Token: 0x060151D1 RID: 86481 RVA: 0x001F0B8F File Offset: 0x001EED8F
		public unsafe UTraceSphereElement ObstacleTraceSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTraceSphereElement>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_ObstacleTraceSphere);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_ObstacleTraceSphere, value);
			}
		}

		// Token: 0x1700537C RID: 21372
		// (get) Token: 0x060151D2 RID: 86482 RVA: 0x001F0BA4 File Offset: 0x001EEDA4
		// (set) Token: 0x060151D3 RID: 86483 RVA: 0x001F0BB8 File Offset: 0x001EEDB8
		public unsafe UTraceBoxElement ObstacleTraceBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTraceBoxElement>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_ObstacleTraceBox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_ObstacleTraceBox, value);
			}
		}

		// Token: 0x1700537D RID: 21373
		// (get) Token: 0x060151D4 RID: 86484 RVA: 0x001F0BCD File Offset: 0x001EEDCD
		// (set) Token: 0x060151D5 RID: 86485 RVA: 0x001F0BE1 File Offset: 0x001EEDE1
		public unsafe UTraceLineElement ObstacleTraceLine
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTraceLineElement>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_ObstacleTraceLine);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletEntity.__PropertyOffset_ObstacleTraceLine, value);
			}
		}

		// Token: 0x1700537E RID: 21374
		// (get) Token: 0x060151D6 RID: 86486 RVA: 0x001F0BF8 File Offset: 0x001EEDF8
		// (set) Token: 0x060151D7 RID: 86487 RVA: 0x001F0C31 File Offset: 0x001EEE31
		[Nullable(1)]
		public TArray<UBulletActionBase> TickActions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBulletActionBase> result;
				if ((result = this._TickActions) == null)
				{
					result = (this._TickActions = new TArray<UBulletActionBase>(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_TickActions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TickActions.CopyAssign(value);
			}
		}

		// Token: 0x1700537F RID: 21375
		// (get) Token: 0x060151D8 RID: 86488 RVA: 0x001F0C40 File Offset: 0x001EEE40
		// (set) Token: 0x060151D9 RID: 86489 RVA: 0x001F0C79 File Offset: 0x001EEE79
		[Nullable(1)]
		public TArray<UBulletOnHitAction> OnHitActions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBulletOnHitAction> result;
				if ((result = this._OnHitActions) == null)
				{
					result = (this._OnHitActions = new TArray<UBulletOnHitAction>(base.NativePtr + (IntPtr)UBulletEntity.__PropertyOffset_OnHitActions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OnHitActions.CopyAssign(value);
			}
		}

		// Token: 0x060151DA RID: 86490 RVA: 0x001F0C87 File Offset: 0x001EEE87
		public void OnObstacleTrace(bool Result, UTraceBaseElement Element, double Frame, double Index)
		{
			UBulletEntity.__OnObstacleTrace_Internal(base.NativePtr, Result, (Element != null) ? Element.NativePtr : IntPtr.Zero, Frame, Index);
		}

		// Token: 0x060151DB RID: 86491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnObstacleTrace_Internal(IntPtr @this, bool Result, IntPtr Element, double Frame, double Index);

		// Token: 0x060151DC RID: 86492 RVA: 0x001F0CA8 File Offset: 0x001EEEA8
		static UBulletEntity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletEntity");
		}

		// Token: 0x060151DD RID: 86493 RVA: 0x001F0CB6 File Offset: 0x001EEEB6
		protected UBulletEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7CD RID: 47053
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletEntity";

		// Token: 0x0400B7CE RID: 47054
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7CF RID: 47055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B7D0 RID: 47056
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400B7D1 RID: 47057
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400B7D2 RID: 47058
		internal static int __PropertyOffset_ConfigId;

		// Token: 0x0400B7D3 RID: 47059
		internal static int __PropertyOffset_BulletContext;

		// Token: 0x0400B7D4 RID: 47060
		internal static int __PropertyOffset_CollisionComponent;

		// Token: 0x0400B7D5 RID: 47061
		internal static int __PropertyOffset_KFCComponent;

		// Token: 0x0400B7D6 RID: 47062
		internal static int __PropertyOffset_bNeedDetach;

		// Token: 0x0400B7D7 RID: 47063
		internal static int __PropertyOffset_MapHitActorData;

		// Token: 0x0400B7D8 RID: 47064
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UObject, UBulletHitActorData> _MapHitActorData;

		// Token: 0x0400B7D9 RID: 47065
		internal static int __PropertyOffset_ArrayHitActorData;

		// Token: 0x0400B7DA RID: 47066
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBulletHitActorData> _ArrayHitActorData;

		// Token: 0x0400B7DB RID: 47067
		internal static int __PropertyOffset_LastMapHitActorData;

		// Token: 0x0400B7DC RID: 47068
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UObject, UBulletHitActorData> _LastMapHitActorData;

		// Token: 0x0400B7DD RID: 47069
		internal static int __PropertyOffset_LastArrayHitActorData;

		// Token: 0x0400B7DE RID: 47070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBulletHitActorData> _LastArrayHitActorData;

		// Token: 0x0400B7DF RID: 47071
		internal static int __PropertyOffset_ObstacleTraceSphere;

		// Token: 0x0400B7E0 RID: 47072
		internal static int __PropertyOffset_ObstacleTraceBox;

		// Token: 0x0400B7E1 RID: 47073
		internal static int __PropertyOffset_ObstacleTraceLine;

		// Token: 0x0400B7E2 RID: 47074
		internal static int __PropertyOffset_TickActions;

		// Token: 0x0400B7E3 RID: 47075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBulletActionBase> _TickActions;

		// Token: 0x0400B7E4 RID: 47076
		internal static int __PropertyOffset_OnHitActions;

		// Token: 0x0400B7E5 RID: 47077
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBulletOnHitAction> _OnHitActions;
	}
}
