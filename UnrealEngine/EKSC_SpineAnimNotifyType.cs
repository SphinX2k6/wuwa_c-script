using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CEC RID: 7404
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_SpineAnimNotifyType")]
	public enum EKSC_SpineAnimNotifyType : byte
	{
		// Token: 0x0400F716 RID: 63254
		AddTag,
		// Token: 0x0400F717 RID: 63255
		RemoveTag,
		// Token: 0x0400F718 RID: 63256
		ClearTag,
		// Token: 0x0400F719 RID: 63257
		AddBuff,
		// Token: 0x0400F71A RID: 63258
		RemoveBuff,
		// Token: 0x0400F71B RID: 63259
		RemoveBuffStacks,
		// Token: 0x0400F71C RID: 63260
		CreateBullet,
		// Token: 0x0400F71D RID: 63261
		PlayEffect,
		// Token: 0x0400F71E RID: 63262
		SearchTarget,
		// Token: 0x0400F71F RID: 63263
		ApplyMovement,
		// Token: 0x0400F720 RID: 63264
		Summon,
		// Token: 0x0400F721 RID: 63265
		SetSpeed,
		// Token: 0x0400F722 RID: 63266
		Charge,
		// Token: 0x0400F723 RID: 63267
		MoveRangeLimit,
		// Token: 0x0400F724 RID: 63268
		SetPosition,
		// Token: 0x0400F725 RID: 63269
		ClearShield,
		// Token: 0x0400F726 RID: 63270
		EKSC_MAX
	}
}
