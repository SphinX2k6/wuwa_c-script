using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017E9 RID: 6121
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiAnimSequenceConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroCrowdAiAnimSequenceConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016986 RID: 92550 RVA: 0x0020F928 File Offset: 0x0020DB28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCrowdAiAnimSequenceConfig._ScriptStructPtr != 0) ? FKuroCrowdAiAnimSequenceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCrowdAi.KuroCrowdAiAnimSequenceConfig", ref FKuroCrowdAiAnimSequenceConfig._ScriptStructPtr);
		}

		// Token: 0x17005B4F RID: 23375
		// (get) Token: 0x06016987 RID: 92551 RVA: 0x0020F94C File Offset: 0x0020DB4C
		// (set) Token: 0x06016988 RID: 92552 RVA: 0x0020F95C File Offset: 0x0020DB5C
		public unsafe int AnimIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_AnimIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_AnimIndex) = value;
			}
		}

		// Token: 0x17005B50 RID: 23376
		// (get) Token: 0x06016989 RID: 92553 RVA: 0x0020F96D File Offset: 0x0020DB6D
		// (set) Token: 0x0601698A RID: 92554 RVA: 0x0020F97D File Offset: 0x0020DB7D
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x17005B51 RID: 23377
		// (get) Token: 0x0601698B RID: 92555 RVA: 0x0020F990 File Offset: 0x0020DB90
		// (set) Token: 0x0601698C RID: 92556 RVA: 0x0020F9D3 File Offset: 0x0020DBD3
		public TArray<FKuroCrowdAiAnimNotifyEventConfig> NotifyEventsConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCrowdAiAnimNotifyEventConfig> result;
				if ((result = this._NotifyEventsConfig) == null)
				{
					result = (this._NotifyEventsConfig = new TArray<FKuroCrowdAiAnimNotifyEventConfig>(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_NotifyEventsConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NotifyEventsConfig.CopyAssign(value);
			}
		}

		// Token: 0x0601698D RID: 92557 RVA: 0x0020F9E1 File Offset: 0x0020DBE1
		public FKuroCrowdAiAnimSequenceConfig()
		{
		}

		// Token: 0x0601698E RID: 92558 RVA: 0x0020F9E9 File Offset: 0x0020DBE9
		public FKuroCrowdAiAnimSequenceConfig(int AnimIndex, float BlendInTime, TArray<FKuroCrowdAiAnimNotifyEventConfig> NotifyEventsConfig)
		{
			this.AnimIndex = AnimIndex;
			this.BlendInTime = BlendInTime;
			this.NotifyEventsConfig = NotifyEventsConfig;
		}

		// Token: 0x0601698F RID: 92559 RVA: 0x0020FA06 File Offset: 0x0020DC06
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCrowdAiAnimSequenceConfig.StaticStruct();
		}

		// Token: 0x06016990 RID: 92560 RVA: 0x0020FA12 File Offset: 0x0020DC12
		[NullableContext(2)]
		public FKuroCrowdAiAnimSequenceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016991 RID: 92561 RVA: 0x0020FA1C File Offset: 0x0020DC1C
		public FKuroCrowdAiAnimSequenceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016992 RID: 92562 RVA: 0x0020FA27 File Offset: 0x0020DC27
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCrowdAiAnimSequenceConfig(Pointer, false, true);
		}

		// Token: 0x06016993 RID: 92563 RVA: 0x0020FA31 File Offset: 0x0020DC31
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCrowdAiAnimSequenceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C45E RID: 50270
		public const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiAnimSequenceConfig";

		// Token: 0x0400C45F RID: 50271
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C460 RID: 50272
		internal static int __PropertyOffset_AnimIndex;

		// Token: 0x0400C461 RID: 50273
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x0400C462 RID: 50274
		internal static int __PropertyOffset_NotifyEventsConfig;

		// Token: 0x0400C463 RID: 50275
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCrowdAiAnimNotifyEventConfig> _NotifyEventsConfig;
	}
}
