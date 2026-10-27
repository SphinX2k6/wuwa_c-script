using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C23 RID: 3107
	[UnrealObjectPath("/Script/Engine.HitResult")]
	[UnrealStructLayout(148, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 148)]
	public class FHitResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009D79 RID: 40313 RVA: 0x000DFDC8 File Offset: 0x000DDFC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHitResult._ScriptStructPtr != 0) ? FHitResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HitResult", ref FHitResult._ScriptStructPtr);
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06009D7A RID: 40314 RVA: 0x000DFDEC File Offset: 0x000DDFEC
		// (set) Token: 0x06009D7B RID: 40315 RVA: 0x000DFE05 File Offset: 0x000DE005
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

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06009D7C RID: 40316 RVA: 0x000DFE35 File Offset: 0x000DE035
		// (set) Token: 0x06009D7D RID: 40317 RVA: 0x000DFE4E File Offset: 0x000DE04E
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

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x06009D7E RID: 40318 RVA: 0x000DFE7E File Offset: 0x000DE07E
		// (set) Token: 0x06009D7F RID: 40319 RVA: 0x000DFE8E File Offset: 0x000DE08E
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

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x06009D80 RID: 40320 RVA: 0x000DFE9F File Offset: 0x000DE09F
		// (set) Token: 0x06009D81 RID: 40321 RVA: 0x000DFEAF File Offset: 0x000DE0AF
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

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x06009D82 RID: 40322 RVA: 0x000DFEC0 File Offset: 0x000DE0C0
		// (set) Token: 0x06009D83 RID: 40323 RVA: 0x000DFED0 File Offset: 0x000DE0D0
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

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x06009D84 RID: 40324 RVA: 0x000DFEE1 File Offset: 0x000DE0E1
		// (set) Token: 0x06009D85 RID: 40325 RVA: 0x000DFEF5 File Offset: 0x000DE0F5
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

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x000DFF0A File Offset: 0x000DE10A
		// (set) Token: 0x06009D87 RID: 40327 RVA: 0x000DFF1E File Offset: 0x000DE11E
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

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06009D88 RID: 40328 RVA: 0x000DFF33 File Offset: 0x000DE133
		// (set) Token: 0x06009D89 RID: 40329 RVA: 0x000DFF47 File Offset: 0x000DE147
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

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06009D8A RID: 40330 RVA: 0x000DFF5C File Offset: 0x000DE15C
		// (set) Token: 0x06009D8B RID: 40331 RVA: 0x000DFF70 File Offset: 0x000DE170
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

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x06009D8C RID: 40332 RVA: 0x000DFF85 File Offset: 0x000DE185
		// (set) Token: 0x06009D8D RID: 40333 RVA: 0x000DFF99 File Offset: 0x000DE199
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

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x06009D8E RID: 40334 RVA: 0x000DFFAE File Offset: 0x000DE1AE
		// (set) Token: 0x06009D8F RID: 40335 RVA: 0x000DFFC2 File Offset: 0x000DE1C2
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

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x06009D90 RID: 40336 RVA: 0x000DFFD7 File Offset: 0x000DE1D7
		// (set) Token: 0x06009D91 RID: 40337 RVA: 0x000DFFE7 File Offset: 0x000DE1E7
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

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x06009D92 RID: 40338 RVA: 0x000DFFF8 File Offset: 0x000DE1F8
		// (set) Token: 0x06009D93 RID: 40339 RVA: 0x000E0008 File Offset: 0x000DE208
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

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x06009D94 RID: 40340 RVA: 0x000E0019 File Offset: 0x000DE219
		// (set) Token: 0x06009D95 RID: 40341 RVA: 0x000E0029 File Offset: 0x000DE229
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

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x06009D96 RID: 40342 RVA: 0x000E003A File Offset: 0x000DE23A
		// (set) Token: 0x06009D97 RID: 40343 RVA: 0x000E004E File Offset: 0x000DE24E
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

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x06009D98 RID: 40344 RVA: 0x000E0063 File Offset: 0x000DE263
		// (set) Token: 0x06009D99 RID: 40345 RVA: 0x000E0077 File Offset: 0x000DE277
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

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x06009D9A RID: 40346 RVA: 0x000E008C File Offset: 0x000DE28C
		// (set) Token: 0x06009D9B RID: 40347 RVA: 0x000E00A0 File Offset: 0x000DE2A0
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

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x06009D9C RID: 40348 RVA: 0x000E00B5 File Offset: 0x000DE2B5
		// (set) Token: 0x06009D9D RID: 40349 RVA: 0x000E00C9 File Offset: 0x000DE2C9
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

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x06009D9E RID: 40350 RVA: 0x000E00DE File Offset: 0x000DE2DE
		// (set) Token: 0x06009D9F RID: 40351 RVA: 0x000E00F2 File Offset: 0x000DE2F2
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

		// Token: 0x06009DA0 RID: 40352 RVA: 0x000E0107 File Offset: 0x000DE307
		public FHitResult()
		{
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x000E0110 File Offset: 0x000DE310
		public FHitResult(bool bBlockingHit, bool bStartPenetrating, int FaceIndex, float Time, float Distance, FVector_NetQuantize Location, FVector_NetQuantize ImpactPoint, FVector_NetQuantizeNormal Normal, FVector_NetQuantizeNormal ImpactNormal, FVector_NetQuantize TraceStart, FVector_NetQuantize TraceEnd, float PenetrationDepth, int Item, byte ElementIndex, [Nullable(new byte[]
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

		// Token: 0x06009DA2 RID: 40354 RVA: 0x000E01B8 File Offset: 0x000DE3B8
		protected override IntPtr GetUStructPtr()
		{
			return FHitResult.StaticStruct();
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x000E01C4 File Offset: 0x000DE3C4
		[NullableContext(2)]
		public FHitResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x000E01CE File Offset: 0x000DE3CE
		public FHitResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x000E01D9 File Offset: 0x000DE3D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHitResult(Pointer, false, true);
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x000E01E3 File Offset: 0x000DE3E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHitResult(Pointer, MemoryOwner);
		}

		// Token: 0x040056DD RID: 22237
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HitResult";

		// Token: 0x040056DE RID: 22238
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040056DF RID: 22239
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x040056E0 RID: 22240
		internal static byte __PropertyMask_bBlockingHit;

		// Token: 0x040056E1 RID: 22241
		internal static int __PropertyOffset_bStartPenetrating;

		// Token: 0x040056E2 RID: 22242
		internal static byte __PropertyMask_bStartPenetrating;

		// Token: 0x040056E3 RID: 22243
		internal static int __PropertyOffset_FaceIndex;

		// Token: 0x040056E4 RID: 22244
		internal static int __PropertyOffset_Time;

		// Token: 0x040056E5 RID: 22245
		internal static int __PropertyOffset_Distance;

		// Token: 0x040056E6 RID: 22246
		internal static int __PropertyOffset_Location;

		// Token: 0x040056E7 RID: 22247
		internal static int __PropertyOffset_ImpactPoint;

		// Token: 0x040056E8 RID: 22248
		internal static int __PropertyOffset_Normal;

		// Token: 0x040056E9 RID: 22249
		internal static int __PropertyOffset_ImpactNormal;

		// Token: 0x040056EA RID: 22250
		internal static int __PropertyOffset_TraceStart;

		// Token: 0x040056EB RID: 22251
		internal static int __PropertyOffset_TraceEnd;

		// Token: 0x040056EC RID: 22252
		internal static int __PropertyOffset_PenetrationDepth;

		// Token: 0x040056ED RID: 22253
		internal static int __PropertyOffset_Item;

		// Token: 0x040056EE RID: 22254
		internal static int __PropertyOffset_ElementIndex;

		// Token: 0x040056EF RID: 22255
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x040056F0 RID: 22256
		internal static int __PropertyOffset_Actor;

		// Token: 0x040056F1 RID: 22257
		internal static int __PropertyOffset_Component;

		// Token: 0x040056F2 RID: 22258
		internal static int __PropertyOffset_BoneName;

		// Token: 0x040056F3 RID: 22259
		internal static int __PropertyOffset_MyBoneName;
	}
}
