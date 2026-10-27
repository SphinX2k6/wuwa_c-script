using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000840 RID: 2112
	[UnrealObjectPath("/Script/Engine.AnimSlotDesc")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimSlotDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060071D1 RID: 29137 RVA: 0x000A3080 File Offset: 0x000A1280
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSlotDesc._ScriptStructPtr != 0) ? FAnimSlotDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSlotDesc", ref FAnimSlotDesc._ScriptStructPtr);
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x060071D2 RID: 29138 RVA: 0x000A30A4 File Offset: 0x000A12A4
		// (set) Token: 0x060071D3 RID: 29139 RVA: 0x000A30B8 File Offset: 0x000A12B8
		public unsafe FName SlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSlotDesc.__PropertyOffset_SlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSlotDesc.__PropertyOffset_SlotName) = value;
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x060071D4 RID: 29140 RVA: 0x000A30CD File Offset: 0x000A12CD
		// (set) Token: 0x060071D5 RID: 29141 RVA: 0x000A30DD File Offset: 0x000A12DD
		public unsafe int NumChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSlotDesc.__PropertyOffset_NumChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSlotDesc.__PropertyOffset_NumChannels) = value;
			}
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x000A30EE File Offset: 0x000A12EE
		public FAnimSlotDesc()
		{
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x000A30F6 File Offset: 0x000A12F6
		public FAnimSlotDesc(FName SlotName, int NumChannels)
		{
			this.SlotName = SlotName;
			this.NumChannels = NumChannels;
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x000A310C File Offset: 0x000A130C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSlotDesc.StaticStruct();
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x000A3118 File Offset: 0x000A1318
		[NullableContext(2)]
		public FAnimSlotDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x000A3122 File Offset: 0x000A1322
		public FAnimSlotDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x000A312D File Offset: 0x000A132D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSlotDesc(Pointer, false, true);
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x000A3137 File Offset: 0x000A1337
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSlotDesc(Pointer, MemoryOwner);
		}

		// Token: 0x040036AB RID: 13995
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimSlotDesc";

		// Token: 0x040036AC RID: 13996
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036AD RID: 13997
		internal static int __PropertyOffset_SlotName;

		// Token: 0x040036AE RID: 13998
		internal static int __PropertyOffset_NumChannels;
	}
}
