using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000183 RID: 387
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimTrack")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060018DB RID: 6363 RVA: 0x00025AA9 File Offset: 0x00023CA9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimTrack._ScriptStructPtr != 0) ? FAnimTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimTrack", ref FAnimTrack._ScriptStructPtr);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00025AD0 File Offset: 0x00023CD0
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x00025B13 File Offset: 0x00023D13
		public TArray<FAnimSegment> AnimSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimSegment> result;
				if ((result = this._AnimSegments) == null)
				{
					result = (this._AnimSegments = new TArray<FAnimSegment>(base.NativePtr + (IntPtr)FAnimTrack.__PropertyOffset_AnimSegments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimSegments.CopyAssign(value);
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00025B21 File Offset: 0x00023D21
		public FAnimTrack()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00025B29 File Offset: 0x00023D29
		protected override IntPtr GetUStructPtr()
		{
			return FAnimTrack.StaticStruct();
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00025B35 File Offset: 0x00023D35
		[NullableContext(2)]
		public FAnimTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00025B3F File Offset: 0x00023D3F
		public FAnimTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00025B4A File Offset: 0x00023D4A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimTrack(Pointer, false, true);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00025B54 File Offset: 0x00023D54
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040007E5 RID: 2021
		public const string __ObjectPath = "/Script/Engine.AnimTrack";

		// Token: 0x040007E6 RID: 2022
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040007E7 RID: 2023
		internal static int __PropertyOffset_AnimSegments;

		// Token: 0x040007E8 RID: 2024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimSegment> _AnimSegments;
	}
}
