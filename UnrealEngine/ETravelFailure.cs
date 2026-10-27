using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA2 RID: 2978
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETravelFailure")]
	public enum ETravelFailure
	{
		// Token: 0x040051FB RID: 20987
		NoLevel,
		// Token: 0x040051FC RID: 20988
		LoadMapFailure,
		// Token: 0x040051FD RID: 20989
		InvalidURL,
		// Token: 0x040051FE RID: 20990
		PackageMissing,
		// Token: 0x040051FF RID: 20991
		PackageVersion,
		// Token: 0x04005200 RID: 20992
		NoDownload,
		// Token: 0x04005201 RID: 20993
		TravelFailure,
		// Token: 0x04005202 RID: 20994
		CheatCommands,
		// Token: 0x04005203 RID: 20995
		PendingNetGameCreateFailure,
		// Token: 0x04005204 RID: 20996
		CloudSaveFailure,
		// Token: 0x04005205 RID: 20997
		ServerTravelFailure,
		// Token: 0x04005206 RID: 20998
		ClientTravelFailure,
		// Token: 0x04005207 RID: 20999
		ETravelFailure_MAX
	}
}
