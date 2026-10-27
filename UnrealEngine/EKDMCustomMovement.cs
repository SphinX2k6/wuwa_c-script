using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019D9 RID: 6617
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EKDMCustomMovement")]
	public enum EKDMCustomMovement : byte
	{
		// Token: 0x0400D464 RID: 54372
		Climb,
		// Token: 0x0400D465 RID: 54373
		Swim,
		// Token: 0x0400D466 RID: 54374
		Glide,
		// Token: 0x0400D467 RID: 54375
		Pendulum,
		// Token: 0x0400D468 RID: 54376
		Slide,
		// Token: 0x0400D469 RID: 54377
		UpToWalkOnWater,
		// Token: 0x0400D46A RID: 54378
		Leisure,
		// Token: 0x0400D46B RID: 54379
		Soar,
		// Token: 0x0400D46C RID: 54380
		Ski,
		// Token: 0x0400D46D RID: 54381
		Roll,
		// Token: 0x0400D46E RID: 54382
		Kite,
		// Token: 0x0400D46F RID: 54383
		Ride,
		// Token: 0x0400D470 RID: 54384
		RailSlide,
		// Token: 0x0400D471 RID: 54385
		SplineClimb,
		// Token: 0x0400D472 RID: 54386
		Swing,
		// Token: 0x0400D473 RID: 54387
		Floating,
		// Token: 0x0400D474 RID: 54388
		EKDMCustomMovement_MAX
	}
}
