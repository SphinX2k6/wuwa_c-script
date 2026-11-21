using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000325 RID: 805
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.BulletEntity")]
	[UnrealStructLayout(1424, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class UBulletEntity : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600545D RID: 21597 RVA: 0x0007630A File Offset: 0x0007450A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletEntity._ClassPtr;
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x00076318 File Offset: 0x00074518
		public UBulletEntity() : this(BuiltinUtils.AllocNativeUObject(UBulletEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x00076340 File Offset: 0x00074540
		[NullableContext(1)]
		public UBulletEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06005460 RID: 21600 RVA: 0x00076373 File Offset: 0x00074573
		// (set) Token: 0x06005461 RID: 21601 RVA: 0x00076387 File Offset: 0x00074587
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

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06005462 RID: 21602 RVA: 0x0007639C File Offset: 0x0007459C
		// (set) Token: 0x06005463 RID: 21603 RVA: 0x000763AC File Offset: 0x000745AC
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

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06005464 RID: 21604 RVA: 0x000763BD File Offset: 0x000745BD
		// (set) Token: 0x06005465 RID: 21605 RVA: 0x000763CD File Offset: 0x000745CD
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

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x000763DE File Offset: 0x000745DE
		// (set) Token: 0x06005467 RID: 21607 RVA: 0x000763F8 File Offset: 0x000745F8
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

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x0007641E File Offset: 0x0007461E
		// (set) Token: 0x06005469 RID: 21609 RVA: 0x00076432 File Offset: 0x00074632
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

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x00076447 File Offset: 0x00074647
		// (set) Token: 0x0600546B RID: 21611 RVA: 0x00076457 File Offset: 0x00074657
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

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x0600546C RID: 21612 RVA: 0x00076468 File Offset: 0x00074668
		// (set) Token: 0x0600546D RID: 21613 RVA: 0x0007647C File Offset: 0x0007467C
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

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x0600546E RID: 21614 RVA: 0x00076491 File Offset: 0x00074691
		// (set) Token: 0x0600546F RID: 21615 RVA: 0x000764A5 File Offset: 0x000746A5
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

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06005470 RID: 21616 RVA: 0x000764BA File Offset: 0x000746BA
		// (set) Token: 0x06005471 RID: 21617 RVA: 0x000764CE File Offset: 0x000746CE
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

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06005472 RID: 21618 RVA: 0x000764E4 File Offset: 0x000746E4
		// (set) Token: 0x06005473 RID: 21619 RVA: 0x0007651D File Offset: 0x0007471D
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

		// Token: 0x06005474 RID: 21620 RVA: 0x0007652B File Offset: 0x0007472B
		public void OnObstacleTrace(bool Result, UTraceBaseElement Element, double Frame, double Index)
		{
			UBulletEntity.__OnObstacleTrace_Internal(base.NativePtr, Result, (Element != null) ? Element.NativePtr : IntPtr.Zero, Frame, Index);
		}

		// Token: 0x06005475 RID: 21621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnObstacleTrace_Internal(IntPtr @this, bool Result, IntPtr Element, double Frame, double Index);

		// Token: 0x06005476 RID: 21622 RVA: 0x0007654C File Offset: 0x0007474C
		static UBulletEntity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletEntity");
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x0007655A File Offset: 0x0007475A
		protected UBulletEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400227B RID: 8827
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletEntity";

		// Token: 0x0400227C RID: 8828
		private static IntPtr _ClassPtr;

		// Token: 0x0400227D RID: 8829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400227E RID: 8830
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400227F RID: 8831
		internal static int __PropertyOffset_EntityId;

		// Token: 0x04002280 RID: 8832
		internal static int __PropertyOffset_ConfigId;

		// Token: 0x04002281 RID: 8833
		internal static int __PropertyOffset_BulletContext;

		// Token: 0x04002282 RID: 8834
		internal static int __PropertyOffset_CollisionComponent;

		// Token: 0x04002283 RID: 8835
		internal static int __PropertyOffset_bNeedDetach;

		// Token: 0x04002284 RID: 8836
		internal static int __PropertyOffset_ObstacleTraceSphere;

		// Token: 0x04002285 RID: 8837
		internal static int __PropertyOffset_ObstacleTraceBox;

		// Token: 0x04002286 RID: 8838
		internal static int __PropertyOffset_ObstacleTraceLine;

		// Token: 0x04002287 RID: 8839
		internal static int __PropertyOffset_TickActions;

		// Token: 0x04002288 RID: 8840
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBulletActionBase> _TickActions;
	}
}
