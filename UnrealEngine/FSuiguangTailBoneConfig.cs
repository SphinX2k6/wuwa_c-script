using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001685 RID: 5765
	[UnrealObjectPath("/Script/KuroAnim.SuiguangTailBoneConfig")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FSuiguangTailBoneConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014EA6 RID: 85670 RVA: 0x001EBF17 File Offset: 0x001EA117
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSuiguangTailBoneConfig._ScriptStructPtr != 0) ? FSuiguangTailBoneConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.SuiguangTailBoneConfig", ref FSuiguangTailBoneConfig._ScriptStructPtr);
		}

		// Token: 0x170052DB RID: 21211
		// (get) Token: 0x06014EA7 RID: 85671 RVA: 0x001EBF3B File Offset: 0x001EA13B
		// (set) Token: 0x06014EA8 RID: 85672 RVA: 0x001EBF4F File Offset: 0x001EA14F
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x170052DC RID: 21212
		// (get) Token: 0x06014EA9 RID: 85673 RVA: 0x001EBF64 File Offset: 0x001EA164
		// (set) Token: 0x06014EAA RID: 85674 RVA: 0x001EBF74 File Offset: 0x001EA174
		public unsafe float TurnAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_TurnAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_TurnAngle) = value;
			}
		}

		// Token: 0x170052DD RID: 21213
		// (get) Token: 0x06014EAB RID: 85675 RVA: 0x001EBF85 File Offset: 0x001EA185
		// (set) Token: 0x06014EAC RID: 85676 RVA: 0x001EBF95 File Offset: 0x001EA195
		public unsafe float LookUpAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_LookUpAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_LookUpAngle) = value;
			}
		}

		// Token: 0x170052DE RID: 21214
		// (get) Token: 0x06014EAD RID: 85677 RVA: 0x001EBFA6 File Offset: 0x001EA1A6
		// (set) Token: 0x06014EAE RID: 85678 RVA: 0x001EBFBA File Offset: 0x001EA1BA
		public unsafe FVector2D TurnLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_TurnLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_TurnLimit) = value;
			}
		}

		// Token: 0x170052DF RID: 21215
		// (get) Token: 0x06014EAF RID: 85679 RVA: 0x001EBFCF File Offset: 0x001EA1CF
		// (set) Token: 0x06014EB0 RID: 85680 RVA: 0x001EBFE3 File Offset: 0x001EA1E3
		public unsafe FVector2D LookUpLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_LookUpLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_LookUpLimit) = value;
			}
		}

		// Token: 0x170052E0 RID: 21216
		// (get) Token: 0x06014EB1 RID: 85681 RVA: 0x001EBFF8 File Offset: 0x001EA1F8
		// (set) Token: 0x06014EB2 RID: 85682 RVA: 0x001EC008 File Offset: 0x001EA208
		public unsafe float LookUpOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_LookUpOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_LookUpOffset) = value;
			}
		}

		// Token: 0x170052E1 RID: 21217
		// (get) Token: 0x06014EB3 RID: 85683 RVA: 0x001EC019 File Offset: 0x001EA219
		// (set) Token: 0x06014EB4 RID: 85684 RVA: 0x001EC029 File Offset: 0x001EA229
		public unsafe float TurnUpOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_TurnUpOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSuiguangTailBoneConfig.__PropertyOffset_TurnUpOffset) = value;
			}
		}

		// Token: 0x06014EB5 RID: 85685 RVA: 0x001EC03A File Offset: 0x001EA23A
		public FSuiguangTailBoneConfig()
		{
		}

		// Token: 0x06014EB6 RID: 85686 RVA: 0x001EC042 File Offset: 0x001EA242
		public FSuiguangTailBoneConfig(FName BoneName, float TurnAngle, float LookUpAngle, FVector2D TurnLimit, FVector2D LookUpLimit, float LookUpOffset, float TurnUpOffset)
		{
			this.BoneName = BoneName;
			this.TurnAngle = TurnAngle;
			this.LookUpAngle = LookUpAngle;
			this.TurnLimit = TurnLimit;
			this.LookUpLimit = LookUpLimit;
			this.LookUpOffset = LookUpOffset;
			this.TurnUpOffset = TurnUpOffset;
		}

		// Token: 0x06014EB7 RID: 85687 RVA: 0x001EC07F File Offset: 0x001EA27F
		protected override IntPtr GetUStructPtr()
		{
			return FSuiguangTailBoneConfig.StaticStruct();
		}

		// Token: 0x06014EB8 RID: 85688 RVA: 0x001EC08B File Offset: 0x001EA28B
		[NullableContext(2)]
		public FSuiguangTailBoneConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014EB9 RID: 85689 RVA: 0x001EC095 File Offset: 0x001EA295
		public FSuiguangTailBoneConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014EBA RID: 85690 RVA: 0x001EC0A0 File Offset: 0x001EA2A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSuiguangTailBoneConfig(Pointer, false, true);
		}

		// Token: 0x06014EBB RID: 85691 RVA: 0x001EC0AA File Offset: 0x001EA2AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSuiguangTailBoneConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B653 RID: 46675
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.SuiguangTailBoneConfig";

		// Token: 0x0400B654 RID: 46676
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B655 RID: 46677
		internal static int __PropertyOffset_BoneName;

		// Token: 0x0400B656 RID: 46678
		internal static int __PropertyOffset_TurnAngle;

		// Token: 0x0400B657 RID: 46679
		internal static int __PropertyOffset_LookUpAngle;

		// Token: 0x0400B658 RID: 46680
		internal static int __PropertyOffset_TurnLimit;

		// Token: 0x0400B659 RID: 46681
		internal static int __PropertyOffset_LookUpLimit;

		// Token: 0x0400B65A RID: 46682
		internal static int __PropertyOffset_LookUpOffset;

		// Token: 0x0400B65B RID: 46683
		internal static int __PropertyOffset_TurnUpOffset;
	}
}
