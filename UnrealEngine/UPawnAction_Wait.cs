using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DC RID: 476
	[UnrealObjectPath("/Script/AIModule.PawnAction_Wait")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UPawnAction_Wait : UPawnAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C1A RID: 7194 RVA: 0x00029E30 File Offset: 0x00028030
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnAction_Wait._ClassPtr;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00029E3C File Offset: 0x0002803C
		public UPawnAction_Wait() : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Wait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00029E64 File Offset: 0x00028064
		[NullableContext(1)]
		public UPawnAction_Wait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Wait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x00029E97 File Offset: 0x00028097
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x00029EA7 File Offset: 0x000280A7
		public unsafe float TimeToWait
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnAction_Wait.__PropertyOffset_TimeToWait);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnAction_Wait.__PropertyOffset_TimeToWait) = value;
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00029EB8 File Offset: 0x000280B8
		static UPawnAction_Wait()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnAction_Wait");
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00029EC6 File Offset: 0x000280C6
		protected UPawnAction_Wait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400091C RID: 2332
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PawnAction_Wait";

		// Token: 0x0400091D RID: 2333
		private static IntPtr _ClassPtr;

		// Token: 0x0400091E RID: 2334
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400091F RID: 2335
		internal static int __PropertyOffset_TimeToWait;
	}
}
