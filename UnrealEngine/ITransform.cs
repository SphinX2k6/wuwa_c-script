using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x020000A2 RID: 162
	[NullableContext(1)]
	public interface ITransform
	{
		// Token: 0x06000C76 RID: 3190
		IVector GetLocation();

		// Token: 0x06000C77 RID: 3191
		void SetLocation(IVector value);

		// Token: 0x06000C78 RID: 3192
		IQuat GetRotation();

		// Token: 0x06000C79 RID: 3193
		void SetRotation(IQuat value);

		// Token: 0x06000C7A RID: 3194
		IVector GetScale3D();

		// Token: 0x06000C7B RID: 3195
		void SetScale3D(IVector value);
	}
}
