using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BB5 RID: 7093
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsCellRange")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FKuroSeasonsCellRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B239 RID: 111161 RVA: 0x0027FDD4 File Offset: 0x0027DFD4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSeasonsCellRange._ScriptStructPtr != 0) ? FKuroSeasonsCellRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsCellRange", ref FKuroSeasonsCellRange._ScriptStructPtr);
		}

		// Token: 0x17006CD8 RID: 27864
		// (get) Token: 0x0601B23A RID: 111162 RVA: 0x0027FDF8 File Offset: 0x0027DFF8
		// (set) Token: 0x0601B23B RID: 111163 RVA: 0x0027FE08 File Offset: 0x0027E008
		public unsafe int Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSeasonsCellRange.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSeasonsCellRange.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17006CD9 RID: 27865
		// (get) Token: 0x0601B23C RID: 111164 RVA: 0x0027FE19 File Offset: 0x0027E019
		// (set) Token: 0x0601B23D RID: 111165 RVA: 0x0027FE29 File Offset: 0x0027E029
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSeasonsCellRange.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSeasonsCellRange.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x0601B23E RID: 111166 RVA: 0x0027FE3A File Offset: 0x0027E03A
		public FKuroSeasonsCellRange()
		{
		}

		// Token: 0x0601B23F RID: 111167 RVA: 0x0027FE42 File Offset: 0x0027E042
		public FKuroSeasonsCellRange(int Offset, int Count)
		{
			this.Offset = Offset;
			this.Count = Count;
		}

		// Token: 0x0601B240 RID: 111168 RVA: 0x0027FE58 File Offset: 0x0027E058
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSeasonsCellRange.StaticStruct();
		}

		// Token: 0x0601B241 RID: 111169 RVA: 0x0027FE64 File Offset: 0x0027E064
		[NullableContext(2)]
		public FKuroSeasonsCellRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B242 RID: 111170 RVA: 0x0027FE6E File Offset: 0x0027E06E
		public FKuroSeasonsCellRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B243 RID: 111171 RVA: 0x0027FE79 File Offset: 0x0027E079
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSeasonsCellRange(Pointer, false, true);
		}

		// Token: 0x0601B244 RID: 111172 RVA: 0x0027FE83 File Offset: 0x0027E083
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSeasonsCellRange(Pointer, MemoryOwner);
		}

		// Token: 0x0400E9D8 RID: 59864
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsCellRange";

		// Token: 0x0400E9D9 RID: 59865
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E9DA RID: 59866
		internal static int __PropertyOffset_Offset;

		// Token: 0x0400E9DB RID: 59867
		internal static int __PropertyOffset_Count;
	}
}
