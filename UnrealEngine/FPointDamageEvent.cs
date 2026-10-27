using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001014 RID: 4116
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PointDamageEvent")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FPointDamageEvent : FDamageEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E105 RID: 57605 RVA: 0x0014ADDA File Offset: 0x00148FDA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointDamageEvent._ScriptStructPtr != 0) ? FPointDamageEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PointDamageEvent", ref FPointDamageEvent._ScriptStructPtr);
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x0600E106 RID: 57606 RVA: 0x0014ADFE File Offset: 0x00148FFE
		// (set) Token: 0x0600E107 RID: 57607 RVA: 0x0014AE0E File Offset: 0x0014900E
		public unsafe float Damage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointDamageEvent.__PropertyOffset_Damage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointDamageEvent.__PropertyOffset_Damage) = value;
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600E108 RID: 57608 RVA: 0x0014AE1F File Offset: 0x0014901F
		// (set) Token: 0x0600E109 RID: 57609 RVA: 0x0014AE33 File Offset: 0x00149033
		public unsafe FVector_NetQuantizeNormal ShotDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPointDamageEvent.__PropertyOffset_ShotDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPointDamageEvent.__PropertyOffset_ShotDirection) = value;
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600E10A RID: 57610 RVA: 0x0014AE48 File Offset: 0x00149048
		// (set) Token: 0x0600E10B RID: 57611 RVA: 0x0014AE8B File Offset: 0x0014908B
		public FHitResult HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new FHitResult(base.NativePtr + (IntPtr)FPointDamageEvent.__PropertyOffset_HitInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)FPointDamageEvent.__PropertyOffset_HitInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600E10C RID: 57612 RVA: 0x0014AEAC File Offset: 0x001490AC
		public FPointDamageEvent()
		{
		}

		// Token: 0x0600E10D RID: 57613 RVA: 0x0014AEB4 File Offset: 0x001490B4
		public FPointDamageEvent(float Damage, FVector_NetQuantizeNormal ShotDirection, FHitResult HitInfo, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDamageType> DamageTypeClass)
		{
			this.Damage = Damage;
			this.ShotDirection = ShotDirection;
			this.HitInfo = HitInfo;
			base.DamageTypeClass = DamageTypeClass;
		}

		// Token: 0x0600E10E RID: 57614 RVA: 0x0014AED9 File Offset: 0x001490D9
		protected override IntPtr GetUStructPtr()
		{
			return FPointDamageEvent.StaticStruct();
		}

		// Token: 0x0600E10F RID: 57615 RVA: 0x0014AEE5 File Offset: 0x001490E5
		[NullableContext(2)]
		public FPointDamageEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E110 RID: 57616 RVA: 0x0014AEEF File Offset: 0x001490EF
		public FPointDamageEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E111 RID: 57617 RVA: 0x0014AEFA File Offset: 0x001490FA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointDamageEvent(Pointer, false, true);
		}

		// Token: 0x0600E112 RID: 57618 RVA: 0x0014AF04 File Offset: 0x00149104
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointDamageEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040078DE RID: 30942
		public new const string __ObjectPath = "/Script/Engine.PointDamageEvent";

		// Token: 0x040078DF RID: 30943
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040078E0 RID: 30944
		internal static int __PropertyOffset_Damage;

		// Token: 0x040078E1 RID: 30945
		internal static int __PropertyOffset_ShotDirection;

		// Token: 0x040078E2 RID: 30946
		internal static int __PropertyOffset_HitInfo;

		// Token: 0x040078E3 RID: 30947
		[Nullable(2)]
		private FHitResult _HitInfo;
	}
}
