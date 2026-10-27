using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AAC RID: 6828
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBillboardComponent")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKuroBillboardComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601946C RID: 103532 RVA: 0x00256042 File Offset: 0x00254242
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBillboardComponent._ClassPtr;
		}

		// Token: 0x0601946D RID: 103533 RVA: 0x00256050 File Offset: 0x00254250
		public UKuroBillboardComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroBillboardComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601946E RID: 103534 RVA: 0x00256078 File Offset: 0x00254278
		[NullableContext(1)]
		public UKuroBillboardComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBillboardComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064B6 RID: 25782
		// (get) Token: 0x0601946F RID: 103535 RVA: 0x002560AB File Offset: 0x002542AB
		// (set) Token: 0x06019470 RID: 103536 RVA: 0x002560BB File Offset: 0x002542BB
		public unsafe bool IsUpdateEveryFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_IsUpdateEveryFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_IsUpdateEveryFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064B7 RID: 25783
		// (get) Token: 0x06019471 RID: 103537 RVA: 0x002560CC File Offset: 0x002542CC
		// (set) Token: 0x06019472 RID: 103538 RVA: 0x002560DC File Offset: 0x002542DC
		public unsafe EBillboardMode OrientAxis
		{
			get
			{
				return (EBillboardMode)(*(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_OrientAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_OrientAxis) = (byte)value;
			}
		}

		// Token: 0x170064B8 RID: 25784
		// (get) Token: 0x06019473 RID: 103539 RVA: 0x002560ED File Offset: 0x002542ED
		// (set) Token: 0x06019474 RID: 103540 RVA: 0x002560FD File Offset: 0x002542FD
		public unsafe bool IsFixSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_IsFixSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_IsFixSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064B9 RID: 25785
		// (get) Token: 0x06019475 RID: 103541 RVA: 0x0025610E File Offset: 0x0025430E
		// (set) Token: 0x06019476 RID: 103542 RVA: 0x0025611E File Offset: 0x0025431E
		public unsafe float ScaleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_ScaleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_ScaleSize) = value;
			}
		}

		// Token: 0x170064BA RID: 25786
		// (get) Token: 0x06019477 RID: 103543 RVA: 0x0025612F File Offset: 0x0025432F
		// (set) Token: 0x06019478 RID: 103544 RVA: 0x0025613F File Offset: 0x0025433F
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x170064BB RID: 25787
		// (get) Token: 0x06019479 RID: 103545 RVA: 0x00256150 File Offset: 0x00254350
		// (set) Token: 0x0601947A RID: 103546 RVA: 0x00256160 File Offset: 0x00254360
		public unsafe float MinSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_MinSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBillboardComponent.__PropertyOffset_MinSize) = value;
			}
		}

		// Token: 0x0601947B RID: 103547 RVA: 0x00256171 File Offset: 0x00254371
		public void Update()
		{
			UKuroBillboardComponent.__Update_Internal(base.NativePtr);
		}

		// Token: 0x0601947C RID: 103548 RVA: 0x0025617E File Offset: 0x0025437E
		public void Initialize()
		{
			UKuroBillboardComponent.__Initialize_Internal(base.NativePtr);
		}

		// Token: 0x0601947D RID: 103549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this);

		// Token: 0x0601947E RID: 103550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr @this);

		// Token: 0x0601947F RID: 103551 RVA: 0x0025618B File Offset: 0x0025438B
		static UKuroBillboardComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBillboardComponent");
		}

		// Token: 0x06019480 RID: 103552 RVA: 0x00256199 File Offset: 0x00254399
		protected UKuroBillboardComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC7F RID: 56447
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBillboardComponent";

		// Token: 0x0400DC80 RID: 56448
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC81 RID: 56449
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC82 RID: 56450
		internal static int __PropertyOffset_IsUpdateEveryFrame;

		// Token: 0x0400DC83 RID: 56451
		internal static int __PropertyOffset_OrientAxis;

		// Token: 0x0400DC84 RID: 56452
		internal static int __PropertyOffset_IsFixSize;

		// Token: 0x0400DC85 RID: 56453
		internal static int __PropertyOffset_ScaleSize;

		// Token: 0x0400DC86 RID: 56454
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400DC87 RID: 56455
		internal static int __PropertyOffset_MinSize;
	}
}
