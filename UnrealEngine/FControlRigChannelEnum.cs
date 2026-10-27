using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200231B RID: 8987
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieSceneTools.FControlRigChannelEnum")]
	public enum FControlRigChannelEnum : byte
	{
		// Token: 0x04012255 RID: 74325
		Bool,
		// Token: 0x04012256 RID: 74326
		Enum,
		// Token: 0x04012257 RID: 74327
		Integer,
		// Token: 0x04012258 RID: 74328
		Float,
		// Token: 0x04012259 RID: 74329
		Vector2DX,
		// Token: 0x0401225A RID: 74330
		Vector2DY,
		// Token: 0x0401225B RID: 74331
		PositionX,
		// Token: 0x0401225C RID: 74332
		PositionY,
		// Token: 0x0401225D RID: 74333
		PositionZ,
		// Token: 0x0401225E RID: 74334
		RotatorX,
		// Token: 0x0401225F RID: 74335
		RotatorY,
		// Token: 0x04012260 RID: 74336
		RotatorZ,
		// Token: 0x04012261 RID: 74337
		ScaleX,
		// Token: 0x04012262 RID: 74338
		ScaleY,
		// Token: 0x04012263 RID: 74339
		ScaleZ,
		// Token: 0x04012264 RID: 74340
		FControlRigChannelEnum_MAX
	}
}
