using System;

namespace System.Text.Json
{
	// Token: 0x0200004F RID: 79
	internal enum StackFrameObjectState : byte
	{
		// Token: 0x04000156 RID: 342
		None,
		// Token: 0x04000157 RID: 343
		StartToken,
		// Token: 0x04000158 RID: 344
		ReadMetadata,
		// Token: 0x04000159 RID: 345
		ConstructorArguments,
		// Token: 0x0400015A RID: 346
		CreatedObject,
		// Token: 0x0400015B RID: 347
		ReadElements,
		// Token: 0x0400015C RID: 348
		EndToken,
		// Token: 0x0400015D RID: 349
		EndTokenValidation
	}
}
