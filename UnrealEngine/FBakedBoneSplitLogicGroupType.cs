using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000891 RID: 2193
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitLogicGroupType")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBakedBoneSplitLogicGroupType : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060077F0 RID: 30704 RVA: 0x000ABC22 File Offset: 0x000A9E22
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneSplitLogicGroupType._ScriptStructPtr != 0) ? FBakedBoneSplitLogicGroupType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneSplitLogicGroupType", ref FBakedBoneSplitLogicGroupType._ScriptStructPtr);
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x060077F1 RID: 30705 RVA: 0x000ABC46 File Offset: 0x000A9E46
		// (set) Token: 0x060077F2 RID: 30706 RVA: 0x000ABC5A File Offset: 0x000A9E5A
		[Nullable(2)]
		public unsafe UBakedBoneSplitSingleMeshDA SingleMeshDAPtr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneSplitSingleMeshDA>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitLogicGroupType.__PropertyOffset_SingleMeshDAPtr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneSplitLogicGroupType.__PropertyOffset_SingleMeshDAPtr, value);
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x060077F3 RID: 30707 RVA: 0x000ABC6F File Offset: 0x000A9E6F
		// (set) Token: 0x060077F4 RID: 30708 RVA: 0x000ABC7F File Offset: 0x000A9E7F
		public unsafe int RenderGroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupType.__PropertyOffset_RenderGroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupType.__PropertyOffset_RenderGroupId) = value;
			}
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x000ABC90 File Offset: 0x000A9E90
		public FBakedBoneSplitLogicGroupType()
		{
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x000ABC98 File Offset: 0x000A9E98
		[NullableContext(1)]
		public FBakedBoneSplitLogicGroupType(UBakedBoneSplitSingleMeshDA SingleMeshDAPtr, int RenderGroupId)
		{
			this.SingleMeshDAPtr = SingleMeshDAPtr;
			this.RenderGroupId = RenderGroupId;
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x000ABCAE File Offset: 0x000A9EAE
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneSplitLogicGroupType.StaticStruct();
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x000ABCBA File Offset: 0x000A9EBA
		[NullableContext(2)]
		public FBakedBoneSplitLogicGroupType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x000ABCC4 File Offset: 0x000A9EC4
		public FBakedBoneSplitLogicGroupType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x000ABCCF File Offset: 0x000A9ECF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneSplitLogicGroupType(Pointer, false, true);
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x000ABCD9 File Offset: 0x000A9ED9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneSplitLogicGroupType(Pointer, MemoryOwner);
		}

		// Token: 0x04003999 RID: 14745
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BakedBoneSplitLogicGroupType";

		// Token: 0x0400399A RID: 14746
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400399B RID: 14747
		internal static int __PropertyOffset_SingleMeshDAPtr;

		// Token: 0x0400399C RID: 14748
		internal static int __PropertyOffset_RenderGroupId;
	}
}
