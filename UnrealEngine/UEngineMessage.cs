using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AF4 RID: 2804
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EngineMessage")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UEngineMessage : ULocalMessage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600925A RID: 37466 RVA: 0x000D2012 File Offset: 0x000D0212
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngineMessage._ClassPtr;
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600925B RID: 37467 RVA: 0x000D201E File Offset: 0x000D021E
		// (set) Token: 0x0600925C RID: 37468 RVA: 0x000D2032 File Offset: 0x000D0232
		public unsafe string FailedPlaceMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_FailedPlaceMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_FailedPlaceMessage)), value);
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600925D RID: 37469 RVA: 0x000D2047 File Offset: 0x000D0247
		// (set) Token: 0x0600925E RID: 37470 RVA: 0x000D205B File Offset: 0x000D025B
		public unsafe string MaxedOutMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_MaxedOutMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_MaxedOutMessage)), value);
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600925F RID: 37471 RVA: 0x000D2070 File Offset: 0x000D0270
		// (set) Token: 0x06009260 RID: 37472 RVA: 0x000D2084 File Offset: 0x000D0284
		public unsafe string EnteredMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_EnteredMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_EnteredMessage)), value);
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06009261 RID: 37473 RVA: 0x000D2099 File Offset: 0x000D0299
		// (set) Token: 0x06009262 RID: 37474 RVA: 0x000D20AD File Offset: 0x000D02AD
		public unsafe string LeftMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_LeftMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_LeftMessage)), value);
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x06009263 RID: 37475 RVA: 0x000D20C2 File Offset: 0x000D02C2
		// (set) Token: 0x06009264 RID: 37476 RVA: 0x000D20D6 File Offset: 0x000D02D6
		public unsafe string GlobalNameChange
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_GlobalNameChange)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_GlobalNameChange)), value);
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06009265 RID: 37477 RVA: 0x000D20EB File Offset: 0x000D02EB
		// (set) Token: 0x06009266 RID: 37478 RVA: 0x000D20FF File Offset: 0x000D02FF
		public unsafe string SpecEnteredMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_SpecEnteredMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_SpecEnteredMessage)), value);
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06009267 RID: 37479 RVA: 0x000D2114 File Offset: 0x000D0314
		// (set) Token: 0x06009268 RID: 37480 RVA: 0x000D2128 File Offset: 0x000D0328
		public unsafe string NewPlayerMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_NewPlayerMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_NewPlayerMessage)), value);
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x06009269 RID: 37481 RVA: 0x000D213D File Offset: 0x000D033D
		// (set) Token: 0x0600926A RID: 37482 RVA: 0x000D2151 File Offset: 0x000D0351
		public unsafe string NewSpecMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_NewSpecMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEngineMessage.__PropertyOffset_NewSpecMessage)), value);
			}
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x000D2166 File Offset: 0x000D0366
		static UEngineMessage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EngineMessage");
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x000D2174 File Offset: 0x000D0374
		protected UEngineMessage() : this(BuiltinUtils.AllocNativeUObject(UEngineMessage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x000D219C File Offset: 0x000D039C
		protected UEngineMessage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004CD7 RID: 19671
		public new const string __ObjectPath = "/Script/Engine.EngineMessage";

		// Token: 0x04004CD8 RID: 19672
		private static IntPtr _ClassPtr;

		// Token: 0x04004CD9 RID: 19673
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004CDA RID: 19674
		internal static int __PropertyOffset_FailedPlaceMessage;

		// Token: 0x04004CDB RID: 19675
		internal static int __PropertyOffset_MaxedOutMessage;

		// Token: 0x04004CDC RID: 19676
		internal static int __PropertyOffset_EnteredMessage;

		// Token: 0x04004CDD RID: 19677
		internal static int __PropertyOffset_LeftMessage;

		// Token: 0x04004CDE RID: 19678
		internal static int __PropertyOffset_GlobalNameChange;

		// Token: 0x04004CDF RID: 19679
		internal static int __PropertyOffset_SpecEnteredMessage;

		// Token: 0x04004CE0 RID: 19680
		internal static int __PropertyOffset_NewPlayerMessage;

		// Token: 0x04004CE1 RID: 19681
		internal static int __PropertyOffset_NewSpecMessage;
	}
}
