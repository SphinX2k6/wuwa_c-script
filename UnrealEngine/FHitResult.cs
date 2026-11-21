using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200021A RID: 538
	[UnrealObjectPath("/Script/Engine.HitResult")]
	[UnrealStructLayout(148, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 148)]
	public class FHitResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002473 RID: 9331 RVA: 0x000348A3 File Offset: 0x00032AA3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHitResult._ScriptStructPtr != 0) ? FHitResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HitResult", ref FHitResult._ScriptStructPtr);
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000348C7 File Offset: 0x00032AC7
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x000348E0 File Offset: 0x00032AE0
		public unsafe bool bBlockingHit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_bBlockingHit) & FHitResult.__PropertyMask_bBlockingHit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHitResult.__PropertyOffset_bBlockingHit) = ((*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_bBlockingHit) & ~FHitResult.__PropertyMask_bBlockingHit) | (value ? FHitResult.__PropertyMask_bBlockingHit : 0));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x00034910 File Offset: 0x00032B10
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x00034929 File Offset: 0x00032B29
		public unsafe bool bStartPenetrating
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_bStartPenetrating) & FHitResult.__PropertyMask_bStartPenetrating) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHitResult.__PropertyOffset_bStartPenetrating) = ((*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_bStartPenetrating) & ~FHitResult.__PropertyMask_bStartPenetrating) | (value ? FHitResult.__PropertyMask_bStartPenetrating : 0));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x00034959 File Offset: 0x00032B59
		// (set) Token: 0x06002479 RID: 9337 RVA: 0x00034969 File Offset: 0x00032B69
		public unsafe int FaceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_FaceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_FaceIndex) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x0003497A File Offset: 0x00032B7A
		// (set) Token: 0x0600247B RID: 9339 RVA: 0x0003498A File Offset: 0x00032B8A
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x0003499B File Offset: 0x00032B9B
		// (set) Token: 0x0600247D RID: 9341 RVA: 0x000349AB File Offset: 0x00032BAB
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000349BC File Offset: 0x00032BBC
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x000349D0 File Offset: 0x00032BD0
		public unsafe FVector_NetQuantize Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000349E5 File Offset: 0x00032BE5
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x000349F9 File Offset: 0x00032BF9
		public unsafe FVector_NetQuantize ImpactPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_ImpactPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_ImpactPoint) = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x00034A0E File Offset: 0x00032C0E
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x00034A22 File Offset: 0x00032C22
		public unsafe FVector_NetQuantizeNormal Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x00034A37 File Offset: 0x00032C37
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x00034A4B File Offset: 0x00032C4B
		public unsafe FVector_NetQuantizeNormal ImpactNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_ImpactNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_ImpactNormal) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x00034A60 File Offset: 0x00032C60
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x00034A74 File Offset: 0x00032C74
		public unsafe FVector_NetQuantize TraceStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_TraceStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_TraceStart) = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x00034A89 File Offset: 0x00032C89
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x00034A9D File Offset: 0x00032C9D
		public unsafe FVector_NetQuantize TraceEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_TraceEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_TraceEnd) = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x00034AB2 File Offset: 0x00032CB2
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x00034AC2 File Offset: 0x00032CC2
		public unsafe float PenetrationDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_PenetrationDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_PenetrationDepth) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x00034AD3 File Offset: 0x00032CD3
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x00034AE3 File Offset: 0x00032CE3
		public unsafe int Item
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Item);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Item) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x00034AF4 File Offset: 0x00032CF4
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x00034B04 File Offset: 0x00032D04
		public unsafe byte ElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_ElementIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_ElementIndex) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x00034B15 File Offset: 0x00032D15
		// (set) Token: 0x06002491 RID: 9361 RVA: 0x00034B29 File Offset: 0x00032D29
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
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_PhysMaterial);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_PhysMaterial) = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x00034B3E File Offset: 0x00032D3E
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x00034B52 File Offset: 0x00032D52
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
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Actor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Actor) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x00034B67 File Offset: 0x00032D67
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x00034B7B File Offset: 0x00032D7B
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
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Component);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_Component) = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x00034B90 File Offset: 0x00032D90
		// (set) Token: 0x06002497 RID: 9367 RVA: 0x00034BA4 File Offset: 0x00032DA4
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x00034BB9 File Offset: 0x00032DB9
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x00034BCD File Offset: 0x00032DCD
		public unsafe FName MyBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_MyBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHitResult.__PropertyOffset_MyBoneName) = value;
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00034BE2 File Offset: 0x00032DE2
		public FHitResult()
		{
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00034BEA File Offset: 0x00032DEA
		protected override IntPtr GetUStructPtr()
		{
			return FHitResult.StaticStruct();
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00034BF6 File Offset: 0x00032DF6
		[NullableContext(2)]
		public FHitResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00034C00 File Offset: 0x00032E00
		public FHitResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00034C0B File Offset: 0x00032E0B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHitResult(Pointer, false, true);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00034C15 File Offset: 0x00032E15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHitResult(Pointer, MemoryOwner);
		}

		// Token: 0x04000DAB RID: 3499
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HitResult";

		// Token: 0x04000DAC RID: 3500
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DAD RID: 3501
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x04000DAE RID: 3502
		internal static byte __PropertyMask_bBlockingHit;

		// Token: 0x04000DAF RID: 3503
		internal static int __PropertyOffset_bStartPenetrating;

		// Token: 0x04000DB0 RID: 3504
		internal static byte __PropertyMask_bStartPenetrating;

		// Token: 0x04000DB1 RID: 3505
		internal static int __PropertyOffset_FaceIndex;

		// Token: 0x04000DB2 RID: 3506
		internal static int __PropertyOffset_Time;

		// Token: 0x04000DB3 RID: 3507
		internal static int __PropertyOffset_Distance;

		// Token: 0x04000DB4 RID: 3508
		internal static int __PropertyOffset_Location;

		// Token: 0x04000DB5 RID: 3509
		internal static int __PropertyOffset_ImpactPoint;

		// Token: 0x04000DB6 RID: 3510
		internal static int __PropertyOffset_Normal;

		// Token: 0x04000DB7 RID: 3511
		internal static int __PropertyOffset_ImpactNormal;

		// Token: 0x04000DB8 RID: 3512
		internal static int __PropertyOffset_TraceStart;

		// Token: 0x04000DB9 RID: 3513
		internal static int __PropertyOffset_TraceEnd;

		// Token: 0x04000DBA RID: 3514
		internal static int __PropertyOffset_PenetrationDepth;

		// Token: 0x04000DBB RID: 3515
		internal static int __PropertyOffset_Item;

		// Token: 0x04000DBC RID: 3516
		internal static int __PropertyOffset_ElementIndex;

		// Token: 0x04000DBD RID: 3517
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x04000DBE RID: 3518
		internal static int __PropertyOffset_Actor;

		// Token: 0x04000DBF RID: 3519
		internal static int __PropertyOffset_Component;

		// Token: 0x04000DC0 RID: 3520
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04000DC1 RID: 3521
		internal static int __PropertyOffset_MyBoneName;
	}
}
