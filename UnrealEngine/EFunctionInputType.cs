using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A75 RID: 2677
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFunctionInputType")]
	public enum EFunctionInputType
	{
		// Token: 0x040047CE RID: 18382
		FunctionInput_Scalar,
		// Token: 0x040047CF RID: 18383
		FunctionInput_Vector2,
		// Token: 0x040047D0 RID: 18384
		FunctionInput_Vector3,
		// Token: 0x040047D1 RID: 18385
		FunctionInput_Vector4,
		// Token: 0x040047D2 RID: 18386
		FunctionInput_Texture2D,
		// Token: 0x040047D3 RID: 18387
		FunctionInput_TextureCube,
		// Token: 0x040047D4 RID: 18388
		FunctionInput_Texture2DArray,
		// Token: 0x040047D5 RID: 18389
		FunctionInput_VolumeTexture,
		// Token: 0x040047D6 RID: 18390
		FunctionInput_StaticBool,
		// Token: 0x040047D7 RID: 18391
		FunctionInput_MaterialAttributes,
		// Token: 0x040047D8 RID: 18392
		FunctionInput_TextureExternal,
		// Token: 0x040047D9 RID: 18393
		FunctionInput_BranchCondition,
		// Token: 0x040047DA RID: 18394
		FunctionInput_MAX
	}
}
