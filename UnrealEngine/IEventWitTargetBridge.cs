using System;

// Token: 0x02000013 RID: 19
public interface IEventWitTargetBridge
{
	// Token: 0x06000044 RID: 68
	unsafe void Emit(uint eventId, int targetId, byte* parameterBuffer);
}
