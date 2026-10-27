using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C24 RID: 3108
	[UnrealObjectPath("/Script/Engine.HitResultDouble")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FHitResultDouble : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009DA7 RID: 40359 RVA: 0x000E01EC File Offset: 0x000DE3EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHitResultDouble._ScriptStructPtr != 0) ? FHitResultDouble._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HitResultDouble", ref FHitResultDouble._ScriptStructPtr);
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x06009DA8 RID: 40360 RVA: 0x000E0210 File Offset: 0x000DE410
		// (set) Token: 0x06009DA9 RID: 40361 RVA: 0x000E0229 File Offset: 0x000DE429
		public unsafe bool bBlockingHit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_bBlockingHit) & FHitResultDouble.__PropertyMask_bBlockingHit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_bBlockingHit) = ((*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_bBlockingHit) & ~FHitResultDouble.__PropertyMask_bBlockingHit) | (value ? FHitResultDouble.__PropertyMask_bBlockingHit : 0));
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x06009DAA RID: 40362 RVA: 0x000E0259 File Offset: 0x000DE459
		// (set) Token: 0x06009DAB RID: 40363 RVA: 0x000E0272 File Offset: 0x000DE472
		public unsafe bool bStartPenetrating
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_bStartPenetrating) & FHitResultDouble.__PropertyMask_bStartPenetrating) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_bStartPenetrating) = ((*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_bStartPenetrating) & ~FHitResultDouble.__PropertyMask_bStartPenetrating) | (value ? FHitResultDouble.__PropertyMask_bStartPenetrating : 0));
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x06009DAC RID: 40364 RVA: 0x000E02A2 File Offset: 0x000DE4A2
		// (set) Token: 0x06009DAD RID: 40365 RVA: 0x000E02B2 File Offset: 0x000DE4B2
		public unsafe int FaceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_FaceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_FaceIndex) = value;
			}
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x06009DAE RID: 40366 RVA: 0x000E02C3 File Offset: 0x000DE4C3
		// (set) Token: 0x06009DAF RID: 40367 RVA: 0x000E02D3 File Offset: 0x000DE4D3
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x06009DB0 RID: 40368 RVA: 0x000E02E4 File Offset: 0x000DE4E4
		// (set) Token: 0x06009DB1 RID: 40369 RVA: 0x000E02F4 File Offset: 0x000DE4F4
		public unsafe double Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06009DB2 RID: 40370 RVA: 0x000E0305 File Offset: 0x000DE505
		// (set) Token: 0x06009DB3 RID: 40371 RVA: 0x000E0319 File Offset: 0x000DE519
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06009DB4 RID: 40372 RVA: 0x000E032E File Offset: 0x000DE52E
		// (set) Token: 0x06009DB5 RID: 40373 RVA: 0x000E0342 File Offset: 0x000DE542
		public unsafe FVectorDouble ImpactPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_ImpactPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_ImpactPoint) = value;
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x000E0357 File Offset: 0x000DE557
		// (set) Token: 0x06009DB7 RID: 40375 RVA: 0x000E036B File Offset: 0x000DE56B
		public unsafe FVectorDouble Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x06009DB8 RID: 40376 RVA: 0x000E0380 File Offset: 0x000DE580
		// (set) Token: 0x06009DB9 RID: 40377 RVA: 0x000E0394 File Offset: 0x000DE594
		public unsafe FVectorDouble ImpactNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_ImpactNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_ImpactNormal) = value;
			}
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x06009DBA RID: 40378 RVA: 0x000E03A9 File Offset: 0x000DE5A9
		// (set) Token: 0x06009DBB RID: 40379 RVA: 0x000E03BD File Offset: 0x000DE5BD
		public unsafe FVectorDouble TraceStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_TraceStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_TraceStart) = value;
			}
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x06009DBC RID: 40380 RVA: 0x000E03D2 File Offset: 0x000DE5D2
		// (set) Token: 0x06009DBD RID: 40381 RVA: 0x000E03E6 File Offset: 0x000DE5E6
		public unsafe FVectorDouble TraceEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_TraceEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_TraceEnd) = value;
			}
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x06009DBE RID: 40382 RVA: 0x000E03FB File Offset: 0x000DE5FB
		// (set) Token: 0x06009DBF RID: 40383 RVA: 0x000E040B File Offset: 0x000DE60B
		public unsafe float PenetrationDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_PenetrationDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_PenetrationDepth) = value;
			}
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x000E041C File Offset: 0x000DE61C
		// (set) Token: 0x06009DC1 RID: 40385 RVA: 0x000E042C File Offset: 0x000DE62C
		public unsafe int Item
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Item);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Item) = value;
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x06009DC2 RID: 40386 RVA: 0x000E043D File Offset: 0x000DE63D
		// (set) Token: 0x06009DC3 RID: 40387 RVA: 0x000E044D File Offset: 0x000DE64D
		public unsafe byte ElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_ElementIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_ElementIndex) = value;
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x06009DC4 RID: 40388 RVA: 0x000E045E File Offset: 0x000DE65E
		// (set) Token: 0x06009DC5 RID: 40389 RVA: 0x000E0472 File Offset: 0x000DE672
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UPhysicalMaterial> PhysMaterial
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_PhysMaterial);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_PhysMaterial) = value;
			}
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x06009DC6 RID: 40390 RVA: 0x000E0487 File Offset: 0x000DE687
		// (set) Token: 0x06009DC7 RID: 40391 RVA: 0x000E049B File Offset: 0x000DE69B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Actor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Actor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Actor) = value;
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x06009DC8 RID: 40392 RVA: 0x000E04B0 File Offset: 0x000DE6B0
		// (set) Token: 0x06009DC9 RID: 40393 RVA: 0x000E04C4 File Offset: 0x000DE6C4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UPrimitiveComponent> Component
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Component);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_Component) = value;
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x06009DCA RID: 40394 RVA: 0x000E04D9 File Offset: 0x000DE6D9
		// (set) Token: 0x06009DCB RID: 40395 RVA: 0x000E04ED File Offset: 0x000DE6ED
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06009DCC RID: 40396 RVA: 0x000E0502 File Offset: 0x000DE702
		// (set) Token: 0x06009DCD RID: 40397 RVA: 0x000E0516 File Offset: 0x000DE716
		public unsafe FName MyBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_MyBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResultDouble.__PropertyOffset_MyBoneName) = value;
			}
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x000E052B File Offset: 0x000DE72B
		public FHitResultDouble()
		{
		}

		// Token: 0x06009DCF RID: 40399 RVA: 0x000E0534 File Offset: 0x000DE734
		public FHitResultDouble(bool bBlockingHit, bool bStartPenetrating, int FaceIndex, float Time, double Distance, FVectorDouble Location, FVectorDouble ImpactPoint, FVectorDouble Normal, FVectorDouble ImpactNormal, FVectorDouble TraceStart, FVectorDouble TraceEnd, float PenetrationDepth, int Item, byte ElementIndex, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UPhysicalMaterial> PhysMaterial, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Actor, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UPrimitiveComponent> Component, FName BoneName, FName MyBoneName)
		{
			this.bBlockingHit = bBlockingHit;
			this.bStartPenetrating = bStartPenetrating;
			this.FaceIndex = FaceIndex;
			this.Time = Time;
			this.Distance = Distance;
			this.Location = Location;
			this.ImpactPoint = ImpactPoint;
			this.Normal = Normal;
			this.ImpactNormal = ImpactNormal;
			this.TraceStart = TraceStart;
			this.TraceEnd = TraceEnd;
			this.PenetrationDepth = PenetrationDepth;
			this.Item = Item;
			this.ElementIndex = ElementIndex;
			this.PhysMaterial = PhysMaterial;
			this.Actor = Actor;
			this.Component = Component;
			this.BoneName = BoneName;
			this.MyBoneName = MyBoneName;
		}

		// Token: 0x06009DD0 RID: 40400 RVA: 0x000E05DC File Offset: 0x000DE7DC
		protected override IntPtr GetUStructPtr()
		{
			return FHitResultDouble.StaticStruct();
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x000E05E8 File Offset: 0x000DE7E8
		[NullableContext(2)]
		public FHitResultDouble(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x000E05F2 File Offset: 0x000DE7F2
		public FHitResultDouble(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009DD3 RID: 40403 RVA: 0x000E05FD File Offset: 0x000DE7FD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHitResultDouble(Pointer, false, true);
		}

		// Token: 0x06009DD4 RID: 40404 RVA: 0x000E0607 File Offset: 0x000DE807
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHitResultDouble(Pointer, MemoryOwner);
		}

		// Token: 0x040056F4 RID: 22260
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HitResultDouble";

		// Token: 0x040056F5 RID: 22261
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040056F6 RID: 22262
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x040056F7 RID: 22263
		internal static byte __PropertyMask_bBlockingHit;

		// Token: 0x040056F8 RID: 22264
		internal static int __PropertyOffset_bStartPenetrating;

		// Token: 0x040056F9 RID: 22265
		internal static byte __PropertyMask_bStartPenetrating;

		// Token: 0x040056FA RID: 22266
		internal static int __PropertyOffset_FaceIndex;

		// Token: 0x040056FB RID: 22267
		internal static int __PropertyOffset_Time;

		// Token: 0x040056FC RID: 22268
		internal static int __PropertyOffset_Distance;

		// Token: 0x040056FD RID: 22269
		internal static int __PropertyOffset_Location;

		// Token: 0x040056FE RID: 22270
		internal static int __PropertyOffset_ImpactPoint;

		// Token: 0x040056FF RID: 22271
		internal static int __PropertyOffset_Normal;

		// Token: 0x04005700 RID: 22272
		internal static int __PropertyOffset_ImpactNormal;

		// Token: 0x04005701 RID: 22273
		internal static int __PropertyOffset_TraceStart;

		// Token: 0x04005702 RID: 22274
		internal static int __PropertyOffset_TraceEnd;

		// Token: 0x04005703 RID: 22275
		internal static int __PropertyOffset_PenetrationDepth;

		// Token: 0x04005704 RID: 22276
		internal static int __PropertyOffset_Item;

		// Token: 0x04005705 RID: 22277
		internal static int __PropertyOffset_ElementIndex;

		// Token: 0x04005706 RID: 22278
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x04005707 RID: 22279
		internal static int __PropertyOffset_Actor;

		// Token: 0x04005708 RID: 22280
		internal static int __PropertyOffset_Component;

		// Token: 0x04005709 RID: 22281
		internal static int __PropertyOffset_BoneName;

		// Token: 0x0400570A RID: 22282
		internal static int __PropertyOffset_MyBoneName;
	}
}
