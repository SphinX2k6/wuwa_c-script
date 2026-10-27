using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001683 RID: 5763
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.SpecialBoneShakeData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSpecialBoneShakeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E8C RID: 85644 RVA: 0x001EBD03 File Offset: 0x001E9F03
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpecialBoneShakeData._ScriptStructPtr != 0) ? FSpecialBoneShakeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.SpecialBoneShakeData", ref FSpecialBoneShakeData._ScriptStructPtr);
		}

		// Token: 0x170052D6 RID: 21206
		// (get) Token: 0x06014E8D RID: 85645 RVA: 0x001EBD28 File Offset: 0x001E9F28
		// (set) Token: 0x06014E8E RID: 85646 RVA: 0x001EBD6B File Offset: 0x001E9F6B
		public TArray<FName> Groups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Groups) == null)
				{
					result = (this._Groups = new TArray<FName>(base.NativePtr + (IntPtr)FSpecialBoneShakeData.__PropertyOffset_Groups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Groups.CopyAssign(value);
			}
		}

		// Token: 0x170052D7 RID: 21207
		// (get) Token: 0x06014E8F RID: 85647 RVA: 0x001EBD79 File Offset: 0x001E9F79
		// (set) Token: 0x06014E90 RID: 85648 RVA: 0x001EBD89 File Offset: 0x001E9F89
		public unsafe float Influence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpecialBoneShakeData.__PropertyOffset_Influence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpecialBoneShakeData.__PropertyOffset_Influence) = value;
			}
		}

		// Token: 0x170052D8 RID: 21208
		// (get) Token: 0x06014E91 RID: 85649 RVA: 0x001EBD9A File Offset: 0x001E9F9A
		// (set) Token: 0x06014E92 RID: 85650 RVA: 0x001EBDAA File Offset: 0x001E9FAA
		public unsafe float ShakeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpecialBoneShakeData.__PropertyOffset_ShakeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpecialBoneShakeData.__PropertyOffset_ShakeTime) = value;
			}
		}

		// Token: 0x06014E93 RID: 85651 RVA: 0x001EBDBB File Offset: 0x001E9FBB
		public FSpecialBoneShakeData()
		{
		}

		// Token: 0x06014E94 RID: 85652 RVA: 0x001EBDC3 File Offset: 0x001E9FC3
		public FSpecialBoneShakeData(TArray<FName> Groups, float Influence, float ShakeTime)
		{
			this.Groups = Groups;
			this.Influence = Influence;
			this.ShakeTime = ShakeTime;
		}

		// Token: 0x06014E95 RID: 85653 RVA: 0x001EBDE0 File Offset: 0x001E9FE0
		protected override IntPtr GetUStructPtr()
		{
			return FSpecialBoneShakeData.StaticStruct();
		}

		// Token: 0x06014E96 RID: 85654 RVA: 0x001EBDEC File Offset: 0x001E9FEC
		[NullableContext(2)]
		public FSpecialBoneShakeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E97 RID: 85655 RVA: 0x001EBDF6 File Offset: 0x001E9FF6
		public FSpecialBoneShakeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E98 RID: 85656 RVA: 0x001EBE01 File Offset: 0x001EA001
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpecialBoneShakeData(Pointer, false, true);
		}

		// Token: 0x06014E99 RID: 85657 RVA: 0x001EBE0B File Offset: 0x001EA00B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpecialBoneShakeData(Pointer, MemoryOwner);
		}

		// Token: 0x0400B648 RID: 46664
		public const string __ObjectPath = "/Script/KuroAnim.SpecialBoneShakeData";

		// Token: 0x0400B649 RID: 46665
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B64A RID: 46666
		internal static int __PropertyOffset_Groups;

		// Token: 0x0400B64B RID: 46667
		[Nullable(2)]
		private TArray<FName> _Groups;

		// Token: 0x0400B64C RID: 46668
		internal static int __PropertyOffset_Influence;

		// Token: 0x0400B64D RID: 46669
		internal static int __PropertyOffset_ShakeTime;
	}
}
