using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x020000BD RID: 189
	[NullableContext(1)]
	public interface ITransform
	{
		// Token: 0x060010E3 RID: 4323
		IVector GetLocation();

		// Token: 0x060010E4 RID: 4324
		void SetLocation(IVector value);

		// Token: 0x060010E5 RID: 4325
		IQuat GetRotation();

		// Token: 0x060010E6 RID: 4326
		void SetRotation(IQuat value);

		// Token: 0x060010E7 RID: 4327
		IVector GetScale3D();

		// Token: 0x060010E8 RID: 4328
		void SetScale3D(IVector value);
	}
}
