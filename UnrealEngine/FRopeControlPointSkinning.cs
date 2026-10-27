using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C75 RID: 7285
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeControlPointSkinning")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRopeControlPointSkinning : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C431 RID: 115761 RVA: 0x0029A8E6 File Offset: 0x00298AE6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRopeControlPointSkinning._ScriptStructPtr != 0) ? FRopeControlPointSkinning._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRopeEffect.RopeControlPointSkinning", ref FRopeControlPointSkinning._ScriptStructPtr);
		}

		// Token: 0x1700723B RID: 29243
		// (get) Token: 0x0601C432 RID: 115762 RVA: 0x0029A90A File Offset: 0x00298B0A
		// (set) Token: 0x0601C433 RID: 115763 RVA: 0x0029A91A File Offset: 0x00298B1A
		public unsafe int BoneIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRopeControlPointSkinning.__PropertyOffset_BoneIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRopeControlPointSkinning.__PropertyOffset_BoneIndex) = value;
			}
		}

		// Token: 0x1700723C RID: 29244
		// (get) Token: 0x0601C434 RID: 115764 RVA: 0x0029A92B File Offset: 0x00298B2B
		// (set) Token: 0x0601C435 RID: 115765 RVA: 0x0029A93F File Offset: 0x00298B3F
		public unsafe FVector BoneLocalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRopeControlPointSkinning.__PropertyOffset_BoneLocalPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRopeControlPointSkinning.__PropertyOffset_BoneLocalPosition) = value;
			}
		}

		// Token: 0x0601C436 RID: 115766 RVA: 0x0029A954 File Offset: 0x00298B54
		public FRopeControlPointSkinning()
		{
		}

		// Token: 0x0601C437 RID: 115767 RVA: 0x0029A95C File Offset: 0x00298B5C
		public FRopeControlPointSkinning(int BoneIndex, FVector BoneLocalPosition)
		{
			this.BoneIndex = BoneIndex;
			this.BoneLocalPosition = BoneLocalPosition;
		}

		// Token: 0x0601C438 RID: 115768 RVA: 0x0029A972 File Offset: 0x00298B72
		protected override IntPtr GetUStructPtr()
		{
			return FRopeControlPointSkinning.StaticStruct();
		}

		// Token: 0x0601C439 RID: 115769 RVA: 0x0029A97E File Offset: 0x00298B7E
		[NullableContext(2)]
		public FRopeControlPointSkinning(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C43A RID: 115770 RVA: 0x0029A988 File Offset: 0x00298B88
		public FRopeControlPointSkinning(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C43B RID: 115771 RVA: 0x0029A993 File Offset: 0x00298B93
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRopeControlPointSkinning(Pointer, false, true);
		}

		// Token: 0x0601C43C RID: 115772 RVA: 0x0029A99D File Offset: 0x00298B9D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRopeControlPointSkinning(Pointer, MemoryOwner);
		}

		// Token: 0x0400F324 RID: 62244
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRopeEffect.RopeControlPointSkinning";

		// Token: 0x0400F325 RID: 62245
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F326 RID: 62246
		internal static int __PropertyOffset_BoneIndex;

		// Token: 0x0400F327 RID: 62247
		internal static int __PropertyOffset_BoneLocalPosition;
	}
}
