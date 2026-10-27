using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CF5 RID: 7413
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCShapeMaterialTableRow")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FKSCShapeMaterialTableRow : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C832 RID: 116786 RVA: 0x002A28E1 File Offset: 0x002A0AE1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCShapeMaterialTableRow._ScriptStructPtr != 0) ? FKSCShapeMaterialTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCShapeMaterialTableRow", ref FKSCShapeMaterialTableRow._ScriptStructPtr);
		}

		// Token: 0x170072D9 RID: 29401
		// (get) Token: 0x0601C833 RID: 116787 RVA: 0x002A2905 File Offset: 0x002A0B05
		// (set) Token: 0x0601C834 RID: 116788 RVA: 0x002A2919 File Offset: 0x002A0B19
		[Nullable(1)]
		public unsafe string Desc
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_Desc)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x170072DA RID: 29402
		// (get) Token: 0x0601C835 RID: 116789 RVA: 0x002A292E File Offset: 0x002A0B2E
		// (set) Token: 0x0601C836 RID: 116790 RVA: 0x002A293E File Offset: 0x002A0B3E
		public unsafe float BounceTangentSpeedRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedRatio) = value;
			}
		}

		// Token: 0x170072DB RID: 29403
		// (get) Token: 0x0601C837 RID: 116791 RVA: 0x002A294F File Offset: 0x002A0B4F
		// (set) Token: 0x0601C838 RID: 116792 RVA: 0x002A295F File Offset: 0x002A0B5F
		public unsafe float BounceTangentSpeedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedValue) = value;
			}
		}

		// Token: 0x170072DC RID: 29404
		// (get) Token: 0x0601C839 RID: 116793 RVA: 0x002A2970 File Offset: 0x002A0B70
		// (set) Token: 0x0601C83A RID: 116794 RVA: 0x002A2980 File Offset: 0x002A0B80
		public unsafe float BounceTangentSpeedMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedMax) = value;
			}
		}

		// Token: 0x170072DD RID: 29405
		// (get) Token: 0x0601C83B RID: 116795 RVA: 0x002A2991 File Offset: 0x002A0B91
		// (set) Token: 0x0601C83C RID: 116796 RVA: 0x002A29A1 File Offset: 0x002A0BA1
		public unsafe float BounceTangentSpeedMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceTangentSpeedMin) = value;
			}
		}

		// Token: 0x170072DE RID: 29406
		// (get) Token: 0x0601C83D RID: 116797 RVA: 0x002A29B2 File Offset: 0x002A0BB2
		// (set) Token: 0x0601C83E RID: 116798 RVA: 0x002A29C2 File Offset: 0x002A0BC2
		public unsafe float BounceNormalSpeedRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedRatio) = value;
			}
		}

		// Token: 0x170072DF RID: 29407
		// (get) Token: 0x0601C83F RID: 116799 RVA: 0x002A29D3 File Offset: 0x002A0BD3
		// (set) Token: 0x0601C840 RID: 116800 RVA: 0x002A29E3 File Offset: 0x002A0BE3
		public unsafe float BounceNormalSpeedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedValue) = value;
			}
		}

		// Token: 0x170072E0 RID: 29408
		// (get) Token: 0x0601C841 RID: 116801 RVA: 0x002A29F4 File Offset: 0x002A0BF4
		// (set) Token: 0x0601C842 RID: 116802 RVA: 0x002A2A04 File Offset: 0x002A0C04
		public unsafe float BounceNormalSpeedMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedMax) = value;
			}
		}

		// Token: 0x170072E1 RID: 29409
		// (get) Token: 0x0601C843 RID: 116803 RVA: 0x002A2A15 File Offset: 0x002A0C15
		// (set) Token: 0x0601C844 RID: 116804 RVA: 0x002A2A25 File Offset: 0x002A0C25
		public unsafe float BounceNormalSpeedMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BounceNormalSpeedMin) = value;
			}
		}

		// Token: 0x170072E2 RID: 29410
		// (get) Token: 0x0601C845 RID: 116805 RVA: 0x002A2A36 File Offset: 0x002A0C36
		// (set) Token: 0x0601C846 RID: 116806 RVA: 0x002A2A46 File Offset: 0x002A0C46
		public unsafe bool bIsEnableTangentMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsEnableTangentMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsEnableTangentMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072E3 RID: 29411
		// (get) Token: 0x0601C847 RID: 116807 RVA: 0x002A2A57 File Offset: 0x002A0C57
		// (set) Token: 0x0601C848 RID: 116808 RVA: 0x002A2A67 File Offset: 0x002A0C67
		public unsafe float TangentMoveIncidentAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_TangentMoveIncidentAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_TangentMoveIncidentAngle) = value;
			}
		}

		// Token: 0x170072E4 RID: 29412
		// (get) Token: 0x0601C849 RID: 116809 RVA: 0x002A2A78 File Offset: 0x002A0C78
		// (set) Token: 0x0601C84A RID: 116810 RVA: 0x002A2A88 File Offset: 0x002A0C88
		public unsafe float FrictionSpeedLost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_FrictionSpeedLost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_FrictionSpeedLost) = value;
			}
		}

		// Token: 0x170072E5 RID: 29413
		// (get) Token: 0x0601C84B RID: 116811 RVA: 0x002A2A99 File Offset: 0x002A0C99
		// (set) Token: 0x0601C84C RID: 116812 RVA: 0x002A2AA9 File Offset: 0x002A0CA9
		public unsafe bool bIsTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsTrigger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsTrigger) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072E6 RID: 29414
		// (get) Token: 0x0601C84D RID: 116813 RVA: 0x002A2ABA File Offset: 0x002A0CBA
		// (set) Token: 0x0601C84E RID: 116814 RVA: 0x002A2ACA File Offset: 0x002A0CCA
		public unsafe EKSC_ShapeMaterial_TriggerType TriggerType
		{
			get
			{
				return (EKSC_ShapeMaterial_TriggerType)(*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_TriggerType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_TriggerType) = (byte)value;
			}
		}

		// Token: 0x170072E7 RID: 29415
		// (get) Token: 0x0601C84F RID: 116815 RVA: 0x002A2ADB File Offset: 0x002A0CDB
		// (set) Token: 0x0601C850 RID: 116816 RVA: 0x002A2AEB File Offset: 0x002A0CEB
		public unsafe bool bIsSimpleTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsSimpleTrigger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsSimpleTrigger) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072E8 RID: 29416
		// (get) Token: 0x0601C851 RID: 116817 RVA: 0x002A2AFC File Offset: 0x002A0CFC
		// (set) Token: 0x0601C852 RID: 116818 RVA: 0x002A2B0C File Offset: 0x002A0D0C
		public unsafe EKSC_ShapeMaterial_GateDirection GateDirection
		{
			get
			{
				return (EKSC_ShapeMaterial_GateDirection)(*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_GateDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_GateDirection) = (byte)value;
			}
		}

		// Token: 0x170072E9 RID: 29417
		// (get) Token: 0x0601C853 RID: 116819 RVA: 0x002A2B1D File Offset: 0x002A0D1D
		// (set) Token: 0x0601C854 RID: 116820 RVA: 0x002A2B2D File Offset: 0x002A0D2D
		public unsafe float DotProductTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_DotProductTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_DotProductTolerance) = value;
			}
		}

		// Token: 0x170072EA RID: 29418
		// (get) Token: 0x0601C855 RID: 116821 RVA: 0x002A2B3E File Offset: 0x002A0D3E
		// (set) Token: 0x0601C856 RID: 116822 RVA: 0x002A2B4E File Offset: 0x002A0D4E
		public unsafe bool IsResetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_IsResetSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_IsResetSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072EB RID: 29419
		// (get) Token: 0x0601C857 RID: 116823 RVA: 0x002A2B5F File Offset: 0x002A0D5F
		// (set) Token: 0x0601C858 RID: 116824 RVA: 0x002A2B6F File Offset: 0x002A0D6F
		public unsafe bool IsFixPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_IsFixPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_IsFixPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072EC RID: 29420
		// (get) Token: 0x0601C859 RID: 116825 RVA: 0x002A2B80 File Offset: 0x002A0D80
		// (set) Token: 0x0601C85A RID: 116826 RVA: 0x002A2B94 File Offset: 0x002A0D94
		public unsafe FVector TeleportPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_TeleportPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_TeleportPosition) = value;
			}
		}

		// Token: 0x170072ED RID: 29421
		// (get) Token: 0x0601C85B RID: 116827 RVA: 0x002A2BA9 File Offset: 0x002A0DA9
		// (set) Token: 0x0601C85C RID: 116828 RVA: 0x002A2BB9 File Offset: 0x002A0DB9
		public unsafe bool IsRelativePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_IsRelativePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_IsRelativePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072EE RID: 29422
		// (get) Token: 0x0601C85D RID: 116829 RVA: 0x002A2BCA File Offset: 0x002A0DCA
		// (set) Token: 0x0601C85E RID: 116830 RVA: 0x002A2BDA File Offset: 0x002A0DDA
		public unsafe long DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_DamageId) = value;
			}
		}

		// Token: 0x170072EF RID: 29423
		// (get) Token: 0x0601C85F RID: 116831 RVA: 0x002A2BEB File Offset: 0x002A0DEB
		// (set) Token: 0x0601C860 RID: 116832 RVA: 0x002A2BFF File Offset: 0x002A0DFF
		public unsafe UEffectModelBase TriggerEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + FKSCShapeMaterialTableRow.__PropertyOffset_TriggerEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSCShapeMaterialTableRow.__PropertyOffset_TriggerEffect, value);
			}
		}

		// Token: 0x170072F0 RID: 29424
		// (get) Token: 0x0601C861 RID: 116833 RVA: 0x002A2C14 File Offset: 0x002A0E14
		// (set) Token: 0x0601C862 RID: 116834 RVA: 0x002A2C28 File Offset: 0x002A0E28
		public unsafe FTransform EffectOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_EffectOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_EffectOffset) = value;
			}
		}

		// Token: 0x170072F1 RID: 29425
		// (get) Token: 0x0601C863 RID: 116835 RVA: 0x002A2C3D File Offset: 0x002A0E3D
		// (set) Token: 0x0601C864 RID: 116836 RVA: 0x002A2C4D File Offset: 0x002A0E4D
		public unsafe EKSC_ShapeMaterial_EffectTarget EffectTarget
		{
			get
			{
				return (EKSC_ShapeMaterial_EffectTarget)(*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_EffectTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_EffectTarget) = (byte)value;
			}
		}

		// Token: 0x170072F2 RID: 29426
		// (get) Token: 0x0601C865 RID: 116837 RVA: 0x002A2C5E File Offset: 0x002A0E5E
		// (set) Token: 0x0601C866 RID: 116838 RVA: 0x002A2C6E File Offset: 0x002A0E6E
		public unsafe bool bIsUseForBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsUseForBattle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_bIsUseForBattle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072F3 RID: 29427
		// (get) Token: 0x0601C867 RID: 116839 RVA: 0x002A2C7F File Offset: 0x002A0E7F
		// (set) Token: 0x0601C868 RID: 116840 RVA: 0x002A2C93 File Offset: 0x002A0E93
		public unsafe UKSC_DA_Buff Buff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + FKSCShapeMaterialTableRow.__PropertyOffset_Buff);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSCShapeMaterialTableRow.__PropertyOffset_Buff, value);
			}
		}

		// Token: 0x170072F4 RID: 29428
		// (get) Token: 0x0601C869 RID: 116841 RVA: 0x002A2CA8 File Offset: 0x002A0EA8
		// (set) Token: 0x0601C86A RID: 116842 RVA: 0x002A2CB8 File Offset: 0x002A0EB8
		public unsafe EKSC_ShapeMaterial_BuffTarget BuffTarget
		{
			get
			{
				return (EKSC_ShapeMaterial_BuffTarget)(*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BuffTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BuffTarget) = (byte)value;
			}
		}

		// Token: 0x170072F5 RID: 29429
		// (get) Token: 0x0601C86B RID: 116843 RVA: 0x002A2CC9 File Offset: 0x002A0EC9
		// (set) Token: 0x0601C86C RID: 116844 RVA: 0x002A2CD9 File Offset: 0x002A0ED9
		public unsafe float BuffCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BuffCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCShapeMaterialTableRow.__PropertyOffset_BuffCD) = value;
			}
		}

		// Token: 0x170072F6 RID: 29430
		// (get) Token: 0x0601C86D RID: 116845 RVA: 0x002A2CEA File Offset: 0x002A0EEA
		// (set) Token: 0x0601C86E RID: 116846 RVA: 0x002A2CFE File Offset: 0x002A0EFE
		public unsafe UAkAudioEvent CollisionAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + FKSCShapeMaterialTableRow.__PropertyOffset_CollisionAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSCShapeMaterialTableRow.__PropertyOffset_CollisionAudioEvent, value);
			}
		}

		// Token: 0x0601C86F RID: 116847 RVA: 0x002A2D13 File Offset: 0x002A0F13
		public FKSCShapeMaterialTableRow()
		{
		}

		// Token: 0x0601C870 RID: 116848 RVA: 0x002A2D1C File Offset: 0x002A0F1C
		[NullableContext(1)]
		public FKSCShapeMaterialTableRow(string Desc, float BounceTangentSpeedRatio, float BounceTangentSpeedValue, float BounceTangentSpeedMax, float BounceTangentSpeedMin, float BounceNormalSpeedRatio, float BounceNormalSpeedValue, float BounceNormalSpeedMax, float BounceNormalSpeedMin, bool bIsEnableTangentMove, float TangentMoveIncidentAngle, float FrictionSpeedLost, bool bIsTrigger, EKSC_ShapeMaterial_TriggerType TriggerType, bool bIsSimpleTrigger, EKSC_ShapeMaterial_GateDirection GateDirection, float DotProductTolerance, bool IsResetSpeed, bool IsFixPosition, FVector TeleportPosition, bool IsRelativePosition, long DamageId, UEffectModelBase TriggerEffect, FTransform EffectOffset, EKSC_ShapeMaterial_EffectTarget EffectTarget, bool bIsUseForBattle, UKSC_DA_Buff Buff, EKSC_ShapeMaterial_BuffTarget BuffTarget, float BuffCD, UAkAudioEvent CollisionAudioEvent)
		{
			this.Desc = Desc;
			this.BounceTangentSpeedRatio = BounceTangentSpeedRatio;
			this.BounceTangentSpeedValue = BounceTangentSpeedValue;
			this.BounceTangentSpeedMax = BounceTangentSpeedMax;
			this.BounceTangentSpeedMin = BounceTangentSpeedMin;
			this.BounceNormalSpeedRatio = BounceNormalSpeedRatio;
			this.BounceNormalSpeedValue = BounceNormalSpeedValue;
			this.BounceNormalSpeedMax = BounceNormalSpeedMax;
			this.BounceNormalSpeedMin = BounceNormalSpeedMin;
			this.bIsEnableTangentMove = bIsEnableTangentMove;
			this.TangentMoveIncidentAngle = TangentMoveIncidentAngle;
			this.FrictionSpeedLost = FrictionSpeedLost;
			this.bIsTrigger = bIsTrigger;
			this.TriggerType = TriggerType;
			this.bIsSimpleTrigger = bIsSimpleTrigger;
			this.GateDirection = GateDirection;
			this.DotProductTolerance = DotProductTolerance;
			this.IsResetSpeed = IsResetSpeed;
			this.IsFixPosition = IsFixPosition;
			this.TeleportPosition = TeleportPosition;
			this.IsRelativePosition = IsRelativePosition;
			this.DamageId = DamageId;
			this.TriggerEffect = TriggerEffect;
			this.EffectOffset = EffectOffset;
			this.EffectTarget = EffectTarget;
			this.bIsUseForBattle = bIsUseForBattle;
			this.Buff = Buff;
			this.BuffTarget = BuffTarget;
			this.BuffCD = BuffCD;
			this.CollisionAudioEvent = CollisionAudioEvent;
		}

		// Token: 0x0601C871 RID: 116849 RVA: 0x002A2E1C File Offset: 0x002A101C
		protected override IntPtr GetUStructPtr()
		{
			return FKSCShapeMaterialTableRow.StaticStruct();
		}

		// Token: 0x0601C872 RID: 116850 RVA: 0x002A2E28 File Offset: 0x002A1028
		public FKSCShapeMaterialTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C873 RID: 116851 RVA: 0x002A2E32 File Offset: 0x002A1032
		public FKSCShapeMaterialTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C874 RID: 116852 RVA: 0x002A2E3D File Offset: 0x002A103D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCShapeMaterialTableRow(Pointer, false, true);
		}

		// Token: 0x0601C875 RID: 116853 RVA: 0x002A2E47 File Offset: 0x002A1047
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCShapeMaterialTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400F75A RID: 63322
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCShapeMaterialTableRow";

		// Token: 0x0400F75B RID: 63323
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F75C RID: 63324
		internal static int __PropertyOffset_Desc;

		// Token: 0x0400F75D RID: 63325
		internal static int __PropertyOffset_BounceTangentSpeedRatio;

		// Token: 0x0400F75E RID: 63326
		internal static int __PropertyOffset_BounceTangentSpeedValue;

		// Token: 0x0400F75F RID: 63327
		internal static int __PropertyOffset_BounceTangentSpeedMax;

		// Token: 0x0400F760 RID: 63328
		internal static int __PropertyOffset_BounceTangentSpeedMin;

		// Token: 0x0400F761 RID: 63329
		internal static int __PropertyOffset_BounceNormalSpeedRatio;

		// Token: 0x0400F762 RID: 63330
		internal static int __PropertyOffset_BounceNormalSpeedValue;

		// Token: 0x0400F763 RID: 63331
		internal static int __PropertyOffset_BounceNormalSpeedMax;

		// Token: 0x0400F764 RID: 63332
		internal static int __PropertyOffset_BounceNormalSpeedMin;

		// Token: 0x0400F765 RID: 63333
		internal static int __PropertyOffset_bIsEnableTangentMove;

		// Token: 0x0400F766 RID: 63334
		internal static int __PropertyOffset_TangentMoveIncidentAngle;

		// Token: 0x0400F767 RID: 63335
		internal static int __PropertyOffset_FrictionSpeedLost;

		// Token: 0x0400F768 RID: 63336
		internal static int __PropertyOffset_bIsTrigger;

		// Token: 0x0400F769 RID: 63337
		internal static int __PropertyOffset_TriggerType;

		// Token: 0x0400F76A RID: 63338
		internal static int __PropertyOffset_bIsSimpleTrigger;

		// Token: 0x0400F76B RID: 63339
		internal static int __PropertyOffset_GateDirection;

		// Token: 0x0400F76C RID: 63340
		internal static int __PropertyOffset_DotProductTolerance;

		// Token: 0x0400F76D RID: 63341
		internal static int __PropertyOffset_IsResetSpeed;

		// Token: 0x0400F76E RID: 63342
		internal static int __PropertyOffset_IsFixPosition;

		// Token: 0x0400F76F RID: 63343
		internal static int __PropertyOffset_TeleportPosition;

		// Token: 0x0400F770 RID: 63344
		internal static int __PropertyOffset_IsRelativePosition;

		// Token: 0x0400F771 RID: 63345
		internal static int __PropertyOffset_DamageId;

		// Token: 0x0400F772 RID: 63346
		internal static int __PropertyOffset_TriggerEffect;

		// Token: 0x0400F773 RID: 63347
		internal static int __PropertyOffset_EffectOffset;

		// Token: 0x0400F774 RID: 63348
		internal static int __PropertyOffset_EffectTarget;

		// Token: 0x0400F775 RID: 63349
		internal static int __PropertyOffset_bIsUseForBattle;

		// Token: 0x0400F776 RID: 63350
		internal static int __PropertyOffset_Buff;

		// Token: 0x0400F777 RID: 63351
		internal static int __PropertyOffset_BuffTarget;

		// Token: 0x0400F778 RID: 63352
		internal static int __PropertyOffset_BuffCD;

		// Token: 0x0400F779 RID: 63353
		internal static int __PropertyOffset_CollisionAudioEvent;
	}
}
