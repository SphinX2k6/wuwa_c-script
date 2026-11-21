using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200029D RID: 669
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.TextureMipGenSettings")]
	public enum TextureMipGenSettings
	{
		// Token: 0x04001CD5 RID: 7381
		TMGS_FromTextureGroup,
		// Token: 0x04001CD6 RID: 7382
		TMGS_SimpleAverage,
		// Token: 0x04001CD7 RID: 7383
		TMGS_Sharpen0,
		// Token: 0x04001CD8 RID: 7384
		TMGS_Sharpen1,
		// Token: 0x04001CD9 RID: 7385
		TMGS_Sharpen2,
		// Token: 0x04001CDA RID: 7386
		TMGS_Sharpen3,
		// Token: 0x04001CDB RID: 7387
		TMGS_Sharpen4,
		// Token: 0x04001CDC RID: 7388
		TMGS_Sharpen5,
		// Token: 0x04001CDD RID: 7389
		TMGS_Sharpen6,
		// Token: 0x04001CDE RID: 7390
		TMGS_Sharpen7,
		// Token: 0x04001CDF RID: 7391
		TMGS_Sharpen8,
		// Token: 0x04001CE0 RID: 7392
		TMGS_Sharpen9,
		// Token: 0x04001CE1 RID: 7393
		TMGS_Sharpen10,
		// Token: 0x04001CE2 RID: 7394
		TMGS_NoMipmaps,
		// Token: 0x04001CE3 RID: 7395
		TMGS_LeaveExistingMips,
		// Token: 0x04001CE4 RID: 7396
		TMGS_Blur1,
		// Token: 0x04001CE5 RID: 7397
		TMGS_Blur2,
		// Token: 0x04001CE6 RID: 7398
		TMGS_Blur3,
		// Token: 0x04001CE7 RID: 7399
		TMGS_Blur4,
		// Token: 0x04001CE8 RID: 7400
		TMGS_Blur5,
		// Token: 0x04001CE9 RID: 7401
		TMGS_Unfiltered,
		// Token: 0x04001CEA RID: 7402
		TMGS_BuildFromSourceImage,
		// Token: 0x04001CEB RID: 7403
		TMGS_MAX
	}
}
