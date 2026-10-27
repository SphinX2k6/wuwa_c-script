using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011BD RID: 4541
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SupportedSubTrackInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSupportedSubTrackInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010BE5 RID: 68581 RVA: 0x001893EC File Offset: 0x001875EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSupportedSubTrackInfo._ScriptStructPtr != 0) ? FSupportedSubTrackInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SupportedSubTrackInfo", ref FSupportedSubTrackInfo._ScriptStructPtr);
		}

		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x06010BE6 RID: 68582 RVA: 0x00189410 File Offset: 0x00187610
		// (set) Token: 0x06010BE7 RID: 68583 RVA: 0x00189424 File Offset: 0x00187624
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UInterpTrack> SupportedClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FSupportedSubTrackInfo.__PropertyOffset_SupportedClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FSupportedSubTrackInfo.__PropertyOffset_SupportedClass) = value;
			}
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x06010BE8 RID: 68584 RVA: 0x00189439 File Offset: 0x00187639
		// (set) Token: 0x06010BE9 RID: 68585 RVA: 0x0018944D File Offset: 0x0018764D
		public unsafe string SubTrackName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSupportedSubTrackInfo.__PropertyOffset_SubTrackName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSupportedSubTrackInfo.__PropertyOffset_SubTrackName)), value);
			}
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x06010BEA RID: 68586 RVA: 0x00189462 File Offset: 0x00187662
		// (set) Token: 0x06010BEB RID: 68587 RVA: 0x00189472 File Offset: 0x00187672
		public unsafe int GroupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSupportedSubTrackInfo.__PropertyOffset_GroupIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSupportedSubTrackInfo.__PropertyOffset_GroupIndex) = value;
			}
		}

		// Token: 0x06010BEC RID: 68588 RVA: 0x00189483 File Offset: 0x00187683
		public FSupportedSubTrackInfo()
		{
		}

		// Token: 0x06010BED RID: 68589 RVA: 0x0018948B File Offset: 0x0018768B
		public FSupportedSubTrackInfo([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UInterpTrack> SupportedClass, string SubTrackName, int GroupIndex)
		{
			this.SupportedClass = SupportedClass;
			this.SubTrackName = SubTrackName;
			this.GroupIndex = GroupIndex;
		}

		// Token: 0x06010BEE RID: 68590 RVA: 0x001894A8 File Offset: 0x001876A8
		protected override IntPtr GetUStructPtr()
		{
			return FSupportedSubTrackInfo.StaticStruct();
		}

		// Token: 0x06010BEF RID: 68591 RVA: 0x001894B4 File Offset: 0x001876B4
		[NullableContext(2)]
		public FSupportedSubTrackInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010BF0 RID: 68592 RVA: 0x001894BE File Offset: 0x001876BE
		public FSupportedSubTrackInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010BF1 RID: 68593 RVA: 0x001894C9 File Offset: 0x001876C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSupportedSubTrackInfo(Pointer, false, true);
		}

		// Token: 0x06010BF2 RID: 68594 RVA: 0x001894D3 File Offset: 0x001876D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSupportedSubTrackInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008F32 RID: 36658
		public const string __ObjectPath = "/Script/Engine.SupportedSubTrackInfo";

		// Token: 0x04008F33 RID: 36659
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008F34 RID: 36660
		internal static int __PropertyOffset_SupportedClass;

		// Token: 0x04008F35 RID: 36661
		internal static int __PropertyOffset_SubTrackName;

		// Token: 0x04008F36 RID: 36662
		internal static int __PropertyOffset_GroupIndex;
	}
}
