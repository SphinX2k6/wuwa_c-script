using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000842 RID: 2114
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSlotInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimSlotInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060071E9 RID: 29161 RVA: 0x000A3233 File Offset: 0x000A1433
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSlotInfo._ScriptStructPtr != 0) ? FAnimSlotInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSlotInfo", ref FAnimSlotInfo._ScriptStructPtr);
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x060071EA RID: 29162 RVA: 0x000A3257 File Offset: 0x000A1457
		// (set) Token: 0x060071EB RID: 29163 RVA: 0x000A326B File Offset: 0x000A146B
		public unsafe FName SlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSlotInfo.__PropertyOffset_SlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSlotInfo.__PropertyOffset_SlotName) = value;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x060071EC RID: 29164 RVA: 0x000A3280 File Offset: 0x000A1480
		// (set) Token: 0x060071ED RID: 29165 RVA: 0x000A32C3 File Offset: 0x000A14C3
		public TArray<float> ChannelWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ChannelWeights) == null)
				{
					result = (this._ChannelWeights = new TArray<float>(base.NativePtr + (IntPtr)FAnimSlotInfo.__PropertyOffset_ChannelWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChannelWeights.CopyAssign(value);
			}
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x000A32D1 File Offset: 0x000A14D1
		public FAnimSlotInfo()
		{
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x000A32D9 File Offset: 0x000A14D9
		public FAnimSlotInfo(FName SlotName, TArray<float> ChannelWeights)
		{
			this.SlotName = SlotName;
			this.ChannelWeights = ChannelWeights;
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x000A32EF File Offset: 0x000A14EF
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSlotInfo.StaticStruct();
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x000A32FB File Offset: 0x000A14FB
		[NullableContext(2)]
		public FAnimSlotInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x000A3305 File Offset: 0x000A1505
		public FAnimSlotInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x000A3310 File Offset: 0x000A1510
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSlotInfo(Pointer, false, true);
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x000A331A File Offset: 0x000A151A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSlotInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040036B4 RID: 14004
		public const string __ObjectPath = "/Script/Engine.AnimSlotInfo";

		// Token: 0x040036B5 RID: 14005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036B6 RID: 14006
		internal static int __PropertyOffset_SlotName;

		// Token: 0x040036B7 RID: 14007
		internal static int __PropertyOffset_ChannelWeights;

		// Token: 0x040036B8 RID: 14008
		[Nullable(2)]
		private TArray<float> _ChannelWeights;
	}
}
