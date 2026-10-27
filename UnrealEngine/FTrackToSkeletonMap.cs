using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011FB RID: 4603
	[UnrealObjectPath("/Script/Engine.TrackToSkeletonMap")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FTrackToSkeletonMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010F98 RID: 69528 RVA: 0x0018EA21 File Offset: 0x0018CC21
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrackToSkeletonMap._ScriptStructPtr != 0) ? FTrackToSkeletonMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TrackToSkeletonMap", ref FTrackToSkeletonMap._ScriptStructPtr);
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x06010F99 RID: 69529 RVA: 0x0018EA45 File Offset: 0x0018CC45
		// (set) Token: 0x06010F9A RID: 69530 RVA: 0x0018EA55 File Offset: 0x0018CC55
		public unsafe int BoneTreeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrackToSkeletonMap.__PropertyOffset_BoneTreeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrackToSkeletonMap.__PropertyOffset_BoneTreeIndex) = value;
			}
		}

		// Token: 0x06010F9B RID: 69531 RVA: 0x0018EA66 File Offset: 0x0018CC66
		public FTrackToSkeletonMap()
		{
		}

		// Token: 0x06010F9C RID: 69532 RVA: 0x0018EA6E File Offset: 0x0018CC6E
		public FTrackToSkeletonMap(int BoneTreeIndex)
		{
			this.BoneTreeIndex = BoneTreeIndex;
		}

		// Token: 0x06010F9D RID: 69533 RVA: 0x0018EA7D File Offset: 0x0018CC7D
		protected override IntPtr GetUStructPtr()
		{
			return FTrackToSkeletonMap.StaticStruct();
		}

		// Token: 0x06010F9E RID: 69534 RVA: 0x0018EA89 File Offset: 0x0018CC89
		[NullableContext(2)]
		public FTrackToSkeletonMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010F9F RID: 69535 RVA: 0x0018EA93 File Offset: 0x0018CC93
		public FTrackToSkeletonMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010FA0 RID: 69536 RVA: 0x0018EA9E File Offset: 0x0018CC9E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrackToSkeletonMap(Pointer, false, true);
		}

		// Token: 0x06010FA1 RID: 69537 RVA: 0x0018EAA8 File Offset: 0x0018CCA8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrackToSkeletonMap(Pointer, MemoryOwner);
		}

		// Token: 0x04009175 RID: 37237
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TrackToSkeletonMap";

		// Token: 0x04009176 RID: 37238
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009177 RID: 37239
		internal static int __PropertyOffset_BoneTreeIndex;
	}
}
