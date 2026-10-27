using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008EF RID: 2287
	[UnrealObjectPath("/Script/Engine.BranchFilter")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBranchFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D79 RID: 32121 RVA: 0x000B3D68 File Offset: 0x000B1F68
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBranchFilter._ScriptStructPtr != 0) ? FBranchFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BranchFilter", ref FBranchFilter._ScriptStructPtr);
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06007D7A RID: 32122 RVA: 0x000B3D8C File Offset: 0x000B1F8C
		// (set) Token: 0x06007D7B RID: 32123 RVA: 0x000B3DA0 File Offset: 0x000B1FA0
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchFilter.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchFilter.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06007D7C RID: 32124 RVA: 0x000B3DB5 File Offset: 0x000B1FB5
		// (set) Token: 0x06007D7D RID: 32125 RVA: 0x000B3DC5 File Offset: 0x000B1FC5
		public unsafe int BlendDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchFilter.__PropertyOffset_BlendDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchFilter.__PropertyOffset_BlendDepth) = value;
			}
		}

		// Token: 0x06007D7E RID: 32126 RVA: 0x000B3DD6 File Offset: 0x000B1FD6
		public FBranchFilter()
		{
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x000B3DDE File Offset: 0x000B1FDE
		public FBranchFilter(FName BoneName, int BlendDepth)
		{
			this.BoneName = BoneName;
			this.BlendDepth = BlendDepth;
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x000B3DF4 File Offset: 0x000B1FF4
		protected override IntPtr GetUStructPtr()
		{
			return FBranchFilter.StaticStruct();
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x000B3E00 File Offset: 0x000B2000
		[NullableContext(2)]
		public FBranchFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x000B3E0A File Offset: 0x000B200A
		public FBranchFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x000B3E15 File Offset: 0x000B2015
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBranchFilter(Pointer, false, true);
		}

		// Token: 0x06007D84 RID: 32132 RVA: 0x000B3E1F File Offset: 0x000B201F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBranchFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04003C1F RID: 15391
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BranchFilter";

		// Token: 0x04003C20 RID: 15392
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C21 RID: 15393
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04003C22 RID: 15394
		internal static int __PropertyOffset_BlendDepth;
	}
}
