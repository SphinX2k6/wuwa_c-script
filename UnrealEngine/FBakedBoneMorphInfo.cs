using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000884 RID: 2180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMorphInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBakedBoneMorphInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007748 RID: 30536 RVA: 0x000AACCF File Offset: 0x000A8ECF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneMorphInfo._ScriptStructPtr != 0) ? FBakedBoneMorphInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneMorphInfo", ref FBakedBoneMorphInfo._ScriptStructPtr);
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06007749 RID: 30537 RVA: 0x000AACF3 File Offset: 0x000A8EF3
		// (set) Token: 0x0600774A RID: 30538 RVA: 0x000AAD03 File Offset: 0x000A8F03
		public unsafe float AnimIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneMorphInfo.__PropertyOffset_AnimIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneMorphInfo.__PropertyOffset_AnimIndex) = value;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x0600774B RID: 30539 RVA: 0x000AAD14 File Offset: 0x000A8F14
		// (set) Token: 0x0600774C RID: 30540 RVA: 0x000AAD57 File Offset: 0x000A8F57
		public TArray<FBakedBoneMorphSectionInfo> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneMorphSectionInfo> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<FBakedBoneMorphSectionInfo>(base.NativePtr + (IntPtr)FBakedBoneMorphInfo.__PropertyOffset_Sections, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x000AAD65 File Offset: 0x000A8F65
		public FBakedBoneMorphInfo()
		{
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x000AAD6D File Offset: 0x000A8F6D
		public FBakedBoneMorphInfo(float AnimIndex, TArray<FBakedBoneMorphSectionInfo> Sections)
		{
			this.AnimIndex = AnimIndex;
			this.Sections = Sections;
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x000AAD83 File Offset: 0x000A8F83
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneMorphInfo.StaticStruct();
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x000AAD8F File Offset: 0x000A8F8F
		[NullableContext(2)]
		public FBakedBoneMorphInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x000AAD99 File Offset: 0x000A8F99
		public FBakedBoneMorphInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x000AADA4 File Offset: 0x000A8FA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneMorphInfo(Pointer, false, true);
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x000AADAE File Offset: 0x000A8FAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneMorphInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003944 RID: 14660
		public const string __ObjectPath = "/Script/Engine.BakedBoneMorphInfo";

		// Token: 0x04003945 RID: 14661
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003946 RID: 14662
		internal static int __PropertyOffset_AnimIndex;

		// Token: 0x04003947 RID: 14663
		internal static int __PropertyOffset_Sections;

		// Token: 0x04003948 RID: 14664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneMorphSectionInfo> _Sections;
	}
}
