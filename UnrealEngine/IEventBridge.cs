using System;

// Token: 0x0200000A RID: 10
public interface IEventBridge
{
	// Token: 0x0600002C RID: 44
	unsafe void Emit(uint eventId, byte* parameterBuffer);
}
