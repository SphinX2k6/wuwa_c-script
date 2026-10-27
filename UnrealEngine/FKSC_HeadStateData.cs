using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001883 RID: 6275
	[UnrealObjectPath("/Script/KuroGameplayUI.KSC_HeadStateData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKSC_HeadStateData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017202 RID: 94722 RVA: 0x0021B260 File Offset: 0x00219460
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_HeadStateData._ScriptStructPtr != 0) ? FKSC_HeadStateData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.KSC_HeadStateData", ref FKSC_HeadStateData._ScriptStructPtr);
		}

		// Token: 0x17005D0E RID: 23822
		// (get) Token: 0x06017203 RID: 94723 RVA: 0x0021B284 File Offset: 0x00219484
		// (set) Token: 0x06017204 RID: 94724 RVA: 0x0021B298 File Offset: 0x00219498
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17005D0F RID: 23823
		// (get) Token: 0x06017205 RID: 94725 RVA: 0x0021B2AD File Offset: 0x002194AD
		// (set) Token: 0x06017206 RID: 94726 RVA: 0x0021B2BD File Offset: 0x002194BD
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x17005D10 RID: 23824
		// (get) Token: 0x06017207 RID: 94727 RVA: 0x0021B2CE File Offset: 0x002194CE
		// (set) Token: 0x06017208 RID: 94728 RVA: 0x0021B2DE File Offset: 0x002194DE
		public unsafe int CurHp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_CurHp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_CurHp) = value;
			}
		}

		// Token: 0x17005D11 RID: 23825
		// (get) Token: 0x06017209 RID: 94729 RVA: 0x0021B2EF File Offset: 0x002194EF
		// (set) Token: 0x0601720A RID: 94730 RVA: 0x0021B2FF File Offset: 0x002194FF
		public unsafe int MaxHp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_MaxHp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_MaxHp) = value;
			}
		}

		// Token: 0x17005D12 RID: 23826
		// (get) Token: 0x0601720B RID: 94731 RVA: 0x0021B310 File Offset: 0x00219510
		// (set) Token: 0x0601720C RID: 94732 RVA: 0x0021B320 File Offset: 0x00219520
		public unsafe int Shield
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_Shield);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_Shield) = value;
			}
		}

		// Token: 0x17005D13 RID: 23827
		// (get) Token: 0x0601720D RID: 94733 RVA: 0x0021B331 File Offset: 0x00219531
		// (set) Token: 0x0601720E RID: 94734 RVA: 0x0021B341 File Offset: 0x00219541
		public unsafe double DistSquared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_DistSquared);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_DistSquared) = value;
			}
		}

		// Token: 0x17005D14 RID: 23828
		// (get) Token: 0x0601720F RID: 94735 RVA: 0x0021B352 File Offset: 0x00219552
		// (set) Token: 0x06017210 RID: 94736 RVA: 0x0021B362 File Offset: 0x00219562
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_bVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_HeadStateData.__PropertyOffset_bVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x06017211 RID: 94737 RVA: 0x0021B373 File Offset: 0x00219573
		public FKSC_HeadStateData()
		{
		}

		// Token: 0x06017212 RID: 94738 RVA: 0x0021B37B File Offset: 0x0021957B
		public FKSC_HeadStateData(FVectorDouble Location, int EntityId, int CurHp, int MaxHp, int Shield, double DistSquared, bool bVisible)
		{
			this.Location = Location;
			this.EntityId = EntityId;
			this.CurHp = CurHp;
			this.MaxHp = MaxHp;
			this.Shield = Shield;
			this.DistSquared = DistSquared;
			this.bVisible = bVisible;
		}

		// Token: 0x06017213 RID: 94739 RVA: 0x0021B3B8 File Offset: 0x002195B8
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_HeadStateData.StaticStruct();
		}

		// Token: 0x06017214 RID: 94740 RVA: 0x0021B3C4 File Offset: 0x002195C4
		[NullableContext(2)]
		public FKSC_HeadStateData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017215 RID: 94741 RVA: 0x0021B3CE File Offset: 0x002195CE
		public FKSC_HeadStateData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017216 RID: 94742 RVA: 0x0021B3D9 File Offset: 0x002195D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_HeadStateData(Pointer, false, true);
		}

		// Token: 0x06017217 RID: 94743 RVA: 0x0021B3E3 File Offset: 0x002195E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_HeadStateData(Pointer, MemoryOwner);
		}

		// Token: 0x0400C8B5 RID: 51381
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplayUI.KSC_HeadStateData";

		// Token: 0x0400C8B6 RID: 51382
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C8B7 RID: 51383
		internal static int __PropertyOffset_Location;

		// Token: 0x0400C8B8 RID: 51384
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400C8B9 RID: 51385
		internal static int __PropertyOffset_CurHp;

		// Token: 0x0400C8BA RID: 51386
		internal static int __PropertyOffset_MaxHp;

		// Token: 0x0400C8BB RID: 51387
		internal static int __PropertyOffset_Shield;

		// Token: 0x0400C8BC RID: 51388
		internal static int __PropertyOffset_DistSquared;

		// Token: 0x0400C8BD RID: 51389
		internal static int __PropertyOffset_bVisible;
	}
}
